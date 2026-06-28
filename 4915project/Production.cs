using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace _4915project
{
    public partial class Production : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        public Production()
        {
            InitializeComponent();
        }

        private void Production_Load(object sender, EventArgs e)
        {
            getSN();
            getRequest();
            SetupWelcomeMessage();
            cmbUrgency.Items.AddRange(new string[] { "Low", "High" });
            cmbRequestStatus.Items.AddRange(new string[] { "Approved", "In Progress", "Completed" });

        }
        private void SetupWelcomeMessage()
        {
            string displayName = string.IsNullOrWhiteSpace(CurrentUser.Username) ? "User" : CurrentUser.Username;
            string rolePart = string.IsNullOrWhiteSpace(CurrentUser.Role) ? "" : $" ({CurrentUser.Role})";
            this.lblWelcome.Text = $"Welcome, {displayName}{rolePart}!";
        }

        private void getSN()
        {
            // 💡 修正 1：移除 so.Status 後方多餘的逗號
            string query = @"
            SELECT 
                so.OrderID,
                c.Name AS CustomerName,
                so.Status,
                so.RequestDeliveryDate
            FROM salesorder so
            LEFT JOIN customer c ON so.CustomerID = c.CustomerID
            LEFT JOIN shipment s ON s.OrderID = so.OrderID
            LEFT JOIN deliveryitem d ON d.ShipmentID = s.ShipmentID
            WHERE d.SerialNumber IS NULL
            ORDER BY so.OrderID ASC;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        DataTable dt = new DataTable();

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        // 1. 綁定 DataGridView
                        dataGridView1.DataSource = dt;

                        // 2. 清空舊的下拉選單項目（避免重複呼叫時項目疊加）
                        cmbOrderID.Items.Clear();
                        cmbCust.Items.Clear();
                        cmbStatus.Items.Clear();

                        // 💡 修正 2：直接利用記憶體中的 DataTable 跑迴圈，不重複讀取 Reader，效能更好
                        foreach (DataRow row in dt.Rows)
                        {
                            string orderId = row["OrderID"].ToString();
                            string custName = row["CustomerName"].ToString();
                            string status = row["Status"].ToString();

                            // 💡 只有在選單中不存在時，才塞入項目（達到去重效果）
                            if (!cmbOrderID.Items.Contains(orderId))
                            {
                                cmbOrderID.Items.Add(orderId);
                            }

                            if (!cmbCust.Items.Contains(custName))
                            {
                                cmbCust.Items.Add(custName);
                            }

                            if (!cmbStatus.Items.Contains(status))
                            {
                                cmbStatus.Items.Add(status);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("System error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Close();
        }

        private void btSales_Click(object sender, EventArgs e)
        {
            SalesOrder salesOrder = new SalesOrder();
            salesOrder.Show();
            this.Close();
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            FormLogistics logistics = new FormLogistics();
            logistics.Show();
            this.Close();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Close();
        }

        private void btAfterSales_Click(object sender, EventArgs e)
        {
            AfterSales afterSales = new AfterSales();
            afterSales.Show();
            this.Close();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            FormSetting setting = new FormSetting();
            setting.Show();
        }

        private void btSNClear_Click(object sender, EventArgs e)
        {
            cmbCust.SelectedIndex = -1;
            cmbOrderID.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        private void btSNReflash_Click(object sender, EventArgs e)
        {
            getSN();
        }

        private void btSNSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // 1. 基本 SQL 語句
                    string query = @"
            SELECT 
                so.OrderID,
                c.Name AS CustomerName,
                so.Status,
                so.RequestDeliveryDate
            FROM salesorder so
            LEFT JOIN customer c ON so.CustomerID = c.CustomerID
            LEFT JOIN shipment s ON s.OrderID = so.OrderID
            LEFT JOIN deliveryitem d ON d.ShipmentID = s.ShipmentID
            WHERE d.SerialNumber IS NULL ";

                    // 2. 根據下拉選單是否有選值，動態拼接 SQL 條件
                    if (cmbOrderID.SelectedIndex != -1)
                    {
                        query += " AND so.OrderID = @OrderID ";
                    }
                    if (cmbCust.SelectedIndex != -1)
                    {
                        query += " AND c.Name = @CustomerName ";
                    }
                    if (cmbStatus.SelectedIndex != -1)
                    {
                        query += " AND so.Status = @Status ";
                    }

                    // 加上原本的日期區間條件與排序
                    query += " AND so.RequestDeliveryDate >= @StartDate AND so.RequestDeliveryDate <= @EndDate ";
                    query += " ORDER BY so.OrderID ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // 3. 綁定動態條件的參數數值
                        if (cmbOrderID.SelectedIndex != -1)
                        {
                            cmd.Parameters.AddWithValue("@OrderID", cmbOrderID.SelectedItem.ToString());
                        }
                        if (cmbCust.SelectedIndex != -1)
                        {
                            cmd.Parameters.AddWithValue("@CustomerName", cmbCust.SelectedItem.ToString());
                        }
                        if (cmbStatus.SelectedIndex != -1)
                        {
                            cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                        }

                        // 💡 提示：請確保您的表單上有這兩個日期控制項（例如 DateTimePicker），此處數值需依據實況調整
                        cmd.Parameters.AddWithValue("@StartDate", StartDate.Value.Date);
                        cmd.Parameters.AddWithValue("@EndDate", EndDate.Value.Date);

                        // 4. 執行查詢並更新介面
                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query failed:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btLinkSN_Click(object sender, EventArgs e)
        {
            LinkSNtoOrder linkSNtoOrder = new LinkSNtoOrder();
            linkSNtoOrder.Show();
        }

        private void Logoutbt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {


                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();

                    // Optional: You can still verify user exists, but usually not necessary for logout
                    string query = @"
                SELECT userid, name FROM user 
                WHERE userid = @UserId 
                LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32("userid");
                                string username = reader["name"]?.ToString() ?? "Unknown";

                                // Log the audit
                                AuditHelper.Log(
                                    tableName: "user",
                                    recordId: userId.ToString(),
                                    action: "LOGOUT",
                                    userId: userId,
                                    username: username,
                                    description: $"User {username} logged out"
                                );
                            }
                        }
                    }
                }

                // Logout from application
                CurrentUser.Logout();

                MessageBox.Show("Logout successful!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Logout error: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cmbRequestID.SelectedIndex = -1;
            cmbUser.SelectedIndex = -1;
            cmbUrgency.SelectedIndex = -1;
            cmbRequestStatus.SelectedIndex = -1;
            requestStartDate.Value = DateTime.Now;
            requestEndDate.Value = DateTime.Now;
            getRequest();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MaterialRequest materialRequest = new MaterialRequest();
            materialRequest.Show();
        }

        private void getRequest()
        {
            string query = @"
    SELECT 
        m.RequestID,
        u.Name,
        m.BatchID,
        m.RequestDate,
        m.RequestByDate,
        m.Urgency,
        m.Status
    FROM materialrequest m
    INNER JOIN user u ON u.UserID = m.UserID
    ORDER BY m.RequestID ASC;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        // DataAdapter 會自動開關連線，不需要手動 con.Open()
                        da.Fill(dt);
                    }

                    // 1. 先將完整的資料綁定到 DataGridView 顯示
                    dataGridView2.DataSource = dt;

                    // 2. 清空 ComboBox 舊有的資料，避免重複重疊
                    cmbRequestID.Items.Clear();
                    cmbUser.Items.Clear();

                    // 3. 在索引 0 插入預設的「全部」選項（對應你前面寫的 Index > 0 篩選）
                    cmbRequestID.Items.Add("-- All IDs --");
                    cmbUser.Items.Add("-- All Users --");

                    // 4. 利用 DataView 技術，直接在記憶體中進行「去重複 (Distinct)」並排序

                    // 提取不重複的 RequestID
                    DataView viewRequest = new DataView(dt);
                    DataTable dtDistinctRequest = viewRequest.ToTable(true, "RequestID");
                    foreach (DataRow row in dtDistinctRequest.Rows)
                    {
                        cmbRequestID.Items.Add(row["RequestID"].ToString());
                    }

                    // 提取不重複的 User Name
                    DataView viewUser = new DataView(dt);
                    DataTable dtDistinctUser = viewUser.ToTable(true, "Name");
                    // 排序人名，讓下拉選單更好找
                    dtDistinctUser.DefaultView.Sort = "Name ASC";
                    DataTable dtSortedUser = dtDistinctUser.DefaultView.ToTable();

                    foreach (DataRow row in dtSortedUser.Rows)
                    {
                        cmbUser.Items.Add(row["Name"].ToString());
                    }

                    // 5. 預設選取第一個選項 (-- All --)
                    cmbRequestID.SelectedIndex = 0;
                    cmbUser.SelectedIndex = 0;
                }
            }
        }

        private void btSearchRequest_Click(object sender, EventArgs e)
        {
            // 1. 基本 SQL 主體：先進行 JOIN，並用 WHERE 1=1 作為動態拼接的安全起點
            string query = @"
    SELECT 
        m.RequestID,
        u.Name,
        m.BatchID,
        m.RequestDate,
        m.RequestByDate,
        m.Urgency,
        m.Status
    FROM materialrequest m
    INNER JOIN user u ON u.UserID = m.UserID
    WHERE 1=1";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;

                    // 2. 動態拼接欄位與安全綁定參數

                    // 【修正】改為 > 0，有效排除 -1 (未選) 與 0 (預設/全部)
                    if (cmbRequestID.SelectedIndex > 0)
                    {
                        query += " AND m.RequestID = @RID";
                        cmd.Parameters.AddWithValue("@RID", cmbRequestID.SelectedItem.ToString());
                    }

                    // 【修正】改為 > 0，避免 SelectedItem 為 null 時呼叫 ToString() 導致崩潰
                    if (cmbUser.SelectedIndex > 0)
                    {
                        query += " AND u.Name LIKE @Uname";
                        cmd.Parameters.AddWithValue("@Uname", "%" + cmbUser.SelectedItem.ToString() + "%");
                    }

                    // 篩選緊急程度 (下拉選單有選取時)
                    if (cmbUrgency.SelectedItem != null && !string.IsNullOrWhiteSpace(cmbUrgency.SelectedItem.ToString()))
                    {
                        query += " AND m.Urgency = @Urgency";
                        cmd.Parameters.AddWithValue("@Urgency", cmbUrgency.SelectedItem.ToString());
                    }

                    // 篩選狀態 (下拉選單有選取時)
                    if (cmbStatus.SelectedItem != null && !string.IsNullOrWhiteSpace(cmbStatus.SelectedItem.ToString()))
                    {
                        query += " AND m.Status = @Status";
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                    }

                    // 3. 拼接日期範圍（包含結束日的整天）
                    query += " AND m.RequestDate >= @startDate AND m.RequestDate <= @EndDate";
                    cmd.Parameters.AddWithValue("@startDate", requestStartDate.Value.Date); // 00:00:00
                    cmd.Parameters.AddWithValue("@EndDate", requestEndDate.Value.Date.AddDays(1).AddSeconds(-1)); // 23:59:59

                    // 4. 加上排序並賦值
                    query += " ORDER BY m.RequestID ASC;";
                    cmd.CommandText = query;

                    try
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // 更新畫面控制項
                        dataGridView2.DataSource = dt;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Search failed: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. 防呆：確保點擊的是有效資料列，而不是標頭欄（Header Row 索引為 -1）
            if (e.RowIndex < 0) return;

            // 2. 獲取點擊列的 RequestID (請確保欄位名稱 "RequestID" 與你主表的 SQL 查詢欄位一致)
            object cellValue = dataGridView2.Rows[e.RowIndex].Cells["RequestID"].Value;

            if (cellValue == null || cellValue == DBNull.Value) return;

            string selectedRequestID = cellValue.ToString();

            // 3. 去資料庫查詢對應的明細資料 (從表)
            // 提示：請根據你實際的資料表名稱與欄位修改此 SQL 語句
            string detailQuery = @"
        SELECT 
        *
        FROM materialrequestitem 
        WHERE RequestID = @RequestID;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(detailQuery, con))
                {
                    // 安全綁定主鍵參數
                    cmd.Parameters.AddWithValue("@RequestID", selectedRequestID);

                    try
                    {
                        // 使用 DataAdapter 自動填充資料至第二個 DataGridView
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // 將明細顯示在另一個 DataGridView 上
                        dataGridView3.DataSource = dt;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Failed to load details: " + ex.Message);
                    }
                }
            }
        }

        private void btRawMaterial_Click(object sender, EventArgs e)
        {
            RawMaterial rawMaterial = new RawMaterial();
            rawMaterial.Show();
            this.Close();
        }
    }
}
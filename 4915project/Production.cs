using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
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
            SetupWelcomeMessage();
            getRequestID();
            genRequestID();
            getBatchID();
            getUser();
            genRequestItemID();
            getMaterialName();
            cmbUrgency.Items.AddRange(new string[] { "Low", "High" });
            cmbRequestStatus.Items.AddRange(new string[] { "In Progress", "Completed" });
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
        private void getRequestID()
        {
            string query = @"Select RequestID from materialrequest order by RequestID ASC";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbRequestID.Items.Add(reader["RequestID"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("System error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void genRequestID()
        {
            // 💡 修正 1：SQL 補上 LIKE @Prefix 篩選，並將 LIMIT BY 1 改為正確的 LIMIT 1
            string query = @"
        SELECT RequestID 
        FROM materialrequest 
        WHERE RequestID LIKE @Prefix 
        ORDER BY RequestID DESC 
        LIMIT 1;";

            string prefix = "REQ";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // 💡 修正 2：現在 SQL 內有 @Prefix 了，這裡的參數綁定才會生效
                    cmd.Parameters.AddWithValue("@Prefix", prefix + "%");

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        int nextNumber = 1;

                        if (result != null && result != DBNull.Value)
                        {
                            string lastOrderID = result.ToString();

                            // 防呆：確保字串長度大於前置詞（3碼），才去切取後方的流水號
                            if (lastOrderID.Length > prefix.Length)
                            {
                                // 💡 優化：直接從前置詞長度之後開始切到尾，避免硬編碼數字導致算錯
                                string lastNumberStr = lastOrderID.Substring(prefix.Length);

                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1;
                                }
                            }
                        }

                        string newRequestID = prefix + nextNumber.ToString("D3");

                        // 將新單號帶入控制項
                        cmbRequestID.Text = newRequestID;

                        // 避免重複加入
                        if (!cmbRequestID.Items.Contains(newRequestID))
                        {
                            cmbRequestID.Items.Add(newRequestID);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Unable to retrieve database serial number:" + ex.Message);
                        MessageBox.Show("Order number cannot be generated automatically. Please enter it manually or try again later.", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void getBatchID()
        {
            string query = @"Select BatchID from productionbatch order by BatchID ASC";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbBatchID.Items.Add(reader["BatchID"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("System error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void getUser()
        {
            string query = @"SELECT Name From User;";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbRequestBy.Items.Add(reader["Name"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("System error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmbRequestID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRequestID.SelectedIndex == -1) return;

            string query = @"
    SELECT 
        m.BatchID, 
        u.Name AS UserName, 
        m.RequestDate, 
        m.Urgency, 
        m.Status, 
        m.RequestByDate
    FROM materialrequest m
    INNER JOIN User u ON m.UserID = u.UserID
    WHERE m.RequestID = @RequestID;";

            string query2 = @"SELECT * FROM materialrequestitem WHERE RequestID = @RequestID;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // ==================== 1. 讀取主檔資料 (使用 DataReader) ====================
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RequestID", cmbRequestID.SelectedItem?.ToString());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cmbBatchID.Text = reader["BatchID"].ToString();
                                RequestDate.Text = reader["RequestDate"].ToString();
                                cmbUrgency.Text = reader["Urgency"].ToString();
                                cmbRequestStatus.Text = reader["Status"].ToString();
                                RequestByDate.Text = reader["RequestByDate"].ToString();
                                cmbRequestBy.Text = reader["UserName"].ToString();
                            }
                        } // 👈 這裡的 using 結束，第一個 reader 會被徹底關閉並釋放連線
                    }

                    // ==================== 2. 讀取明細資料 (直接用 DataAdapter，不開 Reader) ====================
                    DataTable dt = new DataTable();
                    using (MySqlCommand cmd2 = new MySqlCommand(query2, con))
                    {
                        cmd2.Parameters.AddWithValue("@RequestID", cmbRequestID.SelectedItem?.ToString());

                        // 💡 關鍵優化：直接交給 DataAdapter 處理，它會內部自己管好連線，不會有任何衝突
                        using (MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2))
                        {
                            da2.Fill(dt);
                        }
                    }

                    // ==================== 3. 根據明細有無，控制介面 UI 狀態 ====================
                    if (dt.Rows.Count > 0)
                    {
                        // 💡 有明細資料：將明細表格綁定，並鎖定輸入控制項（唯讀模式）
                        dataGridView2.DataSource = dt;

                        tbRequestItemID.Enabled = false;
                        QuantityRequested.Enabled = false;
                        cmbMaterialName.Enabled = false;
                        btAdd.Enabled = false;
                        QuantityApproved.Enabled = false;
                        QuantityIssued.Enabled = false;
                    }
                    else
                    {
                        // 💡 沒有明細資料：清空 DataGridView 並解除鎖定，允許使用者新增品項
                        dataGridView2.DataSource = null;
                        tbRequestItemID.Enabled = true;

                        // 如果需要，其他控制項也可以在這裡設為 true 恢復編輯
                        QuantityRequested.Enabled = true;
                        cmbMaterialName.Enabled = true;
                        btAdd.Enabled = true;
                        QuantityApproved.Enabled = true;
                        QuantityIssued.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to read application form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } // 💡 修正 3：補齊方法的大括號
        private void genRequestItemID()
        {
            string query = @"
            SELECT RequestItemID FROM materialrequestitem 
            WHERE RequestItemID LIKE @Prefix 
            ORDER BY RequestItemID DESC 
            LIMIT 1;";

            string prefix = "RITEM";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Prefix", prefix + "%");

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        int nextNumber = 1;

                        if (result != null && result != DBNull.Value)
                        {
                            string lastItemID = result.ToString();

                            if (lastItemID.Length > prefix.Length)
                            {
                                string lastNumberStr = lastItemID.Substring(prefix.Length);

                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1;
                                }
                            }
                        }

                        string newRequestItemID = prefix + nextNumber.ToString("D3");

                        // 💡 修正 2：將明細單號塞入正確的明細控制項（此處以 tbRequestItemID 為例）
                        tbRequestItemID.Text = newRequestItemID;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Unable to obtain material serial number: " + ex.Message);
                        MessageBox.Show("The detailed order number could not be generated automatically. Please enter it manually or try again later.", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void getMaterialName()
        {
            string query = @"select Name from rawmaterial order by Name ASC";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbMaterialName.Items.Add(reader["Name"]);
                        }
                    }
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // 💡 防呆機制：確保必填欄位都有輸入
            if (string.IsNullOrEmpty(tbRequestItemID.Text) || string.IsNullOrEmpty(cmbRequestID.Text))
            {
                MessageBox.Show("Please confirm that the order number and detail number have been generated!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = @"
        INSERT INTO materialrequestitem 
        (RequestItemID, RequestID, MaterialID, QuantityRequested, QuantityApproved, QuantityIssued) 
        VALUES 
        (@RequestItemID, @RequestID, @MaterialID, @QuantityRequested, @QuantityApproved, @QuantityIssued);";

            string MaterialIDQuery = "SELECT MaterialID FROM rawmaterial WHERE Name = @Name;";
            string query2 = "SELECT * FROM materialrequestitem WHERE RequestID = @RequestID;";

            string MaterialID = "MAT0"; // 預設值

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // 1. 根據物料名稱查詢物料 ID
                    using (MySqlCommand cmd2 = new MySqlCommand(MaterialIDQuery, con))
                    {
                        cmd2.Parameters.AddWithValue("@Name", cmbMaterialName.Text);
                        using (MySqlDataReader reader = cmd2.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MaterialID = reader["MaterialID"].ToString();
                            }
                        }
                    } // 💡 第一個 Reader 在這裡結束並正確關閉，避免後續衝突

                    // 2. 執行資料寫入 (INSERT)
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@RequestItemID", tbRequestItemID.Text);
                        cmd.Parameters.AddWithValue("@RequestID", cmbRequestID.Text);
                        cmd.Parameters.AddWithValue("@MaterialID", MaterialID);

                        // 💡 安全機制：將字串轉換為數字型態，若轉換失敗則代入 0，防止資料庫崩潰
                        int.TryParse(QuantityRequested.Text, out int reqQty);
                        int.TryParse(QuantityApproved.Text, out int appQty);
                        int.TryParse(QuantityIssued.Text, out int issQty);

                        cmd.Parameters.AddWithValue("@QuantityRequested", reqQty);
                        cmd.Parameters.AddWithValue("@QuantityApproved", appQty);
                        cmd.Parameters.AddWithValue("@QuantityIssued", issQty);

                        // 💡 修正 1：必須呼叫 ExecuteNonQuery 才會真正把資料寫進資料庫
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Material details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 3. 重新讀取資料庫，將最新明細刷回 DataGridView
                    DataTable dt = new DataTable();
                    using (MySqlCommand cmd3 = new MySqlCommand(query2, con))
                    {
                        cmd3.Parameters.AddWithValue("@RequestID", cmbRequestID.Text);
                        using (MySqlDataAdapter da2 = new MySqlDataAdapter(cmd3))
                        {
                            da2.Fill(dt);
                        }
                    }

                    // 💡 修正 3：務必將資料來源指派給 DataGridView，畫面才會同步更新
                    dataGridView2.DataSource = dt;

                    // 4. 清空輸入框（保留單號），並自動生成下一個明細序號
                    QuantityRequested.Value = 0;
                    QuantityApproved.Value = 0;
                    QuantityIssued.Value = 0;

                    genRequestItemID(); // 自動幫使用者準備好下一個 RITEM 號碼
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Adding details failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cmbUrgency.SelectedIndex = -1;
            cmbRequestBy.SelectedIndex = -1;
            cmbBatchID.SelectedIndex = -1;
            cmbRequestStatus.SelectedIndex = -1;
            RequestByDate.Value = DateTime.Now;
            RequestDate.Value = DateTime.Now;
            tbRequestItemID.Clear();
            cmbMaterialName.SelectedIndex = -1;
            QuantityRequested.Value = 0;
            QuantityApproved.Value = 0;
            QuantityIssued.Value = 0;
            dataGridView2.DataSource = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 💡 安全防呆：確保主要必填欄位沒有留白
            if (string.IsNullOrEmpty(cmbRequestID.Text) || string.IsNullOrEmpty(cmbRequestBy.Text))
            {
                MessageBox.Show("Please make sure that both the \"Application Number\" and \"Applicant\" fields are filled in!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🎯 宣告兩種 SQL 語句：因應存在與否動態抽換
            string insertQuery = @"
    INSERT INTO materialrequest (RequestID, UserID, BatchID, RequestDate, RequestByDate, Urgency, Status) 
    VALUES (@RequestID, @UserID, @BatchID, @RequestDate, @RequestByDate, @Urgency, @Status);";

            string updateQuery = @"
    UPDATE materialrequest 
    SET UserID = @UserID, BatchID = @BatchID, RequestDate = @RequestDate, RequestByDate = @RequestByDate, Urgency = @Urgency, Status = @Status 
    WHERE RequestID = @RequestID;";

            string checkQuery = "SELECT COUNT(*) FROM materialrequest WHERE RequestID = @RequestID;";
            string UserIDQuery = "SELECT UserID FROM user WHERE Name = @Name;";

            int userID = 0;
            string currentRequestID = cmbRequestID.Text.Trim();

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // 1. 根據申請人名稱查詢 UserID
                    using (MySqlCommand cmd = new MySqlCommand(UserIDQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", cmbRequestBy.Text.Trim());
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userID = reader.GetInt32(0);
                            }
                            else
                            {
                                MessageBox.Show($"The user named \"{cmbRequestBy.Text}\" could not be found. Please verify that your input is correct.", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // 🎯 核心修正 1：檢查該 RequestID 是否已經存在於資料庫中
                    bool isRequestExist = false;
                    using (MySqlCommand cmdCheck = new MySqlCommand(checkQuery, con))
                    {
                        cmdCheck.Parameters.AddWithValue("@RequestID", currentRequestID);
                        isRequestExist = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0;
                    }

                    // 🎯 核心修正 2：根據檢查結果，動態決定是要 INSERT 還是 UPDATE，徹底解決 Primary Key 重複衝突！
                    string finalQuery = isRequestExist ? updateQuery : insertQuery;

                    using (MySqlCommand cmd2 = new MySqlCommand(finalQuery, con))
                    {
                        cmd2.Parameters.AddWithValue("@RequestID", currentRequestID);
                        cmd2.Parameters.AddWithValue("@UserID", userID);
                        cmd2.Parameters.AddWithValue("@BatchID", cmbBatchID.Text.Trim());
                        cmd2.Parameters.AddWithValue("@RequestDate", RequestDate.Value.Date);
                        cmd2.Parameters.AddWithValue("@RequestByDate", RequestByDate.Value.Date);
                        cmd2.Parameters.AddWithValue("@Urgency", cmbUrgency.Text.Trim());
                        cmd2.Parameters.AddWithValue("@Status", cmbRequestStatus.Text.Trim());

                        cmd2.ExecuteNonQuery();
                    }

                    // 提示訊息根據模式自動調整，體驗更專業
                    if (isRequestExist)
                    {
                        MessageBox.Show($"Material requisition master file '{currentRequestID}' updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Material requisition master file '{currentRequestID}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // 💡 可以在這裡呼叫您畫面右下角的 Clear 按鈕事件，或是自動生成下一個 REQ 單號的方法
                    // GenerateNextRequestID(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to store master file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
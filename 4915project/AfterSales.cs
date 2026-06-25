using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915project
{
    public partial class AfterSales : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        public AfterSales()
        {
            InitializeComponent();
        }

        private void SetupWelcomeMessage()
        {
            string displayName = string.IsNullOrWhiteSpace(CurrentUser.Username) ? "User" : CurrentUser.Username;
            string rolePart = string.IsNullOrWhiteSpace(CurrentUser.Role) ? "" : $" ({CurrentUser.Role})";
            this.lblWelcome.Text = $"Welcome, {displayName}{rolePart}!";
        }

        private void AfterSales_Load(object sender, EventArgs e)
        {
            SetupWelcomeMessage();
            PopulateComplaintFilters();
            // 1. 初始化下拉選單的靜態選項（放最前面，避免重複疊加）
            tbShipID.ReadOnly = true; // ShipmentID 是自動生成的，使用者不應該修改
            cmbCondit.Items.Clear();
            cmbCondit.Items.AddRange(new string[] { "Good", "Bad", "Broken" });

            cmbCustConfirm.Items.Clear();
            cmbCustConfirm.Items.AddRange(new string[] { "Yes", "No" });



            
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // ============ 步驟一：驗證使用者與權限 ============
                    string query = @"
                SELECT userid, name, role FROM user 
                WHERE userid = @UserId 
                LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbRole = reader["role"]?.ToString() ?? "User";
                                if (dbRole != "ADMIN")
                                {
                                    gbMenu.Visible = false;
                                }
                            }
                        }
                    }

                    // ============ 步驟二：🎯 核心修正！將所有 ConfirmationID 填入 ComboBox ============
                    string queryLoadIDs = "SELECT ConfirmationID FROM deliveryconfirmation ORDER BY ConfirmationID DESC;";
                    using (MySqlCommand cmdLoad = new MySqlCommand(queryLoadIDs, con))
                    {
                        using (MySqlDataReader idReader = cmdLoad.ExecuteReader())
                        {
                            cmbConID.Items.Clear();
                            cmbConID.Items.Add("Select Confirmation ID"); // 補上預設防呆空白項

                            while (idReader.Read())
                            {
                                if (idReader["ConfirmationID"] != DBNull.Value)
                                {
                                    cmbConID.Items.Add(idReader["ConfirmationID"].ToString());
                                }
                            }
                        }
                    }

                    // 預設選取第 0 項 ("Select Confirmation ID")
                    if (cmbConID.Items.Count > 0)
                    {
                        cmbConID.SelectedIndex = 0;
                    }

                    // 執行你原本的其他初始化方法
                    LoadReport();
                    LoadComplaint();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading form: " + ex.Message);
                }
            }
        }

        // ============ 步驟三：🎯 當使用者在下拉選單切換 ID 時，才真正去撈詳細資料 ============
        private void cmbConID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 防呆檢查：如果選到提示字或者是空的，清空控制項並返回
            if (cmbConID.SelectedIndex <= 0 || cmbConID.SelectedItem == null)
            {
                tbShipID.Clear();
                tbReceiverName.Clear();
                cmbCondit.SelectedIndex = -1;
                cmbCustConfirm.SelectedIndex = -1;
                tbNote.Clear();
                return;
            }

            string selectedConID = cmbConID.SelectedItem.ToString();
            

            string queryDetails = @"
        SELECT 
            ShipmentID, 
            ReceiverName, 
            ReceivedDate, 
            ItemCondition, 
            CustomerConfirmation, 
            Notes 
        FROM deliveryconfirmation 
        WHERE ConfirmationID = @ConfirmationID 
        LIMIT 1;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd2 = new MySqlCommand(queryDetails, con))
                    {
                        cmd2.Parameters.AddWithValue("@ConfirmationID", selectedConID);

                        using (MySqlDataReader reader = cmd2.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 填入對應欄位
                                tbShipID.Text = reader["ShipmentID"]?.ToString() ?? "";
                                tbReceiverName.Text = reader["ReceiverName"]?.ToString() ?? "";

                                // 處理日期
                                if (reader["ReceivedDate"] != DBNull.Value && reader["ReceivedDate"] != null)
                                {
                                    date.Value = Convert.ToDateTime(reader["ReceivedDate"]);
                                }

                                // 處理狀態下拉選單文字
                                cmbCondit.Text = reader["ItemCondition"]?.ToString() ?? "";
                                cmbCustConfirm.Text = reader["CustomerConfirmation"]?.ToString() ?? "";

                                // 處理備註
                                tbNote.Text = reader["Notes"]?.ToString() ?? "";
                            }
                            else
                            {
                                MessageBox.Show("No confirmation record found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load details: " + ex.Message);
                }
            }
        }

        private void LoadReport()
        {
            
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = @"Select * from deliveryconfirmation";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
            }
        }

        private void LoadComplaint()
        {
            
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = @"
                SELECT 
                    c.ComplaintID, 
                    cu.Name AS CustomerName,     -- 💡 修正：從客戶表撈出客戶名字，而不是錯誤的 ComplaintID
                    c.OrderID, 
                    c.SerialNumber, 
                    u.Name AS Employee,          -- 💡 建議：直接撈出員工姓名（假設欄位是 name），比單純秀 UserID 更直覺
                    c.IssueDate, 
                    c.Description, 
                    c.TYPE,
                    c.Resolution, 
                    c.ResolutionDate
                FROM complaint c
                INNER JOIN customer cu ON c.CustomerID = cu.CustomerID   -- 🎯 建立客訴與客戶的關聯
                INNER JOIN user u ON c.UserID = u.UserID;                -- 🎯 建立客訴與經手員工的關聯";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void PopulateComplaintFilters()
        {
            cmbType.Items.Clear();
            cmbUser.Items.Clear();
            cmbType.Items.Add("All");
            cmbUser.Items.Add("All");

            
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    using (MySqlCommand typeCmd = new MySqlCommand("SELECT DISTINCT TYPE FROM complaint WHERE TYPE IS NOT NULL AND TYPE <> '' ORDER BY TYPE", con))
                    using (MySqlDataReader typeReader = typeCmd.ExecuteReader())
                    {
                        while (typeReader.Read())
                        {
                            cmbType.Items.Add(typeReader["TYPE"].ToString());
                        }
                    }

                    using (MySqlCommand userCmd = new MySqlCommand("SELECT DISTINCT Name FROM user WHERE Name IS NOT NULL AND Name <> '' ORDER BY Name", con))
                    using (MySqlDataReader userReader = userCmd.ExecuteReader())
                    {
                        while (userReader.Read())
                        {
                            cmbUser.Items.Add(userReader["Name"].ToString());
                        }
                    }
                }
                catch
                {
                }
            }

            if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
            if (cmbUser.Items.Count > 0) cmbUser.SelectedIndex = 0;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            
            string updateQuery = @"UPDATE deliveryconfirmation
            SET ShipmentID = @ShipmentID, 
            ReceiverName = @ReceiverName, 
            ReceivedDate = @ReceiverDate, 
            ItemCondition = @ItemCondition, 
            CustomerConfirmation = @CustomerConfirmation, 
            Notes = @Note
            WHERE ConfirmationID = @ConfirmationID ";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ShipmentID", tbShipID.Text);
                        cmd.Parameters.AddWithValue("@ReceiverName", tbReceiverName.Text);
                        cmd.Parameters.AddWithValue("@ReceiverDate", date.Value);
                        cmd.Parameters.AddWithValue("@ItemCondition", cmbCondit.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@CustomerConfirmation", cmbCustConfirm.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Note", tbNote.Text);
                        cmd.Parameters.AddWithValue("@ConfirmationID", cmbConID.SelectedItem?.ToString() ?? "");
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateConfirmationAudit(
                                newDate: date.Value.ToString("yyyy-MM-dd"),
                                newStatus: cmbCondit.SelectedItem?.ToString() ?? "",
                                orderID: cmbConID.SelectedItem?.ToString() ?? "",
                                oldDate: "", // 這裡可以擴充為實際的舊值
                                oldStatus: "" // 這裡可以擴充為實際的舊值
                            );
                            LoadReport(); // 更新後重新載入報表
                        }
                        else
                        {
                            MessageBox.Show("No record was updated. Please check the Confirmation ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateConfirmationAudit(string newDate, string newStatus, string orderID, string oldDate, string oldStatus)
        {
            try
            {
                CurrentUser.UpdateOrder(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email
                );

                AuditHelper.Log(
                    tableName: "salesorder",
                    recordId: orderID,
                    action: "Update Order",
                    userId: CurrentUser.UserID,
                    oldValues: oldDate + ", " + oldStatus, // 這裡可以擴充為實際的舊值物件
                    newValues: newDate + ", " + newStatus // 這裡可以擴充為實際的新值物件
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void btNewComplaint_Click(object sender, EventArgs e)
        {
            FormNewComplaint newComplaintForm = new FormNewComplaint();
            newComplaintForm.Show();
            LoadComplaint(); // 新增完客訴後重新載入客訴列表
        }

        private void btViewComplaint_Click(object sender, EventArgs e)
        {
            ViewEditComplaint viewEdit = new ViewEditComplaint();
            viewEdit.Show();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbReceiverName.Clear();
            tbNote.Clear();
        }


        private void btRefreshComplaint_Click(object sender, EventArgs e)
        {
            LoadComplaint();
        }

        private void btCLears_Click(object sender, EventArgs e)
        {
            tbComplainID.Clear();
            tbOrderID.Clear();
            tbCustomer.Clear();
            cmbType.SelectedIndex = cmbType.Items.Count > 0 ? 0 : -1;
            cmbUser.SelectedIndex = cmbUser.Items.Count > 0 ? 0 : -1;
            SDate.Value = DateTime.Today;
            EDate.Value = DateTime.Today;
            LoadComplaint();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            // 1. 定義基礎 SQL（必定會執行的部分）
            string query = @"
        SELECT 
            c.ComplaintID,
            cu.Name AS CustomerName,
            c.OrderID,
            c.SerialNumber,
            u.Name AS Employee,
            c.IssueDate,
            c.Description,
            c.TYPE,
            c.Resolution,
            c.ResolutionDate
        FROM complaint c
        INNER JOIN customer cu ON c.CustomerID = cu.CustomerID
        INNER JOIN user u ON c.UserID = u.UserID
        WHERE c.IssueDate BETWEEN @StartDate AND @EndDate"; // 💡 將日期作為必選的基礎條件

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand("", con))
                {
                    // 2. 動態檢查第一個條件：ComplaintID
                    string complaintID = tbComplainID.Text.Trim();
                    if (!string.IsNullOrEmpty(complaintID))
                    {
                        query += " AND c.ComplaintID LIKE @ComplaintID";
                        cmd.Parameters.AddWithValue("@ComplaintID", "%" + complaintID + "%");
                    }

                    // 3. 動態檢查第二個條件：OrderID
                    string orderID = tbOrderID.Text.Trim();
                    if (!string.IsNullOrEmpty(orderID))
                    {
                        query += " AND c.OrderID LIKE @OrderID";
                        cmd.Parameters.AddWithValue("@OrderID", "%" + orderID + "%");
                    }

                    // 4. 動態檢查第三個條件：CustomerName
                    string customerName = tbCustomer.Text.Trim();
                    if (!string.IsNullOrEmpty(customerName))
                    {
                        query += " AND cu.Name LIKE @CustomerName";
                        cmd.Parameters.AddWithValue("@CustomerName", "%" + customerName + "%");
                    }

                    // 5. 動態檢查第四個條件：TypeFilter 下拉選單
                    if (cmbType.SelectedItem != null)
                    {
                        string typeFilter = cmbType.SelectedItem.ToString().Trim();
                        // 💡 自動防呆：排除 "All"、"Select Type" 或空白，只有選了特定類型才加入過濾
                        if (typeFilter != "All" && typeFilter != "Select Type" && !string.IsNullOrEmpty(typeFilter))
                        {
                            query += " AND c.TYPE = @TypeFilter";
                            cmd.Parameters.AddWithValue("@TypeFilter", typeFilter);
                        }
                    }

                    // 6. 動態檢查第五個條件：UserFilter 下拉選單
                    if (cmbUser.SelectedItem != null)
                    {
                        string userFilter = cmbUser.SelectedItem.ToString().Trim();
                        if (userFilter != "All" && userFilter != "Select User" && !string.IsNullOrEmpty(userFilter))
                        {
                            query += " AND u.Name = @UserFilter";
                            cmd.Parameters.AddWithValue("@UserFilter", userFilter);
                        }
                    }

                    // 7. 補上排序並將完整 SQL 賦值給 Command
                    query += " ORDER BY c.IssueDate DESC;";
                    cmd.CommandText = query;

                    // 8. 綁定必定存在的日期參數 (時間精準補滿)
                    cmd.Parameters.AddWithValue("@StartDate", SDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EndDate", EDate.Value.Date.AddDays(1).AddSeconds(-1));

                    try
                    {
                        con.Open();
                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        dataGridView1.DataSource = dt;

                        // 可選：若查無資料給予提示
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No matching complaint records could be found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to search complaints: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btSales_Click(object sender, EventArgs e)
        {
            SalesOrder salesOrderForm = new SalesOrder();
            salesOrderForm.Show();
            this.Hide();
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Close();
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            FormLogistics formLogistics = new FormLogistics();
            formLogistics.Show();
            this.Close();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Inventory inventoryForm = new Inventory();
            inventoryForm.Show();
            this.Close();
        }


        private void btSetting_Click(object sender, EventArgs e)
        {
            FormSetting setting = new FormSetting();
            setting.Show();
        }

        private void Production_Click(object sender, EventArgs e)
        {
            Production production = new Production();
            production.Show();
            this.Close();
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
    }
}

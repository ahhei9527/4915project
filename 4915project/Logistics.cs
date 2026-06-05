using _4915project;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP4915M
{
    public partial class FormLogistics : Form
    {
        string ShipmentID = "";
        string OrderID = "";
        string ShipmentStatus = "";
        string OrderStatus = "";
        string DeliveryMethod = "";
        string EstimatedDeliveryDate = "";
        string Remark = "";
        string confirmationID = "";
        int CustID;
        int exists = 0;
        string constring = "server=localhost;user id=root;password=;database=4915";
        public FormLogistics()
        {
            InitializeComponent();
        }

        private void FormLogistics_Load(object sender, EventArgs e)
        {
            GenDeliveryNoteID();
            GetDeliveryID();
            //GetShipmentDetail();
            // 1. 初始化 UI 控制項狀態
            receviedDate.Enabled = false;
            cbremark.Items.AddRange(new string[] { "Good", "Bad", "Broken" });
            cbOrderstat.Items.AddRange(new string[] { "Confirmed", "Processing", "Delivered" });
            cbshipStat.Items.AddRange(new string[] { "In Transit", "Delivered", "Delayed" });
            cbMethod.Items.AddRange(new string[] { "Standard", "Express Delivery" });

            

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    // 💡 整個 Using 區塊內，只需要在最開頭 Open 一次即可！
                    con.Open();

                    // ============ 步驟一：讀取並驗證使用者資訊 ============
                    string queryname = @"
                SELECT userid, name, role FROM user 
                WHERE userid = @UserId 
                LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(queryname, con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbUsername = reader["name"]?.ToString() ?? "";
                                string dbRole = reader["role"]?.ToString() ?? "User";
                                lblWelcome.Text = $"Welcome, {dbUsername}({dbRole})";

                                if (dbRole != "ADMIN")
                                {
                                    gbMenu.Visible = false;
                                }
                            }
                        } // reader 在這裡自動關閉釋放
                    }

                    // ============ 步驟二：載入出貨與訂單清單至 DataGridView ============
                    string query = @"
                    SELECT 
                        s.ShipmentID,
                        so.OrderID, 
                        s.Status AS ShipmentStatus,     -- 如果尚未出貨，這裡在 C# 讀出來會是 NULL
                        so.Status AS OrderStatus,       
                        s.DeliveryMethod, 
                        so.EstimatedDeliveryDate
                    FROM salesorder so
                    LEFT JOIN shipment s ON so.OrderID = s.OrderID;"; // 👈 改為 LEFT JOIN 確保以訂單主檔為主

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView2.DataSource = dt;

                            // 清空舊項目，避免重複疊加
                            cbOrderID.Items.Clear();

                            foreach (DataRow row in dt.Rows)
                            {
                                // 1. 將所有訂單編號加進 ComboBox 中
                                if (row["OrderID"] != DBNull.Value)
                                {
                                    cbOrderID.Items.Add(row["OrderID"].ToString());
                                }
                            }

                            // 2. 初始化畫面控制項（填入第一筆資料作為預設）
                            if (dt.Rows.Count > 0)
                            {
                                DataRow firstRow = dt.Rows[0];
                                cbOrderID.Text = firstRow["OrderID"]?.ToString() ?? "";
                                cbOrderstat.Text = firstRow["OrderStatus"]?.ToString() ?? "";

                                // 💡 安全處理：如果新訂單還沒有出貨狀態，給予預設文字
                                cbshipStat.Text = firstRow["ShipmentStatus"] == DBNull.Value ? "Pending" : firstRow["ShipmentStatus"].ToString();
                                cbMethod.Text = firstRow["DeliveryMethod"] == DBNull.Value ? "Standard" : firstRow["DeliveryMethod"].ToString();
                            }
                        }
                        string shipQuery = "SELECT ShipmentID FROM shipment ORDER BY ShipmentID";
                        using (MySqlCommand shipCmd = new MySqlCommand(shipQuery, con))
                        {
                            using (MySqlDataReader shipReader = shipCmd.ExecuteReader())
                            {
                                while (shipReader.Read())
                                {
                                    cmbShipID.Items.Add(shipReader["ShipmentID"].ToString());
                                }
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection or query failed: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 防呆檢查：如果使用者沒有選取，或者選到空白，直接返回
            if (cbOrderID.SelectedItem == null || string.IsNullOrEmpty(cbOrderID.SelectedItem.ToString()))
            {
                return;
            }

            string selectedOrderID = cbOrderID.SelectedItem.ToString();
            

            // 使用 LEFT JOIN 確保即使是剛建立、還沒有出貨單(shipment)的新訂單，也能查出訂單狀態
            string query = @"
        SELECT 
            s.ShipmentID,
            so.OrderID, 
            so.Status AS OrderStatus,       
            s.Status AS ShipmentStatus,     
            s.DeliveryMethod, 
            so.EstimatedDeliveryDate
        FROM salesorder so
        LEFT JOIN shipment s ON so.OrderID = s.OrderID
        WHERE so.OrderID = @OrderID 
        LIMIT 1;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // 帶入安全的參數化數值
                        cmd.Parameters.AddWithValue("@OrderID", selectedOrderID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 1. 更新訂單狀態
                                cbOrderstat.Text = reader["OrderStatus"]?.ToString() ?? "";

                                // 2. 更新出貨狀態（防呆：若尚未有出貨單，顯示預設值，例如 "Pending"）
                                if (reader["ShipmentStatus"] == DBNull.Value || reader["ShipmentStatus"] == null)
                                {
                                    cbshipStat.Text = "Pending";
                                }
                                else
                                {
                                    cbshipStat.Text = reader["ShipmentStatus"].ToString();
                                }

                                // 3. 更新運送方式（防呆：若尚未有出貨單，顯示預設值，例如 "Standard"）
                                if (reader["DeliveryMethod"] == DBNull.Value || reader["DeliveryMethod"] == null)
                                {
                                    cbMethod.SelectedIndex = 0; // 或是設為 "Standard"
                                }
                                else
                                {
                                    cbMethod.Text = reader["DeliveryMethod"].ToString();
                                }

                                // 4. 更新預計送達日期
                                if (reader["EstimatedDeliveryDate"] != DBNull.Value && reader["EstimatedDeliveryDate"] != null)
                                {
                                    receviedDate.Value = Convert.ToDateTime(reader["EstimatedDeliveryDate"]);
                                }
                                else
                                {
                                    receviedDate.Value = DateTime.Now; // 預設今天
                                }
                                if (reader["ShipmentID"] != DBNull.Value && !string.IsNullOrEmpty(reader["ShipmentID"]?.ToString()))
                                {
                                    tbShipID.Text = reader["shipmentID"].ToString();
                                }
                                else
                                {
                                    GenerateShipmentID(); // 或是保留自動生成的 ShipmentID
                                }
                            }
                            else
                            {
                                MessageBox.Show("找不到該訂單的詳細資料。");
                            }
                        }
                    }

                    OrderID = cbOrderID.Text; // 預設選取第一筆訂單的 OrderID
                    ShipmentStatus = cbshipStat.Text; // 預設選取第一筆訂單的 ShipmentStatus
                    OrderStatus = cbOrderstat.Text;
                    DeliveryMethod = cbMethod.Text;
                    EstimatedDeliveryDate = receviedDate.Value.ToString("yyyy-MM-dd");
                    Remark = cbremark.Text;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("讀取訂單詳細資料時發生資料庫錯誤: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("發生未預期的錯誤: " + ex.Message);
                }
            }
        }

        private void GenerateShipmentID()
        {
            
            string query2 = @"
                SELECT ShipmentID 
                FROM shipment 
                WHERE ShipmentID LIKE @Prefix 
                ORDER BY ShipmentID DESC 
                LIMIT 1";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string prefix = "SHIP"; // 生成格式例如：SHIP001, SHIP002

                using (MySqlCommand cmd = new MySqlCommand(query2, con))
                {
                    cmd.Parameters.AddWithValue("@Prefix", prefix + "%");

                    // 💡 修正：移除你原本寫在這裡的 con.Open(); 避免重複開啟錯誤
                    object result = cmd.ExecuteScalar();

                    int nextNumber = 1;

                    if (result != null && result != DBNull.Value)
                    {
                        string lastOrderID = result.ToString();

                        // 安全切割：取字串最後 3 碼數字 (例如從 ""SHIP005"" 切出 ""005"")
                        if (lastOrderID.Length >= 3)
                        {
                            string lastNumberStr = lastOrderID.Substring(lastOrderID.Length - 3);
                            if (int.TryParse(lastNumberStr, out int lastNumber))
                            {
                                nextNumber = lastNumber + 1;
                            }
                        }
                    }

                    // 將序號格式化為 3 位數，例如 1 變成 001，12 變成 012
                    tbShipID.Text = prefix + nextNumber.ToString("D3");
                    tbShipID.ReadOnly = true;
                }
            }
        }

        private void btUpdateCreate_Click(object sender, EventArgs e)
        {
            // 1. 取得畫面上控制項的最新輸入值
            string newShipmentID = tbShipID.Text.Trim();
            string newOrderID = cbOrderID.Text.Trim();
            string newShipmentStatus = cbshipStat.Text.Trim();
            string newOrderStatus = cbOrderstat.Text.Trim();
            string newDeliveryMethod = cbMethod.Text.Trim();
            string newEstimatedDate = receviedDate.Value.ToString();
            string newRemark = cbremark.Text.Trim();

            // 防呆檢查
            if (string.IsNullOrEmpty(newShipmentID) || string.IsNullOrEmpty(newOrderID))
            {
                MessageBox.Show("Shipment ID and Order ID cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            // 狀態標記變數
            bool isShipmentExisting = false;
            bool isConfirmationExisting = false;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // 🔍 檢查一：檢查 shipment 表是否存在該單號
                    string checkShipmentQuery = "SELECT COUNT(*) FROM shipment WHERE ShipmentID = @ShipmentID";
                    using (MySqlCommand checkShipCmd = new MySqlCommand(checkShipmentQuery, con))
                    {
                        checkShipCmd.Parameters.AddWithValue("@ShipmentID", newShipmentID);
                        isShipmentExisting = Convert.ToInt64(checkShipCmd.ExecuteScalar()) > 0;
                    }

                    // 🔍 檢查二：檢查 deliveryconfirmation 表是否已經有這一筆 ShipmentID 的紀錄
                    string checkConfirmQuery = "SELECT ConfirmationID FROM deliveryconfirmation WHERE ShipmentID = @ShipmentID LIMIT 1";
                    using (MySqlCommand checkConfCmd = new MySqlCommand(checkConfirmQuery, con))
                    {
                        checkConfCmd.Parameters.AddWithValue("@ShipmentID", newShipmentID);
                        object confResult = checkConfCmd.ExecuteScalar();
                        if (confResult != null && confResult != DBNull.Value)
                        {
                            isConfirmationExisting = true;
                            confirmationID = confResult.ToString(); // 👈 成功同時取得現有的 ID！
                        }
                        else
                        {
                            isConfirmationExisting = false;
                            confirmationID = null;
                        }
                    }

                    // 使用 Transaction 確保所有表的異動同時成功或同時倒回
                    using (MySqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // ============================================================
                            // 1. 處理 shipment 表 (存在就 UPDATE，不存在就 INSERT)
                            // ============================================================
                            // ==================== 情況 A：新資料，執行 INSERT ====================
                            if (isShipmentExisting)
                            {
                                string updateShipment = @"
                            UPDATE shipment 
                            SET Status = @ShipmentStatus, 
                                DeliveryMethod = @DeliveryMethod
                            WHERE ShipmentID = @ShipmentID;";
                                using (MySqlCommand cmd = new MySqlCommand(updateShipment, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@ShipmentStatus", newShipmentStatus);
                                    cmd.Parameters.AddWithValue("@DeliveryMethod", newDeliveryMethod);
                                    cmd.Parameters.AddWithValue("@ShipmentID", newShipmentID);
                                    cmd.ExecuteNonQuery();
                                }
                                UpdateShipmentAudit(newShipmentStatus, newDeliveryMethod, newShipmentID, ShipmentStatus, DeliveryMethod);
                            }
                            else
                            {
                                // ==================== 情況 B：新資料，執行 INSERT ====================

                                // 1. 新增一筆出貨單到 shipment 表（🎯 補上 UserID 欄位與參數）
                                string insertShipment = @"
                            INSERT INTO shipment (ShipmentID, OrderID, Status, DeliveryMethod, UserID) 
                            VALUES (@ShipmentID, @OrderID, @ShipmentStatus, @DeliveryMethod, @UserID);";

                                using (MySqlCommand cmd = new MySqlCommand(insertShipment, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@ShipmentID", newShipmentID);
                                    cmd.Parameters.AddWithValue("@OrderID", newOrderID);
                                    cmd.Parameters.AddWithValue("@ShipmentStatus", newShipmentStatus);
                                    cmd.Parameters.AddWithValue("@DeliveryMethod", newDeliveryMethod);

                                    // 💡 核心修正：將當前登入系統的 UserID 傳入資料庫
                                    cmd.Parameters.AddWithValue("@UserID", CurrentUser.UserID);

                                    cmd.ExecuteNonQuery();
                                    AddShipmentAudit(newShipmentID, newShipmentStatus, newDeliveryMethod, newOrderID);
                                }
                            }

                            // ============================================================
                            // 2. 同步更新銷售訂單 salesorder 的狀態與交期
                            // ============================================================
                            string updateOrder = @"
                        UPDATE salesorder 
                        SET Status = @OrderStatus, 
                            EstimatedDeliveryDate = @EstimatedDeliveryDate
                        WHERE OrderID = @OrderID;";
                            using (MySqlCommand cmd = new MySqlCommand(updateOrder, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@OrderStatus", newOrderStatus);
                                cmd.Parameters.AddWithValue("@EstimatedDeliveryDate", newEstimatedDate);
                                cmd.Parameters.AddWithValue("@OrderID", OrderID);
                                cmd.ExecuteNonQuery();
                                UpdateSalesOrderAudit(newOrderStatus, newEstimatedDate, OrderID);
                            }

                            // ============================================================
                            // 3. 處理 deliveryconfirmation 表 (有資料就 UPDATE，沒資料就自動生成 CONFxxx 並 INSERT)
                            // ============================================================
                            if (isConfirmationExisting)
                            {
                                // 情況 A：已有關聯資料，直接更新備註條件
                                string updateDelivery = @"
                            UPDATE deliveryconfirmation 
                            SET ItemCondition = @Remark 
                            WHERE ShipmentID = @ShipmentID;";
                                using (MySqlCommand cmd = new MySqlCommand(updateDelivery, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@Remark", newRemark);
                                    cmd.ExecuteNonQuery();
                                    UpdateDeliveryconfirmationAudit(newRemark, confirmationID, Remark);
                                }
                            }
                            else
                            {
                                // 🎯 情況 B：全新建立一列。開始動態生成 CONF001 格式的流水號
                                string prefix = "CONF";
                                int nextNumber = 1;

                                // 前往資料庫抓取目前最大的 ConfirmationID
                                string maxIDQuery = "SELECT ConfirmationID FROM deliveryconfirmation WHERE ConfirmationID LIKE @Prefix ORDER BY ConfirmationID DESC LIMIT 1";
                                using (MySqlCommand maxIDCmd = new MySqlCommand(maxIDQuery, con, transaction))
                                {
                                    maxIDCmd.Parameters.AddWithValue("@Prefix", prefix + "%");
                                    object maxResult = maxIDCmd.ExecuteScalar();

                                    if (maxResult != null && maxResult != DBNull.Value)
                                    {
                                        string lastID = maxResult.ToString();
                                        // 安全擷取最後 3 碼數字（例如從 "CONF005" 切出 "005"）
                                        if (lastID.Length >= 3)
                                        {
                                            string lastNumberStr = lastID.Substring(lastID.Length - 3);
                                            if (int.TryParse(lastNumberStr, out int lastNumber))
                                            {
                                                nextNumber = lastNumber + 1; // 序號加 1
                                            }
                                        }
                                    }
                                }

                                // 格式化為 3 位數，例如 1 變 CONF001，12 變 CONF012
                                string generatedConfirmID = prefix + nextNumber.ToString("D3");

                                // 執行 INSERT
                                string insertDelivery = @"
                            INSERT INTO deliveryconfirmation (ConfirmationID, ShipmentID, ItemCondition) 
                            VALUES (@ConfirmationID, @ShipmentID, @Remark);";
                                using (MySqlCommand cmd = new MySqlCommand(insertDelivery, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@ConfirmationID", generatedConfirmID);
                                    cmd.Parameters.AddWithValue("@ShipmentID", newShipmentID);
                                    cmd.Parameters.AddWithValue("@Remark", newRemark);
                                    cmd.ExecuteNonQuery();
                                    CreateConfirmationAudit(generatedConfirmID, newShipmentID, newRemark);
                                }
                            }

                            // 提交事務，確定寫入資料庫
                            transaction.Commit();
                            MessageBox.Show("All logistics records have been successfully saved/updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 可在此處呼叫重新整理 DataGridView 的方法
                            // RefreshDataGridView();
                        }
                        catch (Exception ex)
                        {
                            // 只要中途有任何一個地方失敗，全部回復原狀
                            transaction.Rollback();
                            MessageBox.Show("Transaction failed! System rolled back changes.\nError: " + ex.Message, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateShipmentAudit(string newShipmentStatus, string newDeliveryMethod, string orderID, string ShipmentStatus, string DeliveryMethod)
        {
            try
            {
                CurrentUser.UpdateShipment(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email
                );

                AuditHelper.Log(
                    tableName: "shipment",
                    recordId: orderID,
                    action: "Update Shipment Status",
                    userId: CurrentUser.UserID,
                    oldValues: ShipmentStatus + ", " + DeliveryMethod, // 這裡可以擴充為實際的舊值物件
                    newValues: newShipmentStatus + ", " + newDeliveryMethod // 這裡可以擴充為實際的新值物件
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void AddShipmentAudit(string newShipmentID, string newShipmentStatus, string newDeliveryMethod, string orderID)
        {
            try
            {
                CurrentUser.CreateShipment(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email
                );

                AuditHelper.Log(
                    tableName: "shipment",
                    recordId: orderID,
                    action: "Create Shipment",
                    userId: CurrentUser.UserID,
                    oldValues: null, // 這裡可以擴充為實際的舊值物件
                    newValues: newShipmentID + ", " + newShipmentStatus + ", " + newDeliveryMethod // 這裡可以擴充為實際的新值物件
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void UpdateSalesOrderAudit(string newOrderStatus, string newEstimatedDate, string newOrderID)
        {
            CurrentUser.UpdateSalesOrder(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email
                );

            AuditHelper.Log(
                    tableName: "SalesOrder",
                    recordId: OrderID,
                    action: "Update SalesOrder",
                    userId: CurrentUser.UserID,
                    oldValues: null, // 這裡可以擴充為實際的舊值物件
                    newValues: OrderID + ", " + newOrderStatus + ", " + newEstimatedDate // 這裡可以擴充為實際的新值物件
                );
        }

        private void UpdateDeliveryconfirmationAudit(string newRemark, string confirmationID, string Remark)
        {
            CurrentUser.UpdateDeliveryconfirmation(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email
                );

            AuditHelper.Log(
                    tableName: "deliveryconfirmation",
                    recordId: confirmationID,
                    action: "Update deliveryconfirmation",
                    userId: CurrentUser.UserID,
                    oldValues: confirmationID + ", " + Remark, // 這裡可以擴充為實際的舊值物件
                    newValues: confirmationID + ", " + newRemark // 這裡可以擴充為實際的新值物件
                );
        }

        private void CreateConfirmationAudit(string generatedConfirmID, string newShipmentID, string newRemark)
        {
            CurrentUser.CreateDeliveryconfirmation(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email
                );

            AuditHelper.Log(
                    tableName: "deliveryconfirmation",
                    recordId: confirmationID,
                    action: "Update deliveryconfirmation",
                    userId: CurrentUser.UserID,
                    oldValues: null, // 這裡可以擴充為實際的舊值物件
                    newValues: confirmationID + ", " + newShipmentID + ", " + newRemark // 這裡可以擴充為實際的新值物件
                );
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
            this.Close();
        }

        private void btSales_Click(object sender, EventArgs e)
        {
            SalesOrder order = new SalesOrder();
            order.Show();
            this.Close();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Close();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            FormSetting setting = new FormSetting();
            setting.Show();
        }

        private void AfterSales_Click(object sender, EventArgs e)
        {
            AfterSales afterSales = new AfterSales();
            afterSales.Show();
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

        private void GenDeliveryNoteID()
        {
            

            // 修正：統一使用相同的欄位名稱 DNNumber (避免欄位名稱不一致報錯)
            string query = @"
        SELECT deliveryID 
        FROM deliverynote 
        WHERE deliveryID LIKE @Prefix 
        ORDER BY deliveryID DESC 
        LIMIT 1";

            string prefix = "DN";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Prefix", prefix + "%");

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        int nextNumber = 1; // 預設如果沒有任何送貨單，就是第一筆

                        if (result != null && result != DBNull.Value)
                        {
                            string lastDeliveryID = result.ToString();

                            // 防呆：確保字串總長度大於前綴長度，才進行切割
                            if (lastDeliveryID.Length > prefix.Length)
                            {
                                // 直接切出前綴後面的所有數字部分 (例如從 "DN001" 切出 "001")
                                string lastNumberStr = lastDeliveryID.Substring(prefix.Length);

                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1; // 序號加 1
                                }
                            }
                        }

                        // 將序號格式化為 3 位數，例如 1 變成 001，12 變成 012
                        tbDeliveryNoteID.Text = prefix + nextNumber.ToString("D3"); // 產生如: DN001
                        tbDeliveryNoteID.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("無法取得送貨單流水號: " + ex.Message);
                        MessageBox.Show("無法自動產生送貨單號，請檢查資料庫連線。");
                        tbDeliveryNoteID.ReadOnly = false;
                    }
                }
            }
        }

        private void cmbShipID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbShipID.SelectedItem == null) return;

            
            string shipmentID = cmbShipID.SelectedItem.ToString().Trim();

            string queryOrderInfo = @"
        SELECT 
            so.OrderID, 
            c.Name AS CustomerName,
            c.Address,
            c.CustomerID
        FROM salesorder so
        INNER JOIN customer c ON so.CustomerID = c.CustomerID
        INNER JOIN shipment s ON so.OrderID = s.OrderID
        WHERE s.ShipmentID = @ShipmentID
        LIMIT 1";

            string queryOrderItems = @"
        SELECT 
            o.OrderItemID,
            p.Name AS ProductName,
            p.ProductID,
            o.Quantity,
            o.UnitPrice,
            o.Subtotal,
            o.CustomNotes
        FROM orderitem o
        INNER JOIN orderitem_product op ON o.OrderItemID = op.OrderItemID
        INNER JOIN product p ON op.ProductID = p.ProductID
        WHERE o.OrderID = @OrderID
        ORDER BY o.OrderItemID";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // 1. 取得訂單基本資訊
                    using (MySqlCommand cmd = new MySqlCommand(queryOrderInfo, con))
                    {
                        cmd.Parameters.AddWithValue("@ShipmentID", shipmentID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CustID = Convert.ToInt32(reader["CustomerID"]);
                                tbOrderID.Text = reader["OrderID"]?.ToString() ?? "";
                                tbOrderID.ReadOnly = true;
                                tbRecipient.Text = reader["CustomerName"]?.ToString() ?? "";
                                tbRecipient.ReadOnly = true;
                                tbAddress.Text = reader["Address"]?.ToString() ?? "";
                                tbAddress.ReadOnly = true;
                            }
                            else
                            {
                                MessageBox.Show("找不到該出貨單對應的訂單資訊。");
                                return;
                            }
                        }
                    }

                    // 2. 取得訂單明細（如果有 dataGridView1）
                    string orderID = tbOrderID.Text.Trim();
                    if (!string.IsNullOrEmpty(orderID))
                    {
                        using (MySqlCommand itemCmd = new MySqlCommand(queryOrderItems, con))
                        {
                            itemCmd.Parameters.AddWithValue("@OrderID", orderID);

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(itemCmd))
                            {
                                DataTable itemTable = new DataTable();
                                adapter.Fill(itemTable);
                                dataGridView1.Columns.Clear();
                                DataGridViewTextBoxColumn itemIdColumn = new DataGridViewTextBoxColumn();
                                itemIdColumn.Name = "ItemID";
                                itemIdColumn.HeaderText = "Item ID"; // Set your custom column title
                                dataGridView1.Columns.Add(itemIdColumn);
                                dataGridView1.DataSource = itemTable;
                                if (dataGridView1.Columns.Contains("OrderItemID"))
                                    dataGridView1.Columns["OrderItemID"].Visible = false;

                                if (dataGridView1.Columns.Contains("ProductID"))
                                    dataGridView1.Columns["ProductID"].Visible = false;

                                // 4. Populate the first column with sequential line numbers (1, 2, 3...)
                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    // If your grid allows adding new rows manually, skip the uncommitted new row
                                    if (dataGridView1.Rows[i].IsNewRow) continue;

                                    dataGridView1.Rows[i].Cells["ItemID"].Value = (i + 1).ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("載入出貨單資料失敗: " + ex.Message);
                }
            }
        }

        private void ExportToPDF()
        {
            // 1. 讓使用者選擇儲存路徑
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = $"DeliveryNote_{tbOrderID.Text.Trim() ?? "Document"}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // 使用完整的命名空間指定 iTextSharp 的 Document，避免與系統視窗衝突
                    iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 30f, 30f, 30f, 30f);

                    try
                    {
                        PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                        document.Open();

                        // 修正：明確指定 iTextSharp 的 Font 類別，並修正 GetFont 的參數類型（將字型大小改為 float 格式，如 18f、10f）
                        iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 18f, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font headerFont = FontFactory.GetFont("Arial", 10f, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font bodyFont = FontFactory.GetFont("Arial", 10f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        // --- 標題標頭 ---
                        Paragraph CompanyName = new Paragraph("Premium Living Furniture Co.Ltd\n\n", titleFont);
                        Paragraph title = new Paragraph("DELIVERY NOTE\n\n", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        document.Add(CompanyName);
                        document.Add(title);

                        // --- 上方表頭基本資訊 (雙欄版面) ---
                        PdfPTable metaTable = new PdfPTable(2);
                        metaTable.WidthPercentage = 100;
                        metaTable.SetWidths(new float[] { 1f, 1f });

                        // 左欄與右欄資料
                        metaTable.AddCell(new PdfPCell(new Phrase($"Delivery ID: DN001", bodyFont)) { Border = PdfPCell.NO_BORDER, PaddingBottom = 8f });
                        metaTable.AddCell(new PdfPCell(new Phrase($"Shipment ID: {cmbShipID.SelectedItem?.ToString()}", bodyFont)) { Border = PdfPCell.NO_BORDER, PaddingBottom = 8f });

                        metaTable.AddCell(new PdfPCell(new Phrase($"Order ID: {tbOrderID.Text}", bodyFont)) { Border = PdfPCell.NO_BORDER, PaddingBottom = 8f });
                        metaTable.AddCell(new PdfPCell(new Phrase($"Recipient: {tbRecipient.Text}", bodyFont)) { Border = PdfPCell.NO_BORDER, PaddingBottom = 8f });

                        document.Add(metaTable);

                        // --- 地址區塊 ---
                        Paragraph addressPara = new Paragraph($"Address:\n{tbAddress.Text}\n\n", bodyFont);
                        document.Add(addressPara);

                        // --- 主要資料表格 ---
                        // 計算目前畫面上畫面上實際顯示的欄位數量
                        int visibleColumnCount = 0;
                        foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            if (col.Visible) visibleColumnCount++;
                        }

                        if (visibleColumnCount == 0)
                        {
                            MessageBox.Show("沒有可導出的資料。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            document.Close();
                            return;
                        }

                        PdfPTable dataTable = new PdfPTable(visibleColumnCount);
                        dataTable.WidthPercentage = 100;
                        dataTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        // 動態建立 PDF 表頭
                        foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            if (col.Visible)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, headerFont));
                                cell.BackgroundColor = new BaseColor(240, 240, 240); // 淺灰色背景
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.Padding = 6f;
                                dataTable.AddCell(cell);
                            }
                        }

                        // 動態填入表格資料（會自動跳過被隱藏的 OrderItemID 和 ProductID）
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (dataGridView1.Rows[i].IsNewRow) continue;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                if (col.Visible)
                                {
                                    string cellValue = dataGridView1.Rows[i].Cells[col.Index].Value?.ToString() ?? "";
                                    PdfPCell cell = new PdfPCell(new Phrase(cellValue, bodyFont));
                                    cell.Padding = 6f;

                                    // 靠右對齊數值與金額欄位
                                    if (col.Name.Contains("Price") || col.Name.Contains("Subtotal") || col.Name.Contains("Quantity"))
                                    {
                                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                                    }
                                    else
                                    {
                                        cell.HorizontalAlignment = Element.ALIGN_LEFT;
                                    }

                                    dataTable.AddCell(cell);
                                }
                            }
                        }

                        document.Add(dataTable);
                        MessageBox.Show("PDF 檔案已成功產生！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("產生 PDF 時發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        document.Close();
                    }
                }
            }
        }

        private void btGenNote_Click(object sender, EventArgs e)
        {
            ExportToPDF();
            SaveToDatabase();
            
            string queryUpdateShipment = @"
            UPDATE shipment s
            INNER JOIN salesorder so ON s.OrderID = so.OrderID
            SET s.STATUS = @Status, 
                so.Status = @OStatus 
            WHERE s.OrderID = @OrderID;";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(queryUpdateShipment, con))
                {
                    cmd.Parameters.AddWithValue("@OrderID", tbOrderID.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", "Delivered");
                    cmd.Parameters.AddWithValue("@OStatus", "Delivered");
                }
            }
        }

        private void SaveToDatabase()
        {
            string constring = "server =localhost;user id=root;password=;database=4915";
            string queryDeliveryNote = @"INSERT INTO deliverynote (deliveryID, shipmentID, orderID, 
            customerID, RecipientName, DeliveryAddress, CreateDate, Status) 
                                        VALUES (@deliveryID, @shipmentID, @orderID, 
            @customerID, @RecipientName, @DeliveryAddress, @CreateDate, @Status);";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(queryDeliveryNote, con))
                    {
                        cmd.Parameters.AddWithValue("@deliveryID", tbDeliveryNoteID.Text.Trim());
                        cmd.Parameters.AddWithValue("@shipmentID", cmbShipID.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@orderID", tbOrderID.Text.Trim());
                        cmd.Parameters.AddWithValue("@customerID", CustID);
                        cmd.Parameters.AddWithValue("@RecipientName", tbRecipient.Text.Trim());
                        cmd.Parameters.AddWithValue("@DeliveryAddress", tbAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Status", "Created");
                        cmd.ExecuteNonQuery();
                        CreateDeliveryNoteAudit(tbDeliveryNoteID.Text);
                        MessageBox.Show("Delivery note has been saved to database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save delivery note to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetDeliveryID()
        {
            
            string query = @"SELECT deliveryID FROM deliverynote";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbDeliveryID.Items.Add(reader["deliveryID"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to retrieve delivery IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenReplySlipID()
        {
            
            string query = @"SELECT replySlipID FROM replyslip 
            WHERE replySlipID LIKE @Prefix ORDER BY replySlipID DESC LIMIT 1";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Prefix", "RS" + "%");
                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        int nextNumber = 1;
                        if (result != null && result != DBNull.Value)
                        {
                            string lastID = result.ToString();
                            if (lastID.Length > 2)
                            {
                                string lastNumberStr = lastID.Substring(2);
                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1;
                                }
                            }
                        }
                        tbReplyID.Text = "RS" + nextNumber.ToString("D3");
                        tbReplyID.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to generate Reply Slip ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbReplyID.ReadOnly = false;
                    }
                }
            }
        }

        private void cmbDeliveryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            // 【已修正】補上 WHERE 條件，避免撈出整張表
            string DNotequery = @"SELECT * FROM deliverynote WHERE deliveryID = @deliveryID";
            string RSlipQuery = @"SELECT * FROM replyslip WHERE deliverynoteID = @deliverynoteID";
            string checkExistQuery = "SELECT COUNT(*) FROM replyslip WHERE deliverynoteID = @DeliveryID";

            string queryOrderItems = @"
        SELECT 
            o.OrderItemID,
            p.Name AS ProductName,
            p.ProductID,
            o.Quantity,
            o.UnitPrice,
            o.Subtotal,
            o.CustomNotes
        FROM orderitem o
        INNER JOIN orderitem_product op ON o.OrderItemID = op.OrderItemID
        INNER JOIN product p ON op.ProductID = p.ProductID
        WHERE o.OrderID = @OrderID
        ORDER BY o.OrderItemID";

            string deliveryID = cmbDeliveryID.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrEmpty(deliveryID)) return; // 防呆：未選取則不執行

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    int exists = 0; // 確保變數有適當宣告

                    using (MySqlCommand checkCmd = new MySqlCommand(checkExistQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@DeliveryID", deliveryID);
                        exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    }

                    if (exists > 0)
                    {
                        // 1. 已有回條：從 replyslip 撈資料
                        using (MySqlCommand cmd = new MySqlCommand(RSlipQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@deliverynoteID", deliveryID);

                            // 【已修正】獨立 reader 的範圍，讓它讀完立刻關閉，釋放連線
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    tbReplyID.Text = reader["replySlipID"].ToString();
                                    tbReplyID.ReadOnly = true;
                                    tbReplyOrderID.Text = reader["orderID"].ToString();
                                    tbReplyOrderID.ReadOnly = true;
                                    tbReplyCustName.Text = reader["recipient"].ToString();
                                    tbReplyCustName.ReadOnly = true;
                                    dateDeliveryDate.Value = reader.GetDateTime("deliveryDate");
                                    dateDeliveryDate.Enabled = false;
                                    tbReplyAddress.Text = reader["Address"].ToString();
                                    tbReplyAddress.ReadOnly = true;
                                }
                            } // reader 在這裡確實被 Close/Dispose 了
                        }

                        // 載入訂單明細
                        LoadOrderItems(queryOrderItems, tbReplyOrderID.Text, con);
                    }
                    else
                    {
                        // 2. 尚未有回條：從 deliverynote 撈預設資料
                        GenReplySlipID(); // 產生新的 ReplySlip ID

                        using (MySqlCommand cmd = new MySqlCommand(DNotequery, con))
                        {
                            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);

                            // 【已修正】獨立 reader 範圍
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    tbReplyOrderID.Text = reader["orderID"].ToString();
                                    tbReplyOrderID.ReadOnly = true;
                                    tbReplyCustName.Text = reader["RecipientName"].ToString();
                                    tbReplyCustName.ReadOnly = true;
                                    dateDeliveryDate.Value = reader.GetDateTime("CreateDate");
                                    dateDeliveryDate.Enabled = false;
                                    tbReplyAddress.Text = reader["DeliveryAddress"].ToString();
                                    tbReplyAddress.ReadOnly = true;
                                }
                            }
                        }

                        // 載入訂單明細
                        LoadOrderItems(queryOrderItems, tbReplyOrderID.Text, con);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to retrieve delivery data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 【優化】抽離出來的 DataGridView 填表邏輯，避免重複程式碼
        private void LoadOrderItems(string query, string orderID, MySqlConnection con)
        {
            using (MySqlCommand itemCmd = new MySqlCommand(query, con))
            {
                itemCmd.Parameters.AddWithValue("@OrderID", orderID);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(itemCmd))
                {
                    DataTable itemTable = new DataTable();
                    adapter.Fill(itemTable);

                    // 清空並重新設定 DataGridView 欄位
                    dataGridView3.DataSource = null;
                    dataGridView3.Columns.Clear();

                    // 新增自訂的序號欄位 (ItemID)
                    DataGridViewTextBoxColumn itemIdColumn = new DataGridViewTextBoxColumn();
                    itemIdColumn.Name = "ItemID";
                    itemIdColumn.HeaderText = "Item ID";
                    dataGridView3.Columns.Add(itemIdColumn);

                    // 綁定主資料
                    dataGridView3.DataSource = itemTable;

                    // 隱藏不需要顯現的 ID 欄位
                    if (dataGridView3.Columns.Contains("OrderItemID"))
                        dataGridView3.Columns["OrderItemID"].Visible = false;

                    if (dataGridView3.Columns.Contains("ProductID"))
                        dataGridView3.Columns["ProductID"].Visible = false;

                    // 填寫 1, 2, 3... 流水號
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        if (dataGridView3.Rows[i].IsNewRow) continue;
                        dataGridView3.Rows[i].Cells["ItemID"].Value = (i + 1).ToString();
                    }
                }
            }
        }

        private void btGenSlip_Click(object sender, EventArgs e)
        {
            string constring = "server =localhost;user id=root;password=;database=4915";
            string queryDeliveryNote = @"INSERT INTO replyslip (replySlipID, OrderID, deliverynoteID,
            recipient, DeliveryDate, Address) 
            VALUES (@replySlipID,@OrderID, @deliverynoteID,
            @recipient, @DeliveryDate, @Address);";
            string checkExistQuery = "SELECT COUNT(*) FROM replyslip WHERE deliverynoteID = @DeliveryID";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand checkCmd = new MySqlCommand(checkExistQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@DeliveryID", cmbDeliveryID.SelectedItem?.ToString());
                        exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (exists > 0)
                        {
                            ExportReplySlipToPDF();
                        }
                        else
                        {
                            using (MySqlCommand cmd = new MySqlCommand(queryDeliveryNote, con))
                            {
                                cmd.Parameters.AddWithValue("@replySlipID", tbReplyID.Text.Trim());
                                cmd.Parameters.AddWithValue("@OrderID", tbReplyOrderID.Text.Trim());
                                cmd.Parameters.AddWithValue("@deliverynoteID", cmbDeliveryID.SelectedItem?.ToString().Trim());
                                cmd.Parameters.AddWithValue("@recipient", tbReplyCustName.Text.Trim());
                                cmd.Parameters.AddWithValue("@DeliveryDate", dateDeliveryDate.Value.ToString().Trim());
                                cmd.Parameters.AddWithValue("@Address", tbReplyAddress.Text.Trim());
                                cmd.ExecuteNonQuery();
                                CreateReplySlipAudit(tbReplyID.Text);
                                MessageBox.Show("Reply Slip has been saved to database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ExportReplySlipToPDF();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save Reply Slip to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportReplySlipToPDF()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                string defaultFileName = !string.IsNullOrWhiteSpace(tbReplyID.Text) ? tbReplyID.Text.Trim() : DateTime.Now.ToString("yyyyMMdd_HHmmss");
                sfd.FileName = $"ReplySlip_{defaultFileName}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // 標準 A4，上下左右 30pt 邊距
                    Document document = new Document(PageSize.A4, 30f, 30f, 30f, 30f);
                    FileStream fs = null;

                    try
                    {
                        fs = new FileStream(sfd.FileName, FileMode.Create);
                        PdfWriter.GetInstance(document, fs);
                        document.Open();

                        // 字型設定
                        iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 18f, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font headerFont = FontFactory.GetFont("Arial", 10f, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font bodyFont = FontFactory.GetFont("Arial", 10f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        // --- 1. 文件標題 ---
                        Paragraph title = new Paragraph("REPLY SLIP\n\n", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        document.Add(title);

                        // --- 2. 表單基本資訊 (2 欄佈局) ---
                        PdfPTable metaTable = new PdfPTable(2);
                        metaTable.WidthPercentage = 100;
                        metaTable.SetWidths(new float[] { 1f, 1f });

                        // Row 1
                        metaTable.AddCell(new PdfPCell(new Phrase($"Reply Slip ID: {tbReplyID.Text.Trim()}", bodyFont)) { Border = PdfPCell.NO_BORDER, PaddingBottom = 10f });
                        metaTable.AddCell(new PdfPCell(new Phrase($"Order ID: {tbReplyOrderID.Text.Trim()}", bodyFont)) { Border = PdfPCell.NO_BORDER, PaddingBottom = 10f });

                        // Row 2
                        metaTable.AddCell(new PdfPCell(new Phrase($"Delivery Note ID: {cmbDeliveryID.SelectedItem?.ToString()}", bodyFont)) { Border = PdfPCell.NO_BORDER, PaddingBottom = 10f });
                        metaTable.AddCell(new PdfPCell(new Phrase($"Delivery Status: Completed", bodyFont)) { Border = PdfPCell.NO_BORDER, PaddingBottom = 10f });

                        // Row 3
                        metaTable.AddCell(new PdfPCell(new Phrase($"Recipient: {tbReplyCustName.Text.Trim()}", bodyFont)) { Border = PdfPCell.NO_BORDER, PaddingBottom = 10f });
                        metaTable.AddCell(new PdfPCell(new Phrase($"Delivery Date: {dateDeliveryDate.Value.ToString("yyyy-MM-dd")}", bodyFont)) { Border = PdfPCell.NO_BORDER, PaddingBottom = 10f });

                        // 【已修正】將原本多餘且打錯標題的第 7 個 Cell 移除，改放到下方的全幅地址欄位

                        document.Add(metaTable);

                        // --- 3. 全幅地址區塊 ---
                        Paragraph addressHeader = new Paragraph("Delivery Address:", headerFont);
                        addressHeader.SpacingBefore = 10f;
                        document.Add(addressHeader);

                        // 【已修正】控制項名稱由 tbAddress 改為 tbReplyAddress
                        Paragraph addressContent = new Paragraph(tbReplyAddress.Text.Trim(), bodyFont);
                        addressContent.SpacingAfter = 20f;
                        document.Add(addressContent);

                        // --- 4. 訂單項目表格明細 ---
                        // 【已修正】將所有的 dataGridView1 修正為實際綁定資料的 dataGridView3
                        int visibleColumnCount = 0;
                        foreach (DataGridViewColumn col in dataGridView3.Columns)
                        {
                            if (col.Visible) visibleColumnCount++;
                        }

                        if (visibleColumnCount > 0)
                        {
                            PdfPTable dataTable = new PdfPTable(visibleColumnCount);
                            dataTable.WidthPercentage = 100;

                            // 建立表頭
                            foreach (DataGridViewColumn col in dataGridView3.Columns)
                            {
                                if (col.Visible)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, headerFont));
                                    cell.BackgroundColor = new BaseColor(240, 240, 240); // 淺灰色背景
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    cell.Padding = 6f;
                                    dataTable.AddCell(cell);
                                }
                            }

                            // 填入表格資料
                            for (int i = 0; i < dataGridView3.Rows.Count; i++)
                            {
                                if (dataGridView3.Rows[i].IsNewRow) continue;

                                foreach (DataGridViewColumn col in dataGridView3.Columns)
                                {
                                    if (col.Visible)
                                    {
                                        string cellValue = dataGridView3.Rows[i].Cells[col.Index].Value?.ToString() ?? "";
                                        PdfPCell cell = new PdfPCell(new Phrase(cellValue, bodyFont));
                                        cell.Padding = 6f;

                                        // 靠右對齊金流與數字欄位
                                        if (col.Name.Contains("Price") || col.Name.Contains("Subtotal") || col.Name.Contains("Quantity") || col.Name.Contains("ItemID"))
                                        {
                                            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                                        }
                                        else
                                        {
                                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                                        }
                                        dataTable.AddCell(cell);
                                    }
                                }
                            }
                            document.Add(dataTable);
                        }

                        MessageBox.Show("Reply Slip PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to build PDF document: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // 【已優化】更安全地關閉與釋放檔案資源
                        if (document.IsOpen())
                        {
                            document.Close();
                        }
                        if (fs != null)
                        {
                            fs.Dispose();
                        }
                    }
                }
            }
        }

        private void CreateDeliveryNoteAudit(string deliverynoteID)
        {
            try
            {
                CurrentUser.CreateOrder(CurrentUser.UserID, CurrentUser.Username,
                                      CurrentUser.Role, CurrentUser.Email);

                AuditHelper.Log("deliverynote", deliverynoteID, "Create deliverynote", CurrentUser.UserID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void CreateReplySlipAudit(string replySlipID)
        {
            try
            {
                CurrentUser.CreateOrder(CurrentUser.UserID, CurrentUser.Username,
                                      CurrentUser.Role, CurrentUser.Email);
                AuditHelper.Log("replyslip", replySlipID, "Create replyslip", CurrentUser.UserID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }
    }
}
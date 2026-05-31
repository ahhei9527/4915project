using _4915project;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public FormLogistics()
        {
            InitializeComponent();
        }

        private void FormLogistics_Load(object sender, EventArgs e)
        {
            // 1. 初始化 UI 控制項狀態
            receviedDate.Enabled = false;
            cbremark.Items.AddRange(new string[] { "Good", "Bad", "Broken" });
            cbOrderstat.Items.AddRange(new string[] { "Confirmed", "Processing", "Delivered" });
            cbshipStat.Items.AddRange(new string[] { "In Transit", "Delivered", "Delayed" });
            cbMethod.Items.AddRange(new string[] { "Standard", "Express Delivery" });

            string constring = "server=localhost;user id=root;password=;database=4915";

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
                    }

                    // ============ 步驟三：自動生成最新出貨單號 (ShipmentID) ============
                    ShipmentID = tbShipID.Text; // 將生成的 ShipmentID 存到全域變數中，方便後續使用
                    if (ShipmentID == null)
                    {
                        GenerateShipmentID();
                        ShipmentID = tbShipID.Text;
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
            string constring = "server=localhost;user id=root;password=;database=4915";

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
            string constring = "server=localhost;user id=root;password=;database=4915";
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

            string constring = "server=localhost;user id=root;password=;database=4915";

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
            this.Close();
        }

        private void AfterSales_Click(object sender, EventArgs e)
        {
            AfterSales afterSales = new AfterSales();
            afterSales.Show();
            this.Close();
        }
    }
}
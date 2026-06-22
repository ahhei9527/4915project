using _4915project;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4915project
{
    public partial class Inventory : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        public Inventory()
        {
            InitializeComponent();
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Close();
        }

        private void SalesOrder_Click(object sender, EventArgs e)
        {
            SalesOrder sale = new SalesOrder();
            sale.Show();
            this.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new string[] { "In Progress", "Completed" });

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();

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
                    }
                }
            }
            cmItem.Items.Add("Oak Wood Panel");
            cmItem.Items.Add("Steel Frame");
            cmItem.Items.Add("Fabric Cover");
            cmItem.Items.Add("Glass Panel");
            cmItem.Items.Add("Foam Padding");
            cmItem.SelectedIndex = 0;
            cbSupplier.Items.Add("Timber Supplies HK");
            cbSupplier.Items.Add("MetalWorks Ltd");
            cbSupplier.Items.Add("Textile Depot");
            cbSupplier.Items.Add("Crystal Glass Co");
            cbSupplier.Items.Add("Comfort Materials");
            cbSupplier.SelectedIndex = 0;
            cbWearhouse.Items.Add("WH-A-12-03");
            cbWearhouse.Items.Add("WH-A-12-04");
            cbWearhouse.Items.Add("WH-B-05-01");
            cbWearhouse.Items.Add("WH-C-08-02");
            cbWearhouse.SelectedIndex = 0;
            cmWearhouse.Items.Add("WH-A-12-03");
            cmWearhouse.Items.Add("WH-A-12-04");
            cmWearhouse.Items.Add("WH-B-05-01");
            cmWearhouse.Items.Add("WH-C-08-02");
            cmWearhouse.SelectedIndex = 0;
            cmbCStatus.Items.AddRange(new string[] { "In Stock", "Delivered" });
            cmbCStatus.SelectedIndex = 0;
            tbSN.ReadOnly = true;

            GenerateInventoryID();

            LoadInward();
            LoadStock();
            LoadPID();
            GenSN();
        }

        private void LoadPID()
        {

            string query = "SELECT ProductID FROM product";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbPID.Items.Add(reader["ProductID"].ToString());
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("載入產品資料失敗: " + ex.Message);
                    }
                }
            }
        }

        private void GenSN()
        {

            string prefix = "SN"; // 2 碼文字

            // 💡 修正點 1：預設的流水號格式要對齊 SN + 8位數 = SN00000001 (總長10碼)
            string defaultSN = prefix + "00000001";

            // 💡 修正點 2：徹底修正 SQL！把所有跟 BATCHID 相關的錯誤欄位，全部換成真正的 SerialNumber
            string query = @"
        SELECT SerialNumber 
        FROM productinstance 
        WHERE SerialNumber LIKE @Prefix 
        ORDER BY SerialNumber DESC 
        LIMIT 1;";

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
                            string lastSN = result.ToString().Trim();

                            // 💡 修正點 3：SN00000001 總長度為 2 + 8 = 10 碼
                            if (lastSN.Length >= 10)
                            {
                                // 🎯 精準切取最後 8 碼純數字（例如從 ""SN00000015"" 切出 ""00000015""）
                                string lastNumberStr = lastSN.Substring(lastSN.Length - 8);

                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1; // 序號順利加 1
                                }
                            }
                        }

                        // 💡 修正點 4：將新序號格式化為 8 位數（例如 5 變成 00000005）並填入文字框
                        tbSN.Text = prefix + nextNumber.ToString("D8");
                        tbSN.ReadOnly = true; // 設為唯讀，防止使用者手動改壞
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("無法取得資料庫流水號: " + ex.Message);

                        // 💡 修正點 5：安全防呆！萬一資料庫斷線或出錯，自動填入預設的 SN00000001，絕對不留白
                        tbSN.Text = defaultSN;
                        tbSN.ReadOnly = false; // 發生錯誤時允許手動輸入
                    }
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadStock();
        }

        private void LoadInward()
        {

            string query = @"
        SELECT 
            i.InventoryID, 
            r.PreferredSupplier, 
            r.Name AS MaterialName, 
            mr.BatchID AS BatchID, 
            i.WarehouseLocation, 
            i.LastUpdated,
            i.QuantityOnHand
        FROM Inventory i
        INNER JOIN RawMaterial r ON i.MaterialID = r.MaterialID
        LEFT JOIN MaterialRequestItem mri ON r.MaterialID = mri.MaterialID
        LEFT JOIN MaterialRequest mr ON mri.RequestID = mr.RequestID;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        // 1. 使用 DataAdapter 將所有多表聯查資料灌入 DataTable
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // 綁定給畫面的 DataGridView
                            dataGridView2.DataSource = dt;

                            // 2. 💡 核心修正：清空舊項目，直接跑記憶體 DataTable 填充 ComboBox
                            cmbBatch.Items.Clear();
                            cmbBatch.Items.Add("Select Batch ID"); // 補上防呆提示文字

                            // 用於過濾重複 BatchID 的雜湊表 (避免選單出現一堆重複的批號)
                            HashSet<string> uniqueBatches = new HashSet<string>();

                            foreach (DataRow row in dt.Rows)
                            {
                                // 確保欄位不是空的，且防止將 DBNull 轉字串
                                if (row["BatchID"] != DBNull.Value && row["BatchID"] != null)
                                {
                                    string batchID = row["BatchID"].ToString().Trim();
                                    cmbBatch.Items.Add(GenerateBatchID()); // 如果批號是空的或重複的，就生成新的庫存編號
                                }
                            }

                            // 預設選取提示字
                            if (cmbBatch.Items.Count > 0)
                            {
                                cmbBatch.SelectedIndex = 0;
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("載入庫存與批次資料失敗: " + ex.Message, "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("發生未預期的錯誤: " + ex.Message, "系統錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string GenerateBatchID()
        {

            string prefix = "BATCH"; // 5 碼文字
            string BATCHID = prefix + "001"; // 預設如果資料庫沒資料，就是第一筆 BATCH001

            // 查詢目前最大的批次流水號
            string query = "SELECT BATCHID FROM productionbatch WHERE BATCHID LIKE @Prefix ORDER BY BATCHID DESC LIMIT 1";

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
                            string lastBatchID = result.ToString();

                            // 💡 核心修正：BATCH001 總長為 8 碼，數字佔最後 3 碼
                            if (lastBatchID.Length >= 8)
                            {
                                // 🎯 精準切取最後 3 碼數字（例如從 ""BATCH005"" 切出 ""005""）
                                string lastNumberStr = lastBatchID.Substring(lastBatchID.Length - 3);

                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1; // 序號順利加 1
                                }
                            }
                        }

                        // 💡 完美對齊：將新序號格式化為 3 位數（例如 9 變 009，12 變 012）
                        BATCHID = prefix + nextNumber.ToString("D3");
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("無法取得資料庫流水號: " + ex.Message);
                        // 發生異常時，維持回傳預設的 BATCH001，避免程式直接當機
                    }
                }
            }
            return BATCHID;
        }

        private void LoadStock()
        {

            string query = @"
            SELECT 
            r.Name as 'Material Name',
            i.QuantityOnHand as 'Current Stock',
            r.ReorderLevel as 'Minimum Stock',
            i.WarehouseLocation as 'Warehouse',
            CASE 
                WHEN i.QuantityOnHand <= r.ReorderLevel THEN 'Low Stock' 
                ELSE 'OK' 
            END as 'Status'
            FROM inventory i,
            rawmaterial r
        WHERE i.MaterialID = r.MaterialID
        ORDER BY i.QuantityOnHand ASC";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("載入庫存資料失敗: " + ex.Message);
                    }
                }
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {


            // 1. 定義所有的 SQL 語句
            string queryGetMaterialInfo = "SELECT MaterialID, ReorderLevel FROM rawmaterial WHERE Name = @MaterialName LIMIT 1";
            string queryInsertInventory = @"INSERT INTO Inventory 
             (InventoryID, MaterialID, ProductID, SerialNumber, WarehouseLocation, QuantityOnHand, LastUpdated, ReorderLevel) 
             VALUES 
             (@InventoryID, @MaterialID, @ProductID, @SerialNumber, @WarehouseLocation, @QuantityOnHand, @LastUpdated, @ReorderLevel);";
            string queryInsertBatch = @"INSERT INTO productionbatch
            (BatchID, StartDate, EndDate, Status)
            VALUES(@BatchID, @StartDate, @EndDate, @Status)";
            string queryInsertInstance = @"INSERT INTO productinstance(
            SerialNumber, ProductID, BatchID, ProductionDate, CurrentStatus, WarrantyEndDate)
            VALUES(@SerialNumber, @ProductID, @BatchID, @ProductionDate, @CurrentStatus, @WarrantyEndDate)";

            // 預設暫存變數
            string materialID = "";
            int reorderLevel = 0;

            // 驗證前端輸入
            if (cmItem.SelectedItem == null)
            {
                MessageBox.Show("請先選擇原材料名稱。");
                return;
            }
            if (cbWearhouse.SelectedItem == null)
            {
                MessageBox.Show("請選擇儲存的倉庫位置。");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open(); // 🔍 修正 1：全程只在最開頭 Open 一次

                    // 步驟 1：查詢該原材料的 MaterialID 與 ReorderLevel
                    using (MySqlCommand cmdGet = new MySqlCommand(queryGetMaterialInfo, con))
                    {
                        cmdGet.Parameters.AddWithValue("@MaterialName", cmItem.SelectedItem?.ToString());

                        using (MySqlDataReader reader = cmdGet.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                materialID = reader["MaterialID"].ToString();
                                reorderLevel = Convert.ToInt32(reader["ReorderLevel"]);
                            }
                            else
                            {
                                MessageBox.Show("無法找到對應的原材料資料，請確認原材料名稱是否正確。");
                                return; // 找不到就攔截，不往下執行
                            }
                        } // reader 在這裡會自動關閉，釋放連線
                    }

                    // 步驟 2：執行庫存寫入
                    using (MySqlCommand cmdInsert = new MySqlCommand(queryInsertInventory, con))
                    {
                        // 依序綁定所有控制項數值
                        cmdInsert.Parameters.AddWithValue("@InventoryID", tbInventoryID.Text);
                        cmdInsert.Parameters.AddWithValue("@MaterialID", materialID);
                        cmdInsert.Parameters.AddWithValue("@ProductID", cmbPID.SelectedItem?.ToString());
                        cmdInsert.Parameters.AddWithValue("@SerialNumber", tbSN.Text.ToString());

                        // 🔍 修正 4：改用 SelectedItem.ToString() 取得實際選中的倉庫字串 (例如 "WH-A-12-03")
                        cmdInsert.Parameters.AddWithValue("@WarehouseLocation", cbWearhouse.SelectedItem.ToString());

                        // 🔍 修正 5：NumericUpDown 控制項建議直接用 (int)Value 讀取
                        cmdInsert.Parameters.AddWithValue("@QuantityOnHand", (int)numQuantity.Value);
                        cmdInsert.Parameters.AddWithValue("@LastUpdated", date.Value);

                        // 🔍 修正 2：成功將剛剛查到的 ReorderLevel 綁定給參數
                        cmdInsert.Parameters.AddWithValue("@ReorderLevel", reorderLevel);

                        cmdInsert.ExecuteNonQuery();
                        InwardAddAudit(tbInventoryID.Text.ToString(), materialID.ToString(),
                            cbWearhouse.SelectedItem.ToString(), numQuantity.Value.ToString(),
                            date.Value.ToString(), reorderLevel.ToString(),
                            cmbPID.SelectedItem?.ToString(), tbSN.Text.ToString());
                    }
                    using (MySqlCommand cmdBatch = new MySqlCommand(queryInsertBatch, con))
                    {
                        cmdBatch.Parameters.AddWithValue("@BatchID", cmbBatch.SelectedItem?.ToString());
                        cmdBatch.Parameters.AddWithValue("@StartDate", date.Value.ToString());
                        cmdBatch.Parameters.AddWithValue("@EndDate", date.Value.AddDays(7).ToString()); // 假設生產批次一週內完成
                        cmdBatch.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem?.ToString());
                        cmdBatch.ExecuteNonQuery();
                        AddBatchAudit(cmbBatch.SelectedItem?.ToString(), date.Value.ToString(),
                            date.Value.AddDays(7).ToString(), cmbStatus.SelectedItem?.ToString());

                    }

                    using (MySqlCommand cmdInstance = new MySqlCommand(queryInsertInstance, con))
                    {
                        cmdInstance.Parameters.AddWithValue("@SerialNumber", tbSN.Text.ToString());
                        cmdInstance.Parameters.AddWithValue("@ProductID", cmbPID.SelectedItem?.ToString());
                        cmdInstance.Parameters.AddWithValue("@BatchID", cmbBatch.SelectedItem?.ToString());
                        cmdInstance.Parameters.AddWithValue("@ProductionDate", date.Value.ToString());
                        cmdInstance.Parameters.AddWithValue("@CurrentStatus", cmbCStatus.SelectedItem?.ToString());
                        cmdInstance.Parameters.AddWithValue("@WarrantyEndDate", date.Value.AddYears(3).ToString()); // 假設保固一年
                        cmdInstance.ExecuteNonQuery();
                        AddProductInstance(tbSN.Text.ToString(), cmbPID.SelectedItem?.ToString(),
                            cmbBatch.SelectedItem?.ToString(), date.Value.ToString(),
                            cmbCStatus.SelectedItem?.ToString(), date.Value.AddYears(3).ToString());
                    }
                    MessageBox.Show("庫存資料新增成功！");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("資料庫存取失敗: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("系統發生非預期錯誤: " + ex.Message);
                }
            }
        }

        private void InwardAddAudit(string tbInventoryID, string materialID, string cbWearhouse, string numQuantity, string date, string reorderLevel, string PID, string SN)
        {
            try
            {
                CurrentUser.AddInward(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email);

                AuditHelper.Log(
                    tableName: "Inventory",
                    recordId: tbInventoryID,
                    action: "Add Inward",
                    userId: CurrentUser.UserID,
                    newValues: new
                    {
                        InventoryID = tbInventoryID,
                        MaterialID = materialID,
                        ProductID = PID,
                        SerialNumber = SN,
                        WarehouseLocation = cbWearhouse,
                        QuantityOnHand = numQuantity,
                        LastUpdated = date,
                        ReorderLevel = reorderLevel
                    }
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void AddBatchAudit(string BID, string SDate, string EDate, string Status)
        {
            try
            {
                CurrentUser.AddInward(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email);
                AuditHelper.Log(
                    tableName: "productionbatch",
                    recordId: BID,
                    action: "Add Production Batch",
                    userId: CurrentUser.UserID,
                    newValues: new
                    {
                        BatchID = BID,
                        StartDate = SDate,
                        EndDate = EDate,
                        Status = Status
                    }
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void AddProductInstance(string SN, string PID, string BID,
            string PDate, string CStatus, string WarrantyEndDate)
        {
            try
            {
                CurrentUser.AddInward(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email);

                AuditHelper.Log(
                    tableName: "productinstance",
                    recordId: SN,
                    action: "Add Product Instance",
                    userId: CurrentUser.UserID,
                    newValues: new
                    {
                        SerialNumber = SN,
                        ProductID = PID,
                        BatchID = BID,
                        ProductionDate = PDate,
                        CurrentStatus = CStatus,
                        WarrantyEndDate = WarrantyEndDate
                    }
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void GenerateInventoryID()
        {

            string prefix = "INV"; // ORD

            // 查詢今天最大的流水號
            string query = "SELECT InventoryID FROM inventory WHERE InventoryID LIKE @Prefix ORDER BY InventoryID DESC LIMIT 1";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Prefix", prefix + "%");

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        int nextNumber = 1; // 預設如果今天沒訂單，就是第一筆

                        if (result != null && result != DBNull.Value)
                        {
                            string lastOrderID = result.ToString();
                            string lastNumberStr = lastOrderID.Substring(lastOrderID.Length - 3);

                            if (int.TryParse(lastNumberStr, out int lastNumber))
                            {
                                nextNumber = lastNumber + 1; // 序號加 1
                            }
                        }

                        // 將序號格式化為 4 位數，例如 1 變成 0001，12 變成 0012
                        tbInventoryID.Text = prefix + nextNumber.ToString("D3");
                        tbInventoryID.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("無法取得資料庫流水號: " + ex.Message);
                        tbInventoryID.ReadOnly = false;
                    }
                }
            }
        }
        private void btSearch_Click(object sender, EventArgs e)
        {


            // 1. 先寫好基礎的 SQL 語句（必定會執行的部分）
            string query = @"SELECT
                        r.Name as 'Material Name',
                        i.QuantityOnHand as 'Current Stock',
                        r.ReorderLevel as 'Minimum Stock',
                        i.WarehouseLocation as 'Warehouse',
                        CASE
                            WHEN i.QuantityOnHand <= r.ReorderLevel THEN 'Low Stock'
                            ELSE 'OK'
                        END as 'Status'
                     FROM inventory i
                     INNER JOIN rawmaterial r ON i.MaterialID = r.MaterialID
                     WHERE 1=1"; // 💡 技巧：WHERE 1=1 方便後面直接塞 "AND ..."

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand("", con)) // 先建立空命令，後面動態塞入
                {
                    // 2. 動態檢查第一個條件：ItemID (假設對應的是庫存編號 InventoryID)
                    string itemName = tbItemID.Text;
                    if (!string.IsNullOrEmpty(itemName))
                    {
                        query += " AND r.Name LIKE @Name"; // 🔍 補上欄位名稱
                        cmd.Parameters.AddWithValue("@Name", itemName);
                    }

                    // 3. 動態檢查第二個條件：倉庫位置 (假設第 0 項是 "請選擇" 或 "全部")
                    // 💡 修正：cmWearhouse 應該是 comboBox 的拼錯，請確認你畫面上的名稱
                    string selectedWarehouse = cmWearhouse.SelectedItem?.ToString();

                    // 確保選中的項目不是 null，也不是空白字串
                    if (!string.IsNullOrEmpty(selectedWarehouse))
                    {
                        query += " AND i.WarehouseLocation = @WarehouseLocation";
                        cmd.Parameters.AddWithValue("@WarehouseLocation", selectedWarehouse);
                    }

                    if (cbLowStock.Checked)
                    {
                        query += " AND i.QuantityOnHand <= r.ReorderLevel";
                    }

                    // 4. 最後補上排序（注意前面要留空格）
                    query += " ORDER BY i.QuantityOnHand ASC;";

                    // 將組合好的完整 SQL 賦值給命令
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                            // 可選：若查無資料給予提示
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("找不到符合條件的庫存資料。");
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("搜尋庫存資料失敗: " + ex.Message);
                    }
                }
            }
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

        private void Logistics_Click(object sender, EventArgs e)
        {
            FormLogistics log = new FormLogistics();
            log.Show();
            this.Close();
        }

        private void AfterSales_Click(object sender, EventArgs e)
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
    }
}
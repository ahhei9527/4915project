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
            GenerateBatchID();
            GenerateInventoryID();
            LoadInward();
            LoadBatchIDs();
            LoadStock();
            LoadPID();
            GenSN();
        }

        private void LoadPID()
        {
            string query = "SELECT ProductID FROM product";
            List<string> productIds = new List<string>();

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
                                productIds.Add(reader["ProductID"].ToString());
                            }
                        }

                        // 優化 UI 寫入效能
                        cmbPID.BeginUpdate();
                        cmbPID.Items.Clear();
                        cmbPID.Items.AddRange(productIds.ToArray());
                        cmbPID.EndUpdate();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Failed to load product information: " + ex.Message);
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
            // 💡 最終加強版：把產品序號 (SerialNumber) 也一併撈出顯示在表格中
            string query = @"
            SELECT 
                i.InventoryID, 
                r.PreferredSupplier, 
                r.Name AS MaterialName, 
                pi.SerialNumber AS 'Serial Number', -- 🎯 新增：讓表格多一欄顯示產品序號
                COALESCE(pi.BatchID, 'No Batch') AS BatchID,  
                i.WarehouseLocation, 
                i.LastUpdated,
                i.QuantityOnHand
            FROM Inventory i
            INNER JOIN RawMaterial r ON i.MaterialID = r.MaterialID
            LEFT JOIN productinstance pi ON i.SerialNumber = pi.SerialNumber 
            ORDER BY i.InventoryID DESC;";

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
                            dataGridView2.DataSource = dt;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Failed to load inventory list: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string GenerateBatchID()
        {
            string prefix = "BATCH";
            string BATCHID = prefix + "001"; // 💡 當資料庫被您清空、完全沒資料時，預設會從 BATCH001 開始發放
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
                            string lastBatchID = result.ToString().Trim();

                            // 確保長度足夠，避免 Substring 發生 ArgumentOutOfRangeException 錯誤
                            if (lastBatchID.Length >= 8)
                            {
                                string lastNumberStr = lastBatchID.Substring(lastBatchID.Length - 3);

                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1; // 順利取得下一碼數字
                                }
                                else
                                {
                                    // 💡 改進 1：若格式有誤，彈窗提示管理員，但不直接讓程式閃退
                                    MessageBox.Show($"Database BatchID format is invalid ({lastBatchID}). Fallback to BATCH001.", "Data Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }

                        // 格式化為 3 位數（如 1 變成 001，12 變成 012）
                        BATCHID = prefix + nextNumber.ToString("D3");
                    }
                    catch (MySqlException ex)
                    {
                        // 💡 改進 2：明確捕獲資料庫異常，提示錯誤訊息
                        MessageBox.Show("Failed to query next Batch ID from database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return prefix + "001"; // 發生錯誤時回傳安全預設值，確保主流程能繼續走下去
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred while generating Batch ID: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return prefix + "001";
                    }
                }
            }
            return BATCHID;
        }

        private void LoadBatchIDs()
        {
            // 直接查詢真實的批次資料表，保證剛寫入的新批號能立刻被抓到
            string query = "SELECT BATCHID FROM productionbatch ORDER BY BATCHID DESC";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        List<string> batchList = new List<string>();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["BATCHID"] != DBNull.Value)
                                {
                                    batchList.Add(reader["BATCHID"].ToString().Trim());
                                }
                            }
                        }

                        // 批次更新 ComboBox 畫面，防止卡頓
                        cmbBatch.BeginUpdate();
                        cmbBatch.Items.Clear();
                        cmbBatch.Items.Add("Select Batch ID");
                        cmbBatch.Items.AddRange(batchList.ToArray());

                        if (cmbBatch.Items.Count > 0)
                        {
                            cmbBatch.SelectedIndex = 0; // 預設選中提示字或最新批號
                        }
                        cmbBatch.EndUpdate();
                    }
                    catch (MySqlException ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Failed to load batch list: " + ex.Message);
                    }
                }
            }
        }

        private void LoadStock()
        {
            // 💡 修正 1：改用標準的 INNER JOIN 語法，結構更清晰且不易出錯
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
    FROM inventory i
    INNER JOIN rawmaterial r ON i.MaterialID = r.MaterialID
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

                            // 💡 優化 2：動態綁定格式化事件（只需綁定一次，或直接在 Form_Load 綁定）
                            dataGridView1.CellFormatting -= DataGridView1_CellFormatting;
                            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Failed to load inventory data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 🎯 新增事件：當庫存不足時，將該列或該格塗上紅色警告
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 檢查目前格式化的欄位是否為 "Status" 欄位
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                if (e.Value.ToString() == "Low Stock")
                {
                    // 將 "Status" 這格變成紅底白字
                    e.CellStyle.BackColor = Color.LightPink;
                    e.CellStyle.ForeColor = Color.DarkRed;
                    e.CellStyle.SelectionBackColor = Color.Red; // 選取時的顏色

                    /* 
                    // 💡 如果您希望「整列」都變紅底，可以改用以下程式碼：
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                    */
                }
                else
                {
                    // 恢復預設顏色（避免捲動時顏色錯亂）
                    e.CellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            // 1. 純粹的新增 SQL 語句
            string queryGetMaterialInfo = "SELECT MaterialID, ReorderLevel FROM rawmaterial WHERE Name = @MaterialName LIMIT 1";
            string queryInsertInventory = @"INSERT INTO Inventory (InventoryID, MaterialID, ProductID, SerialNumber, WarehouseLocation, QuantityOnHand, LastUpdated, ReorderLevel) VALUES (@InventoryID, @MaterialID, @ProductID, @SerialNumber, @WarehouseLocation, @QuantityOnHand, @LastUpdated, @ReorderLevel);";
            string queryInsertBatch = @"INSERT INTO productionbatch (BatchID, StartDate, EndDate, Status) VALUES (@BatchID, @StartDate, @EndDate, @Status)";
            string queryInsertInstance = @"INSERT INTO productinstance (SerialNumber, ProductID, BatchID, ProductionDate, CurrentStatus, WarrantyEndDate) VALUES (@SerialNumber, @ProductID, @BatchID, @ProductionDate, @CurrentStatus, @WarrantyEndDate)";
            string materialID = "";
            int reorderLevel = 0;

            // 💡 1. 核心鎖定：在最開頭就把要用的 BatchID 死死鎖定在 targetBatchID 變數中
            string targetBatchID = "";

            if (cmbBatch.SelectedItem != null && !cmbBatch.SelectedItem.ToString().StartsWith("Select", StringComparison.OrdinalIgnoreCase))
            {
                targetBatchID = cmbBatch.SelectedItem.ToString().Trim(); // 🎯 這裡正確拿到了 "BATCH008"
            }
            else if (!string.IsNullOrEmpty(cmbBatch.Text) && !cmbBatch.Text.StartsWith("Select", StringComparison.OrdinalIgnoreCase))
            {
                targetBatchID = cmbBatch.Text.Trim();
            }
            else
            {
                targetBatchID = GenerateBatchID();
            }

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                MySqlTransaction tran = null;
                try
                {
                    con.Open();

                    // 步驟 1：查詢原材料資訊... (略)

                    tran = con.BeginTransaction();

                    // 步驟 2：直接執行庫存 INSERT
                    using (MySqlCommand cmdInv = new MySqlCommand(queryInsertInventory, con, tran))
                    {
                        cmdInv.Parameters.AddWithValue("@InventoryID", tbInventoryID.Text.Trim());
                        cmdInv.Parameters.AddWithValue("@MaterialID", materialID);
                        cmdInv.Parameters.AddWithValue("@ProductID", cmbPID.SelectedItem?.ToString() ?? "");
                        cmdInv.Parameters.AddWithValue("@SerialNumber", tbSN.Text.Trim());
                        cmdInv.Parameters.AddWithValue("@WarehouseLocation", cbWearhouse.SelectedItem.ToString());
                        cmdInv.Parameters.AddWithValue("@QuantityOnHand", (int)numQuantity.Value);
                        cmdInv.Parameters.AddWithValue("@LastUpdated", date.Value);
                        cmdInv.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
                        cmdInv.ExecuteNonQuery();
                    }

                    // 步驟 3：防撞號檢查 (確保檢查的是 targetBatchID)
                    bool isBatchExist = false;
                    string queryCheckBatch = "SELECT COUNT(*) FROM productionbatch WHERE BatchID = @BatchID";
                    using (MySqlCommand cmdCheck = new MySqlCommand(queryCheckBatch, con, tran))
                    {
                        cmdCheck.Parameters.AddWithValue("@BatchID", targetBatchID); // 💡 帶入 BATCH008
                        isBatchExist = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0;
                    }

                    if (!isBatchExist)
                    {
                        using (MySqlCommand cmdBatch = new MySqlCommand(queryInsertBatch, con, tran))
                        {
                            // ❌ 核心檢查點：請確認您原本這裡有沒有誤寫成 GenerateBatchID()？
                            // 🎯 修正：必須一律帶入鎖定好的 targetBatchID 變數！
                            cmdBatch.Parameters.AddWithValue("@BatchID", targetBatchID);
                            cmdBatch.Parameters.AddWithValue("@StartDate", date.Value);
                            cmdBatch.Parameters.AddWithValue("@EndDate", date.Value.AddDays(7));
                            cmdBatch.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem?.ToString() ?? "Pending");
                            cmdBatch.ExecuteNonQuery();
                        }
                    }

                    // 步驟 4：產品個體執行個體處理 (INSERT)
                    using (MySqlCommand cmdInstance = new MySqlCommand(queryInsertInstance, con, tran))
                    {
                        cmdInstance.Parameters.AddWithValue("@SerialNumber", tbSN.Text.Trim());
                        cmdInstance.Parameters.AddWithValue("@ProductID", cmbPID.SelectedItem?.ToString() ?? "");

                        // ❌ 核心檢查點：請確認您原本這裡有沒有誤打成 GenerateBatchID()？
                        // 🎯 修正：一律帶入鎖定好的 targetBatchID 變數！
                        cmdInstance.Parameters.AddWithValue("@BatchID", targetBatchID);
                        cmdInstance.Parameters.AddWithValue("@ProductionDate", date.Value);
                        cmdInstance.Parameters.AddWithValue("@CurrentStatus", cmbCStatus.SelectedItem?.ToString() ?? "OK");
                        cmdInstance.Parameters.AddWithValue("@WarrantyEndDate", date.Value.AddYears(3));
                        cmdInstance.ExecuteNonQuery();
                    }

                    tran.Commit();
                    MessageBox.Show($"New record successfully added! Assigned Batch ID: {targetBatchID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    tran?.Rollback();
                    MessageBox.Show("Failed to save: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 數據刷新與強制同步
            LoadInward();
            LoadBatchIDs();

            // 強迫 ComboBox 選中我們剛剛指定的 targetBatchID (如 BATCH008)
            int index = cmbBatch.FindStringExact(targetBatchID);
            if (index != -1)
            {
                cmbBatch.SelectedIndex = index;
            }
            else
            {
                cmbBatch.Text = targetBatchID;
            }

            LoadStock();
            LoadPID();
            GenSN();
            GenerateInventoryID();
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
            // 1. 定義基礎的 SQL 語句
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
             WHERE 1=1"; // 💡 技巧：WHERE 1=1 方便後面動態串接 "AND ..."

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand("", con))
                {
                    // 2. 動態檢查第一個條件：物料名稱關鍵字查詢 (支援模糊搜尋)
                    string itemName = tbItemID.Text.Trim();
                    if (!string.IsNullOrEmpty(itemName))
                    {
                        query += " AND r.Name LIKE @Name";
                        cmd.Parameters.AddWithValue("@Name", "%" + itemName + "%"); // 💡 加上 % 才能達成模糊搜尋
                    }

                    // 3. 動態檢查第二個條件：倉庫位置 (排除未選擇、"Select..." 或 "All" 的情況)
                    if (cbWearhouse.SelectedItem != null)
                    {
                        string selectedWarehouse = cbWearhouse.SelectedItem.ToString();

                        // 排除預設的提示字（請根據您實際的 UI 填入文字，例如 "All" 或 "Select Warehouse"）
                        if (selectedWarehouse != "Select Location" && selectedWarehouse != "All" && !string.IsNullOrEmpty(selectedWarehouse))
                        {
                            query += " AND i.WarehouseLocation = @WarehouseLocation";
                            cmd.Parameters.AddWithValue("@WarehouseLocation", selectedWarehouse);
                        }
                    }

                    // 4. 動態檢查第三個條件：是否勾選「只顯示庫存不足」
                    if (cbLowStock.Checked)
                    {
                        query += " AND i.QuantityOnHand <= r.ReorderLevel";
                    }

                    // 5. 最後補上排序
                    query += " ORDER BY i.QuantityOnHand ASC;";

                    // 將組合好的完整 SQL 字串賦值給 Command
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                            // 若查無資料，給予友善提示
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No matching inventory data could be found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Search for inventory data failed: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Production_Click(object sender, EventArgs e)
        {
            Production production = new Production();
            production.Show();
            this.Close();
        }
    }
}
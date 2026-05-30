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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ITP4915M
{
    public partial class Inventory : Form
    {
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
            string constring = "server=localhost;user id=root;password=;database=4915";
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

            GenerateInventoryID();

            LoadInward();
            LoadStock();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadStock();
        }

        private void LoadInward()
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
            string query = @"
                SELECT 
                    i.InventoryID, 
                    r.PreferredSupplier, 
                    r.Name AS MaterialName, 
                    mr.BatchID AS BatchID, -- 從領料單追蹤批次
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
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView2.DataSource = dt;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("載入庫存資料失敗: " + ex.Message);
                    }
                }
            }
        }

        private void LoadStock()
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
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
            string constring = "server=localhost;user id=root;password=;database=4915";

            // 1. 定義所有的 SQL 語句
            string queryGetMaterialInfo = "SELECT MaterialID, ReorderLevel FROM RawMaterial WHERE Name = @MaterialName LIMIT 1";
            string queryInsertInventory = @"INSERT INTO Inventory 
             (InventoryID, MaterialID, WarehouseLocation, QuantityOnHand, LastUpdated, ReorderLevel) 
             VALUES 
             (@InventoryID, @MaterialID, @WarehouseLocation, @QuantityOnHand, @LastUpdated, @ReorderLevel);";

            // 預設暫存變數
            string materialID = "";
            int reorderLevel = 0;

            // 驗證前端輸入
            if (cbSupplier.SelectedItem == null)
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
                        cmdGet.Parameters.AddWithValue("@MaterialName", cbSupplier.SelectedItem.ToString());

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

                        // 🔍 修正 4：改用 SelectedItem.ToString() 取得實際選中的倉庫字串 (例如 "WH-A-12-03")
                        cmdInsert.Parameters.AddWithValue("@WarehouseLocation", cbWearhouse.SelectedItem.ToString());

                        // 🔍 修正 5：NumericUpDown 控制項建議直接用 (int)Value 讀取
                        cmdInsert.Parameters.AddWithValue("@QuantityOnHand", (int)numQuantity.Value);
                        cmdInsert.Parameters.AddWithValue("@LastUpdated", date.Value);

                        // 🔍 修正 2：成功將剛剛查到的 ReorderLevel 綁定給參數
                        cmdInsert.Parameters.AddWithValue("@ReorderLevel", reorderLevel);

                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("庫存資料新增成功！");

                        // 可在此處呼叫清空畫面或關閉視窗的方法
                    }
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
        private void GenerateInventoryID()
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
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
            string constring = "server=localhost;user id=root;password=;database=4915";

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
                string constring = "server=localhost;user id=root;password=;database=4915";

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

            this.Close();
        }

        private void Logistics_Click(object sender, EventArgs e)
        {
            FormLogistics log = new FormLogistics();
            log.Show();
            this.Close();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            FormSetting setting = new FormSetting();
            setting.Show();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4915project
{
    public partial class EditRawMaterial : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        public EditRawMaterial()
        {
            InitializeComponent();
        }

        private void EditRawMaterial_Load(object sender, EventArgs e)
        {
            getdata();
        }
        private void getdata()
        {
            string query = @"SELECT MaterialID, Type, Unit, PreferredSupplier FROM rawmaterial";

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // 1. 宣告並建立 DataTable
                    DataTable dt = new DataTable();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        // Fill 會自動開啟與關閉連線，不需要手動 conn.Open()
                        da.Fill(dt);
                    }

                    // 2. 清空舊的下拉選單項目
                    cmbMterialID.Items.Clear();
                    cmbType.Items.Clear();
                    cmbUnit.Items.Clear();
                    cmbSupplier.Items.Clear();

                    // 3. 處理 Type (去重複與排序)
                    DataView viewType = new DataView(dt);
                    DataTable dtDistinctType = viewType.ToTable(true, "Type");
                    dtDistinctType.DefaultView.Sort = "Type ASC"; // 排序讓選單更好找
                    foreach (DataRow row in dtDistinctType.DefaultView.ToTable().Rows)
                    {
                        if (row["Type"] != DBNull.Value && !string.IsNullOrWhiteSpace(row["Type"].ToString()))
                        {
                            cmbType.Items.Add(row["Type"].ToString());
                        }
                    }

                    // 4. 處理 Unit (去重複與排序)
                    DataView viewUnit = new DataView(dt);
                    DataTable dtDistinctUnit = viewUnit.ToTable(true, "Unit");
                    dtDistinctUnit.DefaultView.Sort = "Unit ASC"; // 補上排序
                    foreach (DataRow row in dtDistinctUnit.DefaultView.ToTable().Rows)
                    {
                        if (row["Unit"] != DBNull.Value && !string.IsNullOrWhiteSpace(row["Unit"].ToString()))
                        {
                            cmbUnit.Items.Add(row["Unit"].ToString());
                        }
                    }

                    // 5. 處理 PreferredSupplier (去重複與排序)
                    DataView viewSupplier = new DataView(dt);
                    DataTable dtDistinctSupplier = viewSupplier.ToTable(true, "PreferredSupplier");
                    dtDistinctSupplier.DefaultView.Sort = "PreferredSupplier ASC"; // 補上排序
                    foreach (DataRow row in dtDistinctSupplier.DefaultView.ToTable().Rows)
                    {
                        if (row["PreferredSupplier"] != DBNull.Value && !string.IsNullOrWhiteSpace(row["PreferredSupplier"].ToString()))
                        {
                            cmbSupplier.Items.Add(row["PreferredSupplier"].ToString());
                        }
                    }

                    // 6. 處理 MaterialID (去重複與排序)
                    DataView viewID = new DataView(dt);
                    DataTable dtDistinctID = viewID.ToTable(true, "MaterialID");
                    dtDistinctID.DefaultView.Sort = "MaterialID ASC"; // 補上排序
                    foreach (DataRow row in dtDistinctID.DefaultView.ToTable().Rows)
                    {
                        if (row["MaterialID"] != DBNull.Value && !string.IsNullOrWhiteSpace(row["MaterialID"].ToString()))
                        {
                            cmbMterialID.Items.Add(row["MaterialID"].ToString());
                        }
                    }

                    // 7. 選擇性設定預設選取第一項 (避免留白)
                    if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
                    if (cmbUnit.Items.Count > 0) cmbUnit.SelectedIndex = 0;
                    if (cmbSupplier.Items.Count > 0) cmbSupplier.SelectedIndex = 0;
                    if (cmbMterialID.Items.Count > 0) cmbMterialID.SelectedIndex = 0;
                }
            }
        }
        private void getRowData()
        {
            // 防呆：如果下拉選單沒有選取任何單號，直接退出，避免後續報錯
            if (cmbMterialID.SelectedItem == null) return;

            string query = @"SELECT * FROM rawmaterial WHERE MaterialID = @ID";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", cmbMterialID.SelectedItem.ToString());

                    try
                    {
                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 1. 處理基本字串欄位（加上安全處理，防止資料庫為 NULL 時崩潰）
                                tbName.Text = reader["Name"]?.ToString() ?? "";
                                cmbType.Text = reader["Type"]?.ToString() ?? "";
                                cmbSupplier.Text = reader["PreferredSupplier"]?.ToString() ?? "";
                                cmbUnit.Text = reader["Unit"]?.ToString() ?? "";

                                // 2. 【關鍵修正】單價欄位轉為 Decimal
                                if (reader["UnitCost"] != DBNull.Value)
                                {
                                    decimal costVal = Convert.ToDecimal(reader["UnitCost"]);
                                    // 確保控制項的最大值大於等於要輸入的值，防止破表
                                    if (costVal > cost.Maximum) cost.Maximum = costVal * 2;
                                    cost.Value = costVal;
                                }

                                // 3. 【關鍵修正】安全庫存量欄位
                                if (reader["ReorderLevel"] != DBNull.Value)
                                {
                                    decimal levelVal = Convert.ToDecimal(reader["ReorderLevel"]);
                                    // 同理，若資料庫的庫存量大於目前控制項最大值，動態拉大最大值
                                    if (levelVal > level.Maximum) level.Maximum = levelVal * 2;
                                    level.Value = levelVal;
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Failed to retrieve row data: " + ex.Message);
                    }
                }
            }
        }

        private void cmbMterialID_SelectedIndexChanged(object sender, EventArgs e)
        {
            getRowData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. 基本前端防呆驗證：必須先選取要修改的 Material ID
            if (cmbMterialID.SelectedItem == null || string.IsNullOrWhiteSpace(cmbMterialID.Text))
            {
                MessageBox.Show("Please select a Material ID to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Material Name cannot be empty.");
                return;
            }

            // 2. 標準 SQL 修改語句
            string query = @"UPDATE rawmaterial SET 
         Name = @name, 
         Type = @type, 
         Unit = @unit, 
         UnitCost = @cost, 
         ReorderLevel = @level, 
         PreferredSupplier = @supplier 
         WHERE MaterialID = @ID;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // 3. 【關鍵修正】安全繫結所有參數，移除空格並補上 @
                    cmd.Parameters.AddWithValue("@name", tbName.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", cmbType.Text.Trim());
                    cmd.Parameters.AddWithValue("@unit", cmbUnit.Text.Trim()); // 補上了 @
                    cmd.Parameters.AddWithValue("@cost", cost.Value);
                    cmd.Parameters.AddWithValue("@level", (int)level.Value); // 強制轉整數符合資料庫型態
                    cmd.Parameters.AddWithValue("@supplier", cmbSupplier.Text.Trim()); // 移除了多餘的空格
                    cmd.Parameters.AddWithValue("@ID", cmbMterialID.SelectedItem.ToString()); // 修正為 @ID 

                    try
                    {
                        con.Open();

                        // 4. 【核心修正】真正執行修改指令
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Material updated successfully!");

                            // 修改成功後，通常需要重新整理介面資料
                            // 如果你有載入 DataGridView 的 method，可以在這邊呼叫
                        }
                        else
                        {
                            MessageBox.Show("No changes were made or Material ID not found.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}

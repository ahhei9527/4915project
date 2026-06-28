using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace _4915project
{
    public partial class CreateRawMaterial : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        public CreateRawMaterial()
        {
            InitializeComponent();
        }

        private void CreateRawMaterial_Load(object sender, EventArgs e)
        {
            getdata();
            GenID();
        }

        private void getdata()
        {
            string query = @"SELECT Type, Unit, PreferredSupplier FROM rawmaterial";

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

                    // 6. 選擇性設定預設選取第一項 (避免留白)
                    if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
                    if (cmbUnit.Items.Count > 0) cmbUnit.SelectedIndex = 0;
                    if (cmbSupplier.Items.Count > 0) cmbSupplier.SelectedIndex = 0;
                }
            }
        }

        private void GenID()
        {
            string prefix = "MAT"; // 生成格式：MAT001

            // 1. 取得最新（最大）的一筆單號
            string query = "SELECT MaterialID FROM rawmaterial WHERE MaterialID LIKE @Prefix ORDER BY MaterialID DESC LIMIT 1";

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
                            string lastMaterialID = result.ToString().Trim();

                            // 【修正防呆】MAT (3碼) + 數字 (3碼) = 6碼。確保長度足夠才進行處理
                            if (lastMaterialID.Length >= 6)
                            {
                                // 【關鍵修正】改為 Length - 3，精確擷取最後 3 碼純數字部分 (例如 "001")
                                string lastNumberStr = lastMaterialID.Substring(lastMaterialID.Length - 3);

                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1;
                                }
                            }
                        }

                        // 2. 產生新單號 (D3 代表不足 3 碼補零，例如：MAT001)
                        tbMterialID.Text = prefix + nextNumber.ToString("D3");
                        tbMterialID.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Unable to retrieve database serial number: " + ex.Message);
                        MessageBox.Show("Material number cannot be generated automatically. Please enter it manually or try again later.");
                        tbMterialID.ReadOnly = false;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. 基本前端防呆驗證（ID 和名稱為必填）
            if (string.IsNullOrWhiteSpace(tbMterialID.Text) || string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Material ID and Name cannot be empty.");
                return;
            }

            // 2. 標準 SQL 新增語句
            string query = @"INSERT INTO rawmaterial 
         (MaterialID, Name, Type, Unit, UnitCost, ReorderLevel, PreferredSupplier) 
         VALUES 
         (@ID, @name, @type, @unit, @cost, @level, @supplier);";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // 3. 安全繫結參數 (NumericUpDown.Value 直接可以拿來用)
                    cmd.Parameters.AddWithValue("@ID", tbMterialID.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", tbName.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem?.ToString() ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@unit", cmbUnit.SelectedItem?.ToString() ?? (object)DBNull.Value);

                    // 單價：直接傳入 Value (decimal 型態)
                    cmd.Parameters.AddWithValue("@cost", cost.Value);

                    // 安全庫存：將 decimal 強制轉換為 int 符合資料庫欄位型態
                    cmd.Parameters.AddWithValue("@level", (int)level.Value);

                    cmd.Parameters.AddWithValue("@supplier", cmbSupplier.SelectedItem?.ToString() ?? (object)DBNull.Value);

                    try
                    {
                        con.Open();

                        // 4. 真正執行 SQL 指令
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Material added successfully!");
                            ClearFields(); // 成功後重置介面
                        }
                        else
                        {
                            MessageBox.Show("No data was inserted.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // 攔截 MySQL 主鍵重複錯誤 (MaterialID 重複)
                        if (ex.Number == 1062)
                        {
                            MessageBox.Show("Error: This Material ID already exists!");
                        }
                        else
                        {
                            MessageBox.Show("Database error: " + ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void ClearFields()
        {
            tbName.Clear();

            // 將 NumericUpDown 重置回你設定的最小值 (通常是 0)
            cost.Value = cost.Minimum;
            level.Value = level.Minimum;

            cmbType.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;

            // 重新生成下一組新序號 (呼叫你之前寫好的 GenID 函式)
            GenID();
        }
    }
}

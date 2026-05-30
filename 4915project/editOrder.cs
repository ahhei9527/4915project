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
    public partial class editOrder : Form
    {
        public editOrder()
        {
            InitializeComponent();
        }

        private void editOrder_Load(object sender, EventArgs e)
        {
            cmbCustName.Enabled = false;
            tbAddress.Enabled = false;
            OrderDate.Enabled = false;
            tbTotal.Enabled = false;
            string constring = "server=localhost;user id=root;password=;database=4915";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string Query = "SELECT OrderID FROM salesorder";
                using (MySqlCommand cmd = new MySqlCommand(Query, con))
                {
                    cmOrderID.Items.Clear();
                    cmOrderID.Items.Add("Select OrderID");
                    cmOrderID.SelectedIndex = 0; // Automatically selects the default text

                    // Execute the reader to fetch data from MySQL
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Add each OrderID from the database to the ComboBox
                            cmOrderID.Items.Add(reader["OrderID"].ToString());
                        }
                    }
                }
            }
        }
        public void cmOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 防呆檢查：如果使用者選到預設的提示字（例如 "Select OrderID"）或沒選，直接返回不執行
            if (cmOrderID.SelectedIndex <= 0 || cmOrderID.SelectedItem == null)
            {
                dgvOrderItems.DataSource = null; // 清空舊的 DataGridView 資料
                return;
            }

            string constring = "server=localhost;user id=root;password=;database=4915";

            // 使用參數化查詢（@OrderID），避免字串拼接產生的語法錯誤與資安風險
            string Query = "SELECT * FROM orderitem WHERE OrderID = @OrderID";
            string Query2 = "SELECT c.Name " +
                "FROM salesorder s " +
                "INNER JOIN customer c ON s.CustomerID = c.CustomerID " +
                "WHERE s.OrderID = @OrderID";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(Query, con))
                    {
                        // 帶入安全的參數值
                        cmd.Parameters.AddWithValue("@OrderID", cmOrderID.SelectedItem.ToString());

                        // 直接使用 DataAdapter 填充 DataTable，完全不需要手動寫 reader 迴圈！
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // 將讀取到的商品明細綁定到畫面的 DataGridView
                            dgvOrderItems.DataSource = dt;
                        }
                    }
                    using (MySqlCommand cmd2 = new MySqlCommand(Query2, con))
                    {
                        cmd2.Parameters.AddWithValue("@OrderID", cmOrderID.SelectedItem.ToString());
                        object result = cmd2.ExecuteScalar();
                        if (result != null)
                        {
                            tbCustName.Text = result.ToString();
                        }
                        else
                        {
                            tbCustName.Text = "Unknown Customer";
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("查詢訂單明細時發生資料庫錯誤: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("發生未預期的錯誤: " + ex.Message);
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

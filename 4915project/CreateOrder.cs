using _4915project;
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

namespace ITP4915M
{
    public partial class FormOrdelDetail : Form
    {
        public FormOrdelDetail()
        {
            InitializeComponent();
        }

        private void labelOrderDetail_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";

            string queryGetCustomerID = "SELECT CustomerID FROM customer WHERE Name = @CustomerName LIMIT 1";
            string queryInsertOrder = @"
        INSERT INTO salesorder (OrderID, CustomerID, OrderDate, TotalAmount, 
                                RequestDeliveryDate, Status, EstimatedDeliveryDate) 
        VALUES (@OrderID, @CustomerID, @OrderDate, @TotalAmount, 
                @RequestDeliveryDate, @Status, @EstimatedDeliveryDate)";

            // 預設防呆變數
            string customerID = null;

            // 使用單一連線處理所有步驟
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    using (MySqlCommand cmd2 = new MySqlCommand(queryGetCustomerID, con))
                    {
                        cmd2.Parameters.AddWithValue("@CustomerName", cmbCustName.SelectedItem?.ToString() ?? "");

                        using (MySqlDataReader reader = cmd2.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 🔍 修正：用標準欄位索引或名稱取得真正的 ID
                                customerID = reader["CustomerID"].ToString();
                            }
                        }
                    }

                    // 防呆檢查：如果根本找不到這個客戶，就攔截並不往下執行
                    if (string.IsNullOrEmpty(customerID))
                    {
                        MessageBox.Show("Cannot find the selected customer. Please check the name.");
                        return;
                    }

                    // 防呆檢查：確保狀態下拉選單有選值
                    if (cbStatus.SelectedItem == null)
                    {
                        MessageBox.Show("Please select an order status.");
                        return;
                    }

                    // 步驟 2：將資料寫入 salesorder 表
                    using (MySqlCommand cmd = new MySqlCommand(queryInsertOrder, con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", tbOrderID.Text);
                        cmd.Parameters.AddWithValue("@CustomerID", customerID); // 傳入正確的 ID
                        cmd.Parameters.AddWithValue("@OrderDate", OrderDate.Value);
                        cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(tbTotal.Text));
                        cmd.Parameters.AddWithValue("@RequestDeliveryDate", deliveryDate.Value);
                        cmd.Parameters.AddWithValue("@Status", cbStatus.SelectedItem.ToString());

                        // 自動計算預計交期（完美保留你原本的邏輯）
                        cmd.Parameters.AddWithValue("@EstimatedDeliveryDate", deliveryDate.Value.AddDays(7));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order saved successfully!");

                        // 成功後才跳轉畫面
                        ReturnToFormOrder();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error occurred: " + ex.Message);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please ensure Total Amount is a valid number.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        private void ReturnToFormOrder()
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ReturnToFormOrder();
        }
        private DataTable orderItemsTable;
        private void FormOrdelDetail_Load(object sender, EventArgs e)
        {
            orderItemsTable = new DataTable();
            orderItemsTable.Columns.Add("Product ID/Name", typeof(string));
            orderItemsTable.Columns.Add("Unit Price", typeof(decimal));
            orderItemsTable.Columns.Add("Quantity", typeof(int));
            orderItemsTable.Columns.Add("Subtotal", typeof(decimal));
            dgvOrderItems.DataSource = orderItemsTable;
            tbAddress.Enabled = false;
            GenerateSequenceOrderID();
            string constring = "server=localhost;user id=root;password=;database=4915";

            string query = "SELECT Name FROM product";
            string query2 = "SELECT Name FROM customer";

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
                                if (reader["Name"] != DBNull.Value)
                                {
                                    comboBoxProductIDName.Items.Add(reader["Name"]);
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("SQL acess failed: " + ex.Message);
                    }
                }
                using (MySqlCommand cmd2 = new MySqlCommand(query2, con))
                {
                    try
                    {
                        using (MySqlDataReader reader = cmd2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["Name"] != DBNull.Value)
                                {
                                    cmbCustName.Items.Add(reader["Name"]); ;
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("SQL acess failed: " + ex.Message);
                    }
                }
            }
        }

        private void comboBoxProductIDName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";

            string query = "SELECT Name FROM product";

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
                                getPrice(comboBoxProductIDName.Text);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("SQL acess failed: " + ex.Message);
                    }
                }
            }
        }
        private void getPrice(string name)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";

            // 1. 使用 @ProductName 作為參數佔位符
            string query = "SELECT UnitPrice FROM product WHERE Name = @ProductName";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // 2. 安全地綁定參數值
                    cmd.Parameters.AddWithValue("@ProductName", name);

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            textBoxUnitPrice.Text = result.ToString();
                        }
                        else
                        {
                            textBoxUnitPrice.Text = "0"; // 或者清空：""
                            MessageBox.Show("找不到該產品的價格。");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("資料庫存取失敗: " + ex.Message);
                    }
                }
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            // 1. 驗證使用者輸入
            if (comboBoxProductIDName.SelectedItem == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }
            if (numericUpDownQuantity.Value <= 0) // 假設數量控制項是 NumericUpDown
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            // 2. 取得輸入值並計算小計
            string productName = comboBoxProductIDName.SelectedItem.ToString();
            decimal unitPrice = decimal.Parse(textBoxUnitPrice.Text);
            int quantity = (int)numericUpDownQuantity.Value;
            decimal subtotal = unitPrice * quantity;

            // 3. 將資料列新增至 DataTable（畫面的 DataGridView 會自動同步更新）
            orderItemsTable.Rows.Add(productName, unitPrice, quantity, subtotal);

            // 4. 更新下方的 Total Amount
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataRow row in orderItemsTable.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }
            tbTotal.Text = total.ToString(); // 假設總金額 TextBox 叫 textBoxTotalAmount
        }

        private void GenerateSequenceOrderID()
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
            string prefix = "ORD"; // ORD

            // 查詢今天最大的流水號
            string query = "SELECT OrderID FROM salesorder WHERE OrderID LIKE @Prefix ORDER BY OrderID DESC LIMIT 1";

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
                            // 擷取最後 4 碼數字 (例如從 "ORD-20260529-0005" 切出 "0005")
                            string lastNumberStr = lastOrderID.Substring(lastOrderID.Length - 6);

                            if (int.TryParse(lastNumberStr, out int lastNumber))
                            {
                                nextNumber = lastNumber + 1; // 序號加 1
                            }
                        }

                        // 將序號格式化為 4 位數，例如 1 變成 0001，12 變成 0012
                        tbOrderID.Text = prefix + nextNumber.ToString("D6");
                        tbOrderID.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("無法取得資料庫流水號: " + ex.Message);
                        tbOrderID.ReadOnly = false;
                    }
                }
            }
        }

        private void cmbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";

            string query = "SELECT Name FROM customer";

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
                                getAddress(cmbCustName.Text);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("SQL acess failed: " + ex.Message);
                    }
                }
            }
        }
        private void getAddress(string name)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";

            // 1. 使用 @ProductName 作為參數佔位符
            string query = "SELECT Address FROM customer WHERE Name = @Name";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // 2. 安全地綁定參數值
                    cmd.Parameters.AddWithValue("@Name", name);

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            tbAddress.Text = result.ToString();
                        }
                        else
                        {
                            textBoxUnitPrice.Text = "0"; // 或者清空：""
                            MessageBox.Show("找不到該產品的價格。");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("資料庫存取失敗: " + ex.Message);
                    }
                }
            }
        }
    }
}

using _4915project;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ITP4915M
{
    public partial class FormOrdelDetail : Form
    {
        string OrderItemID;
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
            string orderIDs = tbOrderID.Text; // 取得目前的訂單編號
            string constring = "server=localhost;user id=root;password=;database=4915";

            string queryGetCustomerID = "SELECT CustomerID FROM customer WHERE Name = @CustomerName LIMIT 1";

            string queryInsertOrder = @"
                INSERT INTO salesorder (OrderID, CustomerID, OrderDate, TotalAmount, 
                                        RequestDeliveryDate, Status, EstimatedDeliveryDate) 
                VALUES (@OrderID, @CustomerID, @OrderDate, @TotalAmount, 
                        @RequestDeliveryDate, @Status, @EstimatedDeliveryDate)";

            string queryInsertItem = @"
                INSERT INTO orderitem (OrderItemID, OrderID, quantity, UnitPrice, Subtotal) 
                VALUES (@OrderItemID, @OrderID, @Quantity, @UnitPrice, @Subtotal)";

            string customerID = null;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // 1. 取得客戶 ID
                    using (MySqlCommand cmdGetCust = new MySqlCommand(queryGetCustomerID, con))
                    {
                        cmdGetCust.Parameters.AddWithValue("@CustomerName", cmbCustName.SelectedItem?.ToString() ?? "");
                        using (MySqlDataReader reader = cmdGetCust.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                customerID = reader["CustomerID"].ToString();
                            }
                        } // 這裡 reader 會自動關閉，釋放連線
                    }

                    // 防呆檢查
                    if (string.IsNullOrEmpty(customerID))
                    {
                        MessageBox.Show("Cannot find the selected customer. Please check the name.");
                        return;
                    }

                    if (cbStatus.SelectedItem == null)
                    {
                        MessageBox.Show("Please select an order status.");
                        return;
                    }

                    // 使用 Transaction 確保主檔與明細同時成功或同時失敗
                    using (MySqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // 2. 寫入主檔 salesorder
                            using (MySqlCommand cmdOrder = new MySqlCommand(queryInsertOrder, con, transaction))
                            {
                                cmdOrder.Parameters.AddWithValue("@OrderID", orderIDs);
                                cmdOrder.Parameters.AddWithValue("@CustomerID", customerID);
                                cmdOrder.Parameters.AddWithValue("@OrderDate", OrderDate.Value);
                                cmdOrder.Parameters.AddWithValue("@TotalAmount", decimal.Parse(tbTotal.Text));
                                cmdOrder.Parameters.AddWithValue("@RequestDeliveryDate", deliveryDate.Value);
                                cmdOrder.Parameters.AddWithValue("@Status", cbStatus.SelectedItem.ToString());
                                cmdOrder.Parameters.AddWithValue("@EstimatedDeliveryDate", deliveryDate.Value.AddDays(7));

                                cmdOrder.ExecuteNonQuery();
                            }

                            // 3. 寫入明細檔 orderitem (跑畫面的 DataTable 迴圈)
                            using (MySqlCommand cmdItem = new MySqlCommand(queryInsertItem, con, transaction))
                            {
                                // 預先建立參數（優化效能，避免在迴圈內重複 Add）
                                cmdItem.Parameters.Add("@OrderItemID", MySqlDbType.VarChar);
                                cmdItem.Parameters.Add("@OrderID", MySqlDbType.VarChar);
                                cmdItem.Parameters.Add("@Quantity", MySqlDbType.Int32);
                                cmdItem.Parameters.Add("@UnitPrice", MySqlDbType.Decimal);
                                cmdItem.Parameters.Add("@Subtotal", MySqlDbType.Decimal);

                                // 假設你的 orderItemsTable 是儲存畫面上多筆商品的 DataTable
                                foreach (DataRow row in orderItemsTable.Rows)
                                {
                                    // 自動生成每筆明細的唯一 OrderItemID (例如: 訂單號 + 隨機/流水號)
                                    string itemID = GenerateOrderItemID();

                                    // 將資料表(DataTable)中的值賦予給 SQL 參數
                                    cmdItem.Parameters["@OrderItemID"].Value = itemID;
                                    cmdItem.Parameters["@OrderID"].Value = orderIDs;
                                    cmdItem.Parameters["@Quantity"].Value = Convert.ToInt32(row["Quantity"]);
                                    cmdItem.Parameters["@UnitPrice"].Value = Convert.ToDecimal(row["Unit Price"]);
                                    cmdItem.Parameters["@Subtotal"].Value = Convert.ToDecimal(row["Subtotal"]);

                                    cmdItem.ExecuteNonQuery();
                                }
                            }

                            // 提交交易（確定寫入資料庫）
                            transaction.Commit();

                            MessageBox.Show("Order saved successfully!");

                            // 紀錄日誌與跳轉
                            CreateOrderAudit(orderIDs);
                            ReturnToFormOrder();
                        }
                        catch (Exception ex)
                        {
                            // 發生任何錯誤，全部還原（Rollback）
                            transaction.Rollback();
                            MessageBox.Show("Failed to save order details. Error: " + ex.Message);
                        }
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

        private void CreateOrderAudit(string orderID)
        {
            try
            {
                CurrentUser.CreateOrder(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email);

                AuditHelper.Log(
                    tableName: "salesorder",
                    recordId: orderID,
                    action: "Create Order",
                    userId: CurrentUser.UserID
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
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
            tbTotal.Enabled = false;
            textBoxUnitPrice.Enabled = false;
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
            string query = "SELECT OrderID FROM salesorder";

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

        private string GenerateOrderItemID()
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
            string prefix = "OI"; 

            // 查詢今天最大的流水號
            string query = "SELECT OrderItemID FROM orderitem WHERE OrderItemID LIKE @Prefix ORDER BY OrderItemID DESC LIMIT 1";

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
                            string lastOrderItemID = result.ToString();
                            // 擷取最後 4 碼數字 (例如從 "ORD-20260529-0005" 切出 "0005")
                            string lastNumberStr = lastOrderItemID.Substring(lastOrderItemID.Length - 6);

                            if (int.TryParse(lastNumberStr, out int lastNumber))
                            {
                                nextNumber = lastNumber + 1; // 序號加 1
                            }
                        }

                        // 將序號格式化為 4 位數，例如 1 變成 0001，12 變成 0012
                        OrderItemID = prefix + nextNumber.ToString("D6");
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("無法取得資料庫流水號: " + ex.Message);
                        tbOrderID.ReadOnly = false;
                    }
                }
            }
            return OrderItemID;
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

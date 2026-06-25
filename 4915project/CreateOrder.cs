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

namespace _4915project
{
    public partial class FormOrderDetail : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        private DataTable orderItemsTable;

        public FormOrderDetail()
        {
            InitializeComponent();
        }

        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            orderItemsTable = new DataTable();
            orderItemsTable.Columns.Add("ProductID", typeof(string));
            orderItemsTable.Columns.Add("Product ID/Name", typeof(string));
            orderItemsTable.Columns.Add("Unit Price", typeof(decimal));
            orderItemsTable.Columns.Add("Quantity", typeof(int));
            orderItemsTable.Columns.Add("Subtotal", typeof(decimal));

            dgvOrderItems.DataSource = orderItemsTable;

            if (dgvOrderItems.Columns["ProductID"] != null)
                dgvOrderItems.Columns["ProductID"].Visible = false;

            tbAddress.Enabled = false;
            tbTotal.Enabled = false;
            textBoxUnitPrice.Enabled = false;

            LoadProducts();
            LoadCustomers();
            GenerateSequenceOrderID();
        }

        private void LoadProducts()
        {
            
            string query = "SELECT ProductID, Name FROM product";

            using (MySqlConnection con = new MySqlConnection(constring))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productID = reader["ProductID"].ToString();
                            string name = reader["Name"].ToString();
                            comboBoxProductIDName.Items.Add(name);  // 顯示 Name
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load products: " + ex.Message);
                }
            }
        }

        private void LoadCustomers()
        {
            
            string query = "SELECT Name FROM customer";

            using (MySqlConnection con = new MySqlConnection(constring))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbCustName.Items.Add(reader["Name"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load customers: " + ex.Message);
                }
            }
        }

        private void comboBoxProductIDName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductIDName.SelectedItem == null) return;
            getPrice(comboBoxProductIDName.SelectedItem.ToString());
        }

        private void cmbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustName.SelectedItem == null) return;
            getAddress(cmbCustName.SelectedItem.ToString());
        }

        private void getPrice(string name)
        {
            
            string query = "SELECT UnitPrice FROM product WHERE Name = @ProductName";

            using (MySqlConnection con = new MySqlConnection(constring))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ProductName", name);
                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    textBoxUnitPrice.Text = result?.ToString() ?? "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database retrieval failed: " + ex.Message);
                    textBoxUnitPrice.Text = "0";
                }
            }
        }

        private void getAddress(string name)
        {
            
            string query = "SELECT Address FROM customer WHERE Name = @Name";

            using (MySqlConnection con = new MySqlConnection(constring))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    tbAddress.Text = result?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database retrieval failed: " + ex.Message);
                    tbAddress.Text = "";
                }
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (comboBoxProductIDName.SelectedItem == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }
            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            string productName = comboBoxProductIDName.SelectedItem.ToString();
            decimal unitPrice = decimal.Parse(textBoxUnitPrice.Text);
            int quantity = (int)numericUpDownQuantity.Value;
            decimal subtotal = unitPrice * quantity;

            // 取得 ProductID（建議改用 Dictionary 快取更佳）
            string productID = GetProductIDByName(productName);

            orderItemsTable.Rows.Add(productID, productName, unitPrice, quantity, subtotal);
            UpdateTotalAmount();
        }

        private string GetProductIDByName(string productName)
        {
            
            string query = "SELECT ProductID FROM product WHERE Name = @Name";

            using (MySqlConnection con = new MySqlConnection(constring))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Name", productName);
                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "";
                }
                catch
                {
                    return "";
                }
            }
        }

        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataRow row in orderItemsTable.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }
            tbTotal.Text = total.ToString("F2"); // 格式化顯示
        }

        // ====================== buttonSaveOrder_Click 等其他方法 ======================
        // （以下保留你原本的邏輯，只做小修正）

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            string orderIDs = tbOrderID.Text.Trim();
            if (string.IsNullOrEmpty(orderIDs))
            {
                MessageBox.Show("Order ID is required.");
                return;
            }

            

            string queryGetCustomerID = "SELECT CustomerID FROM customer WHERE Name = @CustomerName LIMIT 1";
            string queryInsertOrder = @"
        INSERT INTO salesorder (OrderID, CustomerID, OrderDate, TotalAmount, 
                                RequestDeliveryDate, Status, EstimatedDeliveryDate) 
        VALUES (@OrderID, @CustomerID, @OrderDate, @TotalAmount, 
                @RequestDeliveryDate, @Status, @EstimatedDeliveryDate)";

            string queryInsertItem = @"
        INSERT INTO orderitem (OrderItemID, OrderID, quantity, UnitPrice, Subtotal) 
        VALUES (@OrderItemID, @OrderID, @Quantity, @UnitPrice, @Subtotal)";

            string queryInsertItemProduct = @"
        INSERT INTO orderitem_product (OrderItemID, ProductID) 
        VALUES (@OrderItemID, @ProductID)";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // 取得 CustomerID
                    string customerID = null;
                    using (MySqlCommand cmdGetCust = new MySqlCommand(queryGetCustomerID, con))
                    {
                        cmdGetCust.Parameters.AddWithValue("@CustomerName", cmbCustName.SelectedItem?.ToString() ?? "");
                        using (MySqlDataReader reader = cmdGetCust.ExecuteReader())
                        {
                            if (reader.Read())
                                customerID = reader["CustomerID"].ToString();
                        }
                    }

                    if (string.IsNullOrEmpty(customerID))
                    {
                        MessageBox.Show("Cannot find the selected customer.");
                        return;
                    }

                    if (cbStatus.SelectedItem == null)
                    {
                        MessageBox.Show("Please select an order status.");
                        return;
                    }

                    if (dgvOrderItems.Rows.Count <= 1) // 只剩新行
                    {
                        MessageBox.Show("Please add at least one item.");
                        return;
                    }

                    using (MySqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // 1. 插入 salesorder
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

                            // 2. 插入 orderitem + orderitem_product
                            int baseItemNumber = GetCurrentMaxOrderItemNumber(con, transaction);
                            int offset = 0;

                            using (MySqlCommand cmdItem = new MySqlCommand(queryInsertItem, con, transaction))
                            using (MySqlCommand cmdItemProduct = new MySqlCommand(queryInsertItemProduct, con, transaction))
                            {
                                // 準備 orderitem 參數
                                cmdItem.Parameters.Add("@OrderItemID", MySqlDbType.VarChar);
                                cmdItem.Parameters.Add("@OrderID", MySqlDbType.VarChar);
                                cmdItem.Parameters.Add("@Quantity", MySqlDbType.Int32);
                                cmdItem.Parameters.Add("@UnitPrice", MySqlDbType.Decimal);
                                cmdItem.Parameters.Add("@Subtotal", MySqlDbType.Decimal);

                                // 準備 orderitem_product 參數
                                cmdItemProduct.Parameters.Add("@OrderItemID", MySqlDbType.VarChar);
                                cmdItemProduct.Parameters.Add("@ProductID", MySqlDbType.VarChar);

                                foreach (DataGridViewRow row in dgvOrderItems.Rows)
                                {
                                    if (row.IsNewRow) continue;

                                    // 產生 OrderItemID
                                    int nextNumber = baseItemNumber + offset++;
                                    string uniqueItemID = "OI" + nextNumber.ToString("D6");

                                    string productID = row.Cells["ProductID"]?.Value?.ToString();

                                    if (string.IsNullOrEmpty(productID))
                                    {
                                        throw new Exception("ProductID is missing for one of the items.");
                                    }

                                    // 插入 orderitem
                                    cmdItem.Parameters["@OrderItemID"].Value = uniqueItemID;
                                    cmdItem.Parameters["@OrderID"].Value = orderIDs;
                                    cmdItem.Parameters["@Quantity"].Value = Convert.ToInt32(row.Cells["Quantity"].Value);
                                    cmdItem.Parameters["@UnitPrice"].Value = Convert.ToDecimal(row.Cells["Unit Price"].Value);
                                    cmdItem.Parameters["@Subtotal"].Value = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                                    cmdItem.ExecuteNonQuery();

                                    // 插入 orderitem_product（確保 OrderItemID 一致）
                                    cmdItemProduct.Parameters["@OrderItemID"].Value = uniqueItemID;
                                    cmdItemProduct.Parameters["@ProductID"].Value = productID;
                                    cmdItemProduct.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Order saved successfully!");
                            CreateOrderAudit(orderIDs);
                            ReturnToFormOrder();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Failed to save order: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private int GetCurrentMaxOrderItemNumber(MySqlConnection con, MySqlTransaction transaction)
        {
            string query = @"
                SELECT COALESCE(MAX(CAST(SUBSTRING(OrderItemID, 3) AS UNSIGNED)), 0) 
                FROM orderitem WHERE OrderItemID LIKE 'OI%'";

            using (MySqlCommand cmd = new MySqlCommand(query, con, transaction))
            {
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result) + 1;
            }
        }

        private void CreateOrderAudit(string orderID)
        {
            try
            {
                CurrentUser.CreateOrder(CurrentUser.UserID, CurrentUser.Username,
                                      CurrentUser.Role, CurrentUser.Email);

                AuditHelper.Log("salesorder", orderID, "Create Order", CurrentUser.UserID);
            }
            catch (Exception ex)
            {
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

        private void GenerateSequenceOrderID()
        {
            
            string prefix = "ORD";

            // 修正：加上 WHERE 篩選前綴，並用 ORDER BY 排序加 LIMIT 1 取得最新（最大）的一筆
            string query = "SELECT OrderID FROM salesorder WHERE OrderID LIKE @Prefix ORDER BY OrderID DESC LIMIT 1";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // 修正：必須在 SQL 語法中有 @Prefix，此處綁定才有效
                    cmd.Parameters.AddWithValue("@Prefix", prefix + "%");

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        int nextNumber = 1;

                        if (result != null && result != DBNull.Value)
                        {
                            string lastOrderID = result.ToString();

                            // 防呆：確保字串長度足夠切取後 6 碼
                            if (lastOrderID.Length >= 6)
                            {
                                string lastNumberStr = lastOrderID.Substring(lastOrderID.Length - 6);

                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1;
                                }
                            }
                        }

                        // 產生新單號 (例如：ORD000001)
                        tbOrderID.Text = prefix + nextNumber.ToString("D6");
                        tbOrderID.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Unable to retrieve database serial number: " + ex.Message);
                        MessageBox.Show("Order number cannot be generated automatically. Please enter it manually or try again later.");
                        tbOrderID.ReadOnly = false;
                    }
                }
            }
        }
    }
}

using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4915project
{
    public partial class EditOrder : Form
    {
        public EditOrder()
        {
            InitializeComponent();
        }
        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
            string oldDate = null;
            string oldStatus = null;
            string newDate = deliveryDate.Value.ToString();
            string newStatus = cbStatus.SelectedItem?.ToString();
            string orderID = cmOrderID.SelectedItem?.ToString();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string QueryOldDate = "SELECT RequestDeliveryDate, Status FROM salesorder WHERE OrderID = @OrderID";
                using (MySqlCommand cmdOld = new MySqlCommand(QueryOldDate, con))
                {
                    cmdOld.Parameters.AddWithValue("@OrderID", cmOrderID.SelectedItem?.ToString());
                    using (MySqlDataReader reader = cmdOld.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oldDate = reader["RequestDeliveryDate"].ToString();
                            oldStatus = reader["Status"].ToString();
                        }
                    }
                    string queryUpdateOrder = @"
                UPDATE salesorder
                SET RequestDeliveryDate = @RequestDeliveryDate, 
                Status = @Status
                WHERE OrderID = @OrderID;";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdateOrder, con))
                    {
                        cmdUpdate.Parameters.AddWithValue("@RequestDeliveryDate", newDate);
                        cmdUpdate.Parameters.AddWithValue("@Status", newStatus);
                        cmdUpdate.Parameters.AddWithValue("@OrderID", orderID);
                        int rowsAffected = cmdUpdate.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            UpdateOrderAudit(newDate, newStatus, orderID, oldDate, oldStatus);
                            MessageBox.Show("Order updated successfully!");
                        }
                    }
                }
            }
            this.Close();
        }

        private void UpdateOrderAudit(string newDate, string newStatus, string orderID, string oldDate, string oldStatus)
        {
            try
            {
                CurrentUser.UpdateOrder(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email
                );

                AuditHelper.Log(
                    tableName: "salesorder",
                    recordId: orderID,
                    action: "Update Order",
                    userId: CurrentUser.UserID,
                    oldValues: oldDate + ", " + oldStatus, // 這裡可以擴充為實際的舊值物件
                    newValues: newDate + ", " + newStatus // 這裡可以擴充為實際的新值物件
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void editOrder_Load(object sender, EventArgs e)
        {
            tbCustName.Enabled = false;
            tbAddress.Enabled = false;
            OrderDate.Enabled = false;
            tbTotal.Enabled = false;
            string constring = "server=localhost;user id=root;password=;database=4915";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string Query = "SELECT OrderID FROM salesorder WHERE Status != 'Cancel' ORDER BY OrderID ASC";
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
            string Query2 = @"
                SELECT c.Name, c.Address, s.Status, s.TotalAmount
                FROM salesorder s 
                INNER JOIN customer c ON s.CustomerID = c.CustomerID 
                WHERE s.OrderID = @OrderID 
                LIMIT 1;";

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
                        // 帶入安全的參數
                        cmd2.Parameters.AddWithValue("@OrderID", cmOrderID.SelectedItem.ToString());

                        // 💡 因為要取多個欄位，改用 ExecuteReader()
                        using (MySqlDataReader custReader = cmd2.ExecuteReader())
                        {
                            if (custReader.Read()) // 如果有找到該筆訂單與客戶資料
                            {
                                // 精準取出欄位並寫入對應的 TextBox
                                tbCustName.Text = custReader["Name"].ToString();
                                tbAddress.Text = custReader["Address"].ToString();
                                cbStatus.Text = custReader["Status"].ToString();
                                tbTotal.Text = custReader["TotalAmount"].ToString();
                            }
                            else
                            {
                                // 查無資料時的防呆清空
                                tbCustName.Text = "Unknown Customer";
                                tbAddress.Text = string.Empty;
                            }
                        } // 這裡會自動關閉 custReader，釋放連線
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("A database error occurred while querying order details: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deliveryDate_ValueChanged(object sender, EventArgs e)
        {
            // 這裡可以加入一些邏輯，例如檢查交貨日期是否合理
            if (deliveryDate.Value < DateTime.Now)
            {
                MessageBox.Show("Delivery date cannot be earlier than today!");
                deliveryDate.Value = DateTime.Now; // 重置為今天
            }
        }
    }
}
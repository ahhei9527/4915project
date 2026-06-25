using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace _4915project
{
    public partial class LinkSNtoOrder : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";

        public LinkSNtoOrder()
        {
            InitializeComponent();
        }

        private void LinkSNtoOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadSerialNumbers();

            // Disable fields that should be read-only
            tbBatch.Enabled = false;
            tbProduct.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void LoadOrders()
        {
            cmbOrderID.Items.Clear();

            string query = @"
                SELECT DISTINCT so.OrderID
                FROM salesorder so
                LEFT JOIN shipment s ON s.OrderID = so.OrderID
                LEFT JOIN deliveryitem d ON d.ShipmentID = s.ShipmentID
                WHERE d.SerialNumber IS NULL OR d.SerialNumber = ''
                ORDER BY so.OrderID ASC;";

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
                            cmbOrderID.Items.Add(reader["OrderID"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load Order ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadSerialNumbers()
        {
            cmbSN.Items.Clear();

            string query = "SELECT SerialNumber FROM productinstance ORDER BY SerialNumber ASC;";

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
                            cmbSN.Items.Add(reader["SerialNumber"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load Serial Number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSN.SelectedItem == null) return;

            string selectedSN = cmbSN.SelectedItem.ToString();

            string query = @"
                SELECT BatchID, ProductID 
                FROM productinstance 
                WHERE SerialNumber = @SerialNumber;";

            using (MySqlConnection con = new MySqlConnection(constring))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@SerialNumber", selectedSN);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbBatch.Text = reader["BatchID"]?.ToString() ?? "";
                            tbProduct.Text = reader["ProductID"]?.ToString() ?? "";
                        }
                        else
                        {
                            tbBatch.Clear();
                            tbProduct.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Product information loading failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (cmbOrderID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Order ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderID = cmbOrderID.SelectedItem?.ToString();
            string serialNumber = cmbSN.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(serialNumber))
            {
                MessageBox.Show("Please select Serial Number (SN)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // === Generate next DeliveryItemID (DI001, DI002, ...) ===
                    string newDeliveryItemID = "DI001"; // fallback

                    string queryMaxDI = @"
                SELECT DeliveryItemID 
                FROM deliveryitem 
                WHERE DeliveryItemID LIKE 'DI%' 
                ORDER BY DeliveryItemID DESC 
                LIMIT 1;";

                    using (MySqlCommand cmdMax = new MySqlCommand(queryMaxDI, con))
                    {
                        object result = cmdMax.ExecuteScalar();
                        if (result != null)
                        {
                            string lastID = result.ToString();
                            if (lastID.Length >= 3)
                            {
                                int num = int.Parse(lastID.Substring(2)) + 1;
                                newDeliveryItemID = "DI" + num.ToString("D3");
                            }
                        }
                    }

                    // === Main Insert with generated DeliveryItemID ===
                    string queryLink = @"
                INSERT INTO deliveryitem (DeliveryItemID, ShipmentID, SerialNumber, Quantity)
                SELECT @DeliveryItemID, s.ShipmentID, @SerialNumber, 1
                FROM shipment s
                WHERE s.OrderID = @OrderID
                  AND NOT EXISTS (
                      SELECT 1 FROM deliveryitem d 
                      WHERE d.ShipmentID = s.ShipmentID 
                        AND d.SerialNumber = @SerialNumber
                  )
                ORDER BY s.ShipmentID DESC
                LIMIT 1;";

                    using (MySqlCommand cmd = new MySqlCommand(queryLink, con))
                    {
                        cmd.Parameters.AddWithValue("@DeliveryItemID", newDeliveryItemID);
                        cmd.Parameters.AddWithValue("@SerialNumber", serialNumber);
                        cmd.Parameters.AddWithValue("@OrderID", orderID);

                        int affected = cmd.ExecuteNonQuery();

                        if (affected > 0)
                        {
                            MessageBox.Show($"✅ SN {serialNumber} Successfully connected to Order {orderID}\nDeliveryItemID: {newDeliveryItemID}",
                                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadOrders();           // Refresh orders without SN
                            cmbSN.SelectedIndex = -1;
                            tbBatch.Clear();
                            tbProduct.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Unable to find the corresponding Shipment, Or this SN is already linked.。\nPlease confirm that the order has been created and a shipment has been made.",
                                          "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Link failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
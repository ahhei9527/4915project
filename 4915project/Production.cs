using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace _4915project
{
    public partial class Production : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        public Production()
        {
            InitializeComponent();
        }

        private void Production_Load(object sender, EventArgs e)
        {
            getSN();
        }

        private void getSN()
        {
            // 💡 修正 1：移除 so.Status 後方多餘的逗號
            string query = @"
    SELECT 
        so.OrderID,
        c.Name AS CustomerName,
        so.Status,
        so.RequestDeliveryDate
    FROM salesorder so
    LEFT JOIN customer c ON so.CustomerID = c.CustomerID
    LEFT JOIN shipment s ON s.OrderID = so.OrderID
    LEFT JOIN deliveryitem d ON d.ShipmentID = s.ShipmentID
    WHERE d.SerialNumber IS NULL
    ORDER BY so.OrderID ASC;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        DataTable dt = new DataTable();

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        // 1. 綁定 DataGridView
                        dataGridView1.DataSource = dt;

                        // 2. 清空舊的下拉選單項目（避免重複呼叫時項目疊加）
                        cmbOrderID.Items.Clear();
                        cmbCust.Items.Clear();
                        cmbStatus.Items.Clear();

                        // 💡 修正 2：直接利用記憶體中的 DataTable 跑迴圈，不重複讀取 Reader，效能更好
                        foreach (DataRow row in dt.Rows)
                        {
                            string orderId = row["OrderID"].ToString();
                            string custName = row["CustomerName"].ToString();
                            string status = row["Status"].ToString();

                            // 💡 只有在選單中不存在時，才塞入項目（達到去重效果）
                            if (!cmbOrderID.Items.Contains(orderId))
                            {
                                cmbOrderID.Items.Add(orderId);
                            }

                            if (!cmbCust.Items.Contains(custName))
                            {
                                cmbCust.Items.Add(custName);
                            }

                            if (!cmbStatus.Items.Contains(status))
                            {
                                cmbStatus.Items.Add(status);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("系統錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Close();
        }

        private void btSales_Click(object sender, EventArgs e)
        {
            SalesOrder salesOrder = new SalesOrder();
            salesOrder.Show();
            this.Close();
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            FormLogistics logistics = new FormLogistics();
            logistics.Show();
            this.Close();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Close();
        }

        private void btProduction_Click(object sender, EventArgs e)
        {
            Production production = new Production();
            production.Show();
            this.Close();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            FormSetting setting = new FormSetting();
            setting.Show();
        }

        private void btSNClear_Click(object sender, EventArgs e)
        {
            cmbCust.SelectedIndex = -1;
            cmbOrderID.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        private void btSNReflash_Click(object sender, EventArgs e)
        {
            getSN();
        }

        private void btSNSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // 1. 基本 SQL 語句
                    string query = @"
            SELECT 
                so.OrderID,
                c.Name AS CustomerName,
                so.Status,
                so.RequestDeliveryDate
            FROM salesorder so
            LEFT JOIN customer c ON so.CustomerID = c.CustomerID
            LEFT JOIN shipment s ON s.OrderID = so.OrderID
            LEFT JOIN deliveryitem d ON d.ShipmentID = s.ShipmentID
            WHERE d.SerialNumber IS NULL ";

                    // 2. 根據下拉選單是否有選值，動態拼接 SQL 條件
                    if (cmbOrderID.SelectedIndex != -1)
                    {
                        query += " AND so.OrderID = @OrderID ";
                    }
                    if (cmbCust.SelectedIndex != -1)
                    {
                        query += " AND c.Name = @CustomerName ";
                    }
                    if (cmbStatus.SelectedIndex != -1)
                    {
                        query += " AND so.Status = @Status ";
                    }

                    // 加上原本的日期區間條件與排序
                    query += " AND so.RequestDeliveryDate >= @StartDate AND so.RequestDeliveryDate <= @EndDate ";
                    query += " ORDER BY so.OrderID ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // 3. 綁定動態條件的參數數值
                        if (cmbOrderID.SelectedIndex != -1)
                        {
                            cmd.Parameters.AddWithValue("@OrderID", cmbOrderID.SelectedItem.ToString());
                        }
                        if (cmbCust.SelectedIndex != -1)
                        {
                            cmd.Parameters.AddWithValue("@CustomerName", cmbCust.SelectedItem.ToString());
                        }
                        if (cmbStatus.SelectedIndex != -1)
                        {
                            cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                        }

                        // 💡 提示：請確保您的表單上有這兩個日期控制項（例如 DateTimePicker），此處數值需依據實況調整
                        cmd.Parameters.AddWithValue("@StartDate", StartDate.Value.Date);
                        cmd.Parameters.AddWithValue("@EndDate", EndDate.Value.Date);

                        // 4. 執行查詢並更新介面
                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查詢失敗: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
using _4915project;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _4915project
{
    public partial class SalesOrder : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        public SalesOrder()
        {
            InitializeComponent();
            // 把設定表格外觀的程式碼放在這裡，一載入就會生效
            this.dgvOrderItems.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvOrderItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Logoutbt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {


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

            Application.Exit();
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
            this.Close();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            FormOrderDetail CreateOrder = new FormOrderDetail();
            CreateOrder.Show();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();

                string query = @"
                    SELECT userid, name, role FROM user 
                    WHERE userid = @UserId 
                    LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
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
                                gbMenu.Visible = false; // 隱藏管理員專用的功能區塊
                            }
                        }
                    }
                }
            }

            // Populate Report Type ComboBox (add this in Designer: cmbReportType)
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("Quoted");
            comboBoxStatus.Items.Add("Confirmed");
            comboBoxStatus.Items.Add("Processing");
            comboBoxStatus.Items.Add("Delivered");
            comboBoxStatus.Items.Add("Paid");
            comboBoxStatus.SelectedIndex = 0;

            LoadReport();   // Load default report
        }

        private void LoadReport()
        {

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = @"Select * from salesorder WHERE Status != 'Cancel' ORDER BY OrderID ASC";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOrderItems.DataSource = dt;
                }
            }
        }

        private void btnSearch_click(object sender, EventArgs e)
        {
            // 1. 基本 SQL 語句：使用 WHERE 1=1 作為安全的起點，並排除 Cancel 狀態
            string query = @"SELECT s.*, c.name AS custName
                     FROM salesorder s
                     INNER JOIN customer c ON s.CustomerID = c.CustomerID
                     WHERE s.Status != 'Cancel' AND 1=1";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;

                    // 2. 動態拼接字串與綁定參數
                    if (!string.IsNullOrWhiteSpace(textOrderID.Text))
                    {
                        query += " AND s.orderID LIKE @OrderID";
                        cmd.Parameters.AddWithValue("@OrderID", "%" + textOrderID.Text.Trim() + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(textCust.Text))
                    {
                        query += " AND (c.Name LIKE @CustName OR s.CustomerID LIKE @CustName)";
                        cmd.Parameters.AddWithValue("@CustName", "%" + textCust.Text.Trim() + "%");
                    }

                    // 3. 拼接日期範圍（確保包含結束日的整天）
                    query += " AND s.OrderDate >= @StartDate AND s.OrderDate <= @EndDate";

                    cmd.Parameters.AddWithValue("@StartDate", dateTimePickerStart.Value.Date); // 00:00:00
                    cmd.Parameters.AddWithValue("@EndDate", dateTimePickerEnd.Value.Date.AddDays(1).AddSeconds(-1)); // 23:59:59

                    // 4. 加上排序並將最終字串賦值給 CommandText
                    query += " ORDER BY s.OrderID ASC;";
                    cmd.CommandText = query;

                    try
                    {
                        // MySqlDataAdapter 會自動開啟與關閉連線，不需要手動 con.Open()
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvOrderItems.DataSource = dt;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Order inquiry failed: " + ex.Message);
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textCust.Text = "";
            textOrderID.Text = "";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            EditOrder editOrderForm = new EditOrder();
            editOrderForm.Show();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            FormSetting setting = new FormSetting();
            setting.Show();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Close();
        }

        private void Logistics_Click(object sender, EventArgs e)
        {
            FormLogistics log = new FormLogistics();
            log.Show();
            this.Close();
        }

        private void AfterSales_Click(object sender, EventArgs e)
        {
            AfterSales afterSales = new AfterSales();
            afterSales.Show();
            this.Close();
        }

        private void Production_Click(object sender, EventArgs e)
        {
            Production production = new Production();
            production.Show();
            this.Close();
        }

        private void btRawMaterial_Click(object sender, EventArgs e)
        {
            RawMaterial rawMaterial = new RawMaterial();
            rawMaterial.Show();
            this.Close();
        }
    }
}
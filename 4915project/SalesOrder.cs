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

namespace ITP4915M
{
    public partial class SalesOrder : Form
    {
        public SalesOrder()
        {
            InitializeComponent();
            // 把設定表格外觀的程式碼放在這裡，一載入就會生效
            this.dgvOrderItems.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvOrderItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void Logoutbt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentUser.Logout();
            this.Close();
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
            this.Close();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            FormOrdelDetail CreateOrder = new FormOrdelDetail();
            CreateOrder.Show();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
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
            string constring = "server=localhost;user id=root;password=;database=4915";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = @"Select * from salesorder";
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
            string OrderIDSearch = textOrderID.Text;
            string CustSearch = textCust.Text;
            string constring = "server=localhost;user id=root;password=;database=4915";
            string startDate = dateTimePickerStart.Value.ToString("yyyy-MM-dd");
            string endDate = dateTimePickerEnd.Value.ToString("yyyy-MM-dd");
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                if ((textOrderID.Text != "") && (textCust.Text != ""))
                {
                    string query = @"SELECT s.*, c.name AS custName
                             FROM salesorder s
                             INNER JOIN customer c ON s.CustomerID = c.CustomerID
                             WHERE s.orderID LIKE @OrderID 
                               AND c.Name LIKE @CustName 
                               AND s.OrderDate > @StartDate 
                               AND s.OrderDate < @EndDate;";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", "%" + OrderIDSearch + "%");
                        cmd.Parameters.AddWithValue("@CustName", "%" + CustSearch + "%");
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvOrderItems.DataSource = dt;
                    }
                }
                else if ((textOrderID.Text != "") && (textCust.Text == ""))
                {
                    string query = @"SELECT s.*, c.name AS custName
                             FROM salesorder s
                             INNER JOIN customer c ON s.CustomerID = c.CustomerID
                             WHERE s.orderID LIKE @OrderID
                               AND s.OrderDate > @StartDate 
                               AND s.OrderDate < @EndDate;";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", "%" + OrderIDSearch + "%");
                        cmd.Parameters.AddWithValue("@CustName", "%" + CustSearch + "%");
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvOrderItems.DataSource = dt;
                    }
                }
                else if ((textOrderID.Text == "") && (textCust.Text != ""))
                {
                    string query = @"SELECT s.*, c.name AS custName
                             FROM salesorder s
                             INNER JOIN customer c ON s.CustomerID = c.CustomerID
                             WHERE c.Name LIKE @CustName 
                               AND s.OrderDate > @StartDate 
                               AND s.OrderDate < @EndDate;";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", "%" + OrderIDSearch + "%");
                        cmd.Parameters.AddWithValue("@CustName", "%" + CustSearch + "%");
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvOrderItems.DataSource = dt;
                    }
                }
                else
                {
                    // 1. 修正拼字（Sataus -> Status），並將狀態改為安全的參數 @Status
                    string query = @"SELECT s.*, c.name AS custName
                     FROM salesorder s
                     INNER JOIN customer c ON s.CustomerID = c.CustomerID
                     WHERE s.OrderDate > @StartDate 
                       AND s.OrderDate < @EndDate
                       AND s.Status = @Status;";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // 2. 依序安全地綁定所有參數
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        // 防呆：確保選取的值不為 null，若為 null 則帶入空字串
                        cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem?.ToString() ?? "");

                        try
                        {
                            // 如果你的 con 在外面還沒 open()，記得在這邊加上 con.Open(); 
                            // （不過 DataAdapter.Fill 其實會自動處理連線開啟與關閉，但手動確保更安全）

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvOrderItems.DataSource = dt;
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("查詢訂單失敗: " + ex.Message);
                        }
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

        }

        private void SalesOrder_Click(object sender, EventArgs e)
        {
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
            this.Close();
        }
    }
}

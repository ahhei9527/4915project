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
    public partial class FormOrder : Form
    {
        public FormOrder()
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

        private void button1_Click(object sender, EventArgs e)
        {
            // 直接關閉目前的 Form3Order 頁面
            this.Close();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            // 1. 產生 FormOrdelDetail (Form4) 的新物件
            //FormOrdelDetail form4 = new FormOrdelDetail();

            // 2. 顯示 Form4
            //form4.Show();

            // 3. 隱藏目前的 Form3 (舊畫面)
            this.Hide();
            FormOrder orderForm = new FormOrder();
            orderForm.Show();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();

                // 修正：在 SELECT 中加入了 role 欄位
                string query = @"
    SELECT userid, name, role FROM user 
    WHERE userid = @UserId 
    LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // 修正：必須呼叫 reader.Read() 檢查並讀取資料
                        if (reader.Read())
                        {
                            string dbUsername = reader["name"]?.ToString() ?? "";
                            string dbRole = reader["role"]?.ToString() ?? "User";
                            lblWelcome.Text = $"Welcome, {dbUsername}({dbRole})";
                            if (dbRole != "ADMIN")
                            {
                                lblOrder.Hide();
                                palOrder.Hide();
                            }
                        }
                    }
                }
            }

            // Populate Report Type ComboBox (add this in Designer: cmbReportType)
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("Delivered");
            comboBoxStatus.Items.Add("Processing");
            comboBoxStatus.Items.Add("Confirmed");
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
            if(textOrderID.Text != "")
            {
                string OrderIDSearch = textOrderID.Text;
                string constring = "server=localhost;user id=root;password=;database=4915";
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();
                    string query = @"Select * from salesorder where orderID = " + OrderIDSearch;
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvOrderItems.DataSource = dt;
                    }
                }
            }
        }
    }
}

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
    public partial class RawMaterial : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        public RawMaterial()
        {
            InitializeComponent();
        }

        private void RawMaterial_Load(object sender, EventArgs e)
        {
            loadRawMaterial();
        }
        private void loadRawMaterial()
        {
            cmbSupplier.Items.Add("");
            cmbType.Items.Add("");
            cmbUnit.Items.Add("");
            string query = @"select * from rawmaterial order by MaterialID ASC";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    dataGridView1.DataSource = dt;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbType.Items.Clear();
                        cmbUnit.Items.Clear();
                        cmbSupplier.Items.Clear();
                        DataView viewType = new DataView(dt);
                        DataTable dtDistinctType = viewType.ToTable(true, "Type");
                        foreach (DataRow row in dtDistinctType.Rows)
                        {
                            cmbType.Items.Add(row["Type"].ToString());
                        }
                        DataView viewUnit = new DataView(dt);
                        DataTable dtDistinctUnit = viewUnit.ToTable(true, "Unit");
                        DataTable dtSortedUnit = dtDistinctUnit.DefaultView.ToTable();

                        foreach (DataRow row in dtSortedUnit.Rows)
                        {
                            cmbUnit.Items.Add(row["Unit"].ToString());
                        }
                        DataView viewSupplier = new DataView(dt);
                        DataTable dtDistinctSupplier = viewSupplier.ToTable(true, "PreferredSupplier");
                        DataTable dtSortedSupplier = dtDistinctSupplier.DefaultView.ToTable();

                        foreach (DataRow row in dtSortedSupplier.Rows)
                        {
                            cmbSupplier.Items.Add(row["PreferredSupplier"].ToString());
                        }
                    }
                }
            }
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
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Close();
        }

        private void btSales_Click(object sender, EventArgs e)
        {
            SalesOrder order = new SalesOrder();
            order.Show();
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

        private void Production_Click(object sender, EventArgs e)
        {
            Production production = new Production();
            production.Show();
            this.Close();
        }

        private void btAfterSales_Click(object sender, EventArgs e)
        {
            AfterSales afterSales = new AfterSales();
            afterSales.Show();
            this.Close();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            FormSetting setting = new FormSetting();
            setting.Show();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cmbSupplier.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            // 💡 修正：在 "where 1=1" 後面或接下來的 " and" 前面加上空格
            string query = @"select * from rawmaterial where 1=1 ";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                // 💡 優化：直接將 query 與 con 傳入建構子
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    if (cmbType.SelectedIndex >= 0)
                    {
                        cmd.CommandText += " and Type = @Type";
                        cmd.Parameters.AddWithValue("@Type", cmbType.SelectedItem?.ToString());
                    }

                    // 💡 修正 2：供應商下拉選單也一併修正
                    if (cmbSupplier.SelectedIndex >= 0)
                    {
                        cmd.CommandText += " and PreferredSupplier = @Supplier";
                        cmd.Parameters.AddWithValue("@Supplier", cmbSupplier.SelectedItem?.ToString());
                    }

                    // 💡 修正 3：單位下拉選單也一併修正
                    if (cmbUnit.SelectedIndex >= 0)
                    {
                        cmd.CommandText += " and Unit = @Unit";
                        cmd.Parameters.AddWithValue("@Unit", cmbUnit.SelectedItem?.ToString());
                    }

                    // 💡 修正：前方加上空格 " order by..."
                    cmd.CommandText += " order by MaterialID ASC";

                    try
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // 更新畫面控制項
                        dataGridView1.DataSource = dt;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Search failed: " + ex.Message);
                    }
                }
            }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            CreateRawMaterial createRawMaterial = new CreateRawMaterial();
            createRawMaterial.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditRawMaterial editRawMaterial = new EditRawMaterial();
            editRawMaterial.Show();
        }
    }
}

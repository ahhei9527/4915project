using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MySql.Data.MySqlClient;

namespace _4915project
{
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {
            cmbComLan.Items.AddRange(new string[] { "Chinese", "English" });
            cmbComWH.Items.AddRange(new string[] { "WH-A-12-03", "WH-A-12-04", "WH-B-05-01", "WH-C-08-02" });
            cmbComCurr.Items.AddRange(new string[] { "HKD", "USD", "CNY" });
        }

        private void buttonResetDefault_Click(object sender, EventArgs e)
        {
            tbComName.Text = "";
            cmbComLan.Text = "";
            cmbComWH.Text = "";
            cmbComCurr.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
            string query = "INSERT INTO company (CompanyName, warehouse, launage, currency) " +
                "VALUES (@CompanyName, @warehouse, @launage, @currency)";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CompanyName", tbComName.Text);
                    cmd.Parameters.AddWithValue("@warehouse", cmbComWH.Text);
                    cmd.Parameters.AddWithValue("@launage", cmbComLan.Text);
                    cmd.Parameters.AddWithValue("@currency", cmbComCurr.Text);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        addCompanyAudit();
                        MessageBox.Show("Company added successfully!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding company: " + ex.Message);
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCompanyAudit()
        {
            try
            {
                CurrentUser.AddInward(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email);

                AuditHelper.Log(
                    tableName: "company",
                    recordId: tbComName.Text.ToString(),
                    action: "add company",
                    userId: CurrentUser.UserID,
                    newValues: tbComName.Text.ToString()
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }
    }
}
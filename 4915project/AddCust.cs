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
    public partial class AddCust : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        int custID = 0;
        public AddCust()
        {
            InitializeComponent();
        }

        private void AddCust_Load(object sender, EventArgs e)
        {
            string comquery = "SELECT CompanyName FROM company";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(comquery, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbCustCompany.Items.Add(reader.GetString("CompanyName"));
                        }
                    }
                }
            }
            GenCustID();
        }

        private void GenCustID()
        {
            string query = "SELECT COALESCE(MAX(CustomerID), 0) FROM customer";

            try
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();

                        int maxId = Convert.ToInt32(cmd.ExecuteScalar());

                        // 🎯 終極精簡：直接讓全域的 int 變數精準 +1 即可，完全不需要任何字串轉換！
                        custID = maxId + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error generating Customer ID: " + ex.Message);
                custID = 1; // 發生異常時的安全預設值
            }
        }

        private void btCustReset_Click(object sender, EventArgs e)
        {
            tbCustAddress.Text = "";
            tbCustEmail.Text = "";
            tbCustName.Text = "";
            tbCustPhone.Text = "";
            cmbCustCompany.Text = "";
        }

        private void btCustCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCustSave_Click(object sender, EventArgs e)
        {
            // 1. 前端 UI 基礎防呆驗證
            if (string.IsNullOrEmpty(tbCustName.Text.Trim()))
            {
                MessageBox.Show("Please enter the Customer Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🎯 修正點：確保這裡的欄位對齊 CustomerID，與 GenCustID 遙相呼應
            string insertQuery = @"
        INSERT INTO customer (CustomerID, Name, Company, Email, Phone, Address) 
        VALUES (@CustomerID, @Name, @Company, @Email, @Phone, @Address);";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", custID); // 完美傳入 int 變數
                    cmd.Parameters.AddWithValue("@Name", tbCustName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Company", cmbCustCompany.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", tbCustEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", tbCustPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", tbCustAddress.Text.Trim());

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CreateCustAudit();
                        GenCustID();                  // 重新計算下一組整數單號
                        btCustReset_Click(sender, e); // 呼叫您的清空重設事件
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1062) // 主鍵重複衝突防禦
                        {
                            MessageBox.Show("This Customer ID already exists. The system is recalculating a new ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            GenCustID();
                        }
                        else
                        {
                            MessageBox.Show("Database error adding customer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected system error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CreateCustAudit()
        {
            try
            {
                CurrentUser.CreateOrder(CurrentUser.UserID, CurrentUser.Username,
                                      CurrentUser.Role, CurrentUser.Email);

                AuditHelper.Log("customer", custID.ToString(), "Create Customer", CurrentUser.UserID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }
    }
}
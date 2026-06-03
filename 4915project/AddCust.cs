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
        string custID;
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
            try
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();
                    string query = "SELECT MAX(CustID) FROM customer";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    int nextId = 1; // Default to 1 if the table is completely empty
                    if (result != null && result != DBNull.Value)
                    {
                        nextId = Convert.ToInt32(result) + 1;
                    }
                    custID = nextId.ToString("D3");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Customer ID: " + ex.Message);
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
            string insertQuery = "INSERT INTO customer " +
                "(CustomerID, Name, Company, Email, Phone, Address) " +
                "VALUES (@CustomerID, @Name, @Company, @Email, @Phone, @Address)";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", custID);
                    cmd.Parameters.AddWithValue("@Name", tbCustName.Text);
                    cmd.Parameters.AddWithValue("@Company", cmbCustCompany.Text);
                    cmd.Parameters.AddWithValue("@Email", tbCustEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", tbCustPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", tbCustAddress.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully!");
                        CreateCustAudit();
                        GenCustID(); // Generate the next Customer ID for the next entry
                        btCustReset_Click(sender, e); // Clear the form for the next entry
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding customer: " + ex.Message);
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

                AuditHelper.Log("customer", custID, "Create Customer", CurrentUser.UserID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }
    }
}

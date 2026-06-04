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
    public partial class AddEmployee : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        string UserID;
        string Email = "@company.com"; // Default email domain, can be modified as needed
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[] { "Admin", "Staff" });
            cmbDepartment.Items.AddRange(new string[] { "Sales", "Production", "Warehouse", "Design", "After Sales", "Logistics" });
            GenUserID();
        }

        private void GenUserID()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();
                    // Since it's an INT, we can just grab the maximum value directly
                    string query = "SELECT MAX(UserID) FROM user";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    object result = cmd.ExecuteScalar();

                    int nextId = 1; // Default to 1 if the table is completely empty

                    if (result != null && result != DBNull.Value)
                    {
                        nextId = Convert.ToInt32(result) + 1;
                    }

                    // This keeps your C# 'UserID' variable padded as "001", "002", etc.
                    UserID = nextId.ToString("D3");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating User ID: " + ex.Message);
            }
        }

        private void ResetDefault_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "";
            tbPassword.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbPosit.Text = "";
            cmbRole.Text = "";
            cmbDepartment.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();
                    string query = "INSERT INTO user " +
                        "(UserID, Name, position, Role, Department, Email, Phone, password) " +
                                   "VALUES (@UserID, @Name, @posit, @Role, @Depart, @Email, @Phone, @Pwd)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@Name", tbUserName.Text);
                        cmd.Parameters.AddWithValue("@posit", tbPosit.Text);
                        cmd.Parameters.AddWithValue("@Role", cmbRole.Text);
                        cmd.Parameters.AddWithValue("@Depart", cmbDepartment.Text);
                        cmd.Parameters.AddWithValue("@Email", tbEmail.Text + Email.ToString());
                        cmd.Parameters.AddWithValue("@Phone", tbPhone.Text);
                        cmd.Parameters.AddWithValue("@Pwd", tbPassword.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee added successfully!");
                            AddUserAudit();
                            GenUserID(); // Generate the next UserID for the next entry
                            ResetDefault_Click(sender, e); // Clear the form for the next entry
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving employee: " + ex.Message);
            }
        }

        private void AddUserAudit()
        {
            try
            {
                CurrentUser.CreateOrder(CurrentUser.UserID, CurrentUser.Username,
                                      CurrentUser.Role, CurrentUser.Email);

                AuditHelper.Log("user", UserID, "Add User", CurrentUser.UserID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }
    }
}

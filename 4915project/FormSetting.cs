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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _4915project
{
    public partial class FormSetting : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            LoadCompany();
            LoadUser();
            LoadCustomer();
            cmbComLan.Items.AddRange(new string[] { "Chinese", "English" });
            cmbComWH.Items.AddRange(new string[] { "WH-A-12-03", "WH-A-12-04", "WH-B-05-01", "WH-C-08-02" });
            cmbComCurr.Items.AddRange(new string[] { "HKD", "USD", "CNY" });
            cmbRole.Items.AddRange(new string[] { "ADMIN", "STAFF" });
            cmbDepartment.Items.AddRange(new string[] { "Sales", "Production", "Warehouse", "Design", "After Sales", "Logistics" });
            tbPassword.Enabled = false;
            cmbRole.Enabled = false;
            cmbDepartment.Enabled = false;
            tbPosit.Enabled = false;

        }

        private void LoadCompany()
        {
            // Code to load company data into the form
            string query = "SELECT Companyname FROM company";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            //cmbCompanyName.Items.Add(reader["CompanyName"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading company data: " + ex.Message);
                    }
                }
            }
        }

        private void LoadUser()
        {
            // Code to load user data into the form
            string query = "SELECT Name FROM user";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbUserName.Items.Add(reader["Name"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading company data: " + ex.Message);
                    }
                }
            }
        }

        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCompanyData();
        }

        private void btAddCom_Click(object sender, EventArgs e)
        {
            AddCompany addCompany = new AddCompany();
            addCompany.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonResetDefault_Click(object sender, EventArgs e)
        {
            LoadCompanyData();
        }

        private void LoadCompanyData()
        {
            // Code to load default company data into the form
            string companyQuery = "SELECT * FROM company WHERE CompanyName = @CompanyName";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(companyQuery, con))
                {
                    cmd.Parameters.AddWithValue("@CompanyName", cmbCompanyName.SelectedItem?.ToString());
                    try
                    {
                        con.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            cmbComLan.SelectedItem = reader["launage"].ToString();
                            cmbComWH.SelectedItem = reader["warehouse"].ToString();
                            cmbComCurr.SelectedItem = reader["currency"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading company details: " + ex.Message);
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string comQuery = "UPDATE company SET " +
                "launage = @Language, " +
                "warehouse = @Warehouse, " +
                "currency = @Currency " +
                "WHERE CompanyName = @CompanyName";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(comQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Language", cmbComLan.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Warehouse", cmbComWH.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Currency", cmbComCurr.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@CompanyName", cmbCompanyName.SelectedItem?.ToString());
                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Company settings updated successfully.");
                            UpdateCompanySettingsAudit();
                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the company settings.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving company settings: " + ex.Message);
                    }
                }
            }
        }

        private void UpdateCompanySettingsAudit()
        {
            try
            {
                CurrentUser.AddInward(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email);

                AuditHelper.Log(
                    tableName: "company",
                    recordId: cmbCompanyName.SelectedItem?.ToString(),
                    action: "Update  company",
                    userId: CurrentUser.UserID,
                    newValues: new
                    {
                        Language = cmbComLan.SelectedItem?.ToString(),
                        Warehouse = cmbComWH.SelectedItem?.ToString(),
                        Currency = cmbComCurr.SelectedItem?.ToString(),
                        CompanyName = cmbCompanyName.SelectedItem?.ToString()
                    }
                    );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            // Code to load default user data into the form
            string userQuery = "SELECT * FROM user WHERE Name = @Name";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(userQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Name", cmbUserName.SelectedItem?.ToString());
                    try
                    {
                        con.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            cmbRole.SelectedItem = reader["Role"].ToString();
                            cmbDepartment.SelectedItem = reader["Department"].ToString();
                            tbPosit.Text = reader["position"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading user details: " + ex.Message);
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPwd.Checked)
            {
                tbPassword.Enabled = true;
            }
            else
            {
                tbPassword.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRole.Checked)
            {
                cmbRole.Enabled = true;
                cmbDepartment.Enabled = true;
                tbPosit.Enabled = true;
            }
            else
            {
                cmbRole.Enabled = false;
                cmbDepartment.Enabled = false;
                tbPosit.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cbRole.Checked == false)
            {
                string userQuery = "UPDATE user SET " +
                "Role = @Role, " +
                "position = @position, " +
                "Department = Department " +
                "WHERE Name = @Name";
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand(userQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@position", tbPosit.Text.ToString());
                        cmd.Parameters.AddWithValue("@Department", cmbDepartment.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@Name", cmbUserName.SelectedItem?.ToString());
                        try
                        {
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee data updated successfully.");
                                UpdateUserSettingsAudit();
                            }
                            else
                            {
                                MessageBox.Show("No changes were made to the employee settings.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error saving employee settings: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                string userQuery = "UPDATE user SET " +
                "Password = @Password, " +
                "Role = @Role, " +
                "position = @position, " +
                "Department = Department " +
                "WHERE Name = @Name";
                string hashedPassword = ComputeSha256Hash(tbPassword.Text);
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand(userQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@position", tbPosit.Text.ToString());
                        cmd.Parameters.AddWithValue("@Department", cmbDepartment.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@Name", cmbUserName.SelectedItem?.ToString());
                        try
                        {
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Company settings updated successfully.");
                                UpdateUserSettingsAudit();
                            }
                            else
                            {
                                MessageBox.Show("No changes were made to the company settings.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error saving company settings: " + ex.Message);
                        }
                    }
                }
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a readable hex string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void UpdateUserSettingsAudit()
        {
            try
            {
                CurrentUser.AddInward(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email);
                AuditHelper.Log(
                    tableName: "user",
                    recordId: cmbUserName.SelectedItem?.ToString(),
                    action: "Update user",
                    userId: CurrentUser.UserID,
                    newValues: new
                    {
                        Role = cmbRole.SelectedItem?.ToString(),
                        position = tbPosit.Text.ToString(),
                        Department = cmbDepartment.SelectedItem?.ToString()
                    }
                    );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }



        private void LoadCustomer()
        {
            // Code to load customer data into the form
            string query = "SELECT Name FROM customer";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbCustName.Items.Add(reader["Name"].ToString());
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading company data: " + ex.Message);
                    }
                }
            }
            string compquery = "SELECT CompanyName FROM company";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(compquery, con))
                {
                    try
                    {
                        con.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbCustCompany.Items.Add(reader["CompanyName"].ToString());
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading company data: " + ex.Message);
                    }
                }
            }
        }

        private void cmbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            // Code to load default customer data into the form
            string customerQuery = "SELECT * FROM customer WHERE Name = @Name";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(customerQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Name", cmbCustName.SelectedItem?.ToString());
                    try
                    {
                        con.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            cmbCustCompany.SelectedItem = reader["Company"].ToString();
                            tbCustEmail.Text = reader["Email"].ToString();
                            tbCustPhone.Text = reader["Phone"].ToString();
                            tbCustAddress.Text = reader["Address"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading customer details: " + ex.Message);
                    }
                }
            }
        }

        private void btCustReset_Click(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void btCustCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCustSave_Click(object sender, EventArgs e)
        {
            string custQuery = "UPDATE customer SET " +
                "Company = @Company, " +
                "Email = @Email, " +
                "Phone = @Phone, " +
                "Address = @Address " +
                "WHERE Name = @Name";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(custQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Company", cmbCustCompany.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Email", tbCustEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", tbCustPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", tbCustAddress.Text);
                    cmd.Parameters.AddWithValue("@Name", cmbCustName.SelectedItem?.ToString());
                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer settings updated successfully.");
                            UpdateCustomerSettingsAudit();
                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the customer settings.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving customer settings: " + ex.Message);
                    }
                }
            }
        }

        private void UpdateCustomerSettingsAudit()
        {
            try
            {
                CurrentUser.AddInward(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email);
                AuditHelper.Log(
                    tableName: "customer",
                    recordId: cmbCustName.SelectedItem?.ToString(),
                    action: "Update customer",
                    userId: CurrentUser.UserID,
                    newValues: new
                    {
                        Company = cmbCustCompany.SelectedItem?.ToString(),
                        Email = tbCustEmail.Text,
                        Phone = tbCustPhone.Text,
                        Address = tbCustAddress.Text
                    }
                    );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }
        }

        private void btAddCust_Click(object sender, EventArgs e)
        {
            AddCust addCust = new AddCust();
            addCust.Show();
        }
    }
}
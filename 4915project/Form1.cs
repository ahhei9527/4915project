using _4915project;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
using System.Data;

namespace _4915project
{
    public partial class LoginPage : Form
    {


        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textBoxPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        public void Login()
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
            // Basic input validation
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxPwd.Text))
            {
                MessageBox.Show("Please enter both Email and Password.", "Input Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();

                    string query = "SELECT password, role FROM user WHERE Email = @Email LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader["password"].ToString();
                                string dbRole = reader["role"].ToString();

                                if (dbPassword == textBoxPwd.Text)
                                {
                                    MessageBox.Show("Login successful!", "Success",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Redirect based on role
                                    if (dbRole == "ADMIN")
                                    {
                                        DashBoard dashboard = new DashBoard();
                                        dashboard.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unknown role. Access denied.", "Error",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password.", "Login Failed",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email not found.", "Login Failed",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database connection error: {ex.Message}", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
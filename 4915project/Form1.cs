using MySql.Data.MySqlClient;
using System.Data;

namespace _4915project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";

            // Using 'using' statements automatically closes connections and prevents memory leaks
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                // Use a parameter (@Email) instead of direct string addition
                string query = "SELECT password FROM user WHERE Email = @Email LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // Safely pass the text box value to the SQL query
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);

                    try
                    {
                        con.Open();

                        // ExecuteScalar is better when you only need a single value back
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string dbPassword = result.ToString();

                            // Compare the database password with user input
                            if (dbPassword == textBoxPwd.Text)
                            {
                                MessageBox.Show("Login successful");
                            }
                            else
                            {
                                MessageBox.Show("Wrong password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email not found");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}

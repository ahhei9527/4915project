using _4915project;
using ITP4915M;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using static Org.BouncyCastle.Math.Primes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _4915project
{
    public partial class LoginPage : Form
    {

        string constring = "server=localhost;user id=root;password=;database=4915";
        int userId;
        string dbUsername;
        string dbPassword;
        string dbRole;
        string dbEmail;
        string dbDepartment;

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

                    string query = @"
                    SELECT userid, name, password, role, Department, email FROM user WHERE Email = @Email LIMIT 1";
                    string hash = @"update user set password = @Password where email = @Email";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = reader.GetInt32("userid");
                                dbUsername = reader["name"]?.ToString() ?? "";
                                dbPassword = reader["password"]?.ToString() ?? "";
                                dbRole = reader["role"]?.ToString() ?? "User";
                                dbEmail = reader["email"]?.ToString() ?? "";
                                dbDepartment = reader["department"].ToString() ?? "";
                            }else
                            {
                                MessageBox.Show("Email not found.", "Login Failed",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        // 1. 檢查資料庫裡的密碼是「新雜湊」還是「舊明文」
                        // 如果長度是 64 且不等於輸入的明文，代表它已經是 SHA-256 雜湊值了
                        bool isAlreadyHashed = (dbPassword.Length == 64 && textBoxPwd.Text != dbPassword);

                        if (isAlreadyHashed)
                        {
                            // 如果資料庫已經是雜湊，直接進驗證方法
                            VerifyLogin(textBoxPwd.Text, dbPassword);
                        }
                        else
                        {
                            // 如果資料庫裡是明文，且跟輸入的密碼相同 (舊用戶第一次登入)
                            if (textBoxPwd.Text == dbPassword)
                            {
                                string hashedValue = ComputeSha256Hash(textBoxPwd.Text);

                                // 修正後的 SQL 更新語句，確保傳入正確的 SQL 指令字串
                                string updateQuery = "UPDATE user SET password = @Password WHERE Email = @Email";

                                using (MySqlCommand hashCmd = new MySqlCommand(updateQuery, con))
                                {
                                    hashCmd.Parameters.AddWithValue("@Password", hashedValue);
                                    hashCmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
                                    hashCmd.ExecuteNonQuery();
                                }

                                // 【關鍵修正】升級後，傳入剛剛計算好的雜湊值 (hashedValue) 去做登入驗證
                                VerifyLogin(textBoxPwd.Text, hashedValue);
                            }
                            else
                            {
                                // 明文比對失敗，直接顯示錯誤
                                MessageBox.Show("密碼錯誤。", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void VerifyLogin(string enteredPassword, string storedHashInDatabase)
        {
            // 1. Hash the password that the user just typed into the login box
            string enteredPasswordHash = ComputeSha256Hash(enteredPassword);

            // 2. Compare the two hashes. 
            // StringComparison.Ordinal ensures a secure, exact byte-by-byte match.
            if (string.Equals(enteredPasswordHash, storedHashInDatabase, StringComparison.Ordinal))
            {
                // Passwords match, allow login
                CurrentUser.Login(
                                userId: userId,
                                username: dbUsername,
                                role: dbRole,
                                email: dbEmail
                            );
                AuditHelper.Log(
                    tableName: "user",
                    recordId: userId.ToString(),
                    action: "LOGIN",
                    userId: userId,
                    username: dbUsername,
                    description: $"User {dbUsername} logged in"
                );
                MessageBox.Show("Login successful!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Redirect based on role
                if (dbRole == "ADMIN")
                {
                    DashBoard dashboard = new DashBoard();
                    dashboard.Show();
                    this.Hide();
                }
                else if (dbDepartment == "Sales")
                {
                    SalesOrder salesForm = new SalesOrder();
                    salesForm.Show();
                    this.Hide();
                }
                else if (dbDepartment == "CustomerService")
                {
                    AfterSales afterSales = new AfterSales();
                    afterSales.Show();
                    this.Hide();
                }
                else if (dbDepartment == "Warehouse")
                {
                    FormLogistics logistics = new FormLogistics();
                    logistics.Show();
                    this.Hide();
                }
                else if (dbDepartment == "Production")
                {
                    //Production production = new Production();
                    //production.Show();
                    //this.Hide();
                    MessageBox.Show("Production department access is not implemented yet.", "Info",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dbDepartment == "Logistics")
                {
                    FormLogistics logistics = new FormLogistics();
                    logistics.Show();
                    this.Hide();
                }
                else if (dbDepartment == "Design")
                {
                    //SubmitDesign submitDesign = new SubmitDesign();
                    //submitDesign.Show();
                    //this.Hide();
                    MessageBox.Show("Design department access is not implemented yet.", "Info",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unknown role. Access denied.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Wrong password, deny entry
                MessageBox.Show("Incorrect password.", "Login Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
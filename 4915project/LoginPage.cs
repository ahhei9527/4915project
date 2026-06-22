using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _4915project
{
    public partial class LoginPage : Form
    {
        string constring = "server=localhost;user id=root;password=;database=4915";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => Login();

        private void textBoxPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Login();
        }

        // SHA256 Hash 輔助函數
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));
                return builder.ToString();
            }
        }

        public void Login()
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxPwd.Text))
            {
                MessageBox.Show("請輸入電子郵件與密碼。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();
                    string query = "SELECT userid, name, password, role, Department, email FROM user WHERE Email = @Email LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader["password"].ToString();
                                string inputPassword = textBoxPwd.Text;
                                string hashedInput = ComputeSha256Hash(inputPassword);

                                // 判斷資料庫密碼是否已是 Hash (以 64 位元長度判斷)
                                bool isDbHashed = (dbPassword.Length == 64);
                                bool isAuthenticated = false;

                                if (isDbHashed)
                                {
                                    // 直接對比
                                    isAuthenticated = (dbPassword == hashedInput);
                                }
                                else
                                {
                                    // 未 Hash，比對明文並順便更新
                                    if (dbPassword == inputPassword)
                                    {
                                        isAuthenticated = true;
                                        // 更新資料庫為 Hash
                                        UpdatePasswordToHash(reader["userid"].ToString(), hashedInput);
                                    }
                                }

                                if (isAuthenticated)
                                {
                                    // 成功登入邏輯...
                                    MessageBox.Show("登入成功！");
                                    // 這裡接續你原本的頁面導向邏輯
                                    if (reader["role"].ToString() == "ADMIN")
                                    {
                                        DashBoard dashBoard = new DashBoard();
                                        dashBoard.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("登入成功，但目前僅提供管理員使用。", "登入成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("密碼錯誤。", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("帳號不存在。", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系統錯誤: " + ex.Message);
            }
        }

        private void UpdatePasswordToHash(string userId, string hashedPassword)
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "UPDATE user SET password = @pwd WHERE userid = @uid";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pwd", hashedPassword);
                    cmd.Parameters.AddWithValue("@uid", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
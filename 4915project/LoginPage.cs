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
                MessageBox.Show("Please enter your email address and password.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 用於跨區塊傳遞資料的暫存變數
            bool isAuthenticated = false;
            bool needUpdateHash = false;
            string loggedInUserId = "";
            string loggedInName = "";
            string loggedInRole = "";
            string hashedInput = ComputeSha256Hash(textBoxPwd.Text);

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

                                bool isDbHashed = (dbPassword.Length == 64);

                                if (isDbHashed)
                                {
                                    isAuthenticated = (dbPassword == hashedInput);
                                }
                                else
                                {
                                    if (dbPassword == inputPassword)
                                    {
                                        isAuthenticated = true;
                                        // 💡 優化 1：先標記需要更新，暫時不在此處調用數據庫更新，避免死鎖
                                        needUpdateHash = true;
                                    }
                                }

                                if (isAuthenticated)
                                {
                                    // 暫存查出來的用戶資訊
                                    loggedInUserId = reader["userid"].ToString();
                                    loggedInName = reader["name"].ToString();
                                    loggedInRole = reader["role"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("The account does not exist.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        } // 💡 關鍵：第一個 reader 在這裡被完全釋放、關閉連線佔用！
                    }
                } // 外部 con 連線關閉

                // ==================== 驗證後的邏輯處理 (此處連線已完全乾淨) ====================
                if (isAuthenticated)
                {
                    // 💡 修正 2：異步/延後更新密碼雜湊值，此時完全不會引發 DataReader 死鎖
                    if (needUpdateHash)
                    {
                        UpdatePasswordToHash(loggedInUserId, hashedInput);
                    }

                    // 💡 正確作法：利用 int.Parse 轉換 ID，並直接呼叫內建方法傳遞參數
                    if (int.TryParse(loggedInUserId, out int parsedUserId))
                    {
                        // 呼叫你的 Login 封裝方法，完美符合私有 set 的規範！
                        CurrentUser.Login(parsedUserId, loggedInName, loggedInRole);
                    }
                    else
                    {
                        // 預防萬一 ID 轉換失敗時的替代處理
                        CurrentUser.Login(0, loggedInName, loggedInRole);
                    }

                    MessageBox.Show("Login successful!", "System prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 頁面導向邏輯
                    if (loggedInRole == "ADMIN")
                    {
                        DashBoard dashBoard = new DashBoard();
                        dashBoard.Show();
                        this.Hide();
                    }
                    else
                    {
                        // 如果未來一般用戶也要放行，直接在這裡 new 一般用戶的表單即可
                        MessageBox.Show("Login successful, but currently only available to administrators.", "Insufficient permissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("System error: " + ex.Message, "System error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
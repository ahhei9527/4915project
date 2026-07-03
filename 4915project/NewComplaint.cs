using _4915project;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Tsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _4915project
{
    public partial class FormNewComplaint : Form
    {
        public FormNewComplaint()
        {
            InitializeComponent();
        }

        private void FormNewComplaint_Load(object sender, EventArgs e)
        {
            GenComplaintID();
            GetUserID();
            tbCustName.ReadOnly = true;
            tbSN.ReadOnly = true;
            cbType.Items.AddRange(new string[] { "Damage", "Missing", "Return", "Refund", "Quality", "Serve", "Other" });
            string constring = "server=localhost;user id=root;password=;database=4915";
            string query = "SELECT OrderID FROM salesorder;";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbOrderID.Items.Add(reader["OrderID"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to load order information: " + ex.Message);
                    }
                }
                string queryUser = @"SELECT Name From user";
                using (MySqlCommand cmd2 = new MySqlCommand(queryUser, con))
                {
                    try
                    {
                        using (MySqlDataReader reader = cmd2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbUserID.Items.Add(reader["Name"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to load order information: " + ex.Message);
                    }
                }
            }
        }

        private void GenComplaintID()
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
            string prefix = "COMP"; // 4 碼文字
            string defaultID = prefix + "000001"; // 預設 6 位數的第一筆格式 (配合你註解的 6 位數需求)

            // 💡 核心修正 1：補上 ORDER BY ... DESC LIMIT 1，確保永遠撈出資料庫中「最大、最新」的那一筆單號
            string query = @"
        SELECT ComplaintID 
        FROM complaint 
        WHERE ComplaintID LIKE @Prefix 
        ORDER BY ComplaintID DESC 
        LIMIT 1;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Prefix", prefix + "%");

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        int nextNumber = 1;

                        if (result != null && result != DBNull.Value)
                        {
                            string lastComplaintID = result.ToString().Trim();

                            // 💡 核心修正 2：如果採用 COMP + 6位數數字 = COMP000001 (總長 10 碼)
                            if (lastComplaintID.Length >= 10)
                            {
                                // 🎯 精準切取最後 6 碼純數字（例如從 ""COMP015"" 切出 ""015""）
                                string lastNumberStr = lastComplaintID.Substring(lastComplaintID.Length - 3);

                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1; // 序號順利加 1
                                }
                            }
                            // 💡 備用修正 (如果你的資料庫舊資料是 3 位數，例如 COMP001，總長 7 碼)
                            else if (lastComplaintID.Length >= 7)
                            {
                                string lastNumberStr = lastComplaintID.Substring(lastComplaintID.Length - 3);
                                if (int.TryParse(lastNumberStr, out int lastNumber))
                                {
                                    nextNumber = lastNumber + 1;
                                }
                            }
                        }

                        // 💡 核心修正 3：完美對齊！根據你的註解要求，將新序號格式化為 3 位數 (D3)
                        tbComplaintID.Text = prefix + nextNumber.ToString("D3");
                        tbComplaintID.ReadOnly = true; // 設為唯讀，防止使用者改壞
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("無法取得資料庫流水號: " + ex.Message);

                        // 安全防呆：萬一資料庫斷線，自動帶入預設第一筆，絕不留白
                        tbComplaintID.Text = defaultID;
                        tbComplaintID.ReadOnly = false;
                    }
                }
            }
        }

        private void GetOrderInformation()
        {
            // 這裡可以撰寫從資料庫撈取訂單資訊的程式碼，並將其顯示在表單上
            string constring = "server=localhost;user id=root;password=;database=4915";
            string query = @"
            SELECT 
                so.OrderID, 
                c.Name AS CustomerName,      -- 💡 修正：一般客戶表的欄位是 Name，我們用 AS 取別名對齊你的前端
                pi.SerialNumber
            FROM salesorder so
            LEFT JOIN customer c ON so.CustomerID = c.CustomerID       -- 🎯 連結訂單與客戶
            LEFT JOIN shipment s ON s.OrderID = so.OrderID                         -- 🎯 連結訂單與出貨
            LEFT JOIN deliveryitem d ON d.ShipmentID = s.ShipmentID     -- 🎯 連結訂單與產品序號 (假設商品實例表中有 OrderID 外鍵)
            LEFT JOIN productinstance pi ON pi.SerialNumber = d.SerialNumber  -- 🎯 連結產品序號
            WHERE so.OrderID = @OrderID;";
            using (MySqlConnection con = new MySqlConnection(constring))
            {

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // 記得綁定你在 WHERE 中定義的 @OrderID 參數
                    cmd.Parameters.AddWithValue("@OrderID", cmbOrderID.SelectedItem?.ToString());
                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 1. 填入客戶名稱（這一定會有值）
                            tbCustName.Text = reader["CustomerName"]?.ToString() ?? "Unknown";

                            // 2. 安全填入序號（如果尚未生成則填入提示字，防止 NULL 閃退）
                            if (reader["SerialNumber"] != DBNull.Value && reader["SerialNumber"] != null)
                            {
                                tbSN.Text = reader["SerialNumber"].ToString();
                            }
                            else
                            {
                                tbSN.Text = "No Serial Number Found"; // 👈 安全防呆
                            }
                        }
                        else
                        {
                            MessageBox.Show("Order number not found. Please confirm again.");
                        }
                    }
                }
            }
        }

        private void GetUserID()
        {
            // 這裡可以撰寫從資料庫撈取使用者資訊的程式碼，並將其顯示在表單上
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOrderInformation();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";
            string CusID = @"SELECT CustomerID FROM customer WHERE Name = @Name";
            string query = @"INSERT INTO complaint (ComplaintID, CustomerID, OrderID, 
                                SerialNumber, UserID, IssueDate, Description, TYPE, 
                                Resolution, ResolutionDate) 
                             VALUES (@ComplaintID, @CustomerID, @OrderID, 
                                @SerialNumber, @UserID, @IssueDate, @Description, @Type, 
                                @Resolution, @ResolutionDate);";
            string queryUser = @"SELECT UserID FROM user WHERE Name = @Name";
            int customerId;
            int UserID;
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(CusID, con))
                {
                    cmd.Parameters.AddWithValue("@Name", tbCustName.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        customerId = Convert.ToInt32(result);
                        // 你可以在這裡使用 customerId 來進行後續操作，例如存入 complaint 表
                    }
                    else
                    {
                        MessageBox.Show("The corresponding customer ID could not be found. Please confirm that the customer name is correct.");
                        return; // 停止後續操作，避免存入錯誤資料
                    }
                }
                using (MySqlCommand cmdUser = new MySqlCommand(queryUser, con))
                {
                    cmdUser.Parameters.AddWithValue("@Name", cmbUserID.SelectedItem?.ToString());
                    object result = cmdUser.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        UserID = Convert.ToInt32(result);
                        // 你可以在這裡使用 UserID 來進行後續操作，例如存入 complaint 表
                    }
                    else
                    {
                        MessageBox.Show("The corresponding user ID could not be found. Please check if the username is correct.");
                        return; // 停止後續操作，避免存入錯誤資料
                    }
                }
                using (MySqlCommand cmd2 = new MySqlCommand(query, con))
                {
                    cmd2.Parameters.AddWithValue("@ComplaintID", tbComplaintID.Text);
                    cmd2.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd2.Parameters.AddWithValue("@OrderID", cmbOrderID.SelectedItem?.ToString());
                    cmd2.Parameters.AddWithValue("@SerialNumber", tbSN.Text);
                    cmd2.Parameters.AddWithValue("@UserID", UserID);
                    cmd2.Parameters.AddWithValue("@IssueDate", receivedDate.Value);
                    cmd2.Parameters.AddWithValue("@Description", tbDescription.Text);
                    cmd2.Parameters.AddWithValue("@Type", cbType.SelectedItem?.ToString());
                    cmd2.Parameters.AddWithValue("@Resolution", tbResolution.Text); // 預設空白，後續可更新
                    cmd2.Parameters.AddWithValue("@ResolutionDate", resolutionDate.Value); // 預設 NULL，後續可更新
                    try
                    {
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("The complaint has been successfully saved!");
                        AddComplaintAudit(tbComplaintID.Text);
                        this.Close(); // 儲存成功後關閉表單
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while storing the complaint: " + ex.Message);
                    }
                }
            }
        }

        private void AddComplaintAudit(string ComplaintID)
        {
            // 這裡可以撰寫新增投訴紀錄到審計表的程式碼
            try
            {
                CurrentUser.AddComplaint(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email
                );

                AuditHelper.Log(
                    tableName: "complaint",
                    recordId: ComplaintID,
                    action: "Add complaint",
                    userId: CurrentUser.UserID,
                    oldValues: null,
                    newValues: ComplaintID
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }

        }

        private void btClears_Click(object sender, EventArgs e)
        {
            tbResolution.Text = "";
            tbDescription.Text = "";
        }
    }
}
using _4915project;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _4915project
{
    public partial class ViewEditComplaint : Form
    {
        string oldAssignedUserID;
        string oldType;
        string oldResolutionDate;
        string oldResolution;
        string oldDescription;
        public ViewEditComplaint()
        {
            InitializeComponent();
        }

        private void ViewEditComplaint_Load(object sender, EventArgs e)
        {
            tbOrderID.ReadOnly = true;
            tbCustName.ReadOnly = true;
            tbSN.ReadOnly = true;
            receivedDate.Enabled = false;
            GetComplaintInformation();
            LoadComplaint();
            cbType.Items.AddRange(new string[] { "Damage", "Missing", "Return", "Refund" });
        }

        private void GetComplaintInformation()
        {
            string connectionString = "server=localhost;user id=root;password=;database=4915";
            string query = @"SELECT ComplaintID FROM complaint";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cmbComID.Text = reader["ComplaintID"].ToString();
                            cmbComID.Items.Add(reader["ComplaintID"].ToString());
                        }
                    }
                }
            }
        }

        private void LoadComplaint()
        {
            string connectionString = "server=localhost;user id=root;password=;database=4915";

            // 💡 修正：使用兩個 LEFT JOIN，把客戶名稱與用戶名稱一次全部撈出來
            string query = @"
            SELECT cp.*, 
                   c.Name AS CustomerName,
                   u.Name AS StaffName
            FROM complaint cp
            LEFT JOIN customer c ON cp.CustomerID = c.CustomerID
            LEFT JOIN user u ON cp.UserID = u.UserID
            WHERE cp.ComplaintID = @ComplaintID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ComplaintID", cmbComID.Text);
                    try
                    {
                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                receivedDate.Value = reader.GetDateTime("IssueDate");
                                tbOrderID.Text = reader["OrderID"].ToString();
                                tbSN.Text = reader["SerialNumber"].ToString();
                                tbDescription.Text = reader["Description"].ToString();
                                tbResolution.Text = reader["Resolution"].ToString();

                                // 🎯 1. 填入客戶名稱
                                tbCustName.Text = reader["CustomerName"]?.ToString() ?? "Unknown";

                                // 🎯 2. 處理用戶選單（ComboBox）的顯示
                                // 如果您的 cmbUserID 裡面顯示的是「用戶名稱」（例如：管理者），請用這行：
                                cmbUserID.Text = reader["StaffName"]?.ToString() ?? "Unknown";
                                cbType.Text = reader["TYPE"].ToString();

                                // 💡 備忘提示：
                                // 如果您的 cmbUserID 裡面存的是純 ID（例如：U001），且表單有先載入全部 ID，
                                // 那麼上一行應該改回安全索引對齊法：
                                // string dbUserID = reader["UserID"].ToString();
                                // cmbUserID.SelectedIndex = cmbUserID.FindStringExact(dbUserID);
                            }
                            else
                            {
                                MessageBox.Show("Complaint not found.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading complaint: " + ex.Message);
                    }
                }
            }
        }

        private void btClears_Click(object sender, EventArgs e)
        {
            tbResolution.Text = "";
            tbDescription.Text = "";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=4915";
            string query = @"UPDATE complaint 
                             SET UserID = @UserID, 
                                 TYPE = @TYPE, 
                                 ResolutionDate = @ResolutionDate, 
                                 Resolution = @Resolution, 
                                 Description = @Description
                             WHERE ComplaintID = @ComplaintID";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", cmbUserID.Text);
                    cmd.Parameters.AddWithValue("@TYPE", cbType.Text);
                    cmd.Parameters.AddWithValue("@ResolutionDate", resolutionDate.Value);
                    cmd.Parameters.AddWithValue("@Resolution", tbResolution.Text);
                    cmd.Parameters.AddWithValue("@Description", tbDescription.Text);
                    cmd.Parameters.AddWithValue("@ComplaintID", cmbComID.Text);
                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Complaint updated successfully.");
                            UpdateComplintAudit(cmbComID.Text, cmbUserID.Text, cbType.Text, resolutionDate.Value.ToString(),
                                tbResolution.Text, tbDescription.Text);
                            LoadComplaint(); // 重新載入資料以反映更新
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating complaint: " + ex.Message);
                    }
                }
            }
        }

        private void cmbComID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComplaint();
            string connectionString = "server=localhost;user id=root;password=;database=4915";
            string query = @"SELECT c.ComplaintID, u.UserID FROM complaint c, user.u";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oldAssignedUserID = reader["UserID"].ToString();
                            oldType = reader["TYPE"].ToString();
                            oldResolutionDate = reader["IssueDate"].ToString();
                            oldResolution = reader["IssueDate"].ToString();
                            oldDescription = reader["Description"].ToString();
                        }
                    }
                }
            }
        }
        private void UpdateComplintAudit(string ComplaintID, string cmbUserID,
            string cbType, string resolutionDate,
            string tbResolution, string tbDescription)
        {
            // 這裡可以撰寫新增投訴紀錄到審計表的程式碼
            try
            {
                CurrentUser.UpdateComplaint(CurrentUser.UserID,
                    CurrentUser.Username, CurrentUser.Role,
                    CurrentUser.Email
                );

                AuditHelper.Log(
                    tableName: "complaint",
                    recordId: ComplaintID,
                    action: "Update complaint",
                    userId: CurrentUser.UserID,

                    // 💡 修正 1：使用 $ 符號串接舊值，變數放在 { } 內，最乾淨
                    oldValues: $"{oldAssignedUserID}, {oldType}, {oldResolutionDate}, {oldResolution}, {oldDescription}",

                    // 💡 修正 2：新值通常要記錄控制項裡面的「實際數值/文字」（例如 .Text 或 .SelectedValue）
                    newValues: $"{ComplaintID}, {cmbUserID}, {cbType}, {resolutionDate}, {tbResolution}, {tbDescription}"
                );
            }
            catch (Exception ex)
            {
                // 日誌記錄失敗不應阻擋用戶，僅做提示
                Console.WriteLine("Audit Log failed: " + ex.Message);
            }

        }
    }
}
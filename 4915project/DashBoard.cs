using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace _4915project
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            SetupWelcomeMessage();
            SetupAuditTab();
            SetupReportTab();           // New: Report in tabPage2
        }

        private void SetupWelcomeMessage()
        {
            string displayName = string.IsNullOrWhiteSpace(CurrentUser.Username) ? "User" : CurrentUser.Username;
            string rolePart = string.IsNullOrWhiteSpace(CurrentUser.Role) ? "" : $" ({CurrentUser.Role})";
            this.lblWelcome.Text = $"Welcome, {displayName}{rolePart}!";
        }

        // ====================== TAB 1: Audit Logs ======================
        private void SetupAuditTab()
        {
            cmbTableFilter.Items.Clear();
            cmbTableFilter.Items.Add("All");
            cmbTableFilter.Items.Add("user");
            cmbTableFilter.Items.Add("complaint");
            cmbTableFilter.Items.Add("customdesign");
            cmbTableFilter.SelectedIndex = 0;

            LoadAuditLogs();
        }

        private void LoadAuditLogs(string filterTable = "All")
        {
            string constring = "server=localhost;user id=root;password=;database=4915";

            try
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            AuditLogId as 'ID',
                            ChangedDate as 'Date',
                            TableName as 'Table',
                            RecordId as 'Record ID',
                            Action as 'Action',
                            Username as 'User',
                            Description as 'Description'
                        FROM audit_log";

                    if (filterTable != "All")
                        query += " WHERE TableName = @TableName";

                    query += " ORDER BY ChangedDate DESC LIMIT 500";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (filterTable != "All")
                            cmd.Parameters.AddWithValue("@TableName", filterTable);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvAuditLogs.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading audit logs: " + ex.Message);
            }
        }

        // ====================== TAB 2: Report View ======================
        private void SetupReportTab()
        {
            // Populate Report Type ComboBox (add this in Designer: cmbReportType)
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("Audit Summary");
            cmbReportType.Items.Add("Sales Report");
            cmbReportType.Items.Add("Stock Report");
            cmbReportType.Items.Add("Shipment Report");
            cmbReportType.Items.Add("User Activity");
            cmbReportType.Items.Add("Daily Activity Report");
            cmbReportType.SelectedIndex = 0;

            LoadReport();   // Load default report
        }
        private void LoadReport()
        {
            string reportType = cmbReportType.SelectedItem?.ToString() ?? "Audit Summary";

            switch (reportType)
            {
                case "Audit Summary":
                    LoadSummaryReport();
                    break;

                case "Sales Report":
                    LoadSalesReport();
                    break;

                case "Stock Report":
                    LoadStockReport();
                    break;

                case "Shipment Report":
                    LoadShipmentReport();
                    break;

                case "User Activity":
                    LoadUserActivityReport();
                    break;

                case "Daily Activity Report":
                    LoadDailyActivityReport();
                    break;

                case "Recent Login History":
                    LoadLoginHistoryReport();
                    break;
            }
        }
        // ==================== SummaryReport ====================
        private void LoadSummaryReport()
        {
            string query = @"
        SELECT 
            TableName as 'Table Name',
            Action as 'Action',
            COUNT(*) as 'Total',
            MAX(ChangedDate) as 'Last Activity'
        FROM audit_log 
        GROUP BY TableName, Action 
        ORDER BY COUNT(*) DESC";

            LoadReportToGrid(query, "Summary Report");
        }
        // ==================== UserActivityReport ====================
        private void LoadUserActivityReport()
        {
            string query = @"
        SELECT 
            Username as 'User',
            COUNT(*) as 'Total Actions',
            MAX(ChangedDate) as 'Last Activity',
            MIN(ChangedDate) as 'First Activity'
        FROM audit_log 
        GROUP BY Username 
        ORDER BY COUNT(*) DESC";

            LoadReportToGrid(query, "User Activity Report");
        }
        // ==================== DailyActivityReport ====================
        private void LoadDailyActivityReport()
        {
            string query = @"
        SELECT 
            DATE(ChangedDate) as 'Date',
            COUNT(*) as 'Total Activities',
            COUNT(CASE WHEN Action = 'LOGIN' THEN 1 END) as 'Logins',
            COUNT(CASE WHEN Action = 'UPDATE' THEN 1 END) as 'Updates'
        FROM audit_log 
        GROUP BY DATE(ChangedDate) 
        ORDER BY Date DESC";

            LoadReportToGrid(query, "Daily Activity Report");
        }
        // ==================== LoadLoginHistoryReport ====================
        private void LoadLoginHistoryReport()
        {
            string query = @"
        SELECT 
            ChangedDate as 'Login Time',
            Username as 'User',
            IpAddress as 'IP Address',
            MachineName as 'Device'
        FROM audit_log 
        WHERE Action = 'LOGIN'
        ORDER BY ChangedDate DESC 
        LIMIT 100";

            LoadReportToGrid(query, "Recent Login History");
        }
        // ==================== SALES REPORT ====================
        private void LoadSalesReport()
        {
            string query = @"
        SELECT 
            DATE(s.OrderDate) as 'Date',
            COUNT(*) as 'Total Orders',
            SUM(s.TotalAmount) as 'Total Sales (RM)',
            AVG(s.TotalAmount) as 'Average Order Value'
        FROM salesorder s
        GROUP BY DATE(s.OrderDate)
        ORDER BY Date DESC";

            LoadReportToGrid(query, "Sales Report");
        }

        // ==================== STOCK REPORT ====================
        private void LoadStockReport()
        {
            string query = @"
        SELECT 
            r.Name as 'Material Name',
            i.QuantityOnHand as 'Current Stock',
            r.ReorderLevel as 'Minimum Stock',
            CASE 
                WHEN i.QuantityOnHand <= r.ReorderLevel THEN 'Low Stock' 
                ELSE 'OK' 
            END as 'Status'
        FROM inventory i,
            rawmaterial r
        WHERE i.MaterialID = r.MaterialID
        ORDER BY i.QuantityOnHand ASC";

            LoadReportToGrid(query, "Stock Report");
        }

        // ==================== SHIPMENT REPORT ====================
        private void LoadShipmentReport()
        {
            string query = @"
        SELECT 
        sh.ShipmentID as 'Shipment ID',
        o.EstimatedDeliveryDate as 'Shipment Date',
        o.ActualDeliveryDate as 'Actual Delivery Date',
        sh.STATUS as 'Status',
        COUNT(*) AS 'Delivered Count',
        sh.TrackingInfo as 'Tracking No'
        FROM shipment sh
        INNER JOIN salesorder o ON sh.OrderID = o.OrderID
        GROUP BY sh.ShipmentID, o.EstimatedDeliveryDate, o.ActualDeliveryDate, sh.STATUS, sh.TrackingInfo
        ORDER BY sh.ShipmentID DESC;";

            LoadReportToGrid(query, "Shipment Report");
        }
        private void LoadReportToGrid(string query, string reportTitle)
        {
            string constring = "server=localhost;user id=root;password=;database=4915";

            try
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvReport.DataSource = dt;
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading {reportTitle}:\n{ex.Message}\n\n" +
                               $"Make sure the related tables exist.",
                               "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void cmbTableFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void Logoutbt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentUser.Logout();
            this.Close();
        }
    }
}
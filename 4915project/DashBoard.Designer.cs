using Org.BouncyCastle.Security.Certificates;
using System.Xml.Linq;

namespace _4915project
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAuditLogs = new DataGridView();
            btnRefreshAudit = new Button();
            cmbTableFilter = new ComboBox();
            lblWelcome = new Label();
            DashBoardtabControl = new TabControl();
            Overview = new TabPage();
            panel2 = new Panel();
            tbCom = new TextBox();
            tbLowAlert = new TextBox();
            tbPendOrder = new TextBox();
            labelNewComplaints = new Label();
            labelLowStockAlerts = new Label();
            labelPendingOrders = new Label();
            label1 = new Label();
            Audit = new TabPage();
            Report = new TabPage();
            btnRefreshReport = new Button();
            cmbReportType = new ComboBox();
            dgvReport = new DataGridView();
            Logoutbt = new LinkLabel();
            Menu = new GroupBox();
            AfterSales = new Button();
            Production = new Button();
            SubmitDesign = new Button();
            Inventory = new Button();
            SalesOrder = new Button();
            Logistics = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
            DashBoardtabControl.SuspendLayout();
            Overview.SuspendLayout();
            panel2.SuspendLayout();
            Audit.SuspendLayout();
            Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAuditLogs
            // 
            dgvAuditLogs.AllowUserToAddRows = false;
            dgvAuditLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLogs.Location = new Point(27, 144);
            dgvAuditLogs.Margin = new Padding(5);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.ReadOnly = true;
            dgvAuditLogs.RowHeadersWidth = 62;
            dgvAuditLogs.Size = new Size(1317, 443);
            dgvAuditLogs.TabIndex = 0;
            // 
            // btnRefreshAudit
            // 
            btnRefreshAudit.Location = new Point(27, 618);
            btnRefreshAudit.Margin = new Padding(5);
            btnRefreshAudit.Name = "btnRefreshAudit";
            btnRefreshAudit.Size = new Size(299, 74);
            btnRefreshAudit.TabIndex = 1;
            btnRefreshAudit.Text = "Refresh Audit Logs";
            btnRefreshAudit.UseVisualStyleBackColor = true;
            // 
            // cmbTableFilter
            // 
            cmbTableFilter.FormattingEnabled = true;
            cmbTableFilter.Items.AddRange(new object[] { "(All)", "user", "complaint", "customdesign" });
            cmbTableFilter.Location = new Point(1103, 69);
            cmbTableFilter.Margin = new Padding(5);
            cmbTableFilter.Name = "cmbTableFilter";
            cmbTableFilter.Size = new Size(188, 31);
            cmbTableFilter.TabIndex = 2;
            cmbTableFilter.SelectedIndexChanged += cmbTableFilter_SelectedIndexChanged;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(1248, 49);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(358, 60);
            lblWelcome.TabIndex = 3;
            // 
            // DashBoardtabControl
            // 
            DashBoardtabControl.Controls.Add(Overview);
            DashBoardtabControl.Controls.Add(Audit);
            DashBoardtabControl.Controls.Add(Report);
            DashBoardtabControl.Location = new Point(256, 113);
            DashBoardtabControl.Margin = new Padding(5);
            DashBoardtabControl.Name = "DashBoardtabControl";
            DashBoardtabControl.SelectedIndex = 0;
            DashBoardtabControl.Size = new Size(1386, 771);
            DashBoardtabControl.TabIndex = 4;
            // 
            // Overview
            // 
            Overview.Controls.Add(panel2);
            Overview.Location = new Point(4, 32);
            Overview.Name = "Overview";
            Overview.Size = new Size(1378, 735);
            Overview.TabIndex = 2;
            Overview.Text = "Overview";
            Overview.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tbCom);
            panel2.Controls.Add(tbLowAlert);
            panel2.Controls.Add(tbPendOrder);
            panel2.Controls.Add(labelNewComplaints);
            panel2.Controls.Add(labelLowStockAlerts);
            panel2.Controls.Add(labelPendingOrders);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 395);
            panel2.TabIndex = 10;
            // 
            // tbCom
            // 
            tbCom.BackColor = SystemColors.ScrollBar;
            tbCom.Location = new Point(247, 199);
            tbCom.Name = "tbCom";
            tbCom.ReadOnly = true;
            tbCom.Size = new Size(56, 30);
            tbCom.TabIndex = 6;
            // 
            // tbLowAlert
            // 
            tbLowAlert.BackColor = SystemColors.ScrollBar;
            tbLowAlert.Location = new Point(247, 137);
            tbLowAlert.Name = "tbLowAlert";
            tbLowAlert.ReadOnly = true;
            tbLowAlert.Size = new Size(56, 30);
            tbLowAlert.TabIndex = 5;
            // 
            // tbPendOrder
            // 
            tbPendOrder.BackColor = SystemColors.ScrollBar;
            tbPendOrder.Location = new Point(247, 78);
            tbPendOrder.Name = "tbPendOrder";
            tbPendOrder.ReadOnly = true;
            tbPendOrder.Size = new Size(56, 30);
            tbPendOrder.TabIndex = 4;
            // 
            // labelNewComplaints
            // 
            labelNewComplaints.AutoSize = true;
            labelNewComplaints.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelNewComplaints.Location = new Point(75, 196);
            labelNewComplaints.Name = "labelNewComplaints";
            labelNewComplaints.Size = new Size(147, 30);
            labelNewComplaints.TabIndex = 3;
            labelNewComplaints.Text = "Complaints:";
            // 
            // labelLowStockAlerts
            // 
            labelLowStockAlerts.AutoSize = true;
            labelLowStockAlerts.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelLowStockAlerts.Location = new Point(35, 134);
            labelLowStockAlerts.Name = "labelLowStockAlerts";
            labelLowStockAlerts.Size = new Size(206, 30);
            labelLowStockAlerts.TabIndex = 2;
            labelLowStockAlerts.Text = "Low Stock Alerts:";
            // 
            // labelPendingOrders
            // 
            labelPendingOrders.AutoSize = true;
            labelPendingOrders.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelPendingOrders.Location = new Point(35, 78);
            labelPendingOrders.Name = "labelPendingOrders";
            labelPendingOrders.Size = new Size(197, 30);
            labelPendingOrders.TabIndex = 1;
            labelPendingOrders.Text = "Pending Orders:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(35, 11);
            label1.Name = "label1";
            label1.Size = new Size(187, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome,";
            // 
            // Audit
            // 
            Audit.Controls.Add(dgvAuditLogs);
            Audit.Controls.Add(cmbTableFilter);
            Audit.Controls.Add(btnRefreshAudit);
            Audit.Location = new Point(4, 32);
            Audit.Margin = new Padding(5);
            Audit.Name = "Audit";
            Audit.Padding = new Padding(5);
            Audit.Size = new Size(1378, 735);
            Audit.TabIndex = 0;
            Audit.Text = "Audit";
            Audit.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            Report.BackgroundImageLayout = ImageLayout.None;
            Report.Controls.Add(btnRefreshReport);
            Report.Controls.Add(cmbReportType);
            Report.Controls.Add(dgvReport);
            Report.Location = new Point(4, 32);
            Report.Margin = new Padding(5);
            Report.Name = "Report";
            Report.Padding = new Padding(5);
            Report.Size = new Size(1378, 735);
            Report.TabIndex = 1;
            Report.Text = "Report";
            Report.UseVisualStyleBackColor = true;
            // 
            // btnRefreshReport
            // 
            btnRefreshReport.Location = new Point(88, 650);
            btnRefreshReport.Margin = new Padding(5);
            btnRefreshReport.Name = "btnRefreshReport";
            btnRefreshReport.Size = new Size(181, 35);
            btnRefreshReport.TabIndex = 7;
            btnRefreshReport.Text = "Refresh Report";
            btnRefreshReport.UseVisualStyleBackColor = true;
            btnRefreshReport.Click += btnRefreshReport_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(1113, 35);
            cmbReportType.Margin = new Padding(5);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(188, 31);
            cmbReportType.TabIndex = 6;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(47, 98);
            dgvReport.Margin = new Padding(5);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(1256, 503);
            dgvReport.TabIndex = 0;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(1527, 14);
            Logoutbt.Margin = new Padding(5, 0, 5, 0);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(74, 23);
            Logoutbt.TabIndex = 5;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            Logoutbt.LinkClicked += Logoutbt_LinkClicked;
            // 
            // Menu
            // 
            Menu.Controls.Add(AfterSales);
            Menu.Controls.Add(Production);
            Menu.Controls.Add(SubmitDesign);
            Menu.Controls.Add(Inventory);
            Menu.Controls.Add(SalesOrder);
            Menu.Controls.Add(Logistics);
            Menu.Location = new Point(19, 113);
            Menu.Margin = new Padding(5);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(5);
            Menu.Size = new Size(228, 765);
            Menu.TabIndex = 6;
            Menu.TabStop = false;
            Menu.Text = "Menu";
            // 
            // AfterSales
            // 
            AfterSales.Location = new Point(35, 590);
            AfterSales.Margin = new Padding(5);
            AfterSales.Name = "AfterSales";
            AfterSales.Size = new Size(162, 80);
            AfterSales.TabIndex = 5;
            AfterSales.Text = "AfterSales";
            AfterSales.UseVisualStyleBackColor = true;
            // 
            // Production
            // 
            Production.Location = new Point(35, 366);
            Production.Margin = new Padding(5);
            Production.Name = "Production";
            Production.Size = new Size(162, 80);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
            // 
            // SubmitDesign
            // 
            SubmitDesign.Location = new Point(35, 474);
            SubmitDesign.Margin = new Padding(5);
            SubmitDesign.Name = "SubmitDesign";
            SubmitDesign.Size = new Size(162, 80);
            SubmitDesign.TabIndex = 3;
            SubmitDesign.Text = "SubmitDesign";
            SubmitDesign.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            Inventory.Location = new Point(35, 261);
            Inventory.Margin = new Padding(5);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(162, 80);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            // 
            // SalesOrder
            // 
            SalesOrder.Location = new Point(35, 172);
            SalesOrder.Margin = new Padding(5);
            SalesOrder.Name = "SalesOrder";
            SalesOrder.Size = new Size(162, 80);
            SalesOrder.TabIndex = 1;
            SalesOrder.Text = "Sales/Order";
            SalesOrder.UseVisualStyleBackColor = true;
            SalesOrder.Click += SalesOrder_Click;
            // 
            // Logistics
            // 
            Logistics.Location = new Point(13, 34);
            Logistics.Margin = new Padding(5);
            Logistics.Name = "Logistics";
            Logistics.Size = new Size(184, 104);
            Logistics.TabIndex = 0;
            Logistics.Text = "Logistics/Delivery";
            Logistics.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1692, 914);
            Controls.Add(Menu);
            Controls.Add(Logoutbt);
            Controls.Add(DashBoardtabControl);
            Controls.Add(lblWelcome);
            Margin = new Padding(5);
            Name = "DashBoard";
            Text = "DashBoard";
            Load += DashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
            DashBoardtabControl.ResumeLayout(false);
            Overview.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Audit.ResumeLayout(false);
            Report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            Menu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView dgvAuditLogs;
        private Button btnRefreshAudit;
        private ComboBox cmbTableFilter;
        private Label lblWelcome;
        private TabControl DashBoardtabControl;
        private TabPage Audit;
        private TabPage Report;
        private LinkLabel Logoutbt;
        private DataGridView dgvReport;
        private Button btnRefreshReport;
        private ComboBox cmbReportType;
        private GroupBox Menu;
        private Button AfterSales;
        private Button Production;
        private Button SubmitDesign;
        private Button Inventory;
        private Button SalesOrder;
        private Button Logistics;
        private TabPage Overview;
        private Panel panel2;
        private TextBox tbCom;
        private TextBox tbLowAlert;
        private TextBox tbPendOrder;
        private Label labelNewComplaints;
        private Label labelLowStockAlerts;
        private Label labelPendingOrders;
        private Label label1;
    }
}
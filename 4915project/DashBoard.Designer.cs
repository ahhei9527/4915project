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
            dgvAuditLogs.Location = new Point(17, 94);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.ReadOnly = true;
            dgvAuditLogs.RowHeadersWidth = 62;
            dgvAuditLogs.Size = new Size(838, 289);
            dgvAuditLogs.TabIndex = 0;
            // 
            // btnRefreshAudit
            // 
            btnRefreshAudit.Location = new Point(17, 403);
            btnRefreshAudit.Name = "btnRefreshAudit";
            btnRefreshAudit.Size = new Size(190, 48);
            btnRefreshAudit.TabIndex = 1;
            btnRefreshAudit.Text = "Refresh Audit Logs";
            btnRefreshAudit.UseVisualStyleBackColor = true;
            // 
            // cmbTableFilter
            // 
            cmbTableFilter.FormattingEnabled = true;
            cmbTableFilter.Items.AddRange(new object[] { "(All)", "user", "complaint", "customdesign" });
            cmbTableFilter.Location = new Point(702, 45);
            cmbTableFilter.Name = "cmbTableFilter";
            cmbTableFilter.Size = new Size(121, 23);
            cmbTableFilter.TabIndex = 2;
            cmbTableFilter.SelectedIndexChanged += cmbTableFilter_SelectedIndexChanged;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(794, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(228, 39);
            lblWelcome.TabIndex = 3;
            // 
            // DashBoardtabControl
            // 
            DashBoardtabControl.Controls.Add(Overview);
            DashBoardtabControl.Controls.Add(Audit);
            DashBoardtabControl.Controls.Add(Report);
            DashBoardtabControl.Location = new Point(163, 74);
            DashBoardtabControl.Name = "DashBoardtabControl";
            DashBoardtabControl.SelectedIndex = 0;
            DashBoardtabControl.Size = new Size(882, 503);
            DashBoardtabControl.TabIndex = 4;
            // 
            // Overview
            // 
            Overview.Controls.Add(panel2);
            Overview.Location = new Point(4, 24);
            Overview.Margin = new Padding(2);
            Overview.Name = "Overview";
            Overview.Size = new Size(874, 475);
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
            panel2.Location = new Point(10, 12);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 258);
            panel2.TabIndex = 10;
            // 
            // tbCom
            // 
            tbCom.BackColor = SystemColors.ScrollBar;
            tbCom.Location = new Point(157, 130);
            tbCom.Margin = new Padding(2);
            tbCom.Name = "tbCom";
            tbCom.ReadOnly = true;
            tbCom.Size = new Size(37, 23);
            tbCom.TabIndex = 6;
            // 
            // tbLowAlert
            // 
            tbLowAlert.BackColor = SystemColors.ScrollBar;
            tbLowAlert.Location = new Point(157, 89);
            tbLowAlert.Margin = new Padding(2);
            tbLowAlert.Name = "tbLowAlert";
            tbLowAlert.ReadOnly = true;
            tbLowAlert.Size = new Size(37, 23);
            tbLowAlert.TabIndex = 5;
            // 
            // tbPendOrder
            // 
            tbPendOrder.BackColor = SystemColors.ScrollBar;
            tbPendOrder.Location = new Point(157, 51);
            tbPendOrder.Margin = new Padding(2);
            tbPendOrder.Name = "tbPendOrder";
            tbPendOrder.ReadOnly = true;
            tbPendOrder.Size = new Size(37, 23);
            tbPendOrder.TabIndex = 4;
            // 
            // labelNewComplaints
            // 
            labelNewComplaints.AutoSize = true;
            labelNewComplaints.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelNewComplaints.Location = new Point(48, 128);
            labelNewComplaints.Margin = new Padding(2, 0, 2, 0);
            labelNewComplaints.Name = "labelNewComplaints";
            labelNewComplaints.Size = new Size(99, 20);
            labelNewComplaints.TabIndex = 3;
            labelNewComplaints.Text = "Complaints:";
            // 
            // labelLowStockAlerts
            // 
            labelLowStockAlerts.AutoSize = true;
            labelLowStockAlerts.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelLowStockAlerts.Location = new Point(22, 87);
            labelLowStockAlerts.Margin = new Padding(2, 0, 2, 0);
            labelLowStockAlerts.Name = "labelLowStockAlerts";
            labelLowStockAlerts.Size = new Size(136, 20);
            labelLowStockAlerts.TabIndex = 2;
            labelLowStockAlerts.Text = "Low Stock Alerts:";
            // 
            // labelPendingOrders
            // 
            labelPendingOrders.AutoSize = true;
            labelPendingOrders.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelPendingOrders.Location = new Point(22, 51);
            labelPendingOrders.Margin = new Padding(2, 0, 2, 0);
            labelPendingOrders.Name = "labelPendingOrders";
            labelPendingOrders.Size = new Size(131, 20);
            labelPendingOrders.TabIndex = 1;
            labelPendingOrders.Text = "Pending Orders:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(22, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 0;
            label1.Text = "Welcome,";
            // 
            // Audit
            // 
            Audit.Controls.Add(dgvAuditLogs);
            Audit.Controls.Add(cmbTableFilter);
            Audit.Controls.Add(btnRefreshAudit);
            Audit.Location = new Point(4, 24);
            Audit.Name = "Audit";
            Audit.Padding = new Padding(3);
            Audit.Size = new Size(874, 475);
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
            Report.Location = new Point(4, 24);
            Report.Name = "Report";
            Report.Padding = new Padding(3);
            Report.Size = new Size(874, 475);
            Report.TabIndex = 1;
            Report.Text = "Report";
            Report.UseVisualStyleBackColor = true;
            // 
            // btnRefreshReport
            // 
            btnRefreshReport.Location = new Point(56, 424);
            btnRefreshReport.Name = "btnRefreshReport";
            btnRefreshReport.Size = new Size(115, 23);
            btnRefreshReport.TabIndex = 7;
            btnRefreshReport.Text = "Refresh Report";
            btnRefreshReport.UseVisualStyleBackColor = true;
            btnRefreshReport.Click += btnRefreshReport_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(708, 23);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(121, 23);
            cmbReportType.TabIndex = 6;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(30, 64);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(799, 328);
            dgvReport.TabIndex = 0;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(972, 9);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(50, 15);
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
            Menu.Location = new Point(12, 74);
            Menu.Name = "Menu";
            Menu.Size = new Size(145, 499);
            Menu.TabIndex = 6;
            Menu.TabStop = false;
            Menu.Text = "Menu";
            // 
            // AfterSales
            // 
            AfterSales.Location = new Point(22, 385);
            AfterSales.Name = "AfterSales";
            AfterSales.Size = new Size(103, 52);
            AfterSales.TabIndex = 5;
            AfterSales.Text = "AfterSales";
            AfterSales.UseVisualStyleBackColor = true;
            // 
            // Production
            // 
            Production.Location = new Point(22, 239);
            Production.Name = "Production";
            Production.Size = new Size(103, 52);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
            // 
            // SubmitDesign
            // 
            SubmitDesign.Location = new Point(22, 309);
            SubmitDesign.Name = "SubmitDesign";
            SubmitDesign.Size = new Size(103, 52);
            SubmitDesign.TabIndex = 3;
            SubmitDesign.Text = "SubmitDesign";
            SubmitDesign.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            Inventory.Location = new Point(22, 181);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(103, 52);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // SalesOrder
            // 
            SalesOrder.Location = new Point(22, 24);
            SalesOrder.Name = "SalesOrder";
            SalesOrder.Size = new Size(103, 52);
            SalesOrder.TabIndex = 1;
            SalesOrder.Text = "Sales/Order";
            SalesOrder.UseVisualStyleBackColor = true;
            SalesOrder.Click += SalesOrder_Click;
            // 
            // Logistics
            // 
            Logistics.Location = new Point(22, 101);
            Logistics.Name = "Logistics";
            Logistics.Size = new Size(117, 68);
            Logistics.TabIndex = 0;
            Logistics.Text = "Logistics/Delivery";
            Logistics.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 596);
            Controls.Add(Menu);
            Controls.Add(Logoutbt);
            Controls.Add(DashBoardtabControl);
            Controls.Add(lblWelcome);
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
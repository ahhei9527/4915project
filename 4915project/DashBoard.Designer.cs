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
            label2 = new Label();
            btnRefreshReport = new Button();
            cmbReportType = new ComboBox();
            dgvReport = new DataGridView();
            Logoutbt = new LinkLabel();
            Menu = new GroupBox();
            btRawMaterial = new Button();
            btSetting = new Button();
            AfterSales = new Button();
            Production = new Button();
            Inventory = new Button();
            SalesOrder = new Button();
            Logistics = new Button();
            LTitle = new Label();
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
            dgvAuditLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLogs.Location = new Point(20, 18);
            dgvAuditLogs.Margin = new Padding(5);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.ReadOnly = true;
            dgvAuditLogs.RowHeadersWidth = 62;
            dgvAuditLogs.Size = new Size(1010, 581);
            dgvAuditLogs.TabIndex = 0;
            // 
            // btnRefreshAudit
            // 
            btnRefreshAudit.Location = new Point(20, 609);
            btnRefreshAudit.Margin = new Padding(5);
            btnRefreshAudit.Name = "btnRefreshAudit";
            btnRefreshAudit.Size = new Size(296, 40);
            btnRefreshAudit.TabIndex = 1;
            btnRefreshAudit.Text = "Refresh Audit Logs";
            btnRefreshAudit.UseVisualStyleBackColor = true;
            btnRefreshAudit.Click += btnRefreshAudit_Click;
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
            lblWelcome.Location = new Point(808, 9);
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
            DashBoardtabControl.Location = new Point(256, 98);
            DashBoardtabControl.Margin = new Padding(5);
            DashBoardtabControl.Name = "DashBoardtabControl";
            DashBoardtabControl.SelectedIndex = 0;
            DashBoardtabControl.Size = new Size(1062, 711);
            DashBoardtabControl.TabIndex = 4;
            // 
            // Overview
            // 
            Overview.BorderStyle = BorderStyle.FixedSingle;
            Overview.Controls.Add(panel2);
            Overview.Location = new Point(4, 32);
            Overview.Name = "Overview";
            Overview.Size = new Size(1054, 675);
            Overview.TabIndex = 2;
            Overview.Text = "Overview";
            Overview.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tbCom);
            panel2.Controls.Add(tbLowAlert);
            panel2.Controls.Add(tbPendOrder);
            panel2.Controls.Add(labelNewComplaints);
            panel2.Controls.Add(labelLowStockAlerts);
            panel2.Controls.Add(labelPendingOrders);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(20, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 582);
            panel2.TabIndex = 10;
            // 
            // tbCom
            // 
            tbCom.BackColor = SystemColors.ScrollBar;
            tbCom.Location = new Point(247, 199);
            tbCom.Name = "tbCom";
            tbCom.ReadOnly = true;
            tbCom.Size = new Size(72, 30);
            tbCom.TabIndex = 6;
            // 
            // tbLowAlert
            // 
            tbLowAlert.BackColor = SystemColors.ScrollBar;
            tbLowAlert.Location = new Point(247, 136);
            tbLowAlert.Name = "tbLowAlert";
            tbLowAlert.ReadOnly = true;
            tbLowAlert.Size = new Size(72, 30);
            tbLowAlert.TabIndex = 5;
            // 
            // tbPendOrder
            // 
            tbPendOrder.BackColor = SystemColors.ScrollBar;
            tbPendOrder.Location = new Point(247, 78);
            tbPendOrder.Name = "tbPendOrder";
            tbPendOrder.ReadOnly = true;
            tbPendOrder.Size = new Size(72, 30);
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
            labelLowStockAlerts.Location = new Point(35, 133);
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
            Audit.BorderStyle = BorderStyle.FixedSingle;
            Audit.Controls.Add(dgvAuditLogs);
            Audit.Controls.Add(cmbTableFilter);
            Audit.Controls.Add(btnRefreshAudit);
            Audit.Location = new Point(4, 32);
            Audit.Margin = new Padding(5);
            Audit.Name = "Audit";
            Audit.Padding = new Padding(5);
            Audit.Size = new Size(1054, 675);
            Audit.TabIndex = 0;
            Audit.Text = "Audit";
            Audit.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            Report.BackgroundImageLayout = ImageLayout.None;
            Report.BorderStyle = BorderStyle.FixedSingle;
            Report.Controls.Add(label2);
            Report.Controls.Add(btnRefreshReport);
            Report.Controls.Add(cmbReportType);
            Report.Controls.Add(dgvReport);
            Report.Location = new Point(4, 32);
            Report.Margin = new Padding(5);
            Report.Name = "Report";
            Report.Padding = new Padding(5);
            Report.Size = new Size(1054, 675);
            Report.TabIndex = 1;
            Report.Text = "Report";
            Report.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(709, 9);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 9;
            label2.Text = "Select Report";
            // 
            // btnRefreshReport
            // 
            btnRefreshReport.Location = new Point(809, 623);
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
            cmbReportType.Location = new Point(841, 6);
            cmbReportType.Margin = new Padding(5);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(188, 31);
            cmbReportType.TabIndex = 6;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // dgvReport
            // 
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(20, 51);
            dgvReport.Margin = new Padding(5);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(1010, 549);
            dgvReport.TabIndex = 0;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(1175, 21);
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
            Menu.Controls.Add(btRawMaterial);
            Menu.Controls.Add(btSetting);
            Menu.Controls.Add(AfterSales);
            Menu.Controls.Add(Production);
            Menu.Controls.Add(Inventory);
            Menu.Controls.Add(SalesOrder);
            Menu.Controls.Add(Logistics);
            Menu.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Menu.Location = new Point(20, 94);
            Menu.Margin = new Padding(5);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(5);
            Menu.Size = new Size(228, 600);
            Menu.TabIndex = 6;
            Menu.TabStop = false;
            Menu.Text = "Home";
            // 
            // btRawMaterial
            // 
            btRawMaterial.Font = new Font("Microsoft JhengHei UI", 10F);
            btRawMaterial.Location = new Point(20, 345);
            btRawMaterial.Margin = new Padding(5);
            btRawMaterial.Name = "btRawMaterial";
            btRawMaterial.Size = new Size(184, 52);
            btRawMaterial.TabIndex = 13;
            btRawMaterial.Text = "Raw Material";
            btRawMaterial.UseVisualStyleBackColor = true;
            btRawMaterial.Click += btRawMaterial_Click;
            // 
            // btSetting
            // 
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F);
            btSetting.Location = new Point(24, 512);
            btSetting.Margin = new Padding(5);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(184, 48);
            btSetting.TabIndex = 6;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // AfterSales
            // 
            AfterSales.Font = new Font("Microsoft JhengHei UI", 10F);
            AfterSales.Location = new Point(20, 429);
            AfterSales.Margin = new Padding(5);
            AfterSales.Name = "AfterSales";
            AfterSales.Size = new Size(184, 48);
            AfterSales.TabIndex = 5;
            AfterSales.Text = "AfterSales";
            AfterSales.UseVisualStyleBackColor = true;
            AfterSales.Click += AfterSales_Click;
            // 
            // Production
            // 
            Production.Font = new Font("Microsoft JhengHei UI", 10F);
            Production.Location = new Point(24, 267);
            Production.Margin = new Padding(5);
            Production.Name = "Production";
            Production.Size = new Size(184, 48);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
            Production.Click += Production_Click;
            // 
            // Inventory
            // 
            Inventory.Font = new Font("Microsoft JhengHei UI", 10F);
            Inventory.Location = new Point(24, 189);
            Inventory.Margin = new Padding(5);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(184, 48);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // SalesOrder
            // 
            SalesOrder.Font = new Font("Microsoft JhengHei UI", 10F);
            SalesOrder.Location = new Point(24, 46);
            SalesOrder.Margin = new Padding(5);
            SalesOrder.Name = "SalesOrder";
            SalesOrder.Size = new Size(184, 48);
            SalesOrder.TabIndex = 1;
            SalesOrder.Text = "Sales/Order";
            SalesOrder.UseVisualStyleBackColor = true;
            SalesOrder.Click += SalesOrder_Click;
            // 
            // Logistics
            // 
            Logistics.Font = new Font("Microsoft JhengHei UI", 10F);
            Logistics.Location = new Point(24, 113);
            Logistics.Margin = new Padding(5);
            Logistics.Name = "Logistics";
            Logistics.Size = new Size(184, 48);
            Logistics.TabIndex = 0;
            Logistics.Text = "Logistics/Delivery";
            Logistics.UseVisualStyleBackColor = true;
            Logistics.Click += Logistics_Click;
            // 
            // LTitle
            // 
            LTitle.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            LTitle.Location = new Point(41, 21);
            LTitle.Margin = new Padding(5, 0, 5, 0);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(592, 35);
            LTitle.TabIndex = 7;
            LTitle.Text = "Premium Living Centralized Manage System";
            LTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 825);
            Controls.Add(LTitle);
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
            Report.PerformLayout();
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
        private Button btnRefreshReport;
        private ComboBox cmbReportType;
        private GroupBox Menu;
        private Button AfterSales;
        private Button Production;
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
        private Button btSetting;
        private Label LTitle;
        private DataGridView dgvReport;
        private Label label2;
        private Button btRawMaterial;
    }
}

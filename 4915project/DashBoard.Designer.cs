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
            comboBox1 = new ComboBox();
            btnRefreshReport = new Button();
            cmbReportType = new ComboBox();
            dgvReport = new DataGridView();
            Logoutbt = new LinkLabel();
            Menu = new GroupBox();
            btSetting = new Button();
            AfterSales = new Button();
            Production = new Button();
            Inventory = new Button();
            SalesOrder = new Button();
            Logistics = new Button();
            LTitle = new Label();
            btRawMaterial = new Button();
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
            dgvAuditLogs.Location = new Point(13, 12);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.ReadOnly = true;
            dgvAuditLogs.RowHeadersWidth = 62;
            dgvAuditLogs.Size = new Size(643, 379);
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
            btnRefreshAudit.Click += btnRefreshAudit_Click;
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
            lblWelcome.Location = new Point(514, 6);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(228, 39);
            lblWelcome.TabIndex = 3;
            // 
            // DashBoardtabControl
            // 
            DashBoardtabControl.Controls.Add(Overview);
            DashBoardtabControl.Controls.Add(Audit);
            DashBoardtabControl.Controls.Add(Report);
            DashBoardtabControl.Location = new Point(163, 64);
            DashBoardtabControl.Name = "DashBoardtabControl";
            DashBoardtabControl.SelectedIndex = 0;
            DashBoardtabControl.Size = new Size(676, 430);
            DashBoardtabControl.TabIndex = 4;
            // 
            // Overview
            // 
            Overview.BorderStyle = BorderStyle.FixedSingle;
            Overview.Controls.Add(panel2);
            Overview.Location = new Point(4, 24);
            Overview.Margin = new Padding(2, 2, 2, 2);
            Overview.Name = "Overview";
            Overview.Size = new Size(668, 402);
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
            panel2.Location = new Point(13, 12);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 380);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // tbCom
            // 
            tbCom.BackColor = SystemColors.ScrollBar;
            tbCom.Location = new Point(157, 130);
            tbCom.Margin = new Padding(2, 2, 2, 2);
            tbCom.Name = "tbCom";
            tbCom.ReadOnly = true;
            tbCom.Size = new Size(47, 23);
            tbCom.TabIndex = 6;
            // 
            // tbLowAlert
            // 
            tbLowAlert.BackColor = SystemColors.ScrollBar;
            tbLowAlert.Location = new Point(157, 89);
            tbLowAlert.Margin = new Padding(2, 2, 2, 2);
            tbLowAlert.Name = "tbLowAlert";
            tbLowAlert.ReadOnly = true;
            tbLowAlert.Size = new Size(47, 23);
            tbLowAlert.TabIndex = 5;
            // 
            // tbPendOrder
            // 
            tbPendOrder.BackColor = SystemColors.ScrollBar;
            tbPendOrder.Location = new Point(157, 51);
            tbPendOrder.Margin = new Padding(2, 2, 2, 2);
            tbPendOrder.Name = "tbPendOrder";
            tbPendOrder.ReadOnly = true;
            tbPendOrder.Size = new Size(47, 23);
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
            Audit.BorderStyle = BorderStyle.FixedSingle;
            Audit.Controls.Add(dgvAuditLogs);
            Audit.Controls.Add(cmbTableFilter);
            Audit.Controls.Add(btnRefreshAudit);
            Audit.Location = new Point(4, 24);
            Audit.Name = "Audit";
            Audit.Padding = new Padding(3, 3, 3, 3);
            Audit.Size = new Size(668, 402);
            Audit.TabIndex = 0;
            Audit.Text = "Audit";
            Audit.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            Report.BackgroundImageLayout = ImageLayout.None;
            Report.BorderStyle = BorderStyle.FixedSingle;
            Report.Controls.Add(label2);
            Report.Controls.Add(comboBox1);
            Report.Controls.Add(btnRefreshReport);
            Report.Controls.Add(cmbReportType);
            Report.Controls.Add(dgvReport);
            Report.Location = new Point(4, 24);
            Report.Name = "Report";
            Report.Padding = new Padding(3, 3, 3, 3);
            Report.Size = new Size(668, 402);
            Report.TabIndex = 1;
            Report.Text = "Report";
            Report.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 9;
            label2.Text = "Select Report";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(540, 5);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 23);
            comboBox1.TabIndex = 8;
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
            dgvReport.Location = new Point(13, 33);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(643, 358);
            dgvReport.TabIndex = 0;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(748, 14);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(50, 15);
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
            Menu.Location = new Point(13, 61);
            Menu.Name = "Menu";
            Menu.Size = new Size(145, 391);
            Menu.TabIndex = 6;
            Menu.TabStop = false;
            Menu.Text = "Home";
            Menu.Enter += Menu_Enter;
            // 
            // btSetting
            // 
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F);
            btSetting.Location = new Point(15, 334);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(117, 31);
            btSetting.TabIndex = 6;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // AfterSales
            // 
            AfterSales.Font = new Font("Microsoft JhengHei UI", 10F);
            AfterSales.Location = new Point(13, 280);
            AfterSales.Name = "AfterSales";
            AfterSales.Size = new Size(117, 31);
            AfterSales.TabIndex = 5;
            AfterSales.Text = "AfterSales";
            AfterSales.UseVisualStyleBackColor = true;
            AfterSales.Click += AfterSales_Click;
            // 
            // Production
            // 
            Production.Font = new Font("Microsoft JhengHei UI", 10F);
            Production.Location = new Point(15, 174);
            Production.Name = "Production";
            Production.Size = new Size(117, 31);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
            Production.Click += Production_Click;
            // 
            // Inventory
            // 
            Inventory.Font = new Font("Microsoft JhengHei UI", 10F);
            Inventory.Location = new Point(15, 123);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(117, 31);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // SalesOrder
            // 
            SalesOrder.Font = new Font("Microsoft JhengHei UI", 10F);
            SalesOrder.Location = new Point(15, 30);
            SalesOrder.Name = "SalesOrder";
            SalesOrder.Size = new Size(117, 31);
            SalesOrder.TabIndex = 1;
            SalesOrder.Text = "Sales/Order";
            SalesOrder.UseVisualStyleBackColor = true;
            SalesOrder.Click += SalesOrder_Click;
            // 
            // Logistics
            // 
            Logistics.Font = new Font("Microsoft JhengHei UI", 10F);
            Logistics.Location = new Point(15, 74);
            Logistics.Name = "Logistics";
            Logistics.Size = new Size(117, 31);
            Logistics.TabIndex = 0;
            Logistics.Text = "Logistics/Delivery";
            Logistics.UseVisualStyleBackColor = true;
            Logistics.Click += Logistics_Click;
            // 
            // LTitle
            // 
            LTitle.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            LTitle.Location = new Point(26, 14);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(377, 23);
            LTitle.TabIndex = 7;
            LTitle.Text = "Premium Living Centralized Manage System";
            LTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btRawMaterial
            // 
            btRawMaterial.Location = new Point(13, 225);
            btRawMaterial.Name = "btRawMaterial";
            btRawMaterial.Size = new Size(117, 34);
            btRawMaterial.TabIndex = 13;
            btRawMaterial.Text = "Raw Material";
            btRawMaterial.UseVisualStyleBackColor = true;
            btRawMaterial.Click += btRawMaterial_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 561);
            Controls.Add(LTitle);
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
        private ComboBox comboBox1;
        private Label label2;
        private Button btRawMaterial;
    }
}

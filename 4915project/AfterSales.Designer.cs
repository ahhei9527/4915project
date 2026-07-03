namespace _4915project
{
    partial class AfterSales
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
            label1SystemName = new Label();
            tabAfterSales = new TabControl();
            tabPageShipConfirmation = new TabPage();
            panel1 = new Panel();
            btSave = new Button();
            btClear = new Button();
            btRefresh = new Button();
            dataGridView2 = new DataGridView();
            lblNote = new Label();
            lblCustConfir = new Label();
            lblCondit = new Label();
            cmbCustConfirm = new ComboBox();
            lblName = new Label();
            date = new DateTimePicker();
            lblDate = new Label();
            lblShipID = new Label();
            cmbCondit = new ComboBox();
            tbReceiverName = new TextBox();
            tbNote = new TextBox();
            tbShipID = new TextBox();
            cmbConID = new ComboBox();
            lblComID = new Label();
            tabPageComplaint = new TabPage();
            panel3 = new Panel();
            EDate = new DateTimePicker();
            SDate = new DateTimePicker();
            btRefreshComplaint = new Button();
            btViewComplaint = new Button();
            btNewComplaint = new Button();
            dataGridView1 = new DataGridView();
            btCLears = new Button();
            btSearch = new Button();
            label21 = new Label();
            label20 = new Label();
            cmbUser = new ComboBox();
            label19 = new Label();
            cmbType = new ComboBox();
            label18 = new Label();
            tbCustomer = new TextBox();
            label17 = new Label();
            tbOrderID = new TextBox();
            label16 = new Label();
            tbComplainID = new TextBox();
            label15 = new Label();
            lblSearch = new Label();
            gbMenu = new GroupBox();
            btRawMaterial = new Button();
            btSetting = new Button();
            btLog = new Button();
            Production = new Button();
            btDashBoard = new Button();
            btSales = new Button();
            Inventory = new Button();
            Logoutbt = new LinkLabel();
            lblWelcome = new Label();
            tabAfterSales.SuspendLayout();
            tabPageShipConfirmation.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPageComplaint.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1SystemName
            // 
            label1SystemName.AutoSize = true;
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(20, 21);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(592, 36);
            label1SystemName.TabIndex = 3;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            label1SystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabAfterSales
            // 
            tabAfterSales.Controls.Add(tabPageShipConfirmation);
            tabAfterSales.Controls.Add(tabPageComplaint);
            tabAfterSales.Location = new Point(266, 97);
            tabAfterSales.Margin = new Padding(5);
            tabAfterSales.Name = "tabAfterSales";
            tabAfterSales.SelectedIndex = 0;
            tabAfterSales.Size = new Size(1062, 659);
            tabAfterSales.TabIndex = 7;
            // 
            // tabPageShipConfirmation
            // 
            tabPageShipConfirmation.AllowDrop = true;
            tabPageShipConfirmation.BorderStyle = BorderStyle.FixedSingle;
            tabPageShipConfirmation.Controls.Add(panel1);
            tabPageShipConfirmation.Location = new Point(4, 32);
            tabPageShipConfirmation.Margin = new Padding(5);
            tabPageShipConfirmation.Name = "tabPageShipConfirmation";
            tabPageShipConfirmation.Padding = new Padding(5);
            tabPageShipConfirmation.Size = new Size(1054, 623);
            tabPageShipConfirmation.TabIndex = 1;
            tabPageShipConfirmation.Text = "Shipment Confirmation";
            tabPageShipConfirmation.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btSave);
            panel1.Controls.Add(btClear);
            panel1.Controls.Add(btRefresh);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(lblNote);
            panel1.Controls.Add(lblCustConfir);
            panel1.Controls.Add(lblCondit);
            panel1.Controls.Add(cmbCustConfirm);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(date);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblShipID);
            panel1.Controls.Add(cmbCondit);
            panel1.Controls.Add(tbReceiverName);
            panel1.Controls.Add(tbNote);
            panel1.Controls.Add(tbShipID);
            panel1.Controls.Add(cmbConID);
            panel1.Controls.Add(lblComID);
            panel1.Location = new Point(8, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 605);
            panel1.TabIndex = 20;
            // 
            // btSave
            // 
            btSave.Location = new Point(641, 563);
            btSave.Margin = new Padding(5);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 35);
            btSave.TabIndex = 37;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(786, 563);
            btClear.Margin = new Padding(5);
            btClear.Name = "btClear";
            btClear.Size = new Size(118, 35);
            btClear.TabIndex = 36;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btRefresh
            // 
            btRefresh.Location = new Point(190, 563);
            btRefresh.Margin = new Padding(5);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(118, 35);
            btRefresh.TabIndex = 35;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 264);
            dataGridView2.Margin = new Padding(5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(995, 288);
            dataGridView2.TabIndex = 34;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(85, 188);
            lblNote.Margin = new Padding(5, 0, 5, 0);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(62, 23);
            lblNote.TabIndex = 33;
            lblNote.Text = "Note: ";
            // 
            // lblCustConfir
            // 
            lblCustConfir.AutoSize = true;
            lblCustConfir.Location = new Point(484, 127);
            lblCustConfir.Margin = new Padding(5, 0, 5, 0);
            lblCustConfir.Name = "lblCustConfir";
            lblCustConfir.Size = new Size(215, 23);
            lblCustConfir.TabIndex = 32;
            lblCustConfir.Text = "Customer Confirmation:";
            // 
            // lblCondit
            // 
            lblCondit.AutoSize = true;
            lblCondit.Location = new Point(112, 130);
            lblCondit.Margin = new Padding(5, 0, 5, 0);
            lblCondit.Name = "lblCondit";
            lblCondit.Size = new Size(157, 23);
            lblCondit.TabIndex = 31;
            lblCondit.Text = "Item Conditione: ";
            // 
            // cmbCustConfirm
            // 
            cmbCustConfirm.FormattingEnabled = true;
            cmbCustConfirm.Location = new Point(698, 123);
            cmbCustConfirm.Margin = new Padding(5);
            cmbCustConfirm.Name = "cmbCustConfirm";
            cmbCustConfirm.Size = new Size(188, 31);
            cmbCustConfirm.TabIndex = 30;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(121, 81);
            lblName.Margin = new Padding(5, 0, 5, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(148, 23);
            lblName.TabIndex = 29;
            lblName.Text = "Receiver Name: ";
            // 
            // date
            // 
            date.Location = new Point(695, 81);
            date.Margin = new Padding(5);
            date.Name = "date";
            date.Size = new Size(188, 30);
            date.TabIndex = 28;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(563, 81);
            lblDate.Margin = new Padding(5, 0, 5, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(136, 23);
            lblDate.TabIndex = 27;
            lblDate.Text = "Received Date:";
            // 
            // lblShipID
            // 
            lblShipID.AutoSize = true;
            lblShipID.Location = new Point(585, 34);
            lblShipID.Margin = new Padding(5, 0, 5, 0);
            lblShipID.Name = "lblShipID";
            lblShipID.Size = new Size(115, 23);
            lblShipID.TabIndex = 26;
            lblShipID.Text = "ShipmentID:";
            // 
            // cmbCondit
            // 
            cmbCondit.FormattingEnabled = true;
            cmbCondit.Location = new Point(269, 127);
            cmbCondit.Margin = new Padding(5);
            cmbCondit.Name = "cmbCondit";
            cmbCondit.Size = new Size(188, 31);
            cmbCondit.TabIndex = 25;
            // 
            // tbReceiverName
            // 
            tbReceiverName.Location = new Point(269, 78);
            tbReceiverName.Margin = new Padding(5);
            tbReceiverName.Name = "tbReceiverName";
            tbReceiverName.Size = new Size(188, 30);
            tbReceiverName.TabIndex = 24;
            // 
            // tbNote
            // 
            tbNote.Location = new Point(157, 188);
            tbNote.Margin = new Padding(5);
            tbNote.Multiline = true;
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(771, 48);
            tbNote.TabIndex = 23;
            // 
            // tbShipID
            // 
            tbShipID.Location = new Point(698, 32);
            tbShipID.Margin = new Padding(5);
            tbShipID.Name = "tbShipID";
            tbShipID.Size = new Size(188, 30);
            tbShipID.TabIndex = 22;
            // 
            // cmbConID
            // 
            cmbConID.FormattingEnabled = true;
            cmbConID.Location = new Point(269, 31);
            cmbConID.Margin = new Padding(5);
            cmbConID.Name = "cmbConID";
            cmbConID.Size = new Size(188, 31);
            cmbConID.TabIndex = 21;
            cmbConID.SelectedIndexChanged += cmbConID_SelectedIndexChanged;
            // 
            // lblComID
            // 
            lblComID.AutoSize = true;
            lblComID.Location = new Point(121, 34);
            lblComID.Margin = new Padding(5, 0, 5, 0);
            lblComID.Name = "lblComID";
            lblComID.Size = new Size(151, 23);
            lblComID.TabIndex = 20;
            lblComID.Text = "ConfirmationID: ";
            // 
            // tabPageComplaint
            // 
            tabPageComplaint.BorderStyle = BorderStyle.FixedSingle;
            tabPageComplaint.Controls.Add(panel3);
            tabPageComplaint.Location = new Point(4, 32);
            tabPageComplaint.Margin = new Padding(5);
            tabPageComplaint.Name = "tabPageComplaint";
            tabPageComplaint.Padding = new Padding(5);
            tabPageComplaint.Size = new Size(1054, 623);
            tabPageComplaint.TabIndex = 0;
            tabPageComplaint.Text = "Complaint";
            tabPageComplaint.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(EDate);
            panel3.Controls.Add(SDate);
            panel3.Controls.Add(btRefreshComplaint);
            panel3.Controls.Add(btViewComplaint);
            panel3.Controls.Add(btNewComplaint);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(btCLears);
            panel3.Controls.Add(btSearch);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(cmbUser);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(cmbType);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(tbCustomer);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(tbOrderID);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(tbComplainID);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(lblSearch);
            panel3.Location = new Point(8, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(1036, 605);
            panel3.TabIndex = 1;
            // 
            // EDate
            // 
            EDate.Location = new Point(453, 178);
            EDate.Margin = new Padding(5);
            EDate.Name = "EDate";
            EDate.Size = new Size(191, 30);
            EDate.TabIndex = 22;
            // 
            // SDate
            // 
            SDate.Location = new Point(148, 178);
            SDate.Margin = new Padding(5);
            SDate.Name = "SDate";
            SDate.Size = new Size(196, 30);
            SDate.TabIndex = 21;
            // 
            // btRefreshComplaint
            // 
            btRefreshComplaint.Location = new Point(190, 563);
            btRefreshComplaint.Name = "btRefreshComplaint";
            btRefreshComplaint.Size = new Size(118, 35);
            btRefreshComplaint.TabIndex = 20;
            btRefreshComplaint.Text = "Refresh";
            btRefreshComplaint.UseVisualStyleBackColor = true;
            btRefreshComplaint.Click += btRefreshComplaint_Click;
            // 
            // btViewComplaint
            // 
            btViewComplaint.Location = new Point(786, 563);
            btViewComplaint.Name = "btViewComplaint";
            btViewComplaint.Size = new Size(135, 34);
            btViewComplaint.TabIndex = 19;
            btViewComplaint.Text = "View / Edit";
            btViewComplaint.UseVisualStyleBackColor = true;
            btViewComplaint.Click += btViewComplaint_Click;
            // 
            // btNewComplaint
            // 
            btNewComplaint.Location = new Point(588, 563);
            btNewComplaint.Name = "btNewComplaint";
            btNewComplaint.Size = new Size(174, 34);
            btNewComplaint.TabIndex = 18;
            btNewComplaint.Text = "New Complaint";
            btNewComplaint.UseVisualStyleBackColor = true;
            btNewComplaint.Click += btNewComplaint_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(995, 288);
            dataGridView1.TabIndex = 17;
            // 
            // btCLears
            // 
            btCLears.Location = new Point(841, 224);
            btCLears.Name = "btCLears";
            btCLears.Size = new Size(112, 34);
            btCLears.TabIndex = 7;
            btCLears.Text = "Clear";
            btCLears.UseVisualStyleBackColor = true;
            btCLears.Click += btCLears_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(707, 224);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(112, 34);
            btSearch.TabIndex = 8;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(380, 187);
            label21.Name = "label21";
            label21.Size = new Size(40, 23);
            label21.TabIndex = 15;
            label21.Text = "To: ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(28, 186);
            label20.Name = "label20";
            label20.Size = new Size(109, 23);
            label20.TabIndex = 13;
            label20.Text = "Date From: ";
            // 
            // cmbUser
            // 
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(145, 121);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(199, 31);
            cmbUser.TabIndex = 12;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(17, 124);
            label19.Name = "label19";
            label19.Size = new Size(121, 23);
            label19.TabIndex = 11;
            label19.Text = "Assigned To: ";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(453, 121);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(199, 31);
            cmbType.TabIndex = 10;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(380, 124);
            label18.Name = "label18";
            label18.Size = new Size(59, 23);
            label18.TabIndex = 9;
            label18.Text = "Type: ";
            // 
            // tbCustomer
            // 
            tbCustomer.Location = new Point(761, 64);
            tbCustomer.Name = "tbCustomer";
            tbCustomer.Size = new Size(189, 30);
            tbCustomer.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(660, 71);
            label17.Name = "label17";
            label17.Size = new Size(102, 23);
            label17.TabIndex = 7;
            label17.Text = "Customer: ";
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(453, 66);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.Size = new Size(199, 30);
            tbOrderID.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(358, 69);
            label16.Name = "label16";
            label16.Size = new Size(88, 23);
            label16.TabIndex = 5;
            label16.Text = "Order ID:";
            // 
            // tbComplainID
            // 
            tbComplainID.Location = new Point(145, 66);
            tbComplainID.Name = "tbComplainID";
            tbComplainID.Size = new Size(199, 30);
            tbComplainID.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 69);
            label15.Name = "label15";
            label15.Size = new Size(127, 23);
            label15.TabIndex = 3;
            label15.Text = "Complaint ID:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblSearch.Location = new Point(9, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(169, 30);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search / Filter";
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(btRawMaterial);
            gbMenu.Controls.Add(btSetting);
            gbMenu.Controls.Add(btLog);
            gbMenu.Controls.Add(Production);
            gbMenu.Controls.Add(btDashBoard);
            gbMenu.Controls.Add(btSales);
            gbMenu.Controls.Add(Inventory);
            gbMenu.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gbMenu.Location = new Point(20, 94);
            gbMenu.Margin = new Padding(5);
            gbMenu.Name = "gbMenu";
            gbMenu.Padding = new Padding(5);
            gbMenu.Size = new Size(228, 604);
            gbMenu.TabIndex = 14;
            gbMenu.TabStop = false;
            gbMenu.Text = "After Sales";
            // 
            // btRawMaterial
            // 
            btRawMaterial.Font = new Font("Microsoft JhengHei UI", 10F);
            btRawMaterial.Location = new Point(24, 428);
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
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSetting.Location = new Point(24, 514);
            btSetting.Margin = new Padding(5);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(184, 48);
            btSetting.TabIndex = 7;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // btLog
            // 
            btLog.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btLog.Location = new Point(24, 189);
            btLog.Margin = new Padding(5);
            btLog.Name = "btLog";
            btLog.Size = new Size(184, 48);
            btLog.TabIndex = 5;
            btLog.Text = "Logistics/Delivery";
            btLog.UseVisualStyleBackColor = true;
            btLog.Click += btLog_Click;
            // 
            // Production
            // 
            Production.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Production.Location = new Point(24, 340);
            Production.Margin = new Padding(5);
            Production.Name = "Production";
            Production.Size = new Size(184, 48);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
            Production.Click += Production_Click;
            // 
            // btDashBoard
            // 
            btDashBoard.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btDashBoard.Location = new Point(24, 46);
            btDashBoard.Margin = new Padding(5);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(184, 48);
            btDashBoard.TabIndex = 1;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // btSales
            // 
            btSales.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSales.Location = new Point(24, 118);
            btSales.Margin = new Padding(5);
            btSales.Name = "btSales";
            btSales.Size = new Size(184, 48);
            btSales.TabIndex = 0;
            btSales.Text = "Sales/Order";
            btSales.UseVisualStyleBackColor = true;
            btSales.Click += btSales_Click;
            // 
            // Inventory
            // 
            Inventory.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Inventory.Location = new Point(24, 264);
            Inventory.Margin = new Padding(5);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(184, 48);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(1175, 21);
            Logoutbt.Margin = new Padding(5, 0, 5, 0);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(74, 23);
            Logoutbt.TabIndex = 9;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            Logoutbt.LinkClicked += Logoutbt_LinkClicked;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(808, 9);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(358, 60);
            lblWelcome.TabIndex = 8;
            // 
            // AfterSales
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(Logoutbt);
            Controls.Add(gbMenu);
            Controls.Add(lblWelcome);
            Controls.Add(tabAfterSales);
            Controls.Add(label1SystemName);
            Name = "AfterSales";
            Text = "AfterSales";
            Load += AfterSales_Load;
            tabAfterSales.ResumeLayout(false);
            tabPageShipConfirmation.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPageComplaint.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1SystemName;
        private TabControl tabAfterSales;
        private TabPage tabPageComplaint;
        private Panel panel3;
        private Button btRefreshComplaint;
        private Button btViewComplaint;
        private Button btNewComplaint;
        private DataGridView dataGridView1;
        private Button btCLears;
        private Button btSearch;
        private Label label21;
        private Label label20;
        private ComboBox cmbUser;
        private Label label19;
        private ComboBox cmbType;
        private Label label18;
        private TextBox tbCustomer;
        private Label label17;
        private TextBox tbOrderID;
        private Label label16;
        private TextBox tbComplainID;
        private Label label15;
        private Label lblSearch;
        private TabPage tabPageShipConfirmation;
        private GroupBox gbMenu;
        private Button btSetting;
        private Button btLog;
        private Button Production;
        private Button Inventory;
        private Button btDashBoard;
        private Button btSales;
        private DateTimePicker EDate;
        private DateTimePicker SDate;
        private LinkLabel Logoutbt;
        private Label lblWelcome;
        private Panel panel1;
        private Button btSave;
        private Button btClear;
        private Button btRefresh;
        private DataGridView dataGridView2;
        private Label lblNote;
        private Label lblCustConfir;
        private Label lblCondit;
        private ComboBox cmbCustConfirm;
        private Label lblName;
        private DateTimePicker date;
        private Label lblDate;
        private Label lblShipID;
        private ComboBox cmbCondit;
        private TextBox tbReceiverName;
        private TextBox tbNote;
        private TextBox tbShipID;
        private ComboBox cmbConID;
        private Label lblComID;
        private Button btRawMaterial;
    }
}

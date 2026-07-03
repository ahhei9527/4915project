namespace _4915project
{
    partial class Production
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
            TabPage tabPage2;
            cmbRequestID = new ComboBox();
            label23 = new Label();
            dataGridView3 = new DataGridView();
            btSearchRequest = new Button();
            requestEndDate = new DateTimePicker();
            requestStartDate = new DateTimePicker();
            cmbRequestStatus = new ComboBox();
            cmbUrgency = new ComboBox();
            cmbUser = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button10 = new Button();
            button8 = new Button();
            dataGridView2 = new DataGridView();
            label1SystemName = new Label();
            groupBox1 = new GroupBox();
            btRawMaterial = new Button();
            btSetting = new Button();
            btSales = new Button();
            btAfterSales = new Button();
            btDashBoard = new Button();
            Inventory = new Button();
            btLog = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cmbCust = new ComboBox();
            cmbOrderID = new ComboBox();
            EndDate = new DateTimePicker();
            StartDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            btSNReflash = new Button();
            btLinkSN = new Button();
            dataGridView1 = new DataGridView();
            label22 = new Label();
            btSNClear = new Button();
            btSNSearch = new Button();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            lblWelcome = new Label();
            Logoutbt = new LinkLabel();
            tabPage2 = new TabPage();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gainsboro;
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(cmbRequestID);
            tabPage2.Controls.Add(label23);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Controls.Add(btSearchRequest);
            tabPage2.Controls.Add(requestEndDate);
            tabPage2.Controls.Add(requestStartDate);
            tabPage2.Controls.Add(cmbRequestStatus);
            tabPage2.Controls.Add(cmbUrgency);
            tabPage2.Controls.Add(cmbUser);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1054, 657);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Material Request";
            // 
            // cmbRequestID
            // 
            cmbRequestID.FormattingEnabled = true;
            cmbRequestID.Location = new Point(207, 40);
            cmbRequestID.Margin = new Padding(5);
            cmbRequestID.Name = "cmbRequestID";
            cmbRequestID.Size = new Size(163, 31);
            cmbRequestID.TabIndex = 34;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(31, 386);
            label23.Margin = new Padding(5, 0, 5, 0);
            label23.Name = "label23";
            label23.Size = new Size(123, 23);
            label23.TabIndex = 33;
            label23.Text = "Request Item";
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(16, 425);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(992, 172);
            dataGridView3.TabIndex = 32;
            // 
            // btSearchRequest
            // 
            btSearchRequest.Location = new Point(750, 158);
            btSearchRequest.Margin = new Padding(5);
            btSearchRequest.Name = "btSearchRequest";
            btSearchRequest.Size = new Size(118, 35);
            btSearchRequest.TabIndex = 31;
            btSearchRequest.Text = "Search";
            btSearchRequest.UseVisualStyleBackColor = true;
            btSearchRequest.Click += btSearchRequest_Click;
            // 
            // requestEndDate
            // 
            requestEndDate.Location = new Point(534, 97);
            requestEndDate.Margin = new Padding(5);
            requestEndDate.Name = "requestEndDate";
            requestEndDate.Size = new Size(174, 30);
            requestEndDate.TabIndex = 30;
            // 
            // requestStartDate
            // 
            requestStartDate.Location = new Point(207, 97);
            requestStartDate.Margin = new Padding(5);
            requestStartDate.Name = "requestStartDate";
            requestStartDate.Size = new Size(163, 30);
            requestStartDate.TabIndex = 29;
            // 
            // cmbRequestStatus
            // 
            cmbRequestStatus.FormattingEnabled = true;
            cmbRequestStatus.Location = new Point(805, 95);
            cmbRequestStatus.Margin = new Padding(5);
            cmbRequestStatus.Name = "cmbRequestStatus";
            cmbRequestStatus.Size = new Size(138, 31);
            cmbRequestStatus.TabIndex = 28;
            // 
            // cmbUrgency
            // 
            cmbUrgency.FormattingEnabled = true;
            cmbUrgency.Location = new Point(805, 40);
            cmbUrgency.Margin = new Padding(5);
            cmbUrgency.Name = "cmbUrgency";
            cmbUrgency.Size = new Size(138, 31);
            cmbUrgency.TabIndex = 26;
            // 
            // cmbUser
            // 
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(532, 40);
            cmbUser.Margin = new Padding(5);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(169, 31);
            cmbUser.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(728, 100);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 24;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(380, 100);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 23;
            label5.Text = "Request fate to:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 101);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 23);
            label4.TabIndex = 22;
            label4.Text = "Request date from:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(711, 43);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 21;
            label3.Text = "Urgency:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 43);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 20;
            label2.Text = "User:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 19;
            label1.Text = "RequestID:";
            // 
            // button10
            // 
            button10.Location = new Point(890, 158);
            button10.Name = "button10";
            button10.Size = new Size(112, 34);
            button10.TabIndex = 18;
            button10.Text = "Clear";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.Location = new Point(850, 603);
            button8.Name = "button8";
            button8.Size = new Size(152, 34);
            button8.TabIndex = 16;
            button8.Text = "Add Request";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 201);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(992, 172);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label1SystemName
            // 
            label1SystemName.AutoSize = true;
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(41, 21);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(592, 36);
            label1SystemName.TabIndex = 4;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            label1SystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btRawMaterial);
            groupBox1.Controls.Add(btSetting);
            groupBox1.Controls.Add(btSales);
            groupBox1.Controls.Add(btAfterSales);
            groupBox1.Controls.Add(btDashBoard);
            groupBox1.Controls.Add(Inventory);
            groupBox1.Controls.Add(btLog);
            groupBox1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            groupBox1.Location = new Point(20, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 593);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Production";
            // 
            // btRawMaterial
            // 
            btRawMaterial.Font = new Font("Microsoft JhengHei UI", 10F);
            btRawMaterial.Location = new Point(20, 348);
            btRawMaterial.Margin = new Padding(5);
            btRawMaterial.Name = "btRawMaterial";
            btRawMaterial.Size = new Size(184, 52);
            btRawMaterial.TabIndex = 12;
            btRawMaterial.Text = "Raw Material";
            btRawMaterial.UseVisualStyleBackColor = true;
            btRawMaterial.Click += btRawMaterial_Click;
            // 
            // btSetting
            // 
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F);
            btSetting.Location = new Point(20, 509);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(184, 48);
            btSetting.TabIndex = 11;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // btSales
            // 
            btSales.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSales.Location = new Point(20, 120);
            btSales.Name = "btSales";
            btSales.Size = new Size(184, 48);
            btSales.TabIndex = 7;
            btSales.Text = "Sales/Order";
            btSales.UseVisualStyleBackColor = true;
            btSales.Click += btSales_Click;
            // 
            // btAfterSales
            // 
            btAfterSales.Font = new Font("Microsoft JhengHei UI", 10F);
            btAfterSales.Location = new Point(20, 428);
            btAfterSales.Name = "btAfterSales";
            btAfterSales.Size = new Size(184, 48);
            btAfterSales.TabIndex = 10;
            btAfterSales.Text = "After Sales";
            btAfterSales.UseVisualStyleBackColor = true;
            btAfterSales.Click += btAfterSales_Click;
            // 
            // btDashBoard
            // 
            btDashBoard.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btDashBoard.Location = new Point(20, 48);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(184, 48);
            btDashBoard.TabIndex = 6;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // Inventory
            // 
            Inventory.Font = new Font("Microsoft JhengHei UI", 10F);
            Inventory.Location = new Point(20, 273);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(184, 48);
            Inventory.TabIndex = 9;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // btLog
            // 
            btLog.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btLog.Location = new Point(20, 196);
            btLog.Name = "btLog";
            btLog.Size = new Size(184, 48);
            btLog.TabIndex = 8;
            btLog.Text = "Logistics/Delivery";
            btLog.UseVisualStyleBackColor = true;
            btLog.Click += btLog_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(266, 97);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1062, 693);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gainsboro;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(cmbCust);
            tabPage1.Controls.Add(cmbOrderID);
            tabPage1.Controls.Add(EndDate);
            tabPage1.Controls.Add(StartDate);
            tabPage1.Controls.Add(cmbStatus);
            tabPage1.Controls.Add(btSNReflash);
            tabPage1.Controls.Add(btLinkSN);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(btSNClear);
            tabPage1.Controls.Add(btSNSearch);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label16);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1054, 657);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Production";
            // 
            // cmbCust
            // 
            cmbCust.FormattingEnabled = true;
            cmbCust.Location = new Point(523, 77);
            cmbCust.Margin = new Padding(5);
            cmbCust.Name = "cmbCust";
            cmbCust.Size = new Size(189, 31);
            cmbCust.TabIndex = 39;
            // 
            // cmbOrderID
            // 
            cmbOrderID.FormattingEnabled = true;
            cmbOrderID.Location = new Point(152, 77);
            cmbOrderID.Margin = new Padding(5);
            cmbOrderID.Name = "cmbOrderID";
            cmbOrderID.Size = new Size(208, 31);
            cmbOrderID.TabIndex = 38;
            // 
            // EndDate
            // 
            EndDate.Location = new Point(523, 143);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(189, 30);
            EndDate.TabIndex = 37;
            // 
            // StartDate
            // 
            StartDate.Location = new Point(152, 143);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(208, 30);
            StartDate.TabIndex = 36;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(834, 77);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(182, 31);
            cmbStatus.TabIndex = 35;
            // 
            // btSNReflash
            // 
            btSNReflash.Location = new Point(904, 569);
            btSNReflash.Name = "btSNReflash";
            btSNReflash.Size = new Size(112, 34);
            btSNReflash.TabIndex = 31;
            btSNReflash.Text = "Refresh";
            btSNReflash.UseVisualStyleBackColor = true;
            btSNReflash.Click += btSNReflash_Click;
            // 
            // btLinkSN
            // 
            btLinkSN.Location = new Point(636, 569);
            btLinkSN.Name = "btLinkSN";
            btLinkSN.Size = new Size(229, 34);
            btLinkSN.TabIndex = 29;
            btLinkSN.Text = "Link SN to Order";
            btLinkSN.UseVisualStyleBackColor = true;
            btLinkSN.Click += btLinkSN_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1004, 244);
            dataGridView1.TabIndex = 28;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label22.Location = new Point(24, 264);
            label22.Name = "label22";
            label22.Size = new Size(343, 30);
            label22.TabIndex = 27;
            label22.Text = "Order Waiting for Production";
            // 
            // btSNClear
            // 
            btSNClear.Location = new Point(856, 215);
            btSNClear.Name = "btSNClear";
            btSNClear.Size = new Size(112, 34);
            btSNClear.TabIndex = 26;
            btSNClear.Text = "Clear";
            btSNClear.UseVisualStyleBackColor = true;
            btSNClear.Click += btSNClear_Click;
            // 
            // btSNSearch
            // 
            btSNSearch.Location = new Point(698, 215);
            btSNSearch.Name = "btSNSearch";
            btSNSearch.Size = new Size(112, 34);
            btSNSearch.TabIndex = 25;
            btSNSearch.Text = "Search";
            btSNSearch.UseVisualStyleBackColor = true;
            btSNSearch.Click += btSNSearch_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(446, 149);
            label21.Name = "label21";
            label21.Size = new Size(81, 23);
            label21.TabIndex = 24;
            label21.Text = "Data To:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(52, 149);
            label20.Name = "label20";
            label20.Size = new Size(104, 23);
            label20.TabIndex = 23;
            label20.Text = "Data From:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(773, 81);
            label19.Name = "label19";
            label19.Size = new Size(67, 23);
            label19.TabIndex = 22;
            label19.Text = "Status:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(407, 81);
            label18.Name = "label18";
            label18.Size = new Size(97, 23);
            label18.TabIndex = 21;
            label18.Text = "Customer:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(68, 81);
            label17.Name = "label17";
            label17.Size = new Size(88, 23);
            label17.TabIndex = 20;
            label17.Text = "Order ID:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(24, 21);
            label16.Name = "label16";
            label16.Size = new Size(132, 23);
            label16.TabIndex = 19;
            label16.Text = "Search / Filter:";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(808, 9);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(358, 60);
            lblWelcome.TabIndex = 9;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(1175, 21);
            Logoutbt.Margin = new Padding(5, 0, 5, 0);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(74, 23);
            Logoutbt.TabIndex = 10;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            Logoutbt.LinkClicked += Logoutbt_LinkClicked;
            // 
            // Production
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(Logoutbt);
            Controls.Add(lblWelcome);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Controls.Add(label1SystemName);
            Name = "Production";
            Text = "Production";
            Load += Production_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1SystemName;
        private GroupBox groupBox1;
        private Button btDashBoard;
        private Button btSales;
        private Button btLog;
        private Button Inventory;
        private Button btAfterSales;
        private Button btSetting;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lblWelcome;
        private LinkLabel Logoutbt;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button2;
        private Button btSearchRequest;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox11;
        private TextBox textBox10;
        private DateTimePicker EndDate;
        private DateTimePicker StartDate;
        private ComboBox cmbStatus;
        private Button btSNReflash;
        private Button btLinkSN;
        private DataGridView dataGridView1;
        private Label label22;
        private Button btSNClear;
        private Button btSNSearch;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private TextBox textBox15;
        private Button button10;
        private Button button9;
        private Button button8;
        private DataGridView dataGridView2;
        private TextBox textBox20;
        private ComboBox cmbOrderID;
        private ComboBox cmbCust;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker requestEndDate;
        private DateTimePicker requestStartDate;
        private ComboBox cmbRequestStatus;
        private ComboBox cmbUrgency;
        private ComboBox cmbUser;
        private Label label4;
        private Label label23;
        private DataGridView dataGridView3;
        private ComboBox cmbRequestID;
        private Button btRawMaterial;
    }
}

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
            btRawMaterial = new Button();
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(668, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Material Request";
            // 
            // cmbRequestID
            // 
            cmbRequestID.FormattingEnabled = true;
            cmbRequestID.Location = new Point(94, 11);
            cmbRequestID.Name = "cmbRequestID";
            cmbRequestID.Size = new Size(121, 23);
            cmbRequestID.TabIndex = 34;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(20, 252);
            label23.Name = "label23";
            label23.Size = new Size(81, 15);
            label23.TabIndex = 33;
            label23.Text = "Request Item";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(10, 277);
            dataGridView3.Margin = new Padding(2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(631, 112);
            dataGridView3.TabIndex = 32;
            // 
            // btSearchRequest
            // 
            btSearchRequest.Location = new Point(447, 103);
            btSearchRequest.Name = "btSearchRequest";
            btSearchRequest.Size = new Size(75, 23);
            btSearchRequest.TabIndex = 31;
            btSearchRequest.Text = "Search";
            btSearchRequest.UseVisualStyleBackColor = true;
            btSearchRequest.Click += btSearchRequest_Click;
            // 
            // requestEndDate
            // 
            requestEndDate.Location = new Point(354, 63);
            requestEndDate.Name = "requestEndDate";
            requestEndDate.Size = new Size(112, 23);
            requestEndDate.TabIndex = 30;
            // 
            // requestStartDate
            // 
            requestStartDate.Location = new Point(132, 63);
            requestStartDate.Name = "requestStartDate";
            requestStartDate.Size = new Size(114, 23);
            requestStartDate.TabIndex = 29;
            // 
            // cmbRequestStatus
            // 
            cmbRequestStatus.FormattingEnabled = true;
            cmbRequestStatus.Location = new Point(523, 63);
            cmbRequestStatus.Name = "cmbRequestStatus";
            cmbRequestStatus.Size = new Size(89, 23);
            cmbRequestStatus.TabIndex = 28;
            // 
            // cmbUrgency
            // 
            cmbUrgency.FormattingEnabled = true;
            cmbUrgency.Location = new Point(491, 11);
            cmbUrgency.Name = "cmbUrgency";
            cmbUrgency.Size = new Size(121, 23);
            cmbUrgency.TabIndex = 26;
            // 
            // cmbUser
            // 
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(282, 11);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(121, 23);
            cmbUser.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 66);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 24;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 66);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 23;
            label5.Text = "Request fate to:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 66);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 22;
            label4.Text = "Request date from:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 14);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 21;
            label3.Text = "Urgency:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 14);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 20;
            label2.Text = "User:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 19;
            label1.Text = "RequestID:";
            // 
            // button10
            // 
            button10.Location = new Point(541, 103);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(71, 22);
            button10.TabIndex = 18;
            button10.Text = "Clear";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.Location = new Point(541, 393);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(97, 22);
            button8.TabIndex = 16;
            button8.Text = "Add Request";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(10, 131);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(631, 112);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label1SystemName
            // 
            label1SystemName.AutoSize = true;
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(26, 14);
            label1SystemName.Margin = new Padding(2, 0, 2, 0);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(407, 24);
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
            groupBox1.Location = new Point(13, 61);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(145, 387);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Production";
            // 
            // btSetting
            // 
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F);
            btSetting.Location = new Point(13, 332);
            btSetting.Margin = new Padding(2);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(117, 31);
            btSetting.TabIndex = 11;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // btSales
            // 
            btSales.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSales.Location = new Point(13, 78);
            btSales.Margin = new Padding(2);
            btSales.Name = "btSales";
            btSales.Size = new Size(117, 31);
            btSales.TabIndex = 7;
            btSales.Text = "Sales/Order";
            btSales.UseVisualStyleBackColor = true;
            btSales.Click += btSales_Click;
            // 
            // btAfterSales
            // 
            btAfterSales.Font = new Font("Microsoft JhengHei UI", 10F);
            btAfterSales.Location = new Point(13, 279);
            btAfterSales.Margin = new Padding(2);
            btAfterSales.Name = "btAfterSales";
            btAfterSales.Size = new Size(117, 31);
            btAfterSales.TabIndex = 10;
            btAfterSales.Text = "After Sales";
            btAfterSales.UseVisualStyleBackColor = true;
            btAfterSales.Click += btAfterSales_Click;
            // 
            // btDashBoard
            // 
            btDashBoard.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btDashBoard.Location = new Point(13, 31);
            btDashBoard.Margin = new Padding(2);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(117, 31);
            btDashBoard.TabIndex = 6;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // Inventory
            // 
            Inventory.Font = new Font("Microsoft JhengHei UI", 10F);
            Inventory.Location = new Point(13, 178);
            Inventory.Margin = new Padding(2);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(117, 31);
            Inventory.TabIndex = 9;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // btLog
            // 
            btLog.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btLog.Location = new Point(13, 128);
            btLog.Margin = new Padding(2);
            btLog.Name = "btLog";
            btLog.Size = new Size(117, 31);
            btLog.TabIndex = 8;
            btLog.Text = "Logistics/Delivery";
            btLog.UseVisualStyleBackColor = true;
            btLog.Click += btLog_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(169, 63);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(676, 452);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(668, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Production";
            // 
            // cmbCust
            // 
            cmbCust.FormattingEnabled = true;
            cmbCust.Location = new Point(333, 50);
            cmbCust.Name = "cmbCust";
            cmbCust.Size = new Size(122, 23);
            cmbCust.TabIndex = 39;
            // 
            // cmbOrderID
            // 
            cmbOrderID.FormattingEnabled = true;
            cmbOrderID.Location = new Point(97, 50);
            cmbOrderID.Name = "cmbOrderID";
            cmbOrderID.Size = new Size(134, 23);
            cmbOrderID.TabIndex = 38;
            // 
            // EndDate
            // 
            EndDate.Location = new Point(333, 93);
            EndDate.Margin = new Padding(2);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(122, 23);
            EndDate.TabIndex = 37;
            // 
            // StartDate
            // 
            StartDate.Location = new Point(97, 93);
            StartDate.Margin = new Padding(2);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(134, 23);
            StartDate.TabIndex = 36;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(531, 50);
            cmbStatus.Margin = new Padding(2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(117, 23);
            cmbStatus.TabIndex = 35;
            // 
            // btSNReflash
            // 
            btSNReflash.Location = new Point(575, 371);
            btSNReflash.Margin = new Padding(2);
            btSNReflash.Name = "btSNReflash";
            btSNReflash.Size = new Size(71, 22);
            btSNReflash.TabIndex = 31;
            btSNReflash.Text = "Refresh";
            btSNReflash.UseVisualStyleBackColor = true;
            btSNReflash.Click += btSNReflash_Click;
            // 
            // btLinkSN
            // 
            btLinkSN.Location = new Point(405, 371);
            btLinkSN.Margin = new Padding(2);
            btLinkSN.Name = "btLinkSN";
            btLinkSN.Size = new Size(146, 22);
            btLinkSN.TabIndex = 29;
            btLinkSN.Text = "Link SN to Order";
            btLinkSN.UseVisualStyleBackColor = true;
            btLinkSN.Click += btLinkSN_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 193);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(639, 159);
            dataGridView1.TabIndex = 28;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label22.Location = new Point(15, 172);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(229, 20);
            label22.TabIndex = 27;
            label22.Text = "Order Waiting for Production";
            // 
            // btSNClear
            // 
            btSNClear.Location = new Point(545, 140);
            btSNClear.Margin = new Padding(2);
            btSNClear.Name = "btSNClear";
            btSNClear.Size = new Size(71, 22);
            btSNClear.TabIndex = 26;
            btSNClear.Text = "Clear";
            btSNClear.UseVisualStyleBackColor = true;
            btSNClear.Click += btSNClear_Click;
            // 
            // btSNSearch
            // 
            btSNSearch.Location = new Point(444, 140);
            btSNSearch.Margin = new Padding(2);
            btSNSearch.Name = "btSNSearch";
            btSNSearch.Size = new Size(71, 22);
            btSNSearch.TabIndex = 25;
            btSNSearch.Text = "Search";
            btSNSearch.UseVisualStyleBackColor = true;
            btSNSearch.Click += btSNSearch_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(284, 97);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(55, 15);
            label21.TabIndex = 24;
            label21.Text = "Data To:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(33, 97);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(69, 15);
            label20.TabIndex = 23;
            label20.Text = "Data From:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(492, 53);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(44, 15);
            label19.TabIndex = 22;
            label19.Text = "Status:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(259, 53);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(64, 15);
            label18.TabIndex = 21;
            label18.Text = "Customer:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(43, 53);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(58, 15);
            label17.TabIndex = 20;
            label17.Text = "Order ID:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 14);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(86, 15);
            label16.TabIndex = 19;
            label16.Text = "Search / Filter:";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(514, 6);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(228, 39);
            lblWelcome.TabIndex = 9;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(748, 14);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(50, 15);
            Logoutbt.TabIndex = 10;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            Logoutbt.LinkClicked += Logoutbt_LinkClicked;
            // 
            // btRawMaterial
            // 
            btRawMaterial.Location = new Point(13, 227);
            btRawMaterial.Name = "btRawMaterial";
            btRawMaterial.Size = new Size(117, 34);
            btRawMaterial.TabIndex = 12;
            btRawMaterial.Text = "Raw Material";
            btRawMaterial.UseVisualStyleBackColor = true;
            btRawMaterial.Click += btRawMaterial_Click;
            // 
            // Production
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 561);
            Controls.Add(Logoutbt);
            Controls.Add(lblWelcome);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Controls.Add(label1SystemName);
            Margin = new Padding(2);
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

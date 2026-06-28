namespace _4915project
{
    partial class FormLogistics
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            cbOrderID = new ComboBox();
            tbShipID = new TextBox();
            cbMethod = new ComboBox();
            lblMethod = new Label();
            cbremark = new ComboBox();
            cbshipStat = new ComboBox();
            lblShipStatus = new Label();
            receviedDate = new DateTimePicker();
            DelivDate = new DateTimePicker();
            lblActualDDate = new Label();
            cbOrderstat = new ComboBox();
            btUpdateCreate = new Button();
            label12 = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            lblOrderStatus = new Label();
            label10 = new Label();
            lblShipID = new Label();
            GenDoc = new TabPage();
            tabControl2 = new TabControl();
            DeliveryNote = new TabPage();
            tbRecipient = new TextBox();
            dataGridView1 = new DataGridView();
            btGenNote = new Button();
            lblAddress = new Label();
            lblRecipient = new Label();
            lblOrderID = new Label();
            label9 = new Label();
            tbOrderID = new TextBox();
            tbAddress = new TextBox();
            tbDeliveryNoteID = new TextBox();
            cmbShipID = new ComboBox();
            lblDeliveryID = new Label();
            ReplySlip = new TabPage();
            cmbDeliveryID = new ComboBox();
            lblCompleted = new Label();
            dateDeliveryDate = new DateTimePicker();
            label2 = new Label();
            label5 = new Label();
            tbReplyID = new TextBox();
            label13 = new Label();
            tbReplyCustName = new TextBox();
            dataGridView3 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbReplyOrderID = new TextBox();
            tbReplyAddress = new TextBox();
            label6 = new Label();
            btGenSlip = new Button();
            gbMenu = new GroupBox();
            btSetting = new Button();
            AfterSales = new Button();
            Production = new Button();
            Inventory = new Button();
            btDashBoard = new Button();
            btSales = new Button();
            Logoutbt = new LinkLabel();
            lblWelcome = new Label();
            btRawMaterial = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            GenDoc.SuspendLayout();
            tabControl2.SuspendLayout();
            DeliveryNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ReplySlip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            gbMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1SystemName
            // 
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(26, 14);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(377, 23);
            label1SystemName.TabIndex = 2;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            label1SystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(GenDoc);
            tabControl1.Location = new Point(169, 63);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(676, 430);
            tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGray;
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(668, 402);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Status & Goods Received";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(cbOrderID);
            groupBox1.Controls.Add(tbShipID);
            groupBox1.Controls.Add(cbMethod);
            groupBox1.Controls.Add(lblMethod);
            groupBox1.Controls.Add(cbremark);
            groupBox1.Controls.Add(cbshipStat);
            groupBox1.Controls.Add(lblShipStatus);
            groupBox1.Controls.Add(receviedDate);
            groupBox1.Controls.Add(DelivDate);
            groupBox1.Controls.Add(lblActualDDate);
            groupBox1.Controls.Add(cbOrderstat);
            groupBox1.Controls.Add(btUpdateCreate);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblOrderStatus);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblShipID);
            groupBox1.Location = new Point(6, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(660, 394);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ongoing Deliveries";
            // 
            // cbOrderID
            // 
            cbOrderID.FormattingEnabled = true;
            cbOrderID.Location = new Point(461, 22);
            cbOrderID.Name = "cbOrderID";
            cbOrderID.Size = new Size(127, 23);
            cbOrderID.TabIndex = 28;
            cbOrderID.SelectedIndexChanged += cbOrderID_SelectedIndexChanged;
            // 
            // tbShipID
            // 
            tbShipID.Location = new Point(109, 23);
            tbShipID.Name = "tbShipID";
            tbShipID.Size = new Size(121, 23);
            tbShipID.TabIndex = 27;
            // 
            // cbMethod
            // 
            cbMethod.FormattingEnabled = true;
            cbMethod.Location = new Point(109, 114);
            cbMethod.Name = "cbMethod";
            cbMethod.Size = new Size(121, 23);
            cbMethod.TabIndex = 26;
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Location = new Point(5, 117);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(107, 15);
            lblMethod.TabIndex = 25;
            lblMethod.Text = "Delivery Method: ";
            // 
            // cbremark
            // 
            cbremark.FormattingEnabled = true;
            cbremark.Location = new Point(461, 114);
            cbremark.Name = "cbremark";
            cbremark.Size = new Size(127, 23);
            cbremark.TabIndex = 24;
            // 
            // cbshipStat
            // 
            cbshipStat.FormattingEnabled = true;
            cbshipStat.Location = new Point(109, 82);
            cbshipStat.Name = "cbshipStat";
            cbshipStat.Size = new Size(121, 23);
            cbshipStat.TabIndex = 23;
            // 
            // lblShipStatus
            // 
            lblShipStatus.AutoSize = true;
            lblShipStatus.Location = new Point(5, 88);
            lblShipStatus.Name = "lblShipStatus";
            lblShipStatus.Size = new Size(101, 15);
            lblShipStatus.TabIndex = 22;
            lblShipStatus.Text = "Shipment Status:";
            // 
            // receviedDate
            // 
            receviedDate.Location = new Point(461, 53);
            receviedDate.Name = "receviedDate";
            receviedDate.Size = new Size(127, 23);
            receviedDate.TabIndex = 21;
            // 
            // DelivDate
            // 
            DelivDate.Location = new Point(461, 82);
            DelivDate.Name = "DelivDate";
            DelivDate.Size = new Size(127, 23);
            DelivDate.TabIndex = 20;
            // 
            // lblActualDDate
            // 
            lblActualDDate.AutoSize = true;
            lblActualDDate.Location = new Point(331, 84);
            lblActualDDate.Name = "lblActualDDate";
            lblActualDDate.Size = new Size(123, 15);
            lblActualDDate.TabIndex = 19;
            lblActualDDate.Text = "Actual Delivery Date:";
            // 
            // cbOrderstat
            // 
            cbOrderstat.FormattingEnabled = true;
            cbOrderstat.Location = new Point(109, 52);
            cbOrderstat.Name = "cbOrderstat";
            cbOrderstat.Size = new Size(121, 23);
            cbOrderstat.TabIndex = 17;
            // 
            // btUpdateCreate
            // 
            btUpdateCreate.Location = new Point(205, 361);
            btUpdateCreate.Margin = new Padding(2);
            btUpdateCreate.Name = "btUpdateCreate";
            btUpdateCreate.Size = new Size(225, 22);
            btUpdateCreate.TabIndex = 16;
            btUpdateCreate.Text = "Update Status & Complete Order";
            btUpdateCreate.UseVisualStyleBackColor = true;
            btUpdateCreate.Click += btUpdateCreate_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(395, 25);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 10;
            label12.Text = "Order ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 151);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(218, 15);
            label7.TabIndex = 9;
            label7.Text = "Pending Orders (Ready for Shipment)";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 193);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(633, 158);
            dataGridView2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(280, 117);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(181, 15);
            label8.TabIndex = 3;
            label8.Text = "Remarks / Shortage / Damage:";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Location = new Point(25, 53);
            lblOrderStatus.Margin = new Padding(2, 0, 2, 0);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(80, 15);
            lblOrderStatus.TabIndex = 2;
            lblOrderStatus.Text = "Order Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(364, 55);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 1;
            label10.Text = "Received Date:";
            // 
            // lblShipID
            // 
            lblShipID.AutoSize = true;
            lblShipID.Location = new Point(35, 25);
            lblShipID.Margin = new Padding(2, 0, 2, 0);
            lblShipID.Name = "lblShipID";
            lblShipID.Size = new Size(70, 15);
            lblShipID.TabIndex = 0;
            lblShipID.Text = "Delivery ID:";
            // 
            // GenDoc
            // 
            GenDoc.BackColor = Color.DarkGray;
            GenDoc.Controls.Add(tabControl2);
            GenDoc.Location = new Point(4, 24);
            GenDoc.Name = "GenDoc";
            GenDoc.Size = new Size(668, 402);
            GenDoc.TabIndex = 2;
            GenDoc.Text = "Generate Document";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(DeliveryNote);
            tabControl2.Controls.Add(ReplySlip);
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(659, 400);
            tabControl2.TabIndex = 0;
            // 
            // DeliveryNote
            // 
            DeliveryNote.BackColor = Color.Gainsboro;
            DeliveryNote.BorderStyle = BorderStyle.FixedSingle;
            DeliveryNote.Controls.Add(tbRecipient);
            DeliveryNote.Controls.Add(dataGridView1);
            DeliveryNote.Controls.Add(btGenNote);
            DeliveryNote.Controls.Add(lblAddress);
            DeliveryNote.Controls.Add(lblRecipient);
            DeliveryNote.Controls.Add(lblOrderID);
            DeliveryNote.Controls.Add(label9);
            DeliveryNote.Controls.Add(tbOrderID);
            DeliveryNote.Controls.Add(tbAddress);
            DeliveryNote.Controls.Add(tbDeliveryNoteID);
            DeliveryNote.Controls.Add(cmbShipID);
            DeliveryNote.Controls.Add(lblDeliveryID);
            DeliveryNote.Location = new Point(4, 24);
            DeliveryNote.Name = "DeliveryNote";
            DeliveryNote.Padding = new Padding(3);
            DeliveryNote.Size = new Size(651, 372);
            DeliveryNote.TabIndex = 0;
            DeliveryNote.Text = "Delivery Note";
            // 
            // tbRecipient
            // 
            tbRecipient.Location = new Point(365, 82);
            tbRecipient.Name = "tbRecipient";
            tbRecipient.Size = new Size(121, 23);
            tbRecipient.TabIndex = 49;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(633, 145);
            dataGridView1.TabIndex = 48;
            // 
            // btGenNote
            // 
            btGenNote.Location = new Point(218, 335);
            btGenNote.Name = "btGenNote";
            btGenNote.Size = new Size(195, 23);
            btGenNote.TabIndex = 47;
            btGenNote.Text = "Generate Delivery Note";
            btGenNote.UseVisualStyleBackColor = true;
            btGenNote.Click += btGenNote_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(61, 143);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(58, 15);
            lblAddress.TabIndex = 44;
            lblAddress.Text = "Address: ";
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.Location = new Point(307, 83);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(66, 15);
            lblRecipient.TabIndex = 43;
            lblRecipient.Text = "Recipient: ";
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Location = new Point(79, 83);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(61, 15);
            lblOrderID.TabIndex = 41;
            lblOrderID.Text = "Order ID: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(293, 39);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 38;
            label9.Text = "ShipmentID:";
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(137, 82);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.Size = new Size(121, 23);
            tbOrderID.TabIndex = 37;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(116, 141);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(469, 23);
            tbAddress.TabIndex = 36;
            // 
            // tbDeliveryNoteID
            // 
            tbDeliveryNoteID.Location = new Point(137, 36);
            tbDeliveryNoteID.Name = "tbDeliveryNoteID";
            tbDeliveryNoteID.Size = new Size(121, 23);
            tbDeliveryNoteID.TabIndex = 35;
            // 
            // cmbShipID
            // 
            cmbShipID.FormattingEnabled = true;
            cmbShipID.Location = new Point(365, 36);
            cmbShipID.Name = "cmbShipID";
            cmbShipID.Size = new Size(121, 23);
            cmbShipID.TabIndex = 34;
            cmbShipID.SelectedIndexChanged += cmbShipID_SelectedIndexChanged;
            // 
            // lblDeliveryID
            // 
            lblDeliveryID.AutoSize = true;
            lblDeliveryID.Location = new Point(36, 39);
            lblDeliveryID.Name = "lblDeliveryID";
            lblDeliveryID.Size = new Size(105, 15);
            lblDeliveryID.TabIndex = 33;
            lblDeliveryID.Text = "Delivery Note ID: ";
            // 
            // ReplySlip
            // 
            ReplySlip.BackColor = Color.Gainsboro;
            ReplySlip.Controls.Add(cmbDeliveryID);
            ReplySlip.Controls.Add(lblCompleted);
            ReplySlip.Controls.Add(dateDeliveryDate);
            ReplySlip.Controls.Add(label2);
            ReplySlip.Controls.Add(label5);
            ReplySlip.Controls.Add(tbReplyID);
            ReplySlip.Controls.Add(label13);
            ReplySlip.Controls.Add(tbReplyCustName);
            ReplySlip.Controls.Add(dataGridView3);
            ReplySlip.Controls.Add(label1);
            ReplySlip.Controls.Add(label3);
            ReplySlip.Controls.Add(label4);
            ReplySlip.Controls.Add(tbReplyOrderID);
            ReplySlip.Controls.Add(tbReplyAddress);
            ReplySlip.Controls.Add(label6);
            ReplySlip.Controls.Add(btGenSlip);
            ReplySlip.Location = new Point(4, 24);
            ReplySlip.Name = "ReplySlip";
            ReplySlip.Padding = new Padding(3);
            ReplySlip.Size = new Size(651, 372);
            ReplySlip.TabIndex = 1;
            ReplySlip.Text = "Reply Slip";
            // 
            // cmbDeliveryID
            // 
            cmbDeliveryID.FormattingEnabled = true;
            cmbDeliveryID.Location = new Point(112, 60);
            cmbDeliveryID.Name = "cmbDeliveryID";
            cmbDeliveryID.Size = new Size(121, 23);
            cmbDeliveryID.TabIndex = 69;
            cmbDeliveryID.SelectedIndexChanged += cmbDeliveryID_SelectedIndexChanged;
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Location = new Point(447, 61);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(71, 15);
            lblCompleted.TabIndex = 68;
            lblCompleted.Text = "Completed";
            // 
            // dateDeliveryDate
            // 
            dateDeliveryDate.Location = new Point(447, 102);
            dateDeliveryDate.Name = "dateDeliveryDate";
            dateDeliveryDate.Size = new Size(118, 23);
            dateDeliveryDate.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 102);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 66;
            label2.Text = "Delivery Date: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 61);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 64;
            label5.Text = "Delivery Status: ";
            // 
            // tbReplyID
            // 
            tbReplyID.Location = new Point(112, 16);
            tbReplyID.Name = "tbReplyID";
            tbReplyID.Size = new Size(121, 23);
            tbReplyID.TabIndex = 63;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 21);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 62;
            label13.Text = "Reply Slip ID: ";
            // 
            // tbReplyCustName
            // 
            tbReplyCustName.Location = new Point(112, 106);
            tbReplyCustName.Name = "tbReplyCustName";
            tbReplyCustName.Size = new Size(121, 23);
            tbReplyCustName.TabIndex = 61;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 177);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(633, 158);
            dataGridView3.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 141);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 58;
            label1.Text = "Address: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 106);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 57;
            label3.Text = "Recipient: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 21);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 56;
            label4.Text = "Order ID: ";
            // 
            // tbReplyOrderID
            // 
            tbReplyOrderID.Location = new Point(447, 19);
            tbReplyOrderID.Name = "tbReplyOrderID";
            tbReplyOrderID.Size = new Size(121, 23);
            tbReplyOrderID.TabIndex = 54;
            // 
            // tbReplyAddress
            // 
            tbReplyAddress.Location = new Point(85, 141);
            tbReplyAddress.Name = "tbReplyAddress";
            tbReplyAddress.Size = new Size(535, 23);
            tbReplyAddress.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 64);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 50;
            label6.Text = "Delivery Note ID: ";
            // 
            // btGenSlip
            // 
            btGenSlip.Location = new Point(239, 342);
            btGenSlip.Name = "btGenSlip";
            btGenSlip.Size = new Size(165, 23);
            btGenSlip.TabIndex = 47;
            btGenSlip.Text = "Generate Reply Slip";
            btGenSlip.UseVisualStyleBackColor = true;
            btGenSlip.Click += btGenSlip_Click;
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(btRawMaterial);
            gbMenu.Controls.Add(btSetting);
            gbMenu.Controls.Add(AfterSales);
            gbMenu.Controls.Add(Production);
            gbMenu.Controls.Add(Inventory);
            gbMenu.Controls.Add(btDashBoard);
            gbMenu.Controls.Add(btSales);
            gbMenu.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gbMenu.Location = new Point(13, 61);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(145, 418);
            gbMenu.TabIndex = 13;
            gbMenu.TabStop = false;
            gbMenu.Text = "Logistics/Delivery";
            // 
            // btSetting
            // 
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSetting.Location = new Point(13, 355);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(117, 31);
            btSetting.TabIndex = 7;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // AfterSales
            // 
            AfterSales.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            AfterSales.Location = new Point(13, 289);
            AfterSales.Name = "AfterSales";
            AfterSales.Size = new Size(117, 31);
            AfterSales.TabIndex = 5;
            AfterSales.Text = "AfterSales";
            AfterSales.UseVisualStyleBackColor = true;
            AfterSales.Click += AfterSales_Click;
            // 
            // Production
            // 
            Production.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
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
            Inventory.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Inventory.Location = new Point(15, 123);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(117, 31);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // btDashBoard
            // 
            btDashBoard.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btDashBoard.Location = new Point(15, 30);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(117, 31);
            btDashBoard.TabIndex = 1;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // btSales
            // 
            btSales.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSales.Location = new Point(15, 74);
            btSales.Name = "btSales";
            btSales.Size = new Size(117, 31);
            btSales.TabIndex = 0;
            btSales.Text = "Sales/Order";
            btSales.UseVisualStyleBackColor = true;
            btSales.Click += btSales_Click;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(769, 9);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(50, 15);
            Logoutbt.TabIndex = 13;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            Logoutbt.LinkClicked += Logoutbt_LinkClicked;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(514, 6);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(228, 39);
            lblWelcome.TabIndex = 12;
            // 
            // btRawMaterial
            // 
            btRawMaterial.Location = new Point(13, 228);
            btRawMaterial.Name = "btRawMaterial";
            btRawMaterial.Size = new Size(117, 34);
            btRawMaterial.TabIndex = 13;
            btRawMaterial.Text = "Raw Material";
            btRawMaterial.UseVisualStyleBackColor = true;
            btRawMaterial.Click += btRawMaterial_Click;
            // 
            // FormLogistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 561);
            Controls.Add(Logoutbt);
            Controls.Add(gbMenu);
            Controls.Add(lblWelcome);
            Controls.Add(tabControl1);
            Controls.Add(label1SystemName);
            Margin = new Padding(2);
            Name = "FormLogistics";
            Text = "Logistics";
            Load += FormLogistics_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            GenDoc.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            DeliveryNote.ResumeLayout(false);
            DeliveryNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ReplySlip.ResumeLayout(false);
            ReplySlip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            gbMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAddress;
        private Label label1SystemName;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label12;
        private Label label7;
        private DataGridView dataGridView2;
        private Label label8;
        private Label lblOrderStatus;
        private Label label10;
        private Label lblShipID;
        private Button btUpdateCreate;
        private GroupBox gbMenu;
        private Button btSetting;
        private Button AfterSales;
        private Button Production;
        private Button Inventory;
        private Button btDashBoard;
        private Button btSales;
        private LinkLabel Logoutbt;
        private Label lblWelcome;
        private ComboBox cbOrderstat;
        private DateTimePicker receviedDate;
        private DateTimePicker DelivDate;
        private Label lblActualDDate;
        private Label lblShipStatus;
        private ComboBox cbshipStat;
        private ComboBox cbremark;
        private ComboBox cbMethod;
        private Label lblMethod;
        private TextBox tbShipID;
        private ComboBox cbOrderID;
        private TabPage GenDoc;
        private TabControl tabControl2;
        private TabPage DeliveryNote;
        private TabPage ReplySlip;
        private Button btGenNote;
        private TextBox tbRecipient;
        private Label label2;
        private Label lblRecipient;
        private Label lblOrderID;
        private Label label9;
        private TextBox tbOrderID;
        private TextBox tbAddress;
        private TextBox tbDeliveryNoteID;
        private ComboBox cmbShipID;
        private Label lblDeliveryID;
        private Button btGenSlip;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox tbReplyID;
        private Label label13;
        private TextBox tbReplyCustName;
        private DataGridView dataGridView3;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox tbReplyOrderID;
        private TextBox tbReplyAddress;
        private Label label6;
        private ComboBox cmbDeliveryID;
        private Label lblCompleted;
        private DateTimePicker dateDeliveryDate;
        private Button btRawMaterial;
    }
}

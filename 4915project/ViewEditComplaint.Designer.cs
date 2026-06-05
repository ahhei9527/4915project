namespace ITP4915M
{
    partial class ViewEditComplaint
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
            label15 = new Label();
            label1SystemName = new Label();
            panel2 = new Panel();
            tbSN = new TextBox();
            cmbUserID = new ComboBox();
            cmbComID = new ComboBox();
            btClose = new Button();
            btClears = new Button();
            btSave = new Button();
            tbResolution = new TextBox();
            label13 = new Label();
            resolutionDate = new DateTimePicker();
            label11 = new Label();
            tbDescription = new TextBox();
            receivedDate = new DateTimePicker();
            label9 = new Label();
            cbType = new ComboBox();
            tbCustName = new TextBox();
            tbOrderID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label14 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label15.Location = new Point(18, 42);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(172, 20);
            label15.TabIndex = 11;
            label15.Text = "View / Edit Complaint";
            // 
            // label1SystemName
            // 
            label1SystemName.AutoSize = true;
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(18, 12);
            label1SystemName.Margin = new Padding(2, 0, 2, 0);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(509, 30);
            label1SystemName.TabIndex = 7;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tbSN);
            panel2.Controls.Add(cmbUserID);
            panel2.Controls.Add(cmbComID);
            panel2.Controls.Add(btClose);
            panel2.Controls.Add(btClears);
            panel2.Controls.Add(btSave);
            panel2.Controls.Add(tbResolution);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(resolutionDate);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(tbDescription);
            panel2.Controls.Add(receivedDate);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cbType);
            panel2.Controls.Add(tbCustName);
            panel2.Controls.Add(tbOrderID);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label14);
            panel2.Cursor = Cursors.SizeAll;
            panel2.Location = new Point(13, 64);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 314);
            panel2.TabIndex = 12;
            // 
            // tbSN
            // 
            tbSN.Location = new Point(100, 61);
            tbSN.Margin = new Padding(2);
            tbSN.Name = "tbSN";
            tbSN.ReadOnly = true;
            tbSN.Size = new Size(117, 23);
            tbSN.TabIndex = 32;
            // 
            // cmbUserID
            // 
            cmbUserID.FormattingEnabled = true;
            cmbUserID.Location = new Point(481, 64);
            cmbUserID.Name = "cmbUserID";
            cmbUserID.Size = new Size(121, 23);
            cmbUserID.TabIndex = 31;
            // 
            // cmbComID
            // 
            cmbComID.FormattingEnabled = true;
            cmbComID.Location = new Point(92, 5);
            cmbComID.Name = "cmbComID";
            cmbComID.Size = new Size(121, 23);
            cmbComID.TabIndex = 30;
            cmbComID.SelectedIndexChanged += cmbComID_SelectedIndexChanged;
            // 
            // btClose
            // 
            btClose.Location = new Point(13, 274);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(71, 22);
            btClose.TabIndex = 29;
            btClose.Text = "Close Case";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btClears
            // 
            btClears.Location = new Point(532, 274);
            btClears.Margin = new Padding(2);
            btClears.Name = "btClears";
            btClears.Size = new Size(71, 22);
            btClears.TabIndex = 28;
            btClears.Text = "Clear";
            btClears.UseVisualStyleBackColor = true;
            btClears.Click += btClears_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(437, 274);
            btSave.Margin = new Padding(2);
            btSave.Name = "btSave";
            btSave.Size = new Size(71, 22);
            btSave.TabIndex = 27;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // tbResolution
            // 
            tbResolution.Location = new Point(15, 145);
            tbResolution.Margin = new Padding(2);
            tbResolution.Multiline = true;
            tbResolution.Name = "tbResolution";
            tbResolution.Size = new Size(590, 33);
            tbResolution.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 128);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(178, 15);
            label13.TabIndex = 24;
            label13.Text = "Replacement / Refund Details:";
            // 
            // resolutionDate
            // 
            resolutionDate.Location = new Point(478, 98);
            resolutionDate.Margin = new Padding(2);
            resolutionDate.Name = "resolutionDate";
            resolutionDate.Size = new Size(126, 23);
            resolutionDate.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(379, 98);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 15);
            label11.TabIndex = 20;
            label11.Text = "Resolution Date:";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(13, 207);
            tbDescription.Margin = new Padding(2);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(590, 52);
            tbDescription.TabIndex = 17;
            // 
            // receivedDate
            // 
            receivedDate.Location = new Point(481, 8);
            receivedDate.Margin = new Padding(2);
            receivedDate.Name = "receivedDate";
            receivedDate.Size = new Size(124, 23);
            receivedDate.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 190);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 15;
            label9.Text = "Description:";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Damage", "Missing", "Return", "Refund" });
            cbType.Location = new Point(106, 90);
            cbType.Margin = new Padding(2);
            cbType.Name = "cbType";
            cbType.Size = new Size(107, 23);
            cbType.TabIndex = 13;
            // 
            // tbCustName
            // 
            tbCustName.Location = new Point(481, 38);
            tbCustName.Margin = new Padding(2);
            tbCustName.Name = "tbCustName";
            tbCustName.Size = new Size(124, 23);
            tbCustName.TabIndex = 11;
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(96, 33);
            tbOrderID.Margin = new Padding(2);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.ReadOnly = true;
            tbOrderID.Size = new Size(117, 23);
            tbOrderID.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 92);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 6;
            label7.Text = "Complaint Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(403, 63);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 5;
            label6.Text = "Assigned To:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 40);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 4;
            label5.Text = "Customer Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 10);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "Date Received:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 64);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Product Serial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Order ID:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 8);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 0;
            label14.Text = "Complaint ID:";
            // 
            // ViewEditComplaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 388);
            Controls.Add(panel2);
            Controls.Add(label15);
            Controls.Add(label1SystemName);
            Margin = new Padding(2);
            Name = "ViewEditComplaint";
            Text = "View / Edit Complaint";
            Load += ViewEditComplaint_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private Label label1SystemName;
        private Panel panel2;
        private TextBox tbSN;
        private ComboBox cmbUserID;
        private ComboBox cmbComID;
        private Button btClose;
        private Button btClears;
        private Button btSave;
        private TextBox tbResolution;
        private Label label13;
        private DateTimePicker resolutionDate;
        private Label label11;
        private TextBox tbDescription;
        private DateTimePicker receivedDate;
        private Label label9;
        private ComboBox cbType;
        private TextBox tbCustName;
        private TextBox tbOrderID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label14;
    }
}
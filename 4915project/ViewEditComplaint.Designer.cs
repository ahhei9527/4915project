namespace _4915project
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
            label15.Location = new Point(28, 64);
            label15.Name = "label15";
            label15.Size = new Size(256, 30);
            label15.TabIndex = 11;
            label15.Text = "View / Edit Complaint";
            // 
            // label1SystemName
            // 
            label1SystemName.AutoSize = true;
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(28, 18);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(760, 46);
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
            panel2.Location = new Point(20, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(1311, 718);
            panel2.TabIndex = 12;
            // 
            // tbSN
            // 
            tbSN.Location = new Point(170, 121);
            tbSN.Name = "tbSN";
            tbSN.ReadOnly = true;
            tbSN.Size = new Size(182, 30);
            tbSN.TabIndex = 32;
            // 
            // cmbUserID
            // 
            cmbUserID.FormattingEnabled = true;
            cmbUserID.Location = new Point(756, 121);
            cmbUserID.Margin = new Padding(5);
            cmbUserID.Name = "cmbUserID";
            cmbUserID.Size = new Size(193, 31);
            cmbUserID.TabIndex = 31;
            // 
            // cmbComID
            // 
            cmbComID.FormattingEnabled = true;
            cmbComID.Location = new Point(170, 9);
            cmbComID.Margin = new Padding(5);
            cmbComID.Name = "cmbComID";
            cmbComID.Size = new Size(182, 31);
            cmbComID.TabIndex = 30;
            cmbComID.SelectedIndexChanged += cmbComID_SelectedIndexChanged;
            // 
            // btClose
            // 
            btClose.Location = new Point(21, 652);
            btClose.Name = "btClose";
            btClose.Size = new Size(112, 34);
            btClose.TabIndex = 29;
            btClose.Text = "Close Case";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btClears
            // 
            btClears.Location = new Point(1166, 652);
            btClears.Name = "btClears";
            btClears.Size = new Size(112, 34);
            btClears.TabIndex = 28;
            btClears.Text = "Clear";
            btClears.UseVisualStyleBackColor = true;
            btClears.Click += btClears_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(1017, 652);
            btSave.Name = "btSave";
            btSave.Size = new Size(112, 34);
            btSave.TabIndex = 27;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // tbResolution
            // 
            tbResolution.Location = new Point(21, 276);
            tbResolution.Multiline = true;
            tbResolution.Name = "tbResolution";
            tbResolution.Size = new Size(1257, 154);
            tbResolution.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 250);
            label13.Name = "label13";
            label13.Size = new Size(269, 23);
            label13.TabIndex = 24;
            label13.Text = "Replacement / Refund Details:";
            // 
            // resolutionDate
            // 
            resolutionDate.Location = new Point(756, 184);
            resolutionDate.Name = "resolutionDate";
            resolutionDate.Size = new Size(193, 30);
            resolutionDate.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(599, 184);
            label11.Name = "label11";
            label11.Size = new Size(151, 23);
            label11.TabIndex = 20;
            label11.Text = "Resolution Date:";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(24, 477);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(1254, 148);
            tbDescription.TabIndex = 17;
            // 
            // receivedDate
            // 
            receivedDate.Location = new Point(756, 12);
            receivedDate.Name = "receivedDate";
            receivedDate.Size = new Size(193, 30);
            receivedDate.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 451);
            label9.Name = "label9";
            label9.Size = new Size(112, 23);
            label9.TabIndex = 15;
            label9.Text = "Description:";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Damage", "Missing", "Return", "Refund" });
            cbType.Location = new Point(170, 183);
            cbType.Name = "cbType";
            cbType.Size = new Size(182, 31);
            cbType.TabIndex = 13;
            // 
            // tbCustName
            // 
            tbCustName.Location = new Point(756, 67);
            tbCustName.Name = "tbCustName";
            tbCustName.Size = new Size(193, 30);
            tbCustName.TabIndex = 11;
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(170, 65);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.ReadOnly = true;
            tbOrderID.Size = new Size(182, 30);
            tbOrderID.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 188);
            label7.Name = "label7";
            label7.Size = new Size(148, 23);
            label7.TabIndex = 6;
            label7.Text = "Complaint Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(634, 126);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 5;
            label6.Text = "Assigned To:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(596, 70);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 4;
            label5.Text = "Customer Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(614, 15);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 3;
            label4.Text = "Date Received:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 126);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 2;
            label3.Text = "Product Serial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 68);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 1;
            label2.Text = "Order ID:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 12);
            label14.Name = "label14";
            label14.Size = new Size(127, 23);
            label14.TabIndex = 0;
            label14.Text = "Complaint ID:";
            // 
            // ViewEditComplaint
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(panel2);
            Controls.Add(label15);
            Controls.Add(label1SystemName);
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

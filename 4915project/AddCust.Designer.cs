namespace _4915project
{
    partial class AddCust
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
            tbCustPhone = new TextBox();
            tbCustAddress = new TextBox();
            tbCustEmail = new TextBox();
            cmbCustCompany = new ComboBox();
            btCustCancel = new Button();
            btCustSave = new Button();
            btCustReset = new Button();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            tbCustName = new TextBox();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tbCustPhone
            // 
            tbCustPhone.Location = new Point(493, 321);
            tbCustPhone.Margin = new Padding(5, 5, 5, 5);
            tbCustPhone.Name = "tbCustPhone";
            tbCustPhone.Size = new Size(355, 30);
            tbCustPhone.TabIndex = 48;
            // 
            // tbCustAddress
            // 
            tbCustAddress.Location = new Point(493, 447);
            tbCustAddress.Margin = new Padding(5, 5, 5, 5);
            tbCustAddress.Multiline = true;
            tbCustAddress.Name = "tbCustAddress";
            tbCustAddress.Size = new Size(355, 50);
            tbCustAddress.TabIndex = 47;
            // 
            // tbCustEmail
            // 
            tbCustEmail.Location = new Point(493, 380);
            tbCustEmail.Margin = new Padding(5, 5, 5, 5);
            tbCustEmail.Name = "tbCustEmail";
            tbCustEmail.Size = new Size(355, 30);
            tbCustEmail.TabIndex = 46;
            // 
            // cmbCustCompany
            // 
            cmbCustCompany.FormattingEnabled = true;
            cmbCustCompany.Location = new Point(493, 269);
            cmbCustCompany.Margin = new Padding(5, 5, 5, 5);
            cmbCustCompany.Name = "cmbCustCompany";
            cmbCustCompany.Size = new Size(355, 31);
            cmbCustCompany.TabIndex = 45;
            // 
            // btCustCancel
            // 
            btCustCancel.Location = new Point(792, 545);
            btCustCancel.Name = "btCustCancel";
            btCustCancel.Size = new Size(112, 34);
            btCustCancel.TabIndex = 43;
            btCustCancel.Text = "Cancel";
            btCustCancel.UseVisualStyleBackColor = true;
            btCustCancel.Click += btCustCancel_Click;
            // 
            // btCustSave
            // 
            btCustSave.Location = new Point(604, 545);
            btCustSave.Name = "btCustSave";
            btCustSave.Size = new Size(112, 34);
            btCustSave.TabIndex = 42;
            btCustSave.Text = "Save";
            btCustSave.UseVisualStyleBackColor = true;
            btCustSave.Click += btCustSave_Click;
            // 
            // btCustReset
            // 
            btCustReset.Location = new Point(376, 545);
            btCustReset.Name = "btCustReset";
            btCustReset.Size = new Size(146, 34);
            btCustReset.TabIndex = 41;
            btCustReset.TabStop = false;
            btCustReset.Text = "Reset Default";
            btCustReset.UseVisualStyleBackColor = true;
            btCustReset.Click += btCustReset_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(394, 272);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(95, 23);
            label11.TabIndex = 40;
            label11.Text = "Company:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(426, 383);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(66, 23);
            label10.TabIndex = 39;
            label10.Text = "Email: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 321);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 38;
            label7.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 447);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 37;
            label6.Text = "Address: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 214);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 36;
            label5.Text = "Name: ";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(tbCustName);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(tbCustPhone);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(tbCustAddress);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(tbCustEmail);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(cmbCustCompany);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(btCustReset);
            panel4.Controls.Add(btCustCancel);
            panel4.Controls.Add(btCustSave);
            panel4.Location = new Point(17, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(1320, 817);
            panel4.TabIndex = 49;
            // 
            // tbCustName
            // 
            tbCustName.Location = new Point(493, 211);
            tbCustName.Margin = new Padding(5, 5, 5, 5);
            tbCustName.Name = "tbCustName";
            tbCustName.Size = new Size(355, 30);
            tbCustName.TabIndex = 49;
            // 
            // AddCust
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(panel4);
            Margin = new Padding(5, 5, 5, 5);
            Name = "AddCust";
            Text = "AddCust";
            Load += AddCust_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbCustPhone;
        private TextBox tbCustAddress;
        private TextBox tbCustEmail;
        private ComboBox cmbCustCompany;
        private Button btCustCancel;
        private Button btCustSave;
        private Button btCustReset;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private TextBox tbCustName;
    }
}

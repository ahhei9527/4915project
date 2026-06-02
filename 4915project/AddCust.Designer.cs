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
            tbCustPhone.Location = new Point(311, 91);
            tbCustPhone.Name = "tbCustPhone";
            tbCustPhone.Size = new Size(121, 23);
            tbCustPhone.TabIndex = 48;
            // 
            // tbCustAddress
            // 
            tbCustAddress.Location = new Point(34, 153);
            tbCustAddress.Name = "tbCustAddress";
            tbCustAddress.Size = new Size(398, 23);
            tbCustAddress.TabIndex = 47;
            // 
            // tbCustEmail
            // 
            tbCustEmail.Location = new Point(91, 88);
            tbCustEmail.Name = "tbCustEmail";
            tbCustEmail.Size = new Size(121, 23);
            tbCustEmail.TabIndex = 46;
            // 
            // cmbCustCompany
            // 
            cmbCustCompany.FormattingEnabled = true;
            cmbCustCompany.Location = new Point(311, 23);
            cmbCustCompany.Name = "cmbCustCompany";
            cmbCustCompany.Size = new Size(121, 23);
            cmbCustCompany.TabIndex = 45;
            // 
            // btCustCancel
            // 
            btCustCancel.Location = new Point(429, 192);
            btCustCancel.Margin = new Padding(2);
            btCustCancel.Name = "btCustCancel";
            btCustCancel.Size = new Size(71, 22);
            btCustCancel.TabIndex = 43;
            btCustCancel.Text = "Cancel";
            btCustCancel.UseVisualStyleBackColor = true;
            btCustCancel.Click += btCustCancel_Click;
            // 
            // btCustSave
            // 
            btCustSave.Location = new Point(311, 192);
            btCustSave.Margin = new Padding(2);
            btCustSave.Name = "btCustSave";
            btCustSave.Size = new Size(71, 22);
            btCustSave.TabIndex = 42;
            btCustSave.Text = "Save";
            btCustSave.UseVisualStyleBackColor = true;
            btCustSave.Click += btCustSave_Click;
            // 
            // btCustReset
            // 
            btCustReset.Location = new Point(179, 192);
            btCustReset.Margin = new Padding(2);
            btCustReset.Name = "btCustReset";
            btCustReset.Size = new Size(93, 22);
            btCustReset.TabIndex = 41;
            btCustReset.TabStop = false;
            btCustReset.Text = "Reset Default";
            btCustReset.UseVisualStyleBackColor = true;
            btCustReset.Click += btCustReset_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(239, 23);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 40;
            label11.Text = "Company: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 88);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 39;
            label10.Text = "Email: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 96);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 38;
            label7.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 135);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 37;
            label6.Text = "Address: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 23);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
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
            panel4.Location = new Point(11, 11);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(529, 250);
            panel4.TabIndex = 49;
            // 
            // tbCustName
            // 
            tbCustName.Location = new Point(88, 20);
            tbCustName.Name = "tbCustName";
            tbCustName.Size = new Size(124, 23);
            tbCustName.TabIndex = 49;
            // 
            // AddCust
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 275);
            Controls.Add(panel4);
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
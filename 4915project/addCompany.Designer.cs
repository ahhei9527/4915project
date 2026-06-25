namespace _4915project
{
    partial class AddCompany
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
            panel2 = new Panel();
            tbComName = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            buttonResetDefault = new Button();
            labelCompanyName = new Label();
            cmbComCurr = new ComboBox();
            labelDefaultLanguage = new Label();
            labelDefaultWarehouse = new Label();
            labelDefaultCurrency = new Label();
            cmbComWH = new ComboBox();
            cmbComLan = new ComboBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tbComName);
            panel2.Controls.Add(buttonCancel);
            panel2.Controls.Add(buttonSave);
            panel2.Controls.Add(buttonResetDefault);
            panel2.Controls.Add(labelCompanyName);
            panel2.Controls.Add(cmbComCurr);
            panel2.Controls.Add(labelDefaultLanguage);
            panel2.Controls.Add(labelDefaultWarehouse);
            panel2.Controls.Add(labelDefaultCurrency);
            panel2.Controls.Add(cmbComWH);
            panel2.Controls.Add(cmbComLan);
            panel2.Location = new Point(11, 11);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 534);
            panel2.TabIndex = 13;
            // 
            // tbComName
            // 
            tbComName.Location = new Point(330, 179);
            tbComName.Name = "tbComName";
            tbComName.Size = new Size(250, 23);
            tbComName.TabIndex = 16;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(504, 355);
            buttonCancel.Margin = new Padding(2, 2, 2, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(71, 22);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(384, 355);
            buttonSave.Margin = new Padding(2, 2, 2, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(71, 22);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonResetDefault
            // 
            buttonResetDefault.Location = new Point(239, 355);
            buttonResetDefault.Margin = new Padding(2, 2, 2, 2);
            buttonResetDefault.Name = "buttonResetDefault";
            buttonResetDefault.Size = new Size(93, 22);
            buttonResetDefault.TabIndex = 13;
            buttonResetDefault.TabStop = false;
            buttonResetDefault.Text = "Reset Default";
            buttonResetDefault.UseVisualStyleBackColor = true;
            buttonResetDefault.Click += buttonResetDefault_Click;
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCompanyName.Location = new Point(229, 181);
            labelCompanyName.Margin = new Padding(2, 0, 2, 0);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(103, 15);
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "Company Name:";
            // 
            // cmbComCurr
            // 
            cmbComCurr.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmbComCurr.FormattingEnabled = true;
            cmbComCurr.Location = new Point(330, 290);
            cmbComCurr.Margin = new Padding(2, 2, 2, 2);
            cmbComCurr.Name = "cmbComCurr";
            cmbComCurr.Size = new Size(250, 23);
            cmbComCurr.TabIndex = 9;
            // 
            // labelDefaultLanguage
            // 
            labelDefaultLanguage.AutoSize = true;
            labelDefaultLanguage.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelDefaultLanguage.Location = new Point(221, 216);
            labelDefaultLanguage.Margin = new Padding(2, 0, 2, 0);
            labelDefaultLanguage.Name = "labelDefaultLanguage";
            labelDefaultLanguage.Size = new Size(111, 15);
            labelDefaultLanguage.TabIndex = 1;
            labelDefaultLanguage.Text = "Default Language:";
            // 
            // labelDefaultWarehouse
            // 
            labelDefaultWarehouse.AutoSize = true;
            labelDefaultWarehouse.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelDefaultWarehouse.Location = new Point(213, 254);
            labelDefaultWarehouse.Margin = new Padding(2, 0, 2, 0);
            labelDefaultWarehouse.Name = "labelDefaultWarehouse";
            labelDefaultWarehouse.Size = new Size(118, 15);
            labelDefaultWarehouse.TabIndex = 4;
            labelDefaultWarehouse.Text = "Default Warehouse:";
            // 
            // labelDefaultCurrency
            // 
            labelDefaultCurrency.AutoSize = true;
            labelDefaultCurrency.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelDefaultCurrency.Location = new Point(225, 292);
            labelDefaultCurrency.Margin = new Padding(2, 0, 2, 0);
            labelDefaultCurrency.Name = "labelDefaultCurrency";
            labelDefaultCurrency.Size = new Size(103, 15);
            labelDefaultCurrency.TabIndex = 3;
            labelDefaultCurrency.Text = "Default Currency:";
            // 
            // cmbComWH
            // 
            cmbComWH.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmbComWH.FormattingEnabled = true;
            cmbComWH.Location = new Point(330, 252);
            cmbComWH.Margin = new Padding(2, 2, 2, 2);
            cmbComWH.Name = "cmbComWH";
            cmbComWH.Size = new Size(250, 23);
            cmbComWH.TabIndex = 7;
            // 
            // cmbComLan
            // 
            cmbComLan.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmbComLan.FormattingEnabled = true;
            cmbComLan.Location = new Point(330, 214);
            cmbComLan.Margin = new Padding(2, 2, 2, 2);
            cmbComLan.Name = "cmbComLan";
            cmbComLan.Size = new Size(250, 23);
            cmbComLan.TabIndex = 6;
            // 
            // AddCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 561);
            Controls.Add(panel2);
            Name = "AddCompany";
            Text = "Add Company";
            Load += AddCompany_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox tbComName;
        private Button buttonCancel;
        private Button buttonSave;
        private Button buttonResetDefault;
        private Label labelCompanyName;
        private ComboBox cmbComCurr;
        private Label labelDefaultLanguage;
        private Label labelDefaultWarehouse;
        private Label labelDefaultCurrency;
        private ComboBox cmbComWH;
        private ComboBox cmbComLan;
    }
}

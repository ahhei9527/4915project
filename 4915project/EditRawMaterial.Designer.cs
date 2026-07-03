namespace _4915project
{
    partial class EditRawMaterial
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
            level = new NumericUpDown();
            cost = new NumericUpDown();
            cmbSupplier = new ComboBox();
            cmbUnit = new ComboBox();
            cmbType = new ComboBox();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbMterialID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cost).BeginInit();
            SuspendLayout();
            // 
            // level
            // 
            level.Location = new Point(755, 331);
            level.Margin = new Padding(5, 5, 5, 5);
            level.Name = "level";
            level.Size = new Size(83, 30);
            level.TabIndex = 38;
            // 
            // cost
            // 
            cost.Location = new Point(520, 331);
            cost.Margin = new Padding(5, 5, 5, 5);
            cost.Name = "cost";
            cost.Size = new Size(83, 30);
            cost.TabIndex = 37;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(520, 431);
            cmbSupplier.Margin = new Padding(5, 5, 5, 5);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(318, 31);
            cmbSupplier.TabIndex = 36;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(520, 277);
            cmbUnit.Margin = new Padding(5, 5, 5, 5);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(318, 31);
            cmbUnit.TabIndex = 35;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(520, 380);
            cmbType.Margin = new Padding(5, 5, 5, 5);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(318, 31);
            cmbType.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(19, 14);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(313, 46);
            label8.TabIndex = 33;
            label8.Text = "Edit Raw Material";
            // 
            // button2
            // 
            button2.Location = new Point(698, 500);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(118, 35);
            button2.TabIndex = 32;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(523, 500);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(118, 35);
            button1.TabIndex = 31;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 434);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 23);
            label7.TabIndex = 30;
            label7.Text = "PreferredSupplier:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(627, 333);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 29;
            label6.Text = "Reorder Level:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 333);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 28;
            label5.Text = "Unit Cost:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 280);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 27;
            label4.Text = "Unit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 383);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 26;
            label3.Text = "Type:";
            // 
            // tbName
            // 
            tbName.Location = new Point(520, 237);
            tbName.Margin = new Padding(5, 5, 5, 5);
            tbName.Name = "tbName";
            tbName.Size = new Size(318, 30);
            tbName.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 237);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 24;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 204);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 22;
            label1.Text = "MaterialID:";
            // 
            // cmbMterialID
            // 
            cmbMterialID.FormattingEnabled = true;
            cmbMterialID.Location = new Point(520, 197);
            cmbMterialID.Margin = new Padding(5, 5, 5, 5);
            cmbMterialID.Name = "cmbMterialID";
            cmbMterialID.Size = new Size(318, 31);
            cmbMterialID.TabIndex = 39;
            cmbMterialID.SelectedIndexChanged += cmbMterialID_SelectedIndexChanged;
            // 
            // EditRawMaterial
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(cmbMterialID);
            Controls.Add(level);
            Controls.Add(cost);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbUnit);
            Controls.Add(cmbType);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "EditRawMaterial";
            Text = "EditRawMaterial";
            Load += EditRawMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)level).EndInit();
            ((System.ComponentModel.ISupportInitialize)cost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown level;
        private NumericUpDown cost;
        private ComboBox cmbSupplier;
        private ComboBox cmbUnit;
        private ComboBox cmbType;
        private Label label8;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tbName;
        private Label label2;
        private Label label1;
        private ComboBox cmbMterialID;
    }
}
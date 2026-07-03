namespace _4915project
{
    partial class CreateRawMaterial
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
            label1 = new Label();
            tbMterialID = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            cmbType = new ComboBox();
            cmbUnit = new ComboBox();
            cmbSupplier = new ComboBox();
            cost = new NumericUpDown();
            level = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)level).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 204);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 0;
            label1.Text = "MaterialID:";
            // 
            // tbMterialID
            // 
            tbMterialID.Location = new Point(520, 197);
            tbMterialID.Margin = new Padding(5, 5, 5, 5);
            tbMterialID.Name = "tbMterialID";
            tbMterialID.Size = new Size(318, 30);
            tbMterialID.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(520, 237);
            tbName.Margin = new Padding(5, 5, 5, 5);
            tbName.Name = "tbName";
            tbName.Size = new Size(318, 30);
            tbName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 237);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 383);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 4;
            label3.Text = "Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 280);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 6;
            label4.Text = "Unit:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 333);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 8;
            label5.Text = "Unit Cost:";
       
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(627, 333);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 10;
            label6.Text = "Reorder Level:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 434);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 23);
            label7.TabIndex = 12;
            label7.Text = "PreferredSupplier:";
            // 
            // button1
            // 
            button1.Location = new Point(523, 500);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(118, 35);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(698, 500);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(118, 35);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(19, 14);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(358, 46);
            label8.TabIndex = 16;
            label8.Text = "Create Raw Material";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(520, 380);
            cmbType.Margin = new Padding(5, 5, 5, 5);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(318, 31);
            cmbType.TabIndex = 17;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(520, 277);
            cmbUnit.Margin = new Padding(5, 5, 5, 5);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(318, 31);
            cmbUnit.TabIndex = 18;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(520, 431);
            cmbSupplier.Margin = new Padding(5, 5, 5, 5);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(318, 31);
            cmbSupplier.TabIndex = 19;
            // 
            // cost
            // 
            cost.Location = new Point(520, 331);
            cost.Margin = new Padding(5, 5, 5, 5);
            cost.Name = "cost";
            cost.Size = new Size(83, 30);
            cost.TabIndex = 20;
            cost.ValueChanged += cost_ValueChanged;
            // 
            // level
            // 
            level.Location = new Point(755, 331);
            level.Margin = new Padding(5, 5, 5, 5);
            level.Name = "level";
            level.Size = new Size(83, 30);
            level.TabIndex = 21;
            // 
            // CreateRawMaterial
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
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
            Controls.Add(tbMterialID);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "CreateRawMaterial";
            Text = "CreateRawMaterial";
            Load += CreateRawMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)level).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbMterialID;
        private TextBox tbName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Label label8;
        private ComboBox cmbType;
        private ComboBox cmbUnit;
        private ComboBox cmbSupplier;
        private NumericUpDown cost;
        private NumericUpDown level;
    }
}
namespace ITP4915M
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
            panel1 = new Panel();
            button5 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            buttonHome = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            label6 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ColumnOrderID = new DataGridViewTextBoxColumn();
            ColumnExpectedDate = new DataGridViewTextBoxColumn();
            ColumnCustomer = new DataGridViewTextBoxColumn();
            ColumnDeliveryAddress = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            comboBox4 = new ComboBox();
            textBox3 = new TextBox();
            button6 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1SystemName
            // 
            label1SystemName.AutoSize = true;
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(28, 19);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(760, 46);
            label1SystemName.TabIndex = 2;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(buttonHome);
            panel1.Location = new Point(28, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 422);
            panel1.TabIndex = 3;
            // 
            // button5
            // 
            button5.Location = new Point(7, 255);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 5;
            button5.Text = "Setting";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(7, 78);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Order";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(7, 195);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 4;
            button4.Text = "Complaints";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(7, 134);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "Inventory";
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            buttonHome.Location = new Point(7, 23);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(112, 34);
            buttonHome.TabIndex = 4;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(36, 76);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 4;
            label1.Text = "Logistics";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(265, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1036, 603);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkGray;
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1028, 567);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Delivery Scheduling";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGray;
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1028, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Status & Goods Received";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gainsboro;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(10, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1008, 541);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Schedule Delivery";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 199);
            label6.Name = "label6";
            label6.Size = new Size(328, 23);
            label6.TabIndex = 9;
            label6.Text = "Pending Orders (Ready for Shipment)";
            // 
            // button1
            // 
            button1.Location = new Point(265, 139);
            button1.Name = "button1";
            button1.Size = new Size(553, 34);
            button1.TabIndex = 8;
            button1.Text = "Confirm Schedule & Generate Delivery Note & Reply Slip";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnOrderID, ColumnExpectedDate, ColumnCustomer, ColumnDeliveryAddress });
            dataGridView1.Location = new Point(12, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(975, 285);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnOrderID
            // 
            ColumnOrderID.HeaderText = "Order ID";
            ColumnOrderID.MinimumWidth = 8;
            ColumnOrderID.Name = "ColumnOrderID";
            ColumnOrderID.Width = 150;
            // 
            // ColumnExpectedDate
            // 
            ColumnExpectedDate.HeaderText = "Expected Del. Date";
            ColumnExpectedDate.MinimumWidth = 8;
            ColumnExpectedDate.Name = "ColumnExpectedDate";
            ColumnExpectedDate.Width = 150;
            // 
            // ColumnCustomer
            // 
            ColumnCustomer.HeaderText = "ColumnCustomer";
            ColumnCustomer.MinimumWidth = 8;
            ColumnCustomer.Name = "ColumnCustomer";
            ColumnCustomer.Width = 150;
            // 
            // ColumnDeliveryAddress
            // 
            ColumnDeliveryAddress.HeaderText = "Delivery Address";
            ColumnDeliveryAddress.MinimumWidth = 8;
            ColumnDeliveryAddress.Name = "ColumnDeliveryAddress";
            ColumnDeliveryAddress.Width = 150;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(147, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 30);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(587, 75);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 31);
            comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(587, 33);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 31);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 31);
            comboBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(515, 78);
            label5.Name = "label5";
            label5.Size = new Size(67, 23);
            label5.TabIndex = 3;
            label5.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 33);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 2;
            label4.Text = "Driver:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 75);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 1;
            label3.Text = "Vehicle No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 0;
            label2.Text = "Dispatch Date:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(10, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1008, 541);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ongoing Deliveries";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 162);
            label7.Name = "label7";
            label7.Size = new Size(328, 23);
            label7.TabIndex = 9;
            label7.Text = "Pending Orders (Ready for Shipment)";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView2.Location = new Point(12, 188);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(975, 285);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Order ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Expected Del. Date";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "ColumnCustomer";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Delivery Address";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 117);
            label8.Name = "label8";
            label8.Size = new Size(273, 23);
            label8.TabIndex = 3;
            label8.Text = "Remarks / Shortage / Damage:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 74);
            label9.Name = "label9";
            label9.Size = new Size(134, 23);
            label9.TabIndex = 2;
            label9.Text = "Status Update:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(486, 74);
            label10.Name = "label10";
            label10.Size = new Size(136, 23);
            label10.TabIndex = 1;
            label10.Text = "Received Date:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 36);
            label11.Name = "label11";
            label11.Size = new Size(107, 23);
            label11.TabIndex = 0;
            label11.Text = "Delivery ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(534, 30);
            label12.Name = "label12";
            label12.Size = new Size(88, 23);
            label12.TabIndex = 10;
            label12.Text = "Order ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 33);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(161, 30);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(628, 27);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(182, 30);
            textBox2.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(144, 74);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(196, 30);
            dateTimePicker2.TabIndex = 13;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Delivered", "Failed" });
            comboBox4.Location = new Point(628, 71);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(182, 31);
            comboBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(291, 114);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(519, 45);
            textBox3.TabIndex = 15;
            // 
            // button6
            // 
            button6.Location = new Point(324, 489);
            button6.Name = "button6";
            button6.Size = new Size(353, 34);
            button6.TabIndex = 16;
            button6.Text = "Update Status & Complete Order";
            button6.UseVisualStyleBackColor = true;
            // 
            // FormLogistics
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label1SystemName);
            Name = "FormLogistics";
            Text = "Logistics";
            Load += FormLogistics_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1SystemName;
        private Panel panel1;
        private Button button5;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button buttonHome;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Label label6;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnOrderID;
        private DataGridViewTextBoxColumn ColumnExpectedDate;
        private DataGridViewTextBoxColumn ColumnCustomer;
        private DataGridViewTextBoxColumn ColumnDeliveryAddress;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label12;
        private Label label7;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button6;
        private TextBox textBox3;
        private ComboBox comboBox4;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
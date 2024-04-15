namespace WinFormsApp1
{
    partial class Form3
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
            cancelbutton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            insertbutton = new Button();
            monthCalendar1 = new MonthCalendar();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            DepartLabel = new Label();
            NameLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cancelbutton
            // 
            cancelbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelbutton.BackColor = Color.Salmon;
            cancelbutton.DialogResult = DialogResult.Cancel;
            cancelbutton.Location = new Point(427, 12);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(77, 52);
            cancelbutton.TabIndex = 4;
            cancelbutton.Text = "取消";
            cancelbutton.UseVisualStyleBackColor = false;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 270);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(492, 148);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 102);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 2;
            label1.Text = "工令:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 1;
            textBox2.Leave += textBox2_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(12, 247);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "工作內容:";
            // 
            // insertbutton
            // 
            insertbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insertbutton.BackColor = Color.LawnGreen;
            insertbutton.DialogResult = DialogResult.OK;
            insertbutton.Location = new Point(344, 12);
            insertbutton.Name = "insertbutton";
            insertbutton.Size = new Size(77, 52);
            insertbutton.TabIndex = 3;
            insertbutton.Text = "新增";
            insertbutton.UseVisualStyleBackColor = false;
            insertbutton.Click += insertbutton_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            monthCalendar1.Location = new Point(284, 102);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 5;
            monthCalendar1.TabStop = false;
            monthCalendar1.TodayDate = new DateTime(0L);
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(284, 56);
            label3.Name = "label3";
            label3.Size = new Size(45, 40);
            label3.TabIndex = 6;
            label3.Text = "執行\r\n當日:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 2;
            label4.Text = "工令名稱:";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(91, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 23);
            textBox3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(12, 160);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 2;
            label5.Text = "主單元:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.Location = new Point(12, 189);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 2;
            label6.Text = "加工類別:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(12, 219);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 2;
            label8.Text = "花費時間:";
            // 
            // DepartLabel
            // 
            DepartLabel.AutoSize = true;
            DepartLabel.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            DepartLabel.Location = new Point(146, 22);
            DepartLabel.Name = "DepartLabel";
            DepartLabel.Size = new Size(54, 26);
            DepartLabel.TabIndex = 7;
            DepartLabel.Text = "部門";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            NameLabel.Location = new Point(9, 22);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(34, 26);
            NameLabel.TabIndex = 8;
            NameLabel.Text = "ID";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown1.Location = new Point(91, 219);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 24);
            numericUpDown1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(91, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(91, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 23);
            comboBox2.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox4.Enabled = false;
            textBox4.Location = new Point(344, 73);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 23);
            textBox4.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 430);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(DepartLabel);
            Controls.Add(NameLabel);
            Controls.Add(label3);
            Controls.Add(monthCalendar1);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(insertbutton);
            Controls.Add(cancelbutton);
            Name = "Form3";
            Text = "新增資料視窗";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelbutton;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button insertbutton;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label DepartLabel;
        private Label NameLabel;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox4;
    }
}
namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            NameLabel = new Label();
            DepartLabel = new Label();
            dataGridView1 = new DataGridView();
            insertbutton = new Button();
            refrashButton = new Button();
            EscapeButton = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(632, 1);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 1;
            button1.Text = "返回";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            NameLabel.Location = new Point(12, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(34, 26);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "ID";
            NameLabel.Click += label1_Click;
            // 
            // DepartLabel
            // 
            DepartLabel.AutoSize = true;
            DepartLabel.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            DepartLabel.Location = new Point(12, 44);
            DepartLabel.Name = "DepartLabel";
            DepartLabel.Size = new Size(54, 26);
            DepartLabel.TabIndex = 1;
            DepartLabel.Text = "部門";
            DepartLabel.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 355);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // insertbutton
            // 
            insertbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insertbutton.Location = new Point(410, 46);
            insertbutton.Name = "insertbutton";
            insertbutton.Size = new Size(105, 28);
            insertbutton.TabIndex = 0;
            insertbutton.Text = "新增資料";
            insertbutton.UseVisualStyleBackColor = true;
            insertbutton.Click += insertbutton_Click;
            // 
            // refrashButton
            // 
            refrashButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refrashButton.BackgroundImage = (Image)resources.GetObject("refrashButton.BackgroundImage");
            refrashButton.BackgroundImageLayout = ImageLayout.Zoom;
            refrashButton.Location = new Point(753, 42);
            refrashButton.Name = "refrashButton";
            refrashButton.Size = new Size(35, 35);
            refrashButton.TabIndex = 2;
            refrashButton.UseVisualStyleBackColor = true;
            refrashButton.Click += refrashButton_Click;
            // 
            // EscapeButton
            // 
            EscapeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EscapeButton.BackColor = Color.Chocolate;
            EscapeButton.ForeColor = SystemColors.ButtonHighlight;
            EscapeButton.Location = new Point(713, 1);
            EscapeButton.Name = "EscapeButton";
            EscapeButton.Size = new Size(75, 35);
            EscapeButton.TabIndex = 3;
            EscapeButton.Text = "下班";
            EscapeButton.UseVisualStyleBackColor = false;
            EscapeButton.Click += EscapeBtn;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(521, 46);
            button2.Name = "button2";
            button2.Size = new Size(105, 28);
            button2.TabIndex = 0;
            button2.Text = "修改資料";
            button2.UseVisualStyleBackColor = true;
            button2.Click += updatebutton_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(632, 46);
            button3.Name = "button3";
            button3.Size = new Size(105, 28);
            button3.TabIndex = 0;
            button3.Text = "刪除資料";
            button3.UseVisualStyleBackColor = true;
            button3.Click += deletebutton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(refrashButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(insertbutton);
            Controls.Add(dataGridView1);
            Controls.Add(DepartLabel);
            Controls.Add(NameLabel);
            Controls.Add(EscapeButton);
            Controls.Add(button1);
            Name = "Form2";
            Text = "偉詳工時系統";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label NameLabel;
        private Label DepartLabel;
        private DataGridView dataGridView1;
        private Button insertbutton;
        private Button refrashButton;
        private Button EscapeButton;
        private Button button2;
        private Button button3;
    }
}
namespace MYAPP
{
    partial class FrmDoUong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoUong));
            label1 = new Label();
            txtMaDoUong = new TextBox();
            TenDoUong = new Label();
            txtTenDoUong = new TextBox();
            label2 = new Label();
            txtGia = new TextBox();
            label3 = new Label();
            txtKichCo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 56);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Đồ Uống";
            label1.Click += label1_Click;
            // 
            // txtMaDoUong
            // 
            txtMaDoUong.Location = new Point(411, 53);
            txtMaDoUong.Name = "txtMaDoUong";
            txtMaDoUong.Size = new Size(182, 27);
            txtMaDoUong.TabIndex = 1;
            // 
            // TenDoUong
            // 
            TenDoUong.AutoSize = true;
            TenDoUong.Location = new Point(317, 109);
            TenDoUong.Name = "TenDoUong";
            TenDoUong.Size = new Size(96, 20);
            TenDoUong.TabIndex = 2;
            TenDoUong.Text = "Tên Đồ Uống";
            TenDoUong.Click += TenDoUong_Click;
            // 
            // txtTenDoUong
            // 
            txtTenDoUong.Location = new Point(411, 109);
            txtTenDoUong.Name = "txtTenDoUong";
            txtTenDoUong.Size = new Size(182, 27);
            txtTenDoUong.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 161);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 4;
            label2.Text = "Gía";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(411, 161);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(182, 27);
            txtGia.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 216);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 6;
            label3.Text = "Kích Cỡ";
            // 
            // txtKichCo
            // 
            txtKichCo.Location = new Point(411, 216);
            txtKichCo.Name = "txtKichCo";
            txtKichCo.Size = new Size(182, 27);
            txtKichCo.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(257, 315);
            button1.Name = "button1";
            button1.Size = new Size(121, 32);
            button1.TabIndex = 8;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLUU_Click;
            // 
            // button2
            // 
            button2.Location = new Point(588, 315);
            button2.Name = "button2";
            button2.Size = new Size(137, 32);
            button2.TabIndex = 9;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnXOA_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(204, 386);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(564, 243);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button3
            // 
            button3.Location = new Point(429, 315);
            button3.Name = "button3";
            button3.Size = new Size(120, 32);
            button3.TabIndex = 11;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSUA_Click;
            // 
            // FrmDoUong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(968, 655);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtKichCo);
            Controls.Add(label3);
            Controls.Add(txtGia);
            Controls.Add(label2);
            Controls.Add(txtTenDoUong);
            Controls.Add(TenDoUong);
            Controls.Add(txtMaDoUong);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDoUong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Bán Hàng";
            FormClosing += FormDoUong_FormClosing;
            Load += FormDoUong_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaDoUong;
        private Label TenDoUong;
        private TextBox txtTenDoUong;
        private Label label2;
        private TextBox txtGia;
        private Label label3;
        private TextBox txtKichCo;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
    }
}

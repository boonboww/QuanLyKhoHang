namespace CS464O_Nhom7.GUI
{
    partial class frm_HoaDon
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.MaP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.dateTime_ngayvao = new System.Windows.Forms.DateTimePicker();
            this.dateTime_ngaydi = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_songay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoanToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1177, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.taiKhoanToolStripMenuItem.Text = "Tai Khoan";
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.dangXuatToolStripMenuItem.Text = "Dang Xuat";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.thoatToolStripMenuItem.Text = "Thoat";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachHangToolStripMenuItem,
            this.phongToolStripMenuItem,
            this.HDToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.khachHangToolStripMenuItem.Text = "Khách Hàng";
            // 
            // phongToolStripMenuItem
            // 
            this.phongToolStripMenuItem.Name = "phongToolStripMenuItem";
            this.phongToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.phongToolStripMenuItem.Text = "Phòng";
            // 
            // HDToolStripMenuItem
            // 
            this.HDToolStripMenuItem.Name = "HDToolStripMenuItem";
            this.HDToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.HDToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã HD";
            // 
            // MaP
            // 
            this.MaP.AutoSize = true;
            this.MaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaP.Location = new System.Drawing.Point(37, 116);
            this.MaP.Name = "MaP";
            this.MaP.Size = new System.Drawing.Size(99, 32);
            this.MaP.TabIndex = 24;
            this.MaP.Text = "Mã SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày Vào";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ngày Đi";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahd.Location = new System.Drawing.Point(191, 53);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(173, 38);
            this.txt_mahd.TabIndex = 28;
            // 
            // txt_masp
            // 
            this.txt_masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masp.Location = new System.Drawing.Point(191, 108);
            this.txt_masp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(173, 38);
            this.txt_masp.TabIndex = 29;
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(191, 169);
            this.txt_makh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(173, 38);
            this.txt_makh.TabIndex = 30;
            // 
            // dateTime_ngayvao
            // 
            this.dateTime_ngayvao.CustomFormat = "dd/MM/yyyy";
            this.dateTime_ngayvao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_ngayvao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_ngayvao.Location = new System.Drawing.Point(191, 220);
            this.dateTime_ngayvao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_ngayvao.Name = "dateTime_ngayvao";
            this.dateTime_ngayvao.Size = new System.Drawing.Size(200, 38);
            this.dateTime_ngayvao.TabIndex = 31;
            this.dateTime_ngayvao.Value = new System.DateTime(2024, 6, 8, 4, 50, 0, 0);
            this.dateTime_ngayvao.ValueChanged += new System.EventHandler(this.dateTime_ngayvao_ValueChanged);
            // 
            // dateTime_ngaydi
            // 
            this.dateTime_ngaydi.CustomFormat = "dd/MM/yyyy";
            this.dateTime_ngaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_ngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_ngaydi.Location = new System.Drawing.Point(191, 281);
            this.dateTime_ngaydi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_ngaydi.Name = "dateTime_ngaydi";
            this.dateTime_ngaydi.Size = new System.Drawing.Size(200, 38);
            this.dateTime_ngaydi.TabIndex = 32;
            this.dateTime_ngaydi.ValueChanged += new System.EventHandler(this.dateTime_ngaydi_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 482);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(44, 395);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(103, 49);
            this.btn_them.TabIndex = 34;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(191, 395);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(156, 49);
            this.btn_Sua.TabIndex = 35;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(44, 470);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(156, 49);
            this.btn_Xoa.TabIndex = 36;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_songay
            // 
            this.txt_songay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_songay.Location = new System.Drawing.Point(171, 332);
            this.txt_songay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_songay.Name = "txt_songay";
            this.txt_songay.Size = new System.Drawing.Size(108, 38);
            this.txt_songay.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Số Ngày";
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1177, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_songay);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTime_ngaydi);
            this.Controls.Add(this.dateTime_ngayvao);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_mahd;
        public System.Windows.Forms.TextBox txt_masp;
        public System.Windows.Forms.TextBox txt_makh;
        public System.Windows.Forms.DateTimePicker dateTime_ngayvao;
        public System.Windows.Forms.DateTimePicker dateTime_ngaydi;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        public System.Windows.Forms.TextBox txt_songay;
        private System.Windows.Forms.Label label2;
    }
}
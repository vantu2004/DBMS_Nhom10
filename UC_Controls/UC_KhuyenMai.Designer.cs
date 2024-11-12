namespace Nhom11
{
    partial class UC_KhuyenMai
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcl_SanPham = new System.Windows.Forms.TabControl();
            this.tab_DanhSachKhuyenMai = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachMaKhuyenMai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_TimMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.btn_TìmMaKhuyenMai = new System.Windows.Forms.Button();
            this.btn_SuaMaKhuyenMai = new System.Windows.Forms.Button();
            this.btn_XoaMaKhuyenMai = new System.Windows.Forms.Button();
            this.tab_TaoKhuyenMai = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_SoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_ChietKhau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_TenChuongTrinh = new System.Windows.Forms.TextBox();
            this.tcl_SanPham.SuspendLayout();
            this.tab_DanhSachKhuyenMai.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMaKhuyenMai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tab_TaoKhuyenMai.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcl_SanPham
            // 
            this.tcl_SanPham.Controls.Add(this.tab_DanhSachKhuyenMai);
            this.tcl_SanPham.Controls.Add(this.tab_TaoKhuyenMai);
            this.tcl_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcl_SanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcl_SanPham.Location = new System.Drawing.Point(0, 0);
            this.tcl_SanPham.Name = "tcl_SanPham";
            this.tcl_SanPham.SelectedIndex = 0;
            this.tcl_SanPham.Size = new System.Drawing.Size(1674, 1055);
            this.tcl_SanPham.TabIndex = 3;
            // 
            // tab_DanhSachKhuyenMai
            // 
            this.tab_DanhSachKhuyenMai.Controls.Add(this.groupBox2);
            this.tab_DanhSachKhuyenMai.Controls.Add(this.groupBox1);
            this.tab_DanhSachKhuyenMai.Location = new System.Drawing.Point(4, 33);
            this.tab_DanhSachKhuyenMai.Margin = new System.Windows.Forms.Padding(10);
            this.tab_DanhSachKhuyenMai.Name = "tab_DanhSachKhuyenMai";
            this.tab_DanhSachKhuyenMai.Padding = new System.Windows.Forms.Padding(10);
            this.tab_DanhSachKhuyenMai.Size = new System.Drawing.Size(1666, 1018);
            this.tab_DanhSachKhuyenMai.TabIndex = 0;
            this.tab_DanhSachKhuyenMai.Text = "Danh sách mã khuyến mãi";
            this.tab_DanhSachKhuyenMai.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DanhSachMaKhuyenMai);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(10, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1646, 894);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mã khuyến mãi";
            // 
            // dgv_DanhSachMaKhuyenMai
            // 
            this.dgv_DanhSachMaKhuyenMai.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachMaKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachMaKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachMaKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachMaKhuyenMai.Location = new System.Drawing.Point(3, 24);
            this.dgv_DanhSachMaKhuyenMai.Name = "dgv_DanhSachMaKhuyenMai";
            this.dgv_DanhSachMaKhuyenMai.RowHeadersWidth = 51;
            this.dgv_DanhSachMaKhuyenMai.RowTemplate.Height = 24;
            this.dgv_DanhSachMaKhuyenMai.Size = new System.Drawing.Size(1640, 867);
            this.dgv_DanhSachMaKhuyenMai.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_TimMaKhuyenMai);
            this.groupBox1.Controls.Add(this.btn_TìmMaKhuyenMai);
            this.groupBox1.Controls.Add(this.btn_SuaMaKhuyenMai);
            this.groupBox1.Controls.Add(this.btn_XoaMaKhuyenMai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1646, 104);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // tbx_TimMaKhuyenMai
            // 
            this.tbx_TimMaKhuyenMai.ForeColor = System.Drawing.Color.DarkGray;
            this.tbx_TimMaKhuyenMai.Location = new System.Drawing.Point(42, 40);
            this.tbx_TimMaKhuyenMai.Name = "tbx_TimMaKhuyenMai";
            this.tbx_TimMaKhuyenMai.Size = new System.Drawing.Size(263, 28);
            this.tbx_TimMaKhuyenMai.TabIndex = 3;
            this.tbx_TimMaKhuyenMai.Text = "Nhập mã khuyến mãi";
            // 
            // btn_TìmMaKhuyenMai
            // 
            this.btn_TìmMaKhuyenMai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_TìmMaKhuyenMai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TìmMaKhuyenMai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_TìmMaKhuyenMai.Location = new System.Drawing.Point(320, 40);
            this.btn_TìmMaKhuyenMai.Name = "btn_TìmMaKhuyenMai";
            this.btn_TìmMaKhuyenMai.Size = new System.Drawing.Size(110, 32);
            this.btn_TìmMaKhuyenMai.TabIndex = 4;
            this.btn_TìmMaKhuyenMai.Text = "Tìm kiếm";
            this.btn_TìmMaKhuyenMai.UseVisualStyleBackColor = false;
            this.btn_TìmMaKhuyenMai.Click += new System.EventHandler(this.btn_TìmMaKhuyenMai_Click);
            // 
            // btn_SuaMaKhuyenMai
            // 
            this.btn_SuaMaKhuyenMai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_SuaMaKhuyenMai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaMaKhuyenMai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_SuaMaKhuyenMai.Location = new System.Drawing.Point(436, 40);
            this.btn_SuaMaKhuyenMai.Name = "btn_SuaMaKhuyenMai";
            this.btn_SuaMaKhuyenMai.Size = new System.Drawing.Size(110, 32);
            this.btn_SuaMaKhuyenMai.TabIndex = 6;
            this.btn_SuaMaKhuyenMai.Text = "Sửa";
            this.btn_SuaMaKhuyenMai.UseVisualStyleBackColor = false;
            this.btn_SuaMaKhuyenMai.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_XoaMaKhuyenMai
            // 
            this.btn_XoaMaKhuyenMai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_XoaMaKhuyenMai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaMaKhuyenMai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_XoaMaKhuyenMai.Location = new System.Drawing.Point(552, 40);
            this.btn_XoaMaKhuyenMai.Name = "btn_XoaMaKhuyenMai";
            this.btn_XoaMaKhuyenMai.Size = new System.Drawing.Size(110, 32);
            this.btn_XoaMaKhuyenMai.TabIndex = 5;
            this.btn_XoaMaKhuyenMai.Text = "Xóa";
            this.btn_XoaMaKhuyenMai.UseVisualStyleBackColor = false;
            // 
            // tab_TaoKhuyenMai
            // 
            this.tab_TaoKhuyenMai.Controls.Add(this.button1);
            this.tab_TaoKhuyenMai.Controls.Add(this.dtp_NgayKetThuc);
            this.tab_TaoKhuyenMai.Controls.Add(this.dtp_NgayBatDau);
            this.tab_TaoKhuyenMai.Controls.Add(this.label7);
            this.tab_TaoKhuyenMai.Controls.Add(this.label8);
            this.tab_TaoKhuyenMai.Controls.Add(this.label5);
            this.tab_TaoKhuyenMai.Controls.Add(this.label1);
            this.tab_TaoKhuyenMai.Controls.Add(this.tbx_SoLuong);
            this.tab_TaoKhuyenMai.Controls.Add(this.label6);
            this.tab_TaoKhuyenMai.Controls.Add(this.tbx_ChietKhau);
            this.tab_TaoKhuyenMai.Controls.Add(this.label9);
            this.tab_TaoKhuyenMai.Controls.Add(this.tbx_TenChuongTrinh);
            this.tab_TaoKhuyenMai.Location = new System.Drawing.Point(4, 33);
            this.tab_TaoKhuyenMai.Name = "tab_TaoKhuyenMai";
            this.tab_TaoKhuyenMai.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TaoKhuyenMai.Size = new System.Drawing.Size(1666, 1018);
            this.tab_TaoKhuyenMai.TabIndex = 2;
            this.tab_TaoKhuyenMai.Text = "Tạo khuyến mãi";
            this.tab_TaoKhuyenMai.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(597, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 32);
            this.button1.TabIndex = 39;
            this.button1.Text = "Hoàn thành";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(597, 259);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(400, 32);
            this.dtp_NgayKetThuc.TabIndex = 38;
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(100, 259);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(400, 32);
            this.dtp_NgayBatDau.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(100, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(597, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(888, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "% (Phần trăm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(100, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Số lượng áp dụng";
            // 
            // tbx_SoLuong
            // 
            this.tbx_SoLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_SoLuong.Location = new System.Drawing.Point(100, 162);
            this.tbx_SoLuong.Name = "tbx_SoLuong";
            this.tbx_SoLuong.Size = new System.Drawing.Size(400, 32);
            this.tbx_SoLuong.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(597, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Chiết khấu";
            // 
            // tbx_ChietKhau
            // 
            this.tbx_ChietKhau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_ChietKhau.Location = new System.Drawing.Point(597, 66);
            this.tbx_ChietKhau.Name = "tbx_ChietKhau";
            this.tbx_ChietKhau.Size = new System.Drawing.Size(285, 32);
            this.tbx_ChietKhau.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(100, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tên chương trình khuyến mãi";
            // 
            // tbx_TenChuongTrinh
            // 
            this.tbx_TenChuongTrinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_TenChuongTrinh.Location = new System.Drawing.Point(100, 66);
            this.tbx_TenChuongTrinh.Name = "tbx_TenChuongTrinh";
            this.tbx_TenChuongTrinh.Size = new System.Drawing.Size(400, 32);
            this.tbx_TenChuongTrinh.TabIndex = 28;
            // 
            // UC_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcl_SanPham);
            this.Name = "UC_KhuyenMai";
            this.Size = new System.Drawing.Size(1674, 1055);
            this.tcl_SanPham.ResumeLayout(false);
            this.tab_DanhSachKhuyenMai.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMaKhuyenMai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_TaoKhuyenMai.ResumeLayout(false);
            this.tab_TaoKhuyenMai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tcl_SanPham;
        public System.Windows.Forms.TabPage tab_DanhSachKhuyenMai;
        public System.Windows.Forms.Button btn_XoaMaKhuyenMai;
        public System.Windows.Forms.Button btn_TìmMaKhuyenMai;
        public System.Windows.Forms.TextBox tbx_TimMaKhuyenMai;
        public System.Windows.Forms.DataGridView dgv_DanhSachMaKhuyenMai;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbx_SoLuong;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbx_ChietKhau;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbx_TenChuongTrinh;
        public System.Windows.Forms.Button btn_SuaMaKhuyenMai;
        public System.Windows.Forms.TabPage tab_TaoKhuyenMai;
        public System.Windows.Forms.DateTimePicker dtp_NgayKetThuc;
        public System.Windows.Forms.DateTimePicker dtp_NgayBatDau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

namespace Nhom11
{
    partial class UC_NhanVien
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
            this.tab_DanhSachNhanVien = new System.Windows.Forms.TabPage();
            this.btn_SuaNhanVien = new System.Windows.Forms.Button();
            this.btn_XoaNhanVien = new System.Windows.Forms.Button();
            this.btn_TìmSoDienThoai = new System.Windows.Forms.Button();
            this.tbx_TimSoDienThoai = new System.Windows.Forms.TextBox();
            this.dgv_DanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.tab_TaoNhanVien = new System.Windows.Forms.TabPage();
            this.cbx_ChucVu = new System.Windows.Forms.ComboBox();
            this.btn_HoanThanh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Gmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_MatKhau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_TenNhanVien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_SoDienThoai = new System.Windows.Forms.TextBox();
            this.tcl_SanPham.SuspendLayout();
            this.tab_DanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNhanVien)).BeginInit();
            this.tab_TaoNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcl_SanPham
            // 
            this.tcl_SanPham.Controls.Add(this.tab_DanhSachNhanVien);
            this.tcl_SanPham.Controls.Add(this.tab_TaoNhanVien);
            this.tcl_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcl_SanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcl_SanPham.Location = new System.Drawing.Point(0, 0);
            this.tcl_SanPham.Name = "tcl_SanPham";
            this.tcl_SanPham.SelectedIndex = 0;
            this.tcl_SanPham.Size = new System.Drawing.Size(1104, 726);
            this.tcl_SanPham.TabIndex = 4;
            // 
            // tab_DanhSachNhanVien
            // 
            this.tab_DanhSachNhanVien.Controls.Add(this.btn_SuaNhanVien);
            this.tab_DanhSachNhanVien.Controls.Add(this.btn_XoaNhanVien);
            this.tab_DanhSachNhanVien.Controls.Add(this.btn_TìmSoDienThoai);
            this.tab_DanhSachNhanVien.Controls.Add(this.tbx_TimSoDienThoai);
            this.tab_DanhSachNhanVien.Controls.Add(this.dgv_DanhSachNhanVien);
            this.tab_DanhSachNhanVien.Location = new System.Drawing.Point(4, 33);
            this.tab_DanhSachNhanVien.Margin = new System.Windows.Forms.Padding(10);
            this.tab_DanhSachNhanVien.Name = "tab_DanhSachNhanVien";
            this.tab_DanhSachNhanVien.Padding = new System.Windows.Forms.Padding(10);
            this.tab_DanhSachNhanVien.Size = new System.Drawing.Size(1096, 689);
            this.tab_DanhSachNhanVien.TabIndex = 0;
            this.tab_DanhSachNhanVien.Text = "Danh sách nhân viên";
            this.tab_DanhSachNhanVien.UseVisualStyleBackColor = true;
            // 
            // btn_SuaNhanVien
            // 
            this.btn_SuaNhanVien.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_SuaNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaNhanVien.Location = new System.Drawing.Point(857, 13);
            this.btn_SuaNhanVien.Name = "btn_SuaNhanVien";
            this.btn_SuaNhanVien.Size = new System.Drawing.Size(110, 32);
            this.btn_SuaNhanVien.TabIndex = 6;
            this.btn_SuaNhanVien.Text = "Sửa";
            this.btn_SuaNhanVien.UseVisualStyleBackColor = false;
            this.btn_SuaNhanVien.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_XoaNhanVien
            // 
            this.btn_XoaNhanVien.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_XoaNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaNhanVien.Location = new System.Drawing.Point(973, 13);
            this.btn_XoaNhanVien.Name = "btn_XoaNhanVien";
            this.btn_XoaNhanVien.Size = new System.Drawing.Size(110, 32);
            this.btn_XoaNhanVien.TabIndex = 5;
            this.btn_XoaNhanVien.Text = "Xóa";
            this.btn_XoaNhanVien.UseVisualStyleBackColor = false;
            // 
            // btn_TìmSoDienThoai
            // 
            this.btn_TìmSoDienThoai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_TìmSoDienThoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TìmSoDienThoai.Location = new System.Drawing.Point(741, 13);
            this.btn_TìmSoDienThoai.Name = "btn_TìmSoDienThoai";
            this.btn_TìmSoDienThoai.Size = new System.Drawing.Size(110, 32);
            this.btn_TìmSoDienThoai.TabIndex = 4;
            this.btn_TìmSoDienThoai.Text = "Tìm kiếm";
            this.btn_TìmSoDienThoai.UseVisualStyleBackColor = false;
            // 
            // tbx_TimSoDienThoai
            // 
            this.tbx_TimSoDienThoai.ForeColor = System.Drawing.Color.DarkGray;
            this.tbx_TimSoDienThoai.Location = new System.Drawing.Point(463, 13);
            this.tbx_TimSoDienThoai.Name = "tbx_TimSoDienThoai";
            this.tbx_TimSoDienThoai.Size = new System.Drawing.Size(263, 32);
            this.tbx_TimSoDienThoai.TabIndex = 3;
            this.tbx_TimSoDienThoai.Text = "Nhập số điện thoại";
            // 
            // dgv_DanhSachNhanVien
            // 
            this.dgv_DanhSachNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNhanVien.Location = new System.Drawing.Point(3, 73);
            this.dgv_DanhSachNhanVien.Name = "dgv_DanhSachNhanVien";
            this.dgv_DanhSachNhanVien.RowHeadersWidth = 51;
            this.dgv_DanhSachNhanVien.RowTemplate.Height = 24;
            this.dgv_DanhSachNhanVien.Size = new System.Drawing.Size(1090, 603);
            this.dgv_DanhSachNhanVien.TabIndex = 2;
            // 
            // tab_TaoNhanVien
            // 
            this.tab_TaoNhanVien.Controls.Add(this.cbx_ChucVu);
            this.tab_TaoNhanVien.Controls.Add(this.btn_HoanThanh);
            this.tab_TaoNhanVien.Controls.Add(this.label7);
            this.tab_TaoNhanVien.Controls.Add(this.label1);
            this.tab_TaoNhanVien.Controls.Add(this.tbx_Gmail);
            this.tab_TaoNhanVien.Controls.Add(this.label6);
            this.tab_TaoNhanVien.Controls.Add(this.tbx_MatKhau);
            this.tab_TaoNhanVien.Controls.Add(this.label9);
            this.tab_TaoNhanVien.Controls.Add(this.tbx_TenNhanVien);
            this.tab_TaoNhanVien.Controls.Add(this.label10);
            this.tab_TaoNhanVien.Controls.Add(this.tbx_SoDienThoai);
            this.tab_TaoNhanVien.Location = new System.Drawing.Point(4, 33);
            this.tab_TaoNhanVien.Name = "tab_TaoNhanVien";
            this.tab_TaoNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TaoNhanVien.Size = new System.Drawing.Size(1096, 689);
            this.tab_TaoNhanVien.TabIndex = 2;
            this.tab_TaoNhanVien.Text = "Tạo nhân viên";
            this.tab_TaoNhanVien.UseVisualStyleBackColor = true;
            // 
            // cbx_ChucVu
            // 
            this.cbx_ChucVu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_ChucVu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_ChucVu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbx_ChucVu.FormattingEnabled = true;
            this.cbx_ChucVu.IntegralHeight = false;
            this.cbx_ChucVu.Items.AddRange(new object[] {
            "QuanLy",
            "NhanVien"});
            this.cbx_ChucVu.Location = new System.Drawing.Point(104, 259);
            this.cbx_ChucVu.Name = "cbx_ChucVu";
            this.cbx_ChucVu.Size = new System.Drawing.Size(396, 32);
            this.cbx_ChucVu.TabIndex = 40;
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_HoanThanh.Location = new System.Drawing.Point(814, 602);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(183, 32);
            this.btn_HoanThanh.TabIndex = 39;
            this.btn_HoanThanh.Text = "Hoàn thành";
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(100, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(100, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gmail";
            // 
            // tbx_Gmail
            // 
            this.tbx_Gmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_Gmail.Location = new System.Drawing.Point(100, 162);
            this.tbx_Gmail.Name = "tbx_Gmail";
            this.tbx_Gmail.Size = new System.Drawing.Size(400, 32);
            this.tbx_Gmail.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(597, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Mật khẩu";
            // 
            // tbx_MatKhau
            // 
            this.tbx_MatKhau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_MatKhau.Location = new System.Drawing.Point(597, 162);
            this.tbx_MatKhau.Name = "tbx_MatKhau";
            this.tbx_MatKhau.Size = new System.Drawing.Size(400, 32);
            this.tbx_MatKhau.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(100, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tên nhân viên";
            // 
            // tbx_TenNhanVien
            // 
            this.tbx_TenNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_TenNhanVien.Location = new System.Drawing.Point(100, 66);
            this.tbx_TenNhanVien.Name = "tbx_TenNhanVien";
            this.tbx_TenNhanVien.Size = new System.Drawing.Size(400, 32);
            this.tbx_TenNhanVien.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(597, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Số điện thoại";
            // 
            // tbx_SoDienThoai
            // 
            this.tbx_SoDienThoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_SoDienThoai.Location = new System.Drawing.Point(597, 66);
            this.tbx_SoDienThoai.Name = "tbx_SoDienThoai";
            this.tbx_SoDienThoai.Size = new System.Drawing.Size(400, 32);
            this.tbx_SoDienThoai.TabIndex = 26;
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcl_SanPham);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(1104, 726);
            this.tcl_SanPham.ResumeLayout(false);
            this.tab_DanhSachNhanVien.ResumeLayout(false);
            this.tab_DanhSachNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNhanVien)).EndInit();
            this.tab_TaoNhanVien.ResumeLayout(false);
            this.tab_TaoNhanVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tcl_SanPham;
        public System.Windows.Forms.TabPage tab_DanhSachNhanVien;
        public System.Windows.Forms.Button btn_SuaNhanVien;
        public System.Windows.Forms.Button btn_XoaNhanVien;
        public System.Windows.Forms.Button btn_TìmSoDienThoai;
        public System.Windows.Forms.TextBox tbx_TimSoDienThoai;
        public System.Windows.Forms.DataGridView dgv_DanhSachNhanVien;
        private System.Windows.Forms.TabPage tab_TaoNhanVien;
        public System.Windows.Forms.ComboBox cbx_ChucVu;
        public System.Windows.Forms.Button btn_HoanThanh;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbx_Gmail;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbx_MatKhau;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbx_TenNhanVien;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbx_SoDienThoai;
    }
}

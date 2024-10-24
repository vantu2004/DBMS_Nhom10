namespace Nhom11
{
    partial class UC_SanPham
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
            this.tab_DanhSachSanPham = new System.Windows.Forms.TabPage();
            this.btn_SapXep = new System.Windows.Forms.Button();
            this.btn_SuaSanPham = new System.Windows.Forms.Button();
            this.tbx_NhapImei = new System.Windows.Forms.TextBox();
            this.tbx_TimSanPham = new System.Windows.Forms.TextBox();
            this.btn_XoaSanPham = new System.Windows.Forms.Button();
            this.btn_TìmSanPham = new System.Windows.Forms.Button();
            this.dgv_DanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.tcl_SanPham = new System.Windows.Forms.TabControl();
            this.tab_CapNhatThongTin = new System.Windows.Forms.TabPage();
            this.cbx_ChonImei = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_Thue = new System.Windows.Forms.TextBox();
            this.btn_ThemAnh = new System.Windows.Forms.Button();
            this.pbx_HinhAnh = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_GiaBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_GiaNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_MauSac = new System.Windows.Forms.TextBox();
            this.btn_TaoDongMay = new System.Windows.Forms.Button();
            this.cbx_ChonDongMay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_HoanThanh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_SamPhamCanCapNhat = new System.Windows.Forms.DataGridView();
            this.tab_DanhSachSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).BeginInit();
            this.tcl_SanPham.SuspendLayout();
            this.tab_CapNhatThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_HinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SamPhamCanCapNhat)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_DanhSachSanPham
            // 
            this.tab_DanhSachSanPham.Controls.Add(this.btn_SapXep);
            this.tab_DanhSachSanPham.Controls.Add(this.btn_SuaSanPham);
            this.tab_DanhSachSanPham.Controls.Add(this.tbx_NhapImei);
            this.tab_DanhSachSanPham.Controls.Add(this.tbx_TimSanPham);
            this.tab_DanhSachSanPham.Controls.Add(this.btn_XoaSanPham);
            this.tab_DanhSachSanPham.Controls.Add(this.btn_TìmSanPham);
            this.tab_DanhSachSanPham.Controls.Add(this.dgv_DanhSachSanPham);
            this.tab_DanhSachSanPham.Location = new System.Drawing.Point(4, 33);
            this.tab_DanhSachSanPham.Margin = new System.Windows.Forms.Padding(10);
            this.tab_DanhSachSanPham.Name = "tab_DanhSachSanPham";
            this.tab_DanhSachSanPham.Padding = new System.Windows.Forms.Padding(10);
            this.tab_DanhSachSanPham.Size = new System.Drawing.Size(1096, 689);
            this.tab_DanhSachSanPham.TabIndex = 0;
            this.tab_DanhSachSanPham.Text = "Danh sách sản phẩm";
            this.tab_DanhSachSanPham.UseVisualStyleBackColor = true;
            // 
            // btn_SapXep
            // 
            this.btn_SapXep.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_SapXep.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SapXep.Location = new System.Drawing.Point(407, 13);
            this.btn_SapXep.Name = "btn_SapXep";
            this.btn_SapXep.Size = new System.Drawing.Size(110, 32);
            this.btn_SapXep.TabIndex = 15;
            this.btn_SapXep.Text = "Sắp xếp";
            this.btn_SapXep.UseVisualStyleBackColor = false;
            // 
            // btn_SuaSanPham
            // 
            this.btn_SuaSanPham.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_SuaSanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaSanPham.Location = new System.Drawing.Point(862, 13);
            this.btn_SuaSanPham.Name = "btn_SuaSanPham";
            this.btn_SuaSanPham.Size = new System.Drawing.Size(105, 32);
            this.btn_SuaSanPham.TabIndex = 14;
            this.btn_SuaSanPham.Text = "Sửa";
            this.btn_SuaSanPham.UseVisualStyleBackColor = false;
            this.btn_SuaSanPham.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // tbx_NhapImei
            // 
            this.tbx_NhapImei.ForeColor = System.Drawing.Color.DarkGray;
            this.tbx_NhapImei.Location = new System.Drawing.Point(627, 13);
            this.tbx_NhapImei.Name = "tbx_NhapImei";
            this.tbx_NhapImei.Size = new System.Drawing.Size(229, 32);
            this.tbx_NhapImei.TabIndex = 13;
            this.tbx_NhapImei.Text = "Nhập Imei";
            // 
            // tbx_TimSanPham
            // 
            this.tbx_TimSanPham.ForeColor = System.Drawing.Color.DarkGray;
            this.tbx_TimSanPham.Location = new System.Drawing.Point(13, 13);
            this.tbx_TimSanPham.Name = "tbx_TimSanPham";
            this.tbx_TimSanPham.Size = new System.Drawing.Size(263, 32);
            this.tbx_TimSanPham.TabIndex = 3;
            this.tbx_TimSanPham.Text = "Nhập tên sản phẩm";
            // 
            // btn_XoaSanPham
            // 
            this.btn_XoaSanPham.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_XoaSanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaSanPham.Location = new System.Drawing.Point(973, 13);
            this.btn_XoaSanPham.Name = "btn_XoaSanPham";
            this.btn_XoaSanPham.Size = new System.Drawing.Size(110, 32);
            this.btn_XoaSanPham.TabIndex = 6;
            this.btn_XoaSanPham.Text = "Xóa";
            this.btn_XoaSanPham.UseVisualStyleBackColor = false;
            // 
            // btn_TìmSanPham
            // 
            this.btn_TìmSanPham.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_TìmSanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TìmSanPham.Location = new System.Drawing.Point(291, 13);
            this.btn_TìmSanPham.Name = "btn_TìmSanPham";
            this.btn_TìmSanPham.Size = new System.Drawing.Size(110, 32);
            this.btn_TìmSanPham.TabIndex = 4;
            this.btn_TìmSanPham.Text = "Tìm kiếm";
            this.btn_TìmSanPham.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhSachSanPham
            // 
            this.dgv_DanhSachSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSanPham.Location = new System.Drawing.Point(3, 73);
            this.dgv_DanhSachSanPham.Name = "dgv_DanhSachSanPham";
            this.dgv_DanhSachSanPham.RowHeadersWidth = 51;
            this.dgv_DanhSachSanPham.RowTemplate.Height = 24;
            this.dgv_DanhSachSanPham.Size = new System.Drawing.Size(1090, 603);
            this.dgv_DanhSachSanPham.TabIndex = 2;
            // 
            // tcl_SanPham
            // 
            this.tcl_SanPham.Controls.Add(this.tab_DanhSachSanPham);
            this.tcl_SanPham.Controls.Add(this.tab_CapNhatThongTin);
            this.tcl_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcl_SanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcl_SanPham.Location = new System.Drawing.Point(0, 0);
            this.tcl_SanPham.Name = "tcl_SanPham";
            this.tcl_SanPham.SelectedIndex = 0;
            this.tcl_SanPham.Size = new System.Drawing.Size(1104, 726);
            this.tcl_SanPham.TabIndex = 1;
            // 
            // tab_CapNhatThongTin
            // 
            this.tab_CapNhatThongTin.Controls.Add(this.cbx_ChonImei);
            this.tab_CapNhatThongTin.Controls.Add(this.label8);
            this.tab_CapNhatThongTin.Controls.Add(this.label2);
            this.tab_CapNhatThongTin.Controls.Add(this.label6);
            this.tab_CapNhatThongTin.Controls.Add(this.tbx_Thue);
            this.tab_CapNhatThongTin.Controls.Add(this.btn_ThemAnh);
            this.tab_CapNhatThongTin.Controls.Add(this.pbx_HinhAnh);
            this.tab_CapNhatThongTin.Controls.Add(this.label7);
            this.tab_CapNhatThongTin.Controls.Add(this.label5);
            this.tab_CapNhatThongTin.Controls.Add(this.tbx_GiaBan);
            this.tab_CapNhatThongTin.Controls.Add(this.label1);
            this.tab_CapNhatThongTin.Controls.Add(this.tbx_GiaNhap);
            this.tab_CapNhatThongTin.Controls.Add(this.label3);
            this.tab_CapNhatThongTin.Controls.Add(this.tbx_MauSac);
            this.tab_CapNhatThongTin.Controls.Add(this.btn_TaoDongMay);
            this.tab_CapNhatThongTin.Controls.Add(this.cbx_ChonDongMay);
            this.tab_CapNhatThongTin.Controls.Add(this.label4);
            this.tab_CapNhatThongTin.Controls.Add(this.btn_HoanThanh);
            this.tab_CapNhatThongTin.Controls.Add(this.label9);
            this.tab_CapNhatThongTin.Controls.Add(this.dgv_SamPhamCanCapNhat);
            this.tab_CapNhatThongTin.Location = new System.Drawing.Point(4, 33);
            this.tab_CapNhatThongTin.Name = "tab_CapNhatThongTin";
            this.tab_CapNhatThongTin.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CapNhatThongTin.Size = new System.Drawing.Size(1096, 689);
            this.tab_CapNhatThongTin.TabIndex = 1;
            this.tab_CapNhatThongTin.Text = "Cập nhật thông tin";
            this.tab_CapNhatThongTin.UseVisualStyleBackColor = true;
            // 
            // cbx_ChonImei
            // 
            this.cbx_ChonImei.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_ChonImei.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbx_ChonImei.FormattingEnabled = true;
            this.cbx_ChonImei.IntegralHeight = false;
            this.cbx_ChonImei.Location = new System.Drawing.Point(133, 350);
            this.cbx_ChonImei.Name = "cbx_ChonImei";
            this.cbx_ChonImei.Size = new System.Drawing.Size(340, 32);
            this.cbx_ChonImei.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(129, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 63;
            this.label8.Text = "Chọn Imei";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(845, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "% (Phần trăm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(610, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 61;
            this.label6.Text = "Thuế";
            // 
            // tbx_Thue
            // 
            this.tbx_Thue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_Thue.Location = new System.Drawing.Point(614, 586);
            this.tbx_Thue.Name = "tbx_Thue";
            this.tbx_Thue.Size = new System.Drawing.Size(225, 32);
            this.tbx_Thue.TabIndex = 60;
            // 
            // btn_ThemAnh
            // 
            this.btn_ThemAnh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ThemAnh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemAnh.Location = new System.Drawing.Point(845, 349);
            this.btn_ThemAnh.Name = "btn_ThemAnh";
            this.btn_ThemAnh.Size = new System.Drawing.Size(105, 32);
            this.btn_ThemAnh.TabIndex = 59;
            this.btn_ThemAnh.Text = "Thêm";
            this.btn_ThemAnh.UseVisualStyleBackColor = false;
            // 
            // pbx_HinhAnh
            // 
            this.pbx_HinhAnh.Location = new System.Drawing.Point(614, 350);
            this.pbx_HinhAnh.Name = "pbx_HinhAnh";
            this.pbx_HinhAnh.Size = new System.Drawing.Size(225, 201);
            this.pbx_HinhAnh.TabIndex = 58;
            this.pbx_HinhAnh.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(610, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Hình ảnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(129, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Giá bán";
            // 
            // tbx_GiaBan
            // 
            this.tbx_GiaBan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_GiaBan.Location = new System.Drawing.Point(133, 586);
            this.tbx_GiaBan.Name = "tbx_GiaBan";
            this.tbx_GiaBan.Size = new System.Drawing.Size(340, 32);
            this.tbx_GiaBan.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(129, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "Giá nhập";
            // 
            // tbx_GiaNhap
            // 
            this.tbx_GiaNhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_GiaNhap.Location = new System.Drawing.Point(133, 527);
            this.tbx_GiaNhap.Name = "tbx_GiaNhap";
            this.tbx_GiaNhap.Size = new System.Drawing.Size(340, 32);
            this.tbx_GiaNhap.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(129, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Màu sắc";
            // 
            // tbx_MauSac
            // 
            this.tbx_MauSac.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_MauSac.Location = new System.Drawing.Point(133, 468);
            this.tbx_MauSac.Name = "tbx_MauSac";
            this.tbx_MauSac.Size = new System.Drawing.Size(340, 32);
            this.tbx_MauSac.TabIndex = 51;
            // 
            // btn_TaoDongMay
            // 
            this.btn_TaoDongMay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_TaoDongMay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TaoDongMay.Location = new System.Drawing.Point(368, 409);
            this.btn_TaoDongMay.Name = "btn_TaoDongMay";
            this.btn_TaoDongMay.Size = new System.Drawing.Size(105, 32);
            this.btn_TaoDongMay.TabIndex = 50;
            this.btn_TaoDongMay.Text = "Mới";
            this.btn_TaoDongMay.UseVisualStyleBackColor = false;
            // 
            // cbx_ChonDongMay
            // 
            this.cbx_ChonDongMay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_ChonDongMay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbx_ChonDongMay.FormattingEnabled = true;
            this.cbx_ChonDongMay.IntegralHeight = false;
            this.cbx_ChonDongMay.Location = new System.Drawing.Point(133, 409);
            this.cbx_ChonDongMay.Name = "cbx_ChonDongMay";
            this.cbx_ChonDongMay.Size = new System.Drawing.Size(229, 32);
            this.cbx_ChonDongMay.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(129, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Chọn dòng máy";
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_HoanThanh.Location = new System.Drawing.Point(614, 642);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(340, 32);
            this.btn_HoanThanh.TabIndex = 47;
            this.btn_HoanThanh.Text = "Hoàn thành";
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "Danh sách sản phẩm cần cập nhật";
            // 
            // dgv_SamPhamCanCapNhat
            // 
            this.dgv_SamPhamCanCapNhat.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SamPhamCanCapNhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SamPhamCanCapNhat.Location = new System.Drawing.Point(3, 40);
            this.dgv_SamPhamCanCapNhat.Name = "dgv_SamPhamCanCapNhat";
            this.dgv_SamPhamCanCapNhat.RowHeadersWidth = 51;
            this.dgv_SamPhamCanCapNhat.RowTemplate.Height = 24;
            this.dgv_SamPhamCanCapNhat.Size = new System.Drawing.Size(1090, 267);
            this.dgv_SamPhamCanCapNhat.TabIndex = 3;
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcl_SanPham);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(1104, 726);
            this.tab_DanhSachSanPham.ResumeLayout(false);
            this.tab_DanhSachSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).EndInit();
            this.tcl_SanPham.ResumeLayout(false);
            this.tab_CapNhatThongTin.ResumeLayout(false);
            this.tab_CapNhatThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_HinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SamPhamCanCapNhat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabPage tab_DanhSachSanPham;
        public System.Windows.Forms.Button btn_SuaSanPham;
        public System.Windows.Forms.TextBox tbx_NhapImei;
        public System.Windows.Forms.TextBox tbx_TimSanPham;
        public System.Windows.Forms.Button btn_XoaSanPham;
        public System.Windows.Forms.Button btn_TìmSanPham;
        public System.Windows.Forms.DataGridView dgv_DanhSachSanPham;
        public System.Windows.Forms.TabControl tcl_SanPham;
        private System.Windows.Forms.TabPage tab_CapNhatThongTin;
        public System.Windows.Forms.DataGridView dgv_SamPhamCanCapNhat;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbx_ChonImei;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbx_Thue;
        public System.Windows.Forms.Button btn_ThemAnh;
        public System.Windows.Forms.PictureBox pbx_HinhAnh;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbx_GiaBan;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbx_GiaNhap;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbx_MauSac;
        public System.Windows.Forms.Button btn_TaoDongMay;
        public System.Windows.Forms.ComboBox cbx_ChonDongMay;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_HoanThanh;
        public System.Windows.Forms.Button btn_SapXep;
    }
}

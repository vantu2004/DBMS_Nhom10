namespace Nhom11
{
    partial class form_SuaNhanVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_MaNhanVien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.cbx_ChucVu.Location = new System.Drawing.Point(36, 250);
            this.cbx_ChucVu.Name = "cbx_ChucVu";
            this.cbx_ChucVu.Size = new System.Drawing.Size(332, 32);
            this.cbx_ChucVu.TabIndex = 51;
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_HoanThanh.Location = new System.Drawing.Point(410, 374);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(332, 32);
            this.btn_HoanThanh.TabIndex = 50;
            this.btn_HoanThanh.Text = "Hoàn thành";
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            this.btn_HoanThanh.Click += new System.EventHandler(this.btn_HoanThanh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(32, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(32, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Gmail";
            // 
            // tbx_Gmail
            // 
            this.tbx_Gmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_Gmail.Location = new System.Drawing.Point(32, 157);
            this.tbx_Gmail.Name = "tbx_Gmail";
            this.tbx_Gmail.Size = new System.Drawing.Size(336, 32);
            this.tbx_Gmail.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(410, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Mật khẩu";
            // 
            // tbx_MatKhau
            // 
            this.tbx_MatKhau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_MatKhau.Location = new System.Drawing.Point(410, 253);
            this.tbx_MatKhau.Name = "tbx_MatKhau";
            this.tbx_MatKhau.Size = new System.Drawing.Size(336, 32);
            this.tbx_MatKhau.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(406, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "Tên nhân viên";
            // 
            // tbx_TenNhanVien
            // 
            this.tbx_TenNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_TenNhanVien.Location = new System.Drawing.Point(406, 61);
            this.tbx_TenNhanVien.Name = "tbx_TenNhanVien";
            this.tbx_TenNhanVien.Size = new System.Drawing.Size(336, 32);
            this.tbx_TenNhanVien.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(410, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 21);
            this.label10.TabIndex = 42;
            this.label10.Text = "Số điện thoại";
            // 
            // tbx_SoDienThoai
            // 
            this.tbx_SoDienThoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_SoDienThoai.Location = new System.Drawing.Point(410, 157);
            this.tbx_SoDienThoai.Name = "tbx_SoDienThoai";
            this.tbx_SoDienThoai.Size = new System.Drawing.Size(336, 32);
            this.tbx_SoDienThoai.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(32, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã nhân viên";
            // 
            // tbx_MaNhanVien
            // 
            this.tbx_MaNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_MaNhanVien.Location = new System.Drawing.Point(32, 61);
            this.tbx_MaNhanVien.Name = "tbx_MaNhanVien";
            this.tbx_MaNhanVien.ReadOnly = true;
            this.tbx_MaNhanVien.Size = new System.Drawing.Size(336, 32);
            this.tbx_MaNhanVien.TabIndex = 52;
            // 
            // form_SuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_MaNhanVien);
            this.Controls.Add(this.cbx_ChucVu);
            this.Controls.Add(this.btn_HoanThanh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_Gmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_MatKhau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_TenNhanVien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_SoDienThoai);
            this.Name = "form_SuaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin nhân viên";
            this.Load += new System.EventHandler(this.form_SuaNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbx_MaNhanVien;
    }
}
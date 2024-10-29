namespace Nhom11
{
    partial class UC_KhachHang
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
            this.btn_TìmKhachHang = new System.Windows.Forms.Button();
            this.tbx_TimKhachHang = new System.Windows.Forms.TextBox();
            this.dgv_DanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.btn_SuaKhachHang = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ChiTietThanhToan = new System.Windows.Forms.DataGridView();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TìmKhachHang
            // 
            this.btn_TìmKhachHang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_TìmKhachHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TìmKhachHang.Location = new System.Drawing.Point(715, 22);
            this.btn_TìmKhachHang.Name = "btn_TìmKhachHang";
            this.btn_TìmKhachHang.Size = new System.Drawing.Size(110, 33);
            this.btn_TìmKhachHang.TabIndex = 7;
            this.btn_TìmKhachHang.Text = "Tìm kiếm";
            this.btn_TìmKhachHang.UseVisualStyleBackColor = false;
            this.btn_TìmKhachHang.Click += new System.EventHandler(this.btn_TìmKhachHang_Click);
            // 
            // tbx_TimKhachHang
            // 
            this.tbx_TimKhachHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_TimKhachHang.ForeColor = System.Drawing.Color.DarkGray;
            this.tbx_TimKhachHang.Location = new System.Drawing.Point(437, 23);
            this.tbx_TimKhachHang.Name = "tbx_TimKhachHang";
            this.tbx_TimKhachHang.Size = new System.Drawing.Size(272, 32);
            this.tbx_TimKhachHang.TabIndex = 6;
            this.tbx_TimKhachHang.Text = "Nhập số điện thoại khách hàng";
            // 
            // dgv_DanhSachKhachHang
            // 
            this.dgv_DanhSachKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKhachHang.Location = new System.Drawing.Point(3, 99);
            this.dgv_DanhSachKhachHang.Name = "dgv_DanhSachKhachHang";
            this.dgv_DanhSachKhachHang.RowHeadersWidth = 51;
            this.dgv_DanhSachKhachHang.RowTemplate.Height = 24;
            this.dgv_DanhSachKhachHang.Size = new System.Drawing.Size(1098, 337);
            this.dgv_DanhSachKhachHang.TabIndex = 5;
            this.dgv_DanhSachKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachKhachHang_CellClick);
            // 
            // btn_SuaKhachHang
            // 
            this.btn_SuaKhachHang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_SuaKhachHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaKhachHang.Location = new System.Drawing.Point(969, 23);
            this.btn_SuaKhachHang.Name = "btn_SuaKhachHang";
            this.btn_SuaKhachHang.Size = new System.Drawing.Size(110, 33);
            this.btn_SuaKhachHang.TabIndex = 9;
            this.btn_SuaKhachHang.Text = "Sửa";
            this.btn_SuaKhachHang.UseVisualStyleBackColor = false;
            this.btn_SuaKhachHang.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "Danh sách khách hàng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(3, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Chi tiết thanh toán";
            // 
            // dgv_ChiTietThanhToan
            // 
            this.dgv_ChiTietThanhToan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChiTietThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietThanhToan.Location = new System.Drawing.Point(3, 463);
            this.dgv_ChiTietThanhToan.Name = "dgv_ChiTietThanhToan";
            this.dgv_ChiTietThanhToan.RowHeadersWidth = 51;
            this.dgv_ChiTietThanhToan.RowTemplate.Height = 24;
            this.dgv_ChiTietThanhToan.Size = new System.Drawing.Size(1098, 260);
            this.dgv_ChiTietThanhToan.TabIndex = 47;
            this.dgv_ChiTietThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietThanhToan_CellClick);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(831, 22);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(132, 33);
            this.btn_ThanhToan.TabIndex = 49;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ChiTietThanhToan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_SuaKhachHang);
            this.Controls.Add(this.btn_TìmKhachHang);
            this.Controls.Add(this.tbx_TimKhachHang);
            this.Controls.Add(this.dgv_DanhSachKhachHang);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(1104, 726);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_TìmKhachHang;
        public System.Windows.Forms.TextBox tbx_TimKhachHang;
        public System.Windows.Forms.DataGridView dgv_DanhSachKhachHang;
        public System.Windows.Forms.Button btn_SuaKhachHang;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_ChiTietThanhToan;
        public System.Windows.Forms.Button btn_ThanhToan;
    }
}

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
            this.dgv_ChiTietThanhToan = new System.Windows.Forms.DataGridView();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietThanhToan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TìmKhachHang
            // 
            this.btn_TìmKhachHang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_TìmKhachHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TìmKhachHang.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_TìmKhachHang.Location = new System.Drawing.Point(327, 39);
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
            this.tbx_TimKhachHang.Location = new System.Drawing.Point(49, 40);
            this.tbx_TimKhachHang.Name = "tbx_TimKhachHang";
            this.tbx_TimKhachHang.Size = new System.Drawing.Size(272, 32);
            this.tbx_TimKhachHang.TabIndex = 6;
            this.tbx_TimKhachHang.Text = "Nhập số điện thoại khách hàng";
            // 
            // dgv_DanhSachKhachHang
            // 
            this.dgv_DanhSachKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachKhachHang.Location = new System.Drawing.Point(3, 24);
            this.dgv_DanhSachKhachHang.Name = "dgv_DanhSachKhachHang";
            this.dgv_DanhSachKhachHang.RowHeadersWidth = 51;
            this.dgv_DanhSachKhachHang.RowTemplate.Height = 24;
            this.dgv_DanhSachKhachHang.Size = new System.Drawing.Size(960, 932);
            this.dgv_DanhSachKhachHang.TabIndex = 5;
            this.dgv_DanhSachKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachKhachHang_CellClick);
            // 
            // btn_SuaKhachHang
            // 
            this.btn_SuaKhachHang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_SuaKhachHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaKhachHang.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_SuaKhachHang.Location = new System.Drawing.Point(581, 40);
            this.btn_SuaKhachHang.Name = "btn_SuaKhachHang";
            this.btn_SuaKhachHang.Size = new System.Drawing.Size(110, 33);
            this.btn_SuaKhachHang.TabIndex = 9;
            this.btn_SuaKhachHang.Text = "Sửa";
            this.btn_SuaKhachHang.UseVisualStyleBackColor = false;
            this.btn_SuaKhachHang.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dgv_ChiTietThanhToan
            // 
            this.dgv_ChiTietThanhToan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChiTietThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ChiTietThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChiTietThanhToan.Location = new System.Drawing.Point(3, 24);
            this.dgv_ChiTietThanhToan.Name = "dgv_ChiTietThanhToan";
            this.dgv_ChiTietThanhToan.RowHeadersWidth = 51;
            this.dgv_ChiTietThanhToan.RowTemplate.Height = 24;
            this.dgv_ChiTietThanhToan.Size = new System.Drawing.Size(702, 932);
            this.dgv_ChiTietThanhToan.TabIndex = 47;
            this.dgv_ChiTietThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietThanhToan_CellClick);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThanhToan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_ThanhToan.Location = new System.Drawing.Point(443, 39);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(132, 33);
            this.btn_ThanhToan.TabIndex = 49;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_TimKhachHang);
            this.groupBox1.Controls.Add(this.btn_TìmKhachHang);
            this.groupBox1.Controls.Add(this.btn_SuaKhachHang);
            this.groupBox1.Controls.Add(this.btn_ThanhToan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1674, 96);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DanhSachKhachHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(0, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 959);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dach sách khách hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_ChiTietThanhToan);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.Location = new System.Drawing.Point(966, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(708, 959);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết thanh toán";
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(1674, 1055);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietThanhToan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_TìmKhachHang;
        public System.Windows.Forms.TextBox tbx_TimKhachHang;
        public System.Windows.Forms.DataGridView dgv_DanhSachKhachHang;
        public System.Windows.Forms.Button btn_SuaKhachHang;
        public System.Windows.Forms.DataGridView dgv_ChiTietThanhToan;
        public System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

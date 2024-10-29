namespace Nhom11
{
    partial class form_DangNhap
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rbn_NhanVien = new System.Windows.Forms.RadioButton();
            this.rbn_Admin = new System.Windows.Forms.RadioButton();
            this.tbx_TenDangNhap = new System.Windows.Forms.TextBox();
            this.tbx_MatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.rbn_NhanVien);
            this.panelControl1.Controls.Add(this.rbn_Admin);
            this.panelControl1.Location = new System.Drawing.Point(42, 234);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(400, 80);
            this.panelControl1.TabIndex = 0;
            // 
            // rbn_NhanVien
            // 
            this.rbn_NhanVien.AutoSize = true;
            this.rbn_NhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbn_NhanVien.ForeColor = System.Drawing.Color.DarkGray;
            this.rbn_NhanVien.Location = new System.Drawing.Point(209, 22);
            this.rbn_NhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbn_NhanVien.Name = "rbn_NhanVien";
            this.rbn_NhanVien.Size = new System.Drawing.Size(120, 28);
            this.rbn_NhanVien.TabIndex = 1;
            this.rbn_NhanVien.TabStop = true;
            this.rbn_NhanVien.Text = "Nhân viên";
            this.rbn_NhanVien.UseVisualStyleBackColor = true;
            // 
            // rbn_Admin
            // 
            this.rbn_Admin.AutoSize = true;
            this.rbn_Admin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbn_Admin.ForeColor = System.Drawing.Color.DarkGray;
            this.rbn_Admin.Location = new System.Drawing.Point(49, 22);
            this.rbn_Admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbn_Admin.Name = "rbn_Admin";
            this.rbn_Admin.Size = new System.Drawing.Size(87, 28);
            this.rbn_Admin.TabIndex = 0;
            this.rbn_Admin.TabStop = true;
            this.rbn_Admin.Text = "Admin";
            this.rbn_Admin.UseVisualStyleBackColor = true;
            // 
            // tbx_TenDangNhap
            // 
            this.tbx_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_TenDangNhap.Location = new System.Drawing.Point(81, 91);
            this.tbx_TenDangNhap.Name = "tbx_TenDangNhap";
            this.tbx_TenDangNhap.Size = new System.Drawing.Size(320, 30);
            this.tbx_TenDangNhap.TabIndex = 1;
            // 
            // tbx_MatKhau
            // 
            this.tbx_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_MatKhau.Location = new System.Drawing.Point(81, 170);
            this.tbx_MatKhau.Name = "tbx_MatKhau";
            this.tbx_MatKhau.Size = new System.Drawing.Size(320, 30);
            this.tbx_MatKhau.TabIndex = 2;
            this.tbx_MatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(78, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.Black;
            this.btn_DangNhap.Location = new System.Drawing.Point(214, 341);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(187, 55);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            // 
            // form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_MatKhau);
            this.Controls.Add(this.tbx_TenDangNhap);
            this.Controls.Add(this.panelControl1);
            this.Name = "form_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RadioButton rbn_NhanVien;
        private System.Windows.Forms.RadioButton rbn_Admin;
        private System.Windows.Forms.TextBox tbx_TenDangNhap;
        private System.Windows.Forms.TextBox tbx_MatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DangNhap;
    }
}


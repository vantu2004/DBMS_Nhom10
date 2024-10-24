namespace Nhom11
{
    partial class form_SuaSanPham
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
            this.cbx_ChonDongMay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_HoanThanh = new System.Windows.Forms.Button();
            this.btn_TaoDongMay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_MauSac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_GiaNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_GiaBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbx_HinhAnh = new System.Windows.Forms.PictureBox();
            this.btn_ThemAnh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_Thue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_ChonDongMay
            // 
            this.cbx_ChonDongMay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_ChonDongMay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbx_ChonDongMay.FormattingEnabled = true;
            this.cbx_ChonDongMay.IntegralHeight = false;
            this.cbx_ChonDongMay.Location = new System.Drawing.Point(44, 54);
            this.cbx_ChonDongMay.Name = "cbx_ChonDongMay";
            this.cbx_ChonDongMay.Size = new System.Drawing.Size(229, 32);
            this.cbx_ChonDongMay.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(40, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chọn dòng máy";
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_HoanThanh.Location = new System.Drawing.Point(416, 382);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(340, 32);
            this.btn_HoanThanh.TabIndex = 13;
            this.btn_HoanThanh.Text = "Hoàn thành";
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            // 
            // btn_TaoDongMay
            // 
            this.btn_TaoDongMay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_TaoDongMay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TaoDongMay.Location = new System.Drawing.Point(279, 54);
            this.btn_TaoDongMay.Name = "btn_TaoDongMay";
            this.btn_TaoDongMay.Size = new System.Drawing.Size(105, 32);
            this.btn_TaoDongMay.TabIndex = 16;
            this.btn_TaoDongMay.Text = "Mới";
            this.btn_TaoDongMay.UseVisualStyleBackColor = false;
            this.btn_TaoDongMay.Click += new System.EventHandler(this.btn_TaoDongMay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Màu sắc";
            // 
            // tbx_MauSac
            // 
            this.tbx_MauSac.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_MauSac.Location = new System.Drawing.Point(44, 139);
            this.tbx_MauSac.Name = "tbx_MauSac";
            this.tbx_MauSac.Size = new System.Drawing.Size(340, 32);
            this.tbx_MauSac.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(40, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Giá nhập";
            // 
            // tbx_GiaNhap
            // 
            this.tbx_GiaNhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_GiaNhap.Location = new System.Drawing.Point(44, 224);
            this.tbx_GiaNhap.Name = "tbx_GiaNhap";
            this.tbx_GiaNhap.Size = new System.Drawing.Size(340, 32);
            this.tbx_GiaNhap.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(40, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giá bán";
            // 
            // tbx_GiaBan
            // 
            this.tbx_GiaBan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_GiaBan.Location = new System.Drawing.Point(44, 308);
            this.tbx_GiaBan.Name = "tbx_GiaBan";
            this.tbx_GiaBan.Size = new System.Drawing.Size(340, 32);
            this.tbx_GiaBan.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(412, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Hình ảnh";
            // 
            // pbx_HinhAnh
            // 
            this.pbx_HinhAnh.Location = new System.Drawing.Point(416, 54);
            this.pbx_HinhAnh.Name = "pbx_HinhAnh";
            this.pbx_HinhAnh.Size = new System.Drawing.Size(225, 201);
            this.pbx_HinhAnh.TabIndex = 30;
            this.pbx_HinhAnh.TabStop = false;
            // 
            // btn_ThemAnh
            // 
            this.btn_ThemAnh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ThemAnh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemAnh.Location = new System.Drawing.Point(647, 53);
            this.btn_ThemAnh.Name = "btn_ThemAnh";
            this.btn_ThemAnh.Size = new System.Drawing.Size(105, 32);
            this.btn_ThemAnh.TabIndex = 32;
            this.btn_ThemAnh.Text = "Thêm";
            this.btn_ThemAnh.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(647, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "% (Phần trăm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(412, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Thuế";
            // 
            // tbx_Thue
            // 
            this.tbx_Thue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbx_Thue.Location = new System.Drawing.Point(416, 308);
            this.tbx_Thue.Name = "tbx_Thue";
            this.tbx_Thue.Size = new System.Drawing.Size(225, 32);
            this.tbx_Thue.TabIndex = 33;
            // 
            // form_SuaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_Thue);
            this.Controls.Add(this.btn_ThemAnh);
            this.Controls.Add(this.pbx_HinhAnh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_GiaBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_GiaNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_MauSac);
            this.Controls.Add(this.btn_TaoDongMay);
            this.Controls.Add(this.cbx_ChonDongMay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_HoanThanh);
            this.Name = "form_SuaSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbx_ChonDongMay;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_HoanThanh;
        public System.Windows.Forms.Button btn_TaoDongMay;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbx_MauSac;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbx_GiaNhap;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbx_GiaBan;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox pbx_HinhAnh;
        public System.Windows.Forms.Button btn_ThemAnh;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbx_Thue;
    }
}
namespace Nhom11
{
    partial class form_SuaDonNhap
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
            this.btn_HoanThanh = new System.Windows.Forms.Button();
            this.cbx_ChonNhaCungCap = new System.Windows.Forms.ComboBox();
            this.btn_TaoNhaCungCap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_HoanThanh.Location = new System.Drawing.Point(218, 373);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(336, 32);
            this.btn_HoanThanh.TabIndex = 103;
            this.btn_HoanThanh.Text = "Hoàn thành";
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            this.btn_HoanThanh.Click += new System.EventHandler(this.btn_HoanThanh_Click);
            // 
            // cbx_ChonNhaCungCap
            // 
            this.cbx_ChonNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_ChonNhaCungCap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbx_ChonNhaCungCap.FormattingEnabled = true;
            this.cbx_ChonNhaCungCap.IntegralHeight = false;
            this.cbx_ChonNhaCungCap.Location = new System.Drawing.Point(218, 60);
            this.cbx_ChonNhaCungCap.Name = "cbx_ChonNhaCungCap";
            this.cbx_ChonNhaCungCap.Size = new System.Drawing.Size(225, 32);
            this.cbx_ChonNhaCungCap.TabIndex = 92;
            // 
            // btn_TaoNhaCungCap
            // 
            this.btn_TaoNhaCungCap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_TaoNhaCungCap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TaoNhaCungCap.Location = new System.Drawing.Point(449, 59);
            this.btn_TaoNhaCungCap.Name = "btn_TaoNhaCungCap";
            this.btn_TaoNhaCungCap.Size = new System.Drawing.Size(105, 32);
            this.btn_TaoNhaCungCap.TabIndex = 90;
            this.btn_TaoNhaCungCap.Text = "Mới";
            this.btn_TaoNhaCungCap.UseVisualStyleBackColor = false;
            this.btn_TaoNhaCungCap.Click += new System.EventHandler(this.btn_TaoNhaCungCap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(214, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 93;
            this.label1.Text = "Chọn nhà cung cấp";
            // 
            // form_SuaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TaoNhaCungCap);
            this.Controls.Add(this.btn_HoanThanh);
            this.Controls.Add(this.cbx_ChonNhaCungCap);
            this.Name = "form_SuaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa đơn nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_HoanThanh;
        public System.Windows.Forms.ComboBox cbx_ChonNhaCungCap;
        public System.Windows.Forms.Button btn_TaoNhaCungCap;
        public System.Windows.Forms.Label label1;
    }
}
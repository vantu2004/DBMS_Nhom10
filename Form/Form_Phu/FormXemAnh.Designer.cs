namespace Nhom11
{
    partial class frmXemAnh
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
            this.pbx_XemAnhTo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_XemAnhTo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_XemAnhTo
            // 
            this.pbx_XemAnhTo.Location = new System.Drawing.Point(147, 12);
            this.pbx_XemAnhTo.Name = "pbx_XemAnhTo";
            this.pbx_XemAnhTo.Size = new System.Drawing.Size(660, 695);
            this.pbx_XemAnhTo.TabIndex = 31;
            this.pbx_XemAnhTo.TabStop = false;
            // 
            // frmXemAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 759);
            this.Controls.Add(this.pbx_XemAnhTo);
            this.Name = "frmXemAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemAnh";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_XemAnhTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbx_XemAnhTo;
    }
}
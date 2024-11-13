using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11
{
    public partial class frmXemAnh : Form
    {
        public frmXemAnh(string imagePath)
        {
            InitializeComponent();
            LoadImage(imagePath);
        }

        private void LoadImage(string imagePath)
        {
            if (System.IO.File.Exists(imagePath))
            {
                pbx_XemAnhTo.Image = Image.FromFile(imagePath);
                pbx_XemAnhTo.SizeMode = PictureBoxSizeMode.Zoom; // Hình ảnh sẽ tự động điều chỉnh kích thước để vừa với PictureBox
            }
            else
            {
                MessageBox.Show("Hình ảnh không tồn tại.");
            }
        }

        private void frmXemAnh_Load(object sender, EventArgs e)
        {

        }
    }

}
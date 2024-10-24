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
    public partial class form_SuaDonHang : Form
    {
        public form_SuaDonHang()
        {
            InitializeComponent();
        }

        private void btn_KhachHangMoi_Click(object sender, EventArgs e)
        {
            form_TaoKhachHang form_TaoKhachHang = new form_TaoKhachHang();

            form_TaoKhachHang.ShowDialog();
        }
    }
}

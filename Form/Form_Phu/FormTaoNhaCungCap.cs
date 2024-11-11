using Nhom11.Class;
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
    public partial class form_TaoNhaCungCap : Form
    {
        NhaCungCap nhaCungCap = new NhaCungCap();
        DonNhapDAO donNhapDAO = new DonNhapDAO();

        public form_TaoNhaCungCap()
        {
            InitializeComponent();
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            DongMay dongMay = new DongMay();

            if (checkNullTaoDongMay())
            {
                nhaCungCap.MaNhaCungCap = BienToanCuc.randomMa9So();
                nhaCungCap.TenChaCungCap = tbx_TenNhaCungCap.Text;
                nhaCungCap.SDT = tbx_SoDienThoai.Text;
                nhaCungCap.DiaChi = tbx_DiaChi.Text;

                donNhapDAO.TaoNhaCungCap(nhaCungCap);
                this.Close();
            }
        }

        private bool checkNullTaoDongMay()
        {
            if (!string.IsNullOrEmpty(tbx_TenNhaCungCap.Text) && !string.IsNullOrEmpty(tbx_SoDienThoai.Text) && !string.IsNullOrEmpty(tbx_DiaChi.Text))
            {
                return true;
            }
            return false;
        }
    }
}

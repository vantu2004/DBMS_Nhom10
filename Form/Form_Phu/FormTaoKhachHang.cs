using Nhom11.Class;
using Nhom11.DB;
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
    public partial class form_TaoKhachHang : Form
    {
        DonHangDAO donHangDAO = new DonHangDAO();
        public form_TaoKhachHang()
        {
            InitializeComponent();
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng khách hàng
            KhachHang khachHang = new KhachHang();

            // Tạo mã khách hàng mới (GUID)
            Guid g = Guid.NewGuid();
            khachHang.MaKhachHang = g.ToString();

            khachHang.SDT = tbx_SoDienThoai.Text;
            khachHang.TenKhachHang = tbx_TenKhachHang.Text;
            khachHang.DiaChi = tbx_DiaChi.Text;
            khachHang.Gmail = tbx_Gmail.Text;

            donHangDAO.themKhachHang(khachHang);

            //  thêm xong thì đóng form
            this.Close();
        }

    }
}

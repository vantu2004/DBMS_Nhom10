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
    public partial class form_QuanLy : Form
    {
        public form_QuanLy()
        {
            InitializeComponent();
            LoadUC_DonHang();
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            UC_DonHang uc_DonHang = new UC_DonHang();

            uc_DonHang.Dock = DockStyle.Fill;

            pnl_ThongTin.Controls.Clear();

            pnl_ThongTin.Controls.Add(uc_DonHang);
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            UC_KhachHang uc_KhachHang = new UC_KhachHang();

            uc_KhachHang.Dock = DockStyle.Fill;

            pnl_ThongTin.Controls.Clear();

            pnl_ThongTin.Controls.Add(uc_KhachHang);
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            UC_KhuyenMai uc_KhuyenMai = new UC_KhuyenMai();

            uc_KhuyenMai.Dock = DockStyle.Fill;

            pnl_ThongTin.Controls.Clear();

            pnl_ThongTin.Controls.Add(uc_KhuyenMai);
        }

        private void btn_DonNhap_Click(object sender, EventArgs e)
        {
            UC_DonNhap uc_DonNhap = new UC_DonNhap();

            uc_DonNhap.Dock = DockStyle.Fill;

            pnl_ThongTin.Controls.Clear();

            pnl_ThongTin.Controls.Add(uc_DonNhap);
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            UC_SanPham uc_SanPham = new UC_SanPham();

            uc_SanPham.Dock = DockStyle.Fill;

            pnl_ThongTin.Controls.Clear();

            pnl_ThongTin.Controls.Add(uc_SanPham);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            UC_ThongKe uc_ThongKe = new UC_ThongKe();

            uc_ThongKe.Dock = DockStyle.Fill;

            pnl_ThongTin.Controls.Clear();

            pnl_ThongTin.Controls.Add(uc_ThongKe);
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            UC_NhanVien uc_NhanVien = new UC_NhanVien();

            uc_NhanVien.Dock = DockStyle.Fill;

            pnl_ThongTin.Controls.Clear();

            pnl_ThongTin.Controls.Add(uc_NhanVien);
        }

        private void LoadUC_DonHang()
        {
            UC_DonHang uc_DonHang = new UC_DonHang();

            uc_DonHang.Dock = DockStyle.Fill;

            pnl_ThongTin.Controls.Clear();

            pnl_ThongTin.Controls.Add(uc_DonHang);

        }
    }
}

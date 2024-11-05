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
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        UC_KhachHang UC_KhachHang = new UC_KhachHang();

        private string sua_taoMoi_khachHang;

        public form_TaoKhachHang()
        {
            InitializeComponent();
        }

        public string Sua_TaoMoi_khachHang { get => sua_taoMoi_khachHang; set => sua_taoMoi_khachHang = value; }

        //  Tạo là cho UC_DonHang, sửa là cho UC_KhachHang
        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            if (Sua_TaoMoi_khachHang == "Sửa")
            {
                SuaKhachHang();
            }    
            else
            {
                TaoKhachHang();
            }    
        }

        private void SuaKhachHang()
        {
            string sdt = tbx_SoDienThoai.Text;
            string tenKhachHang = tbx_TenKhachHang.Text;
            string diaChi = tbx_DiaChi.Text;
            string gmail = tbx_Gmail.Text;

            // Gọi phương thức cập nhật
            bool result = khachHangDAO.capNhatThongTinKhachHang(sdt, tenKhachHang, diaChi, gmail);

            if (result)
            {
                UC_KhachHang.LoadDanhSachKhachHang();
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form sau khi cập nhật thành công
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaoKhachHang()
        {
            // Tạo đối tượng khách hàng
            KhachHang khachHang = new KhachHang
            {
                MaKhachHang = BienToanCuc.randomMa9So(),
                SDT = tbx_SoDienThoai.Text,
                TenKhachHang = tbx_TenKhachHang.Text,
                DiaChi = tbx_DiaChi.Text,
                Gmail = tbx_Gmail.Text
            };

            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(khachHang.SDT) ||
                string.IsNullOrWhiteSpace(khachHang.TenKhachHang) ||
                string.IsNullOrWhiteSpace(khachHang.DiaChi) ||
                string.IsNullOrWhiteSpace(khachHang.Gmail))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra trùng số điện thoại
            if (khachHangDAO.KiemTraTrungSDTKhachHang(khachHang.SDT))
            {
                MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Thêm khách hàng vào cơ sở dữ liệu
            donHangDAO.themKhachHang(khachHang);

            // Đóng form sau khi thêm thành công
            this.Close();
        }

        public void LoadThongTinKhachHang(string sdt)
        {
            DataTable dt = khachHangDAO.traCuuTheoSDTKhachHang(sdt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbx_TenKhachHang.Text = row["Tên khách hàng"].ToString();
                tbx_DiaChi.Text = row["Địa chỉ"].ToString();
                tbx_Gmail.Text = row["Gmail"].ToString();
                tbx_SoDienThoai.Text = row["Số điện thoại"].ToString();
                tbx_SoDienThoai.ReadOnly = true; // Make phone number read-only
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

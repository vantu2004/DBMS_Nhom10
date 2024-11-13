using Nhom11.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11
{
    public partial class form_KhachTraGop : Form
    {
        private string selectedMaDonBan;
        private DateTime selectedNgayGhiNo;
        private DateTime selectedGioGhiNo;
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        public form_KhachTraGop(string maDonBan, DateTime ngayGhiNo, DateTime gioGhiNo)
        {
            InitializeComponent();
            selectedMaDonBan = maDonBan;
            selectedNgayGhiNo = ngayGhiNo;
            selectedGioGhiNo = gioGhiNo;
            getChiTietHoaDonGhiNo(selectedMaDonBan, selectedNgayGhiNo, selectedGioGhiNo);
        }

        private void form_KhachTraGop_Load(object sender, EventArgs e)
        {

        }

        public void getChiTietHoaDonGhiNo(string maDonBan, DateTime Ngayghino, DateTime Gioghino)
        {
            DataTable dt = khachHangDAO.getChiTietHoaDonGhiNo(maDonBan, Ngayghino, Gioghino);

            // Kiểm tra xem DataTable có dữ liệu hay không
            if (dt != null && dt.Rows.Count > 0)
            {
                decimal tongKhachDaTra = 0;
                decimal tongHoaDon = 0;
                decimal tongKhachConNo = 0;

                foreach (DataRow row in dt.Rows)
                {
                    tongKhachDaTra = row.IsNull("So_tien_tra") ? 0 : row.Field<decimal>("So_tien_tra");
                    tongHoaDon = row.IsNull("Tri_gia") ? 0 : row.Field<decimal>("Tri_gia");
                    tongKhachConNo = row.IsNull("Chua_thanh_toan") ? 0 : row.Field<decimal>("Chua_thanh_toan");
                }

                // Cập nhật label với giá trị tính được
                lbl_TongKhachDaTra.Text = tongKhachDaTra.ToString("C"); // Định dạng tiền tệ
                lbl_TongHoaDon.Text = tongHoaDon.ToString("C"); // Định dạng tiền tệ
                lbl_TongKhachConNo.Text = tongKhachConNo.ToString("C"); // Định dạng tiền tệ
            }
            else
            {
                lbl_TongKhachDaTra.Text = "0";
                lbl_TongHoaDon.Text = "0";
                lbl_TongKhachConNo.Text = "0";
            }
        }



        private void btn_HoanThanh_Click_1(object sender, EventArgs e)
        {
            UC_KhachHang uC = new UC_KhachHang();
            try
            {
                string maDonBan = selectedMaDonBan;
                decimal soTienTraThem = Convert.ToDecimal(tbx_KhachTraThem.Text);

                if (string.IsNullOrEmpty(maDonBan))
                {
                    MessageBox.Show("Mã đơn bán không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi phương thức cập nhật mà không truyền thời gian thực
                if (khachHangDAO.UpdateSoTienConLai(maDonBan, soTienTraThem))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

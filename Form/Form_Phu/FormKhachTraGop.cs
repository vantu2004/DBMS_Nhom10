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
        private string selectedSoThuTu;
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        public form_KhachTraGop(string maDonBan, string soThuTu)
        {
            InitializeComponent();
            selectedMaDonBan = maDonBan;
            selectedSoThuTu = soThuTu;
            getChiTietHoaDonGhiNo(selectedMaDonBan, selectedSoThuTu);
        }

        private void form_KhachTraGop_Load(object sender, EventArgs e)
        {

        }

        public void getChiTietHoaDonGhiNo(string maDonBan, string soThuTu)
        {
            DataTable dt = khachHangDAO.getChiTietHoaDonGhiNo(maDonBan, soThuTu);

            // Kiểm tra xem DataTable có dữ liệu hay không
            if (dt != null && dt.Rows.Count > 0)
            {
                decimal tongKhachDaTra = 0;
                decimal tongHoaDon = 0;
                decimal tongKhachConNo = 0;

                foreach (DataRow row in dt.Rows)
                {

                    tongKhachDaTra = row.Field<decimal>("Số tiền đã trả");
                    tongHoaDon = row.Field<decimal>("Tổng giá trị");
                    tongKhachConNo = row.Field<decimal>("Số tiền còn lại chưa thanh toán");

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
            }
        }

        private void btn_HoanThanh_Click_1(object sender, EventArgs e)
        {
            UC_KhachHang uC = new UC_KhachHang();
            try
            {
                string maDonBan = selectedMaDonBan; // Replace with the actual selected value
                decimal soTienTraThem = Convert.ToDecimal(tbx_KhachTraThem.Text);

                // Call the update method
                if (khachHangDAO.UpdateSoTienConLai(maDonBan, soTienTraThem))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

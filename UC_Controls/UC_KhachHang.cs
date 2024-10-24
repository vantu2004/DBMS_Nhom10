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
    public partial class UC_KhachHang : UserControl
    {
        KhachHangDAO khachHangDAO = new KhachHangDAO();

        public UC_KhachHang()
        {
            InitializeComponent();
            LoadDanhSachKhachHang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            form_TaoKhachHang form_TaoKhachHang = new form_TaoKhachHang();

            form_TaoKhachHang.ShowDialog();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            form_KhachTraGop form_KhachTraGop = new form_KhachTraGop();

            form_KhachTraGop.ShowDialog();
        }

        private void LoadDanhSachKhachHang()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = khachHangDAO.GetDanhSachKhachHang();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachKhachHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_DanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                var selectedRow = dgv_DanhSachKhachHang.Rows[e.RowIndex];
                var maKhachHang = selectedRow.Cells["Mã Khách hàng"].Value;
                MessageBox.Show(maKhachHang.ToString());

                try
                {
                    // Lấy dữ liệu từ view
                    DataTable dt = khachHangDAO.getChiTietThanhToan(maKhachHang.ToString());
                    // Gán dữ liệu vào DataGridView
                    dgv_ChiTietThanhToan.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}

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
    public partial class UC_DonNhap : UserControl
    {
        DonNhapDAO donNhapDAO = new DonNhapDAO();
        public UC_DonNhap()
        {
            InitializeComponent();
            LoadDanhSachDonNhap();
        }

        private void btn_SuaDonNhap_Click(object sender, EventArgs e)
        {
            form_SuaDonNhap form_SuaDonNhap = new form_SuaDonNhap();

            form_SuaDonNhap.ShowDialog();
        }

        private void btn_TaoNhaCungCap_Click_1(object sender, EventArgs e)
        {
            form_TaoNhaCungCap form_TaoNhaCungCap = new form_TaoNhaCungCap();

            form_TaoNhaCungCap.ShowDialog();
        }

        private void btn_TaoDongMay_Click_1(object sender, EventArgs e)
        {
            form_TaoDongMay form_TaoDongMay = new form_TaoDongMay();

            string maDongMay = BienToanCuc.randomMa9So();

            form_TaoDongMay.ShowDialog();
        }

        private void LoadDanhSachDonNhap()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = donNhapDAO.GetDanhSachDonNhap();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachDonNhap.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_DanhSachDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                var selectedRow = dgv_DanhSachDonNhap.Rows[e.RowIndex];
                var maDonNhap = selectedRow.Cells["Mã đơn nhập"].Value;

                try
                {
                    // Lấy dữ liệu từ view
                    DataTable dt = donNhapDAO.getChiTietDonNhap(maDonNhap.ToString());
                    // Gán dữ liệu vào DataGridView
                    dgv_ChiTietDonNhap.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_TaoImei_Click(object sender, EventArgs e)
        {
            lbl_ImeiNgauNhien.Text = BienToanCuc.randomMa15So();
        }
    }
}

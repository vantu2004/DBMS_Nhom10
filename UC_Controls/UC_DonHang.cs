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
    public partial class UC_DonHang : UserControl
    {
        DonHangDAO donHangDAO = new DonHangDAO();
        public UC_DonHang()
        {
            InitializeComponent();
            LoadDanhSachDonHang();
            LoadDanhSachDienThoaiCoSan();
        }

        private void btn_TraGop_Click(object sender, EventArgs e)
        {
            form_SuaDonHang form_SuaDonHang = new form_SuaDonHang();
            form_SuaDonHang.ShowDialog();
        }

        private void btn_KhachHangMoi_Click_1(object sender, EventArgs e)
        {
            form_TaoKhachHang form_TaoKhachHang = new form_TaoKhachHang();

            form_TaoKhachHang.ShowDialog();
        }

        private void LoadDanhSachDonHang()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = donHangDAO.GetDanhSachDonHang();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachDonHang.DataSource = dt; 
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message); 
            }
        }

        private void dgv_DanhSachDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                var selectedRow = dgv_DanhSachDonHang.Rows[e.RowIndex];
                var maDonBan = selectedRow.Cells["Mã đơn bán"].Value;
                
                try
                {
                    // Lấy dữ liệu từ view
                    DataTable dt = donHangDAO.getChiTietDonHang(maDonBan.ToString());
                    // Gán dữ liệu vào DataGridView
                    dgv_ChiTietDonHang.DataSource = dt; 
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message); 
                }
            }
        }

        private void LoadDanhSachDienThoaiCoSan()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = donHangDAO.GetDanhSachDienThoaiCoSan();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachDienThoaiSanCo.DataSource = dt;

                // Kiểm tra xem đã có cột Button chưa, nếu chưa thì thêm vào
                if (!dgv_DanhSachDienThoaiSanCo.Columns.Contains("ActionButton"))
                {
                    // Tạo cột Button
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

                    buttonColumn.Name = "col_ThemDienThoai";
                    buttonColumn.HeaderText = "";
                    buttonColumn.Text = "Thêm";
                    buttonColumn.UseColumnTextForButtonValue = true; 

                    // Thêm cột Button vào DataGridView
                    dgv_DanhSachDienThoaiSanCo.Columns.Add(buttonColumn);

                    // Gọi event click cho button
                    dgv_DanhSachDienThoaiSanCo.CellContentClick += dgv_DanhSachDienThoaiSanCo_CellContentClick;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void dgv_DanhSachDienThoaiSanCo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được click là cột Button
            if (e.ColumnIndex == dgv_DanhSachDienThoaiSanCo.Columns["col_ThemDienThoai"].Index && e.RowIndex >= 0)
            {
                // Lấy Imei điện thoại của hàng được click
                string maDienThoai = dgv_DanhSachDienThoaiSanCo.Rows[e.RowIndex].Cells["Mã Imei"].Value.ToString();

                // Xử lý logic khi nút bấm được click, ví dụ: hiện chi tiết hoặc xử lý hàng đó
                MessageBox.Show("Bạn đã chọn điện thoại: " + maDienThoai);
            }
        }

        private void tab_DanhSachDonHang_Click(object sender, EventArgs e)
        {

        }
    }
}

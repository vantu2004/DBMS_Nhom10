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
    public partial class UC_NhanVien : UserControl
    {
        NhanVienDAO nhanVienDAO = new NhanVienDAO();

        public UC_NhanVien()
        {
            InitializeComponent();
            LoadDanhSachNhanVien();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string soDienThoai = tbx_TimSoDienThoai.Text.Trim();
            if (!string.IsNullOrEmpty(soDienThoai))
            {
                NhanVienDAO nhanVienDAO = new NhanVienDAO();
                DataTable dt = nhanVienDAO.TimKiemNhanVienTheoSDT(soDienThoai);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Tạo form sửa nhân viên và truyền thông tin vào form
                    form_SuaNhanVien formSua = new form_SuaNhanVien();

                    // Gán giá trị từ DataRow vào các textbox và combobox của form
                    formSua.tbx_MaNhanVien.Text = row["Ma_nhan_vien"].ToString();
                    formSua.tbx_TenNhanVien.Text = row["Ten_nhan_vien"].ToString();
                    formSua.tbx_Gmail.Text = row["Gmail"].ToString();
                    formSua.tbx_SoDienThoai.Text = row["SDT"].ToString();
                    formSua.tbx_MatKhau.Text = row["Mat_khau"].ToString();
                    formSua.cbx_ChucVu.Text = row["Chuc_vu"].ToString();

                    // Hiển thị form sửa
                    formSua.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên với số điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadDanhSachNhanVien()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = nhanVienDAO.GetDanhSachNhanVien();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachNhanVien.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            string tenNhanVien = tbx_TenNhanVien.Text.Trim();
            string gmail = tbx_Gmail.Text.Trim();
            string soDienThoai = tbx_SoDienThoai.Text.Trim();
            string matKhau = tbx_MatKhau.Text.Trim();
            string chucVu = cbx_ChucVu.SelectedItem?.ToString() ?? string.Empty;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(tenNhanVien) || string.IsNullOrEmpty(gmail) ||
                string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(chucVu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm ThemNhanVien trong class NhanVienDAO

            try
            {
                bool isSuccess = nhanVienDAO.ThemNhanVien(tenNhanVien, gmail, soDienThoai, matKhau, chucVu);

                if (isSuccess)
                {
                    MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Xử lý tiếp nếu cần, ví dụ: làm trống các ô nhập
                    tbx_TenNhanVien.Clear();
                    tbx_Gmail.Clear();
                    tbx_SoDienThoai.Clear();
                    tbx_MatKhau.Clear();
                    cbx_ChucVu.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaNhanVien_Click(object sender, EventArgs e)
        {
            string soDienThoai = tbx_TimSoDienThoai.Text.Trim();

            if (!string.IsNullOrEmpty(soDienThoai))
            {

                bool isDeleted = nhanVienDAO.XoaNhanVienTheoSDT(soDienThoai);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TìmSoDienThoai_Click(object sender, EventArgs e)
        {
            string soDienThoai = tbx_TimSoDienThoai.Text.Trim();
            if (!string.IsNullOrEmpty(soDienThoai))
            {
                NhanVienDAO nhanVienDAO = new NhanVienDAO();
                DataTable dt = nhanVienDAO.TimKiemNhanVienTheoSDT(soDienThoai);

                if (dt.Rows.Count > 0)
                {
                    // Hiển thị dữ liệu trong DataGridView
                    dgv_DanhSachNhanVien.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên với số điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_DanhSachNhanVien.DataSource = null; // Xóa dữ liệu trong DataGridView nếu không tìm thấy
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}

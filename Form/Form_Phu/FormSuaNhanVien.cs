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
    public partial class form_SuaNhanVien : Form
    {

        public form_SuaNhanVien()
        {
            InitializeComponent();
        }

        private void form_SuaNhanVien_Load(object sender, EventArgs e)
        {

        }

        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            string tenNhanVien = tbx_TenNhanVien.Text.Trim();
            string MaNhanVien = tbx_MaNhanVien.Text.Trim();
            string gmail = tbx_Gmail.Text.Trim();
            string soDienThoai = tbx_SoDienThoai.Text.Trim();
            string matKhau = tbx_MatKhau.Text.Trim();
            string chucVu = cbx_ChucVu.Text;

            // Gọi phương thức cập nhật từ NhanVienDAO
            bool isUpdated = nhanVienDAO.CapNhatThongTinNhanVien(MaNhanVien, tenNhanVien, gmail, soDienThoai, matKhau, chucVu);

            if (isUpdated)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
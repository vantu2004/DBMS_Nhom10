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
            form_SuaNhanVien form_SuaNhanVien = new form_SuaNhanVien();

            form_SuaNhanVien.ShowDialog();
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
    }
}

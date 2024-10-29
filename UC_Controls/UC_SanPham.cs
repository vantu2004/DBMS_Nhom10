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
    public partial class UC_SanPham : UserControl
    {
        SanPhamDAO sanPhamDAO = new SanPhamDAO();
        public UC_SanPham()
        {
            InitializeComponent();
            LoadDanhSachDienThoaiCoSan();
            LoadDanhSachDienThoaiCanCapNhat();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            form_SuaSanPham form_SuaSanPham = new form_SuaSanPham();

            form_SuaSanPham.ShowDialog();
        }

        private void LoadDanhSachDienThoaiCoSan()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = sanPhamDAO.GetDanhSachDienThoaiCoSan();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachSanPham.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void LoadDanhSachDienThoaiCanCapNhat()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = sanPhamDAO.GetDanhSachDienThoaiCanCapNhat();
                // Gán dữ liệu vào DataGridView
                dgv_SamPhamCanCapNhat.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
    }
}

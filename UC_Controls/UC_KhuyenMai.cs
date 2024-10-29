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
    public partial class UC_KhuyenMai : UserControl
    {
        KhuyenMaiDAO khuyenMaiDAO = new KhuyenMaiDAO();

        public UC_KhuyenMai()
        {
            InitializeComponent();
            LoadDanhSachMaKhuyenMai();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            form_SuaMaKhuyenMai form_SuaMaKhuyenMai = new form_SuaMaKhuyenMai();

            form_SuaMaKhuyenMai.ShowDialog();
        }

        private void LoadDanhSachMaKhuyenMai()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = khuyenMaiDAO.GetDanhSachMaKhuyenMai();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachMaKhuyenMai.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

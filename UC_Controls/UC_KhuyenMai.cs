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

            if (!string.IsNullOrEmpty(tbx_TimMaKhuyenMai.Text) && khuyenMaiDAO.KiemTraMaKhuyenMai(tbx_TimMaKhuyenMai.Text))
            {
                form_SuaMaKhuyenMai.MaKhuyenmai = tbx_TimMaKhuyenMai.Text;
                form_SuaMaKhuyenMai.LoadThongTinMaKM();
                form_SuaMaKhuyenMai.ShowDialog();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                KhuyenMai khuyenMai = new KhuyenMai();

                khuyenMai.MaKhuyenMai = BienToanCuc.randomMa9So();
                khuyenMai.TenChuongTrinh = tbx_TenChuongTrinh.Text;
                khuyenMai.SoLuongApDung = Convert .ToInt32(tbx_SoLuong.Text);
                khuyenMai.ChietKhau = Convert.ToDecimal(tbx_ChietKhau.Text);
                khuyenMai.NgayApDung = Convert.ToDateTime(dtp_NgayBatDau.Value).Date;
                khuyenMai.NgayKetThuc = Convert.ToDateTime(dtp_NgayKetThuc.Value).Date;

                khuyenMaiDAO.TaoKhuyenMai(khuyenMai);

                MessageBox.Show("Tạo mã khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không để trống thông tin hoặc nhập sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private bool checkNull()
        {
            // Kiểm tra các TextBox không trống
            if (string.IsNullOrEmpty(tbx_TenChuongTrinh.Text) ||
                string.IsNullOrEmpty(tbx_SoLuong.Text) ||
                string.IsNullOrEmpty(tbx_ChietKhau.Text))
            {
                return false;
            }

            // Kiểm tra tbx_SoLuong và tbx_ChietKhau có phải là số hợp lệ
            if (!int.TryParse(tbx_SoLuong.Text, out _) || !double.TryParse(tbx_ChietKhau.Text, out _))
            {
                return false;
            }

            return true;
        }

        private void btn_TìmMaKhuyenMai_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbx_TimMaKhuyenMai.Text, out _) || !string.IsNullOrEmpty(tbx_TimMaKhuyenMai.Text))
            {
                DataTable dt = khuyenMaiDAO.LayThongTinKhuyenMai(tbx_TimMaKhuyenMai.Text);
                dgv_DanhSachMaKhuyenMai.DataSource = dt;
            }
        }

        private void btn_XoaMaKhuyenMai_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbx_TimMaKhuyenMai.Text, out _) || !string.IsNullOrEmpty(tbx_TimMaKhuyenMai.Text))
            {
                if (khuyenMaiDAO.XoaMaKhuyenMai(tbx_TimMaKhuyenMai.Text))
                {
                    MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa mã khuyến mãi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

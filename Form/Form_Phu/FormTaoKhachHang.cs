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
    public partial class form_TaoKhachHang : Form
    {
        public form_TaoKhachHang()
        {
            InitializeComponent();
            
        }
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        UC_KhachHang UC_KhachHang = new UC_KhachHang(); 
        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            
            string sdt = tbx_SoDienThoai.Text;
            string tenKhachHang = tbx_TenKhachHang.Text;
            string diaChi = tbx_DiaChi.Text;
            string gmail = tbx_Gmail.Text;

            // Gọi phương thức cập nhật
            bool result = khachHangDAO.capNhatThongTinKhachHang(sdt, tenKhachHang, diaChi, gmail);

            if (result)
            {
                UC_KhachHang.LoadDanhSachKhachHang();
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Đóng form sau khi cập nhật thành công
                this.Close();

            }
            else
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void LoadThongTinKhachHang(string sdt)
        {
            DataTable dt = khachHangDAO.traCuuTheoSDTKhachHang(sdt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbx_TenKhachHang.Text = row["Tên khách hàng"].ToString();
                tbx_DiaChi.Text = row["Địa chỉ"].ToString();
                tbx_Gmail.Text = row["Gmail"].ToString();
                tbx_SoDienThoai.Text = row["Số điện thoại"].ToString();
                tbx_SoDienThoai.ReadOnly = true; // Make phone number read-only
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}

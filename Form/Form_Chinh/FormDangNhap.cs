using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Nhom11
{
    public partial class form_DangNhap : Form
    {
        DangNhapDAO dangNhapDAO = new DangNhapDAO();

        public form_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = tbx_TenDangNhap.Text;
            string matKhau = tbx_MatKhau.Text;

            string xacThucNguoiDung;

            if (!string.IsNullOrEmpty(tenDangNhap) && !string.IsNullOrEmpty(matKhau) && (rbn_Admin.Checked || rbn_NhanVien.Checked))
            {
                if (rbn_Admin.Checked)
                {
                    xacThucNguoiDung = dangNhapDAO.getAdmin(tenDangNhap, matKhau);
                    if (string.IsNullOrEmpty(xacThucNguoiDung))
                    {
                        MessageBox.Show("Người dùng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //  vì là admin nên set mã nhân viên là null
                        BienToanCuc.MaNhanVien = null;

                        form_QuanLy form_QuanLy = new form_QuanLy();
                        form_QuanLy.ShowDialog();
                    }
                }
                else if (rbn_NhanVien.Checked)
                {
                    xacThucNguoiDung = dangNhapDAO.getNhanVien(tenDangNhap, matKhau);
                    if (string.IsNullOrEmpty(xacThucNguoiDung))
                    {
                        MessageBox.Show("Người dùng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //  set mã nhân viên 
                        BienToanCuc.MaNhanVien = xacThucNguoiDung;

                        form_QuanLy form_QuanLy = new form_QuanLy();

                        //  giới hạn quyền
                        form_QuanLy.btn_DonNhap.Enabled = false;
                        form_QuanLy.btn_KhuyenMai.Enabled = false;
                        form_QuanLy.btn_ThongKe.Enabled = false;
                        form_QuanLy.btn_NhanVien.Enabled = false;
                        
                        form_QuanLy.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

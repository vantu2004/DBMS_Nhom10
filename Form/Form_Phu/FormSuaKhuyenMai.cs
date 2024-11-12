using Nhom11.Class;
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
    public partial class form_SuaMaKhuyenMai : Form
    {
        string maKhuyenmai;

        KhuyenMaiDAO khuyenMaiDAO = new KhuyenMaiDAO();

        public form_SuaMaKhuyenMai()
        {
            InitializeComponent();
        }

        public string MaKhuyenmai { get => maKhuyenmai; set => maKhuyenmai = value; }

        private bool checkNull()
        {
            // Kiểm tra các TextBox không trống
            if (string.IsNullOrEmpty(tbx_TenChuongTrinh.Text) ||
                string.IsNullOrEmpty(tbx_SoLuong.Text))
            {
                return false;
            }

            // Kiểm tra tbx_SoLuong và tbx_ChietKhau có phải là số hợp lệ
            if (!int.TryParse(tbx_SoLuong.Text, out _))
            {
                return false;
            }

            return true;
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                KhuyenMai khuyenMai = new KhuyenMai();

                khuyenMai.MaKhuyenMai = MaKhuyenmai;
                khuyenMai.TenChuongTrinh = tbx_TenChuongTrinh.Text;
                khuyenMai.SoLuongApDung = Convert.ToInt32(tbx_SoLuong.Text);
                khuyenMai.NgayApDung = Convert.ToDateTime(dtp_NgayBatDau.Value).Date;
                khuyenMai.NgayKetThuc = Convert.ToDateTime(dtp_NgayKetThuc.Value).Date;

                khuyenMaiDAO.SuaKhuyenMai(khuyenMai);

                MessageBox.Show("Sửa mã khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Không để trống thông tin hoặc nhập sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void LoadThongTinMaKM()
        {
            DataTable dt = khuyenMaiDAO.LayThongTinKhuyenMai(MaKhuyenmai);

            // Kiểm tra nếu DataTable có dữ liệu
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Lấy hàng đầu tiên từ DataTable

                tbx_TenChuongTrinh.Text = row["Ten_chuong_trinh"].ToString();
                tbx_SoLuong.Text = row["SL_ap_dung"].ToString();

                // Kiểm tra và chuyển đổi giá trị ngày nếu không NULL
                if (row["Ngay_ap_dung"] != DBNull.Value)
                    dtp_NgayBatDau.Value = Convert.ToDateTime(row["Ngay_ap_dung"]);
                if (row["Ngay_ket_thuc"] != DBNull.Value)
                    dtp_NgayKetThuc.Value = Convert.ToDateTime(row["Ngay_ket_thuc"]);
            }
        }
    }
}

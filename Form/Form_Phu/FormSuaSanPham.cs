using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11
{
    public partial class form_SuaSanPham : Form
    {
        SanPhamDAO sanPhamDAO = new SanPhamDAO();
        public form_SuaSanPham()
        {
            InitializeComponent();
        }

        private void btn_TaoDongMay_Click(object sender, EventArgs e)
        {
            form_TaoDongMay form_TaoDongMay = new form_TaoDongMay();

            form_TaoDongMay.ShowDialog();
        }

        public void LoadThongTinSanPham(string imei)
        {
            DataTable dt = sanPhamDAO.getChiTietSanPham(imei);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbx_Imei.Text = row["Mã Imei"].ToString();
                tbx_GiaNhap.Text = row["Giá nhập"].ToString();
                tbx_GiaBan.Text = row["Giá bán"].ToString();
                tbx_Thue.Text = row["Thuế"].ToString();
                tbx_MauSac.Text = row["Màu sắc"].ToString();
                DataTable dtMaDongMay = sanPhamDAO.GetMaDongMay();

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các textbox 
                string maImei = tbx_Imei.Text;

                // Chuyển đổi giá trị từ các textbox sang decimal
                if (!decimal.TryParse(tbx_GiaNhap.Text, out decimal giaNhap))
                {
                    MessageBox.Show("Giá nhập không hợp lệ. Vui lòng nhập số hợp lệ.");
                    return;
                }

                if (!decimal.TryParse(tbx_GiaBan.Text, out decimal giaBan))
                {
                    MessageBox.Show("Giá bán không hợp lệ. Vui lòng nhập số hợp lệ.");
                    return;
                }

                if (!decimal.TryParse(tbx_Thue.Text, out decimal thue))
                {
                    MessageBox.Show("Thuế không hợp lệ. Vui lòng nhập số hợp lệ.");
                    return;
                }

                string mauSac = tbx_MauSac.Text;
                /*string maDongMay = cbx_ChonDongMay.SelectedValue.ToString();*/

                // Kiểm tra và chuyển đổi hình ảnh thành byte[]
                byte[] hinhAnhData = null;
                if (pbx_HinhAnh.Image != null)
                {
                    hinhAnhData = sanPhamDAO.ImageToByte(pbx_HinhAnh.Image);
                }

                // Gọi phương thức cập nhật sản phẩm
                sanPhamDAO.CapNhatSanPham(maImei, giaNhap, giaBan, thue, mauSac, hinhAnhData);

                MessageBox.Show("Cập nhật sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sản phẩm: Chưa điền đầy đủ thông tin bao gồm ảnh ");
            }
        }
        public void LoadImage(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (var ms = new MemoryStream(imageData))
                {
                    pbx_HinhAnh.Image = Image.FromStream(ms);
                    pbx_HinhAnh.SizeMode = PictureBoxSizeMode.Zoom; // Để hình ảnh vừa với PictureBox
                }
            }
            else
            {
                MessageBox.Show("Không có hình ảnh để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_ThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbx_HinhAnh.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }


    }
}

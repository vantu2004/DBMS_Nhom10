using Nhom11.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

            string maImei = tbx_NhapImei.Text.Trim();

            // Kiểm tra nếu mã IMEI không rỗng
            if (!string.IsNullOrEmpty(maImei))
            {
                // Tạo form sửa sản phẩm và truyền mã IMEI vào form
                form_SuaSanPham form_SuaSanPham = new form_SuaSanPham();

                // Gọi phương thức LoadThongTinSanPham để load dữ liệu lên form
                form_SuaSanPham.LoadThongTinSanPham(maImei);

                // Tìm hàng chứa mã IMEI trong DataGridView
                DataGridViewRow selectedRow = null;
                foreach (DataGridViewRow row in dgv_DanhSachSanPham.Rows)
                {
                    if (row.Cells["Mã Imei"].Value?.ToString() == maImei)
                    {
                        selectedRow = row;
                        break;
                    }
                }

                // Nếu tìm thấy hàng và có ảnh, truyền ảnh vào form
                if (selectedRow != null)
                {
                    // Thêm thông báo kiểm tra giá trị hình ảnh
                    if (selectedRow.Cells["Hình ảnh"].Value != DBNull.Value && selectedRow.Cells["Hình ảnh"].Value is byte[])
                    {
                        byte[] imageData = (byte[])selectedRow.Cells["Hình ảnh"].Value;
                        form_SuaSanPham.LoadImage(imageData);
                    }

                }
                else
                {

                }

                // Hiển thị form sửa sản phẩm
                form_SuaSanPham.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã IMEI để sửa sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                DataTable dt2 = sanPhamDAO.GetDanhSachDienThoaiCoSan();

                // Gán dữ liệu vào DataGridView
                dgv_SamPhamCanCapNhat.DataSource = dt;
                dgv_DanhSachSanPham.DataSource = dt2;

                // Tạo cột nút "Xem ảnh" nếu chưa tồn tại trong dgv_SamPhamCanCapNhat
                if (!dgv_SamPhamCanCapNhat.Columns.Contains("XemAnh"))
                {
                    DataGridViewButtonColumn btnColumn1 = new DataGridViewButtonColumn();
                    btnColumn1.Name = "XemAnh";
                    btnColumn1.HeaderText = "Xem ảnh";
                    btnColumn1.Text = "Xem ảnh";
                    btnColumn1.UseColumnTextForButtonValue = true; // Hiển thị văn bản trên nút
                    dgv_SamPhamCanCapNhat.Columns.Add(btnColumn1);
                }

                // Tạo cột nút "Xem ảnh" nếu chưa tồn tại trong dgv_DanhSachSanPham
                if (!dgv_DanhSachSanPham.Columns.Contains("XemAnh"))
                {
                    DataGridViewButtonColumn btnColumn2 = new DataGridViewButtonColumn();
                    btnColumn2.Name = "XemAnh";
                    btnColumn2.HeaderText = "Xem ảnh";
                    btnColumn2.Text = "Xem ảnh";
                    btnColumn2.UseColumnTextForButtonValue = true; // Hiển thị văn bản trên nút
                    dgv_DanhSachSanPham.Columns.Add(btnColumn2);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        // Xử lý sự kiện nhấn nút trong DataGridView
        private void dgv_SamPhamCanCapNhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_SamPhamCanCapNhat.Columns["XemAnh1"].Index && e.RowIndex >= 0)
            {
                string imagePath = dgv_SamPhamCanCapNhat.Rows[e.RowIndex].Cells["Hình ảnh"].Value.ToString();

                if (System.IO.File.Exists(imagePath))
                {
                    frmXemAnh xemAnhForm = new frmXemAnh(imagePath);
                    xemAnhForm.ShowDialog(); // Hiển thị form xem ảnh
                }
                else
                {
                    MessageBox.Show("Hình ảnh không tồn tại.");
                }
            }
        }
        private void dgv_DanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_DanhSachSanPham.Columns["XemAnh"].Index && e.RowIndex >= 0)
            {
                // Kiểm tra giá trị trong cột "Hình ảnh"
                if (dgv_DanhSachSanPham.Rows[e.RowIndex].Cells["Hình ảnh"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])dgv_DanhSachSanPham.Rows[e.RowIndex].Cells["Hình ảnh"].Value;

                    // Tạo đường dẫn file tạm
                    string tempFilePath = Path.Combine(Path.GetTempPath(), $"tempImage_{Guid.NewGuid()}.png");

                    // Ghi ảnh vào file tạm
                    try
                    {
                        File.WriteAllBytes(tempFilePath, imageData);

                        // Mở form xem ảnh
                        frmXemAnh xemAnhForm = new frmXemAnh(tempFilePath);
                        xemAnhForm.ShowDialog(); // Hiển thị form xem ảnh
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show($"Lỗi khi ghi tệp: {ioEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}");
                    }
                    finally
                    {
                        // Xóa tệp tạm sau khi sử dụng (nếu cần)
                        if (File.Exists(tempFilePath))
                        {
                            try
                            {
                                File.Delete(tempFilePath);
                            }
                            catch (IOException ioEx) { }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hình ảnh không tồn tại.");
                }
            }
        }


        private void dgv_SamPhamCanCapNhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                var selectedRow = dgv_SamPhamCanCapNhat.Rows[e.RowIndex];
                var maImei = selectedRow.Cells["Mã Imei"].Value;


                try
                {
                    // Lấy dữ liệu từ view
                    DataTable dt = sanPhamDAO.getChiTietSanPham(maImei.ToString());
                    this.LoadThongTinSanPham(maImei.ToString());
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
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
                cbx_ChonDongMay.DataSource = dtMaDongMay;
                cbx_ChonDongMay.DisplayMember = "Ma_dong_may";
                tbx_Imei.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pbx_HinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các textbox và combobox
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
                MessageBox.Show("Lỗi khi cập nhật sản phẩm: " + ex.Message);
            }


        }

        private void dgv_SamPhamCanCapNhat_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_SamPhamCanCapNhat.Columns["XemAnh"].Index && e.RowIndex >= 0)
            {
                // Kiểm tra giá trị trong cột "Hình ảnh"
                if (dgv_SamPhamCanCapNhat.Rows[e.RowIndex].Cells["Hình ảnh"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])dgv_SamPhamCanCapNhat.Rows[e.RowIndex].Cells["Hình ảnh"].Value;

                    // Tạo đường dẫn file tạm
                    string tempFilePath = Path.Combine(Path.GetTempPath(), $"tempImage_{Guid.NewGuid()}.png");

                    // Ghi ảnh vào file tạm
                    try
                    {
                        File.WriteAllBytes(tempFilePath, imageData);

                        // Mở form xem ảnh
                        frmXemAnh xemAnhForm = new frmXemAnh(tempFilePath);
                        xemAnhForm.ShowDialog(); // Hiển thị form xem ảnh
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show($"Lỗi khi ghi tệp: {ioEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}");
                    }
                    finally
                    {
                        // Xóa tệp tạm sau khi sử dụng (nếu cần)
                        if (File.Exists(tempFilePath))
                        {
                            try
                            {
                                File.Delete(tempFilePath);
                            }
                            catch (IOException ioEx) { }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hình ảnh không tồn tại.");
                }
            }
        }

        private void btn_TìmSanPham_Click(object sender, EventArgs e)
        {
            string sdt = tbx_TimSanPham.Text.Trim();

            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập tên điện thoại cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                DataTable dt = sanPhamDAO.traCuuTheoTenDT(sdt);

                if (dt.Rows.Count > 0)
                {
                    dgv_DanhSachSanPham.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        form_SuaSanPham srmssp = new form_SuaSanPham();
        private void dgv_DanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                var selectedRow = dgv_DanhSachSanPham.Rows[e.RowIndex];
                var maImei = selectedRow.Cells["Mã Imei"].Value;


                try
                {
                    // Lấy dữ liệu từ view
                    DataTable dt = sanPhamDAO.getChiTietSanPham(maImei.ToString());
                    srmssp.LoadThongTinSanPham(maImei.ToString());
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_TaoDongMay_Click(object sender, EventArgs e)
        {

        }

        //private void btn_XoaSanPham_Click(object sender, EventArgs e)
        //{
        //    string maImei = tbx_NhapImei.Text.Trim();

        //    // Kiểm tra nếu mã IMEI không rỗng
        //    if (!string.IsNullOrEmpty(maImei))
        //    {
        //        try
        //        {
        //            // Gọi phương thức xóa sản phẩm
        //            bool isDeleted = sanPhamDAO.XoaSanPhamTheoImei(maImei);

        //            // Kiểm tra kết quả xóa
        //            if (isDeleted)
        //            {
        //                MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng nhập mã IMEI để xóa sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}

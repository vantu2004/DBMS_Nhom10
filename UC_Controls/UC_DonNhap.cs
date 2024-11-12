using Nhom11.Class;
using Nhom11.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom11
{
    public partial class UC_DonNhap : UserControl
    {
        DonNhapDAO donNhapDAO = new DonNhapDAO();
        int soLuongDienThoaiDonNhap = 0;
        decimal triGiaDonNhap = 0;

        public UC_DonNhap()
        {
            InitializeComponent();
            LoadDanhSachDonNhap();
            LoadMaNhaCungCap();
            LoadMaDongMay();

            dgv_DanhSachDienThoai.CellContentClick += new DataGridViewCellEventHandler(dgv_DanhSachDienThoai_CellContentClick);
        }

        private void btn_SuaDonNhap_Click(object sender, EventArgs e)
        {
            form_SuaDonNhap form_SuaDonNhap = new form_SuaDonNhap();

            form_SuaMaKhuyenMai form_SuaMaKhuyenMai = new form_SuaMaKhuyenMai();

            if (!string.IsNullOrEmpty(tbx_TimDonNhap.Text) && donNhapDAO.KiemTraMaDonNhap(tbx_TimDonNhap.Text))
            {
                form_SuaDonNhap.MaDonNhap = tbx_TimDonNhap.Text;
                form_SuaDonNhap.LoadThongTinMaDonNhap();
                form_SuaDonNhap.ShowDialog();
            }
        }

        private void btn_TaoNhaCungCap_Click_1(object sender, EventArgs e)
        {
            form_TaoNhaCungCap form_TaoNhaCungCap = new form_TaoNhaCungCap();

            form_TaoNhaCungCap.ShowDialog();

            LoadMaNhaCungCap();
        }

        private void btn_TaoDongMay_Click_1(object sender, EventArgs e)
        {
            form_TaoDongMay form_TaoDongMay = new form_TaoDongMay();

            form_TaoDongMay.ShowDialog();

            LoadMaDongMay();
        }

        private void LoadDanhSachDonNhap()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = donNhapDAO.GetDanhSachDonNhap();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachDonNhap.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_DanhSachDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                var selectedRow = dgv_DanhSachDonNhap.Rows[e.RowIndex];
                var maDonNhap = selectedRow.Cells["Mã đơn nhập"].Value;

                try
                {
                    // Lấy dữ liệu từ view
                    DataTable dt = donNhapDAO.getChiTietDonNhap(maDonNhap.ToString());
                    // Gán dữ liệu vào DataGridView
                    dgv_ChiTietDonNhap.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_TaoImei_Click(object sender, EventArgs e)
        {
            lbl_ImeiNgauNhien.Text = BienToanCuc.randomMa15So();
        }

        private void LoadMaDongMay()
        {
            List<string> maDongMay = donNhapDAO.LoadMaDongMay();

            cbx_ChonDongMay.Items.Clear();
            foreach (string item in maDongMay)
            {
                cbx_ChonDongMay.Items.Add(item);
            }
        }

        private void LoadMaNhaCungCap()
        {
            List<string> maNhaCungCap = donNhapDAO.LoadMaNhaCungCap();

            cbx_ChonNhaCungCap.Items.Clear();
            foreach (string item in maNhaCungCap)
            {
                cbx_ChonNhaCungCap.Items.Add(item);
            }

            cbx_MaNCC.Items.Clear();
            foreach (string item in maNhaCungCap)
            {
                cbx_MaNCC.Items.Add(item);
            }
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                DongMay dongMay = donNhapDAO.LayThongTinDongMay(cbx_ChonDongMay.Text);
                
                // Tạo một hàng mới
                int rowIndex = dgv_DanhSachDienThoai.Rows.Add();

                // Gán giá trị cho từng ô trong hàng mới dựa trên tên cột
                dgv_DanhSachDienThoai.Rows[rowIndex].Cells["maDongMay"].Value = dongMay.MaDongMay;
                dgv_DanhSachDienThoai.Rows[rowIndex].Cells["tenDongMay"].Value = dongMay.TenDongMay;
                dgv_DanhSachDienThoai.Rows[rowIndex].Cells["manHinh"].Value = dongMay.KichThuocManHinh;
                dgv_DanhSachDienThoai.Rows[rowIndex].Cells["pin"].Value = dongMay.DungLuongPin;
                dgv_DanhSachDienThoai.Rows[rowIndex].Cells["Imei"].Value = lbl_ImeiNgauNhien.Text;
                dgv_DanhSachDienThoai.Rows[rowIndex].Cells["giaBan"].Value = tbx_GiaBan.Text;
                dgv_DanhSachDienThoai.Rows[rowIndex].Cells["giaNhap"].Value = tbx_GiaNhap.Text;

                //  sau khi tạo xong thì set lại trạng thái
                lbl_ImeiNgauNhien.Text = "Imei ngẫu nhiên";
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool checkNull()
        {
            if (string.IsNullOrEmpty(cbx_ChonNhaCungCap.Text) || string.IsNullOrEmpty(tbx_GiaNhap.Text) || string.IsNullOrEmpty(tbx_GiaBan.Text) 
                || lbl_ImeiNgauNhien.Text == "Imei ngẫu nhiên" || string.IsNullOrEmpty(cbx_ChonDongMay.Text))
            {
                return false;
            }
            return true;
        }

        private void dgv_DanhSachDienThoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn vào cột button "Xóa"
            if (e.ColumnIndex == dgv_DanhSachDienThoai.Columns["xoa"].Index && e.RowIndex >= 0)
            {
                // Xác nhận hành động xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dgv_DanhSachDienThoai.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            DataTable dt = LayDanhSachDienThoaiTuDgv();
            DonNhap donNhap = ThongTinDonNhap();
            DataTable chiTietDonNhap = TaoDuLieuChiTietDonNhap(donNhap.MaDonNhap);

            if (dt != null)
            {
                donNhapDAO.ThemDienThoaiTuDonNhap(dt);
                donNhapDAO.TaoDonNhap(donNhap);
                donNhapDAO.ThemChiTietDonNhap(chiTietDonNhap);

                //  sau khi tạo xong thì set lại trạng thái
                lbl_ImeiNgauNhien.Text = "Imei ngẫu nhiên";

                MessageBox.Show("Tạo đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // set lại 2 biến về 0 để tạo đơn nhập liên tục
                soLuongDienThoaiDonNhap = 0;
                triGiaDonNhap = 0;

            }
            else
            {
                MessageBox.Show("Vui lòng thêm điện thoại vào đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private DataTable LayDanhSachDienThoaiTuDgv()
        {
            // Kiểm tra xem DataGridView có dữ liệu hay không
            if (dgv_DanhSachDienThoai.Rows.Count == 0 || dgv_DanhSachDienThoai.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                return null;
            }

            // Tạo DataTable để chứa dữ liệu từ DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("Ma_Imei", typeof(string));
            dt.Columns.Add("Hinh_anh", typeof(byte[])); // Hình ảnh kiểu byte[]
            dt.Columns.Add("Mau_sac", typeof(string));
            dt.Columns.Add("Trang_thai", typeof(string));
            dt.Columns.Add("Gia_nhap", typeof(decimal));
            dt.Columns.Add("Gia_ban", typeof(decimal));
            dt.Columns.Add("Thue", typeof(decimal));
            dt.Columns.Add("Ma_dong_may", typeof(string));

            // Lấy dữ liệu từ DataGridView và thêm vào DataTable
            foreach (DataGridViewRow row in dgv_DanhSachDienThoai.Rows)
            {
                // Tránh thêm dòng mới (empty row)
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow["Ma_Imei"] = row.Cells["Imei"].Value;
                    dataRow["Hinh_anh"] = DBNull.Value;
                    dataRow["Mau_sac"] = DBNull.Value;
                    dataRow["Trang_thai"] = DBNull.Value;

                    decimal giaNhap = Convert.ToDecimal(row.Cells["giaNhap"].Value);
                    dataRow["Gia_nhap"] = giaNhap;

                    dataRow["Gia_ban"] = row.Cells["giaBan"].Value != null ? Convert.ToDecimal(row.Cells["giaBan"].Value) : (object)DBNull.Value;
                    dataRow["Thue"] = DBNull.Value;
                    dataRow["Ma_dong_may"] = row.Cells["maDongMay"].Value;

                    dt.Rows.Add(dataRow);

                    soLuongDienThoaiDonNhap++;
                    triGiaDonNhap += giaNhap;
                }
            }

            return dt;
        }


        private DonNhap ThongTinDonNhap()
        {
            DonNhap donNhap = new DonNhap();
            donNhap.MaDonNhap = BienToanCuc.randomMa9So();
            donNhap.MaNCC = cbx_ChonNhaCungCap.Text;
            donNhap.MaNhanVien = BienToanCuc.MaNhanVien;
            donNhap.TriGia = triGiaDonNhap;
            donNhap.SoLuongDT = soLuongDienThoaiDonNhap;

            return donNhap;
        }

        private DataTable TaoDuLieuChiTietDonNhap(string maDonNhap)
        {
            // Kiểm tra xem DataGridView có dữ liệu hay không
            if (dgv_DanhSachDienThoai.Rows.Count == 0 || dgv_DanhSachDienThoai.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                return null;
            }

            // Tạo DataTable để chứa dữ liệu từ DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("Ma_Imei", typeof(string));
            dt.Columns.Add("Ma_don_nhap", typeof(string));

            // Lấy dữ liệu từ DataGridView và thêm vào DataTable
            foreach (DataGridViewRow row in dgv_DanhSachDienThoai.Rows)
            {
                // Tránh thêm dòng mới (empty row)
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow["Ma_Imei"] = row.Cells["Imei"].Value;
                    dataRow["Ma_don_nhap"] = maDonNhap;

                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }

        private void btn_TìmDonNhap_Click(object sender, EventArgs e)
        {
            string maNhaCungCap = cbx_MaNCC.Text;

            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = donNhapDAO.GetDanhSachDonNhapMaNCC(maNhaCungCap);
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachDonNhap.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_XoaDonNhap_Click(object sender, EventArgs e)
        {
            string maDonNhap = tbx_TimDonNhap.Text;

            if (!string.IsNullOrEmpty(maDonNhap) && donNhapDAO.KiemTraMaDonNhap(maDonNhap))
            {
                if (donNhapDAO.XoaDonNhap(maDonNhap))
                {
                    MessageBox.Show("Xóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa đơn nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

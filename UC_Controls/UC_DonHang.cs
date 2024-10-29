using DevExpress.Data.Filtering.Helpers;
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
    public partial class UC_DonHang : UserControl
    {
        DonHangDAO donHangDAO = new DonHangDAO();
        public UC_DonHang()
        {
            InitializeComponent();
            LoadDanhSachDonHang();
            LoadDanhSachDienThoaiCoSan();
            //LoadSDTNhanVien_vao_cbx();
            LoadSDTKhachHang_vao_cbx();
            LoadMaKhuyenMai_vao_cbx();
            LoadFilter_vao_4_cbx();
        }

        private void btn_TraGop_Click(object sender, EventArgs e)
        {
            form_SuaDonHang form_SuaDonHang = new form_SuaDonHang();
            

            string maDonHang = tbx_MaDonHang.Text;

           
            List<string> thongTinDonHang = donHangDAO.DienThongTinDonHang(maDonHang);

            //   kiểm tra nếu nhập đúng mã đơn bán thì fill, ko đúng thì thôi
            if (thongTinDonHang != null)
            {
                //form_SuaDonHang.cbx_ChonNhanVien.Text = thongTinDonHang[13];
                form_SuaDonHang.cbx_ChonKhachHang.Text = thongTinDonHang[7];
                form_SuaDonHang.cbx_ChonKhuyenMai.Text = thongTinDonHang[9];

                string tongTien1DonHang = donHangDAO.TinhTongTien1DonHang(maDonHang);
                form_SuaDonHang.lbl_TongHoaDon.Text = tongTien1DonHang;
                form_SuaDonHang.lbl_TongHoaDonSauKM.Text = tongTien1DonHang;
                form_SuaDonHang.MaDonHang = maDonHang;

                // Trong form chính
                form_SuaDonHang.ShowDialog();
            }
        }

        private void btn_KhachHangMoi_Click_1(object sender, EventArgs e)
        {
            form_TaoKhachHang form_TaoKhachHang = new form_TaoKhachHang();

            //  set trạng thái dựa vào btn.text để nhận biết khi nào tạo khi nào sửa
            form_TaoKhachHang.Sua_taoMoi_khachHang = btn_KhachHangMoi.Text;

            form_TaoKhachHang.ShowDialog();

            LoadSDTKhachHang_vao_cbx();
        }

        private void LoadDanhSachDonHang()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = donHangDAO.GetDanhSachDonHang();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachDonHang.DataSource = dt; 
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message); 
            }
        }

        private void dgv_DanhSachDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                var selectedRow = dgv_DanhSachDonHang.Rows[e.RowIndex];
                var maDonBan = selectedRow.Cells["Mã đơn bán"].Value;

                // Lấy % chiết khấu
                var chietKhau = selectedRow.Cells["Chiết khấu"].Value;
                decimal decimal_chietKhau = 0;

                // Kiểm tra và chuyển đổi giá trị chiết khấu
                if (chietKhau != null && !string.IsNullOrEmpty(chietKhau.ToString()))
                {
                    bool isDecimal = decimal.TryParse(chietKhau.ToString(), out decimal_chietKhau);
                    if (!isDecimal)
                    {
                        MessageBox.Show("Chiết khấu không phải là giá trị hợp lệ.");
                        return;
                    }
                }

                try
                {
                    // Lấy dữ liệu từ view
                    DataTable dt = donHangDAO.getChiTietDonHang(maDonBan.ToString());
                    // Gán dữ liệu vào DataGridView
                    dgv_ChiTietDonHang.DataSource = dt;

                    // Tính toán tổng tiền (chưa trừ khuyến mãi) 1 đơn
                    decimal tongTien1DonHang = Convert.ToDecimal(donHangDAO.TinhTongTien1DonHang(maDonBan.ToString()));
                    lbl_TongHoaDon_DanhSach.Text = Math.Round(tongTien1DonHang, 2).ToString();

                    lbl_TongHoaDonSauKM_DanhSach.Text = Math.Round((tongTien1DonHang - decimal_chietKhau * tongTien1DonHang / 100), 2).ToString();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadDanhSachDienThoaiCoSan()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = donHangDAO.GetDanhSachDienThoaiCoSan();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachDienThoaiSanCo.DataSource = dt;

                // Kiểm tra xem đã có cột Button chưa, nếu chưa thì thêm vào
                if (!dgv_DanhSachDienThoaiSanCo.Columns.Contains("ActionButton"))
                {
                    // Tạo cột Button
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

                    buttonColumn.Name = "col_ThemDienThoai";
                    buttonColumn.HeaderText = "";
                    buttonColumn.Text = "Thêm";
                    buttonColumn.UseColumnTextForButtonValue = true; 

                    // Thêm cột Button vào DataGridView
                    dgv_DanhSachDienThoaiSanCo.Columns.Add(buttonColumn);

                    // Gọi event click cho button
                    dgv_DanhSachDienThoaiSanCo.CellContentClick += dgv_DanhSachDienThoaiSanCo_CellContentClick;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void dgv_DanhSachDienThoaiSanCo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được click là cột Button
            if (e.ColumnIndex == dgv_DanhSachDienThoaiSanCo.Columns["col_ThemDienThoai"].Index && e.RowIndex >= 0)
            {
                // Lấy Imei điện thoại của hàng được click
                string imei = dgv_DanhSachDienThoaiSanCo.Rows[e.RowIndex].Cells["Mã Imei"].Value.ToString();

                try
                {
                    // Lấy dữ liệu từ view
                    DataTable dt = donHangDAO.GetDienThoaiDuaVaoImei(imei);

                    // Kiểm tra xem dgv_DienThoaiDaThem có dữ liệu không
                    DataTable currentData = dgv_DienThoaiDaThem.DataSource as DataTable;

                    // Nếu dgv_DienThoaiDaThem chưa có dữ liệu, tạo một DataTable mới
                    if (currentData == null)
                    {
                        currentData = dt.Clone(); // Tạo một DataTable với cấu trúc giống dt
                    }

                    // Kiểm tra trùng IMEI trước khi thêm
                    foreach (DataRow row in dt.Rows)
                    {
                        string newImei = row["Mã Imei"].ToString();
                        bool isDuplicate = false;

                        // Kiểm tra trong currentData xem đã có IMEI này chưa
                        foreach (DataRow existingRow in currentData.Rows)
                        {
                            if (existingRow["Mã Imei"].ToString() == newImei)
                            {
                                isDuplicate = true;
                                break;
                            }
                        }

                        // Nếu không trùng, thêm dòng vào currentData
                        if (!isDuplicate)
                        {
                            currentData.ImportRow(row);

                            //  cập nhật lại tổng tiền sau khi thêm sản phẩm
                            CapNhatTongTien(currentData);
                        }
                        else
                        {
                            MessageBox.Show("Điện thoại đã được thêm");
                        }    
                    }

                    // Gán dữ liệu vào DataGridView
                    dgv_DienThoaiDaThem.DataSource = currentData;
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        //// xử lý xóa điện thoại
        //private void XoaDienThoaiDaThem()
        //{
        //    // Tạo cột Button
        //    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

        //    buttonColumn.Name = "col_ThemDienThoai";
        //    buttonColumn.HeaderText = "";
        //    buttonColumn.Text = "Xóa";
        //    buttonColumn.UseColumnTextForButtonValue = true;

        //    // Thêm cột Button vào DataGridView
        //    dgv_DienThoaiDaThem.Columns.Add(buttonColumn);
        //    // Gọi event click cho button
        //    dgv_DanhSachDienThoaiSanCo.CellContentClick += dgv_DanhSachDienThoaiSanCo_CellContentClick;
        //}

        private void CapNhatTongTien(DataTable currentData)
        {
            decimal tongTien = 0;

            // Duyệt qua từng hàng trong DataTable
            foreach (DataRow row in currentData.Rows)
            {
                // Lấy giá bán từ hàng hiện tại
                decimal giaBan = Convert.ToDecimal(row["Giá bán"].ToString());
                decimal thue = Convert.ToDecimal(row["Thuế"].ToString());
                {
                    // Tính giá trị sau khi trừ thuế
                    decimal giaSauThue = giaBan - (giaBan * thue / 100);
                    tongTien += giaSauThue;
                }
            }

            lbl_TongHoaDon.Text = Math.Round(tongTien, 2).ToString();
            lbl_TongHoaDonSauKM.Text = Math.Round(tongTien, 2).ToString();
        }


        private void btn_TìmDonHang_Click(object sender, EventArgs e)
        {
            String soDienThoai = tbx_TimDonHang.Text;

            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = donHangDAO.GetDanhSachDonHangMotKhach(soDienThoai);
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachDonHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //private void LoadSDTNhanVien_vao_cbx()
        //{
        //    // Xóa các mục cũ nếu có
        //    cbx_ChonNhanVien.Items.Clear();

        //    // Lấy danh sách số điện thoại
        //    List<string> phoneNumbers = donHangDAO.GetDanhSachDienThoaiNhanVien();

        //    // Thêm số điện thoại vào ComboBox
        //    foreach (string phoneNumber in phoneNumbers)
        //    {
        //        cbx_ChonNhanVien.Items.Add(phoneNumber);
        //    }
        //}

        private void LoadSDTKhachHang_vao_cbx()
        {
            // Xóa các mục cũ nếu có
            cbx_ChonKhachHang.Items.Clear();

            // Lấy danh sách số điện thoại
            List<string> phoneNumbers = donHangDAO.GetDanhSachDienThoaiKhachHang();

            // Thêm số điện thoại vào ComboBox
            foreach (string phoneNumber in phoneNumbers)
            {
                cbx_ChonKhachHang.Items.Add(phoneNumber);
            }
        }

        private void LoadMaKhuyenMai_vao_cbx()
        {
            // Xóa các mục cũ nếu có
            cbx_ChonKhuyenMai.Items.Clear();

            // Lấy danh sách mã khuyến mãi
            List<string> maKhuyenMais = donHangDAO.GetDanhSachMaKhuyenMai();

            // Thêm mã khuyến mãi vào ComboBox
            foreach (string maKhuyenMai in maKhuyenMais)
            {
                cbx_ChonKhuyenMai.Items.Add(maKhuyenMai);
            }
        }

        //  LỖI LOGIC
        private void btn_XoaDonHang_Click(object sender, EventArgs e)
        {
            string maDonHang = tbx_MaDonHang.Text;
            donHangDAO.XoaDonHangTheoMa(maDonHang);
        }

        //  load filter cho 4 combobox
        private void LoadFilter_vao_4_cbx()
        {
            List<LoadFilterDienThoaiCoSan> listFilters = donHangDAO.GetFilterDienThoaiCoSan();

            foreach (var listFilter in listFilters)
            {
                cbx_TenDienThoai.Items.Add(listFilter.TenDongMay);

                cbx_ManHinh.Items.Add(listFilter.ManHinh);

                cbx_Pin.Items.Add(listFilter.Pin);

                cbx_MauSac.Items.Add(listFilter.MauSac);
            }
        }

        //  load danh sách điện thoại được lọc từ 4 filter
        private void btn_TimTenDienThoai_Click(object sender, EventArgs e)
        {
            string tenDongMay = string.IsNullOrEmpty(cbx_TenDienThoai.Text) ? null : cbx_TenDienThoai.Text;
            string manHinh = string.IsNullOrEmpty(cbx_ManHinh.Text) ? null : cbx_ManHinh.Text;
            string pin = string.IsNullOrEmpty(cbx_Pin.Text) ? null : cbx_Pin.Text;
            string mauSac = string.IsNullOrEmpty(cbx_MauSac.Text) ? null : cbx_MauSac.Text;

            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = donHangDAO.GetDanhSachDonHangTheoFilter(tenDongMay, manHinh, pin, mauSac);
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachDienThoaiSanCo.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_ApDungKhuyenMai_Click(object sender, EventArgs e)
        {
            string maKhuyenMai = cbx_ChonKhuyenMai.Text;
            decimal tongHoaDon;
            bool isValid = decimal.TryParse(lbl_TongHoaDon.Text, out tongHoaDon);

            if (!isValid)
            {
                MessageBox.Show("Cần thêm sản phẩm.");
                return;
            }

            decimal chietKhau = donHangDAO.GetChietKhau(maKhuyenMai);

            decimal tongHoaDonSauKM = Math.Round(tongHoaDon - chietKhau * tongHoaDon / 100, 2);
            lbl_TongHoaDonSauKM.Text = tongHoaDonSauKM.ToString();
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            DonBan donBan = LayFullThongTin1DonHang();
            List<string> imeiList = LayDanhSachImeiDaThem();

            if (donBan != null && imeiList.Count != 0)
            {
                donHangDAO.ThemDonHangMoi(donBan);
                donHangDAO.ThemVaoChiTietDonHang(donBan.MaDonBan, imeiList);
            }
            else
            {
                MessageBox.Show("Tạo đơn không thành công");
            }
        }

        private DonBan LayFullThongTin1DonHang()
        {
            DonBan donBan = new DonBan();

            donBan.MaDonBan = RandomMaDonHang();

            var dt = LayThoiGianHienTai();
            donBan.NgayTaoDon = dt.Item1;
            donBan.GioTaoDon = dt.Item2;

            donBan.TriGia = 0;
            donBan.SoLuongDT = 0;

            if (!string.IsNullOrEmpty(tbx_TongKhachDua.Text))
            {
                donBan.SoTienTra = Convert.ToDecimal(tbx_TongKhachDua.Text);
            }
            else
            {
                MessageBox.Show("Cần nhập số tiền khách đưa!");
                return null;
            }

            donBan.TrangThai = XetTrangThai();
            if (string.IsNullOrEmpty(donBan.TrangThai))
                return null;

            if (!string.IsNullOrEmpty(cbx_ChonKhachHang.Text))
            {
                donBan.MaKhachHang = donHangDAO.GetMaKhachHangTuSDT(cbx_ChonKhachHang.Text);
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng!");
                return null;
            }

            donBan.MaNhanVien = null;

            if (!string.IsNullOrEmpty(cbx_ChonKhuyenMai.Text))
            {
                donBan.MaKhuyenMai = cbx_ChonKhuyenMai.Text;
            }
            else
            {
                donBan.MaKhuyenMai = null;
            }

            return donBan;
        }
        private string XetTrangThai()
        {
            decimal tongKhachDua = 0;
            decimal tongHoaDonSauKM = 0;
            string trangThai = "Chưa hoàn thành";

            // Kiểm tra null hoặc chuỗi rỗng cho tbx_TongKhachDua.Text và lbl_TongHoaDonSauKM.Text
            if (!string.IsNullOrEmpty(tbx_TongKhachDua.Text) && !string.IsNullOrEmpty(lbl_TongHoaDonSauKM.Text))
            {
                // Chuyển đổi giá trị của tbx_TongKhachDua thành decimal
                tongKhachDua = Math.Round(Convert.ToDecimal(tbx_TongKhachDua.Text), 2);
                tongHoaDonSauKM = Convert.ToDecimal(lbl_TongHoaDonSauKM.Text);

                trangThai = tongKhachDua < tongHoaDonSauKM ? "Chưa hoàn thành" : "Hoàn thành";
                return trangThai;
            }
            else
            {
                MessageBox.Show("Cần nhập số tiền khách đưa!");
                return null;
            }    
        }
        private (string, string) LayThoiGianHienTai()
        {
            DateTime currentDateTime = DateTime.Now;
            string date = currentDateTime.ToString("yyyy-MM-dd");
            string time = currentDateTime.ToString("HH:mm:ss");

            return (date, time); // Trả về một Tuple gồm 2 giá trị
        }
        private string RandomMaDonHang()
        {
            Guid g = Guid.NewGuid();
            return g.ToString();
        }
        private List<string> LayDanhSachImeiDaThem()
        {
            List<string> imeiList = new List<string>();

            // Duyệt qua tất cả các hàng trong DataGridView
            foreach (DataGridViewRow row in dgv_DienThoaiDaThem.Rows)
            {
                // Kiểm tra xem hàng đó có hợp lệ hay không
                if (row.Cells["Mã Imei"] != null && row.Cells["Mã Imei"].Value != null)
                {
                    // Lấy giá trị từ cột "Mã Imei" và thêm vào danh sách
                    imeiList.Add(row.Cells["Mã Imei"].Value.ToString());
                }
            }

            return imeiList;
        }
    }
}

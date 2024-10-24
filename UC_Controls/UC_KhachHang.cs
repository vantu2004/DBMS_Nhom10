﻿using Nhom11.DB;
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
    public partial class UC_KhachHang : UserControl
    {
        KhachHangDAO khachHangDAO = new KhachHangDAO();

        public UC_KhachHang()
        {
            InitializeComponent();
            LoadDanhSachKhachHang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachKhachHang.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_DanhSachKhachHang.SelectedRows[0];
                var sdt = selectedRow.Cells["Số điện thoại"].Value.ToString();

                form_TaoKhachHang form_TaoKhachHang = new form_TaoKhachHang();
                form_TaoKhachHang.LoadThongTinKhachHang(sdt);
                form_TaoKhachHang.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng trước khi sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (dgv_ChiTietThanhToan.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_ChiTietThanhToan.SelectedRows[0];
                var mdb = selectedRow.Cells["Mã Đơn Bán"].Value.ToString();
                var stt = selectedRow.Cells["Số thứ tự"].Value.ToString();
                form_KhachTraGop form_KhachTraGop = new form_KhachTraGop(mdb,stt);
                form_KhachTraGop.getChiTietHoaDonGhiNo(mdb,stt); 
                form_KhachTraGop.ShowDialog();
            }
        }

        

        public void LoadDanhSachKhachHang()
        {
            try
            {
                // Lấy dữ liệu từ view
                DataTable dt = khachHangDAO.GetDanhSachKhachHang();
                // Gán dữ liệu vào DataGridView
                dgv_DanhSachKhachHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_DanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                var selectedRow = dgv_DanhSachKhachHang.Rows[e.RowIndex];
                var maKhachHang = selectedRow.Cells["Mã Khách hàng"].Value;

                /*MessageBox.Show(maKhachHang.ToString());*/

                try
                {
                    // Lấy dữ liệu từ view
                    DataTable dt = khachHangDAO.getChiTietThanhToan(maKhachHang.ToString());
                    // Gán dữ liệu vào DataGridView
                    dgv_ChiTietThanhToan.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void UC_KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btn_TimKhachHang_Click_1(object sender, EventArgs e)
        {
            string sdt = tbx_TimKhachHang.Text.Trim();

            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                DataTable dt = khachHangDAO.traCuuTheoSDTKhachHang(sdt);

                if (dt.Rows.Count > 0)
                {
                    dgv_DanhSachKhachHang.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_ChiTietThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ThanhToan_Click(sender, e);
        }
    }
}

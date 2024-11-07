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
    public partial class form_SuaDonHang : Form
    {
        DonHangDAO donHangDAO = new DonHangDAO();
        string maDonHang;

        public form_SuaDonHang()
        {
            InitializeComponent();
            LoadSDTKhachHang_vao_cbx();
            LoadMaKhuyenMai_vao_cbx();
        }

        public string MaDonHang { get => maDonHang; set => maDonHang = value; }

        //  trường hợp khách hàng mới thì cho phép tạo, 1 sdt chỉ tương ứng 1 khách hàng và tồn tại duy nhất
        private void btn_KhachHangMoi_Click(object sender, EventArgs e)
        {
            form_TaoKhachHang form_TaoKhachHang = new form_TaoKhachHang();

            form_TaoKhachHang.ShowDialog();

            //  tạo xong thì đóng form và cho load lại cbx 
            LoadSDTKhachHang_vao_cbx();
        }

        private void form_SuaDonHang_Load(object sender, EventArgs e)
        {
            
        }

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

        private void btn_ApDungKhuyenMai_Click(object sender, EventArgs e)
        {
            string maKhuyenMai = cbx_ChonKhuyenMai.Text;

            decimal tongTien = Convert.ToDecimal(lbl_TongHoaDon.Text);
            decimal chietKhau = donHangDAO.GetChietKhau(maKhuyenMai);

            lbl_TongHoaDonSauKM.Text = Math.Round((tongTien - chietKhau * tongTien / 100), 2).ToString();
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            string maKhachHang = donHangDAO.GetMaKhachHangTuSDT(cbx_ChonKhachHang.Text);

            string maKhuyenMai = null;
            if (!string.IsNullOrEmpty(cbx_ChonKhuyenMai.Text))
            {
                maKhuyenMai = cbx_ChonKhuyenMai.Text;
            }    

            decimal tongHoaDonSauKM = Convert.ToDecimal(lbl_TongHoaDonSauKM.Text);

            donHangDAO.SuaDonBan(MaDonHang, maKhachHang, maKhuyenMai, tongHoaDonSauKM);
            
            this.Close();
        }
    }
}

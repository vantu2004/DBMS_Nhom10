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
    public partial class form_SuaDonNhap : Form
    {
        DonNhapDAO donNhapDAO = new DonNhapDAO();
        string maDonNhap;

        public form_SuaDonNhap()
        {
            InitializeComponent();
            LoadMaNhaCungCap();
        }

        public string MaDonNhap { get => maDonNhap; set => maDonNhap = value; }

        private void btn_TaoNhaCungCap_Click(object sender, EventArgs e)
        {
            form_TaoNhaCungCap form_TaoNhaCungCap = new form_TaoNhaCungCap();

            form_TaoNhaCungCap.ShowDialog();
            form_TaoNhaCungCap.Close();

            LoadMaNhaCungCap() ;
        }

        private void btn_TaoDongMay_Click(object sender, EventArgs e)
        {
            form_TaoDongMay form_TaoDongMay = new form_TaoDongMay();

            form_TaoDongMay.ShowDialog();
        }

        private void LoadMaNhaCungCap()
        {
            List<string> maNhaCungCap = donNhapDAO.LoadMaNhaCungCap();

            cbx_ChonNhaCungCap.Items.Clear();
            foreach (string item in maNhaCungCap)
            {
                cbx_ChonNhaCungCap.Items.Add(item);
            }
        }

        public void LoadThongTinMaDonNhap()
        {
            DataTable dt = donNhapDAO.LayThongTinDonNhap(MaDonNhap);

            // Kiểm tra nếu DataTable có dữ liệu
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Lấy hàng đầu tiên từ DataTable

                cbx_ChonNhaCungCap.Text = row["Ma_NCC"].ToString();
            }
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbx_ChonNhaCungCap.Text))
            { 
                string maNhaCungCap = cbx_ChonNhaCungCap.Text;

                donNhapDAO.SuaDonNhap(MaDonNhap, maNhaCungCap);

                MessageBox.Show("Sửa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nhom11
{
    public partial class UC_ThongKe : UserControl
    {
        ThongKeDAO thongKeDAO = new ThongKeDAO();

        public UC_ThongKe()
        {
            InitializeComponent();
            LoadChartThongKe();
            LoadChartTop10KhachHang();
            LoadChartTop10SanPhamBanChay();
        }

        private void LoadChartThongKe()
        {
            // Lấy dữ liệu từ database
            DataTable dt = thongKeDAO.LoadThongKe(DateTime.Now.Year, DateTime.Now.Month);

            // Xóa dữ liệu cũ trong các Series nếu có
            chartThongKe.Series["tongThu"].Points.Clear();

            // Duyệt qua các hàng trong DataTable để thêm dữ liệu vào biểu đồ
            foreach (DataRow row in dt.Rows)
            {
                // Lấy dữ liệu từ mỗi hàng
                string ngayThongKe = Convert.ToDateTime(row["Ngay_thong_ke"]).ToString("dd/MM");
                decimal tongThu = Convert.ToDecimal(row["Tong_thu"]);

                // Thêm điểm vào Series TongThu
                chartThongKe.Series["tongThu"].Points.AddXY(ngayThongKe, (double)tongThu);
            }

            // Đảm bảo mỗi ngày đều được hiển thị trên trục X
            chartThongKe.ChartAreas[0].AxisX.Interval = 1;
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn trục X cho dễ đọc
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;

            chartThongKe.Titles.Add("Doanh thu theo ngày trong tháng " + DateTime.Now.Month); // Thêm tiêu đề mới
        }

        private void LoadChartTop10KhachHang()
        {
            // Lấy dữ liệu từ database
            DataTable dt = thongKeDAO.LoadTop10KhachHang();

            // Xóa dữ liệu cũ trong các Series nếu có
            chart_BieuDoTron.Series["khachHang"].Points.Clear();

            // Duyệt qua các hàng trong DataTable để thêm dữ liệu vào biểu đồ tròn
            foreach (DataRow row in dt.Rows)
            {
                // Lấy dữ liệu từ mỗi hàng
                string tenKhachHang = row["Ten_khach_hang"].ToString();
                decimal tongTienDaMua = Convert.ToDecimal(row["Tong_tien_da_mua"]);

                // Thêm điểm vào Series KhachHang (Dữ liệu khách hàng và tổng tiền)
                chart_BieuDoTron.Series["khachHang"].Points.AddXY(tenKhachHang, (double)tongTienDaMua);
            }

            // Đảm bảo biểu đồ tròn có tiêu đề
            chart_BieuDoTron.Titles.Clear();
            chart_BieuDoTron.Titles.Add("Top 10 Khách Hàng theo Tổng Tiền Mua");

            // Đảm bảo các nhãn trên biểu đồ tròn hiển thị đúng
            chart_BieuDoTron.Series["khachHang"].IsValueShownAsLabel = true; // Hiển thị giá trị trên biểu đồ
        }

        private void LoadChartTop10SanPhamBanChay()
        {
            // Lấy dữ liệu từ database
            DataTable dt = thongKeDAO.LayTop10SanPhamBanChay();

            // Xóa dữ liệu cũ trong các Series nếu có
            chart_SanPhamBanChay.Series["soLuong"].Points.Clear();

            // Duyệt qua các hàng trong DataTable để thêm dữ liệu vào biểu đồ cột
            foreach (DataRow row in dt.Rows)
            {
                // Lấy dữ liệu từ mỗi hàng
                string tenDongMay = row["Ten_dong_may"].ToString();
                int soLuongBan = Convert.ToInt32(row["So_luong_ban"]);

                // Thêm điểm vào Series SanPham (Tên dòng máy và số lượng bán)
                chart_SanPhamBanChay.Series["soLuong"].Points.AddXY(tenDongMay, soLuongBan);
            }

            // Đảm bảo biểu đồ cột có tiêu đề
            chart_SanPhamBanChay.Titles.Clear();
            chart_SanPhamBanChay.Titles.Add("Top 10 Sản Phẩm Bán Chạy");

            // Đảm bảo các nhãn trên biểu đồ cột hiển thị đúng
            chart_SanPhamBanChay.Series["soLuong"].IsValueShownAsLabel = true; // Hiển thị giá trị trên biểu đồ
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class ThongKe
    {
        private string iDThongKe;
        private string ngayThongKe;
        private string tongSoLuongBan;
        private string doanhThuTheoNgay;

        public ThongKe(string iDThongKe, string ngayThongKe, string tongSoLuongBan, string doanhThuTheoNgay)
        {
            this.iDThongKe = iDThongKe;
            this.ngayThongKe = ngayThongKe;
            this.tongSoLuongBan = tongSoLuongBan;
            this.doanhThuTheoNgay = doanhThuTheoNgay;
        }

        public string IDThongKe { get => iDThongKe; set => iDThongKe = value; }
        public string NgayThongKe { get => ngayThongKe; set => ngayThongKe = value; }
        public string TongSoLuongBan { get => tongSoLuongBan; set => tongSoLuongBan = value; }
        public string DoanhThuTheoNgay { get => doanhThuTheoNgay; set => doanhThuTheoNgay = value; }
    }
}

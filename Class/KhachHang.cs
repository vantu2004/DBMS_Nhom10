using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class KhachHang
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string sDT;
        private string gmail;
        private string diaChi;

        public KhachHang() { }
        public KhachHang(string maKhachHang, string tenKhachHang, string sDT, string gmail, string diaChi)
        {
            this.maKhachHang = maKhachHang;
            this.tenKhachHang = tenKhachHang;
            this.sDT = sDT;
            this.gmail = gmail;
            this.diaChi = diaChi;
        }

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}

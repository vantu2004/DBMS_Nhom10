using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class KhuyenMai
    {
        private string maKhuyenMai;
        private decimal chietKhau;
        private DateTime ngayApDung;
        private string tenChuongTrinh;
        private int soLuongApDung;
        private DateTime ngayKetThuc;

        public KhuyenMai () { }

        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public decimal ChietKhau { get => chietKhau; set => chietKhau = value; }
        public DateTime NgayApDung { get => ngayApDung; set => ngayApDung = value; }
        public string TenChuongTrinh { get => tenChuongTrinh; set => tenChuongTrinh = value; }
        public int SoLuongApDung { get => soLuongApDung; set => soLuongApDung = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}

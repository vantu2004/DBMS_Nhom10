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
        private string chietKhau;
        private string ngayApDung;
        private string tenChuongTrinh;
        private string soLuongApDung;
        private string ngayKetThuc;

        public KhuyenMai(string maKhuyenMai, string chietKhau, string ngayApDung, string tenChuongTrinh, string soLuongApDung, string ngayKetThuc)
        {
            this.maKhuyenMai = maKhuyenMai;
            this.chietKhau = chietKhau;
            this.ngayApDung = ngayApDung;
            this.tenChuongTrinh = tenChuongTrinh;
            this.soLuongApDung = soLuongApDung;
            this.ngayKetThuc = ngayKetThuc;
        }

        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public string ChietKhau { get => chietKhau; set => chietKhau = value; }
        public string NgayApDung { get => ngayApDung; set => ngayApDung = value; }
        public string TenChuongTrinh { get => tenChuongTrinh; set => tenChuongTrinh = value; }
        public string SoLuongApDung { get => soLuongApDung; set => soLuongApDung = value; }
        public string NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}

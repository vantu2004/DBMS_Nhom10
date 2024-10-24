using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class NhanVien
    {
        private string maNhanVien;
        private string matKhau;
        private string tenNhanVien;
        private string chucVu;
        private string gmail;
        private string sDT;

        public NhanVien(string maNhanvien) { }
        public NhanVien() { }
        public NhanVien(string maNhanVien, string matKhau, string tenNhanVien, string chucVu, string gmail, string sDT)
        {
            this.maNhanVien = maNhanVien;
            this.matKhau = matKhau;
            this.tenNhanVien = tenNhanVien;
            this.chucVu = chucVu;
            this.gmail = gmail;
            this.sDT = sDT;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}

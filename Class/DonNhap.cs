using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class DonNhap
    {
        private string maDonNhap;
        private string ngayNhap;
        private string triGia;
        private string soLuongDT;

        public DonNhap(string maDonNhap, string ngayNhap, string triGia, string soLuongDT)
        {
            this.maDonNhap = maDonNhap;
            this.ngayNhap = ngayNhap;
            this.triGia = triGia;
            this.soLuongDT = soLuongDT;
        }

        public string MaDonNhap { get => maDonNhap; set => maDonNhap = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string TriGia { get => triGia; set => triGia = value; }
        public string SoLuongDT { get => soLuongDT; set => soLuongDT = value; }
    }
}

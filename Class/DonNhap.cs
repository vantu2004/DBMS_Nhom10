using DevExpress.ClipboardSource.SpreadsheetML;
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
        private DateTime ngayNhap;
        private DateTime gioNhap;
        private int soLuongDT;
        private decimal triGia;
        private string maNCC;
        private string maNhanVien;

        public DonNhap() { }

        public string MaDonNhap { get => maDonNhap; set => maDonNhap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public DateTime GioNhap { get => gioNhap; set => gioNhap = value; }
        public int SoLuongDT { get => soLuongDT; set => soLuongDT = value; }
        public decimal TriGia { get => triGia; set => triGia = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}

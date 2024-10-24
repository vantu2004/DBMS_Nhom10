using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class DonBan
    {
        private string maDonBan;
        private string ngayTaoDon;
        private string gioTaoDon;
        private decimal triGia;
        private int soLuongDT;
        private decimal soTienTra;
        private string trangThai;
        private string maKhachHang;
        private string maNhanVien;
        private string maKhuyenMai;

        public DonBan() { }

        public string MaDonBan { get => maDonBan; set => maDonBan = value; }
        public string NgayTaoDon { get => ngayTaoDon; set => ngayTaoDon = value; }
        public string GioTaoDon { get => gioTaoDon; set => gioTaoDon = value; }
        public decimal TriGia { get => triGia; set => triGia = value; }
        public int SoLuongDT { get => soLuongDT; set => soLuongDT = value; }
        public decimal SoTienTra { get => soTienTra; set => soTienTra = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
    }
}

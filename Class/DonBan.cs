using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class DonBan
    {
        private string trangThai;
        private string maDonBan;
        private string ngayTaoDon;
        private string soTienTra;
        private string soLuongDT;
        private string triGia;

        public DonBan(string trangThai, string maDonBan, string ngayTaoDon, string soTienTra, string soLuongDT, string triGia)
        {
            this.trangThai = trangThai;
            this.maDonBan = maDonBan;
            this.ngayTaoDon = ngayTaoDon;
            this.soTienTra = soTienTra;
            this.soLuongDT = soLuongDT;
            this.triGia = triGia;
        }

        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string MaDonBan { get => maDonBan; set => maDonBan = value; }
        public string NgayTaoDon { get => ngayTaoDon; set => ngayTaoDon = value; }
        public string SoTienTra { get => soTienTra; set => soTienTra = value; }
        public string SoLuongDT { get => soLuongDT; set => soLuongDT = value; }
        public string TriGia { get => triGia; set => triGia = value; }
    }
}

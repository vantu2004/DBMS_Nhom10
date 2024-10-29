using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class DienThoai
    {
        private string maImei;
        private string mauSac;
        private string trangThai;
        private string hinhAnh;
        private string thue;
        private string giaNhap;
        private string giaBan;

        public DienThoai(string maImei, string mauSac, string trangThai, string hinhAnh, string thue, string giaNhap, string giaBan)
        {
            this.maImei = maImei;
            this.mauSac = mauSac;
            this.trangThai = trangThai;
            this.hinhAnh = hinhAnh;
            this.thue = thue;
            this.giaNhap = giaNhap;
            this.giaBan = giaBan;
        }

        public string MaImei { get => maImei; set => maImei = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string Thue { get => thue; set => thue = value; }
        public string GiaNhap { get => giaNhap; set => giaNhap = value; }
        public string GiaBan { get => giaBan; set => giaBan = value; }
    }
}

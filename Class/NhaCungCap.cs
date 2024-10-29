using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class NhaCungCap
    {
        private string maNhaCungCap;
        private string tenChaCungCap;
        private string diaChi;
        private string sDT;

        public NhaCungCap(string maNhaCungCap, string tenChaCungCap, string diaChi, string sDT)
        {
            this.maNhaCungCap = maNhaCungCap;
            this.tenChaCungCap = tenChaCungCap;
            this.diaChi = diaChi;
            this.sDT = sDT;
        }

        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public string TenChaCungCap { get => tenChaCungCap; set => tenChaCungCap = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}

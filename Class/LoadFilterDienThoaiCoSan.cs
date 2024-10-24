using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11
{
    internal class LoadFilterDienThoaiCoSan
    {
        private string tenDongMay;
        private string manHinh;
        private string pin;
        private string mauSac;

        public LoadFilterDienThoaiCoSan(string tenDongMay, string manHinh, string pin, string mauSac)
        {
            this.TenDongMay = tenDongMay;
            this.ManHinh = manHinh;
            this.Pin = pin;
            this.MauSac = mauSac;
        }

        public string TenDongMay { get => tenDongMay; set => tenDongMay = value; }
        public string ManHinh { get => manHinh; set => manHinh = value; }
        public string Pin { get => pin; set => pin = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }
    }
}

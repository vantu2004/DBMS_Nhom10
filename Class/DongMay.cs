using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class DongMay
    {
        private string maDongMay;
        private string tenDongMay;
        private string kichThuocManHinh;
        private string dungLuongPin;

        public DongMay(string maDongMay, string tenDongMay, string kichThuocManHinh, string dungLuongPin)
        {
            this.maDongMay = maDongMay;
            this.tenDongMay = tenDongMay;
            this.kichThuocManHinh = kichThuocManHinh;
            this.dungLuongPin = dungLuongPin;
        }

        public string MaDongMay { get => maDongMay; set => maDongMay = value; }
        public string TenDongMay { get => tenDongMay; set => tenDongMay = value; }
        public string KichThuocManHinh { get => kichThuocManHinh; set => kichThuocManHinh = value; }
        public string DungLuongPin { get => dungLuongPin; set => dungLuongPin = value; }
    }
}

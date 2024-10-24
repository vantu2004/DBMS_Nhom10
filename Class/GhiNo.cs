using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.Class
{
    public class GhiNo
    {
        private string sTTGhiNo;
        private string ngayThanhToan;
        private string thanhToan;

        public GhiNo(string sTTGhiNo, string ngayThanhToan, string thanhToan)
        {
            this.sTTGhiNo = sTTGhiNo;
            this.ngayThanhToan = ngayThanhToan;
            this.thanhToan = thanhToan;
        }

        public string STTGhiNo { get => sTTGhiNo; set => sTTGhiNo = value; }
        public string NgayThanhToan { get => ngayThanhToan; set => ngayThanhToan = value; }
        public string ThanhToan { get => thanhToan; set => thanhToan = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11
{
    public static class BienToanCuc
    {
        private static string maNhanVien = null;

        public static string MaNhanVien
        {
            get => maNhanVien;
            set => maNhanVien = value;
        }
    }
}

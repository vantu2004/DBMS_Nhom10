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

        public static string randomMa9So()
        {
            Random random = new Random();
            string result = "";

            for (int i = 0; i < 9; i++)
            {
                // Tạo một số ngẫu nhiên từ 0 đến 9
                result += random.Next(0, 10);
            }

            return result;
        }

        public static string randomMa15So()
        {
            Random random = new Random();
            string result = "";

            for (int i = 0; i < 15; i++)
            {
                // Tạo một số ngẫu nhiên từ 0 đến 9
                result += random.Next(0, 10);
            }

            return result;
        }
    }
}

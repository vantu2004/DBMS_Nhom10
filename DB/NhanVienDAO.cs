using Nhom11.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11.DB
{
    internal class NhanVienDAO
    {
        public NhanVienDAO() { }

        static SqlCommand sqlCommand; // dung de truy van cau lenh insert, delete,...
        static SqlDataReader dataReader; // dung de doc du lieu trong bang

        // Phan nay chi la phan quyen dang nhap cua nhan vien thoi
        public static List<NhanVien> TaiKhoanNhanViens(string query)
        {
            List<NhanVien> giangViens = new List<NhanVien>();
            using (SqlConnection sqlConnection = DBConnection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    giangViens.Add(new NhanVien(dataReader.GetString(0)));
                }
                sqlConnection.Close();
            }
            return giangViens;
        }

        public static NhanVien GetGiangVien(string tenTK, string matKhau)
        {
            NhanVien nv = new NhanVien();
            string query = "SELECT * FROM NHAN_VIEN WHERE Ma_nhan_vien = '" + tenTK + "' and Mat_khau = '" + matKhau + "'";


            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nv.MaNhanVien = reader.GetString(0);
                    nv.TenNhanVien = reader.GetString(1);
                    nv.ChucVu = reader.GetString(2);
                    nv.SDT = reader.GetString(3);
                    nv.Gmail = reader.GetString(4);

                }
                reader.Close();
                conn.Close();
            }
            return nv;
        }
        // end phan quyen

        public DataTable GetDanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM dbo.NHAN_VIEN";

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                sqlCommand = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Không thể lấy danh sách đơn hàng: " + ex.Message);
                }
            }

            return dt;
        }
    }

}

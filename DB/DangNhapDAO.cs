using Nhom11.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11
{
    internal class DangNhapDAO
    {
        static SqlCommand sqlCommand; // dung de truy van cau lenh insert, delete,...
        static SqlDataReader dataReader;

        public DangNhapDAO() { }

        //  Xác thực tài khoản admin
        public string getAdmin(string tenDangNhap, string matKhau)
        {
            string result = null;

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.Fn_XacThucAdmin(@Ten_dang_nhap, @Mat_khau)", connection))
                {
                    command.Parameters.Add(new SqlParameter("@Ten_dang_nhap", tenDangNhap));
                    command.Parameters.Add(new SqlParameter("@Mat_khau", matKhau));

                    connection.Open();
                    object queryResult = command.ExecuteScalar();

                    if (queryResult != DBNull.Value)
                    {
                        result = queryResult.ToString();
                    }
                }
            }

            return result;
        }

        //  Xác thực tài khoản người dùng
        public string getNhanVien(string tenDangNhap, string matKhau)
        {
            string maNhanVien = null;

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.Fn_XacThucNhanVien(@SDT, @MatKhau)", connection))
                {
                    command.Parameters.Add(new SqlParameter("@SDT", tenDangNhap));
                    command.Parameters.Add(new SqlParameter("@MatKhau", matKhau));

                    connection.Open();
                    object queryResult = command.ExecuteScalar();

                    // Kiểm tra nếu kết quả không phải là DBNull
                    if (queryResult != DBNull.Value)
                    {
                        maNhanVien = queryResult.ToString();
                    }
                }
            }

            return maNhanVien;
        }
    }
}

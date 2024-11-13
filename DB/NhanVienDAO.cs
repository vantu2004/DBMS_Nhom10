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
                    throw new Exception("Không thể lấy danh sách nv: " + ex.Message);
                }
            }

            return dt;
        }

        public bool ThemNhanVien(string tenNhanVien, string gmail, string soDienThoai, string matKhau, string chucVu)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand("ThemNhanVien", conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào command
                    sqlCommand.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                    sqlCommand.Parameters.AddWithValue("@Gmail", gmail);
                    sqlCommand.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    sqlCommand.Parameters.AddWithValue("@MatKhau", matKhau);
                    sqlCommand.Parameters.AddWithValue("@ChucVu", chucVu);

                    // Thực thi stored procedure
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    // Trả về true nếu có dòng bị thêm, ngược lại trả về false
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
                }
            }
        }
        public DataTable TimKiemNhanVienTheoSDT(string soDienThoai)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_TimKiemNhanVienTheoSDT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool XoaNhanVienTheoSDT(string soDienThoai)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_XoaNhanVienTheoSDT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool SuaNhanVienTheoSDT(string soDienThoai, string tenNhanVien, string gmail, string matKhau, string chucVu)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_SuaNhanVienTheoSDT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                cmd.Parameters.AddWithValue("@Gmail", gmail);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@ChucVu", chucVu);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool CapNhatThongTinNhanVien(string maNhanVien, string tenNhanVien, string gmail, string soDienThoai, string matKhau, string chucVu)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand("usp_CapNhatThongTinNhanVien", conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào command
                    sqlCommand.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    sqlCommand.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                    sqlCommand.Parameters.AddWithValue("@Gmail", gmail);
                    sqlCommand.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    sqlCommand.Parameters.AddWithValue("@MatKhau", matKhau);
                    sqlCommand.Parameters.AddWithValue("@ChucVu", chucVu);

                    // Thực thi stored procedure
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    return rowsAffected > 0; // Trả về true nếu cập nhật thành công
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message);
                }
            }
        }

    }

}

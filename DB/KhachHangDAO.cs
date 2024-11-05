using Nhom11.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11
{
    internal class KhachHangDAO
    {
        static SqlCommand sqlCommand; // dung de truy van cau lenh insert, delete,...
        static SqlDataReader dataReader;

        public KhachHangDAO() { }

        public DataTable GetDanhSachKhachHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Dgv_DanhSachKhachHang";

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

        public DataTable getChiTietThanhToan(string maKhachHang)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Dgv_ChiTietThanhToan WHERE [Mã khách hàng] = '{maKhachHang}'";

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
                    throw new Exception("Không thể lấy danh sách chi tiết đơn hàng: " + ex.Message);
                }
            }

            return dt;
        }

        public DataTable traCuuTheoSDTKhachHang(string sdt)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM  Dgv_DanhSachKhachHang WHERE [Số điện thoại] = '{sdt}'";

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
                    throw new Exception("Không có thông tin khách hàng: " + ex.Message);
                }
            }

            return dt;
        }

        public bool capNhatThongTinKhachHang(string sdt, string tenKhachHang, string diaChi, string gmail)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                SqlCommand sqlCommand = new SqlCommand("sp_CapNhatThongTinKhachHang", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@SDT", sdt);
                sqlCommand.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                sqlCommand.Parameters.AddWithValue("@DiaChi", diaChi);
                sqlCommand.Parameters.AddWithValue("@Gmail", gmail);

                try
                {
                    conn.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi cập nhật thông tin khách hàng : " + ex.Message);
                }
            }
        }

        public DataTable getChiTietHoaDonGhiNo(string maDonBan, string soThuTu)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Dgv_ChiTietThanhToan WHERE [Mã đơn bán] = '{maDonBan}' AND [Số thứ tự]='{soThuTu}'";

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
                    throw new Exception("Không thể lấy danh sách chi tiết hóa đơn ghi nợ : " + ex.Message);
                }
            }

            return dt;
        }

        public bool UpdateSoTienConLai(string maDonBan, decimal soTienTraThem)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                SqlCommand sqlCommand = new SqlCommand("sp_UpdateSoTienConLai", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@MaDonBan", maDonBan);
                sqlCommand.Parameters.AddWithValue("@SoTienTraThem", soTienTraThem);

                try
                {
                    conn.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read() && (int)reader["Success"] == 1)
                    {
                        return true;
                    }
                    else
                    {

                        return false;
                    }
                }
                catch (SqlException ex)
                {

                    return false;
                }
            }
        }

        //  kiểm tra số điện thoại đã tồn tại trước đó chưa
        public bool KiemTraTrungSDTKhachHang(string sdt)
        {
            bool isDuplicate = false;

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT dbo.Fn_KiemTraTrungSDTKhachHang(@sodienthoai)", connection))
                {
                    command.Parameters.AddWithValue("@sodienthoai", sdt);

                    isDuplicate = (bool)command.ExecuteScalar();
                }
            }

            return isDuplicate;
        }
    }
}

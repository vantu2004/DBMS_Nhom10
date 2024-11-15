using Nhom11.Class;
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
    internal class KhuyenMaiDAO
    {
        static SqlCommand sqlCommand; // dung de truy van cau lenh insert, delete,...
        static SqlDataReader dataReader;

        public KhuyenMaiDAO() { }

        public DataTable GetDanhSachMaKhuyenMai()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM dbo.KHUYEN_MAI";

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

        public void TaoKhuyenMai(KhuyenMai khuyenMai)
        {
            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("Pr_TaoKhuyenMai", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Ma_khuyen_mai", khuyenMai.MaKhuyenMai);
                        command.Parameters.AddWithValue("@Ten_chuong_trinh", khuyenMai.TenChuongTrinh);
                        command.Parameters.AddWithValue("@Chiet_khau", khuyenMai.ChietKhau);
                        command.Parameters.AddWithValue("@SL_ap_dung", khuyenMai.SoLuongApDung);
                        command.Parameters.AddWithValue("@Ngay_ap_dung", khuyenMai.NgayApDung);
                        command.Parameters.AddWithValue("@Ngay_ket_thuc", khuyenMai.NgayKetThuc);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
            }
        }

        public DataTable LayThongTinKhuyenMai(string maKhuyenMai)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Fn_LayThongTinKhuyenMai(@MaKhuyenMai)", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@MaKhuyenMai", SqlDbType.VarChar, 9)).Value = maKhuyenMai;

                        // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return dataTable;
        }

        public void SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("Pr_SuaKhuyenMai", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaKhuyenMai", khuyenMai.MaKhuyenMai);
                        command.Parameters.AddWithValue("@TenChuongTrinh", khuyenMai.TenChuongTrinh);
                        command.Parameters.AddWithValue("@SLApDung", khuyenMai.SoLuongApDung);
                        command.Parameters.AddWithValue("@NgayBatDau", khuyenMai.NgayApDung);
                        command.Parameters.AddWithValue("@NgayKetThuc", khuyenMai.NgayKetThuc);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
            }
        }


        public bool KiemTraMaKhuyenMai(string maKhuyenMai)
        {
            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.Fn_KiemTraMaKhuyenMai(@MaKhuyenMai)", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@MaKhuyenMai", maKhuyenMai));

                        // Execute the command and get the result
                        object result = command.ExecuteScalar();

                        // Kiểm tra nếu result không null và chuyển đổi thành kiểu int để so sánh
                        return result != DBNull.Value && Convert.ToInt32(result) == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
                return false;
            }
        }


        public bool XoaMaKhuyenMai(string maKhuyenMai)
        {
            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("Pr_XoaMaKhuyenMai", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }
    }
}

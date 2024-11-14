using Nhom11.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Nhom11
{
    internal class SanPhamDAO
    {

        static SqlCommand sqlCommand; // dung de truy van cau lenh insert, delete,...
        static SqlDataReader dataReader;

        public SanPhamDAO() { }

        //  mặc định chỉ xuất những sản phẩm đủ full thuộc tính
        public DataTable GetDanhSachDienThoaiCoSan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Dgv_DanhSachDienThoai";

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                sqlCommand = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);

                    // Tạo danh sách để lưu các hàng cần xóa
                    List<DataRow> rowsToDelete = new List<DataRow>();

                    // Duyệt qua từng hàng và kiểm tra giá trị null
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            if (row[col] == DBNull.Value)
                            {
                                // Nếu có null, thêm vào danh sách xóa
                                rowsToDelete.Add(row);
                                break;
                            }
                        }
                    }

                    // Xóa các hàng có giá trị null
                    foreach (DataRow row in rowsToDelete)
                    {
                        dt.Rows.Remove(row);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Không thể lấy danh sách điện thoại có sẵn: " + ex.Message);
                }
            }

            return dt;
        }

        //  mặc định xuất những sản phẩm chưa full thuộc tính
        public DataTable GetDanhSachDienThoaiCanCapNhat()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Dgv_DanhSachDienThoaiSanCo"; // Dữ liệu đã có cột Hinh_anh dưới dạng byte[]

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                sqlCommand = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);

                    // Chuyển đổi dữ liệu Hinh_anh từ byte[] thành Image
                    if (dt.Rows.Count > 0 && dt.Columns.Contains("Hinh_anh"))
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["Hinh_anh"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])row["Hinh_anh"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    row["Hinh_anh"] = Image.FromStream(ms); // Chuyển byte[] thành Image
                                }
                            }
                        }
                    }

                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Không thể lấy danh sách điện thoại: " + ex.Message);
                }
            }
        }


        public DataTable getChiTietSanPham(string maSanPham)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Dgv_DanhSachSanPham WHERE [Mã Imei] = '{maSanPham}'";

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
                    throw new Exception("Không thể lấy danh sách chi tiết sản phẩm : " + ex.Message);
                }
            }

            return dt;
        }

        public DataTable GetMaDongMay()
        {
            DataTable dtMaDongMay = new DataTable("MaDongMay");

            // Add a column named "Ma_dong_may" of type string
            dtMaDongMay.Columns.Add("Ma_dong_may", typeof(string));

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                try
                {
                    string query = "SELECT Ma_dong_may FROM DONG_MAY";
                    SqlCommand command = new SqlCommand(query, conn);

                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maDongMay = reader["Ma_dong_may"].ToString();
                            dtMaDongMay.Rows.Add(maDongMay);
                        }
                    }
                }
                catch (SqlException ex)
                {

                    Console.WriteLine("Error getting Ma_dong_may data: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

            return dtMaDongMay;
        }

        public void ThemHinhAnh(byte[] hinhAnhData)
        {
            string query = "INSERT INTO DIEN_THOAI (Hinh_Anh) VALUES(@hinh)";

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@hinh", hinhAnhData);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi thêm hình ảnh: " + ex.Message);
                }
            }
        }


        public byte[] ImageToByte(Image img)
        {
            if (img == null)
                throw new ArgumentNullException("img", "Hình ảnh không được để trống.");

            using (MemoryStream m = new MemoryStream())
            {
                img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                return m.ToArray();
            }
        }

        public void CapNhatSanPham(string maImei, decimal giaNhap, decimal giaBan, decimal thue, string mauSac, byte[] hinhAnhData)
        {
            string query = "EXEC pr_CapNhatSanPham @MaImei, @GiaNhap, @GiaBan, @Thue, @MauSac, @HinhAnh";

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaImei", maImei);
                    cmd.Parameters.AddWithValue("@GiaNhap", giaNhap);
                    cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                    cmd.Parameters.AddWithValue("@Thue", thue);
                    cmd.Parameters.AddWithValue("@MauSac", mauSac);
                    /*cmd.Parameters.AddWithValue("@MaDongMay", maDongMay);*/
                    cmd.Parameters.AddWithValue("@HinhAnh", hinhAnhData ?? (object)DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi cập nhật sản phẩm: " + ex.Message);
                }
            }
        }



        public DataTable traCuuTheoTenDT(string sdt)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM  Dgv_DanhSachDienThoai WHERE [Tên dòng máy] = '{sdt}'";

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
                    throw new Exception("Không có thông tin điện thoại: " + ex.Message);
                }
            }

            return dt;
        }

        //public bool XoaSanPhamTheoImei(string maImei)
        //{
        //    using (SqlConnection conn = DBConnection.GetSqlConnection())
        //    {
        //        try
        //        {
        //            conn.Open();
        //            SqlCommand sqlCommand = new SqlCommand("XoaSanPhamTheoImei", conn);
        //            sqlCommand.CommandType = CommandType.StoredProcedure;

        //            // Thêm tham số vào command
        //            sqlCommand.Parameters.AddWithValue("@MaImei", maImei);

        //            // Thực thi stored procedure
        //            int rowsAffected = sqlCommand.ExecuteNonQuery();

        //            // Trả về true nếu có dòng bị xóa, ngược lại trả về false
        //            return rowsAffected > 0;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Lỗi khi xóa sản phẩm: " + ex.Message);
        //        }
        //    }
        //}

    }
}


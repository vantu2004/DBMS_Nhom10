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
    internal class DonNhapDAO
    {
        static SqlCommand sqlCommand; // dung de truy van cau lenh insert, delete,...
        static SqlDataReader dataReader;

        public DonNhapDAO() { }

        public DataTable GetDanhSachDonNhap()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Dgv_DanhSachDonNhap";

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

        public DataTable getChiTietDonNhap(string maDonNhap)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Dgv_ChiTietDonNhap WHERE [Mã đơn nhập] = '{maDonNhap}'";

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

        public void TaoDongMay(DongMay dongMay)
        {
            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("Pr_TaoDongMay", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        command.Parameters.AddWithValue("@Ma_dong_may", dongMay.MaDongMay);
                        command.Parameters.AddWithValue("@Ten_dong_may", dongMay.TenDongMay);
                        command.Parameters.AddWithValue("@Dung_luong_pin", dongMay.DungLuongPin);
                        command.Parameters.AddWithValue("@Kich_thuoc", dongMay.KichThuocManHinh);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("Tạo dòng máy thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }

        public List<string> LoadMaDongMay()
        {
            List<string> maDongMayList = new List<string>();

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    // Gọi hàm SQL fn_GetMaDongMayList
                    using (SqlCommand command = new SqlCommand("SELECT Ma_dong_may FROM dbo.Fn_LoadMaDongMay()", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                maDongMayList.Add(reader["Ma_dong_may"].ToString());
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            return maDongMayList;
        }

        public void TaoNhaCungCap(NhaCungCap nhaCungCap)
        {
            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("Pr_TaoNhaCungCap", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        command.Parameters.AddWithValue("@Ma_NCC", nhaCungCap.MaNhaCungCap);
                        command.Parameters.AddWithValue("@Ten_NCC", nhaCungCap.TenChaCungCap);
                        command.Parameters.AddWithValue("@Dia_chi", nhaCungCap.DiaChi);
                        command.Parameters.AddWithValue("@SDT", nhaCungCap.SDT);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Tạo nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }

        public List<string> LoadMaNhaCungCap()
        {
            List<string> maNhaCungCapList = new List<string>();

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT Ma_NCC FROM dbo.Fn_LoadMaNhaCungCap()", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                maNhaCungCapList.Add(reader["Ma_NCC"].ToString());
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            return maNhaCungCapList;
        }

        public DongMay LayThongTinDongMay(string maDongMay)
        {
            DongMay dongMay = new DongMay();

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Fn_LayThongTinDongMay(@Ma_dong_may)", connection))
                    {
                        command.Parameters.AddWithValue("@Ma_dong_may", maDongMay);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();

                                dongMay.MaDongMay = maDongMay;
                                dongMay.TenDongMay = reader["Ten_dong_may"].ToString();
                                dongMay.DungLuongPin = reader["Dung_luong_pin"].ToString();
                                dongMay.KichThuocManHinh = reader["Kich_thuoc"].ToString();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

            return dongMay;
        }

        public void ThemDienThoaiTuDonNhap(DataTable dt)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                    {
                        // Chỉ định bảng đích trong cơ sở dữ liệu
                        bulkCopy.DestinationTableName = "DIEN_THOAI";

                        // Map các cột trong DataTable với bảng SQL
                        bulkCopy.ColumnMappings.Add("Ma_Imei", "Ma_Imei");
                        bulkCopy.ColumnMappings.Add("Hinh_anh", "Hinh_anh");
                        bulkCopy.ColumnMappings.Add("Mau_sac", "Mau_sac");
                        bulkCopy.ColumnMappings.Add("Trang_thai", "Trang_thai");
                        bulkCopy.ColumnMappings.Add("Gia_nhap", "Gia_nhap");
                        bulkCopy.ColumnMappings.Add("Gia_ban", "Gia_ban");
                        bulkCopy.ColumnMappings.Add("Thue", "Thue");
                        bulkCopy.ColumnMappings.Add("Ma_dong_may", "Ma_dong_may");

                        // Chuyển dữ liệu từ DataTable vào cơ sở dữ liệu
                        bulkCopy.WriteToServer(dt);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        public void TaoDonNhap(DonNhap donNhap)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("Pr_TaoDonNhap", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Ma_don_nhap", donNhap.MaDonNhap);
                        cmd.Parameters.AddWithValue("@Ma_NCC", donNhap.MaNCC);
                        cmd.Parameters.AddWithValue("@Ma_nhan_vien", donNhap.MaNhanVien ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoLuongDienThoai", donNhap.SoLuongDT);
                        cmd.Parameters.AddWithValue("@TriGia", donNhap.TriGia);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        public void ThemChiTietDonNhap(DataTable dt)
        {
            // Kiểm tra kết nối từ DBConnection
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                try
                {
                    conn.Open();

                    // Sử dụng SqlBulkCopy để thực hiện chèn hàng loạt
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                    {
                        // Xác định tên bảng đích trong SQL Server
                        bulkCopy.DestinationTableName = "CT_DON_NHAP";

                        // Map các cột từ DataTable sang cột tương ứng trong SQL Server
                        bulkCopy.ColumnMappings.Add("Ma_Imei", "Ma_Imei");
                        bulkCopy.ColumnMappings.Add("Ma_don_nhap", "Ma_don_nhap");

                        // Chèn dữ liệu từ DataTable vào bảng
                        bulkCopy.WriteToServer(dt);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi thêm điện thoại từ đơn nhập: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public DataTable TimDonNhap(string maDonNhap)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM dbo.Fn_TimDonNhap(@Ma_don_nhap)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ma_don_nhap", maDonNhap);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Đổ dữ liệu vào DataTable
                            adapter.Fill(dt); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

            return dt;
        }

        //  lấy danh sách đơn nhập bằng mã dòng máy
        public DataTable GetDanhSachDonNhapMaNCC(string sdt)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM dbo.Fn_TimKiemTheoMaNCC('{sdt}');";

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
                    throw new Exception("Không thể lấy danh sách đơn nhập: " + ex.Message);
                }
            }

            return dt;
        }

        public bool KiemTraMaDonNhap(string maDonNhap)
        {
            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.Fn_KiemTraMaDonNhap(@MaDonNhap)", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@MaDonNhap", maDonNhap));

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

        public DataTable LayThongTinDonNhap(string maDonNhap)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = DBConnection.GetSqlConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Fn_LayThongTinDonNhap(@MaDonNhap)", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@MaDonNhap", maDonNhap));

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

        public void SuaDonNhap(string maDonNhap, string maNCC)
        {
            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("Pr_SuaDonNhap", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaDonNhap", maDonNhap);
                    command.Parameters.AddWithValue("@MaNCC", maNCC);
                    command.Parameters.AddWithValue("@NgayNhap", DBNull.Value);
                    command.Parameters.AddWithValue("@GioNhap", DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool XoaDonNhap(string maDonNhap)
        {
            bool ketQua = false;

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("Pr_XoaDonNhap", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaDonNhap", maDonNhap);

                    // Thêm tham số đầu ra @KetQua
                    SqlParameter ketQuaParam = new SqlParameter("@KetQua", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(ketQuaParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    ketQua = (bool)ketQuaParam.Value;
                }
            }

            return ketQua;
        }
    }
}

using Nhom11.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11.DB
{
    internal class DonHangDAO
    {
        static SqlCommand sqlCommand; // dung de truy van cau lenh insert, delete,...
        static SqlDataReader dataReader;

        public DonHangDAO() { }

        public DataTable GetDanhSachDonHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Dgv_DanhSachDonHang"; 

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

        public DataTable getChiTietDonHang(string maDonBan)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Dgv_ChiTietDonHang WHERE [Mã đơn bán] = '{maDonBan}'";

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

        //  liệt kê danh sách điện thoại sẵn có với trạng thái chưa bán, nếu có bất kỳ thuộc tính nào bị null sẽ ko hiện
        public DataTable GetDanhSachDienThoaiCoSan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Dgv_DanhSachDienThoaiSanCo";

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

        //  lấy danh sách đơn hàng của 1 khách đã mua bằng số điện thoại
        public DataTable GetDanhSachDonHangMotKhach(string soDienThoai)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM dbo.Fn_TimKiemTheoSoDienThoai('{soDienThoai}');";

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

        //  hàm dùng chung cho GetDanhSachDienThoaiNhanVien, GetDanhSachDienThoaiKhachHang, GetDanhSachMaKhuyenMai
        private List<string> GetDanhSachTheoHam(string sqlFunctionName)
        {
            List<string> resultList = new List<string>();
            string querry = $"SELECT * FROM {sqlFunctionName}";

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    
                    sqlCommand = new SqlCommand(querry, connection);

                    // Thực hiện truy vấn
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (sqlFunctionName == "dbo.Fn_LayTatCaMaKhuyenMai()")
                    {
                        // Thêm từng số điện thoại hoặc mã khuyến mãi vào danh sách
                        while (reader.Read())
                        {
                            string value = reader["Ma_khuyen_mai"].ToString();
                            resultList.Add(value); // Thêm vào danh sách
                        }
                    }    
                    else
                    {
                        // Thêm từng số điện thoại hoặc mã khuyến mãi vào danh sách
                        while (reader.Read())
                        {
                            string value = reader["SDT"].ToString();
                            resultList.Add(value); // Thêm vào danh sách
                        }
                    }    

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return resultList;
        }

        //  viết trong này để cbx trong form_SuaDonHang và cbx trong UC_DonHang đều dùng được
        public List<string> GetDanhSachDienThoaiKhachHang()
        {
            return GetDanhSachTheoHam("dbo.Fn_LayTatCaSoDienThoaiKhachHang()");
        }
        //  viết trong này để cbx trong form_SuaDonHang và cbx trong UC_DonHang đều dùng được
        public List<string> GetDanhSachMaKhuyenMai()
        {
            return GetDanhSachTheoHam("dbo.Fn_LayTatCaMaKhuyenMai()");
        }

        public void XoaDonHangTheoMa(string maDonHang)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                using (SqlCommand sqlCommand = new SqlCommand("Pr_XoaDonBan", conn))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào
                    sqlCommand.Parameters.AddWithValue("@Ma_don_ban", maDonHang);

                    // Thêm tham số đầu ra để lấy thông báo
                    SqlParameter messageParam = new SqlParameter("@Message", SqlDbType.NVarChar, 100)
                    {
                        Direction = ParameterDirection.Output
                    };
                    sqlCommand.Parameters.Add(messageParam);

                    try
                    {
                        conn.Open();

                        // Thực thi stored procedure
                        sqlCommand.ExecuteNonQuery();

                        // Lấy thông báo từ tham số đầu ra
                        string message = messageParam.Value.ToString();

                        // Hiển thị thông báo lên MessageBox
                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //  tạo mới khách hàng
        public void themKhachHang(KhachHang khachHang)
        {
            // Gọi stored procedure để thêm khách hàng
            string query = "EXEC [dbo].[Pr_ThemKhachHang] @Ma_khach_hang, @SDT, @Ten_khach_hang, @Dia_chi, @Gmail;";

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    // Sử dụng tham số để tránh SQL Injection
                    sqlCommand.Parameters.AddWithValue("@Ma_khach_hang", khachHang.MaKhachHang); 
                    sqlCommand.Parameters.AddWithValue("@SDT", khachHang.SDT);
                    sqlCommand.Parameters.AddWithValue("@Ten_khach_hang", khachHang.TenKhachHang);
                    sqlCommand.Parameters.AddWithValue("@Dia_chi", khachHang.DiaChi);
                    sqlCommand.Parameters.AddWithValue("@Gmail", khachHang.Gmail);

                    try
                    {
                        conn.Open();
                        sqlCommand.ExecuteNonQuery(); // Thực thi câu lệnh
                        MessageBox.Show("Thêm mới khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tạo mới khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        //  lấy thông tin đơn hàng để fill vào khi sửa đơn hàng
        public List<string> DienThongTinDonHang(string maDonHang)
        {
            List<string> resultList = new List<string>();
            string query = $"SELECT * FROM dbo.Fn_DienThongTinDonHang('{maDonHang}')";

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, connection);

                    // Thực hiện truy vấn
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    // Đọc dữ liệu từ reader và thêm vào list
                    if (dataReader.Read()) // Kiểm tra xem có bản ghi nào không
                    {
                        resultList.Add(dataReader["Mã đơn bán"].ToString());
                        resultList.Add(dataReader["Ngày tạo đơn"].ToString());
                        resultList.Add(dataReader["Số tiền khách đã trả"].ToString());
                        resultList.Add(dataReader["Số lượng điện thoại"].ToString());
                        resultList.Add(dataReader["Trị giá"].ToString());
                        resultList.Add(dataReader["Trạng thái"].ToString());
                        resultList.Add(dataReader["Mã khách hàng"].ToString());
                        resultList.Add(dataReader["Số điện thoại khách hàng"].ToString());
                        resultList.Add(dataReader["Tên khách hàng"].ToString());
                        resultList.Add(dataReader["Mã khuyến mãi"].ToString());
                        resultList.Add(dataReader["Chiết khấu"].ToString());
                        resultList.Add(dataReader["Mã nhân viên"].ToString());
                        resultList.Add(dataReader["Tên nhân viên"].ToString());
                        resultList.Add(dataReader["Số điện thoại nhân viên"].ToString());
                    }
                    else
                    {
                        return null; // Không tìm thấy bản ghi, trả về null
                    }

                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return resultList;
        }

        // Tính tổng tiền 1 đơn hàng chưa trừ khuyến mãi
        public decimal TinhTongTien1DonHang(string maDonBan)
        {
            // Gọi hàm để tính tổng tiền
            string query = $"SELECT dbo.Fn_TongTien1DonHang('{maDonBan}') AS NetTotalAmount";
            string tongTien = "0";

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        // Sử dụng ExecuteScalar để lấy giá trị trả về
                        var result = sqlCommand.ExecuteScalar();
                        tongTien = result.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tính toán " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            return Convert.ToDecimal(tongTien);
        }

        //  lấy chiết khấu từ mã khuyến mãi truyền vào
        public decimal GetChietKhau(string maKhuyenMai)
        {
            string query = $"SELECT dbo.Fn_LayChietKhau('{maKhuyenMai}') AS ChietKhau";

            decimal chietKhau = 0;

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                using (sqlCommand = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        var result = sqlCommand.ExecuteScalar();
                        chietKhau = Convert.ToDecimal(result.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            return chietKhau;
        }

        //  load filter cho 4 combobox bên tab danh sách điện thoại có sẵn
        public List<LoadFilterDienThoaiCoSan> GetFilterDienThoaiCoSan()
        {
            List<LoadFilterDienThoaiCoSan> listFilter = new List<LoadFilterDienThoaiCoSan>();

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM [dbo].[Fn_LoadFilterDienThoaiCoSan]()";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LoadFilterDienThoaiCoSan filter = new LoadFilterDienThoaiCoSan
                        (
                            reader["Tên dòng máy"].ToString(),
                            reader["Kích thước màn hình"].ToString(),
                            reader["Dung lượng pin"].ToString(),
                            reader["Màu sắc"].ToString()
                        );

                        listFilter.Add(filter);
                    }
                }
            }

            return listFilter;
        }

        //  load danh sách điện thoại đã được lọc theo filter
        public DataTable GetDanhSachDonHangTheoFilter(string tenDongMay, string manHinh, string dungLuongPin, string mauSac)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM dbo.Fn_TimDienThoaiTheoFilter(@TenDongMay, @KichThuoc, @DungLuongPin, @MauSac)";


            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                sqlCommand = new SqlCommand(query, conn);

                // Gán giá trị vào tham số, nếu null thì chuyển thành DBNull.Value
                sqlCommand.Parameters.AddWithValue("@TenDongMay", (object)tenDongMay ?? DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@KichThuoc", (object)manHinh ?? DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@DungLuongPin", (object)dungLuongPin ?? DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@MauSac", (object)mauSac ?? DBNull.Value);

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Không thể lấy danh sách điện thoại: " + ex.Message);
                }
            }

            return dt;
        }

        //  lấy thông tin điện thoại dựa vào 1 Imei
        public DataTable GetDienThoaiDuaVaoImei(string imei)
        {
            DataTable resultTable = new DataTable();

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM dbo.Fn_LayDienThoaiDuaVAoImei(@Imei)";

                using (sqlCommand = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu truy vấn
                    sqlCommand.Parameters.AddWithValue("@Imei", imei);

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        adapter.Fill(resultTable);
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            return resultTable;
        }

        //  lấy số điện thoại khách hàng dựa vào số điện thoại
        public string GetMaKhachHangTuSDT(string sdt)
        {
            string query = $"SELECT dbo.Fn_LayMaKhachHang('{sdt}')"; // Giữ truy vấn không đổi
            string maKhachHang = null; // Đặt giá trị mặc định là null

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, conn)) // Khởi tạo sqlCommand
                {
                    try
                    {
                        conn.Open();
                        // Sử dụng ExecuteScalar để lấy giá trị trả về từ truy vấn SELECT
                        var result = sqlCommand.ExecuteScalar();

                        // Kiểm tra nếu kết quả không phải là null
                        if (result != null)
                        {
                            maKhachHang = result.ToString(); // Chuyển đổi kết quả về dạng chuỗi
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            return maKhachHang;
        }

        //  LỖI LOGIC
        //  sửa đơn bán dựa vào mã đơn bán, sửa 4 thuộc tính truyền vào
        public void SuaDonBan(string maDonBan, string newMaKhachHang, string newMaKhuyenMai, decimal tongHoaDonSauKM)
        {
            // Kiểm tra mã khách hàng không được null
            if (string.IsNullOrEmpty(newMaKhachHang))
            {
                MessageBox.Show("Không để trống thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Ngưng thực hiện nếu mã khách hàng là null
            }

            // Chuỗi truy vấn
            string query = "EXEC Pr_SuaDonBan @Ma_don_ban, @Ma_khach_hang, @Ma_khuyen_mai, @Tri_gia";

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    // Thêm các tham số cho stored procedure
                    sqlCommand.Parameters.AddWithValue("@Ma_don_ban", maDonBan);
                    sqlCommand.Parameters.AddWithValue("@Ma_khach_hang", newMaKhachHang);

                    // Nếu mã khuyến mãi là null, sử dụng DBNull.Value
                    if (string.IsNullOrEmpty(newMaKhuyenMai))
                    {
                        sqlCommand.Parameters.AddWithValue("@Ma_khuyen_mai", DBNull.Value);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@Ma_khuyen_mai", newMaKhuyenMai);
                    }

                    sqlCommand.Parameters.AddWithValue("@Tri_gia", tongHoaDonSauKM);

                    try
                    {
                        // Mở kết nối
                        conn.Open();

                        // Thực thi stored procedure
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        // Kiểm tra số hàng đã được cập nhật
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đã cập nhật không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi trong quá trình thực thi
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        public void ThemDonHangMoi(DonBan donBan)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand("Pr_TaoDonBan", conn))
                {
                    // Đặt kiểu là Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho Stored Procedure
                    cmd.Parameters.AddWithValue("@Ma_don_ban", donBan.MaDonBan);
                    cmd.Parameters.AddWithValue("@Ngay_tao_don", donBan.NgayTaoDon);
                    cmd.Parameters.AddWithValue("@Gio_tao_don", donBan.GioTaoDon);
                    cmd.Parameters.AddWithValue("@Tri_gia", donBan.TriGia);
                    cmd.Parameters.AddWithValue("@SL_dien_thoai", donBan.SoLuongDT);
                    cmd.Parameters.AddWithValue("@So_tien_tra", donBan.SoTienTra);
                    cmd.Parameters.AddWithValue("@Trang_thai", donBan.TrangThai);
                    cmd.Parameters.AddWithValue("@Ma_khach_hang", donBan.MaKhachHang);

                    // Kiểm tra nếu MaNhanVien và MaKhuyenMai có giá trị, nếu không thì truyền DBNull
                    cmd.Parameters.AddWithValue("@Ma_nhan_vien", donBan.MaNhanVien ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Ma_khuyen_mai", donBan.MaKhuyenMai ?? (object)DBNull.Value);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tạo đơn bán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void ThemVaoChiTietDonHang(string maDonBan, List<string> imeiList)
        {
            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                conn.Open();

                // Lặp qua từng IMEI trong danh sách
                foreach (var imei in imeiList)
                {
                    using (SqlCommand sqlCommand = new SqlCommand("Pr_ThemVaoChiTietDonHang", conn))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số vào SqlCommand
                        sqlCommand.Parameters.AddWithValue("@Ma_don_ban", maDonBan);
                        sqlCommand.Parameters.AddWithValue("@Ma_Imei", imei);

                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }


    }
}

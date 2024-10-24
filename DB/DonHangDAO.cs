using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //  liệt kê danh sách điện thoại sẵn có, nếu có bất kỳ thuộc tính nào bị null sẽ ko hiện
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

    }
}

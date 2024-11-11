using Nhom11.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                                //// Nếu có null, thêm vào danh sách xóa
                                //rowsToDelete.Add(row);
                                //break;
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
            string query = "SELECT * FROM Dgv_DanhSachDienThoaiSanCo";

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                sqlCommand = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);

                    // Tạo danh sách để lưu các hàng có giá trị null
                    List<DataRow> rowsWithNull = new List<DataRow>();

                    // Duyệt qua từng hàng và kiểm tra giá trị null
                    foreach (DataRow row in dt.Rows)
                    {
                        // Biến để kiểm tra xem có giá trị null hay không
                        bool hasNull = false; 

                        foreach (DataColumn col in dt.Columns)
                        {
                            if (row[col] == DBNull.Value)
                            {
                                // Nếu có giá trị null, đánh dấu
                                hasNull = true;
                                break;
                            }
                        }

                        // Nếu hàng có giá trị null, thêm vào danh sách
                        if (hasNull)
                        {
                            rowsWithNull.Add(row);
                        }
                    }

                    // Tạo DataTable mới chỉ chứa các hàng có giá trị null
                    // Tạo bản sao cấu trúc của DataTable gốc
                    DataTable dtWithNull = dt.Clone(); 

                    foreach (DataRow row in rowsWithNull)
                    {
                        dtWithNull.ImportRow(row); // Nhập hàng vào DataTable mới
                    }

                    return dtWithNull; // Trả về DataTable chứa các hàng có giá trị null
                }
                catch (Exception ex)
                {
                    throw new Exception("Không thể lấy danh sách điện thoại có thuộc tính null: " + ex.Message);
                }
            }
        }

    }
}

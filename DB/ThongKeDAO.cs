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
    internal class ThongKeDAO
    {
        public ThongKeDAO() { }

        public DataTable LoadThongKe(int year, int month)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                // Câu truy vấn để lấy dữ liệu từ function GetThongKeByMonthYear
                string query = "SELECT * FROM dbo.Fn_LayThongKeTrongThang(@Year, @Month)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Month", month);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }


        // Hàm để gọi function và lấy dữ liệu từ SQL Server
        public DataTable LoadTop10KhachHang()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBConnection.GetSqlConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM dbo.LayTop10KhachHang()";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return dt;
        }

        // Hàm để lấy Top 10 sản phẩm bán chạy từ database
        public DataTable LayTop10SanPhamBanChay()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = DBConnection.GetSqlConnection())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Fn_SanPhamBanChay()", conn);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return dt;
        }
    }
}

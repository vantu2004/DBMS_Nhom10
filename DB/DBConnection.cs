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
    internal class DBConnection
    {
        private static string strConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ImeiShop;Integrated Security=True";

        private SqlConnection conn;
        private string connString;

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConnection);
        }

        public DBConnection()
        {
            connString = strConnection;
            try
            {
                conn = new SqlConnection(connString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed: " + ex.Message);
            }
        }

        public DataTable Load(string sqlStr)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dt);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lksDEMAK
{
    internal class Helper
    {
        public static SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L6J0787\\SQLEXPRESS;Initial Catalog=PresensiSekolah;Integrated Security=True");
            return conn;
        }
        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L6J0787\\SQLEXPRESS;Initial Catalog=PresensiSekolah;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand("", conn);


        public static Object GetQuery(string query)
        {
            DataTable dt = new DataTable();
            conn.Open();
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void exQuery(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}

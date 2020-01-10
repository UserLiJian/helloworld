using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionGetStr
    {
       static SqlConnection conn = null;
       static string sqlStr = "Data Source=LAPTOP-5IME6759/SQLEXPRESS;Initial Catalog=User;User ID=sa;Password=123";
        public static void getSqlConnectionStr()
        {
            conn = new SqlConnection(sqlStr);
            conn.Open();
        }

        public static void EndSqlConnectionStr()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}

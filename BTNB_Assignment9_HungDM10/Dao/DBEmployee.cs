using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dao
{
    public static class DBEmployee
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = "server=.\\SQLEXPRESS;database=Employee_Winform;user=sa;password=12345678";

            return sqlConn;
        }
    }
}

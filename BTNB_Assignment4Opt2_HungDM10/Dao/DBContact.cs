using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public static class DBContact
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.\\SQLEXPRESS;database=PersonalContact;user=sa;pwd=12345678";
            return conn;
        }
    }
}

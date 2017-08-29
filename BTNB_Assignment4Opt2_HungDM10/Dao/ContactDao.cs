using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Dao
{
    public class ContactDao
    {
        public int Insert(Contact objContact)
        {
            using (SqlConnection conn = DBContact.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("INSERT Contact([FullName], [Group], [Address], Phone) VALUES (@Name,@Group,@Address,@Phone)", conn);

                SqlParameter[] param = {
                    new SqlParameter("@Name",objContact.FullName),
                    new SqlParameter("@Group",objContact.Group),
                    new SqlParameter("@Address",objContact.Address),
                    new SqlParameter("@Phone",objContact.Phone)
                };

                cmd.Parameters.AddRange(param);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int Update(Contact objContact)
        {
            using (SqlConnection conn = DBContact.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Contact SET [FullName] = @Name, [Group] = @Group, [Address] = @Address, Phone = @Phone WHERE ID = @Id", conn);

                SqlParameter[] param = {
                    new SqlParameter("Id",objContact.Id),
                    new SqlParameter("@Name",objContact.FullName),
                    new SqlParameter("@Group",objContact.Group),
                    new SqlParameter("@Address",objContact.Address),
                    new SqlParameter("@Phone",objContact.Phone)
                };

                cmd.Parameters.AddRange(param);
                conn.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        public int Delete(int contactId)
        {
            using (SqlConnection conn = DBContact.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Contact WHERE ID = @ContactId", conn);
                cmd.Parameters.Add(new SqlParameter("@ContactId", contactId));

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllTable()
        {
            using (SqlConnection conn = DBContact.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT ID, [FullName], [Group], [Address], Phone FROM Contact", conn);

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTable(int id)
        {
            using (SqlConnection conn = DBContact.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT ID, [FullName], [Group], [Address], Phone FROM Contact WHERE ID = @Id", conn);
                cmd.Parameters.Add(new SqlParameter("@Id", id));

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dao
{
    public class DataProvider
    {
        public int Insert(Employee objEmp)
        {
            using (SqlConnection sqlConn = DBEmployee.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("INSERT Employee(Name,EmpAddress,Dob,Salary) VALUES (@Name,@EmpAddress,@Dob,@Salary)", sqlConn);

                SqlParameter[] param = {
                    new SqlParameter("@Name", objEmp.Name),
                    new SqlParameter("@Empaddress", objEmp.EmpAddress),
                    new SqlParameter("@Dob", objEmp.Dob),
                    new SqlParameter("@Salary", objEmp.Salary)
                };
                cmd.Parameters.AddRange(param);

                sqlConn.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllEmployee()
        {
            using (SqlConnection sqlConn = DBEmployee.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT EmpID, Name, EmpAddress, Dob, Salary FROM Employee", sqlConn);
                sqlConn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int Update(Employee objEmp)
        {
            using (SqlConnection sqlConn = DBEmployee.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET Name = @Name, EmpAddress = @EmpAddress, Dob = @Dob, Salary = @Salary WHERE EmpID = @EmpId", sqlConn);

                //SqlParameter[] param =
                //{
                //    new SqlParameter("@EmpId", objEmp.EmpId),
                //    new SqlParameter("@Name", objEmp.Name),
                //    new SqlParameter("@Empaddress", objEmp.EmpAddress),
                //    new SqlParameter("@Dob", objEmp.Dob),
                //    new SqlParameter("@Salary", objEmp.Salary)
                //};

                //cmd.Parameters.AddRange(param);

                cmd.Parameters.Add(new SqlParameter("@EmpId", objEmp.EmpId));
                cmd.Parameters.Add(new SqlParameter("@Name", objEmp.Name));
                cmd.Parameters.Add(new SqlParameter("@Empaddress", objEmp.EmpAddress));
                cmd.Parameters.Add(new SqlParameter("@Dob", objEmp.Dob));
                cmd.Parameters.Add(new SqlParameter("@Salary", objEmp.Salary));

                sqlConn.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetEmployee(int empId)
        {
            using (SqlConnection sqlConn = DBEmployee.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT EmpID, Name, EmpAddress, Dob, Salary FROM Employee WHERE EmpID = @EmpId", sqlConn);
                cmd.Parameters.Add(new SqlParameter("@EmpId", empId));
                sqlConn.Open();
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    public int Delete(int empId)
    {
        using (SqlConnection sqlConn = DBEmployee.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("DELETE Employee WHERE EmpID = @EmpId", sqlConn);
            cmd.Parameters.Add(new SqlParameter("@EmpId", empId));

            sqlConn.Open();

            return cmd.ExecuteNonQuery();
        }
    }
}
}

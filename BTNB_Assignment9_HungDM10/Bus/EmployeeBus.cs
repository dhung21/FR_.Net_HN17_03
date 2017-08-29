using Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus
{
    public static class EmployeeBus
    {
        static DataProvider objData = new DataProvider();

        public static bool Insert(string name, string empAddress, DateTime dob, int salary)
        {
            Employee objEmp = new Employee() { Name = name, EmpAddress = empAddress, Dob = dob, Salary = salary };

            int rs = objData.Insert(objEmp);
            if (rs == 1)
                return true;
            else
                return false;
        }

        public static bool Update(int id, string name, string empAddress, DateTime dob, int salary)
        {
            Employee objEmp = new Employee() {EmpId = id, Name = name, EmpAddress = empAddress, Dob = dob, Salary = salary };

            int rs = objData.Update(objEmp);

            if (rs == 1)
                return true;
            else
                return false;
        }

        public static DataTable DisplayEmployee()
        {
            return objData.GetAllEmployee();
        }

        public static bool Delete(int empID)
        {
            if (objData.Delete(empID) == 1)
                return true;
            else
                return false;
        }

        public static DataTable SearchEmployee(int empId)
        {
            return objData.GetEmployee(empId);
        }
    }
}

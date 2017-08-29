using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class Employee
    {
        int empId;
        string name;
        string empAddress;
        DateTime dob;
        int salary;

        public int EmpId { get => empId; set => empId = value; }
        public string Name { get => name; set => name = value; }
        public string EmpAddress { get => empAddress; set => empAddress = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}

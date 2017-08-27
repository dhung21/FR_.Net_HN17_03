using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNB_Assignment5_HungDM10
{
    class Program
    {
        static List<Employee> listEmp = new List<Employee>();
        static void Main(string[] args)
        {
            XuLy xl = new XuLy();
            xl.DisplayEmployee(listEmp);
        }
    }
}

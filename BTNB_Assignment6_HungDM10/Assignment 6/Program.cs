using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person objPerson = new Person();
            Person[] arrPerson = new Person [3];

            for (int i = 0; i < arrPerson.Length; i++)
            {
                objPerson = new Person();
                arrPerson[i]= objPerson.InputPersonInfo(objPerson);
            }

            Console.WriteLine("\n=====Managment Person programmer=====");

            objPerson.SortBySalary(arrPerson);

            for (int i = 0; i < arrPerson.Length; i++)
            {
                objPerson.DisplayPersonInfo(arrPerson[i]);
            }
            

            Console.ReadKey();
        }
    }
}

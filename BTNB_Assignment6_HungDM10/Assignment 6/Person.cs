using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_6
{
    public class Person
    {
        string name;
        string address;
        double salary;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public Person InputPersonInfo(Person inpPer)
        {
            bool exit = false;

            Console.WriteLine("Input information of Person");
            Console.Write("Please input name: ");
            inpPer.name = Console.ReadLine();
            Console.Write("Please input address: ");
            inpPer.address = Console.ReadLine();
            while (!exit)
            {
                try
                {
                    Console.Write("Please input salary: ");
                    inpPer.salary = double.Parse(Console.ReadLine());
                    if (inpPer.salary <= 0)
                        throw new ArgumentOutOfRangeException();
                    //if (inpPer.salary.ToString().Length == 0)
                    //    throw new Exception();
                    exit = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must input digit");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Salary is greater than zero");
                }
                //catch (Exception)
                //{
                //    Console.WriteLine("You must input Salary");
                //}
            }

            return inpPer;
        }

        public void DisplayPersonInfo(Person objPer)
        {
            Console.WriteLine("Information of Person you have entered: ");
            Console.WriteLine("Name: {0}\nAddress: {1}\nSalary: {2}\n", objPer.name, objPer.address, objPer.salary);
        }

        public Person[] SortBySalary(Person[] arrPerson)
        {
            Person tempPerson;
            for (int i = 0; i < arrPerson.Length; i++)
            {
                for (int j = i+1; j < arrPerson.Length; j++)
                {
                    if (arrPerson[i].salary > arrPerson[j].salary)
                    {
                        tempPerson = arrPerson[i];
                        arrPerson[i] = arrPerson[j];
                        arrPerson[j] = tempPerson;
                    }
                }
            }

            return arrPerson;
        }
    }
}

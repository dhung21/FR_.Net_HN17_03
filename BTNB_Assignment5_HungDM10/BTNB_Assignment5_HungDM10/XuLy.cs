using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNB_Assignment5_HungDM10
{
    class XuLy : Employee
    {
        public XuLy()
        {

        }

        /*private void SwapEmp(ref Employee emp1,ref Employee emp2)
        {
            Employee temp = emp1;
            emp1 = emp2;
            emp2 = temp;
        }*/

        //Sap xep danh sach nhan vien
        private void SortEmployee(List<Employee> listEmp)
        {
            Employee tempEmp;
            string lastName1, lastName2;

            for (int i = 0; i < (listEmp.Count - 1); i++)
            {
                for (int j = i + 1; j < listEmp.Count; j++)
                {
                    if (listEmp[i].Luong < listEmp[j].Luong) //sap xep theo luong
                    {
                        tempEmp = listEmp[i];
                        listEmp[i] = listEmp[j];
                        listEmp[j] = tempEmp;
                    }
                    if (listEmp[i].Luong == listEmp[j].Luong) //luong = nhau -> theo ten
                    {
                        lastName1 = SplitEmpName(listEmp[i].HoTen);
                        lastName2 = SplitEmpName(listEmp[j].HoTen);
                        if (string.Compare(lastName1, lastName2) == 1)
                        {
                            tempEmp = listEmp[i];
                            listEmp[i] = listEmp[j];
                            listEmp[j] = tempEmp;
                        }
                    }
                }
            }
        }

        //Split chi lay ten de sap xep
        private string SplitEmpName(string name)
        {
            string lastName;
            string[] arrName;
            arrName = name.Split(' ');
            if (arrName.Length >= 2)
            {
                lastName = arrName[arrName.Length - 1];
                return lastName;
            }

            return name;
        }

        //Tim kiem
        private void SearchEmp(List<Employee> listEmp, string hoTen, string phongBan)
        {
            Employee objEmp = new Employee();

            foreach (var item in listEmp)
            {
                if (item.EmpType == 1 && item.HoTen.Equals(hoTen) && item.Khoa.Equals(phongBan))
                {
                    objEmp = item;
                    ShowEmployee(objEmp);
                    break;
                }
                else if (item.EmpType == 2 && item.HoTen.Equals(hoTen) && item.PhongBan.Equals(phongBan))
                {
                    objEmp = item;
                    ShowEmployee(objEmp);
                    break;
                }
            }
        }

        //Tao nhan vien
        private void CreateEmployee(List<Employee> listEmp)
        {
            string hoTen, khoa, phongBan;
            int empType, ngayCong, chucVuTrinhDo, heSoLuong;

            Console.Write("Ho Ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Can Bo: ");
            Console.WriteLine("\t 1.Giang vien\n\t 2.Hanh chinh");
            Console.Write("Chon kieu can bo (1/2): ");
            empType = int.Parse(Console.ReadLine());

            if (empType == 1) //Giang vien
            {
                Console.Write("Khoa: ");
                khoa = Console.ReadLine();
                Console.Write("So tiet day: ");
                ngayCong = int.Parse(Console.ReadLine());
                Console.WriteLine("Trinh do: ");
                Console.WriteLine("\t1.Cu Nhan\n\t2.Thac Si\n\t3.Tien Si");
                Console.Write("Chon trinh do(1/2/3): ");
                chucVuTrinhDo = int.Parse(Console.ReadLine());
                Console.Write("He so luong: ");
                heSoLuong = int.Parse(Console.ReadLine());

                listEmp.Add(new EmpTeacher(hoTen, empType, khoa, chucVuTrinhDo, ngayCong, heSoLuong));
            }
            else if (empType == 2) //Nhan vien hanh chinh
            {
                Console.Write("Phong ban: ");
                phongBan = Console.ReadLine();
                Console.Write("Ngay cong: ");
                ngayCong = int.Parse(Console.ReadLine());
                Console.WriteLine("Chuc vu: ");
                Console.WriteLine("\t1.Truong phong\n\t2.Pho phong\n\t3.Nhan vien");
                Console.Write("Chon chuc vu(1/2/3): ");
                chucVuTrinhDo = int.Parse(Console.ReadLine());
                Console.Write("He so luong: ");
                heSoLuong = int.Parse(Console.ReadLine());

                listEmp.Add(new EmpOfficer(hoTen, empType, phongBan, chucVuTrinhDo, ngayCong, heSoLuong));

            }
        }

        //In ra thong tin nhan vien
        private void ShowEmployee(Employee emp)
        {
            if (emp.EmpType == 1)
            {
                Console.WriteLine("Ho Ten: {0}\tCan bo: {1}\tKhoa: {2}\nTrinh do: {3}\nSo tiet day trong thang: {4}\nHe so luong: {5}\tPhu cap: {6}\nLuong: {7}\n", emp.HoTen, emp.NameEmpType, emp.Khoa, emp.NameChucVu, emp.NgayCong, emp.HeSoLuong, emp.PhuCap, emp.Luong);
            }
            else
            if (emp.EmpType == 2)
            {
                Console.WriteLine("Ho Ten: {0}\tCan bo: {1}\tPhong: {2}\nChuc vu: {3}\nNgay cong: {4}\nHe so luong: {5}\tPhu cap: {6}\nLuong: {7}\n", emp.HoTen, emp.NameEmpType, emp.PhongBan, emp.NameChucVu, emp.NgayCong, emp.HeSoLuong, emp.PhuCap, emp.Luong);
            }

        }

        //
        public void DisplayEmployee(List<Employee> listEmp)
        {
            bool exit = false;
            int opt, numEmp;
            string hoTen, phongBan;

            while (!exit)
            {
                Console.WriteLine("\n---------Options---------");
                Console.WriteLine("1.Nhap nhan vien\n2.Danh sach nhan vien\n3.Tim kiem nhan vien\n4.Thoat");
                Console.Write("Chon hanh dong (1/2/3/4): ");
                opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    Console.Write("So luong nhan vien them moi: ");
                    numEmp = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numEmp; i++)
                    {
                        Console.WriteLine("\n------EmpNo " + (i + 1));
                        CreateEmployee(listEmp);
                    }
                    Console.WriteLine("------Nhap xong------");
                }
                else if (opt == 2)
                {
                    Console.WriteLine("\n------In danh sach nhan vien------");
                    SortEmployee(listEmp);
                    for (int i = 0; i < listEmp.Count; i++)
                    {
                        Console.WriteLine("\n-------------EmpNo " + (i + 1));
                        ShowEmployee(listEmp[i]);
                    }

                    Console.WriteLine("------Het danh sach nhan vien------\n");
                }
                else if (opt == 3)
                {
                    Console.WriteLine("\n------Tim kiem nhan vien------");
                    Console.Write("Ho Ten nhan vien: ");
                    hoTen = Console.ReadLine();
                    Console.Write("Phong ban: ");
                    phongBan = Console.ReadLine();
                    Console.WriteLine("------Ket qua tim kiem------");
                    SearchEmp(listEmp,hoTen,phongBan);
                    Console.WriteLine("------Ket thuc tim kiem------\n");
                }
                else
                {
                    exit = true;
                }
            }
        }
    }
}

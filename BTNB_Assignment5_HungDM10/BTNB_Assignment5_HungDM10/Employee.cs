using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNB_Assignment5_HungDM10
{
    public class Employee
    {
        string hoTen;
        string khoa;
        string nameChucVu; //Lay gia tri chucVuTrinhDo de cho ten
        string phongBan;
        string nameEmpType; //Ten kieu can bo. 1: Giang vien, 2: Hanh chinh
        int empType; //1: Giang vien, 2: Hanh chinh
        int phuCap;
        int heSoLuong;
        int luong;
        int ngayCong;
        int chucVuTrinhDo;

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string Khoa
        {
            get
            {
                return khoa;
            }

            set
            {
                khoa = value;
            }
        }

        public string PhongBan
        {
            get
            {
                return phongBan;
            }

            set
            {
                phongBan = value;
            }
        }

        public int PhuCap
        {
            get
            {
                return phuCap;
            }

            set
            {
                phuCap = value;
            }
        }

        public int HeSoLuong
        {
            get
            {
                return heSoLuong;
            }

            set
            {
                heSoLuong = value;
            }
        }

        public int Luong
        {
            get
            {
                return luong;
            }

            set
            {
                luong = value;
            }
        }

        public int NgayCong
        {
            get
            {
                return ngayCong;
            }

            set
            {
                ngayCong = value;
            }
        }

        public int EmpType
        {
            get
            {
                return empType;
            }

            set
            {
                empType = value;
            }
        }

        public int ChucVuTrinhDo
        {
            get
            {
                return chucVuTrinhDo;
            }

            set
            {
                chucVuTrinhDo = value;
            }
        }

        public string NameChucVu
        {
            get
            {
                return nameChucVu;
            }

            set
            {
                nameChucVu = value;
            }
        }

        public string NameEmpType
        {
            get
            {
                return nameEmpType;
            }

            set
            {
                nameEmpType = value;
            }
        }

        public Employee()
        {
            if (empType == 1)
                this.nameEmpType = "Giang vien";
            else
                this.nameEmpType = "Nhan vien hanh chinh";
        }

        //Lay phu cap theo chuc vu/trinh do
        protected int SetPhuCap(int s1,int s2,int s3)
        {
            if (this.chucVuTrinhDo == 1)
                return s1;
            else if (this.chucVuTrinhDo == 2)
                return s2;
            else
                return s3;
        }

        //Lay ten cho tung chuc vu
        protected string SetNameChucVu(string cv1,string cv2,string cv3)
        {
            if (this.chucVuTrinhDo == 1)
                return cv1;
            else if (this.chucVuTrinhDo == 2)
                return cv2;
            else return cv3;
        }
    }
}

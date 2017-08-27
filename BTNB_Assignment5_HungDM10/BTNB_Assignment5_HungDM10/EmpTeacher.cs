using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNB_Assignment5_HungDM10
{
    class EmpTeacher : XuLy
    {
        public EmpTeacher(string hoTen,int empType, string khoa, int trinhDo,int ngayCong, int heSoLuong)
        {
            int _phuCap;
            this.HoTen = hoTen;
            this.EmpType = empType;
            this.Khoa = khoa;
            this.ChucVuTrinhDo = trinhDo;
            _phuCap = SetPhuCap(300, 500, 1000);
            this.PhuCap = _phuCap;
            this.NgayCong = ngayCong;
            this.HeSoLuong = heSoLuong;
            this.Luong = (heSoLuong * 730 + _phuCap + ngayCong * 45);
            this.NameChucVu = SetNameChucVu("Cu nhan","Thac si","Tien si");
        }
    }
}

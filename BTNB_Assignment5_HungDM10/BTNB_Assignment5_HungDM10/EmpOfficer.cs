using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNB_Assignment5_HungDM10
{
    class EmpOfficer : XuLy
    {
        public EmpOfficer(string hoTen, int empType, string phongBan, int chucVu, int ngayCong, int heSoLuong)
        {
            int _phuCap;
            this.HoTen = hoTen;
            this.EmpType = empType;
            this.PhongBan = phongBan;
            this.ChucVuTrinhDo = chucVu;
            _phuCap = SetPhuCap(2000, 1000, 500);
            this.PhuCap = _phuCap;
            this.NgayCong = ngayCong;
            this.HeSoLuong = heSoLuong;
            this.Luong = (heSoLuong * 730 + _phuCap + ngayCong * 30);
            this.NameChucVu = SetNameChucVu("Truong phong","Pho phong","Nhan vien");
        }
    }
}

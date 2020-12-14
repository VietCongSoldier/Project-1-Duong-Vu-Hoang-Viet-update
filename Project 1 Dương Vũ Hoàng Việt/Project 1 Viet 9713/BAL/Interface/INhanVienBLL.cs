using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL;
using Project_1_Viet_9713.DAL.Interface;

namespace Project_1_Viet_9713.BAL.Interface
{
    interface INhanVienBLL
    {
        List<NhanVien> LayDSNhanVien();
        void ThemNV(NhanVien nv);
        void XoaNV(string manv);
        void SuaNV(NhanVien nv, string manvcu);
        void TimKiemNV(string Masp);
    }
}

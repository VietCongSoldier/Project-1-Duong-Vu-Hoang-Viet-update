using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL;
using Project_1_Viet_9713.DAL.Interface;

namespace Project_1_Viet_9713.BAL.Interface
{
    public interface IHoaDonXuatBLL
    {
        List<HoaDonXuat> LayDSHoaDonXuat();
        void LapHoaDon(HoaDonXuat hd);
        void XoaHD(string mahd);
        void SuaHD(HoaDonXuat hd, string mahdcu);
        void TimKiemHD(string Mahd);
    }
}

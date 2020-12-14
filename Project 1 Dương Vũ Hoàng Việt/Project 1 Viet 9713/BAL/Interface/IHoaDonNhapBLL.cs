using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL;

namespace Project_1_Viet_9713.BAL.Interface
{
    public interface IHoaDonNhapBLL
    {
        List<HoaDonNhap> LayDSHoaDon();
        void LapHoaDon(HoaDonNhap hd);
        void XoaHD(string mahd);
        void SuaHD(HoaDonNhap hd, string mahdcu);
        void TimKiemHD(string Mahd);
        void LayDSSPTuHoaDon(HoaDonNhap hd);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.DAL.Interface
{
    public interface IHoaDonNhapDAL
    {
        List<HoaDonNhap> LayDSHoaDon();
        void LapHoaDon(HoaDonNhap hd);
        void Update(List<HoaDonNhap> list);
    }
}

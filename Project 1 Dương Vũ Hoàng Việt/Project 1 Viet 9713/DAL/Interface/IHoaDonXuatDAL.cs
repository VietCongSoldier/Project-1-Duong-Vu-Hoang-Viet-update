using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.DAL.Interface
{
    public interface IHoaDonXuatDAL
    {
        List<HoaDonXuat> LayDSHoaDon();
        void LapHoaDon(HoaDonXuat hd);
        void Update(List<HoaDonXuat> list);
    }
}

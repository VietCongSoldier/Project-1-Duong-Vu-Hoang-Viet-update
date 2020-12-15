using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.DAL.Interface
{
    interface IHoaDonXuatDAL
    {
        List<HoaDonXuat> LayDSHoaDonXuatKho();
        void LapHoaDonXuat(HoaDonXuat hdx);
        void Update(List<HoaDonXuat> list);
    }
}

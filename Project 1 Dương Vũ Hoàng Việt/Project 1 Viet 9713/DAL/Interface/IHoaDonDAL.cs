using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.DAL.Interface
{
    public interface IHoaDonDAL
    {
        List<HoaDon> LayDSHoaDon();
        void LapHoaDon(HoaDon hd);
        void Update(List<HoaDon> list);
    }
}

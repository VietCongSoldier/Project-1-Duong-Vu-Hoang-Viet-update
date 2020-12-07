using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.BAL.Interface
{
    public interface IHangHoaBLL
    {
        List<HangHoa> LayDSSanPham();
        void ThemSP(HangHoa hh);
        void XoaSP(string masp);
        void SuaSP(HangHoa hh);
        void TimKiemSP(string Masp);
    }
}

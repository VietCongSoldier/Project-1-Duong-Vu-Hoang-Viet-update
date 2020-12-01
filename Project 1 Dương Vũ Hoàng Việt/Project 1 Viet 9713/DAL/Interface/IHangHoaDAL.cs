using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.DAL.Interface
{
    public interface IHangHoaDAL
    {
        List<HangHoa> LayDSSanPham();
        void ThemSP(HangHoa hh);
        void Update(List<HangHoa> list);
    }
}

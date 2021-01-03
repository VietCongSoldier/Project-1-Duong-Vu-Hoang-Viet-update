using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL.Interface;
using Project_1_Viet_9713.DAL;

namespace Project_1_Viet_9713.BAL.Interface
{
    interface INhaCungCapBLL
    {
        List<NhaCungCap> LayDSNhaCungCap();
        void ThemNCC(NhaCungCap ncc);
        void XoaNCC(string mancc);
        void SuaNCC(NhaCungCap ncc, string mancccu);
        void TimKiemNCC(string Mancc);
    }
}
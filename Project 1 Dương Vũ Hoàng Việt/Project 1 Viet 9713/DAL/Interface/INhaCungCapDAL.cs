using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.DAL.Interface
{
    interface INhaCungCapDAL
    {
        List<NhaCungCap> LayDSNhaCungCap();
        void ThemNhaCungCap(NhaCungCap ncc);
        void Update(List<NhaCungCap> list);
    }
}

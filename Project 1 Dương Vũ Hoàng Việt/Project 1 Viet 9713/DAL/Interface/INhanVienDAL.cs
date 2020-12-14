using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.DAL.Interface
{
     interface INhanVienDAL
    {
        List<NhanVien> LayDSNhanVien();
        void ThemNhanVien(NhanVien nv);
        void Update(List<NhanVien> list);
    }
}

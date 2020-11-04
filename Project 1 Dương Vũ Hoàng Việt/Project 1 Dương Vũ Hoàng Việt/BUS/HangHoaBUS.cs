using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_Dương_Vũ_Hoàng_Việt.DAL
{
    class HangHoaBUS
    {
        public HangHoaDAL hanghoaDAL = new HangHoaDAL();

        public void ThemSP(string masp, string tensp, string donvitinh, int dongia, int soluong, int thanhtien)
        {
            hanghoaDAL.Themsp(masp,tensp,donvitinh,dongia,soluong,thanhtien);
        }
        public void Suasp(string masp, string tensp, string donvitinh, int dongia, int soluong, int thanhtien)
        {
            hanghoaDAL.Suasp(masp,tensp,donvitinh,dongia,soluong,thanhtien);
        }
        public void XoaSP(string masp)
        {
            hanghoaDAL.Xoasp(masp);
        }
        public List<string> DanhSachSP()
        {
            return hanghoaDAL.DanhSachSP();
        }
    }
}

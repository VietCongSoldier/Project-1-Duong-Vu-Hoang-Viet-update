using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_Dương_Vũ_Hoàng_Việt.DAL
{
    class HangHoaBUS
    {
        private HangHoaDAL hanghoaDAL = new HangHoaDAL();
        public List<string> DanhSachSP()
        {
            return hanghoaDAL.DanhSachSP();
        }
        public void ThemSP(string masp, string tensp, string donvitinh, string phuongthuctt, int dongia, int soluong, int thanhtien)
        {
            hanghoaDAL.Themsp(masp,tensp,donvitinh,phuongthuctt,dongia,soluong,thanhtien);
        }
        public void Suasp(string masp, string tensp, string donvitinh, string phuongthuctt, int dongia, int soluong, int thanhtien)
        {
            hanghoaDAL.Suasp(masp,tensp,donvitinh,phuongthuctt,dongia,soluong,thanhtien);
        }
        public void XoaSP(string masp)
        {
            hanghoaDAL.Xoasp(masp);
        }
    }
}

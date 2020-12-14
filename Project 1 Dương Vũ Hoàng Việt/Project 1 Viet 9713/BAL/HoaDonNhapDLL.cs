using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL;
using Project_1_Viet_9713.DAL.Interface;
using Project_1_Viet_9713.BAL;
using Project_1_Viet_9713.BAL.Interface;

namespace Project_1_Viet_9713.BAL
{
    public class HoaDonBLL : IHoaDonNhapBLL
    {
        private IHoaDonNhapDAL hdDAL = new HoaDonNhapDAL();
        public void LapHoaDon(HoaDonNhap hd)
        {
            hdDAL.LapHoaDon(hd);
        }

        public List<HoaDonNhap> LayDSHoaDon()
        {
            return hdDAL.LayDSHoaDon();
        }

        public void SuaHD(HoaDonNhap hd, string mahdcu)
        {
            int i;
            List<HoaDonNhap> list = LayDSHoaDon();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahoadon == mahdcu) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hd);
                hdDAL.Update(list);
            }
        }

        public void TimKiemHD(string Mahd)
        {
            int i;
            List<HoaDonNhap> list = LayDSHoaDon();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahoadon == Mahd) break;
            }
            if (i < list.Count)
            {
                Console.Clear();
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.Write("Mã Hóa đơn này không tồn tại !");
            }
        }

        public void XoaHD(string mahd)
        {
            int i;
            List<HoaDonNhap> list = LayDSHoaDon();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahoadon == mahd) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hdDAL.Update(list);
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.WriteLine($"Mã hóa đơn này không tồn tại !");
            }
        }
        public void LayDSSPTuHoaDon(HoaDonNhap hd)
        {

        }
    }
}

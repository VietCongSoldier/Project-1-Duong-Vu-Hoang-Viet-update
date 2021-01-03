using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.DAL;
using Project_1_Viet_9713.DAL.Interface;

namespace Project_1_Viet_9713.BAL
{
    public class HoaDonXuatDLL : IHoaDonXuatBLL
    {
        private IHoaDonXuatDAL hdxDAL = new HoaDonXuatDAL();
        public void LapHoaDon(HoaDonXuat hdx)
        {
            hdxDAL.LapHoaDonXuat(hdx);
        }
        public List<HoaDonXuat> LayDSHoaDonXuat()
        {
            return hdxDAL.LayDSHoaDonXuat();
        }
        public void SuaHD(HoaDonXuat hdx, string mahdcu)
        {
            int i;
            List<HoaDonXuat> list = LayDSHoaDonXuat();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahoadon == mahdcu) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hdx);
                hdxDAL.Update(list);
            }
        }

        public void TimKiemHD(string Mahd)
        {
            int i;
            List<HoaDonXuat> list = LayDSHoaDonXuat();
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
            List<HoaDonXuat> list = LayDSHoaDonXuat();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahoadon == mahd) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hdxDAL.Update(list);
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.WriteLine($"Mã hóa đơn này không tồn tại !");
            }
        }
    }
}

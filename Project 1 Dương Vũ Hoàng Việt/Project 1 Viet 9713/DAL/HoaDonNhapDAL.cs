using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Project_1_Viet_9713.DAL.Interface;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.DAL
{
    public class HoaDonNhapDAL : IHoaDonNhapDAL
    {
        private string filename = "hoadonnhap.txt";
        public List<HoaDonNhap> LayDSHoaDon()
        {
            List<HoaDonNhap> list = new List<HoaDonNhap>();
            StreamReader SR = File.OpenText(filename);
            string read = SR.ReadLine();
            while (read != null)
            {
                if (read != "")
                {
                    string[] plit = read.Split("|");
                    list.Add(new HoaDonNhap(plit[0], plit[1], plit[2], plit[3],plit[4]));
                }
                read = SR.ReadLine();
            }
            SR.Close();
            return list;
        }
        public void LapHoaDon(HoaDonNhap hd)
        {
            string mahd = "HD" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter SW = new StreamWriter(filename, true);
            SW.WriteLine($"{hd.Mahoadon}|{hd.Tennv}|{hd.Ngaynhap}");
            SW.Close();
        }
        public void Update(List<HoaDonNhap> list)
        {

            StreamWriter SW = File.CreateText(filename);
            for (int i = 0; i < list.Count; ++i)
            {
                SW.WriteLine($"{list[i].Mahoadon}|{list[i].Tennv}|{list[i].Ngaynhap}");
            }
            SW.Close();
        }
    }
}

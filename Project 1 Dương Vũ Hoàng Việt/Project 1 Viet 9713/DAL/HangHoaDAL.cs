using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL.Interface;

namespace Project_1_Viet_9713.DAL
{
    public class HangHoaDAL : IHangHoaDAL
    {
        private string filename="hanghoa.txt";
        public List<HangHoa> LayDSSanPham()
        {
            List<HangHoa> list = new List<HangHoa>();
            StreamReader SR = File.OpenText(filename);
            string read = SR.ReadLine();
            while (read != null)
            {
                if (read != "")
                {
                    string[] plit = read.Split("|");
                    list.Add(new HangHoa(plit[0], plit[1], int.Parse(plit[2]), int.Parse(plit[3]), plit[4], int.Parse(plit[5])));
                }
                read = SR.ReadLine();
            }
            SR.Close();
            return list;
        }
        public void ThemSP(HangHoa hh)
        {
            StreamWriter SW = new StreamWriter(filename,true);
            SW.WriteLine($"{hh.Masp}|{hh.Tensp}|{hh.Dongia}|{hh.Soluong}|{hh.Donvitinh}|{hh.Thanhtien}|{hh.Ngaynhap}");
            SW.Close();
        }
        public void Update(List<HangHoa> list)
        {
            StreamWriter SW = File.CreateText(filename);
            for (int i=0;i<list.Count;++i)
            {
                SW.WriteLine($"{list[i].Masp}|{list[i].Tensp}|{list[i].Dongia}|{list[i].Soluong}|{list[i].Donvitinh}|{list[i].Thanhtien}");
            }
            SW.Close();
        }
    }
}

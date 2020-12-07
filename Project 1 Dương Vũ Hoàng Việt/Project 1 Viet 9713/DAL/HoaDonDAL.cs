using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Project_1_Viet_9713.DAL.Interface;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.DAL
{
    public class HoaDonDAL : IHoaDonDAL
    {
        private string filename = "HoaDon.txt";
        public List<HoaDon> LayDSHoaDon()
        {
            List<HoaDon> list = new List<HoaDon>();
            StreamReader SR = File.OpenText(filename);
            string read = SR.ReadLine();
            while (read != null)
            {
                if (read != "")
                {
                    string[] plit = read.Split("|");
                    list.Add(new HoaDon(plit[0], plit[1], plit[2],plit[3],int.Parse(plit[4])));
                }
                read = SR.ReadLine();
            }
            SR.Close();
            return list;
        }

        public void LapHoaDon(HoaDon hd)
        {
            string mahd = "HD" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter SW = new StreamWriter(filename, true);
            SW.WriteLine($"{hd.Mahoadon}|{hd.Tennvxuatkho}|{hd.Ngaynhap}");
            SW.Close();
        }

        public void Update(List<HoaDon> list)
        {
            
        }
    }
}

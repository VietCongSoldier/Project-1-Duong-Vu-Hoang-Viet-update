﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL.Interface;

namespace Project_1_Viet_9713.DAL
{
    public class HoaDonXuatDAL : IHoaDonXuatDAL
    {
        
        private string filename = "hoadonxuat.txt";
        public List<HoaDonXuat> LayDSHoaDon()
        {
            List<HoaDonXuat> list = new List<HoaDonXuat>();
            StreamReader SR = File.OpenText(filename);
            string read = SR.ReadLine();
            while (read != null)
            {
                if (read != "")
                {
                    string[] plit = read.Split("|");
                    list.Add(new HoaDonXuat(plit[0], plit[1], plit[2], plit[3], plit[4]));
                }
                read = SR.ReadLine();
            }
            SR.Close();
            return list;
        }
        public void LapHoaDonXuat(HoaDonXuat hdx)
        {
            string mahd = "HD" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter SW = new StreamWriter(filename, true);
            SW.WriteLine($"{hdx.Mahoadon}|{hdx.Manv}|{hdx.Tennv}|{hdx.Sdt}|{hdx.Ngayxuat}");
            SW.Close();
        }
        public void Update(List<HoaDonXuat> list)
        {

            StreamWriter SW = File.CreateText(filename);
            for (int i = 0; i < list.Count; ++i)
            {
                SW.WriteLine($"{list[i].Mahoadon}|{list[i].Manv}|{list[i].Tennv}|{list[i].Sdt}|{list[i].Ngayxuat}");
            }
            SW.Close();
        }
    }
}

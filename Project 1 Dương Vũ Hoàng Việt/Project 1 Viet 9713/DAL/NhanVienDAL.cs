using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL.Interface;

namespace Project_1_Viet_9713.DAL
{
    class NhanVienDAL : INhanVienDAL
    {
        private string filename = "nhanvien.txt";
        public List<NhanVien> LayDSNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            StreamReader SR = File.OpenText(filename);
            string read = SR.ReadLine();
            while (read != null)
            {
                if (read != "")
                {
                    string[] plit = read.Split("|");
                    list.Add(new NhanVien(plit[0], plit[1], int.Parse(plit[2]), plit[3], plit[4], plit[5]));
                }
                read = SR.ReadLine();
            }
            SR.Close();
            return list;
        }
        public void ThemNhanVien(NhanVien nv)
        {
            StreamWriter SW = new StreamWriter(filename, true);
            SW.WriteLine($"{nv.Manv}|{nv.Hoten}|{nv.Namsinh}|{nv.Gioitinh}|{nv.Sdt}|{nv.Chucvu}");
            SW.Close();
        }
        public void Update(List<NhanVien> list)
        {
            StreamWriter SW = File.CreateText(filename);
            for (int i = 0; i < list.Count; ++i)
            {
                SW.WriteLine($"{list[i].Manv}|{list[i].Hoten}|{list[i].Namsinh}|{list[i].Gioitinh}|{list[i].Sdt}|{list[i].Chucvu}"); 
            }
            SW.Close();
        }
    }
}

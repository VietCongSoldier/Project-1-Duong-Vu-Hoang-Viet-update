using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Project_1_Viet_9713.DAL.Interface;
using Project_1_Viet_9713.Entities;

namespace Project_1_Viet_9713.DAL
{
    class NhaCungCapDAL : INhaCungCapDAL
    {
        private string filename = "nhacungcap.txt";
        public List<NhaCungCap> LayDSNhaCungCap()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            StreamReader SR = File.OpenText(filename);
            string read = SR.ReadLine();
            while (read != null)
            {
                if (read != "")
                {
                    string[] plit = read.Split("|");
                    list.Add(new NhaCungCap(plit[0], plit[1],plit[2],plit[3]));
                }
                read = SR.ReadLine();
            }
            SR.Close();
            return list;
        }
        public void ThemNhaCungCap(NhaCungCap ncc)
        {
            StreamWriter SW = new StreamWriter(filename, true);
            SW.WriteLine($"{ncc.Mancc}|{ncc.Tenncc}|{ncc.Sdt}|{ncc.Diachi}");
            SW.Close();
        }
        public void Update(List<NhaCungCap> list)
        {
            StreamWriter SW = File.CreateText(filename);
            for (int i = 0; i < list.Count; ++i)
            {
                SW.WriteLine($"{list[i].Mancc}|{list[i].Tenncc}|{list[i].Sdt}|{list[i].Diachi}");
            }
            SW.Close();
        }
    }
}

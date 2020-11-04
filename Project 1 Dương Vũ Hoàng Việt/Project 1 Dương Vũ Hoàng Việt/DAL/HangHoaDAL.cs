using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project_1_Dương_Vũ_Hoàng_Việt
{
    class HangHoaDAL
    {
        private string filename = "hanghoa.txt";
        public HangHoaDAL()
        {
            
        }
        public List<String> DanhSachSP()
        {
            StreamReader SR =new StreamReader(filename);
            string read;
            List<String> DSSanPham = new List<string>();
            while ((read = SR.ReadLine()) != null) {
                if (read==null) Console.WriteLine("Rỗng"); continue;
                string[] plit = read.Split("|");
                string dulieu = plit[0] + "\t" + plit[1] + "\t" + plit[2] + "\t" + plit[3] + "\t" + plit[4] + "\t" + plit[5];
                DSSanPham.Add(dulieu);
            }
            SR.Close();
            return DSSanPham;
        }
        public void Themsp(string masp,string tensp,string donvitinh,int dongia,int soluong,int thanhtien)
        {

            StreamWriter SW = new StreamWriter(filename, true);
            SW.WriteLine($"{masp}|{tensp}|{dongia}|{soluong}|{donvitinh}|{thanhtien}\n");
            SW.Close();
        }
        public void Suasp(string masp, string tensp, string donvitinh, int dongia, int soluong, int thanhtien)
        {
            string temp = "";
            StreamReader SR = new StreamReader(filename);
            string read;
            while ((read = SR.ReadLine()) != null)
            {
                if (read == null) break;
                string[] dlhanghoa = read.Split('|');
                if (dlhanghoa[0] == masp)
                {
                    temp += masp + '|' + tensp + '|' + dongia + '|' + soluong + '|' + donvitinh + '|' + thanhtien +"\n";
                }
                else
                {
                    temp += read+"\n";
                }
            }
            SR.Close();
            StreamWriter SW = new StreamWriter(filename);
            SW.Write(temp);
            SW.Close();
        }
        public void Xoasp(string masp)
        {
            string temp = "";
            StreamReader SR = new StreamReader(filename);
            string read;
            while ((read = SR.ReadLine()) != null)
            {
                string[] dlhanghoa = read.Split('|');
                if (dlhanghoa[0] != masp)
                {
                    temp = read + "\n";
                }
            }
            SR.Close();
            StreamWriter SW = new StreamWriter(filename);
            SW.Write(temp);
            SW.Close();
        }
        public string ThongTinSP(string masp)
        {
            string temp = "";
            StreamReader SR = new StreamReader(filename);
            string read;
            while ((read = SR.ReadLine()) != null)
            {
                if (read == null) continue;
                string[] dlhanghoa = read.Split('|');
                if (dlhanghoa[0] == masp)
                {
                    temp = dlhanghoa[0] + "\t"+ dlhanghoa[1] + "\t" + dlhanghoa[2] + "\t" + dlhanghoa[3] + "\t" + dlhanghoa[4] + "\t" + dlhanghoa[5];
                }
            }
            SR.Close();
            return temp;
        }
        
    }
}

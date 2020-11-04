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
        public List<String> DSHangHoa()
        {
            Console.Clear();Console.Beep();
            StreamReader SR =new StreamReader(filename);
            string docfile;
            List<String> DSHangHoa = new List<string>();
            do
            {
                docfile = SR.ReadLine();
                if (docfile==null)
                {
                    break;
                }
                string[] plit = docfile.Split("|");
                int dong = int.Parse(plit[0]);
                string dulieu = plit[0] + "| " + plit[1] + "|" + plit[2] + "|" + plit[3] + "|" + plit[4] + "|" + plit[5] + "|" + plit[6];
                DSHangHoa.Add(dulieu);
            }
            while (docfile != null);
            SR.Close();
            return DSHangHoa;
        }
        public void Themsp(string tensp,string masp,string donvitinh,string phuongthuctt,int dongia,int soluong,int thanhtien)
        {

            StreamWriter SW = new StreamWriter(filename, true);
            SW.WriteLine($"{masp}|{tensp}|{dongia}|{soluong}|{donvitinh}|{thanhtien}|{phuongthuctt}\n");
            SW.Close();
        }
        public void Suasp(string tensp, string masp, string donvitinh, string phuongthuctt, int dongia, int soluong, int thanhtien)
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
                    temp += masp + '|' + tensp + '|' + dongia + '|' + soluong + '|' + donvitinh + '|' + thanhtien + '|' + phuongthuctt+"\n";
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
                    temp = dlhanghoa[0] + "\t"+ dlhanghoa[1] + "\t" + dlhanghoa[2] + "\t" + dlhanghoa[3] + "\t" + dlhanghoa[4] + "\t" + dlhanghoa[5] + "\t" + dlhanghoa[6];
                }
            }
            SR.Close();
            return temp;
        }
        
    }
}

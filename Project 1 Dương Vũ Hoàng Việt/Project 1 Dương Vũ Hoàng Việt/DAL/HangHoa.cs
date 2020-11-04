using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project_1_Dương_Vũ_Hoàng_Việt
{
    class HangHoa
    {
        private StreamReader SR;
        private StreamWriter SW;
        private string filename = "hanghoa.txt";
        public HangHoa()
        {
            
        }
        public void HienThiHangHoa()
        {
            Console.Clear();Console.Beep();
            SR =new StreamReader(filename);
            string docfile;
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("Mã SP");
            Console.SetCursorPosition(10, 0);
            Console.WriteLine("Tên SP");
            Console.SetCursorPosition(27, 0);
            Console.WriteLine("Đơn giá");
            Console.SetCursorPosition(40, 0);
            Console.WriteLine("Số Lượng");
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Đơn vị tính");
            Console.SetCursorPosition(64, 0);
            Console.WriteLine("Thành tiền(VNĐ)");
            Console.SetCursorPosition(81, 0);
            Console.WriteLine("Phương thức thanh toán");
            do
            {
                docfile = SR.ReadLine();
                if (docfile==null)
                {
                    break;
                }
                try
                {
                    string[] plit;
                    plit = docfile.Split("|");
                    int dong = int.Parse(plit[0]);
                    Console.SetCursorPosition(1, dong);
                    Console.WriteLine(plit[0]);
                    Console.SetCursorPosition(10, dong);
                    Console.WriteLine(plit[1]);
                    Console.SetCursorPosition(27, dong);
                    Console.WriteLine(plit[2]);
                    Console.SetCursorPosition(40, dong);
                    Console.WriteLine(plit[3]);
                    Console.SetCursorPosition(50, dong);
                    Console.WriteLine(plit[4]);
                    Console.SetCursorPosition(64, dong);
                    Console.WriteLine(plit[5]);
                    Console.SetCursorPosition(81, dong);
                    Console.WriteLine(plit[6]);
                }
                catch (Exception e)
                { 
                }

            }
            while (docfile != null);
            SR.Close();
        }
        public void Themsp()
        {
            Console.Clear();
            SW = new StreamWriter(filename,true);
            string tensp, masp, donvitinh,phuongthuctt;
            int dongia, soluong;
            do {
                Console.SetCursorPosition(45,8); Console.Beep();
                Console.Write("Nhập Mã SP:"); masp = Console.ReadLine();
            } while (masp == "");
            do
            {
                Console.SetCursorPosition(45, 9); Console.Beep();
                Console.Write("Nhập Tên SP:"); tensp = Console.ReadLine();
            } while (tensp == "");
            Console.SetCursorPosition(45, 10); Console.Beep();
            Console.Write("Đơn giá:"); dongia = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(45, 11); Console.Beep();
            Console.Write("Số lượng:"); soluong = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(45, 12); Console.Beep();
            Console.Write("Đơn vị tính:"); donvitinh = Console.ReadLine();
            Console.SetCursorPosition(45, 13); Console.Beep();
            Console.Write("Phương thức thanh toán:"); phuongthuctt = Console.ReadLine();
            int thanhtien = dongia * soluong;
            Console.SetCursorPosition(45, 14); Console.Beep();
            Console.WriteLine($"Thành tiền:{thanhtien} (VNĐ)");
            Console.SetCursorPosition(45, 15); Console.Beep();
            Console.WriteLine("Đã thêm sản phẩm vào kho !");
            SW.WriteLine($"{masp}|{tensp}|{dongia}|{soluong}|{donvitinh}|{thanhtien}|{phuongthuctt}\n");
            SW.Close();
        }
        public void Suasp()
        {
            Console.Clear();
            Console.SetCursorPosition(43, 9); Console.Beep();
            Console.Write("Nhập Mã SP cần sửa:"); string masp = Console.ReadLine();
            Console.SetCursorPosition(43, 10); Console.Beep();
            Console.Write("Nhập Mã SP mới:"); string tensp = Console.ReadLine();
            Console.SetCursorPosition(43, 11); Console.Beep();
            Console.Write("Nhập Tên SP mới:"); string maspmoi = Console.ReadLine();
            Console.SetCursorPosition(43, 12); Console.Beep();
            Console.Write("Đơn giá:"); int dongia = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(43, 13); Console.Beep();
            Console.Write("Số lượng:"); int soluong = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(43, 14); Console.Beep();
            Console.Write("Đơn vị tính:"); string donvitinh = Console.ReadLine();
            Console.SetCursorPosition(43, 15); Console.Beep();
            Console.Write("Phương thức thanh toán:"); string phuongthuctt = Console.ReadLine();
            Console.SetCursorPosition(43, 16); Console.Beep();
            Console.WriteLine("Sản phẩm đã được sửa thành công !");
            int thanhtien = dongia * soluong;
            string temp = "";
            SR = new StreamReader(filename);
            string read;
            while ((read = SR.ReadLine()) != null)
            {
                if (read == null) break;
                string[] dlhanghoa = read.Split('|');
                if (dlhanghoa[0] == masp)
                {
                    temp += maspmoi + '|' + tensp + '|' + dongia + '|' + soluong + '|' + donvitinh + '|' + thanhtien + '|' + phuongthuctt;
                }
                else
                {
                    temp += dlhanghoa[0] + '|' + dlhanghoa[1] + '|' + dlhanghoa[2] + '|' + dlhanghoa[3] + '|' + dlhanghoa[4] + '|' + dlhanghoa[5] + '|' + dlhanghoa[6];
                }
            }
            SR.Close();
            SW = new StreamWriter(filename);
            SW.Write(temp);
            SW.Close();
        }
        public void Xoasp()
        {
            Console.Clear();
            Console.SetCursorPosition(43, 9); Console.Beep();
            Console.Write("Nhập Mã SP cần xóa:"); string masp = Console.ReadLine();
            string temp = "";
            SR = new StreamReader(filename);
            string read;
            while ((read = SR.ReadLine()) != null)
            {
                string[] dlhanghoa = read.Split('|');
                if (dlhanghoa[0] == masp)
                {
                    continue;
                }
                else
                {
                    temp += dlhanghoa[0] + '|' + dlhanghoa[1] + '|' + dlhanghoa[2] + '|' + dlhanghoa[3] + '|' + dlhanghoa[4] + '|' + dlhanghoa[5] + '\n';
                }
            }
            Console.SetCursorPosition(43, 11); Console.Beep();
            Console.WriteLine("Đã xóa sản phẩm !");
            SR.Close();
            SW = new StreamWriter(filename);
            SW.Write(temp);
            SW.Close();
        }
        public void Timkiemsp()
        {

        }
        
    }
}

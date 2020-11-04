using Project_1_Dương_Vũ_Hoàng_Việt.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_Dương_Vũ_Hoàng_Việt.GUI
{
    class GUIHangHoa
    {
        private HangHoaBUS hanghoaBUS = new HangHoaBUS();

        public void MENUHangHoa()
        {
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 8); Console.WriteLine(" ____________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 9); Console.WriteLine("|                    Quản Lý Danh Sách Sản Phẩm                      |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 10); Console.WriteLine("|____________________________________________________________________|");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 11); Console.WriteLine("|                1. Hiển thị toàn bộ sản phẩm trong kho.             |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 12); Console.WriteLine("|                2. Thêm sản phẩm vào kho.                           |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 13); Console.WriteLine("|                3. Sửa sản phẩm trong kho.                          |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 14); Console.WriteLine("|                4. Xóa sản phẩm trong kho.                          |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 15); Console.WriteLine("|                5. Tìm kiếm sản phẩm trong kho.                     |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 16); Console.WriteLine("|                6. Quay lại.                                        |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 17); Console.WriteLine("|                                                                    |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 18); Console.WriteLine("|____________________________________________________________________|");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(48, 17); Console.Write("Chọn công cụ số:"); Console.Beep();
            string chon = Console.ReadLine();
            if (chon == "1")
            {
                HienThiHangHoa();
                Console.ReadKey();
            }
            else if (chon == "2")
            {
                Themsp();
                Console.ReadKey();
            }
            else if (chon == "3")
            {
                Suasp();
                Console.ReadKey();
            }
            else if (chon == "4")
            {
                Xoasp();
                Console.ReadKey();
            }
            else if (chon == "5")
            {
                TimKiemSP();
                Console.ReadKey();
            }
            else if (chon == "6")
            {
                Console.Beep();
                return;
            }
            Console.Clear();
            MENUHangHoa();
        }
        public void HienThiHangHoa()
        {
            Console.Clear();
            Console.SetCursorPosition(43,8);
            Console.WriteLine("DANH SÁCH SẢN PHẨM TRONG KHO");
            foreach(string dl in hanghoaBUS.DanhSachSP())
            {
                Console.WriteLine(dl);
            }
        }
        public void Themsp()
        {
            Console.Clear();
            string tensp, masp, donvitinh;
            int dongia, soluong;
            do
            {
                Console.SetCursorPosition(45, 8); Console.Beep();
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
            int thanhtien = dongia * soluong;
            Console.SetCursorPosition(45, 14); Console.Beep();
            Console.WriteLine($"Thành tiền:{thanhtien} (VNĐ)");
            hanghoaBUS.ThemSP(masp, tensp, donvitinh, dongia, soluong, thanhtien);
            Console.SetCursorPosition(45, 15); Console.Beep();
            Console.WriteLine("Đã thêm sản phẩm vào kho !");
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
            int thanhtien = dongia * soluong;
            Console.SetCursorPosition(43, 15); Console.Beep();
            hanghoaBUS.Suasp(maspmoi, tensp, donvitinh, dongia, soluong, thanhtien);
            Console.SetCursorPosition(43, 16); Console.Beep();
            Console.WriteLine("Sản phẩm đã được sửa thành công !");
        }
        public void Xoasp()
        {
            Console.Clear();
            Console.SetCursorPosition(43, 9); Console.Beep();
            Console.Write("Nhập Mã SP cần xóa:"); string masp = Console.ReadLine();
            hanghoaBUS.XoaSP(masp);
            Console.SetCursorPosition(43, 11); Console.Beep();
            Console.WriteLine("Đã xóa sản phẩm !");
        }
        public void TimKiemSP()
        {

        }
    }
}

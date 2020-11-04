using System;
using System.Text;

namespace Project_1_Dương_Vũ_Hoàng_Việt
{
    class GUI_Chinh
    {
        public void MENUCHINH()
        {
            Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
            Console.SetCursorPosition(25,  8); Console.WriteLine("______________________________________________________________________");
            Console.SetCursorPosition(25,  9); Console.WriteLine("|                              MENU                                  |");
            Console.SetCursorPosition(25, 10); Console.WriteLine("|____________________________________________________________________|");
            Console.SetCursorPosition(25, 11); Console.WriteLine("|              1. Quản lý danh sách sản phẩm trong kho.              |");
            Console.SetCursorPosition(25, 12); Console.WriteLine("|              2. Quản lý hóa đơn nhập xuất kho.                     |");
            Console.SetCursorPosition(25, 13); Console.WriteLine("|              3.     |");
            Console.SetCursorPosition(25, 14); Console.WriteLine("|              4. Hiển thị toàn bộ sản phẩm trong kho.               |");
            Console.SetCursorPosition(25, 15); Console.WriteLine("|              5. Thoát.                                             |");
            Console.SetCursorPosition(25, 16); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 17); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 18); Console.WriteLine("|                                                                    |");
            Console.SetCursorPosition(25, 19); Console.WriteLine("|____________________________________________________________________|");
            string chon;
                Console.SetCursorPosition(48, 18); Console.Write("Chọn công cụ số:");Console.Beep();
                chon = Console.ReadLine();
            Console.Clear();
            if (chon == "1")
            {
                MENUHangHoa();
            }
            else if (chon == "2")
            {
                Console.Beep();
                HangHoaDAL HH = new HangHoaDAL();
                
                Console.ReadKey();
            }
            else if (chon == "3")
            {
                Console.Beep();
                HangHoaDAL HH = new HangHoaDAL();
                
                Console.ReadKey();
            }
            else if (chon == "4")
            {
                Console.Beep();
                HangHoaDAL HH = new HangHoaDAL();
                HH.HienThiHangHoa();
                Console.ReadKey();
            }
            else if (chon == "5")
            {
                Console.Beep();
                return;
            }
            Console.Clear();
            MENUCHINH();
        }
        public void MENUHangHoa()
        {
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25,  8); Console.WriteLine(" ____________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25,  9); Console.WriteLine("|                    Quản Lý Danh Sách Sản Phẩm                      |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 10); Console.WriteLine("|____________________________________________________________________|");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 11); Console.WriteLine("|                1. Hiển thị toàn bộ sản phẩm trong kho.             |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 12); Console.WriteLine("|                2. Thêm sản phẩm vào kho.                           |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 13); Console.WriteLine("|                3. Sửa sản phẩm trong kho.                          |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 14); Console.WriteLine("|                4. Xóa sản phẩm trong kho.                          |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 15); Console.WriteLine("|                5. Tìm Kiếm sản phẩm trong kho.                     |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 16); Console.WriteLine("|                6. Quay lại.                                        |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 17); Console.WriteLine("|                                                                    |");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(25, 18); Console.WriteLine("|____________________________________________________________________|");
            Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(48, 17); Console.Write("Chọn công cụ số:"); Console.Beep();
            string chon = Console.ReadLine();
            if (chon == "1")
            {
                HangHoaDAL HH = new HangHoaDAL();
                HH.HienThiHangHoa();
                Console.ReadKey();
            }
            else if (chon == "2")
            {
                HangHoaDAL HH = new HangHoaDAL();
                HH.Themsp();
                Console.ReadKey();
            }
            else if (chon == "3")
            {
                HangHoaDAL HH = new HangHoaDAL();
                HH.Suasp();
                Console.ReadKey();
            }
            else if (chon == "4")
            {
                HangHoaDAL HH = new HangHoaDAL();
                HH.Xoasp();
                Console.ReadKey();
            }
            else if (chon == "5")
            {
                HangHoaDAL HH = new HangHoaDAL();
                HH.Timkiemsp();
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
    }
}

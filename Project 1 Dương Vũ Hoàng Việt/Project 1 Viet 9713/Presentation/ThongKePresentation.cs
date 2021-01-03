using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.BAL;

namespace Project_1_Viet_9713.Presentation
{
    class ThongKePresentation
    {
        public void MENUThongKe()
        {
            Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
            Console.SetCursorPosition(25, 6); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(25, 7); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 8); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 9); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 10); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(25, 11); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 12); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 13); Console.WriteLine("█░              1. Thống kê sản phẩm theo theo từng Mã Loại.         ░█");
            Console.SetCursorPosition(25, 14); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 15); Console.WriteLine("█░              2.                                                   ░█");
            Console.SetCursorPosition(25, 16); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 17); Console.WriteLine("█░              3.                                                   ░█");
            Console.SetCursorPosition(25, 18); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 19); Console.WriteLine("█░              4.                                                   ░█");
            Console.SetCursorPosition(25, 20); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 21); Console.WriteLine("█░              5. Thoát.                                            ░█");
            Console.SetCursorPosition(25, 22); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 23); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 24); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 25); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(56, 8); Console.WriteLine("MENU");
            string chon;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(48, 23); Console.Write("Chọn công cụ số:"); Console.Beep();
            Console.ForegroundColor = ConsoleColor.Gray;
            chon = Console.ReadLine();
            HangHoaPresentation hhPre = new HangHoaPresentation();
            NhanVienPresentation nvPre = new NhanVienPresentation();
            Console.Clear();
            if (chon == "1")
            {
                
            }
            else if (chon == "2")
            {
                Console.Beep();
                
                Console.ReadKey();
            }
            else if (chon == "3")
            {
                
                Console.ReadKey();
            }
            else if (chon == "4")
            {
                Console.Beep();
                
                Console.ReadKey();
            }
            else if (chon == "5")
            {
                Console.Beep(); Console.Beep();
                return;
            }
        }
    }
}

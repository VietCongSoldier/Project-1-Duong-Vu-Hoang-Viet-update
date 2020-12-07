using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_Viet_9713.Presentation
{
    class HoaDonPresentation
    {
        public void MENUHoaDon()
        {
            Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
            Console.SetCursorPosition(25, 6);  Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(25, 7);  Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 8);  Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 9);  Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 10); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(25, 11); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 12); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 13); Console.WriteLine("█░              1. Lập hóa đơn nhập hàng hóa vào kho.                ░█");
            Console.SetCursorPosition(25, 14); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 15); Console.WriteLine("█░              2. Lập hóa đơn xuất kho.                             ░█");
            Console.SetCursorPosition(25, 16); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 17); Console.WriteLine("█░              3. Hiển thị toàn bộ hóa đơn.                         ░█");
            Console.SetCursorPosition(25, 18); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 19); Console.WriteLine("█░              4. Thoát.                                            ░█");
            Console.SetCursorPosition(25, 20); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 21); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 22); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 23); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(53, 8); Console.WriteLine("MENU Quản lý Hóa Đơn");
            string chon;
            Console.SetCursorPosition(48, 21); Console.Write("Chọn chức năng số:"); Console.Beep();
            chon = Console.ReadLine();
            HoaDonPresentation hdPre = new HoaDonPresentation();
            Console.Clear();
            if (chon == "1")
            {
                hdPre.MENUHoaDon();
            }
            else if (chon == "2")
            {
                Console.Beep();
                Console.ReadKey();
            }
            else if (chon == "3")
            {
                Console.Beep();
                //hdPre.HienThiHoaDon();
                Console.ReadKey();
            }
            else if (chon == "4")
            {
                Console.Beep(); Console.Beep();
                return;
            }
            Console.Clear();
            MENUHoaDon();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Presentation;


namespace Project_1_Viet_9713.Presentation
{
    public class GUI_Chinh
    {
        public void MENU()
        {
            Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
            Console.SetCursorPosition(25, 6); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(25, 7); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 8); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 9); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 10); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(25, 11); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 12); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 13); Console.WriteLine("█░              1. Quản lý danh sách sản phẩm trong kho.             ░█");
            Console.SetCursorPosition(25, 14); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 15); Console.WriteLine("█░              2. Quản lý hóa đơn nhập xuất kho.                    ░█");
            Console.SetCursorPosition(25, 16); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 17); Console.WriteLine("█░              3. Hiển thị toàn bộ sản phẩm trong kho.              ░█");
            Console.SetCursorPosition(25, 18); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 19); Console.WriteLine("█░              4. Thoát.                                            ░█");
            Console.SetCursorPosition(25, 20); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 21); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 22); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 23); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(56, 8); Console.WriteLine("MENU");
            string chon;
            Console.SetCursorPosition(48, 21); Console.Write("Chọn công cụ số:"); Console.Beep();
            chon = Console.ReadLine();
            HangHoaPresentation hhPre = new HangHoaPresentation();
            Console.Clear();
            if (chon == "1")
            {
                hhPre.MENUHangHoa();
            }
            else if (chon == "2")
            {
                Console.Beep();
                //HoaDonPresentation.MENUHoaDon();
                Console.ReadKey();
            }
            else if (chon == "3")
            {
                Console.Beep();
                hhPre.HienThiHangHoa();
                Console.ReadKey();
            }
            else if (chon == "4")
            {
                Console.Beep(); Console.Beep();
                return;
            }
            Console.Clear();
            MENU();
        }
    }
}

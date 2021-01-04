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
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(25, 6);  Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(25, 7);  Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 8);  Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 9);  Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 10); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(25, 11); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 12); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 13); Console.WriteLine("█░              1. Quản lý sản phẩm.                                 ░█");
                Console.SetCursorPosition(25, 14); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 15); Console.WriteLine("█░              2. Quản lý hóa đơn.                                  ░█");
                Console.SetCursorPosition(25, 16); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 17); Console.WriteLine("█░              3. Quản lý nhân viên.                                ░█");
                Console.SetCursorPosition(25, 18); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 19); Console.WriteLine("█░              4. Quản lý nhà cung cấp.                             ░█");
                Console.SetCursorPosition(25, 20); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 21); Console.WriteLine("█░              5. Hiển thị toàn bộ sản phẩm trong kho.              ░█");
                Console.SetCursorPosition(25, 22); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 23); Console.WriteLine("█░              6. Thoát.                                            ░█");
                Console.SetCursorPosition(25, 24); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 25); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 26); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 27); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(56, 8); Console.WriteLine("MENU");
                Console.ForegroundColor = ConsoleColor.Gray;
                string chon;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(48, 25); Console.Write("Chọn công cụ số:"); Console.Beep();
                Console.ForegroundColor = ConsoleColor.Gray;
                chon = Console.ReadLine();
                HangHoaPresentation hhPre = new HangHoaPresentation();
                NhanVienPresentation nvPre = new NhanVienPresentation();
                NhaCungCapPresentation nccPre = new NhaCungCapPresentation();
                Console.Clear();
                if (chon == "1")
                {
                    hhPre.MENUHangHoa();
                }
                else if (chon == "2")
                {
                    Console.Beep();
                    MENUHoaDon();
                }
                else if (chon == "3")
                {
                    nvPre.MENUNhanVien();
                }
                else if (chon == "4")
                {
                    nccPre.MENUNhaCungCap();
                }
                else if (chon == "5")
                {
                    Console.Beep();
                    hhPre.HienThiHangHoa();
                    Console.ReadKey();
                }
                else if (chon == "6")
                {
                    Console.Beep(); Console.Beep();
                    return;
                }
                Console.Clear();
                MENU();
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void MENUHoaDon()
        {
            try
            {
                Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                Console.SetCursorPosition(25, 6);  Console.WriteLine("██████████████████████████████      █████████████████████████████████████████");
                Console.SetCursorPosition(25, 7);  Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 8);  Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 9);  Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 10); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(25, 11); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 12); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 13); Console.WriteLine("█░                      1. Quản lý hóa đơn nhập.                     ░█");
                Console.SetCursorPosition(25, 14); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 15); Console.WriteLine("█░                      2. Quản lý hóa đơn xuất.                     ░█");
                Console.SetCursorPosition(25, 16); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 17); Console.WriteLine("█░                      3. Quay lại.                                 ░█");
                Console.SetCursorPosition(25, 18); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 19); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 20); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 21); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(50, 8); Console.WriteLine("MENU QUẢN LÝ HÓA ĐƠN");
                Console.ForegroundColor = ConsoleColor.Gray;
                string chon;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(48, 19); Console.Write("Chọn công cụ số:"); Console.Beep();
                Console.ForegroundColor = ConsoleColor.Gray;
                chon = Console.ReadLine();
                HangHoaPresentation hhPre = new HangHoaPresentation();
                NhanVienPresentation nvPre = new NhanVienPresentation();
                HoaDonNhapPresentation hdnPre = new HoaDonNhapPresentation();
                HoaDonXuatPresentation hdxPre = new HoaDonXuatPresentation();
                Console.Clear();
                if (chon == "1")
                {
                    hdnPre.MENUHoaDonNhap();
                }
                else if (chon == "2")
                {
                    Console.Beep();
                    hdxPre.MENUHoaDonXuat();
                    Console.ReadKey();
                }
                else if (chon == "3")
                {
                    Console.Beep(); Console.Beep();
                    return;
                }
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.BAL;

namespace Project_1_Viet_9713.Presentation
{
    class NhaCungCapPresentation
    {
        private INhaCungCapBLL nccDLL = new NhaCungCapDLL();
        public void MENUNhaCungCap()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(50, 1); Console.WriteLine("QUẢN LÝ NHÀ CUNG CẤP");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(25, 6); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(25, 7); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 8); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 9); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 10); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(25, 11); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 12); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 13); Console.WriteLine("█░              1. Hiển thị tất cả nhà cung cấp.                     ░█");
                Console.SetCursorPosition(25, 14); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 15); Console.WriteLine("█░              2. Thêm nhà cung cấp.                                ░█");
                Console.SetCursorPosition(25, 16); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 17); Console.WriteLine("█░              3. Sửa thông tin nhà cung cấp.                       ░█");
                Console.SetCursorPosition(25, 18); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 19); Console.WriteLine("█░              4. Xóa nhà cung cấp.                                 ░█");
                Console.SetCursorPosition(25, 20); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 21); Console.WriteLine("█░              5. Tìm kiếm thông tin nhà cung cấp.                  ░█");
                Console.SetCursorPosition(25, 22); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 23); Console.WriteLine("█░              6. Quay lại.                                         ░█");
                Console.SetCursorPosition(25, 24); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 25); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 26); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 27); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(50, 8); Console.WriteLine("MENU QUẢN LÝ NHÀ CUNG CẤP");
                Console.ForegroundColor = ConsoleColor.Gray;
                string chon;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(48, 25); Console.Write("Chọn chức năng số:"); Console.Beep();
                Console.ForegroundColor = ConsoleColor.Gray;
                chon = Console.ReadLine();
                Console.Clear();
                if (chon == "1")
                {
                    Console.Beep();
                    HienThiNhaCungCap();
                    Console.ReadKey();
                }
                else if (chon == "2")
                {
                    Console.Beep();
                    NhapNCC();
                    Console.ReadKey();
                }
                else if (chon == "3")
                {
                    Console.Beep();
                    SuaNCC();
                    Console.ReadKey();
                }
                else if (chon == "4")
                {
                    Console.Beep();
                    XoaNCC();
                }
                else if (chon == "5")
                {
                    Console.Beep();
                    TimKiemNCC();
                }
                else if (chon == "6")
                {
                    return;
                }
                Console.Clear();
                MENUNhaCungCap();
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void NhapNCC()
        {
            try
            {
                NhaCungCap ncc = new NhaCungCap();
                List<NhaCungCap> listncc = new List<NhaCungCap>();
                NhaCungCapPresentation nccPre = new NhaCungCapPresentation();
                string chon;
                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(44, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                    Console.SetCursorPosition(35, 6); Console.WriteLine("█████████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(35, 7); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 8); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 9); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 10); Console.WriteLine("█████████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(35, 11); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 12); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 13); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 14); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 15); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 16); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 17); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 18); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 19); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 20); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 21); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 22); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 23); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 24); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 25); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 26); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 27); Console.WriteLine("██                                                         ██");
                    Console.SetCursorPosition(35, 28); Console.WriteLine("█████████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(54, 8); Console.WriteLine("MENU NHẬP NHÀ CUNG CẤP");
                    List<NhaCungCap> listtest = nccDLL.LayDSNhaCungCap();
                    bool testmancc = false;
                    do
                    {
                        do
                        {
                            Console.SetCursorPosition(45, 12); Console.Beep();
                            Console.Write("Nhập Mã NCC:"); ncc.Mancc = Console.ReadLine();
                        } while (string.IsNullOrEmpty(ncc.Mancc));
                        for (int i = 0; i < listtest.Count; i++)
                        {
                            if (listtest[i].Mancc == ncc.Mancc)
                            {
                                testmancc = true;
                                Console.SetCursorPosition(50, 24);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Mã NCC đã tồn tại !");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            }
                        }
                    } while (testmancc == true);
                    do
                    {
                        Console.SetCursorPosition(45, 14); Console.Beep();
                        Console.Write("Nhập Tên NCC:"); ncc.Tenncc = Console.ReadLine();
                    } while (string.IsNullOrEmpty(ncc.Tenncc));
                    do
                    {
                        Console.SetCursorPosition(45, 20); Console.Beep();
                        Console.Write("Số điện thoại:"); ncc.Sdt = Console.ReadLine();
                    } while (string.IsNullOrEmpty(ncc.Sdt) && ncc.Sdt.Length < 10);
                    do
                    {
                        Console.SetCursorPosition(45, 22); Console.Beep();
                        Console.Write("Địa chỉ:"); ncc.Diachi = Console.ReadLine();
                    } while (string.IsNullOrEmpty(ncc.Diachi));
                    nccDLL.ThemNCC(ncc);
                    listncc.Add(new NhaCungCap(ncc));
                    Console.SetCursorPosition(45, 24); Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Đã thêm nhà cung cấp mới !");
                    Console.SetCursorPosition(45, 26); Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Bạn có muốn thêm ncc khác không (Y/N) ? :");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    do
                    {
                        chon = Console.ReadLine();
                    } while (chon == "");
                } while (chon == "y" || chon == "Y");
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void SuaNCC()
        {
            try
            {
                Console.Clear();
                Console.SetCursorPosition(44, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                Console.SetCursorPosition(35, 6); Console.WriteLine("██████████████████████████████████████████████████████");
                Console.SetCursorPosition(35, 7); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 8); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 9); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 10); Console.WriteLine("██████████████████████████████████████████████████████");
                Console.SetCursorPosition(35, 11); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 12); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 13); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 14); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 15); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 16); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 17); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 18); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 19); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 20); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 21); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 22); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 23); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 24); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 25); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 26); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 27); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 28); Console.WriteLine("██████████████████████████████████████████████████████");
                Console.SetCursorPosition(45, 8); Console.WriteLine("SỬA THÔNG TIN NHÀ CUNG CẤP");
                string Manccmoi, Tennccmoi, Sdtmoi, Diachimoi;
                List<NhaCungCap> list = nccDLL.LayDSNhaCungCap();
                string mancccu;
                do
                {
                    Console.SetCursorPosition(45, 12);
                    Console.Write("Nhập mã nhà cung cấp cần sửa :");
                    mancccu = Console.ReadLine();
                } while (string.IsNullOrEmpty(mancccu));
                int i;
                for (i = 0; i < list.Count; i++)
                {
                    if (list[i].Mancc == mancccu) break;
                }
                NhaCungCap ncc = new NhaCungCap(list[i]);
                if (i < list.Count)
                {
                    do
                    {
                        Console.SetCursorPosition(45, 14); Console.Beep();
                        Console.Write("Nhập Mã NCC mới:"); Manccmoi = Console.ReadLine();
                    } while (string.IsNullOrEmpty(Manccmoi));
                    do
                    {
                        Console.SetCursorPosition(45, 16); Console.Beep();
                        Console.Write("Nhập Tên NCC mới:"); Tennccmoi = Console.ReadLine();
                    } while (string.IsNullOrEmpty(Tennccmoi));
                    do
                    {
                        Console.SetCursorPosition(45, 22); Console.Beep();
                        Console.Write("Số điện thoại mới:"); Sdtmoi = Console.ReadLine();
                    } while (string.IsNullOrEmpty(Sdtmoi) && Sdtmoi.Length < 10);
                    do
                    {
                        Console.SetCursorPosition(45, 24); Console.Beep();
                        Console.Write("Địa chỉ mới:"); Diachimoi = Console.ReadLine();
                    } while (string.IsNullOrEmpty(Diachimoi));
                    Console.SetCursorPosition(45, 26); Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Đã sửa thông tin nhà cung cấp thành công !");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    ncc.Mancc = Manccmoi; ncc.Tenncc = Tennccmoi; ncc.Sdt = Sdtmoi; ncc.Diachi = Diachimoi;
                    nccDLL.SuaNCC(ncc, mancccu);
                }
                else
                {
                    Console.SetCursorPosition(45, 26);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Không tồn tại mã nhà cung cấp này !");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void XoaNCC()
        {
            try
            {
                string chon;
                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(44, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                    Console.SetCursorPosition(35, 6); Console.WriteLine("█████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(35, 7); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 8); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 9); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 10); Console.WriteLine("█████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(35, 11); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 12); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 13); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 14); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 15); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 16); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 17); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 18); Console.WriteLine("█████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(57, 8); Console.WriteLine("XÓA NHÀ CUNG CẤP");
                    Console.SetCursorPosition(48, 12); Console.Beep();
                    Console.Write("Nhập Mã NCC muốn xóa :"); string Mancc = Console.ReadLine();
                    Console.SetCursorPosition(48, 14); Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Đã Xóa !");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    nccDLL.XoaNCC(Mancc);
                    Console.SetCursorPosition(38, 16);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Bạn có muốn xóa thêm nhà cung cấp khác không ? (Y/N) :");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    do
                    {
                        chon = Console.ReadLine();
                    } while (chon == "");
                } while (chon == "Y" || chon == "y");
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void TimKiemNCC()
        {
            try
            {
                char chon;
                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(44, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                    Console.SetCursorPosition(35, 6); Console.WriteLine("█████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(35, 7); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 8); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 9); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 10); Console.WriteLine("█████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(35, 11); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 12); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 13); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 14); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 15); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 16); Console.WriteLine("█████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(50, 8); Console.WriteLine("TÌM KIẾM THÔNG TIN NHÀ CUNG CẤP");
                    Console.SetCursorPosition(40, 12); Console.Beep();
                    Console.Write("Nhập Mã nhà cung cấp bạn muốn tìm :"); string Mancc = Console.ReadLine();
                    nccDLL.TimKiemNCC(Mancc);
                    Console.ReadKey();
                    Console.Clear();
                    Console.SetCursorPosition(44, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                    Console.SetCursorPosition(35, 6); Console.WriteLine("██████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(35, 7); Console.WriteLine("██                                                      ██");
                    Console.SetCursorPosition(35, 8); Console.WriteLine("██                                                      ██");
                    Console.SetCursorPosition(35, 9); Console.WriteLine("██                                                      ██");
                    Console.SetCursorPosition(35, 10); Console.WriteLine("██████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(38, 8);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Bạn có có muốn tìm thêm ncc khác không ? (Y/N) :");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    chon = char.Parse(Console.ReadLine());
                } while (chon == 'y' || chon == 'Y');
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void HienThiNhaCungCap()
        {
            try
            {
                Console.SetCursorPosition(50, 1);
                Console.WriteLine("DANH SÁCH NHÀ CUNG CẤP");
                List<NhaCungCap> list = nccDLL.LayDSNhaCungCap();
                int i = 7;
                Console.Clear();
                Console.SetCursorPosition(1, 4); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(1, 5); Console.WriteLine("██ STT █    Mã NCC   █           Tên Nhà Cung Cấp          █ Số Điện Thoại █              Địa Chỉ               ██");
                Console.SetCursorPosition(1, 6); Console.WriteLine("██_____█_____________█_____________________________________█_______________█____________________________________██");
                Console.SetCursorPosition(1, 7); Console.WriteLine("██  1  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 8); Console.WriteLine("██  2  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 9); Console.WriteLine("██  3  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 10); Console.WriteLine("██  4  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 11); Console.WriteLine("██  5  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 12); Console.WriteLine("██  6  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 13); Console.WriteLine("██  7  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 14); Console.WriteLine("██  8  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 15); Console.WriteLine("██  9  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 16); Console.WriteLine("██ 10  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 17); Console.WriteLine("██ 11  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 18); Console.WriteLine("██ 12  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 19); Console.WriteLine("██ 13  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 20); Console.WriteLine("██ 14  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 21); Console.WriteLine("██ 15  █             █                                     █               █                                    ██");
                Console.SetCursorPosition(1, 22); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                foreach (var dulieu in list)
                {
                    Console.SetCursorPosition(10, 8);
                    Console.WriteLine($"{dulieu.Mancc}");
                    Console.SetCursorPosition(24, 8);
                    Console.WriteLine($"{dulieu.Tenncc}");
                    Console.SetCursorPosition(62, 8);
                    Console.WriteLine($"{dulieu.Sdt}");
                    Console.SetCursorPosition(80, 8);
                    Console.WriteLine($"{dulieu.Diachi}");
                    i++;
                }
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
    }
}

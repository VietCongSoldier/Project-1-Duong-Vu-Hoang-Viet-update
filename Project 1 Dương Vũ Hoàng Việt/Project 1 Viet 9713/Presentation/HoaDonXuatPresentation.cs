using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.BAL;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.Presentation;

namespace Project_1_Viet_9713.Presentation
{
    class HoaDonXuatPresentation
    {
        IHoaDonXuatBLL hdxDLL = new HoaDonXuatDLL();
        public void MENUHoaDonXuat()
        {
            try
            {
                Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                Console.SetCursorPosition(25, 6); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(25, 7); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 8); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 9); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 10); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(25, 11); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 12); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 13); Console.WriteLine("█░              1. Hiển thị toàn bộ danh sách hóa đơn.               ░█");
                Console.SetCursorPosition(25, 14); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 15); Console.WriteLine("█░              2. Lập hóa đơn xuất.                                 ░█");
                Console.SetCursorPosition(25, 16); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 17); Console.WriteLine("█░              3. Sửa hóa đơn.                                      ░█");
                Console.SetCursorPosition(25, 18); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 19); Console.WriteLine("█░              4. Xóa hóa đơn.                                      ░█");
                Console.SetCursorPosition(25, 20); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 21); Console.WriteLine("█░              5. Tìm kiếm hóa đơn.                                 ░█");
                Console.SetCursorPosition(25, 22); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 17); Console.WriteLine("█░              6. Thoát.                                            ░█");
                Console.SetCursorPosition(25, 18); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 19); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 20); Console.WriteLine("█░                                                                   ░█");
                Console.SetCursorPosition(25, 21); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(53, 8); Console.WriteLine("MENU Quản lý Hóa Đơn Xuất");
                string chon;
                Console.SetCursorPosition(48, 21); Console.Write("Chọn chức năng số:"); Console.Beep();
                chon = Console.ReadLine();
                Console.Clear();
                if (chon == "1")
                {
                    HienThiDSHoaDonXuat();
                }
                else if (chon == "2")
                {
                    Console.Beep();
                    NhapHD();
                    Console.ReadKey();
                }
                else if (chon == "3")
                {
                    Console.Beep();
                    SuaHD();
                    Console.ReadKey();
                }
                else if (chon == "4")
                {
                    Console.Beep();
                    XoaHD();
                    Console.ReadKey();
                }
                else if (chon == "5")
                {
                    Console.Beep();
                    TimKiemHD();
                    Console.ReadKey();
                }
                else if (chon == "6")
                {
                    Console.Beep(); Console.Beep();
                    return;
                }
                Console.Clear();
                MENUHoaDonXuat();
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void HienThiDSHoaDonXuat()
        {
            try
            {
                Console.SetCursorPosition(50, 1);
                Console.WriteLine("DANH SÁCH HÓA ĐƠN NHẬP TRONG KHO");
                List<HoaDonXuat> list = hdxDLL.LayDSHoaDon();
                int i = 7;
                Console.SetCursorPosition(1, 3);  Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(1, 4);  Console.WriteLine("██ STT █    Mã HD    █            Tên Nhân Viên              █       Mã NV       █ Số Điện Thoại █    Ngày Xuất     ██");
                Console.SetCursorPosition(1, 5);  Console.WriteLine("██_____█_____________█_______________________________________█___________________█_______________█__________________██");
                Console.SetCursorPosition(1, 6);  Console.WriteLine("██  1  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 7);  Console.WriteLine("██  2  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 8);  Console.WriteLine("██  3  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 9);  Console.WriteLine("██  4  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 10); Console.WriteLine("██  5  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 11); Console.WriteLine("██  6  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 12); Console.WriteLine("██  7  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 13); Console.WriteLine("██  8  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 14); Console.WriteLine("██  9  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 15); Console.WriteLine("██ 10  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 16); Console.WriteLine("██ 11  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 17); Console.WriteLine("██ 12  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 18); Console.WriteLine("██ 13  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 19); Console.WriteLine("██ 14  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 20); Console.WriteLine("██ 15  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 21); Console.WriteLine("██ 16  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 22); Console.WriteLine("██ 17  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 23); Console.WriteLine("██ 18  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 24); Console.WriteLine("██ 19  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 25); Console.WriteLine("██ 20  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 26); Console.WriteLine("██ 21  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 27); Console.WriteLine("██ 22  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 28); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                foreach (var dulieu in list)
                {
                    Console.SetCursorPosition(10, i);
                    Console.WriteLine($"{dulieu.Mahoadon}");
                    Console.SetCursorPosition(24, i);
                    Console.WriteLine($"{dulieu.Tennv}");
                    Console.SetCursorPosition(64, i);
                    Console.WriteLine($"{dulieu.Manv}");
                    Console.SetCursorPosition(84, i);
                    Console.WriteLine($"{dulieu.Sdt}");
                    Console.SetCursorPosition(102, i);
                    Console.WriteLine($"{dulieu.Ngayxuat}");
                    i++;
                }
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void NhapHD()
        {
            HoaDonXuat hdx = new HoaDonXuat();
            List<HoaDonXuat> listhdx = new List<HoaDonXuat>();
            string chon;
            do
            {
                List<HoaDonXuat> listtest = hdxDLL.LayDSHoaDon();
                bool testmahd = false;
                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(35, 12); Console.WriteLine("██████████████████████████████████████████████████████");
                    Console.SetCursorPosition(35, 13); Console.WriteLine("██                                                  ██");
                    Console.SetCursorPosition(35, 14); Console.WriteLine("██                                                  ██");
                    Console.SetCursorPosition(35, 15); Console.WriteLine("██                                                  ██");
                    Console.SetCursorPosition(35, 16); Console.WriteLine("██                                                  ██");
                    Console.SetCursorPosition(35, 17); Console.WriteLine("██                                                  ██");
                    Console.SetCursorPosition(35, 18); Console.WriteLine("██████████████████████████████████████████████████████");
                    do
                    {
                        Console.SetCursorPosition(45, 14); Console.Beep();
                        Console.Write("Nhập Mã HDN:"); hdx.Mahoadon = Console.ReadLine();
                    } while (string.IsNullOrEmpty(hdx.Mahoadon));
                    for (int i = 0; i < listtest.Count; i++)
                    {
                        if (hdx.Mahoadon == listtest[i].Mahoadon)
                        {
                            testmahd = true;
                            Console.SetCursorPosition(50, 16);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Mã HD đã tồn tại !");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                } while (testmahd == true);
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
                Console.SetCursorPosition(35, 24); Console.WriteLine("██████████████████████████████████████████████████████");
                Console.SetCursorPosition(54, 8); Console.WriteLine("MENU LẬP HÓA ĐƠN XUẤT");
                do
                {
                    Console.SetCursorPosition(45, 12); Console.Beep();
                    Console.Write("Nhập Mã HD:"); hdx.Mahoadon = Console.ReadLine();
                } while (string.IsNullOrEmpty(hdx.Mahoadon));
                do
                {
                    Console.SetCursorPosition(45, 14); Console.Beep();
                    Console.Write("Nhập Mã Nhân Viên:");
                    hdx.Manv = Console.ReadLine();

                } while (string.IsNullOrEmpty(hdx.Manv));
                do
                {
                    Console.SetCursorPosition(45, 16); Console.Beep();
                    Console.Write("Số điện thoại :"); hdx.Sdt = Console.ReadLine();
                } while (hdx.Sdt.Length <= 10);
                hdx.Ngayxuat = DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss");
                hdxDLL.LapHoaDon(hdx);
                listhdx.Add(new HoaDonXuat(hdx));
                Console.SetCursorPosition(45, 20); Console.Beep();
                Console.WriteLine("Đã thêm hóa đơn !");
                Console.SetCursorPosition(40, 22); Console.Beep();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Bạn có muốn thêm hđ khác không (Y/N) ? :");
                Console.ForegroundColor = ConsoleColor.Gray;
                do
                {
                    chon = Console.ReadLine();
                } while (chon == "");
            } while (chon == "y" || chon == "Y");
            hdx.Ngayxuat = "Ngày nhập :" + DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss");
        }
        public void SuaHD()
        {
            try
            {
                Console.SetCursorPosition(35, 6); Console.WriteLine("██████████████████████████████████████████████████████");
                Console.SetCursorPosition(35, 7); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 8); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 9); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 10); Console.WriteLine("██████████████████████████████████████████████████████");
                string Mahd, Manv, Tennv, Sdt;
                List<HoaDonXuat> list = hdxDLL.LayDSHoaDon();
                string mahdcu;
                do
                {
                    Console.SetCursorPosition(45, 8);
                    Console.Write("Nhập mã hóa đơn cần sửa :");
                    mahdcu = Console.ReadLine();
                } while (string.IsNullOrEmpty(mahdcu));
                int i;
                List<HoaDonXuat> listhh = hdxDLL.LayDSHoaDon();
                for (i = 0; i < list.Count; ++i)
                {
                    if (list[i].Mahoadon == mahdcu) break;
                }
                if (i < list.Count)
                {
                    Console.Clear();
                    Console.SetCursorPosition(4, 4); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(4, 5); Console.WriteLine("██      Mã HD      █             Tên Nhân Viên             █    Mã NV   █     SĐT     █       Ngày Xuất       ██");
                    Console.SetCursorPosition(4, 6); Console.WriteLine("██_________________█_______________________________________█____________█_____________█_______________________██");
                    Console.SetCursorPosition(4, 7); Console.WriteLine("██                 █                                       █            █             █                       ██");
                    Console.SetCursorPosition(4, 8); Console.WriteLine("██                 █                                       █            █             █                       ██");
                    Console.SetCursorPosition(4, 9); Console.WriteLine("██                 █                                       █            █             █                       ██");
                    Console.SetCursorPosition(4, 10); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(7, 8);
                    Console.WriteLine($"{listhh[i].Mahoadon}");
                    Console.SetCursorPosition(25, 8);
                    Console.WriteLine($"{listhh[i].Tennv}");
                    Console.SetCursorPosition(65, 8);
                    Console.WriteLine($"{listhh[i].Manv}");
                    Console.SetCursorPosition(78, 8);
                    Console.WriteLine($"{listhh[i].Sdt}");
                    Console.SetCursorPosition(100, 8);
                    Console.WriteLine($"{listhh[i].Ngayxuat}");
                }
                Console.SetCursorPosition(44, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                Console.SetCursorPosition(35, 12); Console.WriteLine("██████████████████████████████████████████████████████");
                Console.SetCursorPosition(35, 13); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 14); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 15); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 16); Console.WriteLine("██████████████████████████████████████████████████████");
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
                Console.SetCursorPosition(35, 28); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 29); Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 30); Console.WriteLine("██████████████████████████████████████████████████████");
                Console.SetCursorPosition(45, 14); Console.WriteLine("SỬA THÔNG TIN HÓA ĐƠN");
                i = 0;
                for (i = 0; i < list.Count; i++)
                {
                    if (list[i].Mahoadon == mahdcu) break;
                }
                HoaDonXuat hd = new HoaDonXuat(list[i]);
                if (i < list.Count)
                {
                    do
                    {
                        Console.SetCursorPosition(45, 18); Console.Beep();
                        Console.Write("Nhập Mã HD mới:"); Mahd = Console.ReadLine();
                    } while (string.IsNullOrEmpty(Mahd));
                    do
                    {
                        Console.SetCursorPosition(45, 20); Console.Beep();
                        Console.Write("Nhập Mã NV mới :"); Manv = Console.ReadLine();
                    } while (string.IsNullOrEmpty(Manv));
                    do
                    {
                        Console.SetCursorPosition(45, 22); Console.Beep();
                        Console.Write("Tên NV mới:"); Tennv = Console.ReadLine();
                    } while (string.IsNullOrEmpty(Tennv));
                    do
                    {
                        Console.SetCursorPosition(45, 24); Console.Beep();
                        Console.Write("SDT mới:"); Sdt = Console.ReadLine();
                    } while (string.IsNullOrEmpty(Sdt));
                    Console.SetCursorPosition(45, 26); Console.Beep();
                    Console.Write("Ngày nhập : " + hd.Ngayxuat);
                    Console.SetCursorPosition(45, 28); Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Đã sửa hóa đơn thành công !");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    hd.Mahoadon = Mahd; hd.Manv = Manv; hd.Tennv = Tennv;
                    hdxDLL.SuaHD(hd, mahdcu);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(45, 26);
                    Console.WriteLine("Không tồn tại mã hóa đơn này !");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void XoaHD()
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
                    Console.SetCursorPosition(56, 8); Console.WriteLine("XÓA HÓA ĐƠN");
                    Console.SetCursorPosition(48, 12); Console.Beep();
                    Console.Write("Nhập Mã HD muốn xóa :"); string Mahd = Console.ReadLine();
                    Console.SetCursorPosition(48, 14); Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Đã Xóa !");
                    hdxDLL.XoaHD(Mahd);
                    Console.SetCursorPosition(38, 16);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Bạn có muốn xóa thêm hóa đơn khác không ? (Y/N) :");

                    do
                    {
                        chon = Console.ReadLine();
                    } while (chon == "");
                    Console.ForegroundColor = ConsoleColor.Gray;
                } while (chon == "Y" || chon == "y");
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void TimKiemHD()
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
                    Console.SetCursorPosition(53, 8); Console.WriteLine("TÌM KIẾM HÓA ĐƠN");
                    Console.SetCursorPosition(40, 12); Console.Beep();
                    Console.Write("Nhập Mã Hóa Đơn bạn muốn tìm :"); string Mahd = Console.ReadLine();
                    hdxDLL.TimKiemHD(Mahd);
                    Console.ReadKey();
                    Console.Clear();
                    Console.SetCursorPosition(44, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                    Console.SetCursorPosition(35, 6); Console.WriteLine("█████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(35, 7); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 8); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 9); Console.WriteLine("██                                                     ██");
                    Console.SetCursorPosition(35, 10); Console.WriteLine("█████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(38, 8);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Bạn có có muốn tìm thêm hd khác không ? (Y/N) :");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    chon = char.Parse(Console.ReadLine());
                } while (chon == 'y' || chon == 'Y');
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void HienThiHoaDonXuat(HoaDonXuat hd, List<HangHoa> listhh)
        {
            try
            {
                string ngaynhap = "Ngày nhập :" + DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss");
                Console.Clear();
                Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                Console.SetCursorPosition(1, 6); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(1, 7); Console.WriteLine("██                                                                                                                  ██");
                Console.SetCursorPosition(1, 8); Console.WriteLine("██                                                                                                                  ██");
                Console.SetCursorPosition(1, 9); Console.WriteLine("██                                                                                                                  ██");
                Console.SetCursorPosition(1, 10); Console.WriteLine("██                                                                                                                  ██");
                Console.SetCursorPosition(1, 11); Console.WriteLine("██ Tên đơn vị : Công ty TNHH Phúc Lâm Viên                                                                          ██");
                Console.SetCursorPosition(1, 12); Console.WriteLine("██ Địa chỉ : Đường Nguyễn Văn Linh, TX Mỹ Hào, Hưng Yên                                                             ██");
                Console.SetCursorPosition(1, 13); Console.WriteLine("██ Mã số thuế : 0901055759                                                                                          ██");
                Console.SetCursorPosition(1, 14); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(1, 15); Console.WriteLine("██ STT █    Mã SP    █    Tên Sản Phẩm                       █   Đơn giá   █ Số lượng █ Đơn vị tính █   Thành Tiền  ██");
                Console.SetCursorPosition(1, 16); Console.WriteLine("██_____█_____________█_______________________________________█_____________█__________█_____________█_______________██");
                Console.SetCursorPosition(1, 17); Console.WriteLine("██  1  █             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(1, 18); Console.WriteLine("██  2  █             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(1, 19); Console.WriteLine("██  3  █             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(1, 20); Console.WriteLine("██  4  █             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(1, 21); Console.WriteLine("██  5  █             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(1, 22); Console.WriteLine("██  6  █             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(1, 23); Console.WriteLine("██  7  █             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(1, 24); Console.WriteLine("██  8  █             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(1, 25); Console.WriteLine("██  9  █             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(1, 26); Console.WriteLine("██ 10  █_____________█_______________________________________█_____________█__________█_____________█_______________██");
                Console.SetCursorPosition(1, 27); Console.WriteLine("██Tổng █             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(1, 28); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(50, 8); Console.WriteLine("HÓA ĐƠN XUẤT KHO");
                int i;
                for (i = 0; i < listhh.Count; i++)
                {
                    Console.SetCursorPosition(10, i + 17);
                    Console.WriteLine(listhh[i].Masp);
                    Console.SetCursorPosition(24, i + 17);
                    Console.WriteLine(listhh[i].Tensp);
                    Console.SetCursorPosition(64, i + 17);
                    Console.WriteLine(listhh[i].Dongia);
                    Console.SetCursorPosition(78, i + 17);
                    Console.WriteLine(listhh[i].Soluong);
                    Console.SetCursorPosition(89, i + 17);
                    Console.WriteLine(listhh[i].Donvitinh);
                    Console.SetCursorPosition(103, i + 17);
                    Console.WriteLine(listhh[i].Thanhtien);
                    Console.SetCursorPosition(78, 13); Console.WriteLine(listhh[i].Ngaynhap);
                }
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
    }
}

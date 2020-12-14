using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL.Interface;
using Project_1_Viet_9713.DAL;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.BAL;

namespace Project_1_Viet_9713.Presentation
{
    class NhanVienPresentation
    {
        private INhanVienBLL nvDLL = new NhanVienDLL();
        public void MENUNhanVien()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(50, 1); Console.WriteLine("QUẢN LÝ NHÂN VIÊN");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(25, 6);  Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(25, 7);  Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 8);  Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 9);  Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 10); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(25, 11); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 12); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 13); Console.WriteLine("█░              1. Hiển thị tất cả nhân viên.                        ░█");
            Console.SetCursorPosition(25, 14); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 15); Console.WriteLine("█░              2. Thêm nhân viên.                                   ░█");
            Console.SetCursorPosition(25, 16); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 17); Console.WriteLine("█░              3. Sửa thông tin nhân viên.                          ░█");
            Console.SetCursorPosition(25, 18); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 19); Console.WriteLine("█░              4. Xóa nhân viên.                                    ░█");
            Console.SetCursorPosition(25, 20); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 21); Console.WriteLine("█░              5. Tìm kiếm thông tin nhân viên.                     ░█");
            Console.SetCursorPosition(25, 22); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 23); Console.WriteLine("█░              6. Quay lại.                                         ░█");
            Console.SetCursorPosition(25, 24); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 25); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 26); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 27); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 8); Console.WriteLine("MENU QUẢN LÝ NHÂN VIÊN");
            Console.ForegroundColor = ConsoleColor.Gray;
            string chon;
            Console.SetCursorPosition(48, 25); Console.Write("Chọn chức năng số:"); Console.Beep();
            chon = Console.ReadLine();
            Console.Clear();
            if (chon == "1")
            {
                Console.Beep();
                HienThiNhanVien();
                Console.ReadKey();
            }
            else if (chon == "2")
            {
                Console.Beep();
                NhapNV();
                Console.ReadKey();
            }
            else if (chon == "3")
            {
                Console.Beep();
                SuaNV();
                Console.ReadKey();
            }
            else if (chon == "4")
            {
                Console.Beep();
                XoaNV();
            }
            else if (chon == "5")
            {
                Console.Beep();
                TimKiemNV();
            }
            else if (chon == "6")
            {
                return;
            }
            Console.Clear();
            MENUNhanVien();
        }
        public void NhapNV()
        {
            NhanVien nv = new NhanVien();
            List<NhanVien> listnv = new List<NhanVien>();
            NhanVienPresentation hdPre = new NhanVienPresentation();
            string chon;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(44, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                Console.SetCursorPosition(35, 6);  Console.WriteLine("██████████████████████████████████████████████████████");
                Console.SetCursorPosition(35, 7);  Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 8);  Console.WriteLine("██                                                  ██");
                Console.SetCursorPosition(35, 9);  Console.WriteLine("██                                                  ██");
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
                Console.SetCursorPosition(54, 8); Console.WriteLine("MENU Nhập nhân viên");
                List<NhanVien> listtest = nvDLL.LayDSNhanVien();
                bool testmanv = false;
                do
                {
                    do
                    {
                        Console.SetCursorPosition(45, 12); Console.Beep();
                        Console.Write("Nhập Mã NV:"); nv.Manv = Console.ReadLine();
                    } while (string.IsNullOrEmpty(nv.Manv));
                    for (int i = 0; i < listtest.Count; i++)
                    {
                        if (listtest[i].Manv == nv.Manv)
                        {
                            testmanv = true;
                            Console.SetCursorPosition(50, 24);
                            Console.WriteLine("Mã NV đã tồn tại !");
                            break;
                        }
                    }
                } while (testmanv == true);
                do
                {
                    Console.SetCursorPosition(45, 14); Console.Beep();
                    Console.Write("Nhập Tên NV:"); nv.Hoten = Console.ReadLine();
                } while (string.IsNullOrEmpty(nv.Hoten));
                bool test;
                do
                {
                    Console.SetCursorPosition(45, 16); Console.Beep();
                    Console.Write("Năm Sinh:");
                    nv.Namsinh = int.Parse(Console.ReadLine());
                } while ((2020-nv.Namsinh)>=18&&nv.Namsinh>0);
                do
                {
                    Console.SetCursorPosition(45, 18); Console.Beep();
                    Console.Write("Giới tính:"); nv.Gioitinh = Console.ReadLine();
                } while (string.IsNullOrEmpty(nv.Gioitinh));
                do
                {
                    Console.SetCursorPosition(45, 20); Console.Beep();
                    Console.Write("Số điện thoại:"); nv.Sdt = Console.ReadLine();
                } while (string.IsNullOrEmpty(nv.Sdt)&&nv.Sdt.Length<10);
                do
                {
                    Console.SetCursorPosition(45, 22); Console.Beep();
                    Console.Write("Chức vụ:"); nv.Chucvu = Console.ReadLine();
                } while (string.IsNullOrEmpty(nv.Chucvu));
                nvDLL.ThemNV(nv);
                listnv.Add(new NhanVien(nv));
                Console.SetCursorPosition(45, 24); Console.Beep();
                Console.WriteLine("Đã thêm nhân viên mới !");
                Console.SetCursorPosition(45, 26); Console.Beep();
                Console.Write("Bạn có muốn thêm nhân viên khác không (Y/N) ? :");
                do
                {
                    chon = Console.ReadLine();
                } while (chon == "");
            } while (chon == "y" || chon == "Y");
            
        }
        public void SuaNV()
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
            Console.SetCursorPosition(45, 8); Console.WriteLine("SỬA THÔNG TIN NHÂN VIÊN");
            string Manvmoi, Tennvmoi, Gioitinhmoi,Sdtmoi,Chucvumoi;
            int Namsinhmoi;
            List<NhanVien> list = nvDLL.LayDSNhanVien();
            string manvcu;
            do
            {
                Console.SetCursorPosition(45, 12);
                Console.Write("Nhập mã nhân viên cần sửa :");
                manvcu = Console.ReadLine();
            } while (string.IsNullOrEmpty(manvcu));
            int i = 0;
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Manv == manvcu) break;
            }
            NhanVien nv = new NhanVien(list[i]);
            if (i < list.Count)
            {
                do
                {
                    Console.SetCursorPosition(45, 14); Console.Beep();
                    Console.Write("Nhập Mã NV mới:"); Manvmoi = Console.ReadLine();
                } while (string.IsNullOrEmpty(Manvmoi));
                do
                {
                    Console.SetCursorPosition(45, 16); Console.Beep();
                    Console.Write("Nhập Tên NV mới:"); Tennvmoi = Console.ReadLine();
                } while (string.IsNullOrEmpty(Tennvmoi));
                do
                {
                    Console.SetCursorPosition(45, 18); Console.Beep();
                    Console.Write("Năm sinh mới:"); Namsinhmoi = int.Parse(Console.ReadLine());
                } while ((2020 - Namsinhmoi) >= 18 && Namsinhmoi >0);
                do
                {
                    Console.SetCursorPosition(45, 20); Console.Beep();
                    Console.Write("Giới tính mới:"); Gioitinhmoi = Console.ReadLine();
                } while (string.IsNullOrEmpty(Gioitinhmoi));
                do
                {
                    Console.SetCursorPosition(45, 22); Console.Beep();
                    Console.Write("Số điện thoại mới:"); Sdtmoi = Console.ReadLine();
                } while (string.IsNullOrEmpty(Sdtmoi) && Sdtmoi.Length < 10);
                do
                {
                    Console.SetCursorPosition(45, 24); Console.Beep();
                    Console.Write("Chức vụ mới:"); Chucvumoi = Console.ReadLine();
                } while (string.IsNullOrEmpty(Chucvumoi));
                Console.SetCursorPosition(45, 26); Console.Beep();
                Console.WriteLine($"Đã sửa thông tin nhân viên thành công !");
                nv.Manv = Manvmoi;nv.Hoten = Tennvmoi;nv.Namsinh = Namsinhmoi;nv.Gioitinh = Gioitinhmoi;nv.Sdt = Sdtmoi;nv.Chucvu = Chucvumoi;
                nvDLL.SuaNV(nv, manvcu);
            }
            else
            {
                Console.SetCursorPosition(45, 26);
                Console.WriteLine("Không tồn tại mã nhân viên này !");
            }
        }
        public void XoaNV()
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
                Console.SetCursorPosition(57, 8); Console.WriteLine("XÓA NHÂN VIÊN");
                Console.SetCursorPosition(48, 12); Console.Beep();
                Console.Write("Nhập Mã NV muốn xóa :"); string Manv = Console.ReadLine();
                Console.SetCursorPosition(48, 14); Console.Beep();
                Console.WriteLine("Đã Xóa !");
                nvDLL.XoaNV(Manv);
                Console.SetCursorPosition(38, 16);
                Console.Write("Bạn có muốn xóa thêm nhân viên khác không ? (Y/N) :");
                do
                {
                    chon = Console.ReadLine();
                } while (chon == "");
            } while (chon == "Y" || chon == "y");
        }
        public void TimKiemNV()
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
                Console.SetCursorPosition(50, 8); Console.WriteLine("TÌM KIẾM SẢN PHẨM TRONG KHO");
                Console.SetCursorPosition(40, 12); Console.Beep();
                Console.Write("Nhập Mã nhân viên bạn muốn tìm :"); string Manv = Console.ReadLine();
                nvDLL.TimKiemNV(Manv);
                Console.ReadKey();
                Console.Clear();
                Console.SetCursorPosition(44, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
                Console.SetCursorPosition(35, 6); Console.WriteLine("█████████████████████████████████████████████████████████");
                Console.SetCursorPosition(35, 7); Console.WriteLine("██                                                     ██");
                Console.SetCursorPosition(35, 8); Console.WriteLine("██                                                     ██");
                Console.SetCursorPosition(35, 9); Console.WriteLine("██                                                     ██");
                Console.SetCursorPosition(35, 10); Console.WriteLine("█████████████████████████████████████████████████████████");
                Console.SetCursorPosition(38, 8);
                Console.Write("Bạn có có muốn tìm thêm nv khác không ? (Y/N) :");
                chon = char.Parse(Console.ReadLine());
            } while (chon == 'y' || chon == 'Y');
        }
        public void HienThiNhanVien()
        {
            Console.SetCursorPosition(50, 1);
            Console.WriteLine("DANH SÁCH NHÂN VIÊN");
            List<NhanVien> list = nvDLL.LayDSNhanVien();
            int i = 7;
            Console.SetCursorPosition(1, 3);  Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(1, 4);  Console.WriteLine("██ STT █    Mã NV    █             Tên Nhân Viên            █  Năm Sinh   █ Giới Tính █ Số Điện Thoại █    Chức Vụ    ██");
            Console.SetCursorPosition(1, 5);  Console.WriteLine("██_____█_____________█______________________________________█_____________█___________█_______________█_______________██");
            Console.SetCursorPosition(1, 6);  Console.WriteLine("██  1  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 7);  Console.WriteLine("██  2  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 8);  Console.WriteLine("██  3  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 9);  Console.WriteLine("██  4  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 10); Console.WriteLine("██  5  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 11); Console.WriteLine("██  6  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 12); Console.WriteLine("██  7  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 13); Console.WriteLine("██  8  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 14); Console.WriteLine("██  9  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 15); Console.WriteLine("██ 10  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 16); Console.WriteLine("██ 11  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 17); Console.WriteLine("██ 12  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 18); Console.WriteLine("██ 13  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 19); Console.WriteLine("██ 14  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 20); Console.WriteLine("██ 15  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 21); Console.WriteLine("██ 16  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 22); Console.WriteLine("██ 17  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 23); Console.WriteLine("██ 18  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 24); Console.WriteLine("██ 19  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 25); Console.WriteLine("██ 20  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 26); Console.WriteLine("██ 21  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 27); Console.WriteLine("██ 22  █             █                                      █             █           █               █               ██");
            Console.SetCursorPosition(1, 28); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            foreach (var dulieu in list)
            {
                Console.SetCursorPosition(10, i);
                Console.WriteLine($"{dulieu.Manv}");
                Console.SetCursorPosition(24, i);
                Console.WriteLine($"{dulieu.Hoten}");
                Console.SetCursorPosition(65, i);
                Console.WriteLine($"{dulieu.Namsinh}");
                Console.SetCursorPosition(78, i);
                Console.WriteLine($"{dulieu.Gioitinh}");
                Console.SetCursorPosition(89, i);
                Console.WriteLine($"{dulieu.Sdt}");
                Console.SetCursorPosition(104, i);
                Console.WriteLine($"{dulieu.Chucvu}");
                i++;
            }
        }
    }
}

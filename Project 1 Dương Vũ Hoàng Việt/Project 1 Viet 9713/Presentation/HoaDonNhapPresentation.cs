using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.BAL;
using Project_1_Viet_9713.BAL.Interface;


namespace Project_1_Viet_9713.Presentation
{
    class HoaDonNhapPresentation
    {
        IHoaDonNhapBLL hdnBLL = new HoaDonNhapBLL();
        public void MENUHoaDonNhap()
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
                Console.SetCursorPosition(25, 15); Console.WriteLine("█░              2. Lập hóa đơn nhập hàng hóa vào kho.                ░█");
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
                Console.SetCursorPosition(53, 8); Console.WriteLine("MENU Quản lý Hóa Đơn Nhập");
                string chon;
                Console.SetCursorPosition(48, 19); Console.Write("Chọn chức năng số:"); Console.Beep();
                chon = Console.ReadLine();
                Console.Clear();
                if (chon == "1")
                {
                    HienThiDSHoaDon();
                }
                else if (chon == "2")
                {
                    Console.Beep();
                    Console.ReadKey();
                }
                else if (chon == "3")
                {
                    Console.Beep(); Console.Beep();
                    return;
                }
                Console.Clear();
                MENUHoaDonNhap();
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void HienThiDSHoaDon()
        {
            try
            {
                Console.SetCursorPosition(50, 1);
                Console.WriteLine("DANH SÁCH HÓA ĐƠN NHẬP TRONG KHO");
                List<HoaDonNhap> list = hdnBLL.LayDSHoaDon();
                int i = 7;
                Console.SetCursorPosition(1, 3); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(1, 4); Console.WriteLine("██ STT █    Mã HD    █            Tên Nhân Viên              █       Mã NV       █ Số Điện Thoại █    Ngày Nhập     ██");
                Console.SetCursorPosition(1, 5); Console.WriteLine("██_____█_____________█_______________________________________█___________________█_______________█__________________██");
                Console.SetCursorPosition(1, 6); Console.WriteLine("██  1  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 7); Console.WriteLine("██  2  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 8); Console.WriteLine("██  3  █             █                                       █                   █               █                  ██");
                Console.SetCursorPosition(1, 9); Console.WriteLine("██  4  █             █                                       █                   █               █                  ██");
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
                    Console.WriteLine($"{dulieu.Ngaynhap}");
                    i++;
                }
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
        public void HienThiHoaDonNhap(HoaDonNhap hd,List<HangHoa> listhh)
        {
            try
            {
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
                Console.SetCursorPosition(50, 8); Console.WriteLine("HÓA ĐƠN NHẬP KHO");
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
                    Console.SetCursorPosition(78, 13);
                    Console.WriteLine(listhh[i].Ngaynhap);
                }
            }
            catch { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(34, 15); Console.WriteLine("Oopps !!!   Something Wrong - Please restart now !"); }
        }
    }
}

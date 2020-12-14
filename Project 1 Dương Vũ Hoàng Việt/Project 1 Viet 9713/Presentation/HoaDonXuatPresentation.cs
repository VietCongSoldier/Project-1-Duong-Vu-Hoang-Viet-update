using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL;
using Project_1_Viet_9713.DAL.Interface;
using Project_1_Viet_9713.BAL;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.Presentation;

namespace Project_1_Viet_9713.Presentation
{
    class HoaDonXuatPresentation
    {
        public void MENUHoaDonXuat()
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
            Console.SetCursorPosition(25, 17); Console.WriteLine("█░              3. Lập hóa đơn xuất kho.                             ░█");
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
            Console.Clear();
            if (chon == "1")
            {
                HienThiDSHoaDonXuat();
            }
            else if (chon == "2")
            {
                Console.Beep();
                Console.ReadKey();
            }
            else if (chon == "3")
            {
                Console.Beep();

                Console.ReadKey();
            }
            else if (chon == "4")
            {
                Console.Beep(); Console.Beep();
                return;
            }
            Console.Clear();
            MENUHoaDonXuat();
        }
        public void HienThiDSHoaDonXuat()
        {

        }
        public void HienThiHoaDonXuat(HoaDonXuat hd, List<HangHoa> listhh)
        {
            string ngaynhap = "Ngày nhập :" + DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss");
            Console.Clear();
            Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
            Console.SetCursorPosition(1,  6); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(1,  7); Console.WriteLine("██                                                                                                                  ██");
            Console.SetCursorPosition(1,  8); Console.WriteLine("██                                                                                                                  ██");
            Console.SetCursorPosition(1,  9); Console.WriteLine("██                                                                                                                  ██");
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
    }
}

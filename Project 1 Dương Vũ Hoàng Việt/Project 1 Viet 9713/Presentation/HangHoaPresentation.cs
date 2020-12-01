using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.BAL;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.Presentation;

namespace Project_1_Viet_9713.Presentation
{
    public class HangHoaPresentation
    {
        private IHangHoaBLL hhDLL = new HangHoaBLL();
        public void MENUHangHoa()
        {
            Console.SetCursorPosition(47, 1); Console.WriteLine("QUẢN LÝ HÀNG HÓA TRONG KHO");
            Console.SetCursorPosition(25, 6); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(25, 7); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 8); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 9); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 10); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(25, 11); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 12); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 13); Console.WriteLine("█░              1. Hiển thị tất cả sản phẩm trong kho.               ░█");
            Console.SetCursorPosition(25, 14); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 15); Console.WriteLine("█░              2. Nhập sản phẩm vào kho.                            ░█");
            Console.SetCursorPosition(25, 16); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 17); Console.WriteLine("█░              3. Sửa sản phẩm trong kho.                           ░█");
            Console.SetCursorPosition(25, 18); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 19); Console.WriteLine("█░              4. Xóa sản phẩm trong kho.                           ░█");
            Console.SetCursorPosition(25, 20); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 21); Console.WriteLine("█░              5. Tìm kiếm sản phẩm trong kho                       ░█");
            Console.SetCursorPosition(25, 22); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 23); Console.WriteLine("█░              6. Quay lại.                                         ░█");
            Console.SetCursorPosition(25, 24); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 25); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 26); Console.WriteLine("█░                                                                   ░█");
            Console.SetCursorPosition(25, 27); Console.WriteLine("███████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(50, 8); Console.WriteLine("MENU QUẢN LÝ HÀNG HÓA");
            string chon;
            Console.SetCursorPosition(48, 25); Console.Write("Chọn công cụ số:"); Console.Beep();
            chon = Console.ReadLine();
            Console.Clear();
            if (chon == "1")
            {
                Console.Beep();
                HienThiHangHoa();
                Console.ReadKey();
            }
            else if (chon == "2")
            {
                Console.Beep();
                NhapSP();
                Console.ReadKey();
            }
            else if (chon == "3")
            {
                Console.Beep();
                //.HienThiHangHoa();
                Console.ReadKey();
            }
            else if (chon == "4")
            {
                Console.Beep(); Console.Beep();
                return;
            }
            else if (chon == "5")
            {
                Console.Beep(); Console.Beep();
                return;
            }
            else if (chon == "6")
            {
                return;
            }
        }
        public void NhapSP()
        {
            HangHoa hh = new HangHoa();
            Console.Clear();
            do
            {
                Console.SetCursorPosition(45, 8); Console.Beep();
                Console.Write("Nhập Mã SP:"); hh.Masp = Console.ReadLine();
            } while (hh.Masp == "");
            do
            {
                Console.SetCursorPosition(45, 9); Console.Beep();
                Console.Write("Nhập Tên SP:"); hh.Tensp = Console.ReadLine();
            } while (hh.Tensp == "");
            Console.SetCursorPosition(45, 10); Console.Beep();
            Console.Write("Đơn giá:"); hh.Dongia = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(45, 11); Console.Beep();
            Console.Write("Số lượng:"); hh.Soluong = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(45, 12); Console.Beep();
            Console.Write("Đơn vị tính:"); hh.Donvitinh = Console.ReadLine();
            Console.SetCursorPosition(45, 14); Console.Beep();
            hh.Thanhtien = hh.Soluong * hh.Dongia;
            Console.WriteLine($"Thành tiền:{hh.Thanhtien} (VNĐ)");
            Console.SetCursorPosition(45, 15); Console.Beep();
            Console.WriteLine("Đã thêm sản phẩm vào kho !");
            hhDLL.ThemSP(hh);
        }
        public void SuaSP()
        {

        }
        public void XoaSP()
        {

        }
        public void TimKiemSP()
        {

        }
        public void HienThiHangHoa()
        {
            Console.SetCursorPosition(40, 2);
            Console.WriteLine("DANH SÁCH HÀNG HÓA TRONG KHO");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Mã Sản Phẩm \t Tên Sản Phẩm \t\t Đơn Giá \t Số Lượng \t Đơn Vị Tính \t Thành Tiền");
            Console.SetCursorPosition(0, 7);
            List<HangHoa> list = hhDLL.LayDSSanPham();
            int i = 7;
            foreach (var dulieu in list)
            {
                Console.WriteLine($"{dulieu.Masp}");
                Console.SetCursorPosition(17, i);
                Console.WriteLine($"{dulieu.Tensp}");
                Console.SetCursorPosition(41, i);
                Console.WriteLine($"{dulieu.Dongia}");
                Console.SetCursorPosition(57, i);
                Console.WriteLine($"{dulieu.Soluong}");
                Console.SetCursorPosition(73, i);
                Console.WriteLine($"{dulieu.Donvitinh}");
                Console.SetCursorPosition(89, i);
                Console.WriteLine($"{dulieu.Thanhtien} (vnđ)");
                i++;
            }
        }

    }
}

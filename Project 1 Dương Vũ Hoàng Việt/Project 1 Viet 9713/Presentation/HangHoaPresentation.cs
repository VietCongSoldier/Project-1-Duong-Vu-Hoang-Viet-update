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
                SuaSP();
                Console.ReadKey();
            }
            else if (chon == "4")
            {
                Console.Beep();
                XoaSP();
                return;
            }
            else if (chon == "5")
            {
                Console.Beep();
                TimKiemSP();
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
            List<HangHoa> listhh = new List<HangHoa>();
            string chon;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(45, 8); Console.Beep();
                Console.Write("Nhập Mã SP:"); hh.Masp = Console.ReadLine();
                Console.SetCursorPosition(45, 9); Console.Beep();
                Console.Write("Nhập Tên SP:"); hh.Tensp = Console.ReadLine();
                Console.SetCursorPosition(45, 10); Console.Beep();
                Console.Write("Đơn giá:"); hh.Dongia = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(45, 11); Console.Beep();
                Console.Write("Số lượng:"); hh.Soluong = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(45, 12); Console.Beep();
                Console.Write("Đơn vị tính:"); hh.Donvitinh = Console.ReadLine();
                Console.SetCursorPosition(45, 14); Console.Beep();
                hh.Thanhtien = hh.Soluong * hh.Dongia;
                Console.WriteLine($"Thành tiền:{hh.Thanhtien} (VNĐ)");
                hhDLL.ThemSP(hh);
                listhh.Add(new HangHoa(hh));
                Console.SetCursorPosition(45, 15); Console.Beep();
                Console.WriteLine("Đã thêm sản phẩm vào kho !");
                Console.SetCursorPosition(45, 15); Console.Beep();
                Console.Write("Bạn có muốn nhập tiếp không (Y/N) ? :");
                do
                {
                    chon = Console.ReadLine();
                } while (chon == "");
            } while (chon == "y" || chon == "Y");
            string ngaynhap = ""+DateTime.Now.ToString("ddMMyyhhmmss");
            Console.Clear();
            Console.SetCursorPosition(40, 1); Console.WriteLine("CHƯƠNG TRÌNH QUẢN LÝ KHO NHÀ HÀNG");
            Console.SetCursorPosition(1, 6);  Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(1, 7);  Console.WriteLine("██                                                                                                                  ██");
            Console.SetCursorPosition(1, 8);  Console.WriteLine("██                                                                                                                  ██");
            Console.SetCursorPosition(1, 9);  Console.WriteLine("██                                                                                                                  ██");
            Console.SetCursorPosition(1, 10); Console.WriteLine("██                                                                                                                  ██");
            Console.SetCursorPosition(1, 11); Console.WriteLine("██ Tên đơn vị : Công ty TNHH Phúc Lâm Viên                                                                          ██");
            Console.SetCursorPosition(1, 12); Console.WriteLine("██ Địa chỉ : Đường Nguyễn Văn Linh, TX Mỹ Hào, Hưng Yên                                                             ██");
            Console.SetCursorPosition(1, 13); Console.WriteLine("██ Mã số thuế : 0901055759                                                    Ngày xuất :                           ██");
            Console.SetCursorPosition(1, 14); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(1, 15); Console.WriteLine("██ STT █    Mã SP    █    Tên Sản Phẩm                       █   Đơn giá   █ Số lượng █ Đơn vị tính █   Thành Tiền  ██");
            Console.SetCursorPosition(1, 16); Console.WriteLine("██  1  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 17); Console.WriteLine("██  2  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 18); Console.WriteLine("██  3  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 19); Console.WriteLine("██  4  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 20); Console.WriteLine("██  5  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 21); Console.WriteLine("██  6  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 22); Console.WriteLine("██  7  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 23); Console.WriteLine("██  8  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 24); Console.WriteLine("██  9  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 25); Console.WriteLine("██ 10  █_____________█_______________________________________█_____________█__________█_____________█_______________██");
            Console.SetCursorPosition(1, 26); Console.WriteLine("██Tổng █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 27); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(50, 8); Console.WriteLine("HÓA ĐƠN NHẬP KHO");
            Console.SetCursorPosition(89, 13); Console.WriteLine(ngaynhap);
            int i;
            for (i = 0; i < listhh.Count; i++)
            {
                Console.SetCursorPosition(10,i+16);
                Console.WriteLine(listhh[i].Masp);
                Console.SetCursorPosition(24, i + 16);
                Console.WriteLine(listhh[i].Tensp);
                Console.SetCursorPosition(64, i + 16);
                Console.WriteLine(listhh[i].Dongia);
                Console.SetCursorPosition(78, i + 16);
                Console.WriteLine(listhh[i].Soluong);
                Console.SetCursorPosition(89, i + 16);
                Console.WriteLine(listhh[i].Donvitinh);
                Console.SetCursorPosition(103, i + 16);
                Console.WriteLine(listhh[i].Thanhtien);
            }
        }
        public void SuaSP()
        {
            Console.Clear();
            string Maspmoi,Tenspmoi,Donvitinhmoi;
            int Dongiamoi, Soluongmoi,Thanhtienmoi;
            Console.SetCursorPosition(45, 1); Console.WriteLine("SỬA THÔNG TIN SẢN PHẨM TRONG KHO");
            List<HangHoa> list = hhDLL.LayDSSanPham();
            Console.SetCursorPosition(45, 6);
            Console.Write("Nhập mã sản phẩm cần sửa :");
            string masp; masp = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Masp == masp) break;
            }
            if (i < list.Count)
            {
                //HangHoa hh = new HangHoa(list[i]);
                Console.SetCursorPosition(45, 8); Console.Beep();
                Console.Write("Nhập Mã SP mới:"); Maspmoi = Console.ReadLine();
                Console.SetCursorPosition(45, 9); Console.Beep();
                Console.Write("Nhập Tên SP mới:"); Tenspmoi = Console.ReadLine();
                Console.SetCursorPosition(45, 10); Console.Beep();
                Console.Write("Đơn giá mới:"); Dongiamoi = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(45, 11); Console.Beep();
                Console.Write("Số lượng mới:"); Soluongmoi = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(45, 12); Console.Beep();
                Console.Write("Đơn vị tính mới:"); Donvitinhmoi = Console.ReadLine();
                Console.SetCursorPosition(45, 14); Console.Beep();
                Thanhtienmoi = Soluongmoi * Dongiamoi;
                Console.WriteLine($"Thành tiền:{Thanhtienmoi} (VNĐ)");
                Console.SetCursorPosition(45, 15); Console.Beep();
                Console.WriteLine($"Đã sửa sản phẩm thành công !");
                list[i].Masp = Maspmoi; list[i].Tensp = Tenspmoi; list[i].Dongia = Dongiamoi; list[i].Soluong = Soluongmoi; list[i].Donvitinh = Donvitinhmoi; list[i].Thanhtien = Thanhtienmoi;
                hhDLL.SuaSP(list[i]);
            }
            else
            {
                Console.SetCursorPosition(45, 15);
                Console.WriteLine("Không tồn tại mã sản phẩm này !");
            } 
        }
        public void XoaSP()
        {
            string chon;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(45, 1); Console.WriteLine("XÓA SẢN PHẨM TRONG KHO");
                Console.SetCursorPosition(45, 8); Console.Beep();
                Console.Write("Nhập Mã SP muốn xóa :"); string Masp = Console.ReadLine();
                Console.SetCursorPosition(45, 9); Console.Beep();
                Console.WriteLine("Đã Xóa !");
                hhDLL.XoaSP(Masp);
                Console.SetCursorPosition(45, 10);
                Console.Write("Bạn có muốn xóa thêm sản phẩm khác không ? (Y/N) :");
                do
                {
                    chon = Console.ReadLine();
                } while (chon=="");
            } while (chon == 'Y' || chon == 'y');
        }
        public void TimKiemSP()
        {
            Console.Clear();
            HangHoa hh = new HangHoa();
            Console.SetCursorPosition(45, 1); Console.WriteLine("TÌM KIẾM SẢN PHẨM TRONG KHO");
            Console.SetCursorPosition(45, 8); Console.Beep();
            Console.Write("Nhập Mã SP muốn tìm :"); hh.Masp = Console.ReadLine();
            //hhDLL.TimKiemSP();
            Console.SetCursorPosition(45, 9); Console.Beep();
            Console.ReadKey();
        }
        public void HienThiHangHoa()
        {
            Console.SetCursorPosition(40, 2);
            Console.WriteLine("DANH SÁCH HÀNG HÓA TRONG KHO");
            List<HangHoa> list = hhDLL.LayDSSanPham();
            int i = 7;
            Console.SetCursorPosition(1, 4);  Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(1, 5);  Console.WriteLine("██ STT █    Mã SP    █             Tên Sản Phẩm              █   Đơn giá   █ Số lượng █ Đơn vị tính █   Thành Tiền  ██");
            Console.SetCursorPosition(1, 6);  Console.WriteLine("██_____█_____________█_______________________________________█_____________█__________█_____________█_______________██");
            Console.SetCursorPosition(1, 7);  Console.WriteLine("██  1  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 8);  Console.WriteLine("██  2  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 9);  Console.WriteLine("██  3  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 10); Console.WriteLine("██  4  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 11); Console.WriteLine("██  5  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 12); Console.WriteLine("██  6  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 13); Console.WriteLine("██  7  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 14); Console.WriteLine("██  8  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 15); Console.WriteLine("██  9  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 16); Console.WriteLine("██ 10  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 17); Console.WriteLine("██ 11  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 18); Console.WriteLine("██ 12  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 19); Console.WriteLine("██ 13  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 20); Console.WriteLine("██ 14  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 21); Console.WriteLine("██ 15  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 22); Console.WriteLine("██ 16  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 23); Console.WriteLine("██ 17  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 24); Console.WriteLine("██ 18  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 25); Console.WriteLine("██ 19  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 26); Console.WriteLine("██ 20  █             █                                       █             █          █             █               ██");
            Console.SetCursorPosition(1, 27); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            foreach (var dulieu in list)
            {
                Console.SetCursorPosition(10, i);
                Console.WriteLine($"{dulieu.Masp}");
                Console.SetCursorPosition(24, i);
                Console.WriteLine($"{dulieu.Tensp}");
                Console.SetCursorPosition(64, i);
                Console.WriteLine($"{dulieu.Dongia}");
                Console.SetCursorPosition(78, i);
                Console.WriteLine($"{dulieu.Soluong}");
                Console.SetCursorPosition(89, i);
                Console.WriteLine($"{dulieu.Donvitinh}");
                Console.SetCursorPosition(103, i);
                Console.WriteLine($"{dulieu.Thanhtien} (vnđ)");
                i++;
            }
        }

    }
}

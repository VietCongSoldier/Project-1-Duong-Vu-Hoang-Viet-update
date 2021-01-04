using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.DAL;
using Project_1_Viet_9713.DAL.Interface;

namespace Project_1_Viet_9713.BAL
{
    public class HoaDonXuatDLL : IHoaDonXuatBLL
    {
        private IHoaDonXuatDAL hdxDAL = new HoaDonXuatDAL();
        public void LapHoaDon(HoaDonXuat hdx)
        {
            hdxDAL.LapHoaDonXuat(hdx);
        }
        public List<HoaDonXuat> LayDSHoaDon()
        {
            return hdxDAL.LayDSHoaDon();
        }
        public void SuaHD(HoaDonXuat hdx, string mahdcu)
        {
            int i;
            List<HoaDonXuat> list = LayDSHoaDon();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahoadon == mahdcu) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hdx);
                hdxDAL.Update(list);
            }
        }

        public void TimKiemHD(string Mahd)
        {
            int i;
            List<HoaDonXuat> list = LayDSHoaDon();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahoadon == Mahd) break;
            }
            if (i < list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(4, 4); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(4, 5); Console.WriteLine("██      Mã HD      █             Tên Nhân Viên             █    Mã NV   █     SĐT     █       Ngày Nhập       ██");
                Console.SetCursorPosition(4, 6); Console.WriteLine("██_________________█_______________________________________█____________█_____________█_______________________██");
                Console.SetCursorPosition(4, 7); Console.WriteLine("██                 █                                       █            █             █                       ██");
                Console.SetCursorPosition(4, 8); Console.WriteLine("██                 █                                       █            █             █                       ██");
                Console.SetCursorPosition(4, 9); Console.WriteLine("██                 █                                       █            █             █                       ██");
                Console.SetCursorPosition(4, 10); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(7, 8);
                Console.WriteLine($"{list[i].Mahoadon}");
                Console.SetCursorPosition(25, 8);
                Console.WriteLine($"{list[i].Tennv}");
                Console.SetCursorPosition(65, 8);
                Console.WriteLine($"{list[i].Manv}");
                Console.SetCursorPosition(78, 8);
                Console.WriteLine($"{list[i].Sdt}");
                Console.SetCursorPosition(100, 8);
                Console.WriteLine($"{list[i].Ngayxuat}");
                Console.SetCursorPosition(45, 12); Console.Write("Nhấn 'C' để hiển thị chi tiết hóa đơn :"); char key = char.Parse(Console.ReadLine());
                if (key == 'C' || key == 'c')
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
                    Console.SetCursorPosition(1, 15); Console.WriteLine("██ STT █     Mã SP    █    Tên Sản Phẩm                      █   Đơn giá   █ Số lượng █ Đơn vị tính █   Thành Tiền  ██");
                    Console.SetCursorPosition(1, 16); Console.WriteLine("██_____█______________█______________________________________█_____________█__________█_____________█_______________██");
                    Console.SetCursorPosition(1, 17); Console.WriteLine("██  1  █              █                                      █             █          █             █               ██");
                    Console.SetCursorPosition(1, 18); Console.WriteLine("██  2  █              █                                      █             █          █             █               ██");
                    Console.SetCursorPosition(1, 19); Console.WriteLine("██  3  █              █                                      █             █          █             █               ██");
                    Console.SetCursorPosition(1, 20); Console.WriteLine("██  4  █              █                                      █             █          █             █               ██");
                    Console.SetCursorPosition(1, 21); Console.WriteLine("██  5  █              █                                      █             █          █             █               ██");
                    Console.SetCursorPosition(1, 22); Console.WriteLine("██  6  █              █                                      █             █          █             █               ██");
                    Console.SetCursorPosition(1, 23); Console.WriteLine("██  7  █              █                                      █             █          █             █               ██");
                    Console.SetCursorPosition(1, 24); Console.WriteLine("██  8  █              █                                      █             █          █             █               ██");
                    Console.SetCursorPosition(1, 25); Console.WriteLine("██  9  █              █                                      █             █          █             █               ██");
                    Console.SetCursorPosition(1, 26); Console.WriteLine("██ 10  █______________█______________________________________█_____________█__________█_____________█_______________██");
                    Console.SetCursorPosition(1, 27); Console.WriteLine("██Tổng █                                                                                                            ██");
                    Console.SetCursorPosition(1, 28); Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                    Console.SetCursorPosition(50, 8); Console.WriteLine("HÓA ĐƠN XUẤT KHO");
                    Console.SetCursorPosition(70, 9); Console.WriteLine("Mã HD:" + list[i].Mahoadon);
                    Console.SetCursorPosition(70, 10); Console.WriteLine("Ngày:" + list[i].Ngayxuat);
                    Console.SetCursorPosition(70, 11); Console.WriteLine("NV:" + list[i].Tennv);
                    Console.SetCursorPosition(70, 12); Console.WriteLine("SDT:" + list[i].Sdt);
                    Console.SetCursorPosition(70, 13); Console.WriteLine("Mã NV:" + list[i].Manv);
                }
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.Write("Mã Hóa đơn này không tồn tại !");
            }
        }

        public void XoaHD(string mahd)
        {
            int i;
            List<HoaDonXuat> list = LayDSHoaDon();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahoadon == mahd) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hdxDAL.Update(list);
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.WriteLine($"Mã hóa đơn này không tồn tại !");
            }
        }
    }
}

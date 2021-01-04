using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.DAL.Interface;
using Project_1_Viet_9713.DAL;

namespace Project_1_Viet_9713.BAL
{
    class NhanVienDLL : INhanVienBLL
    {
        INhanVienDAL nvDAL = new NhanVienDAL();
        public List<NhanVien> LayDSNhanVien()
        {
            return nvDAL.LayDSNhanVien();
        }
        public void SuaNV(NhanVien nv, string manvcu)
        {
            int i;
            List<NhanVien> list = LayDSNhanVien();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Manv == manvcu) break;
            }
            if (i < list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(4, 4); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(4, 5); Console.WriteLine("██    Mã NV    █             Tên Nhân Viên           █  Năm Sinh  █ Giới Tính █ Số Điện Thoại █    Chức Vụ    ██");
                Console.SetCursorPosition(4, 6); Console.WriteLine("██_____________█_____________________________________█____________█___________█_______________█_______________██");
                Console.SetCursorPosition(4, 7); Console.WriteLine("██             █                                     █            █           █               █               ██");
                Console.SetCursorPosition(4, 8); Console.WriteLine("██             █                                     █            █           █               █               ██");
                Console.SetCursorPosition(4, 9); Console.WriteLine("██             █                                     █            █           █               █               ██");
                Console.SetCursorPosition(4,10); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(7, 8);
                Console.WriteLine($"{list[i].Manv}");
                Console.SetCursorPosition(21, 8);
                Console.WriteLine($"{list[i].Hoten}");
                Console.SetCursorPosition(61, 8);
                Console.WriteLine($"{list[i].Namsinh}");
                Console.SetCursorPosition(73, 8);
                Console.WriteLine($"{list[i].Gioitinh}");
                Console.SetCursorPosition(85, 8);
                Console.WriteLine($"{list[i].Sdt}");
                Console.SetCursorPosition(100, 8);
                Console.WriteLine($"{list[i].Chucvu}");
                list.RemoveAt(i);
                list.Add(nv);
                nvDAL.Update(list);
            }
        }
        public void ThemNV(NhanVien nv)
        {
            nvDAL.ThemNhanVien(nv);
        }
        public void TimKiemNV(string Masp)
        {
            int i;
            List<NhanVien> list = LayDSNhanVien();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Manv == Masp) break;
            }
            if (i < list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(4, 4); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(4, 5); Console.WriteLine("██    Mã NV    █             Tên Nhân Viên           █  Năm Sinh  █ Giới Tính █ Số Điện Thoại █    Chức Vụ    ██");
                Console.SetCursorPosition(4, 6); Console.WriteLine("██_____________█_____________________________________█____________█___________█_______________█_______________██");
                Console.SetCursorPosition(4, 7); Console.WriteLine("██             █                                     █            █           █               █               ██");
                Console.SetCursorPosition(4, 8); Console.WriteLine("██             █                                     █            █           █               █               ██");
                Console.SetCursorPosition(4, 9); Console.WriteLine("██             █                                     █            █           █               █               ██");
                Console.SetCursorPosition(4,10); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(7, 8);
                Console.WriteLine($"{list[i].Manv}");
                Console.SetCursorPosition(21, 8);
                Console.WriteLine($"{list[i].Hoten}");
                Console.SetCursorPosition(61, 8);
                Console.WriteLine($"{list[i].Namsinh}");
                Console.SetCursorPosition(73, 8);
                Console.WriteLine($"{list[i].Gioitinh}");
                Console.SetCursorPosition(85, 8);
                Console.WriteLine($"{list[i].Sdt}");
                Console.SetCursorPosition(100, 8);
                Console.WriteLine($"{list[i].Chucvu}");
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.Write("Mã Sản Phẩm này không tồn tại !");
            }
        }
        public void XoaNV(string manv)
        {
            int i;
            List<NhanVien> list = LayDSNhanVien();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Manv == manv) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                nvDAL.Update(list);
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.WriteLine($"Mã nhân viên này không tồn tại !");
            }
        }
    }
}

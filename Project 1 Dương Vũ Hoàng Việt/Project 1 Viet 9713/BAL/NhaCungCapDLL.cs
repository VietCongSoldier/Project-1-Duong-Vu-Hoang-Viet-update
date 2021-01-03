using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.DAL;
using Project_1_Viet_9713.DAL.Interface;

namespace Project_1_Viet_9713.BAL
{
    class NhaCungCapDLL : INhaCungCapBLL
    {
        INhaCungCapDAL nccDAL = new NhaCungCapDAL();
        public List<NhaCungCap> LayDSNhaCungCap()
        {
            return nccDAL.LayDSNhaCungCap();
        }

        public void SuaNCC(NhaCungCap ncc, string mancccu)
        {
            int i;
            List<NhaCungCap> list = LayDSNhaCungCap();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mancc == mancccu) break;
            }
            if (i < list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(4, 4); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(4, 5); Console.WriteLine("██    Mã NCC   █           Tên Nhà Cung Cấp          █ Số Điện Thoại █                 Địa Chỉ                ██");
                Console.SetCursorPosition(4, 6); Console.WriteLine("██_____________█_____________________________________█_______________█________________________________________██");
                Console.SetCursorPosition(4, 7); Console.WriteLine("██             █                                     █               █                                        ██");
                Console.SetCursorPosition(4, 8); Console.WriteLine("██             █                                     █               █                                        ██");
                Console.SetCursorPosition(4, 9); Console.WriteLine("██             █                                     █               █                                        ██");
                Console.SetCursorPosition(4, 10); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(7, 8);
                Console.WriteLine($"{list[i].Mancc}");
                Console.SetCursorPosition(21, 8);
                Console.WriteLine($"{list[i].Tenncc}");
                Console.SetCursorPosition(59, 8);
                Console.WriteLine($"{list[i].Sdt}");
                Console.SetCursorPosition(77, 8);
                Console.WriteLine($"{list[i].Diachi}");
                list.RemoveAt(i);
                list.Add(ncc);
                nccDAL.Update(list);
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.Write("Mã Nhà Cung Cấp này không tồn tại !");
            }
        }
        public void ThemNCC(NhaCungCap ncc)
        {
            nccDAL.ThemNhaCungCap(ncc);
        }
        public void TimKiemNCC(string Mancc)
        {
            int i;
            List<NhaCungCap> list = LayDSNhaCungCap();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mancc == Mancc) break;
            }
            if (i < list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(4, 4); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(4, 5); Console.WriteLine("██    Mã NCC   █           Tên Nhà Cung Cấp          █ Số Điện Thoại █                 Địa Chỉ                ██");
                Console.SetCursorPosition(4, 6); Console.WriteLine("██_____________█_____________________________________█_______________█________________________________________██");
                Console.SetCursorPosition(4, 7); Console.WriteLine("██             █                                     █               █                                        ██");
                Console.SetCursorPosition(4, 8); Console.WriteLine("██             █                                     █               █                                        ██");
                Console.SetCursorPosition(4, 9); Console.WriteLine("██             █                                     █               █                                        ██");
                Console.SetCursorPosition(4,10); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(7, 8);
                Console.WriteLine($"{list[i].Mancc}");
                Console.SetCursorPosition(21, 8);
                Console.WriteLine($"{list[i].Tenncc}");
                Console.SetCursorPosition(59, 8);
                Console.WriteLine($"{list[i].Sdt}");
                Console.SetCursorPosition(77, 8);
                Console.WriteLine($"{list[i].Diachi}");
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.Write("Mã Nhà Cung Cấp này không tồn tại !");
            }
        }

        public void XoaNCC(string mancc)
        {
            int i;
            List<NhaCungCap> list = LayDSNhaCungCap();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mancc == mancc) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                nccDAL.Update(list);
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.WriteLine($"Mã nhà cung cấp này không tồn tại !");
            }
        }
    }
}

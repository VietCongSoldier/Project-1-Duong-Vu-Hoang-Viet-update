using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.DAL;
using Project_1_Viet_9713.DAL.Interface;

namespace Project_1_Viet_9713.BAL
{
    public class HangHoaDLL:IHangHoaBLL
    {
        private IHangHoaDAL hhDAL = new HangHoaDAL();
        public List<HangHoa> LayDSSanPham()
        {
            return hhDAL.LayDSSanPham();
        }
        public void ThemSP(HangHoa hh)
        {
            hhDAL.ThemSP(hh);
        }
        public void XoaSP(string masp)
        {
            int i;
            List<HangHoa> list = LayDSSanPham();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Masp == masp) break;
            }
            if (i<list.Count)
            {
                list.RemoveAt(i);
                hhDAL.Update(list);
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.WriteLine($"Mã sản phẩm này không tồn tại !");
            }
        }
        public void SuaSP(HangHoa hh,string maspcu)
        {
            int i;
            List<HangHoa> list = LayDSSanPham();
            for (i=0;i<list.Count;++i)
            {
                if (list[i].Masp == maspcu) break;
            }
            if (i < list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(4, 4); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(4, 5); Console.WriteLine("██    Mã SP    █             Tên Sản Phẩm              █   Đơn giá   █ Số lượng █ Đơn vị tính █   Thành Tiền  ██");
                Console.SetCursorPosition(4, 6); Console.WriteLine("██_____________█_______________________________________█_____________█__________█_____________█_______________██");
                Console.SetCursorPosition(4, 7); Console.WriteLine("██             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(4, 8); Console.WriteLine("██             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(4, 9); Console.WriteLine("██             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(4, 10); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(7, 8);
                Console.WriteLine($"{list[i].Masp}");
                Console.SetCursorPosition(21, 8);
                Console.WriteLine($"{list[i].Tensp}");
                Console.SetCursorPosition(61, 8);
                Console.WriteLine($"{list[i].Dongia}");
                Console.SetCursorPosition(75, 8);
                Console.WriteLine($"{list[i].Soluong}");
                Console.SetCursorPosition(86, 8);
                Console.WriteLine($"{list[i].Donvitinh}");
                Console.SetCursorPosition(100, 8);
                Console.WriteLine($"{list[i].Thanhtien} (vnđ)");
                list.RemoveAt(i);
                list.Add(hh);
                hhDAL.Update(list);
            }
        }
        public void TimKiemSP(string Masp)
        {
            int i;
            List<HangHoa> list = LayDSSanPham();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Masp == Masp) break;
            }
            if (i<list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(4, 4); Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(4, 5); Console.WriteLine("██    Mã SP    █             Tên Sản Phẩm              █   Đơn giá   █ Số lượng █ Đơn vị tính █   Thành Tiền  ██");
                Console.SetCursorPosition(4, 6); Console.WriteLine("██_____________█_______________________________________█_____________█__________█_____________█_______________██");
                Console.SetCursorPosition(4, 7); Console.WriteLine("██             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(4, 8); Console.WriteLine("██             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(4, 9); Console.WriteLine("██             █                                       █             █          █             █               ██");
                Console.SetCursorPosition(4, 10);Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(7, 8);
                Console.WriteLine($"{list[i].Masp}");
                Console.SetCursorPosition(21, 8);
                Console.WriteLine($"{list[i].Tensp}");
                Console.SetCursorPosition(61, 8);
                Console.WriteLine($"{list[i].Dongia}");
                Console.SetCursorPosition(75, 8);
                Console.WriteLine($"{list[i].Soluong}");
                Console.SetCursorPosition(86, 8);
                Console.WriteLine($"{list[i].Donvitinh}");
                Console.SetCursorPosition(100, 8);
                Console.WriteLine($"{list[i].Thanhtien} (vnđ)");
            }
            else
            {
                Console.SetCursorPosition(45, 14);
                Console.Write("Mã Sản Phẩm này không tồn tại !");
            }
            //List<HangHoa> dskq = new List<HangHoa>();
            //if (string.IsNullOrEmpty(hh.Masp) && string.IsNullOrEmpty(hh.Tensp) && hh.Dongia == 0)
            //{
            //    dskq = list;
            //}
            //if (!string.IsNullOrEmpty(hh.Tensp))
            //{
            //    for (int i = 0; i < list.Count; ++i)
            //    {
            //        dskq.Add(new HangHoa(list[i]));
            //    }
            //}
            //else if (hh.Dongia > 0)
            //{
            //    for (int i = 0; i < list.Count; ++i)
            //    {
            //        if (list[i].Dongia == hh.Dongia)
            //        {
            //            dskq.Add(new HangHoa(list[i]));
            //        }
            //    }
            //}
            //else dskq = null;
        }
    }
}

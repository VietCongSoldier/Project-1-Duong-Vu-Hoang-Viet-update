using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Entities;
using Project_1_Viet_9713.BAL.Interface;
using Project_1_Viet_9713.DAL;
using Project_1_Viet_9713.DAL.Interface;

namespace Project_1_Viet_9713.BAL
{
    public class HangHoaBLL:IHangHoaBLL
    {
        private IHangHoaDAL hhBL = new HangHoaDAL();
        public List<HangHoa> LayDSSanPham()
        {
            return hhBL.LayDSSanPham();
        }
        public void ThemSP(HangHoa hh)
        {
            hhBL.ThemSP(hh);
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
                hhBL.Update(list);
            }
            else
            {
                throw new Exception($"Không tồn tại mã : {masp} !");
            }
        }
        public void SuaSP(HangHoa hh)
        {
            int i;
            List<HangHoa> list = LayDSSanPham();
            for (i=0;i<list.Count;++i)
            {
                if (list[i].Masp == hh.Masp) break;
            }
            if (i > list.Count)
            {
                list.RemoveAt(i);
                list.Add(hh);
                hhBL.Update(list);
            }
            else
            {
                throw new Exception($"Không tồn tại mã sản phẩm này !");
            }
        }
        public List<HangHoa> TimKiemSP(HangHoa hh)
        {
            List<HangHoa> list = LayDSSanPham();
            List<HangHoa> dskq = new List<HangHoa>();
            if (string.IsNullOrEmpty(hh.Masp) && string.IsNullOrEmpty(hh.Tensp) && hh.Dongia == 0)
            {
                dskq = list;
            }
            if (!string.IsNullOrEmpty(hh.Tensp))
            {
                for (int i = 0; i < list.Count; ++i)
                {
                    dskq.Add(new HangHoa(list[i]));
                }
            }
            else if (hh.Dongia > 0)
            {
                for (int i = 0; i < list.Count; ++i)
                {
                    if (list[i].Dongia == hh.Dongia)
                    {
                        dskq.Add(new HangHoa(list[i]));
                    }
                }
            }
            else dskq = null;
            return dskq;
        }
    }
}

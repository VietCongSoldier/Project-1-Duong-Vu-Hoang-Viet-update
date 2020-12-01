using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Viet_9713.Entities
{
    public class HangHoa
    {
        private string masp;
        private string tensp;
        private int dongia;
        private int soluong;
        private string donvitinh;
        private int thanhtien;
        public HangHoa()
        {
            thanhtien = dongia * soluong;
        }
        public HangHoa(string masp,string tensp,int dongia,int soluong,string donvitinh,int thanhtien)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.dongia = dongia;
            this.soluong = soluong;
            this.donvitinh = donvitinh;
            this.thanhtien = thanhtien;
        }
        public HangHoa(HangHoa sp)
        {
            this.masp = sp.masp;
            this.tensp = sp.tensp;
            this.dongia = sp.dongia;
            this.soluong = sp.soluong;
            this.donvitinh = sp.donvitinh;
            this.thanhtien = sp.thanhtien;
        }
        public string Masp
        {
            get { return masp; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    masp = value;
            }
        }
        public string Tensp
        {
            get { return tensp; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tensp = value;
            }
        }
        public int Dongia
        {
            get { return dongia; }
            set
            {
                if (value > 0)
                    dongia = value;
            }
        }
        public int Soluong
        {
            get { return soluong; }
            set
            {
                if (value > 0)
                    soluong = value;
            }
        }
        public string Donvitinh
        {
            get { return donvitinh; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    donvitinh = value;
            }
        }
        public int Thanhtien
        {
            get { return thanhtien; }
            set
            {
                thanhtien = value;
            }
        }
    }
}

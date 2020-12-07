using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_Viet_9713.Entities
{
    public class HoaDon
    {
        private string mahoadon;
        private string tennvxuatkho;
        private string ngaynhap;
        private string masp;
        private int soluong;
        public HoaDon()
        {
        }
        public HoaDon(string mahoadon, string tennv,string ngayxuat,string masp,int soluong)
        {
            this.mahoadon = mahoadon;
            this.tennvxuatkho = tennvxuatkho;
            this.ngaynhap = ngaynhap;
            this.masp = masp;
            this.soluong = soluong;
        }
        public HoaDon(HoaDon hd)
        {
            this.mahoadon = hd.mahoadon;
            this.tennvxuatkho = hd.tennvxuatkho;
            this.ngaynhap = hd.ngaynhap;
            this.masp = hd.masp;
            this.soluong = soluong;

        }
        public string Mahoadon
        {
            get { return mahoadon; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    mahoadon = value;
            }
        }
        public string Tennvxuatkho
        {
            get { return tennvxuatkho; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tennvxuatkho = value;
            }
        }
        public string Ngaynhap
        {
            get { return ngaynhap; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    ngaynhap = value;
            }
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
        public int Soluong
        {
            get { return soluong; }
            set { if (soluong > 0)
                    soluong = value;
            }

        }
    }
}

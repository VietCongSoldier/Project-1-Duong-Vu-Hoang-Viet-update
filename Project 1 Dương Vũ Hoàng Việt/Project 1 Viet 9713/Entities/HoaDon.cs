using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_Viet_9713.Entities
{
    public class HoaDon
    {
        private string mahoadon;
        private string tennvxuatkho;
        private string ngayxuat;
        public HoaDon()
        {
        }
        public HoaDon(string mahoadon, string tennv,string ngayxuat)
        {
            this.mahoadon = mahoadon;
            this.tennvxuatkho = tennvxuatkho;
            this.ngayxuat = ngayxuat;
        }
        public HoaDon(HoaDon hd)
        {
            this.mahoadon = hd.mahoadon;
            this.tennvxuatkho = hd.tennvxuatkho;
            this.ngayxuat = hd.ngayxuat;

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
        public string Ngayxuat
        {
            get { return ngayxuat; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    ngayxuat = value;
            }
        }
    }
}

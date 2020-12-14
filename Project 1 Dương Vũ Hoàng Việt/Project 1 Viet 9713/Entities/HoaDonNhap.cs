using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_Viet_9713.Entities
{
    public class HoaDonNhap
    {
        private string mahoadon;
        private string manv;
        private string tennv;
        private string sdt;
        private string ngaynhap;

        public HoaDonNhap()
        {        
        }
        public HoaDonNhap(string mahoadon, string manv, string tennv,string sdt,string ngaynhap)
        {
            this.mahoadon = mahoadon;
            this.manv = manv;
            this.tennv = tennv;
            this.sdt = sdt;
            this.ngaynhap = ngaynhap;
        }
        public HoaDonNhap(HoaDonNhap hd)
        {
            this.mahoadon = hd.mahoadon;
            this.manv = hd.manv;
            this.tennv = hd.tennv;
            this.sdt = hd.sdt;
            this.ngaynhap = hd.ngaynhap;
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
        public string Manv
        {
            get { return manv; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    manv = value;
            }
        }
        public string Tennv
        {
            get { return tennv; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tennv = value;
            }
        }
        public string Sdt
        {
            get { return sdt; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    sdt = value;
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
    }
}

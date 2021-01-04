using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_Viet_9713.Entities
{
    public class HoaDonXuat
    {
        private string mahoadon;
        private string manv;
        private string tennv;
        private string sdt;
        private string ngayxuat;

        public HoaDonXuat()
        {
        }
        public HoaDonXuat(string mahoadon, string manv, string tennv, string sdt, string ngayxuat)
        {
            this.mahoadon = mahoadon;
            this.manv = manv;
            this.tennv = tennv;
            this.sdt = sdt;
            this.ngayxuat = ngayxuat;
        }
        public HoaDonXuat(HoaDonXuat hd)
        {
            this.mahoadon = hd.mahoadon;
            this.manv = hd.manv;
            this.tennv = hd.tennv;
            this.sdt = hd.sdt;
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

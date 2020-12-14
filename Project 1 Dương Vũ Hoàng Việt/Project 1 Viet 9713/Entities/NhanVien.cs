using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_Viet_9713.Entities
{
    class NhanVien
    {
        private string manv;
        private int namsinh;
        private string hoten;
        private string gioitinh;
        private string sdt;
        private string chucvu;
        private NhanVien nv;

        public NhanVien()
        {

        }

        public NhanVien(NhanVien nv)
        {
            this.nv = nv;
        }

        public NhanVien(string manv, string hoten, int namsinh, string gioitinh, string sdt, string chucvu)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.chucvu = chucvu;
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
        public string Hoten
        {
            get { return hoten; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    hoten = value;
            }

        }
        public int Namsinh
        {
            get { return namsinh; }
            set
            {
                if (value>0)
                    namsinh = value;
            }

        }
        public string Chucvu
        {
            get { return chucvu; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    chucvu = value;
            }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    gioitinh = value;
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
    }
}

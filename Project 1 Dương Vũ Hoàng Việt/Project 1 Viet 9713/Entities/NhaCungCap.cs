using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_Viet_9713.Entities
{
    class NhaCungCap
    {
        private string mancc; 
        private string tenncc;
        private string sdt;
        private string diachi;
        private NhaCungCap ncc;

        public NhaCungCap()
        {

        }

        public NhaCungCap(NhaCungCap ncc)
        {
            this.ncc = ncc;
        }

        public NhaCungCap(string mancc, string tenncc, string sdt, string diachi)
        {
            this.mancc = mancc;
            this.tenncc = tenncc;
            this.sdt = sdt;
            this.diachi = diachi;
        }
        public string Mancc
        {
            get { return mancc; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    mancc = value;
            }
        }
        public string Tenncc
        {
            get { return tenncc; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tenncc = value;
            }

        }
        public string Diachi
        {
            get { return diachi; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    diachi = value;
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

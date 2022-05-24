using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Demo
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTenLot { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string Ten { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public List<string> MHDK { get; set; }

        public SinhVien()
        {
            MHDK = new List<string>();
        }

        public SinhVien(string mSSV, string hoTenLot, DateTime ngaySinh, string cMND, string diaChi, bool gioiTinh, string ten, string lop, string sDT, List<string> mHDK)
        {
            MSSV = mSSV;
            HoTenLot = hoTenLot;
            NgaySinh = ngaySinh;
            CMND = cMND;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            Ten = ten;
            Lop = lop;
            SDT = sDT;
            MHDK = mHDK;
        }

        public override string ToString()
        {
            string[] s = SDT.Split('.');
            string sdt = "";
            foreach (var item in s)
            {
                sdt += item;
            }
            int gt = 0;
            if (GioiTinh)
            {
                gt = 1;
            }
            string mhdk = "";
            foreach (var item in MHDK)
            {
                mhdk += item + ", ";
            }
            mhdk = mhdk.Substring(0, mhdk.Length - 1);
            string str = MSSV + "*" + HoTenLot + "*" + Ten + "*" + gt + "*" + NgaySinh + "*" + Lop + "*" + CMND + "*" + sdt + "*" + DiaChi + "*" + mhdk;

            return str;
        }
    }
}

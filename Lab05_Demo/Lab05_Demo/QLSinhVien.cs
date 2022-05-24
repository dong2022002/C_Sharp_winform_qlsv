using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Demo
{
    public delegate int SoSanh(object obj1, object obj2);
    public class QLSinhVien
    {
        List<SinhVien> _danhSachSV;

        public List<SinhVien> DanhSachSV { get => _danhSachSV; set => _danhSachSV = value; }

       
        
        public QLSinhVien()
        {
           _danhSachSV= new List<SinhVien>();
        }
        public SinhVien this[int index]
        {
            get { return _danhSachSV[index]; }
            set { _danhSachSV[index] = value; }
        }
        public void Them(SinhVien sv)
        {
            _danhSachSV.Add(sv);
        }
        public void Xoa(object obj, SoSanh ss)
        {
            for (int i = 0; i < _danhSachSV.Count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    _danhSachSV.RemoveAt(i);
                }
            }
        }

        public bool Sua(SinhVien svSua, object obj, SoSanh ss)
        {
            bool result = false;
            for (int i = 0; i < _danhSachSV.Count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svSua;
                    result = true;
                    break;
                }
            }
            return result;
        }

        public SinhVien Tim(Object obj, SoSanh ss)
        {
            SinhVien sinhVien = null;
            foreach (SinhVien sv in _danhSachSV)
            {
                if (ss(obj, sv) == 0)
                {
                    sinhVien = sv;
                    break;
                }
            }
            return sinhVien;
        }
        

        public void DocTuFile()
        {
            string fileName = "DSSV.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                sv = new SinhVien();
                s = t.Split('*');
                sv.MSSV = s[0];
                sv.HoTenLot = s[1];
                sv.Ten = s[2];
                if (s[3]=="1")
                {
                    sv.GioiTinh = true;
                }
                else
                {
                    sv.GioiTinh = false;
                }
                sv.NgaySinh = DateTime.Parse(s[4]);               
                sv.Lop = s[5];
                sv.CMND = s[6];
                sv.SDT= s[7];
                sv.DiaChi = s[8];
                string[] mh = s[9].Split(',');
                foreach (var item in mh)
                {
                    sv.MHDK.Add(item);
                }
                Them(sv);
            }
            sr.Close();
        }
        public void GhiSV()
        {
            string str = "";
            using(StreamWriter sr =new StreamWriter(@"DSSV.txt", append: false))
            {
                foreach (SinhVien item in _danhSachSV)
                {
                    str = item.ToString();
                    sr.WriteLine(str);
                }
                sr.Close();
            }

        }



    }
}

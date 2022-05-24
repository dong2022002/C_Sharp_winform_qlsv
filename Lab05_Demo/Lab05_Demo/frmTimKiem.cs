using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Demo
{
    public partial class frmTimKiem : Form
    {
        QLSinhVien danhSachSV = new QLSinhVien();
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            danhSachSV = frmSinhVien.danhSach;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tim = txtTim.Text;
            QLSinhVien ds = new QLSinhVien();
            SinhVien sv;
            if (string.IsNullOrEmpty(txtTim.Text))
            {
                MessageBox.Show("Vui long nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rdMSSV.Checked)
                {
                    sv = new SinhVien();
                    sv = danhSachSV.Tim(tim, SoSanhTheoMa);
                    if (sv != null)
                    {
                        //ds.Them(sv);
                        this.lvDSSV.Items.Clear();
                        ThemSVLV(sv);
                    }
                    else
                    {
                        lvDSSV.Items.Clear();
                        ThongBaoLoi();
                    }
                }
                if (rdTen.Checked)
                {
                    foreach (var item in danhSachSV.DanhSachSV)
                    {
                        if (item.Ten.CompareTo(tim) == 0)
                        {
                            ds.Them(item);
                        }
                    }
                    InDanhSach(ds);
                }
                if (rdLop.Checked)
                    {
                        foreach (var item in danhSachSV.DanhSachSV)
                        {
                            if (item.Lop.CompareTo(tim) == 0)
                            {
                                ds.Them(item);
                            }
                        }
                        InDanhSach(ds);
                    }
                
            }



        }

        private void InDanhSach(QLSinhVien ds)
            {
                if (ds.DanhSachSV.Count > 0)
                {
                    LoadListView(ds);
                }
                else
                {
                    lvDSSV.Items.Clear();
                    ThongBaoLoi();
                } 
         }

        private void ThongBaoLoi()
        {
            MessageBox.Show("Không tìm thấy sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int SoSanhTheoMa(object obj1, object obj2)
        {

            SinhVien sv2 = obj2 as SinhVien;
            return sv2.MSSV.CompareTo(obj1);
        }
        private int SoSanhTheoTen(object obj1, object obj2)
        {

            SinhVien sv2 = obj2 as SinhVien;
            return sv2.Ten.CompareTo(obj1);
        }
        private int SoSanhTheoLop(object obj1, object obj2)
        {

            SinhVien sv2 = obj2 as SinhVien;
            return sv2.Lop.CompareTo(obj1);
        }
        private void LoadListView(QLSinhVien ds)
        {
            this.lvDSSV.Items.Clear();
            foreach (SinhVien sv in ds.DanhSachSV)
            {
                ThemSVLV(sv);
            }
        }
        private void ThemSVLV(SinhVien sv)
        {
            ListViewItem lvItem = new ListViewItem(sv.MSSV);
            lvItem.SubItems.Add(sv.HoTenLot);
            lvItem.SubItems.Add(sv.Ten);
            string gt = "Nữ";
            if (sv.GioiTinh)
            {
                gt = "Nam";
            }
            lvItem.SubItems.Add(gt);
            lvItem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvItem.SubItems.Add(sv.Lop);
            lvItem.SubItems.Add(sv.CMND);
            lvItem.SubItems.Add(sv.SDT);
            lvItem.SubItems.Add(sv.DiaChi);
            string mh = "";
            foreach (var item in sv.MHDK)
            {
                mh += item.ToString() + ",";
            }
            mh = mh.Substring(0, mh.Length - 1);
            lvItem.SubItems.Add(mh);
            this.lvDSSV.Items.Add(lvItem);
        }
    }
}

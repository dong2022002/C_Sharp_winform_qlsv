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
    public partial class frmSinhVien : Form
    {
        public static QLSinhVien danhSach;
        public static List<string> listMonHoc;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var frmTimKiem =new frmTimKiem();
            frmTimKiem.ShowDialog();
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            danhSach = new QLSinhVien();

            danhSach.DocTuFile();
            LoadListView();
        }

        private void LoadListView()
        {
            this.lvDSSV.Items.Clear();
            foreach (SinhVien sv in danhSach.DanhSachSV)
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            bool kt = ktNull();
            if (kt)
            {
                SinhVien sv = GetSinhVien();
                SinhVien kq = danhSach.Tim(sv.MSSV, SoSanhTheoMa);
                if (kq != null)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    danhSach.Them(sv);
                    danhSach.GhiSV();
                    LoadListView();
                }
            }
            else
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv2 = obj2 as SinhVien;
            return sv2.MSSV.CompareTo(obj1);
        }
        public bool ktNull()
        {
            bool mh = true;
            int count = clbMHDK.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (clbMHDK.GetItemChecked(i))
                {
                    mh = false;
                    break;
                }
            }
            bool b = true;
            if (string.IsNullOrEmpty(mtxtMSSV.Text) ||
                string.IsNullOrEmpty(txtHoTenLot.Text) ||
                string.IsNullOrEmpty(dtpNgaySinh.Text) ||
                string.IsNullOrEmpty(mtxtCMND.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtTen.Text) ||
                string.IsNullOrEmpty(cboLop.Text) ||
                string.IsNullOrEmpty(mtxtSDT.Text) || mh)
            {
                b = false;
            }
            return b;
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = this.mtxtMSSV.Text;
            sv.HoTenLot = this.txtHoTenLot.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.CMND = this.mtxtCMND.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            bool gt = false;
            if (rdNam.Checked)
            {
                gt = true;
            }
            sv.GioiTinh = gt;
            sv.Ten = this.txtTen.Text;
            sv.Lop = this.cboLop.Text;
            sv.SDT = this.mtxtSDT.Text;
            List<string> mh = new List<string>();
            for (int i = 0; i < this.clbMHDK.Items.Count; i++)
            {
                if (this.clbMHDK.GetItemChecked(i))
                {
                    mh.Add(clbMHDK.Items[i].ToString());
                }
            }
            sv.MHDK = mh;

            return sv;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool kt = ktNull();
            if (kt)
            {
                SinhVien sv = GetSinhVien();
                bool kq = danhSach.Sua(sv, sv.MSSV, SoSanhTheoMa);
                if (!kq)
                {
                    MessageBox.Show("Chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    danhSach.GhiSV();
                    LoadListView();
                }
            }
            else
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDSSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lv = this.lvDSSV.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lv);
                ThietLapThongTin(sv);
            }
        }

        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoTenLot.Text = sv.HoTenLot;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.mtxtCMND.Text = sv.CMND;
            this.txtDiaChi.Text = sv.DiaChi;
            if (sv.GioiTinh)
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            this.txtTen.Text = sv.Ten;
            this.cboLop.Text = sv.Lop;
            this.mtxtSDT.Text = sv.SDT;
            int count = this.clbMHDK.Items.Count;
            for (int i = 0; i < count; i++)
            {
                this.clbMHDK.SetItemChecked(i, false);
            }
            foreach (var item in sv.MHDK)
            {
                for (int i = 0; i < count; i++)
                {
                    if (item.CompareTo(this.clbMHDK.Items[i]) == 0)
                    {
                        this.clbMHDK.SetItemChecked(i, true);
                    }

                }
            }

        }

        private SinhVien GetSinhVienLV(ListViewItem lv)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lv.SubItems[0].Text;
            sv.HoTenLot = lv.SubItems[1].Text;
            bool gt = false;
            sv.Ten = lv.SubItems[2].Text;
            if (lv.SubItems[3].Text == "Nam")
            {
                gt = true;
            }
            sv.GioiTinh = gt;
            sv.NgaySinh = DateTime.Parse(lv.SubItems[4].Text);
            sv.Lop = lv.SubItems[5].Text;
            sv.CMND = lv.SubItems[6].Text;
            sv.SDT = lv.SubItems[7].Text;
            sv.DiaChi = lv.SubItems[8].Text;
            string[] s = lv.SubItems[9].Text.Split(',');
            List<string> mh = new List<string>();
            foreach (var item in s)
            {
                mh.Add(item);
            }
            sv.MHDK = mh;
            return sv;


        }

        private void thêmMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var themMH = new frmThemMonHoc();
            themMH.ShowDialog();
            if (themMH.monHocMoi != "")
            {
                string mh = themMH.monHocMoi;
                clbMHDK.Items.Add(mh);
            }

        }

        private void xóaMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listMonHoc = new List<string>();
            for (int i = 0; i < this.clbMHDK.Items.Count; i++)
            {
                listMonHoc.Add(clbMHDK.Items[i].ToString());
            }

            var xoaMonHoc = new frmXoaMonHoc();
            xoaMonHoc.ShowDialog();
            listMonHoc = xoaMonHoc.listMonHoc;
            clbMHDK.Items.Clear();
            for (int i = 0; i < listMonHoc.Count; i++)
            {
                clbMHDK.Items.Add(listMonHoc[i].ToString());
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = lvDSSV.Items.Count-1;
            for (int i = count; i >=0; i--)
            {
                ListViewItem lv = lvDSSV.Items[i];
                if (lv.Checked)
                {
                    danhSach.Xoa(lv.SubItems[0].Text, SoSanhTheoMa);
                    count--;
                }
            }
            danhSach.GhiSV();
            LoadListView();
            
        }

        private void clbMHDK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

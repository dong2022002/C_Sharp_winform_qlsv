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
    public partial class frmXoaMonHoc : Form
    {
        public List<string> listMonHoc;
        public frmXoaMonHoc()
        {
            InitializeComponent();
        }

        private void frmXoaMonHoc_Load(object sender, EventArgs e)
        {

            List<string> listMH = new List<string>();
            listMH = frmSinhVien.listMonHoc;
            foreach (string item in listMH)
            {
                cbXoa.Items.Add(item);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            listMonHoc=new List<string>();
            string xoa = cbXoa.Text;
            cbXoa.Items.Remove(xoa);
            foreach (var item in cbXoa.Items)
            {
                listMonHoc.Add(item.ToString());
            }

            
            Close();
        }
    }
}

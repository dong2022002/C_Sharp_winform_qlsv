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
    public partial class frmThemMonHoc : Form
    {
        public frmThemMonHoc()
        {
            InitializeComponent();           
        }
        public string monHocMoi="";

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtThemMH.Text))
            {
                MessageBox.Show("Vui lòng nhập môn học mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            monHocMoi = txtThemMH.Text;
            Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

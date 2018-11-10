using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCF
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmQLQCFcs frmQLCF = new frmQLQCFcs();
            this.Hide();
            frmQLCF.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

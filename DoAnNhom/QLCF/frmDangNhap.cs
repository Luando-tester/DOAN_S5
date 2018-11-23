using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLCF.Class;
using QLCF.DTB;

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

        //Xử lý đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //username Admin
            //password 1
            string username = txtTendangnhap.Text;
            string password = txtMatkhau.Text;
            if (Logins(username,password))
            {
                frmQLQCFcs frmQLCF = new frmQLQCFcs();
                this.Hide();
                frmQLCF.ShowDialog();
                this.Show();
                txtMatkhau.Text = "";
            }else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu\nVui lòng kiểm tra lại!");
        }

        bool Logins(string username,string password)
        {
            return Login.Instance.Logins(username,password);
        }

        //Chức năng thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

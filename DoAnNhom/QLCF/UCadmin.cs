using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLCF.DTB;

namespace QLCF
{
    public partial class UCadmin : UserControl
    {
        BindingSource listAccount = new BindingSource();
        public UCadmin()
        {
            InitializeComponent();
            dtgvAccount.DataSource = listAccount;
            loadListAccount();
            loadText();
        }
        
        private static UCadmin _instance;

        public static UCadmin Instance
        {
            get { if (_instance == null) _instance = new UCadmin(); return UCadmin._instance; }
            set { UCadmin._instance = value; }
        }
        void loadListAccount()
        {
            listAccount.DataSource = Account.Instance.listAccount();
        }
        void loadText()
        {
            txtUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Displayname", true, DataSourceUpdateMode.Never));
            txtPassWord.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Password", true, DataSourceUpdateMode.Never));
            numTypeAccount.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "type", true, DataSourceUpdateMode.Never));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadListAccount();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string displayname = txtDisplayName.Text;
                string password = txtPassWord.Text;
                int type = (int)numTypeAccount.Value;
                if (Account.Instance.themAccount(username, displayname, password, type))
                {
                    MessageBox.Show("Thêm tài khoản " + username + " thành công");
                    loadListAccount();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string displayname = txtDisplayName.Text;
                string password = txtPassWord.Text;
                int type = (int)numTypeAccount.Value;
                if (Account.Instance.capnhatAccount(username, displayname, password, type))
                {
                    MessageBox.Show("Cập nhật tài khoản " + username + " thành công");
                    loadListAccount();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi cập nhật");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                DialogResult dialog = MessageBox.Show("Bạn thực sự muốn xóa không ?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    if (Account.Instance.xoaAccount(username))
                    {
                        MessageBox.Show("Xóa tài khoản " + username + " thành công");
                        loadListAccount();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xóa");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string timkiem = txtTimKiem.Text;
                listAccount.DataSource = Account.Instance.timkiem(timkiem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tìm kiếm");
            }
        }
    }
}

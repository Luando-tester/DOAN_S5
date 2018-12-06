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
    public partial class UCbancs : UserControl
    {
        private static UCbancs _instance;
        public static UCbancs Instace
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new UCbancs();
                }
                return _instance;
            }
        }
        BindingSource listTable = new BindingSource();
        public UCbancs()
        {
            InitializeComponent();
            dtgvBan.DataSource = listTable;
            loadListTable();
            loadtxtTable();
        }
        void loadListTable()
        {
            listTable.DataSource = TableDrink.Instance.loadTableDrink();
        }

        void loadtxtTable()
        {
            txtIDban.DataBindings.Add(new Binding("Text", dtgvBan.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtBan.DataBindings.Add(new Binding("Text", dtgvBan.DataSource, "name", true, DataSourceUpdateMode.Never));
            txtStatus.DataBindings.Add(new Binding("Text", dtgvBan.DataSource, "status", true, DataSourceUpdateMode.Never));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadListTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtBan.Text;
                string status = txtStatus.Text;
                if (name != "")
                {
                    if (TableDrink.Instance.themBan(name, status))
                    {
                        MessageBox.Show("Thêm " + name + " thành công");
                        loadListTable();
                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập tên bàn");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)Convert.ToInt32(txtIDban.Text);
                string name = txtBan.Text;
                string status = txtStatus.Text;
                if (TableDrink.Instance.suaBan(id, name, status))
                {
                    MessageBox.Show("Sửa " + name + " thành công");
                    loadListTable();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)Convert.ToInt32(txtIDban.Text);
                string name = txtBan.Text;
                if (TableDrink.Instance.xoaBan(id))
                {
                    MessageBox.Show("Xóa " + name + " thành công");
                    loadListTable();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}

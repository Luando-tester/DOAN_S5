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
    public partial class UCdanhmuc : UserControl
    {
        private static UCdanhmuc _instance;
        public static UCdanhmuc Instace
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new UCdanhmuc();
                }
                return _instance;
            }
        }
        BindingSource typeList = new BindingSource();
        public UCdanhmuc()
        {
            InitializeComponent();
            dtgvDanhmuc.DataSource = typeList;
            loadListType();
            loadTxtType();
        }
        void loadListType()
        {
            typeList.DataSource = TypeDrink.Instance.ListTypeDrink();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadListType();
        }

        void loadTxtType()
        {
            txtTendanhmuc.DataBindings.Add(new Binding("Text", dtgvDanhmuc.DataSource, "name", true, DataSourceUpdateMode.Never));
            txtIDdanhmuc.DataBindings.Add(new Binding("Text", dtgvDanhmuc.DataSource, "id", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txtTendanhmuc.Text;
            if (TypeDrink.Instance.themTypeDrink(name))
            {
                MessageBox.Show("Thêm " + name + " thành công");
                loadListType();
            }
            else
                MessageBox.Show("Có lỗi khi thêm");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string name = txtTendanhmuc.Text;
            int id = Convert.ToInt32(txtIDdanhmuc.Text);
            if (TypeDrink.Instance.suaTypeDrink(id,name))
            {
                MessageBox.Show("Sửa " + name + " thành công");
                loadListType();
            }
            else
                MessageBox.Show("Có lỗi khi sửa");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDdanhmuc.Text);
            string name = txtTendanhmuc.Text;
            if (TypeDrink.Instance.xoaTypeDrink(id))
            {
                MessageBox.Show("Xóa " + name + " thành công");
                loadListType();
            }
            else
                MessageBox.Show("Có lỗi khi xóa");
        }
    }
}

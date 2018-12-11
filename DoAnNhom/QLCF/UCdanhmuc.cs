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
            if (txtTendanhmuc.Text == "")
            {
                MessageBox.Show("Vui lòng đặt tên danh mục");
            }
            else
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTendanhmuc.Text;
                int id = Convert.ToInt32(txtIDdanhmuc.Text);
                if (TypeDrink.Instance.suaTypeDrink(id, name))
                {
                    MessageBox.Show("Sửa " + name + " thành công");
                    loadListType();
                }
                else
                    MessageBox.Show("Có lỗi khi sửa");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIDdanhmuc.Text);
                string name = txtTendanhmuc.Text;
                DialogResult dialog = MessageBox.Show("Bạn thực sự muốn xóa không ?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    if (TypeDrink.Instance.xoaTypeDrink(id))
                    {
                        MessageBox.Show("Xóa " + name + " thành công");
                        loadListType();
                    }
                    else
                        MessageBox.Show("Có lỗi khi xóa");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thanh toán drink trước khi xóa");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTimdanhmuc.Text;
                typeList.DataSource = TypeDrink.Instance.search(name);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi tìm kiếm");
            }

        }
    }
}

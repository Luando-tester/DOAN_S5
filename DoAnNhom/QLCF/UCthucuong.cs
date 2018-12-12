using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLCF.DTB;
using QLCF.Class;

namespace QLCF
{
    public partial class UCthucuong : UserControl
    {
        private static UCthucuong _instance;
        public static UCthucuong Instace
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new UCthucuong();
                }
                return _instance;
            }
        }
        BindingSource drinklist = new BindingSource();
        public UCthucuong()
        {
            InitializeComponent();
            dtgvThucuong.DataSource = drinklist;
            loadListDrink();
            loadDrinktxt();
            loadTypeDrink(cobLoaithucuong);
        }

        //load danh sach drink
        void loadListDrink()
        {
            drinklist.DataSource = Drink.Instance.getListDrink();
        }

        //load cac text drink theo list drink
        void loadDrinktxt()
        {
            txtTenthucuong.DataBindings.Add(new Binding("Text",dtgvThucuong.DataSource, "name",true,DataSourceUpdateMode.Never));
            txtIDthucuong.DataBindings.Add(new Binding("Text", dtgvThucuong.DataSource, "id",true,DataSourceUpdateMode.Never));
            numGiathucuong.DataBindings.Add(new Binding("Value", dtgvThucuong.DataSource, "price",true,DataSourceUpdateMode.Never));
        }

        void loadTypeDrink(ComboBox cb)
        {
            cb.DataSource = TypeDrink.Instance.ListTypeDrink();
            cb.DisplayMember = "name";
        }

        //event show danh sach drink
        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                loadListDrink();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xem");
            }
        }

        private void txtIDthucuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvThucuong.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvThucuong.SelectedCells[0].OwningRow.Cells["TypeDrink"].Value;
                    ClsTypeDrink typedrink = TypeDrink.Instance.loadTypeDrinkbyId(id);
                    cobLoaithucuong.SelectedItem = typedrink;
                    int index = -1;
                    int i = 0;
                    foreach (ClsTypeDrink item in cobLoaithucuong.Items)
                    {
                        if (item.Id == typedrink.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cobLoaithucuong.SelectedIndex = index;
                }
            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenthucuong.Text;
                int typeDrink = (cobLoaithucuong.SelectedItem as ClsTypeDrink).Id;
                float price = (float)numGiathucuong.Value;
                if (name != "" && price != 0 && typeDrink != 0)
                {
                    if (Drink.Instance.themDrink(name, typeDrink, price))
                    {
                        MessageBox.Show("Thêm " + name + " thành công");
                        loadListDrink();
                    }
                    else
                        MessageBox.Show("Có lỗi khi thêm");
                }
                else
                {
                    MessageBox.Show("Vui lòng không bỏ trống thông tin khi thêm");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenthucuong.Text;
                int typeDrink = (cobLoaithucuong.SelectedItem as ClsTypeDrink).Id;
                float price = (float)numGiathucuong.Value;
                int id = Convert.ToInt32(txtIDthucuong.Text);
                if (Drink.Instance.suaDrink(id, name, typeDrink, price))
                {
                    MessageBox.Show("Cập nhật " + name + " thành công");
                    loadListDrink();
                }
                else
                    MessageBox.Show("Có lỗi khi cập nhật");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi cập nhật");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenthucuong.Text;
                int id = Convert.ToInt32(txtIDthucuong.Text);
                DialogResult dialog = MessageBox.Show("Bạn thực sự muốn xóa không ?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    if (Drink.Instance.xoaDrink(id))
                    {
                        MessageBox.Show("Xóa" + name + " thành công");
                        loadListDrink();
                    }
                    else
                        MessageBox.Show("Có lỗi khi xóa");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi xóa");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string nameDrink = txtTimthucuong.Text;
                drinklist.DataSource = Drink.Instance.timkiem(nameDrink);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi tìm kiếm");
            }
        }

    }
}

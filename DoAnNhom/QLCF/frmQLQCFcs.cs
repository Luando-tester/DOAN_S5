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
using System.Globalization;

namespace QLCF
{
    public partial class frmQLQCFcs : Form
    {
        
        public frmQLQCFcs()
        {
            InitializeComponent();
            LoadTypeDrink();
            LoadTableDrink();
        }

        //Hiển thị usercontrol Tài Khoản
        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            if (!PnlUsercontrol.Controls.Contains(UCtaikhoan.Instace))
            {
                PnlUsercontrol.Controls.Add(UCtaikhoan.Instace);
                UCtaikhoan.Instace.Dock = DockStyle.Fill;
                UCtaikhoan.Instace.BringToFront();
            }
            else
                UCtaikhoan.Instace.BringToFront();
        }

        //Chức năng thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Chặn khi tắt chương trình
        private void frmQLQCFcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        //Hiển thị usercontrol Hóa Đơn 
        private void btnHoadon_Click(object sender, EventArgs e)
        {
            if (!PnlUsercontrol.Controls.Contains(UChoadon.Instace))
            {
                PnlUsercontrol.Controls.Add(UChoadon.Instace);
                UChoadon.Instace.Dock = DockStyle.Fill;
                UChoadon.Instace.BringToFront();
            }
            else
                UChoadon.Instace.BringToFront();
        }

        //Hiển thị usercontrol Drink
        private void btnQuanlydrink_Click(object sender, EventArgs e)
        {
            if (!PnlUsercontrol.Controls.Contains(UCthucuong.Instace))
            {
                PnlUsercontrol.Controls.Add(UCthucuong.Instace);
                UCthucuong.Instace.Dock = DockStyle.Fill;
                UCthucuong.Instace.BringToFront();
            }
            else
                UCthucuong.Instace.BringToFront();
        }

        //Hiển thị usercontrol Danh Mục
        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            if (!PnlUsercontrol.Controls.Contains(UCdanhmuc.Instace))
            {
                PnlUsercontrol.Controls.Add(UCdanhmuc.Instace);
                UCdanhmuc.Instace.Dock = DockStyle.Fill;
                UCdanhmuc.Instace.BringToFront();
            }
            else
                UCdanhmuc.Instace.BringToFront();
        }
        
        //Hiển thị usercontrol Bàn
        private void btnBan_Click(object sender, EventArgs e)
        {
            if (!PnlUsercontrol.Controls.Contains(UCbancs.Instace))
            {
                PnlUsercontrol.Controls.Add(UCbancs.Instace);
                UCbancs.Instace.Dock = DockStyle.Fill;
                UCbancs.Instace.BringToFront();
            }
            else
                UCbancs.Instace.BringToFront();
        }

        //Hiển thị usercontrol Admin
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (!PnlUsercontrol.Controls.Contains(UCadmin.Instance))
            {
                PnlUsercontrol.Controls.Add(UCadmin.Instance);
                UCadmin.Instance.Dock = DockStyle.Fill;
                UCadmin.Instance.BringToFront();
            }
            else
                UCadmin.Instance.BringToFront();
        }

        //Load danh sách bàn lên giao diện hiện thị bằng button gồm tên bàn + status
        void LoadTableDrink()
        {
            flTabledrink.Controls.Clear();
            List<ClsTableDrink> tableList = TableDrink.Instance.loadTableDrink();
            foreach (ClsTableDrink item in tableList)
            {
                Button btnTable = new Button() { Width = TableDrink.TableWidth, Height = TableDrink.TableHeight };
                btnTable.Text = item.Name + Environment.NewLine + item.Status;
                btnTable.Click += btnTable_Click;
                btnTable.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btnTable.BackColor = Color.White;
                        break;
                    default:
                        btnTable.BackColor = Color.Aqua;
                        break;
                }
                flTabledrink.Controls.Add(btnTable);
            }
        }

        //Hiển thị hóa đơn của từng bàn
        void ShowBill(int id)
        {
            lsvHoadon.Items.Clear();
            List<QLCF.Class.ClsMenu> listBill = QLCF.DTB.Menu.Instance.getListMenu(id);
            float totalPrice = 0;
            foreach(QLCF.Class.ClsMenu item in listBill)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Total.ToString());
                totalPrice += item.Total;
                lsvHoadon.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalPrice.Text = totalPrice.ToString("c",culture);
        }

        //Event hiển thị hóa đơn tương ứng khi click vào bàn 
        void btnTable_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as ClsTableDrink).Id;
            lsvHoadon.Tag = (sender as Button).Tag;
            ShowBill(tableId);
        }  

        //Load danh sach TypeDrink
        void LoadTypeDrink()
        {
            List<ClsTypeDrink> listTypeDrink = TypeDrink.Instance.ListTypeDrink();
            cobLoaidrink.DataSource = listTypeDrink;
            cobLoaidrink.DisplayMember = "name";
        }

        //Load danh sach Drink theo TypeDrink
        void LoadDrink(int id)
        {
            List<ClsDrink> listDrink = Drink.Instance.listDrink(id);
            cobDrink.DataSource = listDrink;
            cobDrink.DisplayMember = "name";
        }

        //Load danh sach comboBox khi Selected item
        private void cobLoaidrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cob = sender as ComboBox;
            if (cob.SelectedItem == null)
                return;
            ClsTypeDrink selected = cob.SelectedItem as ClsTypeDrink;
            id = selected.Id;

            LoadDrink(id);
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            ClsTableDrink table = lsvHoadon.Tag as ClsTableDrink;
            int idBill = Bill.Instance.getBill(table.Id);
            int drink = (cobDrink.SelectedItem as ClsDrink).Id;
            int count = (int)numSoluongdrink.Value;
            if (idBill == -1)
            {
                Bill.Instance.AddBill(table.Id);
                DrinkBill.Instance.AddDrinkBill(Bill.Instance.getIdBill(), drink, count);
            }
            else
            {
                DrinkBill.Instance.AddDrinkBill(idBill, drink, count);
            }
            ShowBill(table.Id);
            LoadTableDrink();
        }

        private void btnThanhthoan_Click(object sender, EventArgs e)
        {
            ClsTableDrink table = lsvHoadon.Tag as ClsTableDrink;
            int idBill = Bill.Instance.getBill(table.Id);
            if (idBill != -1)
            {
                if(MessageBox.Show("Thanh toán hóa đơn cho " + table.Name, "Thông Báo", MessageBoxButtons.OKCancel)== System.Windows.Forms.DialogResult.OK); 
                {
                    Bill.Instance.CheckOut(idBill);
                    ShowBill(table.Id);
                    LoadTableDrink();
                }
            }
        }
    }
}

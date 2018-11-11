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
    public partial class frmQLQCFcs : Form
    {
        
        public frmQLQCFcs()
        {
            InitializeComponent();
        }

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmQLQCFcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

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
    }
}

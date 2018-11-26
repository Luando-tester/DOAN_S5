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
    public partial class UChoadon : UserControl
    {
        private static UChoadon _instance;
        public static UChoadon Instace
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new UChoadon();
                }
                return _instance;
            }
        }
        public UChoadon()
        {
            InitializeComponent();
            loadThang();
            loadListBill(timePicktungay.Value,timePickdenngay.Value);
        }

        void loadThang()
        {
            DateTime now = DateTime.Now;
            timePicktungay.Value = new DateTime(now.Year, now.Month, 1);
            timePickdenngay.Value = timePicktungay.Value.AddMonths(1).AddDays(-1);
        }

        void loadListBill(DateTime checkIn, DateTime checkOut)
        {
            dtgvHoadon.DataSource = Bill.Instance.getHoadon(checkIn,checkOut);
        }

        private void btnXemhoadon_Click(object sender, EventArgs e)
        {
            loadListBill(timePicktungay.Value, timePickdenngay.Value);
        }
    }
}

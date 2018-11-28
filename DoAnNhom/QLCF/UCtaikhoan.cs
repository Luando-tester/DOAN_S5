using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLCF.Class;
using QLCF.DTB;

namespace QLCF
{
    public partial class UCtaikhoan : UserControl
    {
        private ClsAccount loginAccount;

        public ClsAccount LoginAccount
        {
            get { return loginAccount; }
            set
            {
                loginAccount = value;
                typeAccount(loginAccount);
            }
        }
        private static UCtaikhoan _instance;
        public static UCtaikhoan Instace
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCtaikhoan();
                }
                return _instance;
            }
        }
        public UCtaikhoan()
        {
            InitializeComponent();
        }
        void typeAccount(ClsAccount acc)
        {
            txtTendangnhap.Text = loginAccount.Username;
        }
    }
}

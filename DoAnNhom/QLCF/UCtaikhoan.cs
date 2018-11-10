using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCF
{
    public partial class UCtaikhoan : UserControl
    {
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
    }
}

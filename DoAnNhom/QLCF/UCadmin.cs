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
    public partial class UCadmin : UserControl
    {
        public UCadmin()
        {
            InitializeComponent();
        }
        private static UCadmin _instance;

        public static UCadmin Instance
        {
            get { if (_instance == null) _instance = new UCadmin(); return UCadmin._instance; }
            set { UCadmin._instance = value; }
        }
    }
}

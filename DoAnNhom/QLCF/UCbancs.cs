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
        public UCbancs()
        {
            InitializeComponent();
        }
    }
}

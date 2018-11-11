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
        public UCdanhmuc()
        {
            InitializeComponent();
        }
    }
}

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
        public UCthucuong()
        {
            InitializeComponent();
        }
    }
}

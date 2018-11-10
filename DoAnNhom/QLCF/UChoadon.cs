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
        }
    }
}

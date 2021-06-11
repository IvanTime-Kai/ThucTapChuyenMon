using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class MainHinhAnh : Form
    {
        public MainHinhAnh()
        {
            InitializeComponent();
        }
        private int _img = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_img == 1)
            {
                pcchinh.Image = dental_sys.Properties.Resources._1;
                _img = 2;
            }
            else if (_img == 2)
            {
                pcchinh.Image = dental_sys.Properties.Resources._3;
                _img = 3;
            }
            else if (_img == 3)
            {
                pcchinh.Image = dental_sys.Properties.Resources._4;
                _img = 4;
            }
            else if (_img == 4)
            {
                pcchinh.Image = dental_sys.Properties.Resources._5;
                _img = 5;
            }
            else if (_img == 5)
            {
                pcchinh.Image = dental_sys.Properties.Resources._6;
                _img = 6;
            }
        }
    }
}

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
    public partial class frmXemLuong : Form
    {
        public frmXemLuong()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        int idUser;
        public frmXemLuong(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void frmXemLuong_Load(object sender, EventArgs e)
        {
            using(thuctapEntities xemLuong = new thuctapEntities())
            {
                dataGridView1.DataSource = xemLuong.sp_XemLuong(idUser).ToList();
            }
        }
    }
}

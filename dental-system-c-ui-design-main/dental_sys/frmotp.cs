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
    public partial class frmotp : Form
    {
        public int id;
        public int otp;
        public frmotp()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtmaxn.Text) == otp)
            {
                frmNhapMKnew doiMK = new frmNhapMKnew();
                doiMK.id = id;
                this.Hide();
                doiMK.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mã OTP không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

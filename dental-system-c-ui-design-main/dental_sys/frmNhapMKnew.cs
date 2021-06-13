using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class frmNhapMKnew : Form
    {
        public int id;
        public frmNhapMKnew()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "" || txtpassmoi.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtpass.Text != txtpassmoi.Text)
            {
                MessageBox.Show("Mật khẩu không trùng nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtpass.Text.Equals(txtpassmoi.Text))
            {
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtpassmoi.Text);
                byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

                string hasPass = "";
                foreach (byte item in hasData)
                {
                    hasPass += item;
                }
                string query = " update Users set MatKhau='" + hasPass + "' where id like '" + id + "' ";
                int data = Connect.Instace.updateTaikhoan(query);
                if (data > 0)
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmDangNhap back = new frmDangNhap();
                back.Visible = true;
            }
            else
            {
                MessageBox.Show("Mật khẩu chưa trùng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

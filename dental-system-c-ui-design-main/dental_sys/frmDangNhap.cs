using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        frm_NhanDienKhuonMat frm_NDKM;

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (thuctapEntities quanLy = new thuctapEntities())
            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (txtUser.Text == "" || txtPassWord.Text == "" || txtUser.Text == "" && txtPassWord.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                }
                else
                {
                    if (Regex.IsMatch(txtUser.Text, pattern))
                    {
                        errorProvider1.Clear();
                        User user = new User();
                        
                        try
                        {
                            byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtPassWord.Text);
                            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

                            string hasPass = "";
                            foreach (byte item in hasData)
                            {
                                hasPass += item;
                            }

                            user = quanLy.Users.Single(p => p.Email == txtUser.Text && p.MatKhau == hasPass);
                            int id = int.Parse(quanLy.Users.Single(p => p.Email == txtUser.Text && p.MatKhau == hasPass).id.ToString());
                            MessageBox.Show("Đăng nhập thành công");
                            Role role = quanLy.Roles.FirstOrDefault(p => p.id == user.Chucvu);
                            try
                            {
                                if (role.role_name == "Bác sĩ")
                                {                                 
                                    Loading _load = new Loading(id, true, true, true, false, false ,false ,false ,false ,false ,true);
                                    _load.Show();
                                    this.Hide();
                                    frm_NDKM.Close();

                                }
                                else if (role.role_name == "Lễ tân")
                                {
                                    Loading _load = new Loading(id, true, true, false, false, false, false, false, false, false, true);
                                    _load.Show();
                                    this.Hide();
                                    frm_NDKM.Close();

                                }
                                else if(role.role_name == "Giám đốc")
                                {
                                    Loading _load = new Loading(id, true, true, true, true, true, true, true, true, true, true);
                                    _load.Show();
                                    this.Hide();
                                    frm_NDKM.Close();

                                }


                            }
                            catch (Exception)
                            {

                                MessageBox.Show("Tài khoản này chưa được phân quyền","Thông báo");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Users không tồn tại");
                        }
                    
                }
                    else
                    {
                        errorProvider1.SetError(this.txtUser, "Please provide valid Mail address");
                    }
                }
            }
                

            //Loading _load = new Loading();
            //_load.Show();
        }

        private void linkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau frmQuenMK = new frmQuenMatKhau();
            frmQuenMK.Show();
        }

        private void frmDangNhap_Shown(object sender, EventArgs e)
        {
            frm_NDKM = new frm_NhanDienKhuonMat();
            frm_NDKM.Show();
            frm_NDKM.Hide();
        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Có thực sự muốn thoát?", "Thoát chương trình!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                // do nothing
            }
        }
    }
}

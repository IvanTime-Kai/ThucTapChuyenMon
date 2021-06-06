using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                            
                            user = quanLy.Users.Single(p => p.Email == txtUser.Text && p.MatKhau == txtPassWord.Text);
                            int id = int.Parse(quanLy.Users.Single(p => p.Email == txtUser.Text && p.MatKhau == txtPassWord.Text).id.ToString());
                            MessageBox.Show("Đăng nhập thành công");
                            Role role = quanLy.Roles.FirstOrDefault(p => p.id == user.Chucvu);
                            try
                            {
                                if (role.role_name == "Bác sĩ")
                                {                                 
                                    Loading _load = new Loading(id);
                                    _load.Show();
                                    
                                }
                                else if (role.role_name == "Lễ tân")
                                {
                                    Loading _load = new Loading(id);
                                    _load.Show();
                                    
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
            frm_NhanDienKhuonMat frm_NhanDienKhuonMat = new frm_NhanDienKhuonMat();
            frm_NhanDienKhuonMat.Show();
            frm_NhanDienKhuonMat.Hide();
        }
    }
}

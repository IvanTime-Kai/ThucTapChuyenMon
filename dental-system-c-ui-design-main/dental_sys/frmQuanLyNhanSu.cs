using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class frmQuanLyNhanSu : Form
    {
        public frmQuanLyNhanSu()
        {
            InitializeComponent();
        }
        string location = "";
        private void frmQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuctapDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.thuctapDataSet1.Users);


            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;

            using (thuctapEntities qlNhanSu = new thuctapEntities())
            {
                cbChucVu.DataSource = qlNhanSu.Roles.Where(p => p.id != 3).ToList();
                cbChucVu.DisplayMember = "role_name";
                cbChucVu.ValueMember = "id";

                cbGioiTinh.SelectedIndex = 0;

            }
        }
        int idUser;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private byte[] getImage() // return byte[] cua image cua this.location
        {
            byte[] imgProduct = null;

            if (this.location == "")
            {
                // nothing
            }
            else
            {
                FileStream fs = new FileStream(this.location, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imgProduct = br.ReadBytes((int)fs.Length);
            }


            return imgProduct;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Chọn ảnh sản phẩm";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    location = dlg.FileName.ToString();
                    picProduct.ImageLocation = location;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng load ảnh lên!");
            }
        }
        private void load_bandau()
        {
            using (thuctapEntities qlNhanSu = new thuctapEntities())
            {
                dataGridView1.DataSource = qlNhanSu.Users.ToList();
            }
        }
        private void load()
        {
            using(thuctapEntities qlNhanSu = new thuctapEntities())
            {
                Role role = qlNhanSu.Roles.Where(p => p.role_name == "Giám đốc").First();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((Int32)row.Cells[4].Value == role.id)
                    {
                        //dataGridView1.DataSource = qlNhanSu.Users.ToList();
                        dataGridView1.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        private bool check_Null()
        {
            if (txtTen.Text.Equals(String.Empty))
            {
                return false;
            }
            if (txtSDT.Text.Equals(String.Empty))
            {
                return false;
            }
            if (txtEmail.Text.Equals(String.Empty))
            {
                return false;
            }
            if (txtPassword.Text.Equals(String.Empty))
            {
                return false;
            }

            return true;
        }

        private void refresh()
        {
            txtTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            picProduct.ImageLocation = "";
            this.location = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlNhanSu = new thuctapEntities())
            {
                if(check_Null() == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    User user = new User();
                    user.Ten = txtTen.Text;
                    user.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                    user.NgaySinh = dtpNgaySinh.Value;
                    user.Chucvu = int.Parse(cbChucVu.SelectedValue.ToString());
                    if (getImage() == null)
                    {
                        MessageBox.Show("Vui lòng load hình ảnh sản phẩm lên");
                        refresh();
                        picProduct.Image = null;
                        return;
                    }
                    else
                    {
                        user.AnhChup = getImage();
                        user.SoDienThoai = txtSDT.Text;
                        //user.MatKhau = txtPassword.Text;

                        byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtPassword.Text);
                        byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

                        string hasPass = "";
                        foreach (byte item in hasData)
                        {
                            hasPass += item;
                        }

                        user.MatKhau = hasPass;

                        user.Email = txtEmail.Text;
                        user.NgayVaoLam = dtpNgayVaoLam.Value;

                        qlNhanSu.Users.Add(user);
                        qlNhanSu.SaveChanges();
                        MessageBox.Show("Thêm thành công");
                        dataGridView1.DataSource = qlNhanSu.Users.ToList();
                        load();
                        refresh();
                        picProduct.Image = null;
                        //frmQuanLyNhanSu_Load(sender, e);
                    }                  
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlNhanSu = new thuctapEntities())
            {
                if (check_Null() == false)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xoá");
                    return;
                }
                else
                {
                    try
                    {
                        qlNhanSu.sp_XoaUser(idUser);
                        qlNhanSu.SaveChanges();
                        dataGridView1.DataSource = qlNhanSu.Users.ToList();
                        load();
                        MessageBox.Show("Xoá thành công");
                        refresh();
                        picProduct.Image = null;
                        frmQuanLyNhanSu_Load(sender, e);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xoá những nhân viên đang còn hợp đồng");
                        refresh();
                        picProduct.Image = null;
                        return;
                    }
                    
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlNhanSu = new thuctapEntities())
            {
                if(check_Null() == false)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa");
                    return;
                }
                else
                {
                    try
                    {
                        User user = qlNhanSu.Users.FirstOrDefault(p => p.id == idUser);
                        user.Ten = txtTen.Text;
                        user.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                        user.NgaySinh = dtpNgaySinh.Value;
                        user.Chucvu = int.Parse(cbChucVu.SelectedValue.ToString());
                        if (getImage() == null)
                        {
                            user.SoDienThoai = txtSDT.Text;
                            user.MatKhau = txtPassword.Text;
                            user.Email = txtEmail.Text;
                            user.NgayVaoLam = dtpNgayVaoLam.Value;
                            qlNhanSu.SaveChanges();
                        }
                        else
                        {
                            user.AnhChup = getImage();
                            user.SoDienThoai = txtSDT.Text;
                            user.MatKhau = txtPassword.Text;
                            user.Email = txtEmail.Text;
                            user.NgayVaoLam = dtpNgayVaoLam.Value;
                            qlNhanSu.SaveChanges();
                        }

                    

                        load();
                        dataGridView1.DataSource = qlNhanSu.Users.ToList();
                        refresh();
                        MessageBox.Show("Sửa thành công");
                        picProduct.Image = null;
                        this.location = "";
                        //this.idUser = ;
                        //frmQuanLyNhanSu_Load(sender, e);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idUser = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cbGioiTinh.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dtpNgaySinh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cbChucVu.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                txtSDT.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtPassword.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                dtpNgayVaoLam.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                try
                {
                    byte[] img = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                    MemoryStream ms = new MemoryStream(img);
                    picProduct.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {
                    picProduct.Image = null;
                }

            }
            catch (Exception)
            {
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void frmQuanLyNhanSu_Shown(object sender, EventArgs e)
        {
            using (thuctapEntities qlNhanSu = new thuctapEntities())
            {
                Role role = qlNhanSu.Roles.Where(p => p.role_name == "Giám đốc").First();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((Int32)row.Cells[4].Value == role.id)
                    {
                        //MessageBox.Show(role.id + " " + (Int32)row.Cells[4].Value);
                        dataGridView1.Rows[row.Index].Visible = false;
                        //MessageBox.Show(" " + row.Index);
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class frmQuanLy : Form
    {

        public frmQuanLy()
        {
            InitializeComponent();
        }
        string location = "";
        int idUser;
        private bool qlDichVu;
        private bool qlCatruc;
        private bool qlNhanSu;
        private bool qlLuong;
        private bool qlVatLieu;
        private bool qlThuChi;
        private bool qlLichHen;
        private bool qlBaoCao;
        private bool qlBenhNhan;
        private bool XemCaTruc;

        //private int maUser;
        public frmQuanLy(int idUser, bool qlLichHen, bool qlBenhNhan, bool XemCaTruc, bool qlDichVu, bool qlCatruc, bool qlNhanSu, bool qlLuong, bool qlVatLieu, bool qlThuChi, bool qlBaoCao)       
        {
            InitializeComponent();
            this.idUser = idUser;
            this.qlLichHen = qlLichHen;
            this.qlBenhNhan = qlBenhNhan;
            this.XemCaTruc = XemCaTruc;
            this.qlDichVu = qlDichVu;
            this.qlCatruc = qlCatruc;
            this.qlNhanSu = qlNhanSu;
            this.qlLuong = qlLuong;
            this.qlVatLieu = qlVatLieu;
            this.qlThuChi = qlThuChi;
            this.qlBaoCao = qlBaoCao;
        }

        private void loadform(object formload)
        {
            if (this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);
            Form fh = formload as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(fh);
            this.pnMain.Tag = fh;
            fh.Opacity = 0;
            fh.Show();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            guna2Button1.Enabled = qlLichHen;
            guna2Button2.Enabled = qlBenhNhan;
            guna2Button3.Enabled = XemCaTruc;
            guna2Button4.Enabled = qlDichVu;
            guna2Button5.Enabled = qlCatruc;
            guna2Button6.Enabled = qlNhanSu;
            guna2Button7.Enabled = qlLuong;
            guna2Button8.Enabled = qlVatLieu;
            guna2Button9.Enabled = qlThuChi;
            guna2Button10.Enabled = qlBaoCao;
            

            using (thuctapEntities quanLy = new thuctapEntities())
            {
                byte[] imgUser = quanLy.Users.FirstOrDefault(p => p.id == idUser).AnhChup;
                string name = quanLy.Users.FirstOrDefault(p => p.id == idUser).Ten;
                try
                {
                    byte[] img = imgUser;
                    MemoryStream ms = new MemoryStream(img);
                    picProduct.Image = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    picProduct.Image = null;
                }

                lbTen.Text = "Xin chào   " + name;
            }

            loadform(new MainHinhAnh());
        }

        public void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new frmQL_LichHen(idUser));
        }

        private void container(object _form)
        {

            if (pnMain.Controls.Count > 0) pnMain.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(fm);
            pnMain.Tag = fm;
            fm.Show();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadform(new frm_BacsiCaTruc(idUser));
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            loadform(new frmQuanLyDichVu());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            container(new frmQuanLyBenhNhan());
        }

        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            using (thuctapEntities loading = new thuctapEntities())
            {
                frmXemLuong frmXemLuong = new frmXemLuong(idUser);
                frmXemLuong.Show();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            loadform(new frmQL_CaTruc());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            loadform(new frmQuanLyNhanSu());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            loadform(new frmQL_Luong());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            loadform(new frmQL_VatLieu());
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            loadform(new frmQL_ThuChi());
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            loadform(new frmqlBaoCao());
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

        private void xemLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (thuctapEntities loading = new thuctapEntities())
            {
                frmXemLuong frmXemLuong = new frmXemLuong(idUser);
                frmXemLuong.Show();
            }
        }
        Random random = new Random();
        int x = 16, y = 16, a = 1;

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Thực sự muốn đăng xuất ??",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                new frmDangNhap().Show();
                this.Close();
            }
            else
            {
                // nothing
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Có thực sự muốn thoát?", "Thoát chương trình!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.Close();
                System.Environment.Exit(0);
            }
            else if (dr == DialogResult.Cancel)
            {
                // do nothing
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Principal_Load(sender, e);
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            loadform(new frmQL_ThanhToan());
        }

        //bool mnuExpanded = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            //if (!bunifuTransition1.IsCompleted) return;
            //if (guna2Panel1.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            //{
            //    if (!mnuExpanded)
            //    {
            //        mnuExpanded = true;
            //        guna2Panel1.Visible = false;
            //        guna2Panel1.Width = 250;
            //        bunifuTransition1.Show(guna2Panel1);
            //    }
            //}
            //else
            //{
            //    if (mnuExpanded)
            //    {
            //        mnuExpanded = false;
            //        guna2Panel1.Visible = false;
            //        guna2Panel1.Width = 50;
            //        bunifuTransition1.Show(guna2Panel1);
            //    }
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                label2.Location = new Point(x, y);
                if (x >= 286)
                {
                    a = -1;
                    label2.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if (x <= 16)
                {
                    a = 1;
                    label2.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }

            }
            catch { }
        }
    }
}

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
    public partial class frmThemDichVu : Form
    {
        public frmThemDichVu()
        {
            InitializeComponent();
        }

        int buoiDieuTri;
        string emailKH;
        public frmThemDichVu(int id, string emailKH)
        {
            InitializeComponent();
            this.buoiDieuTri = id;
            this.emailKH = emailKH;
        }

        private void frmThemDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuctapDataSet1.DataTable3' table. You can move, or remove it, as needed.
            this.dataTable3TableAdapter.Fill(this.thuctapDataSet1.DataTable3);
            using (thuctapEntities qlDichVu = new thuctapEntities())
            {
                cbDichVu.DataSource = qlDichVu.DichVus.ToList();
                cbDichVu.DisplayMember = "TenDichVu";
                cbDichVu.ValueMember = "id";

                txtBDT_id.Text = Convert.ToString(buoiDieuTri);

                dataGridView5.DataSource = qlDichVu.sp_BDT_DichVu(buoiDieuTri);
            }
        }

        frmQuanLyBenhNhan obj = (frmQuanLyBenhNhan)Application.OpenForms["frmQuanLyBenhNhan"];

        private void btnThem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBDT_id.Text);
            using (thuctapEntities qlDichVu = new thuctapEntities())
            {
                try
                {
                    qlDichVu.sp_TaoBDT_DichVu(id, Convert.ToInt32(cbDichVu.SelectedValue));
                    qlDichVu.SaveChanges();

                    //frmDichVu_Load(sender, e);

                    obj.loadDataBDT();
                    dataGridView5.Update();
                    dataGridView5.Refresh();
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Dich vu da ton tai vui long chon dich vu khac");

                }
            }
        }

        private void btnCT_BDT_Click(object sender, EventArgs e)
        {
             int id = int.Parse(txtBDT_id.Text);
             using (thuctapEntities qlCTHD = new thuctapEntities())
             {
                this.Hide();
                frmXuatCT_CDT f = new frmXuatCT_CDT(id, emailKH);
                f.ShowDialog();
                this.Show();
              }
        }
    }
}

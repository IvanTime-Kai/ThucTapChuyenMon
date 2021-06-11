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
            this.CenterToScreen();
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
                txtBDT_id.Enabled = false;

                txtBDT_id.Text = Convert.ToString(buoiDieuTri);

                dataGridView5.DataSource = qlDichVu.sp_BDT_DichVu(buoiDieuTri);
            }
        }

        private void load()
        {
            using(thuctapEntities qlDichVu = new thuctapEntities())
            {
                //dataGridView5.DataSource = qlDichVu.sp_load_BDT_DichVu();
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

                    load();
                }
                catch (Exception)
                {

                    MessageBox.Show("Dich vu da ton tai vui long chon dich vu khac");

                }
            }
        }

        private void btnCT_BDT_Click(object sender, EventArgs e)
        {
             
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlDichVu = new thuctapEntities())
            {
                if (int.Parse(cbDichVu.SelectedValue.ToString()).Equals(null))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xoá");
                }
                else
                {
                    try
                    {
                        qlDichVu.sp_XoaBDT_DichVu(int.Parse(txtBDT_id.Text), int.Parse(cbDichVu.SelectedValue.ToString()));
                        MessageBox.Show("Xoá thành công");

                        qlDichVu.SaveChanges();

                        obj.loadDataBDT();


                        dataGridView5.Update();
                        dataGridView5.Refresh();

                        load();
                    }
                    catch (Exception)
                    {
                    }
                }
                
            }
        }

        private void btnCT_BDT_Click_1(object sender, EventArgs e)
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

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                cbDichVu.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlDichVu = new thuctapEntities())
            {
                try
                {
                    qlDichVu.sp_Sua_BDT_DichVu(int.Parse(cbDichVu.SelectedValue.ToString()));
                    MessageBox.Show("Sửa thành công");

                    qlDichVu.SaveChanges();


                    obj.loadDataBDT();


                    dataGridView5.Update();
                    dataGridView5.Refresh();

                    load();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dịch vụ nãy đã tồn tại nên không sửa được");
                }
            }
        }
    }
}

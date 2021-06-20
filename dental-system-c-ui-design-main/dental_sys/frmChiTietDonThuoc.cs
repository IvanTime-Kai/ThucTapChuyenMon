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
    public partial class frmChiTietDonThuoc : Form
    {
        public frmChiTietDonThuoc()
        {
            InitializeComponent();
        }

        int donThuocId;
        string emailKH;
        public frmChiTietDonThuoc(int donThuocId, string emailKH)
        {
            InitializeComponent();
            this.donThuocId = donThuocId;
            this.emailKH = emailKH;
            this.CenterToScreen();
        }

        private void frmChiTietDonThuoc_Load(object sender, EventArgs e)
        {

            txtIDDonThuoc.Enabled = false;


            dataGridView6.Columns["id"].Visible = false;
            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.ReadOnly = true;
            dataGridView6.AllowUserToAddRows = false;
            dataGridView6.MultiSelect = false;

            using (thuctapEntities qlCTDT = new thuctapEntities())
            {
                txtIDDonThuoc.Text = Convert.ToString(donThuocId);
            }
            loadData();

        }

        public void loadData()
        {
            using (thuctapEntities qlCTDT = new thuctapEntities())
            {
                dataGridView6.DataSource = qlCTDT.ChiTietDonThuocs.Where(p => p.Donthuoc_id == donThuocId).ToList();         
            }
        }
        string idCTHD = "";
        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idCTHD = dataGridView6.CurrentRow.Cells[0].Value.ToString();
                txtTenThuoc.Text = dataGridView6.CurrentRow.Cells[1].Value.ToString();
                txtSoLuong.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
                cbDonVi.SelectedItem = dataGridView6.CurrentRow.Cells[3].Value.ToString();
                txtIDDonThuoc.Text = dataGridView6.CurrentRow.Cells[4].Value.ToString();
                txtDonGia.Text = dataGridView6.CurrentRow.Cells[5].Value.ToString();
                txtHDSD.Text = dataGridView6.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        frmQuanLyBenhNhan obj = (frmQuanLyBenhNhan)Application.OpenForms["frmQuanLyBenhNhan"];

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (thuctapEntities qlCTDT = new thuctapEntities())
            {
                try
                {
                    ChiTietDonThuoc CTDT = new ChiTietDonThuoc();
                    CTDT.TenThuoc = txtTenThuoc.Text;
                    try
                    {
                        CTDT.SoLuong = int.Parse(txtSoLuong.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Số lượng phải là số");
                        return;
                    }

                    CTDT.Donvi = cbDonVi.Text;
                    CTDT.Donthuoc_id = int.Parse(txtIDDonThuoc.Text);
                    try
                    {
                        CTDT.DonGia = int.Parse(txtDonGia.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đơn giá phải là số");
                    }

                    CTDT.HuongDan = txtHDSD.Text;

                    qlCTDT.ChiTietDonThuocs.Add(CTDT);
                    qlCTDT.SaveChanges();

                    obj.loadData();
                    dataGridView6.Update();
                    dataGridView6.Refresh();

                    loadData();
                    refresh();
                }
                catch (Exception)
                {
                }               
            }
        }

        private void btnXuatCTHD_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlCTDH = new thuctapEntities())
            {
                if (this.idCTHD.Equals(string.Empty))
                {
                    MessageBox.Show("Vui lòng chọn thông tin đơn thuốc cần xoá");
                    return;
                }
                MessageBox.Show(idCTHD);
                try
                {
                    qlCTDH.sp_XoaCTDT(int.Parse(this.idCTHD));
                    qlCTDH.SaveChanges();
                    loadData();
                    obj.loadData();
                    dataGridView6.Update();
                    dataGridView6.Refresh();
                    MessageBox.Show("Đã xoá thành công");
                    this.idCTHD = "";
                }
                catch (Exception)
                {
                }
            }
        }

        private void refresh()
        {
            txtTenThuoc.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtHDSD.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlCTDT = new thuctapEntities())
            {
                if (this.idCTHD.Equals(string.Empty))
                {
                    MessageBox.Show("Vui lòng chọn thông tin đơn thuốc cần sửa");
                    return;
                }
                else
                {
                    try
                    {
                        int id = int.Parse(dataGridView6.CurrentRow.Cells[0].Value.ToString());
                        ChiTietDonThuoc ctdt = qlCTDT.ChiTietDonThuocs.FirstOrDefault(p => p.id == id);
                        ctdt.TenThuoc = txtTenThuoc.Text;
                        ctdt.SoLuong = int.Parse(txtSoLuong.Text);
                        ctdt.Donvi = cbDonVi.SelectedItem.ToString();
                        ctdt.DonGia = int.Parse(txtDonGia.Text);
                        ctdt.HuongDan = txtHDSD.Text;

                        qlCTDT.SaveChanges();
                        loadData();
                        MessageBox.Show("Sửa thành công");
                        refresh();
                    }
                    catch (Exception)
                    {
                    }
                }
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXuatCTHD_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDDonThuoc.Text);
            using (thuctapEntities qlCTHD = new thuctapEntities())
            {
                this.Hide();
                frmXuatCTDT f = new frmXuatCTDT(id, emailKH);
                f.ShowDialog();
                this.Show();
            }
        }
    }
}

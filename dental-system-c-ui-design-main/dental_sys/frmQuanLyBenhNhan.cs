﻿using System;
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
    public partial class frmQuanLyBenhNhan : Form
    {
        public frmQuanLyBenhNhan()
        {
            InitializeComponent();
        }
        string location = "";
        private int maFile;
        private void frmQuanLyBenhNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuctapDataSet.BenhNen' table. You can move, or remove it, as needed.
            this.benhNenTableAdapter.Fill(this.thuctapDataSet.BenhNen);
            // TODO: This line of code loads data into the 'thuctapDataSet.BenhNen_BenhNhan' table. You can move, or remove it, as needed.
            this.benhNen_BenhNhanTableAdapter.Fill(this.thuctapDataSet.BenhNen_BenhNhan);
            // TODO: This line of code loads data into the 'thuctapDataSet.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter1.Fill(this.thuctapDataSet.BenhNhan);

            // TODO: This line of code loads data into the 'thuctapDataSet.DonThuoc' table. You can move, or remove it, as needed.
            this.donThuocTableAdapter.Fill(this.thuctapDataSet.DonThuoc);
            // TODO: This line of code loads data into the 'thuctapDataSet.HinhAnhDieuTri' table. You can move, or remove it, as needed.
            this.hinhAnhDieuTriTableAdapter.Fill(this.thuctapDataSet.HinhAnhDieuTri);
            // TODO: This line of code loads data into the 'thuctapDataSet.BuoiDieuTri' table. You can move, or remove it, as needed.
            this.buoiDieuTriTableAdapter.Fill(this.thuctapDataSet.BuoiDieuTri);
            // TODO: This line of code loads data into the 'thuctapDataSet11.DataTable2' table. You can move, or remove it, as needed.
            // this.dataTable2TableAdapter.Fill(this.thuctapDataSet11.DataTable2);
            // TODO: This line of code loads data into the 'thuctapDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.thuctapDataSet1.DataTable1);
            // TODO: This line of code loads data into the 'thuctapDataSet1.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter.Fill(this.thuctapDataSet1.BenhNhan);


            dgvBenhNhan.Columns["bn"].Visible = false;
            dgvBenhNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBenhNhan.ReadOnly = true;
            dgvBenhNhan.AllowUserToAddRows = false;
            dgvBenhNhan.MultiSelect = false;

            dgvBenhNen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBenhNen.ReadOnly = true;
            dgvBenhNen.AllowUserToAddRows = false;
            dgvBenhNen.MultiSelect = false;
            dgvBenhNen.DataSource = null;

            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.DataSource = null;

            dataGridView6.Columns["dt"].Visible = false;
            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.ReadOnly = true;
            dataGridView6.AllowUserToAddRows = false;
            dataGridView6.MultiSelect = false;
            dataGridView6.DataSource = null;

            dgvBuoiDieuTri.Columns["idBDT"].Visible = false;
            dgvBuoiDieuTri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuoiDieuTri.ReadOnly = true;
            dgvBuoiDieuTri.AllowUserToAddRows = false;
            dgvBuoiDieuTri.MultiSelect = false;


            dataGridView2.Columns["idBN"].Visible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.MultiSelect = false;

            //formatDataGridView(dgvBuoiDieuTri);

            //dataGridView3.Columns["idBN"].Visible = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.ReadOnly = true;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.DataSource = null;



            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                // Load data lên bảng dgvBuoiDieuTri
                //dgvBuoiDieuTri.DataSource = qlBenhNhan.sp_BDT_HinhAnh().ToList();

                // Buoi dieu tri
                cbBacSi.DataSource = qlBenhNhan.Users.Where(p => p.Chucvu == 1).ToList();
                cbBacSi.DisplayMember = "Ten";
                cbBacSi.ValueMember = "id";

                // Don thuoc
                //int id = int.Parse(dgvBenhNhan.CurrentRow.Cells[0].Value.ToString());
                //cbBuoiDieuTri.DataSource = qlBenhNhan.BuoiDieuTris.Where(p => p.BenhNhan == id).ToList();

                //cbBuoiDieuTri.DisplayMember = "id";
                //cbBuoiDieuTri.ValueMember = "id";

                txtID.Enabled = false;
                txtChiPhi.Enabled = false;
                txtBenhNhan.Enabled = false;

                txtDonThuoc_BDT.Enabled = false;

                cbGioiTinh.SelectedIndex = 0;

                cbNguoiTiepNhan.DataSource = qlBenhNhan.Users.ToList();
                cbNguoiTiepNhan.DisplayMember = "Ten";
                cbNguoiTiepNhan.ValueMember = "id";

                //cbBenhNen.DataSource = qlBenhNhan.BenhNens.ToList();
                //cbBenhNen.DisplayMember = "BenhNen";
                //cbBenhNen.ValueMember = "id";
                //cbBenhNen.SelectedIndex = 0;

            }
        }

        private void formatDataGridView(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
        }

        private void idBDT_HinhAnh()
        {
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                dataGridView1.DataSource = qlBenhNhan.sp_loadHinhAnhBDT(int.Parse(txtID.Text));
            }
        }

        public void BDT_DonThuoc()
        {
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                dataGridView6.DataSource = qlBenhNhan.sp_loadDonThuoc_BDT(int.Parse(txtID.Text));
            }
        }
        private void dgvBuoiDieuTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgvBuoiDieuTri.CurrentRow.Cells[0].Value.ToString();
                dtpBuoiDieuTri.Text = dgvBuoiDieuTri.CurrentRow.Cells[1].Value.ToString();
                if(dgvBuoiDieuTri.CurrentRow.Cells[2].Value == null)
                {
                    txtChuanDoan.Text = string.Empty;
                }
                else
                {
                    txtChuanDoan.Text = dgvBuoiDieuTri.CurrentRow.Cells[2].Value.ToString();
                }

                if (dgvBuoiDieuTri.CurrentRow.Cells[3].Value == null)
                {
                    txtChiPhi.Text = string.Empty;
                }
                else
                {
                    txtChiPhi.Text = dgvBuoiDieuTri.CurrentRow.Cells[3].Value.ToString();
                }

                if (dgvBuoiDieuTri.CurrentRow.Cells[6].Value == null)
                {
                    txtGhiChu.Text = string.Empty;
                }
                else
                {
                    txtGhiChu.Text = dgvBuoiDieuTri.CurrentRow.Cells[6].Value.ToString();
                }


                cbBacSi.SelectedValue = int.Parse(dgvBuoiDieuTri.CurrentRow.Cells[4].Value.ToString());
                txtBenhNhan.Text = dgvBuoiDieuTri.CurrentRow.Cells[5].Value.ToString();
                

                idBDT_HinhAnh();
                BDT_DonThuoc();

                txtDonThuoc_BDT.Text = dgvBuoiDieuTri.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception)
            {
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                
                int id = int.Parse(dgvBenhNhan.CurrentRow.Cells[0].Value.ToString());
                
                if (e.RowIndex >= 0)
                {                  
                      dgvBenhNen.DataSource = qlBenhNhan.sp_BenhNen(id);
                }
                dgvBuoiDieuTri.DataSource = qlBenhNhan.BuoiDieuTris.Where(p => p.BenhNhan == id).ToList();
                txtBenhNhan.Text = Convert.ToString(id);

                dataGridView3.DataSource = qlBenhNhan.sp_LocBenhNen(id);

                

                //cbBuoiDieuTri.DataSource = qlBenhNhan.BuoiDieuTris.Where(p => p.BenhNhan == id).ToList();
                //cbBuoiDieuTri.DisplayMember = "id";
                //cbBuoiDieuTri.ValueMember = "id";

                txtChiPhi.Text = "0";
            }
        }

        public void loadDataBDT()
        {
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                int id = int.Parse(txtBenhNhan.Text);
                dgvBuoiDieuTri.DataSource = qlBenhNhan.BuoiDieuTris.Where(p => p.BenhNhan == id).ToList();
            }
        }

        //public void loaadDataBDT()
        //{
        //    using (thuctapEntities qlBenhNhan = new thuctapEntities())
        //    {
        //        dgvBuoiDieuTri.DataSource = qlBenhNhan.BuoiDieuTris.ToList();
        //    }
        //}

        public void loadData()
        {
            using (thuctapEntities qlCTDT = new thuctapEntities())
            {
                dataGridView6.DataSource = qlCTDT.DonThuocs.ToList();
            }
        }

        public void loadDataHinhAnhBDT()
        {
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                dataGridView1.DataSource = qlBenhNhan.HinhAnhDieuTris.ToList();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {

                if(checkNull_BDT() == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    try
                    {
                        BuoiDieuTri buoiDieuTri = new BuoiDieuTri();
                        buoiDieuTri.NgayKham = dtpBuoiDieuTri.Value;
                        buoiDieuTri.ChuanDoan = txtChuanDoan.Text;
                        buoiDieuTri.ChiPhi = int.Parse(txtChiPhi.Text);
                        buoiDieuTri.BacSi = int.Parse(cbBacSi.SelectedValue.ToString());
                        buoiDieuTri.BenhNhan = int.Parse(txtBenhNhan.Text);
                        buoiDieuTri.GhiChu = txtGhiChu.Text;
                        buoiDieuTri.DaThanhToan = false;

                        qlBenhNhan.BuoiDieuTris.Add(buoiDieuTri);
                        qlBenhNhan.SaveChanges();

                        
                        loadDataBDT();
                        refreshForm();
                    }
                    catch (Exception)
                    {
                    }
                }
              
            }
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
            
        }

        private void btnThemHinhAnh_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if(picProduct.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh của buổi điều trị");
                }
                else
                {
                    try
                    {
                        HinhAnhDieuTri hinhAnhBuoiDieuTri = new HinhAnhDieuTri();
                        hinhAnhBuoiDieuTri.Hinh = getImage();
                        hinhAnhBuoiDieuTri.BDT_id = int.Parse(txtID.Text);

                        qlBenhNhan.HinhAnhDieuTris.Add(hinhAnhBuoiDieuTri);
                        qlBenhNhan.SaveChanges();

                        idBDT_HinhAnh();
                        refreshFormHA_BDT();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Vui lòng chọn buổi điều trị để thêm hình ảnh");
                        refreshFormHA_BDT();
                    }
                }              
            }
        }

        private void btnFile_Click_1(object sender, EventArgs e)
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

        

        private void btnThem4_Click(object sender, EventArgs e)
        {

        }


        private void btnThemDonThuoc_Click(object sender, EventArgs e)
        {
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {

                if (txtDonThuoc_BDT.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng chọn buổi điều trị");
                }
                else
                {
                    int BuoiDieuTri = int.Parse(txtDonThuoc_BDT.Text);
                    bool buoiDieuTriDaTonTai = qlBenhNhan.DonThuocs.Any(p => p.BuoiDieuTri == BuoiDieuTri);

                    if (buoiDieuTriDaTonTai)
                    {
                        MessageBox.Show("Buoi dieu tri da ton tai");
                        return;
                    }


                    try
                    {
                        DonThuoc donThuoc = new DonThuoc();

                        donThuoc.BuoiDieuTri = int.Parse(txtDonThuoc_BDT.Text);
                        donThuoc.ThanhTien = 0;
                        donThuoc.DaThanhToan = false;

                        qlBenhNhan.DonThuocs.Add(donThuoc);

                        qlBenhNhan.SaveChanges();

                        BDT_DonThuoc();

                    }
                    catch (Exception)
                    {
                    }
                }
                
                
            }
        }


        private void btnCTDT_Click(object sender, EventArgs e)
        {
            int id_BuoiDieuTri = int.Parse(dataGridView6.CurrentRow.Cells[0].Value.ToString());
            int id_BenhNhan = int.Parse(dgvBuoiDieuTri.CurrentRow.Cells[5].Value.ToString());
            
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                string email = qlBenhNhan.BenhNhans.Find(id_BenhNhan).Email;
                frmChiTietDonThuoc frmchitiethoadon = new frmChiTietDonThuoc(id_BuoiDieuTri, email);
                frmchitiethoadon.Show();
            }
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                int id_BenhNhan = int.Parse(dgvBuoiDieuTri.CurrentRow.Cells[5].Value.ToString());
                using (thuctapEntities qlBenhNhan = new thuctapEntities())
                {
                    try
                    {
                        string email = qlBenhNhan.BenhNhans.Find(id_BenhNhan).Email;
                        int id = int.Parse(txtID.Text);
                        frmThemDichVu frmdichvu = new frmThemDichVu(id, email);
                        frmdichvu.Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Vui lòng chọn buổi điều trị");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để thêm dịch vụ");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string mailKH = "";
            //this.maFile++;
            //int id = int.Parse(txtBenhNhan.Text);
            //using (thuctapEntities quanly = new thuctapEntities())
            //{
            //    mailKH = quanly.BenhNhans.FirstOrDefault(p => p.id == id).Email.ToString();
            //}
            //frmXuatCTDT f = new frmXuatCTDT(this.maFile.ToString());

            //if (f.ShowDialog() == DialogResult.Cancel)
            //{
            //    frmMail mailHoaDon = new frmMail(mailKH, this.maFile.ToString());
            //    mailHoaDon.send();
            //}

            //btnXuatHD.Enabled = false;
            //resetForm();
        }

        private bool checkNull_BDT()
        {

            if (txtChuanDoan.Text.Equals(string.Empty))
            {
                return false;
            }
            if (txtGhiChu.Text.Equals(string.Empty))
            {
                return false;
            }
            return true;
        }

        private void refreshForm()
        {
            txtID.Text = "";
            txtChuanDoan.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if (txtID.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Vui lòng chọn buổi điều trị cần xoá");
                }
                else
                {
                    int id = int.Parse(txtID.Text);
                    try
                    {
                        qlBenhNhan.sp_XoaBDT(id);
                        qlBenhNhan.SaveChanges();


                        loadDataBDT();
                        MessageBox.Show("Đã xoá thành công");
                        refreshForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xoá những buổi diều trị đang thực hiện");
                    }
                    
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if(checkNull_BDT() == false)
                {
                    MessageBox.Show("Vui lòng chọn buổi điều trị cần sửa");
                }
                try
                {
                    int id = int.Parse(txtID.Text);
                    BuoiDieuTri buoiDieuTri = qlBenhNhan.BuoiDieuTris.FirstOrDefault(p => p.id == id);

                    buoiDieuTri.NgayKham = dtpBuoiDieuTri.Value;
                    buoiDieuTri.ChuanDoan = txtChuanDoan.Text;
                    buoiDieuTri.BacSi = int.Parse(cbBacSi.SelectedValue.ToString());
                    buoiDieuTri.GhiChu = txtGhiChu.Text;


                    qlBenhNhan.SaveChanges();
                    loadDataBDT();
                    MessageBox.Show(" Sửa thành công ");
                    refreshForm();
                }
                catch (Exception)
                {
                }
            }
        }
        string idHA_BDT = "";
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idHA_BDT = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                byte[] img = (byte[])dataGridView1.CurrentRow.Cells[1].Value;
                MemoryStream ms = new MemoryStream(img);
                picProduct.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {
                picProduct.Image = null;
            }
        }
        private void refreshFormHA_BDT()
        {
            picProduct.ImageLocation = "";
            this.location = "";
        }
        private void btnXoaHA_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if (this.idHA_BDT.Equals(string.Empty)){
                    MessageBox.Show("Vui lòng chọn hình ảnh cần xoá");
                    return;
                }
                
                try
                {
                    qlBenhNhan.sp_HinhAnhBDT(int.Parse(idHA_BDT));
                    qlBenhNhan.SaveChanges();
                    idBDT_HinhAnh();
                    MessageBox.Show("Đã xoá thành công");
                    this.idHA_BDT = "";
                }
                catch (Exception)
                {
                }
                refreshFormHA_BDT();
                picProduct.Image = null;
            }
        }

        private void btnSuaHA_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if (this.idHA_BDT.Equals(string.Empty))
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh cần sửa");
                    return;
                }

                try
                {
                    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    HinhAnhDieuTri hinhAnhDieuTri = qlBenhNhan.HinhAnhDieuTris.FirstOrDefault(p => p.id == id);
                    if (getImage() == null)
                    {
                        qlBenhNhan.SaveChanges();
                    }
                    else
                    {
                        hinhAnhDieuTri.Hinh = getImage();
                        qlBenhNhan.SaveChanges();
                    }
                    MessageBox.Show("Sửa thành công");
                    idBDT_HinhAnh();
                    refreshFormHA_BDT();

                    
                    //picProduct.Image = null;
                    //this.location = "";
                    //this.idHA_BDT = "";
                }
                catch (Exception)
                {
                }
            }
        }

        private void txtDonThuoc_BDT_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnXoaDonThuoc_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if (this.idDonThuoc.Equals(string.Empty))
                {
                    MessageBox.Show("Vui lòng chọn đơn thuốc cần xoá");
                    return;
                }
                //MessageBox.Show(idDonThuoc);
                try
                {
                    qlBenhNhan.sp_XoaDonThuoc(int.Parse(this.idDonThuoc));
                    qlBenhNhan.SaveChanges();
                    BDT_DonThuoc();
                    MessageBox.Show("Đã xoá thành công");
                    this.idDonThuoc = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Đơn thuốc đã được thanh toán");
                }
                txtDonThuoc_BDT.Text = "";
            }
        }

        string idDonThuoc = "";
        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idDonThuoc = dataGridView6.CurrentRow.Cells[0].Value.ToString();
                txtDonThuoc_BDT.Text = dataGridView6.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnSuaDonThuoc_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchString = txtTimKiem.text.ToString();
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                dgvBenhNhan.DataSource = qlBenhNhan.sp_TimKiemTen(searchString).ToList();
            }
        }

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            //frmQL_LichHen frmQL_LichHen = new frmQL_LichHen();
            //frmQL_LichHen.Show();

        }

        private bool check_Null_BenhNhan()
        {
            if (txtTenBenhNhan.Text.Equals(String.Empty))
            {
                return false;
            }
            if (txtTuoi.Text.Equals(String.Empty))
            {
                return false;
            }
            if (txtEmail.Text.Equals(String.Empty))
            {
                return false;
            }
            if (txtNgheNghiep.Text.Equals(String.Empty))
            {
                return false;
            }
            if (txtSDT.Text.Equals(String.Empty))
            {
                return false;
            }
            if (txtDiaChi.Text.Equals(String.Empty))
            {
                return false;
            }

            return true;
        }

        private void refresh_BenhNhan()
        {
            txtTenBenhNhan.Text = "";
            txtTuoi.Text = "";
            txtNgheNghiep.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            ptbBenhNhan.ImageLocation = "";
            this.location = "";
        }

        int idBenhNhan;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idBenhNhan = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                txtTenBenhNhan.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                cbGioiTinh.SelectedItem = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtTuoi.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                txtNgheNghiep.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                txtSDT.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                txtDiaChi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                cbNguoiTiepNhan.SelectedValue = int.Parse(dataGridView2.CurrentRow.Cells[9].Value.ToString());
                dtpNgayTiepNhan.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();
                try
                {
                    byte[] img = (byte[])dataGridView2.CurrentRow.Cells[8].Value;
                    MemoryStream ms = new MemoryStream(img);
                    ptbBenhNhan.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {
                    ptbBenhNhan.Image = null;
                }

            }
            catch (Exception)
            {
            }
        }

        private void btnChonHinhAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Chọn ảnh sản phẩm";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    location = dlg.FileName.ToString();
                    ptbBenhNhan.ImageLocation = location;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng load ảnh lên!");
            }
        }

        private void load_BenhNhan()
        {
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                dataGridView2.DataSource = qlBenhNhan.BenhNhans.ToList();
            }
        }

        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if (check_Null_BenhNhan() == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    BenhNhan benhNhan = new BenhNhan();
                    benhNhan.TenBenhNhan = txtTenBenhNhan.Text;
                    benhNhan.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                    try
                    {
                        benhNhan.Tuoi = int.Parse(txtTuoi.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tuổi phải là số");
                    }
                    
                    benhNhan.NgheNghiep = txtNgheNghiep.Text;
                    benhNhan.LienHe = txtSDT.Text;
                    benhNhan.Email = txtEmail.Text;
                    benhNhan.DiaChi = txtDiaChi.Text;
                    benhNhan.NguoiTiepNhan = int.Parse(cbNguoiTiepNhan.SelectedValue.ToString());
                    benhNhan.NgayTiepNhan = dtpNgayTiepNhan.Value;
                    if (getImage() == null)
                    {
                        MessageBox.Show("Vui lòng load hình ảnh sản phẩm lên");
                        return;
                    }
                    else
                    {
                        benhNhan.AnhChup = getImage();
                    }

                    qlBenhNhan.BenhNhans.Add(benhNhan);
                    qlBenhNhan.SaveChanges();
                    MessageBox.Show("Thêm thành công");

                    load_BenhNhan();
                    refresh_BenhNhan();
                    ptbBenhNhan.Image = null;
                    frmQuanLyBenhNhan_Load(sender, e);
                }
            }
        }

        private void btnXoaBenhNhan_Click(object sender, EventArgs e)
        {
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if (check_Null_BenhNhan() == false)
                {
                    MessageBox.Show("Vui lòng chọn bệnh nhân cần xoá");
                    return;
                }
                else
                {
                    try
                    {
                        qlBenhNhan.sp_XoaBenhNhan(idBenhNhan);
                        qlBenhNhan.SaveChanges();
                        load_BenhNhan();
                        MessageBox.Show("Xoá thành công");
                        refresh_BenhNhan();
                        ptbBenhNhan.Image = null;
                        frmQuanLyBenhNhan_Load(sender, e);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xoá những bệnh nhân đang điều trị");
                        refresh_BenhNhan();
                        return;
                    }

                }
            }
        }

        private void btnSuaBenhNhan_Click(object sender, EventArgs e)
        {
            using (thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if (check_Null_BenhNhan() == false)
                {
                    MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa");
                    return;
                }
                else
                {
                    try
                    {
                        BenhNhan benhNhan = qlBenhNhan.BenhNhans.FirstOrDefault(p => p.id == idBenhNhan);
                        if (getImage() == null)
                        {
                            benhNhan.TenBenhNhan = txtTenBenhNhan.Text;
                            benhNhan.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                            try
                            {
                                benhNhan.Tuoi = int.Parse(txtTuoi.Text);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Tuổi phải là số");
                            }

                            benhNhan.NgheNghiep = txtNgheNghiep.Text;
                            benhNhan.LienHe = txtSDT.Text;
                            benhNhan.Email = txtEmail.Text;
                            benhNhan.DiaChi = txtDiaChi.Text;
                            benhNhan.NguoiTiepNhan = int.Parse(cbNguoiTiepNhan.SelectedValue.ToString());
                            benhNhan.NgayTiepNhan = dtpNgayTiepNhan.Value;
                            qlBenhNhan.SaveChanges();
                        }
                        else
                        {
                            
                            benhNhan.TenBenhNhan = txtTenBenhNhan.Text;
                            benhNhan.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                            try
                            {
                                benhNhan.Tuoi = int.Parse(txtTuoi.Text);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Tuổi phải là số");
                            }

                            benhNhan.NgheNghiep = txtNgheNghiep.Text;
                            benhNhan.LienHe = txtSDT.Text;
                            benhNhan.Email = txtEmail.Text;
                            benhNhan.DiaChi = txtDiaChi.Text;
                            benhNhan.NguoiTiepNhan = int.Parse(cbNguoiTiepNhan.SelectedValue.ToString());
                            benhNhan.NgayTiepNhan = dtpNgayTiepNhan.Value;
                            benhNhan.AnhChup = getImage();
                            qlBenhNhan.SaveChanges();
                        }



                        load_BenhNhan();
                        refresh_BenhNhan();
                        MessageBox.Show("Sửa thành công");
                        ptbBenhNhan.Image = null;
                        this.location = "";
                        //this.idUser = ;
                        frmQuanLyBenhNhan_Load(sender, e);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void load_BenhNen()
        {
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                dataGridView3.DataSource = qlBenhNhan.sp_LocBenhNen(int.Parse(txtBenhNhan.Text));
            }
        }
        private void btnThemBN_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if (txtBenhNhan.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Vui lòng chọn bệnh nhân cần thêm");
                }
                else
                {
                    try
                    {
                        qlBenhNhan.sp_ThemBenhNen(int.Parse(txtBenhNhan.Text), int.Parse(cbBenhNen.SelectedValue.ToString()));
                        MessageBox.Show("Thêm thành công");
                        load_BenhNen();
                        dgvBenhNen.DataSource = qlBenhNhan.sp_BenhNen(int.Parse(txtBenhNhan.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bệnh nền này đã tồn tại");
                    }
                    
                }
            }
        }
        
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbBenhNen.SelectedValue = int.Parse(dataGridView3.CurrentRow.Cells[1].Value.ToString());
        }

        private void btnXoaBN_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if (txtBenhNhan.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Vui lòng chọn để xoá ");
                }else
                {
                    qlBenhNhan.sp_XoaBenhNen(int.Parse(txtBenhNhan.Text), int.Parse(cbBenhNen.SelectedValue.ToString()));
                    MessageBox.Show("Xoá thành công");
                    load_BenhNen();
                    dgvBenhNen.DataSource = qlBenhNhan.sp_BenhNen(int.Parse(txtBenhNhan.Text));
                }
            }
        }

        private void btnSuaBN_Click(object sender, EventArgs e)
        {
            using( thuctapEntities qlBenhNhan = new thuctapEntities())
            {
                if (txtBenhNhan.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa");
                }
                else
                {
                    try
                    {
                        qlBenhNhan.sp_SuaBenhNen(int.Parse(txtBenhNhan.Text), int.Parse(cbBenhNen.SelectedValue.ToString()));
                        MessageBox.Show("Sửa thành công");
                        load_BenhNen();
                        dgvBenhNen.DataSource = qlBenhNhan.sp_BenhNen(int.Parse(txtBenhNhan.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bệnh nền này đã tồn tại");
                    }

                }
            }
            
        }
    }
}

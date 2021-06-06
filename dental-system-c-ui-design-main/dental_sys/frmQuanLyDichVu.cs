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
    public partial class frmQuanLyDichVu : Form
    {
        public frmQuanLyDichVu()
        {
            InitializeComponent();
        }
        int idDichVu;
        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuctapDataSet.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.thuctapDataSet.DichVu);

        }

        private void load()
        {
            using(thuctapEntities qlDichVu = new thuctapEntities())
            {
                dataGridView1.DataSource = qlDichVu.DichVus.ToList();
            }
        }
        private void refresh()
        {
            txtTenDichVu.Text = "";
            txtGiaDichVu.Text = "";
        }
        private bool checkNull()
        {
            if(txtTenDichVu.Text.Equals(string.Empty))
            {
                return false;
            }
            if (txtGiaDichVu.Text.Equals(null))
            {
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (thuctapEntities qlDichVu = new thuctapEntities())
            {

                if (checkNull() == false)
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin vui lòng nhập lại");
                }
                else
                {
                    DichVu dichVu = new DichVu();
                    dichVu.TenDichVu = txtTenDichVu.Text;
                    try
                    {
                        dichVu.GiaDichVu = int.Parse(txtGiaDichVu.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Giá dịch vụ phải là số");
                        return;
                    }

                    qlDichVu.DichVus.Add(dichVu);
                    qlDichVu.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    load();
                    refresh();
                }               
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idDichVu = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtTenDichVu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtGiaDichVu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlDichVu = new thuctapEntities())
            {
                if (idDichVu.Equals(null))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xoá");
                }
                else
                {
                    try
                    {
                        dataGridView1.DataSource = qlDichVu.sp_XoaDichVu(idDichVu);
                        MessageBox.Show("Xoá thành công");
                        load();
                        refresh();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dịch vụ này đang được khách hàng sử dụng");
                        refresh();
                    }
                    
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using(thuctapEntities qlDichVu = new thuctapEntities())
            {
                if (idDichVu.Equals(null))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xoá");
                }
                else
                {
                    try
                    {
                        DichVu dichVu = qlDichVu.DichVus.FirstOrDefault(p => p.id == idDichVu);
                        dichVu.TenDichVu = txtTenDichVu.Text;
                        try
                        {
                            dichVu.GiaDichVu = int.Parse(txtGiaDichVu.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Giá dịch vụ phải là số");
                            return;
                        }

                        qlDichVu.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                        load();
                        refresh();
                    }
                    catch (Exception)
                    {

                    }
                    
                }
            }
        }
    }
}

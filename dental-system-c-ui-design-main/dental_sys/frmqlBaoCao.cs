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
    public partial class frmqlBaoCao : Form
    {
        public frmqlBaoCao()
        {
            InitializeComponent();
        }
        int sumTongBDT = 0;
        int sumTongDT = 0;
        int sumTongThu = 0;
        int TongThu = 0;
        int sumTongVL = 0;
        int sumTongChi = 0;
        int sumTongTraLuong = 0;
        int Tongchi = 0;
        private void frmqlBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuctapDataSet.DonThuoc' table. You can move, or remove it, as needed.
            this.donThuocTableAdapter.Fill(this.thuctapDataSet.DonThuoc);


            // TODO: This line of code loads data into the 'thuctapDataSet1.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.thuctapDataSet1.DichVu);

            using (thuctapEntities qlBaoCao = new thuctapEntities())
            {
                cbDichVu.DataSource = qlBaoCao.DichVus.ToList();
                cbDichVu.DisplayMember = "TenDichVu";
                cbDichVu.ValueMember = null;

                cbBuoiDieuTri.SelectedIndex = 0;
                cbBuoiDieuTri.DropDownStyle = ComboBoxStyle.DropDownList;


                txtTongTienBDT.Text = sumTongBDT.ToString();
                txtTongTienDT.Text = sumTongDT.ToString();
                txtTongTienThu.Text = sumTongThu.ToString();
                lbTongThu.Text = TongThu.ToString();

                txtChiVL.Text = sumTongVL.ToString();
                txtChi.Text = sumTongChi.ToString();
                txtChiTraLuong.Text = sumTongTraLuong.ToString();
                lbTongChi.Text = Tongchi.ToString();
            }

        }
     

        private void cbDichVu_SelectedValueChanged_1(object sender, EventArgs e)
        {
            DichVu dichVu = (DichVu)cbDichVu.SelectedValue;
            int idDichVu = dichVu.id;
            using (thuctapEntities qlBaoCao = new thuctapEntities())
            {
                dataGridView1.DataSource = qlBaoCao.sp_BaoCaoTheoDichVu(idDichVu).ToList();
            }
        }

        private void cbBuoiDieuTri_SelectedValueChanged(object sender, EventArgs e)
        {
            using (thuctapEntities qlBaoCao = new thuctapEntities())
            {
                MessageBox.Show(cbBuoiDieuTri.SelectedIndex.ToString());

                if (int.Parse(cbBuoiDieuTri.SelectedIndex.ToString()) == 1)
                {
                    dgvBenhNhan.DataSource = qlBaoCao.sp_BenhNhan_BDT().ToList();
                }
                if (int.Parse(cbBuoiDieuTri.SelectedIndex.ToString()) == 2)
                {
                    dgvBenhNhan.DataSource = qlBaoCao.sp_BenhNhan_not_BDT().ToList();
                }

            }
        }

        private void dtpNgayTiepNhan_ValueChanged(object sender, EventArgs e)
        {
            using(thuctapEntities qlBaoCao = new thuctapEntities())
            {
                if(int.Parse(cbBuoiDieuTri.SelectedIndex.ToString()) == 0)
                {
                    dgvBenhNhan.DataSource = qlBaoCao.sp_BenhNhanTiepNhan_BDT(dtpNgayTiepNhan.Value).ToList();
                }
                if(int.Parse(cbBuoiDieuTri.SelectedIndex.ToString()) == 1)
                {
                    dgvBenhNhan.DataSource = qlBaoCao.sp_BenhNhanTiepNhan_BDT_have(dtpNgayTiepNhan.Value).ToList();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (thuctapEntities qlBaoCao = new thuctapEntities())
            {

                try
                {
                    dgvThuBDT.DataSource = qlBaoCao.sp_TongTienBDT(dtpDayStart.Value, dtpDayEnd.Value).ToList();
                    dgvDonThuoc.DataSource = qlBaoCao.sp_TongTienDT(dtpDayStart.Value, dtpDayEnd.Value).ToList();
                    dgvThu.DataSource = qlBaoCao.sp_TongTienThu(dtpDayStart.Value, dtpDayEnd.Value).ToList();



                    for (int i = 0; i < dgvThuBDT.Rows.Count; i++)
                    {
                        sumTongBDT += int.Parse(dgvThuBDT.Rows[i].Cells[2].Value.ToString());
                    }

                    txtTongTienBDT.Text = Convert.ToString(sumTongBDT);

                    for (int i = 0; i < dgvDonThuoc.Rows.Count; i++)
                    {
                        sumTongDT += int.Parse(dgvDonThuoc.Rows[i].Cells[1].Value.ToString());
                    }

                    txtTongTienDT.Text = Convert.ToString(sumTongDT);

                    for (int i = 0; i < dgvThu.Rows.Count; i++)
                    {
                        sumTongThu += int.Parse(dgvThu.Rows[i].Cells[1].Value.ToString());
                    }

                    txtTongTienThu.Text = Convert.ToString(sumTongThu);


                    lbTongThu.Text = (sumTongBDT + sumTongDT + sumTongThu).ToString();
                }
                catch (Exception)
                {
                }
                
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (thuctapEntities qlBaoCao = new thuctapEntities())
            {

                try
                {
                    dgvVatLieu.DataSource = qlBaoCao.sp_TongTienVatLieu(dtpStart.Value, dtpEnd.Value).ToList();
                    dgvChi.DataSource = qlBaoCao.sp_TongTienChi(dtpStart.Value, dtpEnd.Value).ToList();
                    dgvTraLuong.DataSource = qlBaoCao.sp_TongTienNhanVien(dtpStart.Value, dtpEnd.Value).ToList();



                    for (int i = 0; i < dgvVatLieu.Rows.Count; i++)
                    {
                        sumTongVL += int.Parse(dgvVatLieu.Rows[i].Cells[3].Value.ToString());
                    }

                    txtChiVL.Text = Convert.ToString(sumTongVL);

                    for (int i = 0; i < dgvChi.Rows.Count; i++)
                    {
                        sumTongChi += int.Parse(dgvChi.Rows[i].Cells[1].Value.ToString());
                    }

                    txtChi.Text = Convert.ToString(sumTongChi);

                    for (int i = 0; i < dgvTraLuong.Rows.Count; i++)
                    {
                        sumTongTraLuong += int.Parse(dgvTraLuong.Rows[i].Cells[3].Value.ToString());
                    }

                    txtChiTraLuong.Text = Convert.ToString(sumTongTraLuong);


                    lbTongChi.Text = (sumTongVL + sumTongChi + sumTongTraLuong).ToString();
                }
                catch (Exception)
                {
                }
                
            }
        }

        private void ToExcel(DataGridView dataGridView, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Thống kê doanh thu";

                // Export header
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                // Export content

                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 3, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Save work book
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất file Excels thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvBenhNhan, saveFileDialog1.FileName);
            }
        }
    }
}

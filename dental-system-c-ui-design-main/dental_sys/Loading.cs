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
    public partial class Loading : Form
    {
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
        public Loading(int idUser, bool qlLichHen, bool qlBenhNhan, bool XemCaTruc, bool qlDichVu, bool qlCatruc, bool qlNhanSu, bool qlLuong, bool qlVatLieu, bool qlThuChi, bool qlBaoCao)
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2CircleProgressBar1.Value==100)
            {
                timer1.Stop();

                frmQuanLy p = new frmQuanLy(idUser, qlLichHen, qlBenhNhan, XemCaTruc, qlDichVu, qlCatruc, qlNhanSu, qlLuong, qlVatLieu, qlThuChi, qlBaoCao);
                p.Show();
                this.Hide();

            }
            else
            { 
            guna2CircleProgressBar1.Value += 1;
            label_val.Text = (Convert.ToInt32(label_val.Text) + 1).ToString();
             }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }
    }
}

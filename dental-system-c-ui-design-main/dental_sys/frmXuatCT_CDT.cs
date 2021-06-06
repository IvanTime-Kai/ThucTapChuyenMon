using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class frmXuatCT_CDT : Form
    {
        private int id;
        string mailKH;
        public frmXuatCT_CDT()
        {
            InitializeComponent();
        }
        public frmXuatCT_CDT(int id, string mailKH)
        {
            this.maBDT = id;
            InitializeComponent();
            this.mailKH = mailKH;

        }
        private string maFile;
        public frmXuatCT_CDT(string maFile)
        {
            InitializeComponent();
            this.maFile = maFile;
        }

        public int maBDT { get => id; set => id = value; }

        private void frmXuatCT_CDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2, id);

            this.reportViewer1.RefreshReport();
            ExportToPDF();
        }

        public void ExportToPDF()
        {
            Microsoft.Reporting.WinForms.Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;
            byte[] bytes = new byte[1024];

            bytes = this.reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);
            string fileName = @"D:\Aplication\HoaDonBaiTapLon\DichVu_" + maFile + ".pdf";
            File.WriteAllBytes(fileName, bytes);
            Process pr = Process.Start(fileName);
            pr.Close();

            frmMail emailCTDT = new frmMail(this.mailKH, maFile);
            emailCTDT.send();
        }
    }
}

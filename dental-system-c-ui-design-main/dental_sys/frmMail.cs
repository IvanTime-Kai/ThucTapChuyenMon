using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace dental_sys
{
    public partial class frmMail : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        Attachment attch = null;
        private string mailKH;
        private string maFile;
        public frmMail(string mailKH, string maFile)
        {
            InitializeComponent();
            this.mailKH = mailKH;
            this.maFile = maFile;
            txtTo.Text = this.mailKH;
            textBox1.Text = @"D:\Aplication\HoaDonBaiTapLon\HoaDon_" + maFile + ".pdf";
        }
        thuctapEntities quanlichuan = new thuctapEntities();

        private void frmMail_Load(object sender, EventArgs e)
        {         
            txtTo.DisplayMember = "Email";
            txtTo.ValueMember = "id";
            txtTo.DataSource = quanlichuan.BenhNhans.ToList();
        }
        public void send()
        {
            attch = null;
            try
            {
                FileInfo file = new FileInfo(textBox1.Text);
                attch = new Attachment(textBox1.Text);
            }
            catch (Exception ex)
            {

            }
            login = new NetworkCredential(txtussename.Text = "trungtamnhakhoa74", txtPassword.Text = "trungtamnhakhoa74.pass");
            client = new SmtpClient(txtSmtp.Text);
            client.Port = Convert.ToInt32(txtPort.Text);
            client.EnableSsl = chkssl.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txtussename.Text + txtSmtp.Text.Replace("smtp.", "@"), "Ivantime", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtTo.Text));
            msg.Attachments.Add(attch);
            if (!string.IsNullOrEmpty(txtTo.Text))
            {
                // msg.To.Add(new MailAddress(txtCC.Text));
                msg.Subject = txtSubject.Text;
                msg.Body = txtMessage.Text;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompleteCallback);
                string usetate = "Sending...";
                client.SendAsync(msg, usetate);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            send();
        }

        private void SendCompleteCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (attch != null)
            {
                msg.Attachments.Add(attch);
            }
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Your message has been successfully sent.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
        }

        private void txtTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMail_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuctapDataSet.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter.Fill(this.thuctapDataSet.BenhNhan);

        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace dental_sys
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int maxn = 0;
        private void btnGui_Click(object sender, EventArgs e)
        {
            if (txtGmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mail.");
                return;
            }
            string emailUser = txtGmail.Text.Trim();

            SqlConnection connect = ConnectProvider.GetConnection(); connect.Open();
            SqlCommand command;
            SqlDataReader dataReader;

            string query = string.Format("select * from Users where Email = '{0}'", emailUser);
            command = new SqlCommand(query, connect);
            dataReader = command.ExecuteReader(); dataReader.Read();

            if (!dataReader.HasRows) {
                MessageBox.Show("Email không tồn tại!", "Cảnh báo!");
                return;
            }

            int id = dataReader.GetInt32(0);

            connect.Close();


            Console.WriteLine(emailUser);
            if (emailUser.Equals(txtGmail.Text))
            {
                String txttendangnhap = "trungtamnhakhoa74@gmail.com";
                String txtmk = "trungtamnhakhoa74.pass";
                string email = txtGmail.Text;
                maxn = random.Next(1000, 9999);
                MailMessage mail = new MailMessage(txttendangnhap, email, "Mã xác nhận", maxn.ToString());
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Host = "smtp.gmail.com";
                client.UseDefaultCredentials = false;
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(txttendangnhap, txtmk);
                client.EnableSsl = true;
                client.Send(mail);
                frmotp ma = new frmotp();
                ma.otp = maxn;
                ma.id = id;
                this.Hide();
                ma.ShowDialog();

            }
            else
            {
                MessageBox.Show("Gmail không đúng", "Thông  Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

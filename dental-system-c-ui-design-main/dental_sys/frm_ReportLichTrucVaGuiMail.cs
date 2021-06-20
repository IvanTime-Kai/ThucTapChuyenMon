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
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;

namespace dental_sys
{
    public partial class frm_ReportLichTrucVaGuiMail : Form
    {
        int bacSiId;
        string PARAMETER = "@userId";
        const string GMAIL_USERNAME = "trungtamnhakhoa74";
        const string GMAIL_PASSWORD = "trungtamnhakhoa74.pass";
        public frm_ReportLichTrucVaGuiMail(int bacSiId)
        {
            InitializeComponent();
            this.bacSiId = bacSiId;
        }

        private void loadDataToReport()
        {
            // Lấy dữ liệu ngày trực của bác sĩ (bacsiId) từ database bằng StoredProcedure để tạo
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "sp_NhungCaTruc";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = con;
            command.Parameters.Add(new SqlParameter(PARAMETER, this.bacSiId));
            // Khai báo dataset để chứa dữ liệu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(ds);

            // Thiếp lập báo cáo
            rpvLichTruc.ProcessingMode = ProcessingMode.Local;
            rpvLichTruc.LocalReport.ReportPath = "rptNhungCaTruc.rdlc";

            // nếu có bản ghi thì load dữ liệu vào và enable nút Xác nhận
            if (ds.Tables[0].Rows.Count > 0)
            {
                btnXacNhan.Enabled = true;

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "NhungCaTrucSapToiCuaMotBacSi_DataSet";
                rds.Value = ds.Tables[0];
                // Gắn lên report viewer
                rpvLichTruc.LocalReport.DataSources.Clear();
                rpvLichTruc.LocalReport.DataSources.Add(rds);
                rpvLichTruc.Controls[0].Dock = DockStyle.Fill;
                this.rpvLichTruc.RefreshReport();
            }

            con.Close();
        }

        private void frm_ReportLichTrucVaGuiMail_Load(object sender, EventArgs e)
        {
            loadDataToReport();
            this.rpvLichTruc.RefreshReport();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            Microsoft.Reporting.WinForms.Warning[] warnings;
            string[] streamids;
            string mimetype;
            string encoding;
            string filenameExtension;
            string directoryPath = Application.StartupPath + "\\LichTruc\\";
            string fileName = "LichTruc.pdf";
            string des = directoryPath + fileName;
            byte[] bytes = new byte[1024];

            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            //DateTime now = DateTime.Now;
            //string current = now.Date.Year.ToString() + now.Date.Month + now.Date.Day + now.Date.Hour + now.Date.Minute + now.Date.Second;

            //string fileName = string.Format("LichTruc_{0}_{1}.pdf", this.bacSiId, current);
            try
            {
                bytes = rpvLichTruc.LocalReport.Render("PDF", null, out mimetype, out encoding, out filenameExtension, out streamids, out warnings);
                File.WriteAllBytes(des, bytes);
                Process pr = Process.Start(des);
                pr.Close();
            }
            catch (Exception ex)
            {

            }


            if (cbGuiEmail.Checked)
            {
                // chuẩn bị email
                string smtp = "smtp.gmail.com";
                NetworkCredential login = new NetworkCredential(GMAIL_USERNAME, GMAIL_PASSWORD); // cung cấp thông tin xác nhận dựa trên mật khẩu
                SmtpClient client = new SmtpClient(smtp); // cho phép ứng dụng gửi email thông qua phương thức smtp
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = login;
                MailMessage msg; // biểu diễn tin nhắn email cần gửi
                msg = new MailMessage { From = new MailAddress(GMAIL_USERNAME + smtp.Replace("smtp.", "@"), "Trung Tâm Nha Khoa", Encoding.UTF8) };
                msg.Subject = "Đây là những ca trực của bạn trong thời gian tới!";
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                Attachment attachment = new Attachment(des);
                msg.Attachments.Add(attachment);

                // lấy email của bác sĩ để gửi
                SqlConnection con = ConnectProvider.GetConnection(); con.Open();
                SqlDataReader sqlDataReader; SqlCommand command;
                DateTime toDay = DateTime.Now.Date;
                string query = "select Email ";
                query += "from Users ";
                query += string.Format("where id={0}", bacSiId);
                command = new SqlCommand(query, con);
                sqlDataReader = command.ExecuteReader(); sqlDataReader.Read();
                string emailBacSi = sqlDataReader.GetString(0);

                //
                msg.To.Add(new MailAddress(emailBacSi));

                client.Send(msg);
            }

            this.Close();
        }
    }
}

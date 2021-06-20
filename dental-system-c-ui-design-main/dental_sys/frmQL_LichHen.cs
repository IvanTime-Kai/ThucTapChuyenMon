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
using System.Net;
using System.Net.Mail;

namespace dental_sys
{
    public partial class frmQL_LichHen : Form
    {
        const string HOAN_THANH = "Hoàn Thành";
        const string CHUA_HOAN_THANH = "Chưa Hoàn Thành";
        const string WARNING = "Warning!";
        const string TEN_BAC_SI = "TenBacSi";
        const string TEN_BENH_NHAN = "TenBenhNhan";
        const string NGAY_HEN = "NgayHen";
        const string CA = "Ca";
        const string NOI_DUNG = "NoiDung";
        const string TRANG_THAI = "TrangThai";
        const string ID = "Id";
        const string NONE = "None";

        const string GMAIL_USERNAME = "trungtamnhakhoa74";
        const string GMAIL_PASSWORD = "trungtamnhakhoa74.pass";
        int selectedCuocHenId = 0;
        int currentBacsiId;
        public frmQL_LichHen(int currentBacSiId)
        {
            InitializeComponent();
            this.currentBacsiId = currentBacSiId;
        }

        private void resetData()
        {
            selectedCuocHenId = 0;
            cbTenBacSi.SelectedIndex = 0;
            cbTenBenhNhan.SelectedIndex = 0;
            dtpNgayHen.Value = DateTime.Now.Date;
            cbCa.SelectedIndex = 0;
            txtNoiDung.Text = string.Empty;
            cbTrangThai.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Now.AddDays(-10).Date;
            dtpTo.Value = DateTime.Now.AddDays(10).Date;
        }

        private void setUp()
        {
            // custom controls
            dgv_LichHen.ReadOnly = true;
            dgv_LichHen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgv_LichHen.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv_LichHen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_LichHen.MultiSelect = false;
            dgv_LichHen.BackgroundColor = Color.White;
            dgv_LichHen.RowHeadersVisible = false;
            dgv_LichHen.AllowUserToResizeRows = false;


            cbTenBacSi.DropDownStyle = ComboBoxStyle.DropDownList; cbTenBenhNhan.DropDownStyle = ComboBoxStyle.DropDownList; cbCa.DropDownStyle = ComboBoxStyle.DropDownList; cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList; cbSapXep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCa.SelectedIndex = 0; cbTrangThai.SelectedIndex = 1; cbSapXep.SelectedIndex = 0;

            // format datetimepicker
            dtpNgayHen.Format = DateTimePickerFormat.Custom;
            dtpNgayHen.CustomFormat = "dd-MM-yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "dd-MM-yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "dd-MM-yyyy";
            dtpFrom.Value = DateTime.Now.AddDays(-10).Date;
            dtpTo.Value = DateTime.Now.AddDays(10).Date;

            // load data to comboBox
            loadBacSi();
            loadBenhNhan();

            // load data to gridview
            loadLichHen(string.Empty, null, null);
            dgv_LichHen.Columns[ID].Visible = false;
        }

        private void frmQL_LichHen_Load(object sender, EventArgs e)
        {
            setUp();

            sendEmailToCustomers();
        }

        private static void sendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled || e.Error != null)
            {
                MessageBox.Show("Gửi email cho khách hàng không thành công!");
            }
            else
            {
                MessageBox.Show("Gửi email cho khách hàng thành công!");
            }
        }

        private void sendEmailToCustomers()
        {
            string smtp = "smtp.gmail.com";
            NetworkCredential login = new NetworkCredential(GMAIL_USERNAME, GMAIL_PASSWORD); // cung cấp thông tin xác nhận dựa trên mật khẩu
            SmtpClient client = new SmtpClient(smtp); // cho phép ứng dụng gửi email thông qua phương thức smtp
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            MailMessage msg; // biểu diễn tin nhắn email cần gửi
            msg = new MailMessage { From = new MailAddress(GMAIL_USERNAME + smtp.Replace("smtp.", "@"), "Trung Tâm Nha Khoa", Encoding.UTF8) };
            msg.Subject = "Trung tâm nha khoa nhắc nhở!";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(sendCompletedCallback);

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand command;
            DateTime tomorrow = DateTime.Now.Date.AddDays(1);
            string query = "select BenhNhan.TenBenhNhan, BenhNhan.Email, CuocHen.NoiDung, CuocHen.Ca, CuocHen.id ";
            query += "from CuocHen inner join BenhNhan on CuocHen.BenhNhan = BenhNhan.id ";
            query += string.Format("where NgayHen = '{0}' AND DaGuiEmail = 0", tomorrow);
            command = new SqlCommand(query, con);
            sqlDataReader = command.ExecuteReader();

            if (sqlDataReader.HasRows) // kiểm tra nếu có cuộc hẹn chưa được gửi mail
            {
                while (sqlDataReader.Read())
                {  // gửi mail nhắc lịch hẹn cho khách hàng ngày mai
                    msg.To.Clear();
                    string tenBenhNhan = sqlDataReader.GetString(0);
                    string emailBenhNhan = sqlDataReader.GetString(1);
                    string noiDungCuocHen = sqlDataReader.GetString(2);
                    string ca = sqlDataReader.GetString(3);
                    int cuochenId = sqlDataReader.GetInt32(4);

                    string tinNhan = string.Format("<h2>Xin chào {0}!</h2> <p>Đừng quên ngày mai bạn có buổi hẹn với phòng khám nha khoa vào lúc {1}</p>", tenBenhNhan, (ca.Equals("1") ? "7h30" : "1h30"));
                    tinNhan += string.Format("<p><strong>Nội dung:</strong> {0}</p> <p>Xin cảm ơn!</p>", noiDungCuocHen);
                    msg.Body = tinNhan;
                    msg.To.Add(new MailAddress(emailBenhNhan));
                    client.Send(msg);
                }
                con.Close();

                con = ConnectProvider.GetConnection(); con.Open();
                string update = string.Format("update CuocHen set DaGuiEmail = 1 where NgayHen = '{0}'", tomorrow);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand(update, con);
                adapter.UpdateCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Gửi mail thành công!");
            }
        }

        private bool validateFormInsert()
        {
            DateTime ngayHen = dtpNgayHen.Value;
            string noiDung = txtNoiDung.Text.Trim();
            string trangThai = cbTrangThai.Text;
            if (DateTime.Compare(ngayHen.Date, DateTime.Now.Date) < 0)
            {
                return false;
            }
            else if (noiDung.Equals(string.Empty))
            {
                return false;
            }
            else if (trangThai.Equals(HOAN_THANH))
            {
                return false;
            }

            return true;
        }

        private bool kiemTraTrungLichInsert(string tenBacSiForm, string tenBenhNhanForm, DateTime ngayHenForm, string caForm) // kiểm tra bác sĩ hoặc bệnh nhân có bị trùng lịch?
        {
            foreach (DataGridViewRow row in dgv_LichHen.Rows)
            {
                string tenBacSi = row.Cells[TEN_BAC_SI].Value.ToString();
                string tenBenhNhan = row.Cells[TEN_BENH_NHAN].Value.ToString();

                if (tenBacSi.Equals(tenBacSiForm) || tenBenhNhan.Equals(tenBenhNhanForm))
                {
                    DateTime ngayHen = (DateTime)row.Cells[NGAY_HEN].Value;
                    string ca = row.Cells[CA].Value.ToString();

                    if (ngayHen.Equals(ngayHenForm) && ca.Equals(caForm))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool kiemTraTrungLichUpdate(string tenBacSiForm, string tenBenhNhanForm, DateTime ngayHenForm, string caForm) // kiểm tra bác sĩ hoặc bệnh nhân có bị trùng lịch?
        {
            foreach (DataGridViewRow row in dgv_LichHen.Rows)
            {
                string tenBacSi = row.Cells[TEN_BAC_SI].Value.ToString();
                string tenBenhNhan = row.Cells[TEN_BENH_NHAN].Value.ToString();
                int id = (Int32)row.Cells[ID].Value;

                if ((tenBacSi.Equals(tenBacSiForm) || tenBenhNhan.Equals(tenBenhNhanForm)) && id != selectedCuocHenId)
                {
                    DateTime ngayHen = (DateTime)row.Cells[NGAY_HEN].Value;
                    string ca = row.Cells[CA].Value.ToString();

                    if (ngayHen.Equals(ngayHenForm) && ca.Equals(caForm))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void loadBacSi()
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            List<BacSiADO> bacSiList = new List<BacSiADO>();
            string query = "select Users.Ten, Users.id ";
            query += "from Users inner join Roles on Roles.id = Users.Chucvu ";
            query += "where Roles.role_name = N'Bác sĩ' ";
            SqlDataReader sqlDataReader; SqlCommand command = new SqlCommand(query, con);
            sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                string tenBacSi = sqlDataReader.GetString(0);
                int id = sqlDataReader.GetInt32(1);

                bacSiList.Add(new BacSiADO(tenBacSi, id));
            }

            cbTenBacSi.DataSource = bacSiList;

            cbTenBacSi.DisplayMember = TEN_BAC_SI;
            cbTenBacSi.ValueMember = ID;

            con.Close();
        }

        private void loadBenhNhan()
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            List<BenhNhanADO> benhNhanList = new List<BenhNhanADO>();
            string query = "select TenBenhNhan, id from BenhNhan";
            SqlDataReader sqlDataReader; SqlCommand command = new SqlCommand(query, con);
            sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                string tenBenhNhan = sqlDataReader.GetString(0);
                int id = sqlDataReader.GetInt32(1);

                benhNhanList.Add(new BenhNhanADO(tenBenhNhan, id));
            }

            cbTenBenhNhan.DataSource = benhNhanList;

            cbTenBenhNhan.DisplayMember = TEN_BENH_NHAN;
            cbTenBenhNhan.ValueMember = ID;

            con.Close();
        }

        private void loadLichHen(string orderBy, DateTime? from, DateTime? to)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            List<LichHenADO> cuocHenList = new List<LichHenADO>();
            string query = "select Users.Ten, BenhNhan.TenBenhNhan, CuocHen.NgayHen, CuocHen.Ca, CuocHen.NoiDung, CuocHen.TrangThai, CuocHen.id ";
            query += "from CuocHen inner join Users on CuocHen.BacSi = Users.id inner join BenhNhan on BenhNhan.id = CuocHen.BenhNhan inner join Roles on Roles.id = Users.Chucvu ";
            query += "where Roles.role_name = N'Bác sĩ' ";

            if (from != null && to != null)
            {
                query += string.Format("AND (CuocHen.NgayHen BETWEEN '{0}' AND '{1}') ", from, to);
            }

            if (!orderBy.Equals(string.Empty))
                query += string.Format("order by {0}", orderBy);

            SqlDataReader sqlDataReader; SqlCommand command = new SqlCommand(query, con);
            sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                string tenBacSi = sqlDataReader.GetString(0);
                string tenBenhNhan = sqlDataReader.GetString(1);
                DateTime ngayHen = sqlDataReader.GetDateTime(2);
                string Ca = (string)sqlDataReader.GetValue(3);
                string noiDung = sqlDataReader.GetString(4);
                string trangThai = sqlDataReader.GetString(5);
                int id = sqlDataReader.GetInt32(6);

                cuocHenList.Add(new LichHenADO(id, tenBacSi, tenBenhNhan, ngayHen, Ca, noiDung, trangThai));
            }

            dgv_LichHen.DataSource = cuocHenList;
            con.Close();
        }

        private void dgv_LichHen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0)
            {
                int selectedRowIndex = dgv_LichHen.SelectedRows[0].Index;

                string tenBacSi = dgv_LichHen.Rows[selectedRowIndex].Cells[TEN_BAC_SI].Value.ToString();
                string tenBenhNhan = dgv_LichHen.Rows[selectedRowIndex].Cells[TEN_BENH_NHAN].Value.ToString();
                DateTime ngayHen = (DateTime)dgv_LichHen.Rows[selectedRowIndex].Cells[NGAY_HEN].Value;
                string Ca = (string)dgv_LichHen.Rows[selectedRowIndex].Cells[CA].Value.ToString();
                string noiDung = dgv_LichHen.Rows[selectedRowIndex].Cells[NOI_DUNG].Value.ToString();
                string trangThai = dgv_LichHen.Rows[selectedRowIndex].Cells[TRANG_THAI].Value.ToString();
                int id = (Int32)dgv_LichHen.Rows[selectedRowIndex].Cells[ID].Value;


                cbTenBacSi.Text = tenBacSi;
                cbTenBenhNhan.Text = tenBenhNhan;
                dtpNgayHen.Value = ngayHen;
                cbCa.Text = Ca;
                txtNoiDung.Text = noiDung;
                cbTrangThai.Text = trangThai;
                selectedCuocHenId = id;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private string getCurrentOrderBy()
        {
            string selectedText = cbSapXep.Text;
            string orderBy = string.Empty;
            if (selectedText.Equals("Bác sĩ"))
            {
                orderBy = "Ten";
            }
            else if (selectedText.Equals("Bệnh nhân"))
            {
                orderBy = "TenBenhNhan";
            }
            else if (selectedText.Equals("Ngày hẹn"))
            {
                orderBy = "NgayHen";
            }

            return orderBy;
        }

        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLichHen(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value);
        }

        private void btnDanhDau_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!validateFromTo(dtpFrom.Value, dtpTo.Value))
            {
                MessageBox.Show("Thao tác không hợp lệ", WARNING);
                dtpFrom.Value = DateTime.Now.Date;
                dtpTo.Value = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day + 1).Date;
                return;
            }
            loadLichHen(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value);
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (!validateFromTo(dtpFrom.Value, dtpTo.Value))
            {
                MessageBox.Show("Thao tác không hợp lệ", WARNING);
                dtpFrom.Value = DateTime.Now.Date;
                dtpTo.Value = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day + 1).Date;
                // loadLichHen(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value); bỏ dòng này
                return;
            }
            loadLichHen(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value);
        }

        private bool validateFromTo(DateTime from, DateTime to)
        {
            return (DateTime.Compare(from, to) > 0) ? false : true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            // get data from form
            int bacSiId = (Int32)cbTenBacSi.SelectedValue;
            int benhNhanId = (Int32)cbTenBenhNhan.SelectedValue;
            DateTime ngayHenForm = dtpNgayHen.Value.Date;
            string caForm = cbCa.Text;
            string noiDung = txtNoiDung.Text.Trim();
            string trangThai = cbTrangThai.Text.Trim();

            string tenBacSiForm = cbTenBacSi.Text;
            string tenBenhNhanForm = cbTenBenhNhan.Text;

            // validate data
            if (!validateFormInsert())
            {
                MessageBox.Show("Thông tin form chưa hợp lệ!", WARNING);
                return;
            }

            if (!kiemTraTrungLichInsert(tenBacSiForm, tenBenhNhanForm, ngayHenForm, caForm))
            {
                MessageBox.Show("Bác sĩ hoặc bệnh nhân đã trùng lịch!", WARNING);
                return;
            }


            //insert
            string insertCommand = string.Format("insert into CuocHen(BacSi, BenhNhan, NgayHen, Ca, TrangThai, NoiDung, DaGuiEmail) values ({0}, {1}, '{2}', '{3}', N'{4}', N'{5}', 0)", bacSiId, benhNhanId, ngayHenForm, caForm, trangThai, noiDung);
            sqlDataAdapter.InsertCommand = new SqlCommand(insertCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            loadLichHen(string.Empty, null, null);
            resetData();
            con.Close();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (selectedCuocHenId == 0)
            {
                MessageBox.Show("Vui lòng chọn cuộc hẹn để chỉnh sửa!", WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            // get data from form
            int bacSiId = (Int32)cbTenBacSi.SelectedValue;
            int benhNhanId = (Int32)cbTenBenhNhan.SelectedValue;
            DateTime ngayHenForm = dtpNgayHen.Value.Date;
            string caForm = cbCa.Text;
            string noiDung = txtNoiDung.Text.Trim();
            string trangThai = cbTrangThai.Text.Trim();

            string tenBacSiForm = cbTenBacSi.Text;
            string tenBenhNhanForm = cbTenBenhNhan.Text;

            if (!kiemTraTrungLichUpdate(tenBacSiForm, tenBenhNhanForm, ngayHenForm, caForm))
            {
                MessageBox.Show("Bác sĩ hoặc bệnh nhân đã trùng lịch!", WARNING);
                return;
            }

            if ((DateTime.Compare(ngayHenForm.Date, DateTime.Now.Date) > 0) && trangThai.Equals(HOAN_THANH))
            {
                MessageBox.Show("Chỉnh sửa ngày hẹn và trạng thái không hợp lệ", WARNING);
                return;
            }

            //update
            string rawUpdateCommand = "update CuocHen ";
            rawUpdateCommand += "set BacSi = {0}, BenhNhan = {1}, NgayHen = '{2}', Ca = N'{3}', TrangThai = N'{4}', NoiDung = N'{5}' ";
            rawUpdateCommand += "where id = {6}";
            string updateCommand = string.Format(rawUpdateCommand, bacSiId, benhNhanId, ngayHenForm, caForm, trangThai, noiDung, selectedCuocHenId);
            sqlDataAdapter.InsertCommand = new SqlCommand(updateCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();


            loadLichHen(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value);
            resetData();
            con.Close();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (selectedCuocHenId == 0)
            {
                MessageBox.Show("Vui lòng chọn cuộc hẹn xoá!", WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string deleteCommand = string.Format("delete from CuocHen where id = {0}", selectedCuocHenId);
            sqlDataAdapter.DeleteCommand = new SqlCommand(deleteCommand, con);
            sqlDataAdapter.DeleteCommand.ExecuteNonQuery();

            loadLichHen(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value);
            resetData();
            con.Close();
        }

        private void btnDanhDau_Click_1(object sender, EventArgs e)
        {
            
            frm_CuocHen cuocHen = new frm_CuocHen(currentBacsiId);
            DialogResult dr = cuocHen.ShowDialog(this);
            if (dr == DialogResult.Cancel || dr == DialogResult.OK)
            {
                cuocHen.Close();
                loadLichHen(string.Empty, dtpFrom.Value, dtpTo.Value);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            setUp();
        }

    }
}

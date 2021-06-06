using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class frm_CuocHen : Form
    {
        TableLayoutPanel appointments;
        string currentUser = "2";
        public frm_CuocHen()
        {
            InitializeComponent();
            loadAppointment();
        }

        public SqlConnection GetConnection()
        {
            string connectString = @"Data Source=IVANTIME\SQLEXPRESS;Initial Catalog=thuctap;Integrated Security=True";
            return new SqlConnection(connectString);
        }

        // findIndexOf tìm index Coloumn của ngày hẹn
        private int findIndexOf(List<KeyValuePair<String, int>> l, String ngayHen)
        {
            int index = 0;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].Key.ToString().Equals(ngayHen))
                {
                    index = l[i].Value; break;
                }
            }

            return index;
        }

        // 1 label = 1 cuộc hẹn
        private Label getLable(string tenBenhNhan, string ca, string trangThai, string noiDung, string cuocHenId, string ngayHen, string bacSiId, string benhNhanId)
        {
            var lb = new Label() { };
            if (trangThai.Equals("Hoàn Thành"))
            {
                lb.BackColor = Color.Green;
            }
            else
            {
                lb.BackColor = Color.Red;
            }
            lb.ForeColor = Color.White;
            lb.AutoSize = true;
            lb.Tag = cuocHenId + "-" + trangThai + "-" + ngayHen + "-" + bacSiId + "-" + benhNhanId;
            lb.Text = tenBenhNhan + "\n";
            lb.Text += "Ca: " + ca + "\n";
            lb.Text += trangThai + "\n";
            lb.Margin = new Padding(3);
            lb.Padding = new Padding(3);
            lb.DoubleClick += handleHoanThanh_Click;

            return lb;
        }

        private void handleHoanThanh_Click(object sender, System.EventArgs e)
        {


            SqlConnection connect;
            SqlDataAdapter sqlDataAdapter;

            Label lb = (Label)sender;
            string tag = lb.Tag.ToString();
            string id = tag.Split('-')[0];
            string trangThai = tag.Split('-')[1];
            string ngayHen = tag.Split('-')[2];
            string bacSiId = tag.Split('-')[3];
            string benhNhanId = tag.Split('-')[4];

            // bác sĩ nào thì chỉ được thao tác trên cuộc hẹn của bác sĩ đó
            if (!currentUser.Equals(bacSiId))
            {
                MessageBox.Show("Thao tác không hợp lệ");
                return;
            }

            DateTime date = DateTime.ParseExact(ngayHen, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime current = DateTime.Now;
            if (DateTime.Compare(date, current) > 0)
            {
                MessageBox.Show("Thao tác không hợp lệ");
                return;
            }

            string trangThaiUpdate;
            if (trangThai.Equals("Hoàn Thành"))
            {
                // Nếu đánh dấu là chưa hoàn thành thì sẽ xoá đi BuoiDieuTri ứng với cuộc hẹn đó
                sqlDataAdapter = new SqlDataAdapter(); connect = GetConnection(); connect.Open();
                trangThaiUpdate = "Chưa Hoàn Thành";
                string ngayHenToSearchForDelete = ngayHen.Split('/')[2] + "-" + ngayHen.Split('/')[1] + "-" + ngayHen.Split('/')[0];
                string delete = string.Format("delete from BuoiDieuTri where NgayKham = '{0}' AND Bacsi = {1} AND BenhNhan = {2}", ngayHenToSearchForDelete, bacSiId, benhNhanId);
                sqlDataAdapter.DeleteCommand = new SqlCommand(delete, connect);
                try
                {
                    sqlDataAdapter.DeleteCommand.ExecuteNonQuery(); // bỏ trong khối try catch bởi vì phòng trường hợp trong bảng BuoiDieuTri không có BuoiDieuTri tương ứng với CuocHen
                }
                catch (Exception ex)
                {

                }


                connect.Close();
            }
            else
            {
                // nếu đánh dấu là đã hoàn thành thì chúng ta sẽ thêm 1 BuoiDieuTri ứng với CuocHen đó
                sqlDataAdapter = new SqlDataAdapter(); connect = GetConnection(); connect.Open();
                trangThaiUpdate = "Hoàn Thành";
                string ngayHenForInsert = ngayHen.Split('/')[2] + "-" + ngayHen.Split('/')[1] + "-" + ngayHen.Split('/')[0];
                string insertBuoiDieuTri = string.Format("insert into BuoiDieuTri(NgayKham, Bacsi, BenhNhan) values ('{0}', {1}, {2})", ngayHenForInsert, bacSiId, benhNhanId);
                sqlDataAdapter.InsertCommand = new SqlCommand(insertBuoiDieuTri, connect);
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                connect.Close();
            }
            // update trạng thái của CuocHen (Hoàn Thành hoặc Chưa Hoàn Thành)
            connect = GetConnection(); connect.Open();
            sqlDataAdapter = new SqlDataAdapter();
            string update = string.Format("update CuocHen set TrangThai = N'{0}' where id = '{1}'", trangThaiUpdate, id);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, connect);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            Controls.Remove(appointments);
            loadAppointment();
            connect.Close();
        }

        private void loadAppointment()
        {
            appointments = new TableLayoutPanel() { AutoSize = true, AutoScroll = true, Dock = DockStyle.Fill };

            // load những ngày có cuộc hẹn
            SqlConnection connect = GetConnection(); connect.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string query = "select distinct NgayHen from CuocHen order by NgayHen asc";
            command = new SqlCommand(query, connect);
            dataReader = command.ExecuteReader();
            List<String> dates = new List<string>(); // những ngày có bệnh nhân hẹn

            while (dataReader.Read())
            {
                dates.Add(dataReader.GetDateTime(0).Date.ToString("dd/MM/yyyy"));
            }
            connect.Close();

            // lấy những bác sĩ có trong danh sách cuộc hẹn
            query = "select distinct Users.Ten from CuocHen inner join Users on CuocHen.BacSi = Users.id inner join Roles on Users.Chucvu = Roles.id where Roles.role_name = N'Bác sĩ'";
            List<String> users = new List<string>(); // lưu tên của những bác sĩ trong list
            connect = GetConnection(); connect.Open();
            command = new SqlCommand(query, connect);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                users.Add(dataReader.GetString(0));
            }
            connect.Close();

            // format cho table
            appointments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            appointments.AutoSize = true;
            appointments.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            List<KeyValuePair<String, int>> l = new List<KeyValuePair<string, int>>(); // chúng ta sẽ lưu  ngày hẹn và index cột của nó trong bảng dưới dạng Key Value

            appointments.Controls.Add(new Label() { Text = "Bác sĩ" }, 0, 0); // render "Bác sĩ vào ô 0 0 trên table

            //Thêm header column cho table (những ngày có cuộc hẹn)
            for (int i = 0; i < dates.Count; i++)
            {
                appointments.Controls.Add(new Label() { Text = dates[i].Trim() }, i + 1, 0);
                l.Add(new KeyValuePair<string, int>(dates[i], i + 1));
            }

            FlowLayoutPanel[,] matrixLayout = new FlowLayoutPanel[users.Count + 1, dates.Count + 1]; // ma trận ánh xạ cell trên table
            // tham chiếu
            for (int i = 1; i < users.Count + 1; i++)
            {
                for (int j = 1; j < dates.Count + 1; j++)
                {
                    matrixLayout[i, j] = new FlowLayoutPanel { Dock = DockStyle.Fill };
                    matrixLayout[i, j].FlowDirection = FlowDirection.TopDown;
                    appointments.Controls.Add(matrixLayout[i, j], j, i);
                }
            }


            //thêm bác sĩ vào table và đồng thời load những cuộc hẹn của bác sĩ đó
            for (int i = 0; i < users.Count; i++)
            {
                string name = users[i];
                query = string.Format("select Users.Ten, Users.id, CuocHen.NgayHen, CuocHen.Ca , CuocHen.NoiDung, BenhNhan.TenBenhNhan, BenhNhan.id, CuocHen.TrangThai, CuocHen.id from CuocHen inner join Users on CuocHen.BacSi = Users.id inner join BenhNhan on BenhNhan.id = CuocHen.BenhNhan where Users.Ten = N'{0}' ", name);

                appointments.Controls.Add(new Label() { Text = name }, 0, i + 1); // tên bác sĩ

                connect = GetConnection(); connect.Open();
                command = new SqlCommand(query, connect);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string bacSiId = dataReader.GetValue(1).ToString();
                    string ngayHen = dataReader.GetDateTime(2).Date.ToString("dd/MM/yyyy");
                    string ca = dataReader.GetValue(3).ToString();
                    string noiDung = dataReader.GetValue(4).ToString();
                    string tenBenhNhan = dataReader.GetValue(5).ToString();
                    string benhNhanId = dataReader.GetValue(6).ToString();
                    string trangThai = dataReader.GetValue(7).ToString();
                    string cuocHenId = dataReader.GetValue(8).ToString();

                    //Panel panel = getPanel(caTruc, trangThai, id);

                    int indexCol = findIndexOf(l, ngayHen);
                    //matrixLayout[i + 1, indexCol].FlowDirection = FlowDirection.BottomUp;
                    matrixLayout[i + 1, indexCol].Controls.Add(getLable(tenBenhNhan, ca, trangThai, noiDung, cuocHenId, ngayHen, bacSiId, benhNhanId));
                }
            }

            Controls.Add(appointments);
        }

        private void CuocHen_Load(object sender, EventArgs e)
        {

        }
    }
}

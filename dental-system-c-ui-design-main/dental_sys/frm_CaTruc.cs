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
    public partial class frm_CaTruc : Form
    {
        TableLayoutPanel tableLayoutPanel1;
        public frm_CaTruc()
        {
            InitializeComponent();
            loadScheduler();
        }

        public SqlConnection GetConnection()
        {
            string connectString = @"Data Source=IVANTIME\SQLEXPRESS;Initial Catalog=thuctap;Integrated Security=True";
            return new SqlConnection(connectString);
        }

        private Label getLable(string ca, string trangThai, string id, string ngayTruc)
        {
            var lb = new Label();
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
            lb.Tag = id + "-" + trangThai + "-" + ngayTruc;
            lb.Text = "Ca: " + ca + "\n" + trangThai;
            lb.Margin = new Padding(3);
            lb.Padding = new Padding(3);
            lb.DoubleClick += handleHoanThanh_Click;

            return lb;
        }

        private void handleHoanThanh_Click(object sender, System.EventArgs e)
        {
            Label lb = (Label)sender;
            string tag = lb.Tag.ToString();

            string id = tag.Split('-')[0];
            string trangThai = tag.Split('-')[1];
            string ngayTruc = tag.Split('-')[2];
            DateTime date = DateTime.ParseExact(ngayTruc, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime current = DateTime.Now.Date;
            if (DateTime.Compare(date, current) > 0)
            {
                MessageBox.Show("Thao tác không hợp lệ");
                return;
            }

            string trangThaiUpdate;
            if (trangThai.Equals("Hoàn Thành"))
            {
                trangThaiUpdate = "Chưa Hoàn Thành";
            }
            else
            {
                trangThaiUpdate = "Hoàn Thành";
            }
            // update
            SqlConnection connect = GetConnection(); connect.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string update = string.Format("update CaTruc set TrangThai = N'{0}' where id = '{1}'", trangThaiUpdate, id);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, connect);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            Controls.Remove(tableLayoutPanel1);
            loadScheduler();
        }

        private int findIndexOf(List<KeyValuePair<String, int>> l, String ngayTruc)
        {
            int index = 0;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].Key.ToString().Equals(ngayTruc))
                {
                    index = l[i].Value; break;
                }
            }

            return index;
        }


        private void loadScheduler()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // load những ngày có ca trực
            SqlConnection connect = GetConnection(); connect.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string query = "select distinct NgayTruc from CaTruc order by NgayTruc asc";
            command = new SqlCommand(query, connect);
            dataReader = command.ExecuteReader();
            List<String> dates = new List<string>(); // những ngày có ca trực

            while (dataReader.Read())
            {
                dates.Add(dataReader.GetDateTime(0).Date.ToString("dd/MM/yyyy"));
            }
            connect.Close();

            // lấy những user có trong danh sách ca trực
            query = "select distinct Users.Ten from CaTruc inner join Users on CaTruc.NguoiTruc = Users.id";
            List<String> users = new List<string>();

            connect = GetConnection(); connect.Open();

            command = new SqlCommand(query, connect);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                users.Add(dataReader.GetString(0));
            }
            connect.Close();


            List<KeyValuePair<String, int>> l = new List<KeyValuePair<string, int>>();

            tableLayoutPanel1.Controls.Add(new Label() { Text = "Users" }, 0, 0);

            //add column
            for (int i = 0; i < dates.Count; i++)
            {
                tableLayoutPanel1.Controls.Add(new Label() { Text = dates[i].Trim() }, i + 1, 0);
                l.Add(new KeyValuePair<string, int>(dates[i], i + 1));
            }

            FlowLayoutPanel[,] matrixLayout = new FlowLayoutPanel[users.Count + 1, dates.Count + 1];

            for (int i = 1; i < users.Count + 1; i++)
            {
                for (int j = 1; j < dates.Count + 1; j++)
                {
                    matrixLayout[i, j] = new FlowLayoutPanel { Dock = DockStyle.Fill };
                    matrixLayout[i, j].FlowDirection = FlowDirection.TopDown;

                    tableLayoutPanel1.Controls.Add(matrixLayout[i, j], j, i);
                }
            }


            //thêm user và những ca trực của user đó
            for (int i = 0; i < users.Count; i++)
            {
                string name = users[i];
                query = string.Format("select Users.Ten, Catruc.NgayTruc, Catruc.Ca, Catruc.TrangThai, Catruc.id from CaTruc inner join Users on CaTruc.NguoiTruc = Users.id where Users.Ten = N'{0}' ", name);

                tableLayoutPanel1.Controls.Add(new Label() { Text = name }, 0, i + 1);

                connect = GetConnection(); connect.Open();
                command = new SqlCommand(query, connect);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string ngayTruc = dataReader.GetDateTime(1).Date.ToString("dd/MM/yyyy");
                    string caTruc = dataReader.GetValue(2).ToString();
                    string trangThai = dataReader.GetValue(3).ToString();
                    string id = dataReader.GetValue(4).ToString();

                    //Panel panel = getPanel(caTruc, trangThai, id);

                    int indexCol = findIndexOf(l, ngayTruc);
                    //matrixLayout[i + 1, indexCol].FlowDirection = FlowDirection.BottomUp;
                    matrixLayout[i + 1, indexCol].Controls.Add(getLable(caTruc, trangThai, id, ngayTruc));
                }
            }

            Controls.Add(tableLayoutPanel1);
        }
    }
}

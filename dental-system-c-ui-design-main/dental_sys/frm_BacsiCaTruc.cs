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
    public partial class frm_BacsiCaTruc : Form
    {
        int currentId = 0; // id của bác sĩ hiện tại đang đăng nhập, 
        const string WARNING = "Warning!";
        const string NONE = "(None)";
        TableLayoutPanel tlp_CaTruc;
        public frm_BacsiCaTruc(int bacSiId)
        {
            InitializeComponent();
            this.currentId = bacSiId;
        }

        // tìm index của ngày đó trong bảng
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

            return lb;
        }

        private void loadCatruc(string trangThaiCombobox, DateTime? from, DateTime? to)
        {
            tlp_CaTruc = new TableLayoutPanel();
            tlp_CaTruc.AutoSize = true;
            tlp_CaTruc.AutoScroll = true;
            tlp_CaTruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tlp_CaTruc.AutoSize = true;
            tlp_CaTruc.Dock = DockStyle.Fill;
            tlp_CaTruc.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlp_CaTruc.Controls.Add(new Label() { Text = "Bác sĩ" }, 0, 0);

            // load những ngày có ca trực của bác sĩ hiện tại
            SqlConnection connect = ConnectProvider.GetConnection(); connect.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string query = "select distinct NgayTruc from CaTruc ";
            query += string.Format("where NguoiTruc = {0} ", currentId);
            query += "order by NgayTruc asc";
            command = new SqlCommand(query, connect);
            dataReader = command.ExecuteReader();
            List<String> dates = new List<string>(); // lưu những ngày có ca trực của bác sĩ hiện tại vào List

            while (dataReader.Read())
            {
                dates.Add(dataReader.GetDateTime(0).Date.ToString("dd/MM/yyyy"));
            }
            connect.Close();

            // lấy tên của bác sĩ hiện tại
            query = "select distinct Users.Ten from CaTruc inner join Users on CaTruc.NguoiTruc = Users.id ";
            query += string.Format("where Users.id = {0}", currentId);
            string tenBacSi = "";

            connect = ConnectProvider.GetConnection(); connect.Open();

            command = new SqlCommand(query, connect);
            dataReader = command.ExecuteReader();
            dataReader.Read(); tenBacSi = dataReader.GetString(0);
            connect.Close();

            // list key value dùng để lưu ngày và index của ngày đó trên table
            List<KeyValuePair<String, int>> l = new List<KeyValuePair<string, int>>();

            //add column
            for (int i = 0; i < dates.Count; i++)
            {
                tlp_CaTruc.Controls.Add(new Label() { Text = dates[i].Trim() }, i + 1, 0); // thêm ngày trực lên table
                l.Add(new KeyValuePair<string, int>(dates[i], i + 1)); // lưu ngày trực và index của ngày đó trên table
            }

            FlowLayoutPanel[] layoutArray = new FlowLayoutPanel[dates.Count + 1]; // mảng dùng để chứa tham chiếu đến những ô trên table,  mỗi ô chúng ta dùng 1 cái FlowLayoutPanel để chứa control

            for (int j = 1; j < dates.Count + 1; j++) // mỗi ô 1 FlowLayoutPanel
            {
                layoutArray[j] = new FlowLayoutPanel { Dock = DockStyle.Fill };
                layoutArray[j].FlowDirection = FlowDirection.TopDown;

                tlp_CaTruc.Controls.Add(layoutArray[j], j, 1); // bởi vì chỉ có 1 bác sĩ nên chỉ có 1 hàng
            }

            //những ca trực của bác sĩ hiện tại
            query = string.Format("select Users.Ten, Catruc.NgayTruc, Catruc.Ca, Catruc.TrangThai, Catruc.id from CaTruc inner join Users on CaTruc.NguoiTruc = Users.id where Users.Ten = N'{0}' ", tenBacSi);
            if (from != null)
            {
                query += string.Format("AND (CaTruc.NgayTruc BETWEEN '{0}' AND '{1}') ", from, to);
            }
            if (!trangThaiCombobox.Equals(NONE))
            {
                query += string.Format("AND CaTruc.TrangThai = N'{0}'", trangThaiCombobox);
            }

            tlp_CaTruc.Controls.Add(new Label() { Text = tenBacSi }, 0, 1); // đưa tên bác sĩ lên table

            connect = ConnectProvider.GetConnection(); connect.Open();
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
                layoutArray[indexCol].Controls.Add(getLable(caTruc, trangThai, id, ngayTruc));
            }

            panel1.Controls.Clear();
            panel1.Controls.Add(tlp_CaTruc);
        }

        private void frm_BacsiCaTruc_Load(object sender, EventArgs e)
        {
            loadCatruc(NONE, null, null);

            // format datetimepicker
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "dd-MM-yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "dd-MM-yyyy";
            dtpFrom.Value = DateTime.Now.AddDays(-10).Date;
            dtpTo.Value = DateTime.Now.AddDays(10).Date;
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            cbTrangThai.SelectedIndex = 0;
        }

        private bool validateFromTo(DateTime from, DateTime to)
        {
            return (DateTime.Compare(from, to) > 0) ? false : true; // from không thể sau to
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!validateFromTo(dtpFrom.Value, dtpTo.Value))
            {
                MessageBox.Show("Thao tác không hợp lệ", WARNING);
                dtpFrom.Value = DateTime.Now.AddDays(-10).Date;
                dtpTo.Value = DateTime.Now.AddDays(10).Date;
                return; // nếu thông tin ngày tháng sai thì khởi tạo lại date time picker
            }
            loadCatruc(cbTrangThai.Text, dtpFrom.Value, dtpTo.Value);
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (!validateFromTo(dtpFrom.Value, dtpTo.Value))
            {
                MessageBox.Show("Thao tác không hợp lệ", WARNING);
                dtpFrom.Value = DateTime.Now.AddDays(-10).Date;
                dtpTo.Value = DateTime.Now.AddDays(10).Date; // nếu thông tin ngày tháng sai thì khởi tạo lại date time picker
                return;
            }
            loadCatruc(cbTrangThai.Text, dtpFrom.Value, dtpTo.Value);
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCatruc(cbTrangThai.Text, dtpFrom.Value, dtpTo.Value);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddDays(-10).Date;
            dtpTo.Value = DateTime.Now.AddDays(10).Date;

            cbTrangThai.SelectedIndex = 0;

            loadCatruc(NONE, null, null);
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            new frm_ReportLichTrucVaGuiMail(currentId).ShowDialog();
        }
    }
}

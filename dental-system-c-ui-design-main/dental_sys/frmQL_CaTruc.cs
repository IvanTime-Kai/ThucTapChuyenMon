using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dental_sys
{
    public partial class frmQL_CaTruc : Form
    {
        const string HOAN_THANH = "Hoàn Thành";
        const string CHUA_HOAN_THANH = "Chưa Hoàn Thành";
        const string WARNING = "Warning!";
        const string TEN_BAC_SI = "TenBacSi";
        const string NGAY_TRUC = "NgayTruc";
        const string CA = "Ca";
        const string TRANG_THAI = "TrangThai";
        const string ID = "Id";
        const string THONG_BAO_TRUNG_LICH = "Bác sĩ đã trùng lịch!";
        const string THONG_BAO_CHON_CA_TRUC = "Vui lòng chọn ca trực để {0}!";
        const string THONG_BAO_CHINH_SUA_KHONG_HOP_LE = "Chỉnh sửa ngày trực và trạng thái không hợp lệ";
        int selectedCaTrucId = 0;

        public frmQL_CaTruc()
        {
            InitializeComponent();
        }

        private void resetData()
        {
            selectedCaTrucId = 0;
            cbTenBacSi.SelectedIndex = 0;
            dtpNgayTruc.Value = DateTime.Now.Date;
            cbCa.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Now.AddDays(-10).Date;
            dtpTo.Value = DateTime.Now.AddDays(10).Date;
        }

        private void setUp()
        {
            // custom controls
            dgv_CaTruc.ReadOnly = true;
            dgv_CaTruc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgv_CaTruc.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv_CaTruc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_CaTruc.MultiSelect = false;
            dgv_CaTruc.BackgroundColor = Color.White;
            dgv_CaTruc.RowHeadersVisible = false;
            dgv_CaTruc.AllowUserToResizeRows = false;


            cbTenBacSi.DropDownStyle = ComboBoxStyle.DropDownList; cbCa.DropDownStyle = ComboBoxStyle.DropDownList; cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList; cbSapXep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCa.SelectedIndex = 0; cbTrangThai.SelectedIndex = 1; cbSapXep.SelectedIndex = 0;

            // format datetimepicker
            dtpNgayTruc.Format = DateTimePickerFormat.Custom;
            dtpNgayTruc.CustomFormat = "dd-MM-yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "dd-MM-yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "dd-MM-yyyy";
            dtpFrom.Value = DateTime.Now.AddDays(-10).Date;
            dtpTo.Value = DateTime.Now.AddDays(10).Date;

            // load data to comboBox
            loadBacSi();

            // load data to gridview
            loadCaTruc(string.Empty, null, null);
            dgv_CaTruc.Columns[ID].Visible = false; // ẩn cột id
        }

        private void loadCaTruc(string orderBy, DateTime? from, DateTime? to)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            List<CaTrucADO> caTrucList = new List<CaTrucADO>();
            string query = "select CaTruc.id, Users.Ten, CaTruc.NgayTruc, CaTruc.Ca, CaTruc.TrangThai ";
            query += "from CaTruc inner join Users on CaTruc.NguoiTruc = Users.id inner join Roles on Users.Chucvu = Roles.id ";
            query += "where Roles.role_name = N'Bác sĩ' ";

            if (from != null && to != null)
            {
                query += string.Format("AND (CaTruc.NgayTruc BETWEEN '{0}' AND '{1}') ", from, to);
            }

            if (!orderBy.Equals(string.Empty))
                query += string.Format("order by {0}", orderBy);

            SqlDataReader sqlDataReader; SqlCommand command = new SqlCommand(query, con);
            sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int idCatruc = sqlDataReader.GetInt32(0);
                string tenBacSi = sqlDataReader.GetString(1);
                DateTime ngayTruc = sqlDataReader.GetDateTime(2);
                string ca = sqlDataReader.GetString(3);
                string trangThai = sqlDataReader.GetString(4);

                caTrucList.Add(new CaTrucADO(idCatruc, tenBacSi, ngayTruc, ca, trangThai));
            }

            dgv_CaTruc.DataSource = caTrucList;
            con.Close();
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

        private void frmQL_CaTruc_Load(object sender, EventArgs e)
        {
            setUp();
        }

        private void dgv_CaTruc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedRowIndex = dgv_CaTruc.SelectedRows[0].Index;

                int idCatruc = Int32.Parse(dgv_CaTruc.Rows[selectedRowIndex].Cells[ID].Value.ToString());
                string tenBacSi = dgv_CaTruc.Rows[selectedRowIndex].Cells[TEN_BAC_SI].Value.ToString();
                DateTime ngayTruc = (DateTime)dgv_CaTruc.Rows[selectedRowIndex].Cells[NGAY_TRUC].Value;
                string Ca = dgv_CaTruc.Rows[selectedRowIndex].Cells[CA].Value.ToString();
                string trangThai = dgv_CaTruc.Rows[selectedRowIndex].Cells[TRANG_THAI].Value.ToString();

                cbTenBacSi.Text = tenBacSi;
                dtpNgayTruc.Value = ngayTruc;
                cbCa.Text = Ca;
                cbTrangThai.Text = trangThai;
                selectedCaTrucId = idCatruc;
            }
        }

        private bool validateFormInsert()
        {
            DateTime ngayTruc = dtpNgayTruc.Value;
            string trangThai = cbTrangThai.Text;
            if (DateTime.Compare(ngayTruc.Date, DateTime.Now.Date) < 0) // thêm mới 1 ngày trực phải lớn hơn hoặc bằng ngày hiện tại
            {
                return false;
            }
            else if (trangThai.Equals(HOAN_THANH)) // ca trực mới được thêm vào phải ở trạng thái chưa hoàn thành
            {
                return false;
            }

            return true;
        }

        private bool kiemTraTrungLichInsert(string tenBacSiForm, DateTime ngayTrucForm, string caForm)
        {
            foreach (DataGridViewRow row in dgv_CaTruc.Rows)
            {
                string tenBacSi = row.Cells[TEN_BAC_SI].Value.ToString();
                DateTime ngayTruc = (DateTime)row.Cells[NGAY_TRUC].Value;
                string ca = row.Cells[CA].Value.ToString();
                if (tenBacSi.Equals(tenBacSiForm) && ngayTruc.Equals(ngayTrucForm) && ca.Equals(caForm))
                {
                    return false; // trả về false thông báo bác sĩ đã trực ca này
                }
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            // get data from form
            int bacSiId = (Int32)cbTenBacSi.SelectedValue;
            DateTime ngayTrucForm = dtpNgayTruc.Value.Date;
            string caForm = cbCa.Text;
            string trangThai = cbTrangThai.Text;
            string tenBacSiForm = cbTenBacSi.Text;

            // validate data
            if (!validateFormInsert())
            {
                MessageBox.Show("Thông tin form chưa hợp lệ!", WARNING);
                return;
            }

            if (!kiemTraTrungLichInsert(tenBacSiForm, ngayTrucForm, caForm))
            {
                MessageBox.Show(THONG_BAO_TRUNG_LICH, WARNING);
                return;
            }


            //insert
            string insertCommand = string.Format("insert into CaTruc values({0}, '{1}', N'{2}', N'{3}')", bacSiId, ngayTrucForm, caForm, trangThai);
            sqlDataAdapter.InsertCommand = new SqlCommand(insertCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            loadCaTruc(string.Empty, null, null);
            resetData();
            con.Close();
        }

        private bool kiemTraTrungLichUpdate(string tenBacSiForm, DateTime ngayTrucForm, string caForm)
        {
            foreach (DataGridViewRow row in dgv_CaTruc.Rows)
            {
                string tenBacSi = row.Cells[TEN_BAC_SI].Value.ToString();
                int id = (Int32)row.Cells[ID].Value;

                if (tenBacSi.Equals(tenBacSiForm) && id != selectedCaTrucId) // kiểm tra những row còn lại của bác sĩ đang sửa trên datagridview
                {
                    DateTime ngayTruc = (DateTime)row.Cells[NGAY_TRUC].Value;
                    string ca = row.Cells[CA].Value.ToString();

                    if (ngayTruc.Equals(ngayTrucForm) && ca.Equals(caForm))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedCaTrucId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_CHON_CA_TRUC, "chỉnh sửa"), WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            // get data from form
            int bacSiId = (Int32)cbTenBacSi.SelectedValue;
            DateTime ngayTrucForm = dtpNgayTruc.Value.Date;
            string caForm = cbCa.Text;
            string trangThai = cbTrangThai.Text;
            string tenBacSiForm = cbTenBacSi.Text;

            if (!kiemTraTrungLichUpdate(tenBacSiForm, ngayTrucForm, caForm))
            {
                MessageBox.Show(THONG_BAO_TRUNG_LICH, WARNING);
                return;
            }

            if ((DateTime.Compare(ngayTrucForm.Date, DateTime.Now.Date) > 0) && trangThai.Equals(HOAN_THANH)) // không cho phép hoàn thành
            {
                MessageBox.Show(THONG_BAO_CHINH_SUA_KHONG_HOP_LE, WARNING);
                return;
            }

            //update
            string rawUpdateCommand = "update CaTruc ";
            rawUpdateCommand += "set NguoiTruc = {0}, NgayTruc = '{1}', Ca = N'{2}', TrangThai = N'{3}' ";
            rawUpdateCommand += "where id = {4}";
            string updateCommand = string.Format(rawUpdateCommand, bacSiId, ngayTrucForm, caForm, trangThai, selectedCaTrucId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(updateCommand, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();


            loadCaTruc(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value);
            resetData();
            con.Close();
        }

        private string getCurrentOrderBy()
        {
            string selectedText = cbSapXep.Text;
            string orderBy = string.Empty;
            if (selectedText.Equals("Bác sĩ"))
            {
                orderBy = "Ten";
            }
            else if (selectedText.Equals("Ngày hẹn"))
            {
                orderBy = "NgayTruc";
            }

            return orderBy;
        }

        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCaTruc(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedCaTrucId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_CHON_CA_TRUC, "xoá"), WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string deleteCommand = string.Format("delete from CaTruc where id = {0}", selectedCaTrucId);
            sqlDataAdapter.DeleteCommand = new SqlCommand(deleteCommand, con);
            sqlDataAdapter.DeleteCommand.ExecuteNonQuery();

            loadCaTruc(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value);
            resetData();
            con.Close();
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
            loadCaTruc(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value);
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
            loadCaTruc(getCurrentOrderBy(), dtpFrom.Value, dtpTo.Value);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setUp();
        }

        private void btnDanhDau_Click(object sender, EventArgs e)
        {
            frm_CaTruc caTruc = new frm_CaTruc();
            DialogResult dr = caTruc.ShowDialog(this);
            if (dr == DialogResult.Cancel || dr == DialogResult.OK)
            {
                caTruc.Close();
                loadCaTruc(string.Empty, dtpFrom.Value, dtpTo.Value);
            }
        }
    }
}

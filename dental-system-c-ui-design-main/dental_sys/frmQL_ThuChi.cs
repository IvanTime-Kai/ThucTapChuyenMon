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
    public partial class frmQL_ThuChi : Form
    {
        const string TEN_KHOAN_NAY_KHONG_DUOC_BO_TRONG = "Tên khoản {0} không được bỏ trống!";
        const string SO_TIEN_KHONG_DUOC_BO_TRONG = "Số tiền không được bỏ trống!";
        const string SO_TIEN_PHAI_LA_SO = "Số tiền phải là số!";
        const string THONG_BAO_VUI_LONG_CHON_KHOAN = "Vui lòng chọn khoản {0} để {1}!";
        const string THONG_BAO_KHONG_THE_XOA_KHOAN_NAY = "Không thể xoá khoản {0} này!";
        const string THONG_BAO_KHONG_THE_XOA_LAN_THU_NAY = "Không thể xoá lần thu này!";
        const string THONG_BAO_KHONG_THE_XOA_LAN_CHI_NAY = "Không thể xoá lần chi này!";
        const string THONG_BAO_GHI_CHU_KHONG_DUOC_BO_TRONG = "Ghi chú không được bỏ trống!";
        const string THONG_BAO_VUI_LONG_CHON_LAN_THU = "Vui lòng chọn một lần thu để {0}!";
        const string THONG_BAO_VUI_LONG_CHON_LAN_CHI = "Vui lòng chọn một lần chi để {0}!";
        const string NGAY_KHONG_HOP_LE = "Ngày {0} không hợp lệ!";
        const string WARNING = "Warning!";

        const string ID = "id";
        const string TEN_KHOAN_THU = "TenKhoanThu";
        const string TEN_KHOAN_CHI = "TenKhoanChi";
        const string SO_TIEN = "SoTien";
        const string TEN = "Ten";
        const string GHI_CHU = "GhiChu";
        const string NGAY_DONG = "NgayDong"; // dưới database đặt tên cột là NgayThu còn trên code thì đặt tên cột là NgauDong
        const string NGAY_THU = "NgayThu"; // dưới database đặt tên cột là NgayThu còn trên code thì đặt tên cột là NgauDong
        const string NGUOI_DONG = "NguoiDong";
        const string TEN_NGUOI_DONG = "TenNguoiDong";
        const string TEN_NGUOI_CHI = "TenNguoiChi";
        const string NGAY_CHI = "NgayChi";
        const string NGUOI_CHI = "NguoiChi";
        int currentKhoanThuId = 0;
        int currentThuId = 0;
        int currentKhoanChiId = 0;
        int currentChiId = 0;
        public frmQL_ThuChi()
        {
            InitializeComponent();
        }

        private void formatDataGridView(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
        }

        private void loadKhoanThu()
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select * from Khoanthu";
            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<KhoanThuADO> listKhoanThu = new List<KhoanThuADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string tenKhoanThu = sqlDataReader.GetString(1);
                int soTien = sqlDataReader.GetInt32(2);
                listKhoanThu.Add(new KhoanThuADO(id, tenKhoanThu, soTien));
            }

            dgv_KhoanThu.DataSource = listKhoanThu;

            con.Close();
        }

        private void loadKhoanChi()
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select * from Khoanchi";
            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<KhoanChiADO> listKhoanChi = new List<KhoanChiADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string tenKhoanChi = sqlDataReader.GetString(1);
                int soTien = sqlDataReader.GetInt32(2);
                listKhoanChi.Add(new KhoanChiADO(id, tenKhoanChi, soTien));
            }

            dgv_KhoanChi.DataSource = listKhoanChi;

            con.Close();
        }

        private void loadThuGridView(int khoanThuId, string orderBy) // load những lần Thu từ Khoản Thu này
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select T.id, Users.Ten, KT.TenKhoanThu, T.NgayThu ,T.GhiChu ";
            query += "from Thu T inner join Khoanthu KT on T.KhoanThu = KT.id inner join Users on T.NguoiDong = Users.id ";
            query += string.Format("where T.KhoanThu = {0} ", khoanThuId);
            if (!orderBy.Equals(string.Empty))
                query += string.Format("order by {0}", orderBy);

            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<ThuADO> listThu = new List<ThuADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string tenNguoiDong = sqlDataReader.GetString(1);
                string tenKhoanThu = sqlDataReader.GetString(2);
                DateTime ngayDong = sqlDataReader.GetDateTime(3);
                string ghiChu = sqlDataReader.GetString(4);
                listThu.Add(new ThuADO(id, tenNguoiDong, tenKhoanThu, ngayDong, ghiChu));
            }

            dgv_Thu.DataSource = listThu;

            con.Close();
        }

        private void loadChiGridView(int khoanChiId, string orderBy) // load những lần Chi từ Khoản Chi này
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select C.id, Users.Ten, KC.TenKhoanChi, C.NgayChi ,C.GhiChu ";
            query += "from Chi C inner join Khoanchi KC on C.KhoanChi = KC.id inner join Users on C.NguoiChi = Users.id ";
            query += string.Format("where C.KhoanChi = {0} ", khoanChiId);
            if (!orderBy.Equals(string.Empty))
                query += string.Format("order by {0}", orderBy);

            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<ChiADO> listChi = new List<ChiADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string tenNguoiChi = sqlDataReader.GetString(1);
                string tenKhoanChi = sqlDataReader.GetString(2);
                DateTime ngayChi = sqlDataReader.GetDateTime(3);
                string ghiChu = sqlDataReader.GetString(4);
                listChi.Add(new ChiADO(id, tenNguoiChi, tenKhoanChi, ngayChi, ghiChu));
            }

            dgv_Chi.DataSource = listChi;

            con.Close();
        }

        private void loadUserToComboBox(ComboBox combobox)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select id, Ten from Users ";
            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<UserADO> listUser = new List<UserADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string ten = sqlDataReader.GetString(1);

                listUser.Add(new UserADO(id, ten));
            }

            combobox.ValueMember = null;
            combobox.DisplayMember = TEN;
            combobox.DataSource = listUser;

            con.Close();
        }

        private void setUpThu()
        {
            // custom controls
            formatDataGridView(dgv_KhoanThu);
            formatDataGridView(dgv_Thu);


            // load data to gridview
            loadKhoanThu();
            dgv_KhoanThu.Columns[ID].Visible = false;

            //format datetimepicker
            dtpNgayDong.Format = DateTimePickerFormat.Custom;
            dtpNgayDong.CustomFormat = "dd-MM-yyyy";

            try // Nếu có đã có Khoản thu thì hiển thị những lần Thu của Khoản thu đó ra, nếu chưa có Khoản thu nào thì thoi
            {
                DataGridViewRow row = dgv_KhoanThu.Rows[0];
                int firstIdKhoanThu = Int32.Parse(row.Cells[ID].Value.ToString());
                loadThuGridView(firstIdKhoanThu, string.Empty);
                dgv_Thu.Columns[ID].Visible = false;
                currentKhoanThuId = firstIdKhoanThu;
            }
            catch (Exception ex)
            {

            }

            // load data User to comboBox, format combobox
            loadUserToComboBox(cbUser_Thu);
            cbUser_Thu.DropDownStyle = ComboBoxStyle.DropDownList; cbUser_Thu.SelectedIndex = 0;
            cbSapXep_Thu.DropDownStyle = ComboBoxStyle.DropDownList; cbSapXep_Thu.SelectedIndex = 0;
        }

        private void setUpChi()
        {
            // custom controls
            formatDataGridView(dgv_KhoanChi);
            formatDataGridView(dgv_Chi);


            // load data to gridview
            loadKhoanChi();
            dgv_KhoanChi.Columns[ID].Visible = false;

            //format datetimepicker
            dtpNgayChi.Format = DateTimePickerFormat.Custom;
            dtpNgayChi.CustomFormat = "dd-MM-yyyy";

            try // Nếu có đã có Khoản chi thì hiển thị những lần Chi của Khoản chi đó ra, nếu chưa có Khoản chi nào thì thoi
            {
                DataGridViewRow row = dgv_KhoanChi.Rows[0];
                int firstIdKhoanChi = Int32.Parse(row.Cells[ID].Value.ToString());
                loadChiGridView(firstIdKhoanChi, string.Empty);
                dgv_Chi.Columns[ID].Visible = false;
                currentKhoanChiId = firstIdKhoanChi;
            }
            catch (Exception ex)
            {

            }

            // load data User to comboBox, format combobox
            loadUserToComboBox(cbUser_Chi);
            cbUser_Chi.DropDownStyle = ComboBoxStyle.DropDownList; cbUser_Chi.SelectedIndex = 0;
            cbSapXep_Chi.DropDownStyle = ComboBoxStyle.DropDownList; cbSapXep_Chi.SelectedIndex = 0;
        }

        private void frmQL_ThuChi_Load(object sender, EventArgs e)
        {
            setUpThu();
            setUpChi();
        }

        private void resetDataKhoanThu()
        {
            txtSoTien_KhoanThu.Text = string.Empty;
            txtTenKhoanThu.Text = string.Empty;
            currentKhoanThuId = 0;
        }

        private void resetDataKhoanChi()
        {
            txtSoTien_KhoanChi.Text = string.Empty;
            txtTenKhoanChi.Text = string.Empty;
            currentKhoanChiId = 0;
        }

        private bool validateFormKhoanThu()
        {
            // get data from form
            string tenKhoanThu = txtTenKhoanThu.Text.Trim();
            int soTien;
            // validate data
            if (tenKhoanThu.Equals(string.Empty))
            {
                MessageBox.Show(string.Format(TEN_KHOAN_NAY_KHONG_DUOC_BO_TRONG, "thu"), WARNING);
                return false;
            }

            if (txtSoTien_KhoanThu.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(SO_TIEN_KHONG_DUOC_BO_TRONG, WARNING);
                return false;
            }

            try
            {
                soTien = Int32.Parse(txtSoTien_KhoanThu.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(SO_TIEN_PHAI_LA_SO, WARNING);
                return false;
            }
            return true;
        }

        private bool validateFormKhoanChi()
        {
            // get data from form
            string tenKhoanChi = txtTenKhoanChi.Text.Trim();
            int soTien;
            // validate data
            if (tenKhoanChi.Equals(string.Empty))
            {
                MessageBox.Show(string.Format(TEN_KHOAN_NAY_KHONG_DUOC_BO_TRONG, "chi"), WARNING);
                return false;
            }

            if (txtSoTien_KhoanChi.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(SO_TIEN_KHONG_DUOC_BO_TRONG, WARNING);
                return false;
            }

            try
            {
                soTien = Int32.Parse(txtSoTien_KhoanChi.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(SO_TIEN_PHAI_LA_SO, WARNING);
                return false;
            }
            return true;
        }

        private void btnThemKhoanThu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaKhoanThu_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_KhoanThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhoanThu.SelectedRows[0];
                int id = Int32.Parse(row.Cells[ID].Value.ToString());
                string tenKhoanThu = row.Cells[TEN_KHOAN_THU].Value.ToString();
                int soTien = Int32.Parse(row.Cells[SO_TIEN].Value.ToString());
                txtTenKhoanThu.Text = tenKhoanThu;
                txtSoTien_KhoanThu.Text = soTien.ToString();
                currentKhoanThuId = id;

                loadThuGridView(currentKhoanThuId, string.Empty);
                dgv_Thu.Columns[ID].Visible = false;
                resetDataThu();
            }
        }

        private void btnXoaKhoanThu_Click(object sender, EventArgs e)
        {
            
        }

        private bool validateFormThu()
        {
            if (txtGhiChu_Thu.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(THONG_BAO_GHI_CHU_KHONG_DUOC_BO_TRONG, WARNING);
                return false;
            }
            return true;
        }

        private bool validateFormChi()
        {
            if (txtGhiChu_Chi.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(THONG_BAO_GHI_CHU_KHONG_DUOC_BO_TRONG, WARNING);
                return false;
            }
            return true;
        }

        private void resetDataThu()
        {
            cbUser_Thu.SelectedIndex = 0;
            dtpNgayDong.Value = DateTime.Now.Date;
            txtGhiChu_Thu.Text = string.Empty;
            currentThuId = 0;
        }

        private void resetDataChi()
        {
            cbUser_Chi.SelectedIndex = 0;
            dtpNgayChi.Value = DateTime.Now.Date;
            txtGhiChu_Chi.Text = string.Empty;
            currentChiId = 0;
        }

        private void btnThemThu_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_Thu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Thu.SelectedRows[0];

                cbUser_Thu.Text = row.Cells[TEN_NGUOI_DONG].Value.ToString();
                dtpNgayDong.Value = (DateTime)row.Cells[NGAY_DONG].Value;
                txtGhiChu_Thu.Text = row.Cells[GHI_CHU].Value.ToString();
                currentThuId = Int32.Parse(row.Cells[ID].Value.ToString());
            }
        }

        private void btnSuaThu_Click(object sender, EventArgs e)
        {
            
        }

        private string getOrderBy_Thu()
        {
            string selectedOrderBy = cbSapXep_Thu.Text;
            if (selectedOrderBy.Equals("Người đóng"))
                return NGUOI_DONG;
            else if (selectedOrderBy.Equals("Ngày đóng"))
                return NGAY_THU;

            return string.Empty;

        }

        private string getOrderBy_Chi()
        {
            string selectedOrderBy = cbSapXep_Chi.Text;
            if (selectedOrderBy.Equals("Người chi"))
                return NGUOI_CHI;
            else if (selectedOrderBy.Equals("Ngày chi"))
                return NGAY_CHI;

            return string.Empty;

        }

        private void cbSapXep_Thu_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadThuGridView(currentKhoanThuId, getOrderBy_Thu());
        }

        private void btnXoaThu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemKhoanChi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaKhoanChi_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_KhoanChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhoanChi.SelectedRows[0];
                int id = Int32.Parse(row.Cells[ID].Value.ToString());
                string tenKhoanChi = row.Cells[TEN_KHOAN_CHI].Value.ToString();
                int soTien = Int32.Parse(row.Cells[SO_TIEN].Value.ToString());
                txtTenKhoanChi.Text = tenKhoanChi;
                txtSoTien_KhoanChi.Text = soTien.ToString();
                currentKhoanChiId = id;

                loadChiGridView(currentKhoanChiId, string.Empty);
                dgv_Thu.Columns[ID].Visible = false;
                resetDataChi();
            }
        }

        private void btnXoaKhoanChi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemChi_Click(object sender, EventArgs e)
        {
            
        }

        private void dtpNgayDong_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Date;
            if (DateTime.Compare(dt, dtpNgayDong.Value.Date) < 0)
            {
                MessageBox.Show(string.Format(NGAY_KHONG_HOP_LE, "đóng"), WARNING);
                dtpNgayDong.Value = DateTime.Now.Date;
            }
        }

        private void dtpNgayChi_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Date;
            if (DateTime.Compare(dt, dtpNgayChi.Value.Date) < 0)
            {
                MessageBox.Show(string.Format(NGAY_KHONG_HOP_LE, "chi"), WARNING);
                dtpNgayChi.Value = DateTime.Now.Date;
            }
        }

        private void dgv_Chi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Chi.SelectedRows[0];

                cbUser_Chi.Text = row.Cells[TEN_NGUOI_CHI].Value.ToString();
                dtpNgayChi.Value = (DateTime)row.Cells[NGAY_CHI].Value;
                txtGhiChu_Chi.Text = row.Cells[GHI_CHU].Value.ToString();
                currentChiId = Int32.Parse(row.Cells[ID].Value.ToString());
            }
        }

        private void btnSuaChi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaChi_Click(object sender, EventArgs e)
        {
            
        }

        private void cbSapXep_Chi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadChiGridView(currentKhoanChiId, getOrderBy_Chi());
        }

        private void btnThemKhoanThu_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            // validate data
            if (!validateFormKhoanThu())
            {
                return;
            }
            string tenKhoanThu = txtTenKhoanThu.Text.Trim();
            int soTien = Int32.Parse(txtSoTien_KhoanThu.Text.Trim());

            //insert
            string insertCommand = string.Format("insert into Khoanthu values (N'{0}', {1})", tenKhoanThu, soTien);
            sqlDataAdapter.InsertCommand = new SqlCommand(insertCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            loadKhoanThu();
            resetDataKhoanThu();
            con.Close();
        }

        private void btnSuaKhoanThu_Click_1(object sender, EventArgs e)
        {
            // validate
            if (currentKhoanThuId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_KHOAN, "thu", "sửa"), WARNING);
                return;
            }

            if (!validateFormKhoanThu())
            {
                return;
            }
            string tenKhoanThu = txtTenKhoanThu.Text.Trim();
            int soTien = Int32.Parse(txtSoTien_KhoanThu.Text.Trim());

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string update = "update Khoanthu ";
            update += string.Format("set TenKhoanThu = N'{0}', SoTien = {1} ", tenKhoanThu, soTien);
            update += string.Format("where id = {0}", currentKhoanThuId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            resetDataKhoanThu();
            loadKhoanThu();
            con.Close();
        }

        private void btnXoaKhoanThu_Click_1(object sender, EventArgs e)
        {
            if (currentKhoanThuId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_KHOAN, "thu", "xoá"), WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string deleteCommand = string.Format("delete from Khoanthu where id = {0}", currentKhoanThuId);
            sqlDataAdapter.DeleteCommand = new SqlCommand(deleteCommand, con);
            try
            {
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                loadKhoanThu();
                resetDataKhoanThu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(THONG_BAO_KHONG_THE_XOA_KHOAN_NAY, "thu"), WARNING);
            }

            con.Close();
        }

        private void btnThemThu_Click_1(object sender, EventArgs e)
        {
            if (currentKhoanThuId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_KHOAN, "thu", "thêm một lần thu"), WARNING);
                return;
            }

            if (!validateFormThu())
            {
                return;
            }

            UserADO selectedUser = (UserADO)cbUser_Thu.SelectedValue;
            int nguoiDongId = selectedUser.Id;
            int khoanThuId = currentKhoanThuId;
            string ghiChu = txtGhiChu_Thu.Text.Trim();
            DateTime ngayDong = dtpNgayDong.Value.Date;

            //insert
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string insertCommand = "insert into Thu ";
            insertCommand += string.Format("values({0}, {1}, N'{2}', '{3}')", nguoiDongId, khoanThuId, ghiChu, ngayDong);
            sqlDataAdapter.InsertCommand = new SqlCommand(insertCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            resetDataThu();
            loadThuGridView(currentKhoanThuId, string.Empty);
            con.Close();
        }

        private void btnSuaThu_Click_1(object sender, EventArgs e)
        {
            if (currentThuId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_LAN_THU, "sửa"), WARNING);
                return;
            }

            if (!validateFormThu())
            {
                return;
            }

            UserADO selectedUser = (UserADO)cbUser_Thu.SelectedValue;
            int nguoiDongId = selectedUser.Id;
            int khoanThuId = currentKhoanThuId;
            string ghiChu = txtGhiChu_Thu.Text.Trim();
            DateTime ngayDong = dtpNgayDong.Value.Date;

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string update = "update Thu ";
            update += string.Format("set NguoiDong = {0}, GhiChu = N'{1}', NgayThu = '{2}' ", nguoiDongId, ghiChu, ngayDong);
            update += string.Format("where id = {0}", currentThuId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            resetDataThu();
            loadThuGridView(currentKhoanThuId, getOrderBy_Thu());
            con.Close();
        }

        private void btnXoaThu_Click_1(object sender, EventArgs e)
        {
            if (currentThuId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_LAN_THU, "xoá"), WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string deleteCommand = string.Format("delete from Thu where id = {0}", currentThuId);
            sqlDataAdapter.DeleteCommand = new SqlCommand(deleteCommand, con);
            try
            {
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                loadThuGridView(currentKhoanThuId, getOrderBy_Thu());
                resetDataThu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(THONG_BAO_KHONG_THE_XOA_LAN_THU_NAY, WARNING);
            }

            con.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            // validate data
            if (!validateFormKhoanChi())
            {
                return;
            }
            string tenKhoanChi = txtTenKhoanChi.Text.Trim();
            int soTien = Int32.Parse(txtSoTien_KhoanChi.Text.Trim());

            //insert
            string insertCommand = string.Format("insert into Khoanchi values (N'{0}', {1})", tenKhoanChi, soTien);
            sqlDataAdapter.InsertCommand = new SqlCommand(insertCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            loadKhoanChi();
            resetDataKhoanChi();
            con.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // validate
            if (currentKhoanChiId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_KHOAN, "chi", "sửa"), WARNING);
                return;
            }

            if (!validateFormKhoanChi())
            {
                return;
            }
            string tenKhoanChi = txtTenKhoanChi.Text.Trim();
            int soTien = Int32.Parse(txtSoTien_KhoanChi.Text.Trim());

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string update = "update Khoanchi ";
            update += string.Format("set TenKhoanChi = N'{0}', SoTien = {1} ", tenKhoanChi, soTien);
            update += string.Format("where id = {0}", currentKhoanChiId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            resetDataKhoanChi();
            loadKhoanChi();
            con.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (currentKhoanChiId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_KHOAN, "chi", "xoá"), WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string deleteCommand = string.Format("delete from Khoanchi where id = {0}", currentKhoanChiId);
            sqlDataAdapter.DeleteCommand = new SqlCommand(deleteCommand, con);
            try
            {
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                loadKhoanChi();
                resetDataKhoanChi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(THONG_BAO_KHONG_THE_XOA_KHOAN_NAY, "chi"), WARNING);
            }

            con.Close();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (currentKhoanChiId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_KHOAN, "chi", "thêm một lần chi"), WARNING);
                return;
            }

            if (!validateFormChi())
            {
                return;
            }

            UserADO selectedUser = (UserADO)cbUser_Chi.SelectedValue;
            int nguoiChiId = selectedUser.Id;
            int khoanChiId = currentKhoanChiId;
            string ghiChu = txtGhiChu_Chi.Text.Trim();
            DateTime ngayChi = dtpNgayChi.Value.Date;

            //insert
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string insertCommand = "insert into Chi ";
            insertCommand += string.Format("values({0}, {1}, N'{2}', '{3}')", nguoiChiId, khoanChiId, ghiChu, ngayChi);
            sqlDataAdapter.InsertCommand = new SqlCommand(insertCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            resetDataChi();
            loadChiGridView(currentKhoanChiId, string.Empty);
            con.Close();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            if (currentChiId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_LAN_CHI, "sửa"), WARNING);
                return;
            }

            if (!validateFormChi())
            {
                return;
            }

            UserADO selectedUser = (UserADO)cbUser_Chi.SelectedValue;
            int nguoiChiId = selectedUser.Id;
            int khoanChiId = currentKhoanChiId;
            string ghiChu = txtGhiChu_Chi.Text.Trim();
            DateTime ngayChi = dtpNgayChi.Value.Date;

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string update = "update Chi ";
            update += string.Format("set NguoiChi = {0}, GhiChu = N'{1}', NgayChi = '{2}' ", nguoiChiId, ghiChu, ngayChi);
            update += string.Format("where id = {0}", currentChiId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            resetDataChi();
            loadChiGridView(currentKhoanChiId, getOrderBy_Chi());
            con.Close();
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            if (currentChiId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_LAN_CHI, "xoá"), WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string deleteCommand = string.Format("delete from Chi where id = {0}", currentChiId);
            sqlDataAdapter.DeleteCommand = new SqlCommand(deleteCommand, con);
            try
            {
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                loadChiGridView(currentKhoanChiId, getOrderBy_Chi());
                resetDataChi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(THONG_BAO_KHONG_THE_XOA_LAN_CHI_NAY, WARNING);
            }

            con.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

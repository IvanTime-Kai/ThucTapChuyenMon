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
    public partial class frmQL_Luong : Form
    {
        const string BAC_SI = "Bác sĩ";
        const string LE_TAN = "Lễ tân";
        const string ID = "id";
        const string BUTTONS = "Buttons";
        const string NONE = "(None)";
        const string DA_TRA = "Đã trả";
        const string CHUA_TRA = "Chưa trả";
        const int MIN_LUONG = 500;
        const int MAX_LUONG = 10000;
        const string MUC_LUONG = "MucLuong";
        const string WARNING = "Cảnh báo!";
        const string THONG_BAO_MUC_LUONG_KHONG_HOP_LE = "Mức lương không hợp lệ!";
        const string THONG_BAO_VUI_LONG_CHON_ROLE = "Chọn role để chỉnh sửa mức lương!";

        int currentRoleId = 0;
        public frmQL_Luong()
        {
            InitializeComponent();
        }

        private void taoTraLuongThangTruocNeuChuaTonTai()
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string thangTruoc = DateTime.Now.AddMonths(-1).Date.Month.ToString();
            string query = "select * from TraLuong ";
            query += string.Format("where MONTH(ThangLuong) = {0}", thangTruoc);
            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();
            if (!sqlDataReader.HasRows) // Kiểm tra, nếu chưa tạo trả lương cho nhân viên tháng trước thì sẽ tạo
            {
                // lấy id và chức vụ của nhân viên để tính lương và thêm vào bảng trả lương
                List<ThongTinTraLuongADO> listThongTinTraLuong = new List<ThongTinTraLuongADO>();
                con = ConnectProvider.GetConnection(); con.Open();
                query = "select Users.id, Users.NgayVaoLam, Roles.MucLuong, Roles.role_name ";
                query += "from Users inner join Roles on Users.Chucvu = Roles.id ";
                query += "where Roles.role_name != N'Giám đốc'";
                sqlCommand = new SqlCommand(query, con);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    int nhanVienId = sqlDataReader.GetInt32(0);
                    DateTime ngayVaoLam = sqlDataReader.GetDateTime(1);
                    int mucLuong = sqlDataReader.GetInt32(2);
                    string roleName = sqlDataReader.GetString(3);
                    listThongTinTraLuong.Add(new ThongTinTraLuongADO(nhanVienId, ngayVaoLam, mucLuong, roleName));
                }

                foreach (ThongTinTraLuongADO item in listThongTinTraLuong) // lặp qua tính lương cho từng nhan viên
                {
                    double soTienTra = item.MucLuong;
                    // xét tăng lương theo số năm làm việc
                    double soNamLamViec = Convert.ToInt32(Math.Floor((DateTime.Now.Date - item.NgayVaoLam.Date).TotalDays / 365));
                    double luongTheoSoNam = 0;
                    if (item.RoleName.Equals(BAC_SI))
                    { // bác sĩ mỗi năm làm việc tăng 1000, lễ tân 500
                        luongTheoSoNam = soNamLamViec * 1000;
                    }
                    else if (item.RoleName.Equals(LE_TAN))
                    {
                        luongTheoSoNam = soNamLamViec * 500;
                    }
                    soTienTra += luongTheoSoNam;

                    // nếu là tháng cuối cùng của năm thì thưởng 300
                    if (thangTruoc.Equals("12"))
                        soTienTra += 300;

                    // tính sổ ca trực chưa hoàn thành của bác sĩ để trừ lương, mỗi buổi ko trực -100
                    if (item.RoleName.Equals(BAC_SI))
                    {
                        con = ConnectProvider.GetConnection(); con.Open();
                        query = "select count(*) ";
                        query += "from Catruc ";
                        query += string.Format("where NguoiTruc = {0} AND TrangThai = N'Chưa Hoàn Thành' AND MONTH(NgayTruc) = {1}", item.Id, thangTruoc);
                        sqlCommand = new SqlCommand(query, con);
                        sqlDataReader = sqlCommand.ExecuteReader(); sqlDataReader.Read();
                        int soBuoiBoTruc = sqlDataReader.GetInt32(0);

                        if (soBuoiBoTruc < 10)
                        {
                            int soTienTru = soBuoiBoTruc * 100;
                            soTienTra -= soTienTru;
                        }
                        else // nếu bỏ từ 10 buổi trực trở lên thì không tính lương
                        {
                            soTienTra = 0;
                        }

                        con.Close();
                    }

                    // sau khi tính toán lương xong thì thêm xuống database
                    DateTime thangLuong = new DateTime(DateTime.Now.Date.Year, Int32.Parse(thangTruoc), 01);
                    con = ConnectProvider.GetConnection(); con.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    string insert = "insert into TraLuong(SoTienTra, ThangLuong, NguoiDuocTra) ";
                    insert += string.Format("values ({0}, '{1}', {2})", soTienTra, thangLuong, item.Id);
                    sqlDataAdapter.InsertCommand = new SqlCommand(insert, con);
                    sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                    con.Close();

                }

                con.Close();
            }

            con.Close();
        }

        private void setUp()
        {
            // custom controls
            dgv_TraLuong.ReadOnly = true;
            dgv_TraLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgv_TraLuong.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv_TraLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_TraLuong.MultiSelect = false;
            dgv_TraLuong.BackgroundColor = Color.White;
            dgv_TraLuong.RowHeadersVisible = false;
            dgv_TraLuong.AllowUserToResizeRows = false;

            dgv_Roles.ReadOnly = true;
            dgv_Roles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgv_Roles.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv_Roles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Roles.MultiSelect = false;
            dgv_Roles.BackgroundColor = Color.White;
            dgv_Roles.RowHeadersVisible = false;
            dgv_Roles.AllowUserToResizeRows = false;


            cb_filter.DropDownStyle = ComboBoxStyle.DropDownList; cb_trangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_filter.SelectedIndex = 1; cb_trangThai.SelectedIndex = 0;

            // load data to gridview
            loadTraLuong(string.Empty, string.Empty);
            loadRole();
            dgv_TraLuong.Columns[ID].Visible = false;
            dgv_Roles.Columns[ID].Visible = false;
        }

        private void loadRole()
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select * from Roles";
            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<RoleADO> listRole = new List<RoleADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string roleName = sqlDataReader.GetString(1);
                int mucLuong = sqlDataReader.GetInt32(2);

                listRole.Add(new RoleADO(id, roleName, mucLuong));
            }

            dgv_Roles.DataSource = listRole;
            con.Close();
        }

        private void loadTraLuong(string filter, string trangThai)
        {
            string thangTruoc = DateTime.Now.AddMonths(-1).Date.Month.ToString();

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select Users.Ten, TraLuong.ThangLuong, Roles.role_name, TraLuong.NgayTra, TraLuong.id, TraLuong.SoTienTra ";
            query += "from TraLuong inner join Users On TraLuong.NguoiDuocTra = Users.id inner join Roles on Users.Chucvu = Roles.id ";

            if (filter.Equals(string.Empty)) // nếu filter là chuỗi rỗng thì ta chỉ load tháng trước
            {
                query += string.Format("where MONTH(ThangLuong) = {0} ", thangTruoc);
            }
            else // nếu filter không rỗng thì ta load hết lịch sử trả lương tất cả tháng
            {
                query += string.Format("where MONTH(ThangLuong) <= {0} ", thangTruoc);
            }

            if (trangThai.Equals(DA_TRA))
            {
                query += "AND NgayTra IS NOT NULL";
            }
            else if (trangThai.Equals(CHUA_TRA))
            {
                query += "AND NgayTra IS NULL";
            }

            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<TraLuongADO> listTraLuong = new List<TraLuongADO>();
            while (sqlDataReader.Read())
            {
                string ten = sqlDataReader.GetString(0);
                string thangLuong = sqlDataReader.GetDateTime(1).ToString("MM-yyyy");
                string chucVu = sqlDataReader.GetString(2);
                DateTime? ngayTra;
                try
                {
                    ngayTra = sqlDataReader.GetDateTime(3);
                }
                catch (Exception ex)
                {
                    ngayTra = null;
                }
                int id = sqlDataReader.GetInt32(4);
                int soTienTra = sqlDataReader.GetInt32(5);

                listTraLuong.Add(new TraLuongADO(id, ten, thangLuong, chucVu, ngayTra, soTienTra));
            }


            dgv_TraLuong.DataSource = listTraLuong;

            con.Close();
        }

        private void frmQL_Luong_Load(object sender, EventArgs e)
        {
            taoTraLuongThangTruocNeuChuaTonTai(); // khi mới load form sẽ kiểm tra xem đã tính lương cho nhân viên tháng trước chưa, nếu chưa thì tính toàn và thêm vào db
            setUp();

            /*Thêm button Trả lương cho gridview*/
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv_TraLuong.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Trả lương";
            btn.Name = BUTTONS;
            btn.UseColumnTextForButtonValue = true;
            /**/

            //MessageBox.Show("asd: " + DateTime.ParseExact(DateTime.Now.Date.ToString("MM-yyyy"), "MM-yyyy", CultureInfo.InvariantCulture));
        }

        private string getFilter()
        {
            string selectedFilter = cb_filter.Text;

            if (selectedFilter.Equals(NONE))
            {
                return "Load all months";
            }
            else
            {
                return string.Empty;
            }
        }

        private void dgv_TraLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                String columnName = dgv_TraLuong.Columns[e.ColumnIndex].Name;
                if (columnName.Equals(BUTTONS)) // khi click vào nút "Trả lương" thì sẽ đánh dấu ngày trả lương cho nhân viên là ngày hiện tái
                {
                    DataGridViewRow row = dgv_TraLuong.Rows[e.RowIndex];
                    int traLuongId = Int32.Parse(row.Cells[ID].Value.ToString());

                    // nếu chưa đánh dấu trả lương thì đánh dấu, nếu đã đánh dấu thì bỏ đánh dấu
                    SqlConnection con = ConnectProvider.GetConnection(); con.Open();
                    SqlDataReader sqlDataReader; SqlCommand sqlCommand;
                    string query = "select NgayTra from TraLuong ";
                    query += string.Format("where id = {0}", traLuongId);
                    sqlCommand = new SqlCommand(query, con);
                    sqlDataReader = sqlCommand.ExecuteReader(); sqlDataReader.Read();
                    try // nếu đã đánh dấu trả lương
                    {
                        DateTime ngayTra = sqlDataReader.GetDateTime(0);

                        con = ConnectProvider.GetConnection(); con.Open();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        string update = "update TraLuong ";
                        update += string.Format("set NgayTra = {0} ", "null");
                        update += string.Format("where id = {0}", traLuongId);
                        sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
                        sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

                        loadTraLuong(getFilter(), cb_trangThai.Text);
                        con.Close();
                    }
                    catch (Exception ex) // nếu chưa đánh dấu trả lương (cột NgayTra sẽ bằng null và khi GetDateTime(0) thì sẽ nhảy xuống khối catch)
                    {
                        DateTime current = DateTime.Now.Date;

                        con = ConnectProvider.GetConnection(); con.Open();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        string update = "update TraLuong ";
                        update += string.Format("set NgayTra = '{0}' ", current);
                        update += string.Format("where id = {0}", traLuongId);
                        sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
                        sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

                        loadTraLuong(getFilter(), cb_trangThai.Text);
                        con.Close();
                    }
                    con.Close();
                }
            }
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTraLuong(getFilter(), cb_trangThai.Text);
        }

        private void cb_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTraLuong(getFilter(), cb_trangThai.Text);
        }

        private void dgv_Roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Roles.SelectedRows[0];
                int mucLuong = Int32.Parse(row.Cells[MUC_LUONG].Value.ToString());
                int roleId = Int32.Parse(row.Cells[ID].Value.ToString());
                txtMucLuong.Text = mucLuong.ToString();
                currentRoleId = roleId;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            // validate
            int mucLuong = 0;
            if (txtMucLuong.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(THONG_BAO_MUC_LUONG_KHONG_HOP_LE, WARNING);
                return;
            }

            try
            {
                mucLuong = Int32.Parse(txtMucLuong.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(THONG_BAO_MUC_LUONG_KHONG_HOP_LE, WARNING);
                return;
            }

            if (mucLuong < MIN_LUONG || mucLuong > MAX_LUONG)
            {
                MessageBox.Show(THONG_BAO_MUC_LUONG_KHONG_HOP_LE, WARNING);
                return;
            }

            if (currentRoleId == 0)
            {
                MessageBox.Show(THONG_BAO_VUI_LONG_CHON_ROLE, WARNING);
                return;
            }


            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string update = "update Roles ";
            update += string.Format("set MucLuong = {0} ", mucLuong);
            update += string.Format("where id = {0}", currentRoleId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            currentRoleId = 0;
            txtMucLuong.Text = string.Empty;
            loadRole();
            con.Close();
        }
    }
}

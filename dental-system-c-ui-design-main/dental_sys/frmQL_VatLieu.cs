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
    public partial class frmQL_VatLieu : Form
    {
        const string TEN_NHOM_VL_KHONG_BO_TRONG = "Tên nhóm vật liệu không được bỏ trống!";
        const string THONG_BAO_VUI_LONG_CHON_NHOM_VAT_LIEU = "Chọn nhóm vật liệu để {0}";
        const string THONG_BAO_VUI_LONG_CHON_VAT_LIEU = "Chọn vật liệu để {0}";
        const string THONG_BAO_VUI_LONG_CHON_NHAP_VAT_LIEU = "Chọn một lần nhập vật liệu để xoá!";
        const string THONG_BAO_VUI_LONG_CHON_XUAT_VAT_LIEU = "Chọn một lần xuất vật liệu để xoá!";
        const string THONG_BAO_THONG_TIN_VAT_LIEU_KHONG_HOP_LE = "Thông tin vật liệu không hợp lệ!";
        const string THONG_BAO_KHONG_THE_XOA_NHOM_VAT_LIEU_NAY = "Không thể xoá nhóm vật liệu này!";
        const string THONG_BAO_KHONG_THE_XOA__VAT_LIEU_NAY = "Không thể xoá nhóm vật liệu này!";
        const string THONG_BAO_KHONG_DU_SO_LUONG_VAT_LIEU_DE_XUAT = "Không đủ số lượng để xuất!";
        const string WARNING = "Cảnh báo!";

        const int MIN_DON_GIA = 0;
        const string ID = "id";
        const string TEN_NHOM = "TenNhom";
        const string TEN_VAT_LIEU = "TenVatLieu";
        const string DON_VI = "DonVi";
        const string DON_GIA = "DonGia";
        const string SO_LUONG = "SoLuong";
        const string TONG_TIEN = "TongTien";
        const string NGAY_NHAP = "NgayNhap";
        const string NGAY_XUAT = "NgayXuat";


        int currentNhomVatLieuId = 0;
        int currentVatLieuId = 0;
        int currentDonGiaVatLieu_Nhap = 0; // để tính tổng tiền nhập
        int currentNhapVatLieuId = 0; // để xoá nhập vật liệu
        int currentXuatVatLieuId = 0; // để xoá xuất vật liệu

        public frmQL_VatLieu()
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

        private void setUpQuanLiVatLieu()
        {
            // custom controls
            formatDataGridView(dgv_NhomVatLieu);
            formatDataGridView(dgv_VatLieu);

            cbDonViVatLieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDonViVatLieu.SelectedIndex = 0;


            // load data to gridview
            loadNhomVatLieu();
            dgv_NhomVatLieu.Columns[ID].Visible = false;


            try // Nếu có nhóm vật liệu thì hiển thị những vật liệu của nhóm đó ra, nếu chưa có nhóm vật liệu nào thì thoi
            {
                DataGridViewRow row = dgv_NhomVatLieu.Rows[0];
                int firstIdNhomVatLieu = Int32.Parse(row.Cells[ID].Value.ToString());
                loadVatLieuToGridView(firstIdNhomVatLieu, string.Empty);
                dgv_VatLieu.Columns[ID].Visible = false;
                currentNhomVatLieuId = firstIdNhomVatLieu;
            }
            catch (Exception ex)
            {

            }
        }

        private void setUpNhapVatLieu()
        {
            // custom controls
            formatDataGridView(dgv_NhapVatLieu);

            // load data to comboBox
            loadTenVatLieuToComboBox(cbTenVatLieu_Nhap);

            cbTenVatLieu_Nhap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenVatLieu_Nhap.SelectedIndex = 0;
            cbSapXep_Nhap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSapXep_Nhap.SelectedIndex = 0;

            loadNhapVatLieu(null, null, string.Empty);

            // format datetimepicker
            dtpFrom_Nhap.Format = DateTimePickerFormat.Custom;
            dtpFrom_Nhap.CustomFormat = "dd-MM-yyyy";
            dtpTo_Nhap.Format = DateTimePickerFormat.Custom;
            dtpTo_Nhap.CustomFormat = "dd-MM-yyyy";
            dtpFrom_Nhap.Value = DateTime.Now.AddDays(-10).Date;
            dtpTo_Nhap.Value = DateTime.Now.AddDays(10).Date;
        }

        private void setUpXuatVatLieu()
        {
            // custom controls
            formatDataGridView(dgv_XuatVatLieu);

            // load data to comboBox
            loadTenVatLieuToComboBox(cbTenVatLieu_Xuat);

            cbTenVatLieu_Xuat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenVatLieu_Xuat.SelectedIndex = 0;
            cbSapXep_Xuat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSapXep_Xuat.SelectedIndex = 0;

            loadXuatVatLieu(null, null, string.Empty);

            // format datetimepicker
            dtpFrom_Xuat.Format = DateTimePickerFormat.Custom;
            dtpFrom_Xuat.CustomFormat = "dd-MM-yyyy";
            dtpTo_Xuat.Format = DateTimePickerFormat.Custom;
            dtpTo_Xuat.CustomFormat = "dd-MM-yyyy";
            dtpFrom_Xuat.Value = DateTime.Now.AddDays(-10).Date;
            dtpTo_Xuat.Value = DateTime.Now.AddDays(10).Date;
        }

        private void loadNhomVatLieu()
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select * from NhomVatLieu";
            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<NhomVatLieuADO> listNhomVatLieu = new List<NhomVatLieuADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string tenNhom = sqlDataReader.GetString(1);
                listNhomVatLieu.Add(new NhomVatLieuADO(id, tenNhom));
            }

            dgv_NhomVatLieu.DataSource = listNhomVatLieu;

            con.Close();
        }

        private void loadVatLieuToGridView(int nhomVatLieuId, string timKiem) // load những vật liệu thuộc một nhóm 
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select id, TenVatLieu, DonVi, TongNhap, TongXuat, TonKho, DonGia from VatLieu ";
            query += string.Format("where NhomVatLieu = {0} ", nhomVatLieuId);
            if (!timKiem.Equals(string.Empty))
                query += string.Format("AND TenVatLieu LIKE N'%{0}%'", timKiem);

            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<VatLieuADO> listVatLieu = new List<VatLieuADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string tenVatLieu = sqlDataReader.GetString(1);
                string donVi = sqlDataReader.GetString(2);
                int tongNhap = sqlDataReader.GetInt32(3);
                int tongXuat = sqlDataReader.GetInt32(4);
                int tonKho = sqlDataReader.GetInt32(5);
                int donGia = sqlDataReader.GetInt32(6);
                listVatLieu.Add(new VatLieuADO(id, tenVatLieu, donVi, tongNhap, tongXuat, tonKho, donGia));
            }

            dgv_VatLieu.DataSource = listVatLieu;

            con.Close();
        }

        private void loadNhapVatLieu(DateTime? from, DateTime? to, string orderBy)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select NVL.id, VL.TenVatLieu, NVL.Soluong, NVL.TongTien, NVL.NgayNhap ";
            query += "from NhapVatLieu NVL inner join VatLieu VL on NVL.VatLieu_id = VL.id ";

            if (from != null && to != null)
            {
                query += string.Format("where NVL.NgayNhap BETWEEN '{0}' AND '{1}' ", from, to);
            }

            if (!orderBy.Equals(string.Empty))
            {
                query += string.Format("order by {0} ", orderBy);
            }

            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<NhapVatLieuADO> listNhapVatLieu = new List<NhapVatLieuADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string tenVatLieu = sqlDataReader.GetString(1);
                int soLuong = sqlDataReader.GetInt32(2);
                int tongTien = sqlDataReader.GetInt32(3);
                DateTime ngayNhap = sqlDataReader.GetDateTime(4);
                listNhapVatLieu.Add(new NhapVatLieuADO(id, tenVatLieu, soLuong, tongTien, ngayNhap));
            }

            dgv_NhapVatLieu.DataSource = listNhapVatLieu;

            con.Close();
        }

        private void loadXuatVatLieu(DateTime? from, DateTime? to, string orderBy)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select XVL.id, VL.TenVatLieu, XVL.Soluong,  XVL.NgayXuat ";
            query += "from XuatVatLieu XVL inner join VatLieu VL on XVL.VatLieu_id = VL.id ";

            if (from != null && to != null)
            {
                query += string.Format("where XVL.NgayXuat BETWEEN '{0}' AND '{1}' ", from, to);
            }

            if (!orderBy.Equals(string.Empty))
            {
                query += string.Format("order by {0} ", orderBy);
            }

            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<XuatVatLieuADO> listXuatVatLieu = new List<XuatVatLieuADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string tenVatLieu = sqlDataReader.GetString(1);
                int soLuong = sqlDataReader.GetInt32(2);
                DateTime ngayXuat = sqlDataReader.GetDateTime(3);
                listXuatVatLieu.Add(new XuatVatLieuADO(id, tenVatLieu, soLuong, ngayXuat));
            }

            dgv_XuatVatLieu.DataSource = listXuatVatLieu;

            con.Close();
        }

        private void loadTenVatLieuToComboBox(ComboBox comboBox)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select id, TenVatLieu, DonVi, TongNhap, TongXuat, TonKho, DonGia from VatLieu ";
            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<VatLieuADO> listVatLieu = new List<VatLieuADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string tenVatLieu = sqlDataReader.GetString(1);
                string donVi = sqlDataReader.GetString(2);
                int tongNhap = sqlDataReader.GetInt32(3);
                int tongXuat = sqlDataReader.GetInt32(4);
                int tonKho = sqlDataReader.GetInt32(5);
                int donGia = sqlDataReader.GetInt32(6);
                listVatLieu.Add(new VatLieuADO(id, tenVatLieu, donVi, tongNhap, tongXuat, tonKho, donGia));
            }

            comboBox.ValueMember = null;
            comboBox.DisplayMember = TEN_VAT_LIEU;
            comboBox.DataSource = listVatLieu;

            con.Close();
        }

        private void frmQL_VatLieu_Load(object sender, EventArgs e)
        {
            setUpQuanLiVatLieu();
            setUpNhapVatLieu();
            setUpXuatVatLieu();
        }

        private void resetDataNhomVatLieu()
        {
            txtTenNhomVatLieu.Text = string.Empty;
            currentNhomVatLieuId = 0;
        }

        private void resetDataVatLieu()
        {
            txtTenVatLieu.Text = string.Empty;
            cbDonViVatLieu.SelectedIndex = 0;
            txtDonGia.Text = string.Empty;
            currentVatLieuId = 0;
        }

        private void resetDataNhapVatLieu()
        {
            cbTenVatLieu_Nhap.SelectedIndex = 0;
            nudSoLuong_Nhap.Value = 1;
            txtTongTien.Text = currentDonGiaVatLieu_Nhap.ToString();
            currentNhapVatLieuId = 0;
        }

        private void resetDataXuatVatLieu()
        {
            cbTenVatLieu_Xuat.SelectedIndex = 0;
            nudSoLuong_Xuat.Value = 1;
            currentXuatVatLieuId = 0;
        }

        private void btnThem_NhomVL_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            // get data from form
            string tenNhom = txtTenNhomVatLieu.Text.Trim();

            // validate data
            if (tenNhom.Equals(string.Empty))
            {
                MessageBox.Show(TEN_NHOM_VL_KHONG_BO_TRONG, WARNING);
                return;
            }

            //insert
            string insertCommand = string.Format("insert into NhomVatLieu values(N'{0}')", tenNhom);
            sqlDataAdapter.InsertCommand = new SqlCommand(insertCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            loadNhomVatLieu();
            resetDataNhomVatLieu();
            con.Close();
        }

        private void btnSua_NhomVL_Click(object sender, EventArgs e)
        {
            // validate
            string tenNhom = txtTenNhomVatLieu.Text.Trim();
            if (tenNhom.Equals(string.Empty))
            {
                MessageBox.Show(TEN_NHOM_VL_KHONG_BO_TRONG, WARNING);
                return;
            }

            if (currentNhomVatLieuId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_NHOM_VAT_LIEU, "sửa"), WARNING);
                return;
            }


            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string update = "update NhomVatLieu ";
            update += string.Format("set TenNhom = N'{0}' ", tenNhom);
            update += string.Format("where id = {0}", currentNhomVatLieuId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            resetDataNhomVatLieu();
            loadNhomVatLieu();
            con.Close();
        }

        private void btnXoa_NhomVL_Click(object sender, EventArgs e)
        {
            if (currentNhomVatLieuId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_NHOM_VAT_LIEU, "xoá"), WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string deleteCommand = string.Format("delete from NhomVatLieu where id = {0}", currentNhomVatLieuId);
            sqlDataAdapter.DeleteCommand = new SqlCommand(deleteCommand, con);
            try
            {
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                loadNhomVatLieu();
                resetDataNhomVatLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(THONG_BAO_KHONG_THE_XOA_NHOM_VAT_LIEU_NAY, WARNING);
            }

            con.Close();
        }

        private void dgv_NhomVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // bổ sung điều kiện này vào sự kiện CellClick của những DataGridView
            {
                DataGridViewRow row = dgv_NhomVatLieu.SelectedRows[0];
                int id = Int32.Parse(row.Cells[ID].Value.ToString());
                string tenNhom = row.Cells[TEN_NHOM].Value.ToString();
                txtTenNhomVatLieu.Text = tenNhom;
                currentNhomVatLieuId = id;

                loadVatLieuToGridView(currentNhomVatLieuId, string.Empty);
                dgv_VatLieu.Columns[ID].Visible = false;
                resetDataVatLieu();
            }
        }

        private bool validateFormVatLieu()
        {
            if (txtTenVatLieu.Text.Trim().Equals(string.Empty))
                return false;

            int donGia = 0;
            try
            {
                donGia = Int32.Parse(txtDonGia.Text.Trim());
            }
            catch (Exception ex)
            {
                return false;
            }

            if (donGia <= MIN_DON_GIA)
                return false;

            return true;
        }

        private void btnThem_VL_Click(object sender, EventArgs e)
        {
            if (currentNhomVatLieuId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_NHOM_VAT_LIEU, "thêm vật liệu"), WARNING);
                return;
            }

            if (!validateFormVatLieu())
            {
                MessageBox.Show(THONG_BAO_THONG_TIN_VAT_LIEU_KHONG_HOP_LE, WARNING);
                return;
            }

            string tenVatLieu = txtTenVatLieu.Text.Trim();
            string donVi = cbDonViVatLieu.Text;
            int tongNhap = 0;
            int tongXuat = 0;
            int tonKho = 0;
            int donGia = Int32.Parse(txtDonGia.Text.Trim());

            //insert
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string insertCommand = "insert into VatLieu ";
            insertCommand += string.Format("values (N'{0}', N'{1}', {2}, {3}, {4}, {5}, {6})", tenVatLieu, donVi, tongNhap, tongXuat, tonKho, currentNhomVatLieuId, donGia);
            sqlDataAdapter.InsertCommand = new SqlCommand(insertCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            loadVatLieuToGridView(currentNhomVatLieuId, string.Empty);
            resetDataVatLieu();
            con.Close();

            // Cập nhật lại thông tin dữ liệu lên combobox
            loadTenVatLieuToComboBox(cbTenVatLieu_Nhap);
            loadTenVatLieuToComboBox(cbTenVatLieu_Xuat);
        }

        private void btnSua_VL_Click(object sender, EventArgs e)
        {
            if (currentVatLieuId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_VAT_LIEU, "sửa"), WARNING);
                return;
            }

            if (!validateFormVatLieu())
            {
                MessageBox.Show(THONG_BAO_THONG_TIN_VAT_LIEU_KHONG_HOP_LE, WARNING);
                return;
            }

            string tenVatLieu = txtTenVatLieu.Text.Trim();
            string donVi = cbDonViVatLieu.Text;
            int donGia = Int32.Parse(txtDonGia.Text.Trim());

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string update = "update VatLieu ";
            update += string.Format("set TenVatLieu = N'{0}', DonVi = N'{1}', DonGia = {2} ", tenVatLieu, donVi, donGia);
            update += string.Format("where id = {0}", currentVatLieuId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            resetDataVatLieu();
            loadVatLieuToGridView(currentNhomVatLieuId, txtTimKiem.Text);
            con.Close();

            // Cập nhật lại thông tin dữ liệu lên combobox
            loadTenVatLieuToComboBox(cbTenVatLieu_Nhap);
            loadTenVatLieuToComboBox(cbTenVatLieu_Xuat);
        }

        private void dgv_VatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_VatLieu.SelectedRows[0];

                txtTenVatLieu.Text = row.Cells[TEN_VAT_LIEU].Value.ToString();
                cbDonViVatLieu.Text = row.Cells[DON_VI].Value.ToString();
                txtDonGia.Text = row.Cells[DON_GIA].Value.ToString();
                currentVatLieuId = Int32.Parse(row.Cells[ID].Value.ToString());
            }
        }

        private void btnXoa_VL_Click(object sender, EventArgs e)
        {
            if (currentVatLieuId == 0)
            {
                MessageBox.Show(string.Format(THONG_BAO_VUI_LONG_CHON_VAT_LIEU, "xoá"), WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string deleteCommand = string.Format("delete from VatLieu where id = {0}", currentVatLieuId);
            sqlDataAdapter.DeleteCommand = new SqlCommand(deleteCommand, con);
            try
            {
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                loadVatLieuToGridView(currentNhomVatLieuId, txtTimKiem.Text);
                resetDataVatLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(THONG_BAO_KHONG_THE_XOA__VAT_LIEU_NAY, WARNING);
            }

            con.Close();

            // Cập nhật lại thông tin dữ liệu lên combobox
            loadTenVatLieuToComboBox(cbTenVatLieu_Nhap);
            loadTenVatLieuToComboBox(cbTenVatLieu_Xuat);
        }

        private void cbTenVatLieu_Nhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            VatLieuADO selectedVatLieu = (VatLieuADO)cbTenVatLieu_Nhap.SelectedValue;
            currentDonGiaVatLieu_Nhap = selectedVatLieu.DonGia;

            // chọn 1 vật liệu trên combobox thì chúng ta sẽ load lại số lượng và tổng tiền
            nudSoLuong_Nhap.Value = 1;
            txtTongTien.Text = currentDonGiaVatLieu_Nhap.ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            VatLieuADO selectedVatLieu = (VatLieuADO)cbTenVatLieu_Nhap.SelectedValue;

            DateTime ngayNhap = DateTime.Now.Date;
            int soLuong = Int32.Parse(nudSoLuong_Nhap.Value.ToString());
            int tongTien = Int32.Parse(txtTongTien.Text);
            int vatLieuId = selectedVatLieu.Id;

            //insert nhập vật liệu
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string insertCommand = "insert into NhapVatLieu ";
            insertCommand += string.Format("values ('{0}', {1}, {2}, {3})", ngayNhap, vatLieuId, soLuong, tongTien);
            sqlDataAdapter.InsertCommand = new SqlCommand(insertCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            loadNhapVatLieu(null, null, string.Empty);
            resetDataNhapVatLieu();
            con.Close();

            // Sau đó cập nhập tổng nhập và tồn kho của vật liệu đó
            con = ConnectProvider.GetConnection(); con.Open();
            sqlDataAdapter = new SqlDataAdapter();
            string update = "update VatLieu ";
            update += string.Format("set TongNhap = TongNhap + {0}, TonKho = TonKho + {0} ", soLuong);
            update += string.Format("where id = {0}", vatLieuId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            loadVatLieuToGridView(currentNhomVatLieuId, string.Empty);
            loadTenVatLieuToComboBox(cbTenVatLieu_Nhap);
            loadTenVatLieuToComboBox(cbTenVatLieu_Xuat);
            con.Close();
        }

        private void nupSoLuong_Nhap_ValueChanged(object sender, EventArgs e)
        {
            int tongTien = Int32.Parse(nudSoLuong_Nhap.Value.ToString()) * currentDonGiaVatLieu_Nhap;
            txtTongTien.Text = tongTien.ToString();
        }

        private string getOrderBy_Nhap()
        {

            string selectedOrderBy = cbSapXep_Nhap.Text;
            if (selectedOrderBy.Equals("Tên vật liệu"))
            {
                return TEN_VAT_LIEU;
            }
            else if (selectedOrderBy.Equals("Ngày nhập"))
            {
                return NGAY_NHAP;
            }
            else
            {
                return string.Empty;
            }
        }

        private string getOrderBy_Xuat()
        {
            string selectedOrderBy = cbSapXep_Xuat.Text;
            if (selectedOrderBy.Equals("Tên vật liệu"))
            {
                return TEN_VAT_LIEU;
            }
            else if (selectedOrderBy.Equals("Ngày xuất"))
            {
                return NGAY_XUAT;
            }
            else
            {
                return string.Empty;
            }
        }

        private void btnXoa_Nhap_Click(object sender, EventArgs e)
        {
            if (currentNhapVatLieuId == 0)
            {
                MessageBox.Show(THONG_BAO_VUI_LONG_CHON_NHAP_VAT_LIEU, WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string deleteCommand = string.Format("delete from NhapVatLieu where id = {0}", currentNhapVatLieuId);
            sqlDataAdapter.DeleteCommand = new SqlCommand(deleteCommand, con);
            sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
            con.Close();

            // Sau khi xoá 1 lần nhập vật liệu, cập nhập lại tổng nhập và tồn kho
            DataGridViewRow row = dgv_NhapVatLieu.SelectedRows[0];
            int soLuong = Int32.Parse(row.Cells[SO_LUONG].Value.ToString());
            VatLieuADO selectedVatLieu = (VatLieuADO)cbTenVatLieu_Nhap.SelectedValue;
            int vatLieuId = selectedVatLieu.Id;

            con = ConnectProvider.GetConnection(); con.Open();
            sqlDataAdapter = new SqlDataAdapter();
            string update = "update VatLieu ";
            update += string.Format("set TongNhap = TongNhap - {0}, TonKho = TonKho - {0} ", soLuong);
            update += string.Format("where id = {0}", vatLieuId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            // sau khi cập nhật xong thì ta mới load dữ liệu Nhập Vật Liệu lên gridview và reset lại form
            loadVatLieuToGridView(currentNhomVatLieuId, string.Empty);

            loadNhapVatLieu(dtpFrom_Nhap.Value.Date, dtpTo_Nhap.Value.Date, getOrderBy_Nhap());
            resetDataNhapVatLieu();
            loadTenVatLieuToComboBox(cbTenVatLieu_Nhap);
            loadTenVatLieuToComboBox(cbTenVatLieu_Xuat);
            con.Close();
        }

        private void dgv_NhapVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NhapVatLieu.SelectedRows[0];

                cbTenVatLieu_Nhap.Text = row.Cells[TEN_VAT_LIEU].Value.ToString();
                nudSoLuong_Nhap.Value = Int32.Parse(row.Cells[SO_LUONG].Value.ToString());
                txtTongTien.Text = row.Cells[TONG_TIEN].Value.ToString();
                currentNhapVatLieuId = Int32.Parse(row.Cells[ID].Value.ToString());
            }
        }

        private bool validateFromTo(DateTime from, DateTime to)
        {
            return (DateTime.Compare(from, to) > 0) ? false : true; // from không thể sau to
        }

        private void dtpFrom_Nhap_ValueChanged(object sender, EventArgs e)
        {
            if (!validateFromTo(dtpFrom_Nhap.Value, dtpTo_Nhap.Value))
            {
                MessageBox.Show("Thao tác không hợp lệ", WARNING);
                dtpFrom_Nhap.Value = DateTime.Now.AddDays(-10).Date;
                dtpTo_Nhap.Value = DateTime.Now.AddDays(10).Date;
                return; // nếu thông tin ngày tháng sai thì khởi tạo lại date time picker
            }
            loadNhapVatLieu(dtpFrom_Nhap.Value.Date, dtpTo_Nhap.Value.Date, getOrderBy_Nhap());
            resetDataNhapVatLieu();
        }

        private void dtpTo_Nhap_ValueChanged(object sender, EventArgs e)
        {
            if (!validateFromTo(dtpFrom_Nhap.Value, dtpTo_Nhap.Value))
            {
                MessageBox.Show("Thao tác không hợp lệ", WARNING);
                dtpFrom_Nhap.Value = DateTime.Now.AddDays(-10).Date;
                dtpTo_Nhap.Value = DateTime.Now.AddDays(10).Date;
                return; // nếu thông tin ngày tháng sai thì khởi tạo lại date time picker
            }
            loadNhapVatLieu(dtpFrom_Nhap.Value.Date, dtpTo_Nhap.Value.Date, getOrderBy_Nhap());
            resetDataNhapVatLieu();
        }

        private void cbSapXep_Nhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNhapVatLieu(dtpFrom_Nhap.Value.Date, dtpTo_Nhap.Value.Date, getOrderBy_Nhap());
            resetDataNhapVatLieu();
        }

        private void btnReset_Nhap_Click(object sender, EventArgs e)
        {
            resetDataNhapVatLieu();
            dtpFrom_Nhap.Value = DateTime.Now.AddDays(-10).Date;
            dtpTo_Nhap.Value = DateTime.Now.AddDays(10).Date;
            cbSapXep_Nhap.SelectedIndex = 0;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            VatLieuADO selectedVatLieu = (VatLieuADO)cbTenVatLieu_Xuat.SelectedValue;

            DateTime ngayXuat = DateTime.Now.Date;
            int soLuong = Int32.Parse(nudSoLuong_Xuat.Value.ToString());
            int vatLieuId = selectedVatLieu.Id;

            // kiểm tra xem còn đủ hàng trong kho để xuất không, đủ thì mới cho xuất, không đủ thì thông báo
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = string.Format("select (TonKho - {0}) ", soLuong);
            query += "from VatLieu ";
            query += string.Format("where id = {0}", vatLieuId);
            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader(); sqlDataReader.Read();
            int soLuongTonKhoConLai = sqlDataReader.GetInt32(0);
            if (soLuongTonKhoConLai < 0)
            {
                MessageBox.Show(THONG_BAO_KHONG_DU_SO_LUONG_VAT_LIEU_DE_XUAT, WARNING);
                return;
            }

            // nếu còn đủ số lượng thì xuất bình thường
            con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string insertCommand = "insert into XuatVatLieu ";
            insertCommand += string.Format("values('{0}', {1}, {2})", ngayXuat, vatLieuId, soLuong);
            sqlDataAdapter.InsertCommand = new SqlCommand(insertCommand, con);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            loadXuatVatLieu(null, null, string.Empty);
            resetDataXuatVatLieu();
            con.Close();

            // Sau khi xuất thì cập nhật lại tồn kho và tổng xuất
            con = ConnectProvider.GetConnection(); con.Open();
            sqlDataAdapter = new SqlDataAdapter();
            string update = "update VatLieu ";
            update += string.Format("set TongXuat = TongXuat + {0}, TonKho = TonKho - {0} ", soLuong);
            update += string.Format("where id = {0}", vatLieuId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            loadVatLieuToGridView(currentNhomVatLieuId, string.Empty);
            con.Close();

            // sau khi xuất thì load lại dữ liệu Vật liệu lên combobox để nó cập nhật lại tồn kho
            loadTenVatLieuToComboBox(cbTenVatLieu_Nhap);
            loadTenVatLieuToComboBox(cbTenVatLieu_Xuat);
        }

        private void btnXoa_Xuat_Click(object sender, EventArgs e)
        {
            if (currentXuatVatLieuId == 0)
            {
                MessageBox.Show(THONG_BAO_VUI_LONG_CHON_XUAT_VAT_LIEU, WARNING);
                return;
            }

            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string deleteCommand = string.Format("delete from XuatVatLieu where id = {0}", currentXuatVatLieuId);
            sqlDataAdapter.DeleteCommand = new SqlCommand(deleteCommand, con);
            sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
            con.Close();

            // Sau khi xoá 1 lần xuất vật liệu, cập nhập lại tổng tổng xuất và tồn kho
            DataGridViewRow row = dgv_XuatVatLieu.SelectedRows[0];
            int soLuong = Int32.Parse(row.Cells[SO_LUONG].Value.ToString());
            VatLieuADO selectedVatLieu = (VatLieuADO)cbTenVatLieu_Xuat.SelectedValue;
            int vatLieuId = selectedVatLieu.Id;

            con = ConnectProvider.GetConnection(); con.Open();
            sqlDataAdapter = new SqlDataAdapter();
            string update = "update VatLieu ";
            update += string.Format("set TongXuat = TongXuat - {0}, TonKho = TonKho + {0} ", soLuong);
            update += string.Format("where id = {0}", vatLieuId);
            sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            // sau khi cập nhật xong thì ta mới load dữ liệu Nhập Vật Liệu lên gridview và reset lại form
            loadVatLieuToGridView(currentNhomVatLieuId, string.Empty);

            loadXuatVatLieu(dtpFrom_Nhap.Value.Date, dtpTo_Nhap.Value.Date, getOrderBy_Xuat());
            resetDataXuatVatLieu();
            con.Close();

            // sau khi xuất thì load lại dữ liệu Vật liệu lên combobox để nó cập nhật lại tồn kho
            loadTenVatLieuToComboBox(cbTenVatLieu_Nhap);
            loadTenVatLieuToComboBox(cbTenVatLieu_Xuat);
        }

        private void cbTenVatLieu_Xuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            VatLieuADO selectedVatLieu = (VatLieuADO)cbTenVatLieu_Xuat.SelectedValue;
            int currentTonKho = selectedVatLieu.TonKho;

            // chọn 1 vật liệu trên combobox thì chúng ta sẽ load lại số lượng và tồn kho
            nudSoLuong_Xuat.Value = 1;
            txtTonKho.Text = currentTonKho.ToString();
        }

        private void dgv_XuatVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_XuatVatLieu.SelectedRows[0];
                cbTenVatLieu_Xuat.Text = row.Cells[TEN_VAT_LIEU].Value.ToString();
                nudSoLuong_Xuat.Value = Int32.Parse(row.Cells[SO_LUONG].Value.ToString());

                VatLieuADO selectedVatLieu = (VatLieuADO)cbTenVatLieu_Xuat.SelectedValue;
                txtTonKho.Text = selectedVatLieu.TonKho.ToString();
                currentXuatVatLieuId = Int32.Parse(row.Cells[ID].Value.ToString());
            }
        }

        private void dtpFrom_Xuat_ValueChanged(object sender, EventArgs e)
        {
            if (!validateFromTo(dtpFrom_Nhap.Value, dtpTo_Nhap.Value))
            {
                MessageBox.Show("Thao tác không hợp lệ", WARNING);
                dtpFrom_Xuat.Value = DateTime.Now.AddDays(-10).Date;
                dtpTo_Xuat.Value = DateTime.Now.AddDays(10).Date;
                return; // nếu thông tin ngày tháng sai thì khởi tạo lại date time picker
            }
            loadXuatVatLieu(dtpFrom_Xuat.Value.Date, dtpTo_Xuat.Value.Date, getOrderBy_Xuat());
            resetDataXuatVatLieu();
        }

        private void dtpTo_Xuat_ValueChanged(object sender, EventArgs e)
        {
            if (!validateFromTo(dtpFrom_Nhap.Value, dtpTo_Nhap.Value))
            {
                MessageBox.Show("Thao tác không hợp lệ", WARNING);
                dtpFrom_Xuat.Value = DateTime.Now.AddDays(-10).Date;
                dtpTo_Xuat.Value = DateTime.Now.AddDays(10).Date;
                return; // nếu thông tin ngày tháng sai thì khởi tạo lại date time picker
            }
            loadXuatVatLieu(dtpFrom_Xuat.Value.Date, dtpTo_Xuat.Value.Date, getOrderBy_Xuat());
            resetDataXuatVatLieu();
        }

        private void cbSapXep_Xuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadXuatVatLieu(dtpFrom_Xuat.Value.Date, dtpTo_Xuat.Value.Date, getOrderBy_Xuat());
            resetDataXuatVatLieu();
        }

        private void btnReset_Xuat_Click(object sender, EventArgs e)
        {
            resetDataXuatVatLieu();
            dtpFrom_Xuat.Value = DateTime.Now.AddDays(-10).Date;
            dtpTo_Xuat.Value = DateTime.Now.AddDays(10).Date;
            cbSapXep_Xuat.SelectedIndex = 0;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            loadVatLieuToGridView(currentNhomVatLieuId, txtTimKiem.Text);
        }
    }
}

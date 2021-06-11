using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class frmQL_ThanhToan : Form
    {
        const string ID = "id";
        const string TRANGTHAI = "TrangThai";
        const string CHI_PHI = "ChiPhi";
        const string THANH_TIEN = "ThanhTien";
        const string NGAYKHAM = "NgayKham";
        const string TEN_BENH_NHANH = "TenBenhNhan";
        const string DA_THANH_TOAN = "Đã thanh toán";
        const string CHUA_THANH_TOAN = "Chưa thanh toán";
        const string BUTTONS_THANHTOANTIENMAT = "Btn_Thanhtoantienmat";
        const string BUTTONS_THANHTOANMOMO = "Btn_Thanhtoanmomo";
        const string CONFIRM = "Xác nhận!";
        const string KHACH_HANG_TRA_TIEN_MAT = "Khách hàng trả tiền mặt?";
        const string WARNING = "Cảnh báo!";
        const string BUOI_DIEU_TRI_NAY_DA_THANH_TOAN_ROI = "Buổi điều trị này đã thanh toán rồi!";
        const string DON_THUOC_NAY_DA_THANH_TOAN_ROI = "Đơn thuốc này đã thanh toán rồi";
        #region MOMOPAYMENT CONSTANT
        const string endpoint = "https://test-payment.momo.vn/gw_payment/transactionProcessor";
        const string partnerCode = "MOMOPFDL20210608";
        const string accessKey = "8jqEmzx2HkXgldEN";
        const string serectkey = "lU3ToFMAdM4CDZXdKL1Ob15n3VRcPXm7";
        const string returnUrl = "https://cdn.dribbble.com/users/1735807/screenshots/4290582/03.gif";
        const string notifyurl = "https://www.facebook.com/";
        const string extraData = "";
        #endregion
        public frmQL_ThanhToan()
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

        private void loadBenhNhanToComboBox(ComboBox combobox)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select id, TenBenhNhan from BenhNhan ";
            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<BenhNhanADO> listBenhNhan = new List<BenhNhanADO>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                string tenBenhNhan = sqlDataReader.GetString(1);
                listBenhNhan.Add(new BenhNhanADO(tenBenhNhan, id));
            }

            combobox.ValueMember = null;
            combobox.DisplayMember = TEN_BENH_NHANH;
            combobox.DataSource = listBenhNhan;

            con.Close();
        }

        private void loadThanhToanBDT(int benhNhanId)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select id, NgayKham, ChiPhi, ChuanDoan, GhiChu ,DaThanhToan ";
            query += "from BuoiDieuTri   ";
            query += string.Format("where BenhNhan = {0} ", benhNhanId);

            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<ThanhToanADO_BDT> listThanhToanBDT = new List<ThanhToanADO_BDT>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                DateTime ngayKham = sqlDataReader.GetDateTime(1);
                int chiPhi = sqlDataReader.GetInt32(2);
                string chuanDoan = sqlDataReader.GetString(3);
                string ghiChu = sqlDataReader.GetString(4);
                bool daThanhToan = sqlDataReader.GetBoolean(5);
                string trangThai = daThanhToan ? DA_THANH_TOAN : CHUA_THANH_TOAN;
                listThanhToanBDT.Add(new ThanhToanADO_BDT(id, ngayKham, chiPhi, chuanDoan, ghiChu, trangThai));
            }

            dgv_ThanhToanBDT.DataSource = listThanhToanBDT;

            con.Close();
        }

        private void loadThanhToanDT(int benhNhanId)
        {
            SqlConnection con = ConnectProvider.GetConnection(); con.Open();
            SqlDataReader sqlDataReader; SqlCommand sqlCommand;
            string query = "select DT.id, BDT.NgayKham, U.Ten, DT.ThanhTien, DT.DaThanhToan ";
            query += "from DonThuoc DT inner join BuoiDieuTri BDT on DT.BuoiDieuTri = BDT.id inner join Users U ON BDT.BacSi = U.id   ";
            query += string.Format("where BDT.BenhNhan = {0} ", benhNhanId);

            sqlCommand = new SqlCommand(query, con);
            sqlDataReader = sqlCommand.ExecuteReader();

            List<ThanhToanADO_DT> listThanhToanDT = new List<ThanhToanADO_DT>();
            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);
                DateTime ngayKham = sqlDataReader.GetDateTime(1);
                string nguoiKeDon = sqlDataReader.GetString(2);
                int thanhTien = sqlDataReader.GetInt32(3);
                bool daThanhToan = sqlDataReader.GetBoolean(4);
                string trangThai = daThanhToan ? DA_THANH_TOAN : CHUA_THANH_TOAN;
                listThanhToanDT.Add(new ThanhToanADO_DT(id, ngayKham, nguoiKeDon, thanhTien, trangThai));
            }

            dgv_ThanhToanDT.DataSource = listThanhToanDT;

            con.Close();
        }

        private void setUp_ThanhToan_BDT()
        {
            // custom controls
            formatDataGridView(dgv_ThanhToanBDT);

            // load data BenhNhan to comboBox, format combobox
            loadBenhNhanToComboBox(cbBenhNhan_BDT);
            cbBenhNhan_BDT.DropDownStyle = ComboBoxStyle.DropDownList; cbBenhNhan_BDT.SelectedIndex = 0;

            // load data to gridview
            BenhNhanADO selectedBenhNhan = (BenhNhanADO)cbBenhNhan_BDT.SelectedItem;
            loadThanhToanBDT(selectedBenhNhan.Id);
            dgv_ThanhToanBDT.Columns[ID].Visible = false;
        }

        private void setUp_ThanhToan_DT()
        {
            // custom controls
            formatDataGridView(dgv_ThanhToanDT);

            // load data BenhNhan to comboBox, format combobox
            loadBenhNhanToComboBox(cbBenhNhan_DT);
            cbBenhNhan_DT.DropDownStyle = ComboBoxStyle.DropDownList; cbBenhNhan_DT.SelectedIndex = 0;

            // load data to gridview
            BenhNhanADO selectedBenhNhan = (BenhNhanADO)cbBenhNhan_BDT.SelectedItem;
            loadThanhToanDT(selectedBenhNhan.Id);
            dgv_ThanhToanDT.Columns[ID].Visible = false;
        }

        private void frmQL_ThanhToan_Load(object sender, EventArgs e)
        {
            setUp_ThanhToan_BDT();
            setUp_ThanhToan_DT();

            /*Thêm 2 button Thanh toán cho gridview dgv_ThanhToanBDT, dgv_ThanhToanDT*/
            DataGridViewButtonColumn btnThanhToanTienMat_BDT = new DataGridViewButtonColumn();
            dgv_ThanhToanBDT.Columns.Add(btnThanhToanTienMat_BDT);
            btnThanhToanTienMat_BDT.HeaderText = "";
            btnThanhToanTienMat_BDT.Text = "Tiền mặt";
            btnThanhToanTienMat_BDT.Name = BUTTONS_THANHTOANTIENMAT;
            btnThanhToanTienMat_BDT.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnThanhToanMomo_BDT = new DataGridViewButtonColumn();
            dgv_ThanhToanBDT.Columns.Add(btnThanhToanMomo_BDT);
            btnThanhToanMomo_BDT.HeaderText = "";
            btnThanhToanMomo_BDT.Text = "Momo";
            btnThanhToanMomo_BDT.Name = BUTTONS_THANHTOANMOMO;
            btnThanhToanMomo_BDT.UseColumnTextForButtonValue = true;
            /**/

            /*Thêm 2 button Thanh toán cho gridview dgv_ThanhToanBDT, dgv_ThanhToanDT*/
            DataGridViewButtonColumn btnThanhToanTienMat_DT = new DataGridViewButtonColumn();
            dgv_ThanhToanDT.Columns.Add(btnThanhToanTienMat_DT);
            btnThanhToanTienMat_DT.HeaderText = "";
            btnThanhToanTienMat_DT.Text = "Tiền mặt";
            btnThanhToanTienMat_DT.Name = BUTTONS_THANHTOANTIENMAT;
            btnThanhToanTienMat_DT.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnThanhToanMomo_DT = new DataGridViewButtonColumn();
            dgv_ThanhToanDT.Columns.Add(btnThanhToanMomo_DT);
            btnThanhToanMomo_DT.HeaderText = "";
            btnThanhToanMomo_DT.Text = "Momo";
            btnThanhToanMomo_DT.Name = BUTTONS_THANHTOANMOMO;
            btnThanhToanMomo_DT.UseColumnTextForButtonValue = true;
            /**/
        }

        private void cbBenhNhan_BDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            BenhNhanADO selectedBenhNhan = (BenhNhanADO)cbBenhNhan_BDT.SelectedItem;
            loadThanhToanBDT(selectedBenhNhan.Id);
        }

        private void dgv_ThanhToanBDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String columnName = dgv_ThanhToanBDT.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dgv_ThanhToanBDT.Rows[e.RowIndex];
                // Nếu row đó chưa thanh toán thì mới cho thanh toán, còn đã thanh toán thì đưa ra cảnh báo
                if (columnName.Equals(BUTTONS_THANHTOANTIENMAT) || columnName.Equals(BUTTONS_THANHTOANMOMO))
                {
                    string trangThai = row.Cells[TRANGTHAI].Value.ToString();
                    if (trangThai.Equals(DA_THANH_TOAN))
                    {
                        MessageBox.Show(BUOI_DIEU_TRI_NAY_DA_THANH_TOAN_ROI, WARNING);
                        return;
                    }
                }

                // Nếu chưa thanh toán thì cho phép người ta thanh toán
                int id = Int32.Parse(row.Cells[ID].Value.ToString());
                BenhNhanADO selectedBenhNhan = (BenhNhanADO)cbBenhNhan_BDT.SelectedItem;
                SqlConnection con = ConnectProvider.GetConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                if (columnName.Equals(BUTTONS_THANHTOANTIENMAT))
                {
                    DialogResult rs = MessageBox.Show(KHACH_HANG_TRA_TIEN_MAT, WARNING, MessageBoxButtons.YesNoCancel);
                    if (rs == DialogResult.Yes)
                    {
                        con.Open();
                        string update = "update BuoiDieuTri ";
                        update += "set DaThanhToan = 1";
                        update += string.Format("where id = {0}", id);
                        sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
                        sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

                        loadThanhToanBDT(selectedBenhNhan.Id);
                        con.Close();
                    }

                }
                else if (columnName.Equals(BUTTONS_THANHTOANMOMO))
                {
                    try
                    {
                        string orderInfo = "Buổi điều trị ngày ", amount = "";
                        string orderid = Guid.NewGuid().ToString();
                        string requestId = Guid.NewGuid().ToString();
                        DateTime ngayKham = (DateTime)row.Cells[NGAYKHAM].Value;
                        orderInfo += ngayKham.ToString("dd/MM/yyyy");
                        int chiPhi = Int32.Parse(row.Cells[CHI_PHI].Value.ToString());
                        amount = chiPhi.ToString();


                        //Before sign HMAC SHA256 signature
                        string rawHash = "partnerCode=" +
                            partnerCode + "&accessKey=" +
                            accessKey + "&requestId=" +
                            requestId + "&amount=" +
                            amount + "&orderId=" +
                            orderid + "&orderInfo=" +
                            orderInfo + "&returnUrl=" +
                            returnUrl + "&notifyUrl=" +
                            notifyurl + "&extraData=" +
                            extraData;

                        MoMoSecurity crypto = new MoMoSecurity();
                        //sign signature SHA256
                        string signature = crypto.signSHA256(rawHash, serectkey);
                        // log.Debug("Signature = " + signature);

                        //build body json request
                        JObject message = new JObject
                    {
                        { "partnerCode", partnerCode },
                        { "accessKey", accessKey },
                        { "requestId", requestId },
                        { "amount", amount },
                        { "orderId", orderid },
                        { "orderInfo", orderInfo },
                        { "returnUrl", returnUrl },
                        { "notifyUrl", notifyurl },
                        { "extraData", extraData },
                        { "requestType", "captureMoMoWallet" },
                        { "signature", signature }

                    };
                        //   log.Debug("Json request to MoMo: " + message.ToString());
                        string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());

                        JObject jmessage = JObject.Parse(responseFromMomo);
                        //log.Debug("Return from MoMo: " + jmessage.ToString());
                        DialogResult result = MessageBox.Show("Mở quét QR", CONFIRM, MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            //yes...
                            System.Diagnostics.Process.Start(jmessage.GetValue("payUrl").ToString());

                            // cập nhật thoan toán xuống database
                            Task.Factory.StartNew(() =>
                            {
                                System.Threading.Thread.Sleep(5000);


                                if (dgv_ThanhToanBDT.InvokeRequired)
                                {
                                    dgv_ThanhToanBDT.Invoke(new MethodInvoker(delegate
                                    {
                                        con.Open();
                                        string update = "update BuoiDieuTri ";
                                        update += "set DaThanhToan = 1";
                                        update += string.Format("where id = {0}", id);
                                        sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
                                        sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

                                        loadThanhToanBDT(selectedBenhNhan.Id);
                                        con.Close();
                                    }));
                                }
                            });

                        }
                        else if (result == DialogResult.Cancel)
                        {
                            //no...
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thử lại lần sau!", WARNING);
                    }

                }
            }
        }

        private void cbBenhNhan_DT_SelectedIndexChanged(object sender, EventArgs e)
        {
            BenhNhanADO selectedBenhNhan = (BenhNhanADO)cbBenhNhan_DT.SelectedItem;
            loadThanhToanDT(selectedBenhNhan.Id);
        }

        private void dgv_ThanhToanDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String columnName = dgv_ThanhToanDT.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dgv_ThanhToanDT.Rows[e.RowIndex];
                // Nếu row đó chưa thanh toán thì mới cho thanh toán, còn đã thanh toán thì đưa ra cảnh báo
                if (columnName.Equals(BUTTONS_THANHTOANTIENMAT) || columnName.Equals(BUTTONS_THANHTOANMOMO))
                {
                    string trangThai = row.Cells[TRANGTHAI].Value.ToString();
                    if (trangThai.Equals(DA_THANH_TOAN))
                    {
                        MessageBox.Show(DON_THUOC_NAY_DA_THANH_TOAN_ROI, WARNING);
                        return;
                    }
                }

                // Nếu chưa thanh toán thì cho phép người ta thanh toán
                int id = Int32.Parse(row.Cells[ID].Value.ToString());
                BenhNhanADO selectedBenhNhan = (BenhNhanADO)cbBenhNhan_BDT.SelectedItem;
                SqlConnection con = ConnectProvider.GetConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                if (columnName.Equals(BUTTONS_THANHTOANTIENMAT))
                {
                    DialogResult rs = MessageBox.Show(KHACH_HANG_TRA_TIEN_MAT, WARNING, MessageBoxButtons.YesNoCancel);
                    if (rs == DialogResult.Yes)
                    {
                        con.Open();
                        string update = "update DonThuoc ";
                        update += "set DaThanhToan = 1";
                        update += string.Format("where id = {0}", id);
                        sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
                        sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

                        loadThanhToanDT(selectedBenhNhan.Id);
                        con.Close();
                    }

                }
                else if (columnName.Equals(BUTTONS_THANHTOANMOMO))
                {
                    try
                    {
                        string orderInfo = "Đơn thuốc kê ngày ", amount = "";
                        string orderid = Guid.NewGuid().ToString();
                        string requestId = Guid.NewGuid().ToString();
                        DateTime ngayKham = (DateTime)row.Cells[NGAYKHAM].Value;
                        orderInfo += ngayKham.ToString("dd/MM/yyyy");
                        int thanhTien = Int32.Parse(row.Cells[THANH_TIEN].Value.ToString());
                        amount = thanhTien.ToString();


                        //Before sign HMAC SHA256 signature
                        string rawHash = "partnerCode=" +
                            partnerCode + "&accessKey=" +
                            accessKey + "&requestId=" +
                            requestId + "&amount=" +
                            amount + "&orderId=" +
                            orderid + "&orderInfo=" +
                            orderInfo + "&returnUrl=" +
                            returnUrl + "&notifyUrl=" +
                            notifyurl + "&extraData=" +
                            extraData;

                        MoMoSecurity crypto = new MoMoSecurity();
                        //sign signature SHA256
                        string signature = crypto.signSHA256(rawHash, serectkey);
                        // log.Debug("Signature = " + signature);

                        //build body json request
                        JObject message = new JObject
                    {
                        { "partnerCode", partnerCode },
                        { "accessKey", accessKey },
                        { "requestId", requestId },
                        { "amount", amount },
                        { "orderId", orderid },
                        { "orderInfo", orderInfo },
                        { "returnUrl", returnUrl },
                        { "notifyUrl", notifyurl },
                        { "extraData", extraData },
                        { "requestType", "captureMoMoWallet" },
                        { "signature", signature }

                    };
                        //   log.Debug("Json request to MoMo: " + message.ToString());
                        string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());

                        JObject jmessage = JObject.Parse(responseFromMomo);
                        //log.Debug("Return from MoMo: " + jmessage.ToString());
                        DialogResult result = MessageBox.Show("Mở quét QR", CONFIRM, MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            //yes...
                            System.Diagnostics.Process.Start(jmessage.GetValue("payUrl").ToString());

                            // cập nhật thoan toán xuống database
                            Task.Factory.StartNew(() =>
                            {
                                System.Threading.Thread.Sleep(5000);


                                if (dgv_ThanhToanBDT.InvokeRequired)
                                {
                                    dgv_ThanhToanBDT.Invoke(new MethodInvoker(delegate
                                    {
                                        con.Open();
                                        string update = "update DonThuoc ";
                                        update += "set DaThanhToan = 1";
                                        update += string.Format("where id = {0}", id);
                                        sqlDataAdapter.UpdateCommand = new SqlCommand(update, con);
                                        sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

                                        loadThanhToanDT(selectedBenhNhan.Id);
                                        con.Close();
                                    }));
                                }
                            });

                        }
                        else if (result == DialogResult.Cancel)
                        {
                            //no...
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thử lại lần sau!", WARNING);
                    }

                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

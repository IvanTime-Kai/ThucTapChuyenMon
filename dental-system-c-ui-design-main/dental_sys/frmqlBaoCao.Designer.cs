
namespace dental_sys
{
    partial class frmqlBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuctapDataSet1 = new dental_sys.thuctapDataSet1();
            this.cbDichVu = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuoiDieuTri = new System.Windows.Forms.ComboBox();
            this.dtpNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.cbBacSi = new System.Windows.Forms.ComboBox();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtTongTienBDT = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDayEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDayStart = new System.Windows.Forms.DateTimePicker();
            this.dgvThuBDT = new System.Windows.Forms.DataGridView();
            this.thuctapDataSet11 = new dental_sys.thuctapDataSet1();
            this.dichVuTableAdapter = new dental_sys.thuctapDataSet1TableAdapters.DichVuTableAdapter();
            this.benhNhan1TableAdapter = new dental_sys.thuctapDataSet1TableAdapters.BenhNhan1TableAdapter();
            this.thuctapDataSet = new dental_sys.thuctapDataSet();
            this.donThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donThuocTableAdapter = new dental_sys.thuctapDataSetTableAdapters.DonThuocTableAdapter();
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.dgvThu = new System.Windows.Forms.DataGridView();
            this.txtTongTienDT = new System.Windows.Forms.TextBox();
            this.txtTongTienThu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTongThu = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChiTraLuong = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.dgvTraLuong = new System.Windows.Forms.DataGridView();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.txtChiVL = new System.Windows.Forms.TextBox();
            this.dgvVatLieu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbTongChi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuBDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatLieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.cbDichVu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(947, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tenDichVuDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dichVuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(367, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 387);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenDichVuDataGridViewTextBoxColumn
            // 
            this.tenDichVuDataGridViewTextBoxColumn.DataPropertyName = "TenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.HeaderText = "TenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDichVuDataGridViewTextBoxColumn.Name = "tenDichVuDataGridViewTextBoxColumn";
            this.tenDichVuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // dichVuBindingSource
            // 
            this.dichVuBindingSource.DataMember = "DichVu";
            this.dichVuBindingSource.DataSource = this.thuctapDataSet1;
            // 
            // thuctapDataSet1
            // 
            this.thuctapDataSet1.DataSetName = "thuctapDataSet1";
            this.thuctapDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbDichVu
            // 
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.Location = new System.Drawing.Point(177, 103);
            this.cbDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.Size = new System.Drawing.Size(147, 21);
            this.cbDichVu.TabIndex = 0;
            this.cbDichVu.SelectedValueChanged += new System.EventHandler(this.cbDichVu_SelectedValueChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcel);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbBuoiDieuTri);
            this.tabPage2.Controls.Add(this.dtpNgayTiepNhan);
            this.tabPage2.Controls.Add(this.cbBacSi);
            this.tabPage2.Controls.Add(this.dgvBenhNhan);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1192, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // cbBuoiDieuTri
            // 
            this.cbBuoiDieuTri.FormattingEnabled = true;
            this.cbBuoiDieuTri.Items.AddRange(new object[] {
            "Chọn",
            "Đã điều trị",
            "Chưa Điều trị"});
            this.cbBuoiDieuTri.Location = new System.Drawing.Point(57, 120);
            this.cbBuoiDieuTri.Name = "cbBuoiDieuTri";
            this.cbBuoiDieuTri.Size = new System.Drawing.Size(121, 21);
            this.cbBuoiDieuTri.TabIndex = 3;
            this.cbBuoiDieuTri.SelectedValueChanged += new System.EventHandler(this.cbBuoiDieuTri_SelectedValueChanged);
            // 
            // dtpNgayTiepNhan
            // 
            this.dtpNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTiepNhan.Location = new System.Drawing.Point(57, 48);
            this.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";
            this.dtpNgayTiepNhan.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayTiepNhan.TabIndex = 2;
            this.dtpNgayTiepNhan.ValueChanged += new System.EventHandler(this.dtpNgayTiepNhan_ValueChanged);
            // 
            // cbBacSi
            // 
            this.cbBacSi.FormattingEnabled = true;
            this.cbBacSi.Location = new System.Drawing.Point(57, 190);
            this.cbBacSi.Name = "cbBacSi";
            this.cbBacSi.Size = new System.Drawing.Size(121, 21);
            this.cbBacSi.TabIndex = 1;
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBenhNhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Location = new System.Drawing.Point(320, 48);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.Size = new System.Drawing.Size(583, 446);
            this.dgvBenhNhan.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbTongThu);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.txtTongTienThu);
            this.tabPage3.Controls.Add(this.txtTongTienDT);
            this.tabPage3.Controls.Add(this.dgvThu);
            this.tabPage3.Controls.Add(this.dgvDonThuoc);
            this.tabPage3.Controls.Add(this.txtTongTienBDT);
            this.tabPage3.Controls.Add(this.dgvThuBDT);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1192, 600);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtTongTienBDT
            // 
            this.txtTongTienBDT.Location = new System.Drawing.Point(468, 174);
            this.txtTongTienBDT.Name = "txtTongTienBDT";
            this.txtTongTienBDT.Size = new System.Drawing.Size(100, 20);
            this.txtTongTienBDT.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(31, 179);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDayEnd
            // 
            this.dtpDayEnd.Location = new System.Drawing.Point(31, 112);
            this.dtpDayEnd.Name = "dtpDayEnd";
            this.dtpDayEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpDayEnd.TabIndex = 2;
            // 
            // dtpDayStart
            // 
            this.dtpDayStart.Location = new System.Drawing.Point(31, 42);
            this.dtpDayStart.Name = "dtpDayStart";
            this.dtpDayStart.Size = new System.Drawing.Size(200, 20);
            this.dtpDayStart.TabIndex = 1;
            // 
            // dgvThuBDT
            // 
            this.dgvThuBDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuBDT.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuBDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuBDT.Location = new System.Drawing.Point(36, 25);
            this.dgvThuBDT.Name = "dgvThuBDT";
            this.dgvThuBDT.Size = new System.Drawing.Size(406, 169);
            this.dgvThuBDT.TabIndex = 0;
            // 
            // thuctapDataSet11
            // 
            this.thuctapDataSet11.DataSetName = "thuctapDataSet1";
            this.thuctapDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dichVuTableAdapter
            // 
            this.dichVuTableAdapter.ClearBeforeFill = true;
            // 
            // benhNhan1TableAdapter
            // 
            this.benhNhan1TableAdapter.ClearBeforeFill = true;
            // 
            // thuctapDataSet
            // 
            this.thuctapDataSet.DataSetName = "thuctapDataSet";
            this.thuctapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donThuocBindingSource
            // 
            this.donThuocBindingSource.DataMember = "DonThuoc";
            this.donThuocBindingSource.DataSource = this.thuctapDataSet;
            // 
            // donThuocTableAdapter
            // 
            this.donThuocTableAdapter.ClearBeforeFill = true;
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Location = new System.Drawing.Point(36, 218);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.Size = new System.Drawing.Size(406, 166);
            this.dgvDonThuoc.TabIndex = 5;
            // 
            // dgvThu
            // 
            this.dgvThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThu.Location = new System.Drawing.Point(36, 401);
            this.dgvThu.Name = "dgvThu";
            this.dgvThu.Size = new System.Drawing.Size(406, 165);
            this.dgvThu.TabIndex = 6;
            // 
            // txtTongTienDT
            // 
            this.txtTongTienDT.Location = new System.Drawing.Point(468, 364);
            this.txtTongTienDT.Name = "txtTongTienDT";
            this.txtTongTienDT.Size = new System.Drawing.Size(100, 20);
            this.txtTongTienDT.TabIndex = 7;
            // 
            // txtTongTienThu
            // 
            this.txtTongTienThu.Location = new System.Drawing.Point(468, 546);
            this.txtTongTienThu.Name = "txtTongTienThu";
            this.txtTongTienThu.Size = new System.Drawing.Size(100, 20);
            this.txtTongTienThu.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDayStart);
            this.groupBox1.Controls.Add(this.dtpDayEnd);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(739, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 263);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng Chi Phí ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng Chi Phí ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tổng Chi Phí ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(736, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng Thu";
            // 
            // lbTongThu
            // 
            this.lbTongThu.AutoSize = true;
            this.lbTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongThu.Location = new System.Drawing.Point(807, 486);
            this.lbTongThu.Name = "lbTongThu";
            this.lbTongThu.Size = new System.Drawing.Size(51, 55);
            this.lbTongThu.TabIndex = 15;
            this.lbTongThu.Text = "0";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbTongChi);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtChiTraLuong);
            this.tabPage4.Controls.Add(this.txtChi);
            this.tabPage4.Controls.Add(this.dgvTraLuong);
            this.tabPage4.Controls.Add(this.dgvChi);
            this.tabPage4.Controls.Add(this.txtChiVL);
            this.tabPage4.Controls.Add(this.dgvVatLieu);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1192, 600);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tổng Chi Phí ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tổng Chi Phí ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tổng Chi Phí ";
            // 
            // txtChiTraLuong
            // 
            this.txtChiTraLuong.Location = new System.Drawing.Point(460, 549);
            this.txtChiTraLuong.Name = "txtChiTraLuong";
            this.txtChiTraLuong.Size = new System.Drawing.Size(100, 20);
            this.txtChiTraLuong.TabIndex = 18;
            // 
            // txtChi
            // 
            this.txtChi.Location = new System.Drawing.Point(460, 367);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(100, 20);
            this.txtChi.TabIndex = 17;
            // 
            // dgvTraLuong
            // 
            this.dgvTraLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraLuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTraLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraLuong.Location = new System.Drawing.Point(28, 404);
            this.dgvTraLuong.Name = "dgvTraLuong";
            this.dgvTraLuong.Size = new System.Drawing.Size(406, 165);
            this.dgvTraLuong.TabIndex = 16;
            // 
            // dgvChi
            // 
            this.dgvChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChi.BackgroundColor = System.Drawing.Color.White;
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Location = new System.Drawing.Point(28, 221);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.Size = new System.Drawing.Size(406, 166);
            this.dgvChi.TabIndex = 15;
            // 
            // txtChiVL
            // 
            this.txtChiVL.Location = new System.Drawing.Point(460, 177);
            this.txtChiVL.Name = "txtChiVL";
            this.txtChiVL.Size = new System.Drawing.Size(100, 20);
            this.txtChiVL.TabIndex = 14;
            // 
            // dgvVatLieu
            // 
            this.dgvVatLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVatLieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvVatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatLieu.Location = new System.Drawing.Point(28, 28);
            this.dgvVatLieu.Name = "dgvVatLieu";
            this.dgvVatLieu.Size = new System.Drawing.Size(406, 169);
            this.dgvVatLieu.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(779, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 263);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(31, 42);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(31, 112);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(31, 179);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lbTongChi
            // 
            this.lbTongChi.AutoSize = true;
            this.lbTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongChi.Location = new System.Drawing.Point(887, 507);
            this.lbTongChi.Name = "lbTongChi";
            this.lbTongChi.Size = new System.Drawing.Size(51, 55);
            this.lbTongChi.TabIndex = 24;
            this.lbTongChi.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(816, 549);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tổng Thu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(60, 435);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmqlBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 644);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmqlBaoCao";
            this.Text = "frmqlBaoCao";
            this.Load += new System.EventHandler(this.frmqlBaoCao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuBDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatLieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbDichVu;
        private System.Windows.Forms.TabPage tabPage2;
        private thuctapDataSet1 thuctapDataSet1;
        private System.Windows.Forms.BindingSource dichVuBindingSource;
        private thuctapDataSet1TableAdapters.DichVuTableAdapter dichVuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        //private System.Windows.Forms.BindingSource benhNhan1BindingSource;
        private thuctapDataSet1TableAdapters.BenhNhan1TableAdapter benhNhan1TableAdapter;
        private System.Windows.Forms.ComboBox cbBuoiDieuTri;
        private System.Windows.Forms.DateTimePicker dtpNgayTiepNhan;
        private System.Windows.Forms.ComboBox cbBacSi;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private thuctapDataSet1 thuctapDataSet11;
        //private System.Windows.Forms.BindingSource benhNhan2BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBenhNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lienHeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDayEnd;
        private System.Windows.Forms.DateTimePicker dtpDayStart;
        private System.Windows.Forms.DataGridView dgvThuBDT;
        private thuctapDataSet thuctapDataSet;
        private System.Windows.Forms.BindingSource donThuocBindingSource;
        private thuctapDataSetTableAdapters.DonThuocTableAdapter donThuocTableAdapter;
        private System.Windows.Forms.TextBox txtTongTienBDT;
        private System.Windows.Forms.TextBox txtTongTienThu;
        private System.Windows.Forms.TextBox txtTongTienDT;
        private System.Windows.Forms.DataGridView dgvThu;
        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTongThu;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChiTraLuong;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.DataGridView dgvTraLuong;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.TextBox txtChiVL;
        private System.Windows.Forms.DataGridView dgvVatLieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbTongChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
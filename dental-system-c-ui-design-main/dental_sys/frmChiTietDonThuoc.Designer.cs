
namespace dental_sys
{
    partial class frmChiTietDonThuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietDonThuoc));
            this.label7 = new System.Windows.Forms.Label();
            this.cbDonVi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.chiTietDonThuocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.thuctapDataSet = new dental_sys.thuctapDataSet();
            this.chiTietDonThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietDonThuocTableAdapter = new dental_sys.thuctapDataSetTableAdapters.ChiTietDonThuocTableAdapter();
            this.txtIDDonThuoc = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtTenThuoc = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtSoLuong = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtDonGia = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtHDSD = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatCTHD = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donthuocidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huongDanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonThuocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonThuocBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXuatCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Đơn vị";
            // 
            // cbDonVi
            // 
            this.cbDonVi.FormattingEnabled = true;
            this.cbDonVi.Items.AddRange(new object[] {
            "viên",
            "gói"});
            this.cbDonVi.Location = new System.Drawing.Point(143, 169);
            this.cbDonVi.Margin = new System.Windows.Forms.Padding(2);
            this.cbDonVi.Name = "cbDonVi";
            this.cbDonVi.Size = new System.Drawing.Size(174, 21);
            this.cbDonVi.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Hướng dẫn sử dụng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên Thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID Đơn Thuốc";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tenThuocDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donviDataGridViewTextBoxColumn,
            this.donthuocidDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.huongDanDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.chiTietDonThuocBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView6.GridColor = System.Drawing.Color.Black;
            this.dataGridView6.Location = new System.Drawing.Point(14, 51);
            this.dataGridView6.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView6.Name = "dataGridView6";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(528, 448);
            this.dataGridView6.TabIndex = 26;
            this.dataGridView6.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellClick);
            // 
            // chiTietDonThuocBindingSource1
            // 
            this.chiTietDonThuocBindingSource1.DataMember = "ChiTietDonThuoc";
            this.chiTietDonThuocBindingSource1.DataSource = this.thuctapDataSet;
            // 
            // thuctapDataSet
            // 
            this.thuctapDataSet.DataSetName = "thuctapDataSet";
            this.thuctapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietDonThuocBindingSource
            // 
            this.chiTietDonThuocBindingSource.DataMember = "ChiTietDonThuoc";
            this.chiTietDonThuocBindingSource.DataSource = this.thuctapDataSet;
            // 
            // chiTietDonThuocTableAdapter
            // 
            this.chiTietDonThuocTableAdapter.ClearBeforeFill = true;
            // 
            // txtIDDonThuoc
            // 
            this.txtIDDonThuoc.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtIDDonThuoc.Location = new System.Drawing.Point(143, 38);
            this.txtIDDonThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDDonThuoc.Name = "txtIDDonThuoc";
            this.txtIDDonThuoc.Size = new System.Drawing.Size(51, 20);
            this.txtIDDonThuoc.TabIndex = 45;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTenThuoc.Location = new System.Drawing.Point(143, 104);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(174, 20);
            this.txtTenThuoc.TabIndex = 46;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSoLuong.Location = new System.Drawing.Point(143, 134);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(174, 20);
            this.txtSoLuong.TabIndex = 47;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDonGia.Location = new System.Drawing.Point(143, 207);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(174, 20);
            this.txtDonGia.TabIndex = 48;
            // 
            // txtHDSD
            // 
            this.txtHDSD.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtHDSD.Location = new System.Drawing.Point(143, 247);
            this.txtHDSD.Margin = new System.Windows.Forms.Padding(2);
            this.txtHDSD.Multiline = true;
            this.txtHDSD.Name = "txtHDSD";
            this.txtHDSD.Size = new System.Drawing.Size(174, 72);
            this.txtHDSD.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHDSD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.cbDonVi);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTenThuoc);
            this.groupBox1.Controls.Add(this.txtIDDonThuoc);
            this.groupBox1.Location = new System.Drawing.Point(563, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 336);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết đơn thuốc";
            // 
            // btnXuatCTHD
            // 
            this.btnXuatCTHD.BackColor = System.Drawing.Color.White;
            this.btnXuatCTHD.Image = global::dental_sys.Properties.Resources.icons8_pdf_32;
            this.btnXuatCTHD.ImageActive = null;
            this.btnXuatCTHD.Location = new System.Drawing.Point(706, 514);
            this.btnXuatCTHD.Name = "btnXuatCTHD";
            this.btnXuatCTHD.Size = new System.Drawing.Size(61, 44);
            this.btnXuatCTHD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnXuatCTHD.TabIndex = 54;
            this.btnXuatCTHD.TabStop = false;
            this.btnXuatCTHD.Zoom = 10;
            this.btnXuatCTHD.Click += new System.EventHandler(this.btnXuatCTHD_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.ActiveBorderThickness = 1;
            this.btnThem.ActiveCornerRadius = 20;
            this.btnThem.ActiveFillColor = System.Drawing.Color.White;
            this.btnThem.ActiveForecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleCornerRadius = 20;
            this.btnThem.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.IdleForecolor = System.Drawing.Color.White;
            this.btnThem.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Location = new System.Drawing.Point(572, 445);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 52;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveBorderThickness = 1;
            this.btnXoa.ActiveCornerRadius = 20;
            this.btnXoa.ActiveFillColor = System.Drawing.Color.White;
            this.btnXoa.ActiveForecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.ButtonText = "Xoá";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleCornerRadius = 20;
            this.btnXoa.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.IdleForecolor = System.Drawing.Color.White;
            this.btnXoa.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Location = new System.Drawing.Point(671, 445);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 34);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ActiveBorderThickness = 1;
            this.btnSua.ActiveCornerRadius = 20;
            this.btnSua.ActiveFillColor = System.Drawing.Color.White;
            this.btnSua.ActiveForecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSua.IdleBorderThickness = 1;
            this.btnSua.IdleCornerRadius = 20;
            this.btnSua.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.IdleForecolor = System.Drawing.Color.White;
            this.btnSua.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Location = new System.Drawing.Point(772, 445);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 34);
            this.btnSua.TabIndex = 50;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // tenThuocDataGridViewTextBoxColumn
            // 
            this.tenThuocDataGridViewTextBoxColumn.DataPropertyName = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.HeaderText = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenThuocDataGridViewTextBoxColumn.Name = "tenThuocDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // donviDataGridViewTextBoxColumn
            // 
            this.donviDataGridViewTextBoxColumn.DataPropertyName = "Donvi";
            this.donviDataGridViewTextBoxColumn.HeaderText = "Donvi";
            this.donviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donviDataGridViewTextBoxColumn.Name = "donviDataGridViewTextBoxColumn";
            // 
            // donthuocidDataGridViewTextBoxColumn
            // 
            this.donthuocidDataGridViewTextBoxColumn.DataPropertyName = "Donthuoc_id";
            this.donthuocidDataGridViewTextBoxColumn.HeaderText = "Donthuoc_id";
            this.donthuocidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donthuocidDataGridViewTextBoxColumn.Name = "donthuocidDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // huongDanDataGridViewTextBoxColumn
            // 
            this.huongDanDataGridViewTextBoxColumn.DataPropertyName = "HuongDan";
            this.huongDanDataGridViewTextBoxColumn.HeaderText = "HuongDan";
            this.huongDanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.huongDanDataGridViewTextBoxColumn.Name = "huongDanDataGridViewTextBoxColumn";
            // 
            // frmChiTietDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 570);
            this.Controls.Add(this.btnXuatCTHD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChiTietDonThuoc";
            this.Text = "frmChiTietDonThuoc";
            this.Load += new System.EventHandler(this.frmChiTietDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonThuocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonThuocBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXuatCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDonVi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView6;
        private thuctapDataSet thuctapDataSet;
        private System.Windows.Forms.BindingSource chiTietDonThuocBindingSource;
        private thuctapDataSetTableAdapters.ChiTietDonThuocTableAdapter chiTietDonThuocTableAdapter;
        private System.Windows.Forms.BindingSource chiTietDonThuocBindingSource1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIDDonThuoc;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTenThuoc;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSoLuong;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDonGia;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtHDSD;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnXuatCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donthuocidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn huongDanDataGridViewTextBoxColumn;
    }
}
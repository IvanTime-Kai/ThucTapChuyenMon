
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietDonThuoc));
            this.btnXuatCTHD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDonVi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donthuocidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huongDanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietDonThuocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.thuctapDataSet = new dental_sys.thuctapDataSet();
            this.chiTietDonThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietDonThuocTableAdapter = new dental_sys.thuctapDataSetTableAdapters.ChiTietDonThuocTableAdapter();
            this.txtIDDonThuoc = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtTenThuoc = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtSoLuong = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtDonGia = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtHDSD = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonThuocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonThuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuatCTHD
            // 
            this.btnXuatCTHD.Location = new System.Drawing.Point(14, 518);
            this.btnXuatCTHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXuatCTHD.Name = "btnXuatCTHD";
            this.btnXuatCTHD.Size = new System.Drawing.Size(56, 19);
            this.btnXuatCTHD.TabIndex = 43;
            this.btnXuatCTHD.Text = "XuatCTHD";
            this.btnXuatCTHD.UseVisualStyleBackColor = true;
            this.btnXuatCTHD.Click += new System.EventHandler(this.btnXuatCTHD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 275);
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
            this.cbDonVi.Location = new System.Drawing.Point(690, 270);
            this.cbDonVi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDonVi.Name = "cbDonVi";
            this.cbDonVi.Size = new System.Drawing.Size(114, 21);
            this.cbDonVi.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Hướng dẫn sử dụng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 312);
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
            this.label3.Location = new System.Drawing.Point(576, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên Thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 143);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tenThuocDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donviDataGridViewTextBoxColumn,
            this.donthuocidDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.huongDanDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.chiTietDonThuocBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView6.Location = new System.Drawing.Point(14, 51);
            this.dataGridView6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView6.Name = "dataGridView6";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(512, 448);
            this.dataGridView6.TabIndex = 26;
            this.dataGridView6.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.txtIDDonThuoc.Location = new System.Drawing.Point(690, 139);
            this.txtIDDonThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDDonThuoc.Name = "txtIDDonThuoc";
            this.txtIDDonThuoc.Size = new System.Drawing.Size(76, 20);
            this.txtIDDonThuoc.TabIndex = 45;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTenThuoc.Location = new System.Drawing.Point(690, 205);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(114, 20);
            this.txtTenThuoc.TabIndex = 46;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSoLuong.Location = new System.Drawing.Point(690, 235);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(114, 20);
            this.txtSoLuong.TabIndex = 47;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDonGia.Location = new System.Drawing.Point(690, 308);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(114, 20);
            this.txtDonGia.TabIndex = 48;
            // 
            // txtHDSD
            // 
            this.txtHDSD.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtHDSD.Location = new System.Drawing.Point(690, 348);
            this.txtHDSD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHDSD.Multiline = true;
            this.txtHDSD.Name = "txtHDSD";
            this.txtHDSD.Size = new System.Drawing.Size(174, 72);
            this.txtHDSD.TabIndex = 49;
            // 
            // btnThem
            // 
            this.btnThem.ActiveBorderThickness = 1;
            this.btnThem.ActiveCornerRadius = 20;
            this.btnThem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnThem.ActiveForecolor = System.Drawing.Color.White;
            this.btnThem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleCornerRadius = 20;
            this.btnThem.IdleFillColor = System.Drawing.Color.White;
            this.btnThem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnThem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnThem.Location = new System.Drawing.Point(572, 445);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnXoa.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoa.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.ButtonText = "Xoá";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleCornerRadius = 20;
            this.btnXoa.IdleFillColor = System.Drawing.Color.White;
            this.btnXoa.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnXoa.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.Location = new System.Drawing.Point(671, 445);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnSua.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSua.ActiveForecolor = System.Drawing.Color.White;
            this.btnSua.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSua.IdleBorderThickness = 1;
            this.btnSua.IdleCornerRadius = 20;
            this.btnSua.IdleFillColor = System.Drawing.Color.White;
            this.btnSua.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSua.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSua.Location = new System.Drawing.Point(772, 445);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 34);
            this.btnSua.TabIndex = 50;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 53;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChiTietDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtHDSD);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.txtIDDonThuoc);
            this.Controls.Add(this.btnXuatCTHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbDonVi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChiTietDonThuoc";
            this.Text = "frmChiTietDonThuoc";
            this.Load += new System.EventHandler(this.frmChiTietDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonThuocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonThuocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuatCTHD;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donthuocidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn huongDanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chiTietDonThuocBindingSource1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIDDonThuoc;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTenThuoc;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSoLuong;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDonGia;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtHDSD;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private System.Windows.Forms.Button button1;
    }
}

namespace dental_sys
{
    partial class frmThemDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemDichVu));
            this.BDT_id = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.bDTidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuctapDataSet1 = new dental_sys.thuctapDataSet1();
            this.label11 = new System.Windows.Forms.Label();
            this.dataTable3TableAdapter = new dental_sys.thuctapDataSet1TableAdapters.DataTable3TableAdapter();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtBDT_id = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.cbDichVu = new Guna.UI.WinForms.GunaComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCT_BDT = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCT_BDT)).BeginInit();
            this.SuspendLayout();
            // 
            // BDT_id
            // 
            this.BDT_id.AutoSize = true;
            this.BDT_id.Location = new System.Drawing.Point(31, 59);
            this.BDT_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BDT_id.Name = "BDT_id";
            this.BDT_id.Size = new System.Drawing.Size(62, 20);
            this.BDT_id.TabIndex = 41;
            this.BDT_id.Text = "BDT_id";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bDTidDataGridViewTextBoxColumn,
            this.tenDichVuDataGridViewTextBoxColumn,
            this.giaDichVuDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.dataTable3BindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(9, 46);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(332, 249);
            this.dataGridView5.TabIndex = 36;
            this.dataGridView5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            // 
            // bDTidDataGridViewTextBoxColumn
            // 
            this.bDTidDataGridViewTextBoxColumn.DataPropertyName = "BDT_id";
            this.bDTidDataGridViewTextBoxColumn.HeaderText = "BDT_id";
            this.bDTidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDTidDataGridViewTextBoxColumn.Name = "bDTidDataGridViewTextBoxColumn";
            // 
            // tenDichVuDataGridViewTextBoxColumn
            // 
            this.tenDichVuDataGridViewTextBoxColumn.DataPropertyName = "TenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.HeaderText = "TenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDichVuDataGridViewTextBoxColumn.Name = "tenDichVuDataGridViewTextBoxColumn";
            // 
            // giaDichVuDataGridViewTextBoxColumn
            // 
            this.giaDichVuDataGridViewTextBoxColumn.DataPropertyName = "GiaDichVu";
            this.giaDichVuDataGridViewTextBoxColumn.HeaderText = "GiaDichVu";
            this.giaDichVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDichVuDataGridViewTextBoxColumn.Name = "giaDichVuDataGridViewTextBoxColumn";
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.thuctapDataSet1;
            // 
            // thuctapDataSet1
            // 
            this.thuctapDataSet1.DataSetName = "thuctapDataSet1";
            this.thuctapDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Loại hình dịch vụ";
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
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
            this.btnThem.Location = new System.Drawing.Point(150, 314);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 44);
            this.btnThem.TabIndex = 44;
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
            this.btnXoa.Location = new System.Drawing.Point(272, 314);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 44);
            this.btnXoa.TabIndex = 43;
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
            this.btnSua.Location = new System.Drawing.Point(394, 314);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 44);
            this.btnSua.TabIndex = 42;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtBDT_id
            // 
            this.txtBDT_id.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtBDT_id.Location = new System.Drawing.Point(114, 53);
            this.txtBDT_id.Margin = new System.Windows.Forms.Padding(2);
            this.txtBDT_id.Name = "txtBDT_id";
            this.txtBDT_id.Size = new System.Drawing.Size(71, 26);
            this.txtBDT_id.TabIndex = 45;
            // 
            // cbDichVu
            // 
            this.cbDichVu.BackColor = System.Drawing.Color.Transparent;
            this.cbDichVu.BaseColor = System.Drawing.Color.White;
            this.cbDichVu.BorderColor = System.Drawing.Color.Silver;
            this.cbDichVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDichVu.FocusedColor = System.Drawing.Color.Empty;
            this.cbDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDichVu.ForeColor = System.Drawing.Color.Black;
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.Location = new System.Drawing.Point(35, 139);
            this.cbDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbDichVu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbDichVu.Size = new System.Drawing.Size(177, 26);
            this.cbDichVu.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDichVu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.BDT_id);
            this.groupBox1.Controls.Add(this.txtBDT_id);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(359, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 188);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // btnCT_BDT
            // 
            this.btnCT_BDT.BackColor = System.Drawing.Color.White;
            this.btnCT_BDT.Image = global::dental_sys.Properties.Resources.icons8_pdf_32;
            this.btnCT_BDT.ImageActive = null;
            this.btnCT_BDT.Location = new System.Drawing.Point(555, 358);
            this.btnCT_BDT.Name = "btnCT_BDT";
            this.btnCT_BDT.Size = new System.Drawing.Size(61, 44);
            this.btnCT_BDT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCT_BDT.TabIndex = 55;
            this.btnCT_BDT.TabStop = false;
            this.btnCT_BDT.Zoom = 10;
            this.btnCT_BDT.Click += new System.EventHandler(this.btnCT_BDT_Click_1);
            // 
            // frmThemDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 414);
            this.Controls.Add(this.btnCT_BDT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridView5);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThemDichVu";
            this.Text = "frmThemDichVu";
            this.Load += new System.EventHandler(this.frmThemDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCT_BDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BDT_id;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label11;
        private thuctapDataSet1 thuctapDataSet1;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private thuctapDataSet1TableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDTidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDichVuDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtBDT_id;
        private Guna.UI.WinForms.GunaComboBox cbDichVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnCT_BDT;
    }
}
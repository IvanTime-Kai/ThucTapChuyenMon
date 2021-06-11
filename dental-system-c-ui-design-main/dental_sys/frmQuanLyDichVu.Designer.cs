
namespace dental_sys
{
    partial class frmQuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDichVu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuctapDataSet = new dental_sys.thuctapDataSet();
            this.txtTenDichVu = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtGiaDichVu = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.dichVuTableAdapter = new dental_sys.thuctapDataSetTableAdapters.DichVuTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dv,
            this.tenDichVuDataGridViewTextBoxColumn,
            this.giaDichVuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dichVuBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(605, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 485);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dichVuBindingSource
            // 
            this.dichVuBindingSource.DataMember = "DichVu";
            this.dichVuBindingSource.DataSource = this.thuctapDataSet;
            // 
            // thuctapDataSet
            // 
            this.thuctapDataSet.DataSetName = "thuctapDataSet";
            this.thuctapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTenDichVu.Location = new System.Drawing.Point(203, 48);
            this.txtTenDichVu.Multiline = true;
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(186, 28);
            this.txtTenDichVu.TabIndex = 1;
            // 
            // txtGiaDichVu
            // 
            this.txtGiaDichVu.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtGiaDichVu.Location = new System.Drawing.Point(203, 110);
            this.txtGiaDichVu.Multiline = true;
            this.txtGiaDichVu.Name = "txtGiaDichVu";
            this.txtGiaDichVu.Size = new System.Drawing.Size(186, 26);
            this.txtGiaDichVu.TabIndex = 2;
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
            this.btnThem.Location = new System.Drawing.Point(125, 393);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 44);
            this.btnThem.TabIndex = 6;
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
            this.btnXoa.Location = new System.Drawing.Point(269, 393);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 44);
            this.btnXoa.TabIndex = 5;
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
            this.btnSua.Location = new System.Drawing.Point(407, 393);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 44);
            this.btnSua.TabIndex = 4;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Dịch Vụ ";
            // 
            // dichVuTableAdapter
            // 
            this.dichVuTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giá Dịch Vụ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenDichVu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGiaDichVu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(97, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 166);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // dv
            // 
            this.dv.DataPropertyName = "id";
            this.dv.HeaderText = "id";
            this.dv.Name = "dv";
            this.dv.ReadOnly = true;
            // 
            // tenDichVuDataGridViewTextBoxColumn
            // 
            this.tenDichVuDataGridViewTextBoxColumn.DataPropertyName = "TenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.HeaderText = "TenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.Name = "tenDichVuDataGridViewTextBoxColumn";
            // 
            // giaDichVuDataGridViewTextBoxColumn
            // 
            this.giaDichVuDataGridViewTextBoxColumn.DataPropertyName = "GiaDichVu";
            this.giaDichVuDataGridViewTextBoxColumn.HeaderText = "GiaDichVu";
            this.giaDichVuDataGridViewTextBoxColumn.Name = "giaDichVuDataGridViewTextBoxColumn";
            // 
            // frmQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyDichVu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmQuanLyDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTenDichVu;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtGiaDichVu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private System.Windows.Forms.Label label1;
        private thuctapDataSet thuctapDataSet;
        private System.Windows.Forms.BindingSource dichVuBindingSource;
        private thuctapDataSetTableAdapters.DichVuTableAdapter dichVuTableAdapter;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDichVuDataGridViewTextBoxColumn;
    }
}
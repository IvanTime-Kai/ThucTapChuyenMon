
namespace dental_sys
{
    partial class frmQL_LichHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQL_LichHen));
            this.dgv_LichHen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTenBacSi = new System.Windows.Forms.ComboBox();
            this.cbTenBenhNhan = new System.Windows.Forms.ComboBox();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.cbCa = new System.Windows.Forms.ComboBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDanhDau = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichHen)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDanhDau)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_LichHen
            // 
            this.dgv_LichHen.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichHen.GridColor = System.Drawing.Color.Black;
            this.dgv_LichHen.Location = new System.Drawing.Point(471, 108);
            this.dgv_LichHen.Name = "dgv_LichHen";
            this.dgv_LichHen.Size = new System.Drawing.Size(734, 469);
            this.dgv_LichHen.TabIndex = 0;
            this.dgv_LichHen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LichHen_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bác sĩ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bệnh nhân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày hẹn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nội dung:";
            // 
            // cbTenBacSi
            // 
            this.cbTenBacSi.FormattingEnabled = true;
            this.cbTenBacSi.Location = new System.Drawing.Point(161, 37);
            this.cbTenBacSi.Name = "cbTenBacSi";
            this.cbTenBacSi.Size = new System.Drawing.Size(185, 32);
            this.cbTenBacSi.TabIndex = 6;
            // 
            // cbTenBenhNhan
            // 
            this.cbTenBenhNhan.FormattingEnabled = true;
            this.cbTenBenhNhan.Location = new System.Drawing.Point(161, 87);
            this.cbTenBenhNhan.Name = "cbTenBenhNhan";
            this.cbTenBenhNhan.Size = new System.Drawing.Size(185, 32);
            this.cbTenBenhNhan.TabIndex = 7;
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.Location = new System.Drawing.Point(161, 146);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(115, 29);
            this.dtpNgayHen.TabIndex = 8;
            // 
            // cbCa
            // 
            this.cbCa.FormattingEnabled = true;
            this.cbCa.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbCa.Location = new System.Drawing.Point(161, 198);
            this.cbCa.Name = "cbCa";
            this.cbCa.Size = new System.Drawing.Size(115, 32);
            this.cbCa.TabIndex = 9;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(161, 252);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(185, 29);
            this.txtNoiDung.TabIndex = 10;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Hoàn Thành",
            "Chưa Hoàn Thành"});
            this.cbTrangThai.Location = new System.Drawing.Point(161, 305);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(185, 32);
            this.cbTrangThai.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trạng thái:";
            // 
            // cbSapXep
            // 
            this.cbSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Items.AddRange(new object[] {
            "None",
            "Bác sĩ",
            "Bệnh nhân",
            "Ngày hẹn"});
            this.cbSapXep.Location = new System.Drawing.Point(963, 54);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(149, 32);
            this.cbSapXep.TabIndex = 17;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(857, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sắp xếp:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(83, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(110, 29);
            this.dtpFrom.TabIndex = 19;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(243, 28);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(104, 29);
            this.dtpTo.TabIndex = 20;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "From:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(199, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "To:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbTenBacSi);
            this.groupBox1.Controls.Add(this.cbTenBenhNhan);
            this.groupBox1.Controls.Add(this.dtpNgayHen);
            this.groupBox1.Controls.Add(this.cbCa);
            this.groupBox1.Controls.Add(this.txtNoiDung);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 396);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch hẹn";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Image = global::dental_sys.Properties.Resources.icons8_synchronize_32;
            this.btnReset.ImageActive = null;
            this.btnReset.Location = new System.Drawing.Point(1146, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 50);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReset.TabIndex = 29;
            this.btnReset.TabStop = false;
            this.btnReset.Zoom = 10;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnDanhDau
            // 
            this.btnDanhDau.BackColor = System.Drawing.Color.White;
            this.btnDanhDau.Image = global::dental_sys.Properties.Resources.icons8_checked_32;
            this.btnDanhDau.ImageActive = global::dental_sys.Properties.Resources.icons8_inspection_321;
            this.btnDanhDau.InitialImage = global::dental_sys.Properties.Resources.icons8_inspection_32;
            this.btnDanhDau.Location = new System.Drawing.Point(1119, 583);
            this.btnDanhDau.Name = "btnDanhDau";
            this.btnDanhDau.Size = new System.Drawing.Size(71, 56);
            this.btnDanhDau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDanhDau.TabIndex = 28;
            this.btnDanhDau.TabStop = false;
            this.btnDanhDau.Zoom = 10;
            this.btnDanhDau.Click += new System.EventHandler(this.btnDanhDau_Click_1);
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
            this.btnThem.Location = new System.Drawing.Point(69, 533);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 44);
            this.btnThem.TabIndex = 27;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
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
            this.btnSua.Location = new System.Drawing.Point(200, 533);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 44);
            this.btnSua.TabIndex = 25;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
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
            this.btnXoa.Location = new System.Drawing.Point(324, 533);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 44);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpTo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpFrom);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(471, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 70);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // frmQL_LichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDanhDau);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbSapXep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_LichHen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQL_LichHen";
            this.Text = "frmQL_LichHen";
            this.Load += new System.EventHandler(this.frmQL_LichHen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichHen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDanhDau)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LichHen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTenBacSi;
        private System.Windows.Forms.ComboBox cbTenBenhNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.ComboBox cbCa;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSapXep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuImageButton btnDanhDau;
        private Bunifu.Framework.UI.BunifuImageButton btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
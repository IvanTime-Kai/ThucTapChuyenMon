
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDanhDau = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichHen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LichHen
            // 
            this.dgv_LichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichHen.Location = new System.Drawing.Point(329, 112);
            this.dgv_LichHen.Name = "dgv_LichHen";
            this.dgv_LichHen.Size = new System.Drawing.Size(734, 429);
            this.dgv_LichHen.TabIndex = 0;
            this.dgv_LichHen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LichHen_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bác sĩ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bệnh nhân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày hẹn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nội dung:";
            // 
            // cbTenBacSi
            // 
            this.cbTenBacSi.FormattingEnabled = true;
            this.cbTenBacSi.Location = new System.Drawing.Point(91, 104);
            this.cbTenBacSi.Name = "cbTenBacSi";
            this.cbTenBacSi.Size = new System.Drawing.Size(147, 21);
            this.cbTenBacSi.TabIndex = 6;
            // 
            // cbTenBenhNhan
            // 
            this.cbTenBenhNhan.FormattingEnabled = true;
            this.cbTenBenhNhan.Location = new System.Drawing.Point(91, 159);
            this.cbTenBenhNhan.Name = "cbTenBenhNhan";
            this.cbTenBenhNhan.Size = new System.Drawing.Size(147, 21);
            this.cbTenBenhNhan.TabIndex = 7;
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.Location = new System.Drawing.Point(91, 213);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(87, 20);
            this.dtpNgayHen.TabIndex = 8;
            // 
            // cbCa
            // 
            this.cbCa.FormattingEnabled = true;
            this.cbCa.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbCa.Location = new System.Drawing.Point(91, 265);
            this.cbCa.Name = "cbCa";
            this.cbCa.Size = new System.Drawing.Size(58, 21);
            this.cbCa.TabIndex = 9;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(91, 319);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(185, 20);
            this.txtNoiDung.TabIndex = 10;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Hoàn Thành",
            "Chưa Hoàn Thành"});
            this.cbTrangThai.Location = new System.Drawing.Point(91, 372);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(147, 21);
            this.cbTrangThai.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trạng thái:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 440);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(114, 440);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(215, 440);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbSapXep
            // 
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Items.AddRange(new object[] {
            "None",
            "Bác sĩ",
            "Bệnh nhân",
            "Ngày hẹn"});
            this.cbSapXep.Location = new System.Drawing.Point(914, 69);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(149, 21);
            this.cbSapXep.TabIndex = 17;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(844, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sắp xếp:";
            // 
            // btnDanhDau
            // 
            this.btnDanhDau.Location = new System.Drawing.Point(329, 77);
            this.btnDanhDau.Name = "btnDanhDau";
            this.btnDanhDau.Size = new System.Drawing.Size(75, 23);
            this.btnDanhDau.TabIndex = 18;
            this.btnDanhDau.Text = "Đánh dấu";
            this.btnDanhDau.UseVisualStyleBackColor = true;
            this.btnDanhDau.Click += new System.EventHandler(this.btnDanhDau_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(515, 80);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(87, 20);
            this.dtpFrom.TabIndex = 19;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(652, 80);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(87, 20);
            this.dtpTo.TabIndex = 20;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "From:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "To:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(995, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 23);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmQL_LichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 553);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnDanhDau);
            this.Controls.Add(this.cbSapXep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.cbCa);
            this.Controls.Add(this.dtpNgayHen);
            this.Controls.Add(this.cbTenBenhNhan);
            this.Controls.Add(this.cbTenBacSi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_LichHen);
            this.Name = "frmQL_LichHen";
            this.Text = "frmQL_LichHen";
            this.Load += new System.EventHandler(this.frmQL_LichHen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichHen)).EndInit();
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
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbSapXep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDanhDau;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReset;
    }
}
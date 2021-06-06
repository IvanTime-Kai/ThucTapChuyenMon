
namespace dental_sys
{
    partial class frmQL_ThuChi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSapXep_Thu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu_Thu = new System.Windows.Forms.TextBox();
            this.dtpNgayDong = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUser_Thu = new System.Windows.Forms.ComboBox();
            this.txtSoTien_KhoanThu = new System.Windows.Forms.TextBox();
            this.btnThemThu = new System.Windows.Forms.Button();
            this.btnSuaThu = new System.Windows.Forms.Button();
            this.btnXoaThu = new System.Windows.Forms.Button();
            this.txtTenKhoanThu = new System.Windows.Forms.TextBox();
            this.dgv_Thu = new System.Windows.Forms.DataGridView();
            this.btnXoaKhoanThu = new System.Windows.Forms.Button();
            this.btnSuaKhoanThu = new System.Windows.Forms.Button();
            this.btnThemKhoanThu = new System.Windows.Forms.Button();
            this.dgv_KhoanThu = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSapXep_Chi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu_Chi = new System.Windows.Forms.TextBox();
            this.dtpNgayChi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbUser_Chi = new System.Windows.Forms.ComboBox();
            this.txtSoTien_KhoanChi = new System.Windows.Forms.TextBox();
            this.btnThemChi = new System.Windows.Forms.Button();
            this.btnSuaChi = new System.Windows.Forms.Button();
            this.btnXoaChi = new System.Windows.Forms.Button();
            this.txtTenKhoanChi = new System.Windows.Forms.TextBox();
            this.dgv_Chi = new System.Windows.Forms.DataGridView();
            this.btnXoaKhoanChi = new System.Windows.Forms.Button();
            this.btnSuaKhoanChi = new System.Windows.Forms.Button();
            this.btnThemKhoanChi = new System.Windows.Forms.Button();
            this.dgv_KhoanChi = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoanThu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoanChi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1125, 625);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbSapXep_Thu);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtGhiChu_Thu);
            this.tabPage1.Controls.Add(this.dtpNgayDong);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbUser_Thu);
            this.tabPage1.Controls.Add(this.txtSoTien_KhoanThu);
            this.tabPage1.Controls.Add(this.btnThemThu);
            this.tabPage1.Controls.Add(this.btnSuaThu);
            this.tabPage1.Controls.Add(this.btnXoaThu);
            this.tabPage1.Controls.Add(this.txtTenKhoanThu);
            this.tabPage1.Controls.Add(this.dgv_Thu);
            this.tabPage1.Controls.Add(this.btnXoaKhoanThu);
            this.tabPage1.Controls.Add(this.btnSuaKhoanThu);
            this.tabPage1.Controls.Add(this.btnThemKhoanThu);
            this.tabPage1.Controls.Add(this.dgv_KhoanThu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1117, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lí thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Sắp xếp:";
            // 
            // cbSapXep_Thu
            // 
            this.cbSapXep_Thu.FormattingEnabled = true;
            this.cbSapXep_Thu.Items.AddRange(new object[] {
            "(None)",
            "Người đóng",
            "Ngày đóng"});
            this.cbSapXep_Thu.Location = new System.Drawing.Point(307, 534);
            this.cbSapXep_Thu.Name = "cbSapXep_Thu";
            this.cbSapXep_Thu.Size = new System.Drawing.Size(159, 21);
            this.cbSapXep_Thu.TabIndex = 52;
            this.cbSapXep_Thu.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_Thu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ghi chú:";
            // 
            // txtGhiChu_Thu
            // 
            this.txtGhiChu_Thu.Location = new System.Drawing.Point(797, 39);
            this.txtGhiChu_Thu.Name = "txtGhiChu_Thu";
            this.txtGhiChu_Thu.Size = new System.Drawing.Size(293, 20);
            this.txtGhiChu_Thu.TabIndex = 50;
            // 
            // dtpNgayDong
            // 
            this.dtpNgayDong.Location = new System.Drawing.Point(592, 39);
            this.dtpNgayDong.Name = "dtpNgayDong";
            this.dtpNgayDong.Size = new System.Drawing.Size(87, 20);
            this.dtpNgayDong.TabIndex = 49;
            this.dtpNgayDong.ValueChanged += new System.EventHandler(this.dtpNgayDong_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày đóng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Người đóng:";
            // 
            // cbUser_Thu
            // 
            this.cbUser_Thu.FormattingEnabled = true;
            this.cbUser_Thu.Location = new System.Drawing.Point(307, 37);
            this.cbUser_Thu.Name = "cbUser_Thu";
            this.cbUser_Thu.Size = new System.Drawing.Size(159, 21);
            this.cbUser_Thu.TabIndex = 46;
            // 
            // txtSoTien_KhoanThu
            // 
            this.txtSoTien_KhoanThu.Location = new System.Drawing.Point(26, 367);
            this.txtSoTien_KhoanThu.Name = "txtSoTien_KhoanThu";
            this.txtSoTien_KhoanThu.Size = new System.Drawing.Size(173, 20);
            this.txtSoTien_KhoanThu.TabIndex = 45;
            // 
            // btnThemThu
            // 
            this.btnThemThu.Location = new System.Drawing.Point(816, 532);
            this.btnThemThu.Name = "btnThemThu";
            this.btnThemThu.Size = new System.Drawing.Size(73, 23);
            this.btnThemThu.TabIndex = 42;
            this.btnThemThu.Text = "Thêm";
            this.btnThemThu.UseVisualStyleBackColor = true;
            this.btnThemThu.Click += new System.EventHandler(this.btnThemThu_Click);
            // 
            // btnSuaThu
            // 
            this.btnSuaThu.Location = new System.Drawing.Point(915, 532);
            this.btnSuaThu.Name = "btnSuaThu";
            this.btnSuaThu.Size = new System.Drawing.Size(73, 23);
            this.btnSuaThu.TabIndex = 41;
            this.btnSuaThu.Text = "Sửa";
            this.btnSuaThu.UseVisualStyleBackColor = true;
            this.btnSuaThu.Click += new System.EventHandler(this.btnSuaThu_Click);
            // 
            // btnXoaThu
            // 
            this.btnXoaThu.Location = new System.Drawing.Point(1017, 532);
            this.btnXoaThu.Name = "btnXoaThu";
            this.btnXoaThu.Size = new System.Drawing.Size(73, 23);
            this.btnXoaThu.TabIndex = 40;
            this.btnXoaThu.Text = "Xoá";
            this.btnXoaThu.UseVisualStyleBackColor = true;
            this.btnXoaThu.Click += new System.EventHandler(this.btnXoaThu_Click);
            // 
            // txtTenKhoanThu
            // 
            this.txtTenKhoanThu.Location = new System.Drawing.Point(27, 321);
            this.txtTenKhoanThu.Name = "txtTenKhoanThu";
            this.txtTenKhoanThu.Size = new System.Drawing.Size(173, 20);
            this.txtTenKhoanThu.TabIndex = 29;
            // 
            // dgv_Thu
            // 
            this.dgv_Thu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Thu.Location = new System.Drawing.Point(230, 80);
            this.dgv_Thu.Name = "dgv_Thu";
            this.dgv_Thu.Size = new System.Drawing.Size(860, 437);
            this.dgv_Thu.TabIndex = 33;
            this.dgv_Thu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Thu_CellClick);
            // 
            // btnXoaKhoanThu
            // 
            this.btnXoaKhoanThu.Location = new System.Drawing.Point(27, 494);
            this.btnXoaKhoanThu.Name = "btnXoaKhoanThu";
            this.btnXoaKhoanThu.Size = new System.Drawing.Size(173, 23);
            this.btnXoaKhoanThu.TabIndex = 32;
            this.btnXoaKhoanThu.Text = "Xoá";
            this.btnXoaKhoanThu.UseVisualStyleBackColor = true;
            this.btnXoaKhoanThu.Click += new System.EventHandler(this.btnXoaKhoanThu_Click);
            // 
            // btnSuaKhoanThu
            // 
            this.btnSuaKhoanThu.Location = new System.Drawing.Point(27, 450);
            this.btnSuaKhoanThu.Name = "btnSuaKhoanThu";
            this.btnSuaKhoanThu.Size = new System.Drawing.Size(173, 23);
            this.btnSuaKhoanThu.TabIndex = 31;
            this.btnSuaKhoanThu.Text = "Sửa";
            this.btnSuaKhoanThu.UseVisualStyleBackColor = true;
            this.btnSuaKhoanThu.Click += new System.EventHandler(this.btnSuaKhoanThu_Click);
            // 
            // btnThemKhoanThu
            // 
            this.btnThemKhoanThu.Location = new System.Drawing.Point(27, 404);
            this.btnThemKhoanThu.Name = "btnThemKhoanThu";
            this.btnThemKhoanThu.Size = new System.Drawing.Size(173, 23);
            this.btnThemKhoanThu.TabIndex = 30;
            this.btnThemKhoanThu.Text = "Thêm";
            this.btnThemKhoanThu.UseVisualStyleBackColor = true;
            this.btnThemKhoanThu.Click += new System.EventHandler(this.btnThemKhoanThu_Click);
            // 
            // dgv_KhoanThu
            // 
            this.dgv_KhoanThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhoanThu.Location = new System.Drawing.Point(26, 25);
            this.dgv_KhoanThu.Name = "dgv_KhoanThu";
            this.dgv_KhoanThu.Size = new System.Drawing.Size(174, 260);
            this.dgv_KhoanThu.TabIndex = 28;
            this.dgv_KhoanThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhoanThu_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbSapXep_Chi);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtGhiChu_Chi);
            this.tabPage2.Controls.Add(this.dtpNgayChi);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cbUser_Chi);
            this.tabPage2.Controls.Add(this.txtSoTien_KhoanChi);
            this.tabPage2.Controls.Add(this.btnThemChi);
            this.tabPage2.Controls.Add(this.btnSuaChi);
            this.tabPage2.Controls.Add(this.btnXoaChi);
            this.tabPage2.Controls.Add(this.txtTenKhoanChi);
            this.tabPage2.Controls.Add(this.dgv_Chi);
            this.tabPage2.Controls.Add(this.btnXoaKhoanChi);
            this.tabPage2.Controls.Add(this.btnSuaKhoanChi);
            this.tabPage2.Controls.Add(this.btnThemKhoanChi);
            this.tabPage2.Controls.Add(this.dgv_KhoanChi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1117, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lí chi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Sắp xếp:";
            // 
            // cbSapXep_Chi
            // 
            this.cbSapXep_Chi.FormattingEnabled = true;
            this.cbSapXep_Chi.Items.AddRange(new object[] {
            "(None)",
            "Người chi",
            "Ngày chi"});
            this.cbSapXep_Chi.Location = new System.Drawing.Point(307, 543);
            this.cbSapXep_Chi.Name = "cbSapXep_Chi";
            this.cbSapXep_Chi.Size = new System.Drawing.Size(158, 21);
            this.cbSapXep_Chi.TabIndex = 70;
            this.cbSapXep_Chi.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_Chi_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Ghi chú:";
            // 
            // txtGhiChu_Chi
            // 
            this.txtGhiChu_Chi.Location = new System.Drawing.Point(797, 48);
            this.txtGhiChu_Chi.Name = "txtGhiChu_Chi";
            this.txtGhiChu_Chi.Size = new System.Drawing.Size(293, 20);
            this.txtGhiChu_Chi.TabIndex = 68;
            // 
            // dtpNgayChi
            // 
            this.dtpNgayChi.Location = new System.Drawing.Point(592, 48);
            this.dtpNgayChi.Name = "dtpNgayChi";
            this.dtpNgayChi.Size = new System.Drawing.Size(87, 20);
            this.dtpNgayChi.TabIndex = 67;
            this.dtpNgayChi.ValueChanged += new System.EventHandler(this.dtpNgayChi_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Ngày đóng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Người đóng:";
            // 
            // cbUser_Chi
            // 
            this.cbUser_Chi.FormattingEnabled = true;
            this.cbUser_Chi.Location = new System.Drawing.Point(307, 46);
            this.cbUser_Chi.Name = "cbUser_Chi";
            this.cbUser_Chi.Size = new System.Drawing.Size(159, 21);
            this.cbUser_Chi.TabIndex = 64;
            // 
            // txtSoTien_KhoanChi
            // 
            this.txtSoTien_KhoanChi.Location = new System.Drawing.Point(26, 376);
            this.txtSoTien_KhoanChi.Name = "txtSoTien_KhoanChi";
            this.txtSoTien_KhoanChi.Size = new System.Drawing.Size(173, 20);
            this.txtSoTien_KhoanChi.TabIndex = 63;
            // 
            // btnThemChi
            // 
            this.btnThemChi.Location = new System.Drawing.Point(816, 541);
            this.btnThemChi.Name = "btnThemChi";
            this.btnThemChi.Size = new System.Drawing.Size(73, 23);
            this.btnThemChi.TabIndex = 62;
            this.btnThemChi.Text = "Thêm";
            this.btnThemChi.UseVisualStyleBackColor = true;
            this.btnThemChi.Click += new System.EventHandler(this.btnThemChi_Click);
            // 
            // btnSuaChi
            // 
            this.btnSuaChi.Location = new System.Drawing.Point(915, 541);
            this.btnSuaChi.Name = "btnSuaChi";
            this.btnSuaChi.Size = new System.Drawing.Size(73, 23);
            this.btnSuaChi.TabIndex = 61;
            this.btnSuaChi.Text = "Sửa";
            this.btnSuaChi.UseVisualStyleBackColor = true;
            this.btnSuaChi.Click += new System.EventHandler(this.btnSuaChi_Click);
            // 
            // btnXoaChi
            // 
            this.btnXoaChi.Location = new System.Drawing.Point(1017, 541);
            this.btnXoaChi.Name = "btnXoaChi";
            this.btnXoaChi.Size = new System.Drawing.Size(73, 23);
            this.btnXoaChi.TabIndex = 60;
            this.btnXoaChi.Text = "Xoá";
            this.btnXoaChi.UseVisualStyleBackColor = true;
            this.btnXoaChi.Click += new System.EventHandler(this.btnXoaChi_Click);
            // 
            // txtTenKhoanChi
            // 
            this.txtTenKhoanChi.Location = new System.Drawing.Point(27, 330);
            this.txtTenKhoanChi.Name = "txtTenKhoanChi";
            this.txtTenKhoanChi.Size = new System.Drawing.Size(173, 20);
            this.txtTenKhoanChi.TabIndex = 55;
            // 
            // dgv_Chi
            // 
            this.dgv_Chi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Chi.Location = new System.Drawing.Point(230, 89);
            this.dgv_Chi.Name = "dgv_Chi";
            this.dgv_Chi.Size = new System.Drawing.Size(860, 437);
            this.dgv_Chi.TabIndex = 59;
            this.dgv_Chi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Chi_CellClick);
            // 
            // btnXoaKhoanChi
            // 
            this.btnXoaKhoanChi.Location = new System.Drawing.Point(27, 503);
            this.btnXoaKhoanChi.Name = "btnXoaKhoanChi";
            this.btnXoaKhoanChi.Size = new System.Drawing.Size(173, 23);
            this.btnXoaKhoanChi.TabIndex = 58;
            this.btnXoaKhoanChi.Text = "Xoá";
            this.btnXoaKhoanChi.UseVisualStyleBackColor = true;
            this.btnXoaKhoanChi.Click += new System.EventHandler(this.btnXoaKhoanChi_Click);
            // 
            // btnSuaKhoanChi
            // 
            this.btnSuaKhoanChi.Location = new System.Drawing.Point(27, 459);
            this.btnSuaKhoanChi.Name = "btnSuaKhoanChi";
            this.btnSuaKhoanChi.Size = new System.Drawing.Size(173, 23);
            this.btnSuaKhoanChi.TabIndex = 57;
            this.btnSuaKhoanChi.Text = "Sửa";
            this.btnSuaKhoanChi.UseVisualStyleBackColor = true;
            this.btnSuaKhoanChi.Click += new System.EventHandler(this.btnSuaKhoanChi_Click);
            // 
            // btnThemKhoanChi
            // 
            this.btnThemKhoanChi.Location = new System.Drawing.Point(27, 413);
            this.btnThemKhoanChi.Name = "btnThemKhoanChi";
            this.btnThemKhoanChi.Size = new System.Drawing.Size(173, 23);
            this.btnThemKhoanChi.TabIndex = 56;
            this.btnThemKhoanChi.Text = "Thêm";
            this.btnThemKhoanChi.UseVisualStyleBackColor = true;
            this.btnThemKhoanChi.Click += new System.EventHandler(this.btnThemKhoanChi_Click);
            // 
            // dgv_KhoanChi
            // 
            this.dgv_KhoanChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhoanChi.Location = new System.Drawing.Point(26, 34);
            this.dgv_KhoanChi.Name = "dgv_KhoanChi";
            this.dgv_KhoanChi.Size = new System.Drawing.Size(174, 260);
            this.dgv_KhoanChi.TabIndex = 54;
            this.dgv_KhoanChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhoanChi_CellClick);
            // 
            // frmQL_ThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmQL_ThuChi";
            this.Text = "frmQL_ThuChi";
            this.Load += new System.EventHandler(this.frmQL_ThuChi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoanThu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoanChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnThemThu;
        private System.Windows.Forms.Button btnSuaThu;
        private System.Windows.Forms.Button btnXoaThu;
        private System.Windows.Forms.TextBox txtTenKhoanThu;
        private System.Windows.Forms.DataGridView dgv_Thu;
        private System.Windows.Forms.Button btnXoaKhoanThu;
        private System.Windows.Forms.Button btnSuaKhoanThu;
        private System.Windows.Forms.Button btnThemKhoanThu;
        private System.Windows.Forms.DataGridView dgv_KhoanThu;
        private System.Windows.Forms.TextBox txtSoTien_KhoanThu;
        private System.Windows.Forms.ComboBox cbUser_Thu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu_Thu;
        private System.Windows.Forms.DateTimePicker dtpNgayDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSapXep_Thu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSapXep_Chi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu_Chi;
        private System.Windows.Forms.DateTimePicker dtpNgayChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUser_Chi;
        private System.Windows.Forms.TextBox txtSoTien_KhoanChi;
        private System.Windows.Forms.Button btnThemChi;
        private System.Windows.Forms.Button btnSuaChi;
        private System.Windows.Forms.Button btnXoaChi;
        private System.Windows.Forms.TextBox txtTenKhoanChi;
        private System.Windows.Forms.DataGridView dgv_Chi;
        private System.Windows.Forms.Button btnXoaKhoanChi;
        private System.Windows.Forms.Button btnSuaKhoanChi;
        private System.Windows.Forms.Button btnThemKhoanChi;
        private System.Windows.Forms.DataGridView dgv_KhoanChi;
    }
}
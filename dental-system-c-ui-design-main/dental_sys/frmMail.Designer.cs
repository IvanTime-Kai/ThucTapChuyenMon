
namespace dental_sys
{
    partial class frmMail
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
            this.chkssl = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBenhNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngheNghiepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lienHeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhChupDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nguoiTiepNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTiepNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuctapDataSet = new dental_sys.thuctapDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtussename = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.ComboBox();
            this.benhNhanTableAdapter = new dental_sys.thuctapDataSetTableAdapters.BenhNhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chkssl
            // 
            this.chkssl.AutoSize = true;
            this.chkssl.Checked = true;
            this.chkssl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkssl.Location = new System.Drawing.Point(638, 50);
            this.chkssl.Name = "chkssl";
            this.chkssl.Size = new System.Drawing.Size(46, 17);
            this.chkssl.TabIndex = 41;
            this.chkssl.Text = "SSL";
            this.chkssl.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "smtp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "cc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "to";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tenBenhNhanDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.tuoiDataGridViewTextBoxColumn,
            this.ngheNghiepDataGridViewTextBoxColumn,
            this.lienHeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.anhChupDataGridViewImageColumn,
            this.nguoiTiepNhanDataGridViewTextBoxColumn,
            this.ngayTiepNhanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.benhNhanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(675, 243);
            this.dataGridView1.TabIndex = 32;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenBenhNhanDataGridViewTextBoxColumn
            // 
            this.tenBenhNhanDataGridViewTextBoxColumn.DataPropertyName = "TenBenhNhan";
            this.tenBenhNhanDataGridViewTextBoxColumn.HeaderText = "TenBenhNhan";
            this.tenBenhNhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenBenhNhanDataGridViewTextBoxColumn.Name = "tenBenhNhanDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // tuoiDataGridViewTextBoxColumn
            // 
            this.tuoiDataGridViewTextBoxColumn.DataPropertyName = "Tuoi";
            this.tuoiDataGridViewTextBoxColumn.HeaderText = "Tuoi";
            this.tuoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tuoiDataGridViewTextBoxColumn.Name = "tuoiDataGridViewTextBoxColumn";
            // 
            // ngheNghiepDataGridViewTextBoxColumn
            // 
            this.ngheNghiepDataGridViewTextBoxColumn.DataPropertyName = "NgheNghiep";
            this.ngheNghiepDataGridViewTextBoxColumn.HeaderText = "NgheNghiep";
            this.ngheNghiepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngheNghiepDataGridViewTextBoxColumn.Name = "ngheNghiepDataGridViewTextBoxColumn";
            // 
            // lienHeDataGridViewTextBoxColumn
            // 
            this.lienHeDataGridViewTextBoxColumn.DataPropertyName = "LienHe";
            this.lienHeDataGridViewTextBoxColumn.HeaderText = "LienHe";
            this.lienHeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lienHeDataGridViewTextBoxColumn.Name = "lienHeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // anhChupDataGridViewImageColumn
            // 
            this.anhChupDataGridViewImageColumn.DataPropertyName = "AnhChup";
            this.anhChupDataGridViewImageColumn.HeaderText = "AnhChup";
            this.anhChupDataGridViewImageColumn.MinimumWidth = 6;
            this.anhChupDataGridViewImageColumn.Name = "anhChupDataGridViewImageColumn";
            // 
            // nguoiTiepNhanDataGridViewTextBoxColumn
            // 
            this.nguoiTiepNhanDataGridViewTextBoxColumn.DataPropertyName = "NguoiTiepNhan";
            this.nguoiTiepNhanDataGridViewTextBoxColumn.HeaderText = "NguoiTiepNhan";
            this.nguoiTiepNhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nguoiTiepNhanDataGridViewTextBoxColumn.Name = "nguoiTiepNhanDataGridViewTextBoxColumn";
            // 
            // ngayTiepNhanDataGridViewTextBoxColumn
            // 
            this.ngayTiepNhanDataGridViewTextBoxColumn.DataPropertyName = "NgayTiepNhan";
            this.ngayTiepNhanDataGridViewTextBoxColumn.HeaderText = "NgayTiepNhan";
            this.ngayTiepNhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTiepNhanDataGridViewTextBoxColumn.Name = "ngayTiepNhanDataGridViewTextBoxColumn";
            // 
            // benhNhanBindingSource
            // 
            this.benhNhanBindingSource.DataMember = "BenhNhan";
            this.benhNhanBindingSource.DataSource = this.thuctapDataSet;
            // 
            // thuctapDataSet
            // 
            this.thuctapDataSet.DataSetName = "thuctapDataSet";
            this.thuctapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "chon File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 30;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(90, 266);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(157, 20);
            this.txtMessage.TabIndex = 29;
            this.txtMessage.Text = "Trung tâm nha khoa Ivantime";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(638, 109);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 28;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(555, 171);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(213, 20);
            this.txtSmtp.TabIndex = 27;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(384, 171);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(105, 20);
            this.txtPort.TabIndex = 26;
            this.txtPort.Text = "587";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(406, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 20);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.Text = "0941045446";
            // 
            // txtussename
            // 
            this.txtussename.Location = new System.Drawing.Point(406, 49);
            this.txtussename.Name = "txtussename";
            this.txtussename.Size = new System.Drawing.Size(194, 20);
            this.txtussename.TabIndex = 24;
            this.txtussename.Text = "ivantime000";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(78, 167);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(194, 20);
            this.txtSubject.TabIndex = 23;
            this.txtSubject.Text = "Thông tin Trung tâm nha khoa Ivantime";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(78, 109);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(194, 20);
            this.txtCC.TabIndex = 22;
            this.txtCC.Text = "Hello";
            // 
            // txtTo
            // 
            this.txtTo.FormattingEnabled = true;
            this.txtTo.Location = new System.Drawing.Point(78, 49);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(194, 21);
            this.txtTo.TabIndex = 21;
            // 
            // benhNhanTableAdapter
            // 
            this.benhNhanTableAdapter.ClearBeforeFill = true;
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 592);
            this.Controls.Add(this.chkssl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSmtp);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtussename);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtTo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMail";
            this.Text = "frmMaiil";
            this.Load += new System.EventHandler(this.frmMail_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkssl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtussename;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.ComboBox txtTo;
        private thuctapDataSet thuctapDataSet;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private thuctapDataSetTableAdapters.BenhNhanTableAdapter benhNhanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBenhNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngheNghiepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lienHeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn anhChupDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiTiepNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTiepNhanDataGridViewTextBoxColumn;
    }
}
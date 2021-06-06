
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
            this.thuctapDataSet = new dental_sys.thuctapDataSet();
            this.benhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benhNhanTableAdapter = new dental_sys.thuctapDataSetTableAdapters.BenhNhanTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chkssl
            // 
            this.chkssl.AutoSize = true;
            this.chkssl.Checked = true;
            this.chkssl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkssl.Location = new System.Drawing.Point(850, 62);
            this.chkssl.Margin = new System.Windows.Forms.Padding(4);
            this.chkssl.Name = "chkssl";
            this.chkssl.Size = new System.Drawing.Size(56, 21);
            this.chkssl.TabIndex = 41;
            this.chkssl.Text = "SSL";
            this.chkssl.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "smtp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "cc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
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
            this.dataGridView1.Location = new System.Drawing.Point(50, 422);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(900, 299);
            this.dataGridView1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "chon File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 326);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 22);
            this.textBox1.TabIndex = 30;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(120, 327);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(208, 22);
            this.txtMessage.TabIndex = 29;
            this.txtMessage.Text = "Cellphone S!";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(850, 134);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 28;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(740, 211);
            this.txtSmtp.Margin = new System.Windows.Forms.Padding(4);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(283, 22);
            this.txtSmtp.TabIndex = 27;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(512, 211);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(139, 22);
            this.txtPort.TabIndex = 26;
            this.txtPort.Text = "587";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(541, 139);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(257, 22);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.Text = "0941045446";
            // 
            // txtussename
            // 
            this.txtussename.Location = new System.Drawing.Point(541, 60);
            this.txtussename.Margin = new System.Windows.Forms.Padding(4);
            this.txtussename.Name = "txtussename";
            this.txtussename.Size = new System.Drawing.Size(257, 22);
            this.txtussename.TabIndex = 24;
            this.txtussename.Text = "ivantime000";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(104, 206);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(257, 22);
            this.txtSubject.TabIndex = 23;
            this.txtSubject.Text = "Hoá Đơn";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(104, 134);
            this.txtCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(257, 22);
            this.txtCC.TabIndex = 22;
            this.txtCC.Text = "Hello";
            // 
            // txtTo
            // 
            this.txtTo.FormattingEnabled = true;
            this.txtTo.Location = new System.Drawing.Point(104, 60);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(257, 24);
            this.txtTo.TabIndex = 21;
            // 
            // thuctapDataSet
            // 
            this.thuctapDataSet.DataSetName = "thuctapDataSet";
            this.thuctapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // benhNhanBindingSource
            // 
            this.benhNhanBindingSource.DataMember = "BenhNhan";
            this.benhNhanBindingSource.DataSource = this.thuctapDataSet;
            // 
            // benhNhanTableAdapter
            // 
            this.benhNhanTableAdapter.ClearBeforeFill = true;
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
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 729);
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
            this.Name = "frmMail";
            this.Text = "frmMaiil";
            this.Load += new System.EventHandler(this.frmMail_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuctapDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
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

namespace dental_sys
{
    partial class frm_ReportLichTrucVaGuiMail
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
            this.cbGuiEmail = new System.Windows.Forms.CheckBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NhungCaTrucSapToiCuaMotBacSi_DataSet = new dental_sys.NhungCaTrucSapToiCuaMotBacSi_DataSet();
            this.sp_NhungCaTrucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_NhungCaTrucTableAdapter = new dental_sys.NhungCaTrucSapToiCuaMotBacSi_DataSetTableAdapters.sp_NhungCaTrucTableAdapter();
            this.DataSet1 = new dental_sys.DataSet1();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new dental_sys.DataSet1TableAdapters.DataTable1TableAdapter();
            this.rpvLichTruc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhungCaTrucSapToiCuaMotBacSi_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_NhungCaTrucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGuiEmail
            // 
            this.cbGuiEmail.AutoSize = true;
            this.cbGuiEmail.Location = new System.Drawing.Point(810, 519);
            this.cbGuiEmail.Name = "cbGuiEmail";
            this.cbGuiEmail.Size = new System.Drawing.Size(69, 17);
            this.cbGuiEmail.TabIndex = 1;
            this.cbGuiEmail.Text = "Gửi email";
            this.cbGuiEmail.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Location = new System.Drawing.Point(899, 513);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpvLichTruc);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 495);
            this.panel1.TabIndex = 3;
            // 
            // NhungCaTrucSapToiCuaMotBacSi_DataSet
            // 
            this.NhungCaTrucSapToiCuaMotBacSi_DataSet.DataSetName = "NhungCaTrucSapToiCuaMotBacSi_DataSet";
            this.NhungCaTrucSapToiCuaMotBacSi_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_NhungCaTrucBindingSource
            // 
            this.sp_NhungCaTrucBindingSource.DataMember = "sp_NhungCaTruc";
            this.sp_NhungCaTrucBindingSource.DataSource = this.NhungCaTrucSapToiCuaMotBacSi_DataSet;
            // 
            // sp_NhungCaTrucTableAdapter
            // 
            this.sp_NhungCaTrucTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // rpvLichTruc
            // 
            this.rpvLichTruc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvLichTruc.Location = new System.Drawing.Point(0, 0);
            this.rpvLichTruc.Name = "rpvLichTruc";
            this.rpvLichTruc.ServerReport.BearerToken = null;
            this.rpvLichTruc.Size = new System.Drawing.Size(962, 495);
            this.rpvLichTruc.TabIndex = 0;
            // 
            // frm_ReportLichTrucVaGuiMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cbGuiEmail);
            this.Name = "frm_ReportLichTrucVaGuiMail";
            this.Text = "frm_ReportLichTrucVaGuiMail";
            this.Load += new System.EventHandler(this.frm_ReportLichTrucVaGuiMail_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NhungCaTrucSapToiCuaMotBacSi_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_NhungCaTrucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbGuiEmail;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource sp_NhungCaTrucBindingSource;
        private NhungCaTrucSapToiCuaMotBacSi_DataSet NhungCaTrucSapToiCuaMotBacSi_DataSet;
        private NhungCaTrucSapToiCuaMotBacSi_DataSetTableAdapters.sp_NhungCaTrucTableAdapter sp_NhungCaTrucTableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvLichTruc;
    }
}
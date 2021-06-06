
namespace dental_sys
{
    partial class frmQL_Luong
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
            this.dgv_TraLuong = new System.Windows.Forms.DataGridView();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.cb_trangThai = new System.Windows.Forms.ComboBox();
            this.dgv_Roles = new System.Windows.Forms.DataGridView();
            this.txtMucLuong = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TraLuong
            // 
            this.dgv_TraLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TraLuong.Location = new System.Drawing.Point(12, 202);
            this.dgv_TraLuong.Name = "dgv_TraLuong";
            this.dgv_TraLuong.Size = new System.Drawing.Size(981, 286);
            this.dgv_TraLuong.TabIndex = 0;
            this.dgv_TraLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TraLuong_CellClick);
            // 
            // cb_filter
            // 
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "(None)",
            "Tháng lương hiện tại"});
            this.cb_filter.Location = new System.Drawing.Point(569, 158);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(183, 21);
            this.cb_filter.TabIndex = 1;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // cb_trangThai
            // 
            this.cb_trangThai.FormattingEnabled = true;
            this.cb_trangThai.Items.AddRange(new object[] {
            "(None)",
            "Đã trả",
            "Chưa trả"});
            this.cb_trangThai.Location = new System.Drawing.Point(810, 158);
            this.cb_trangThai.Name = "cb_trangThai";
            this.cb_trangThai.Size = new System.Drawing.Size(183, 21);
            this.cb_trangThai.TabIndex = 2;
            this.cb_trangThai.SelectedIndexChanged += new System.EventHandler(this.cb_trangThai_SelectedIndexChanged);
            // 
            // dgv_Roles
            // 
            this.dgv_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Roles.Location = new System.Drawing.Point(12, 12);
            this.dgv_Roles.Name = "dgv_Roles";
            this.dgv_Roles.Size = new System.Drawing.Size(300, 150);
            this.dgv_Roles.TabIndex = 3;
            this.dgv_Roles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Roles_CellClick);
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.Location = new System.Drawing.Point(319, 13);
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(100, 20);
            this.txtMucLuong.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(319, 51);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmQL_Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 500);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtMucLuong);
            this.Controls.Add(this.dgv_Roles);
            this.Controls.Add(this.cb_trangThai);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.dgv_TraLuong);
            this.Name = "frmQL_Luong";
            this.Text = "frmQL_Luong";
            this.Load += new System.EventHandler(this.frmQL_Luong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TraLuong;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.ComboBox cb_trangThai;
        private System.Windows.Forms.DataGridView dgv_Roles;
        private System.Windows.Forms.TextBox txtMucLuong;
        private System.Windows.Forms.Button btnSua;
    }
}
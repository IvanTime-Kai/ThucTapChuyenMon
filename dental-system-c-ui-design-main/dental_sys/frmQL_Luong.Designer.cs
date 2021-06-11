
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQL_Luong));
            this.dgv_TraLuong = new System.Windows.Forms.DataGridView();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.cb_trangThai = new System.Windows.Forms.ComboBox();
            this.dgv_Roles = new System.Windows.Forms.DataGridView();
            this.txtMucLuong = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_TraLuong
            // 
            this.dgv_TraLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TraLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TraLuong.GridColor = System.Drawing.Color.Black;
            this.dgv_TraLuong.Location = new System.Drawing.Point(145, 329);
            this.dgv_TraLuong.Name = "dgv_TraLuong";
            this.dgv_TraLuong.Size = new System.Drawing.Size(981, 286);
            this.dgv_TraLuong.TabIndex = 0;
            this.dgv_TraLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TraLuong_CellClick);
            // 
            // cb_filter
            // 
            this.cb_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "(None)",
            "Tháng lương hiện tại"});
            this.cb_filter.Location = new System.Drawing.Point(166, 280);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(183, 28);
            this.cb_filter.TabIndex = 1;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // cb_trangThai
            // 
            this.cb_trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_trangThai.FormattingEnabled = true;
            this.cb_trangThai.Items.AddRange(new object[] {
            "(None)",
            "Đã trả",
            "Chưa trả"});
            this.cb_trangThai.Location = new System.Drawing.Point(379, 280);
            this.cb_trangThai.Name = "cb_trangThai";
            this.cb_trangThai.Size = new System.Drawing.Size(183, 28);
            this.cb_trangThai.TabIndex = 2;
            this.cb_trangThai.SelectedIndexChanged += new System.EventHandler(this.cb_trangThai_SelectedIndexChanged);
            // 
            // dgv_Roles
            // 
            this.dgv_Roles.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Roles.GridColor = System.Drawing.Color.Black;
            this.dgv_Roles.Location = new System.Drawing.Point(596, 97);
            this.dgv_Roles.Name = "dgv_Roles";
            this.dgv_Roles.Size = new System.Drawing.Size(530, 211);
            this.dgv_Roles.TabIndex = 3;
            this.dgv_Roles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Roles_CellClick);
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.Location = new System.Drawing.Point(142, 38);
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(160, 29);
            this.txtMucLuong.TabIndex = 4;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.btnSua.Location = new System.Drawing.Point(112, 79);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 50);
            this.btnSua.TabIndex = 19;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMucLuong);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(194, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 149);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lương";
            // 
            // frmQL_Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Roles);
            this.Controls.Add(this.cb_trangThai);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.dgv_TraLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQL_Luong";
            this.Text = "frmQL_Luong";
            this.Load += new System.EventHandler(this.frmQL_Luong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Roles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TraLuong;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.ComboBox cb_trangThai;
        private System.Windows.Forms.DataGridView dgv_Roles;
        private System.Windows.Forms.TextBox txtMucLuong;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}
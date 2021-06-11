
namespace dental_sys
{
    partial class frmQL_ThanhToan
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_ThanhToanBDT = new System.Windows.Forms.DataGridView();
            this.cbBenhNhan_BDT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_ThanhToanDT = new System.Windows.Forms.DataGridView();
            this.cbBenhNhan_DT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThanhToanBDT)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThanhToanDT)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1303, 693);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_ThanhToanBDT);
            this.tabPage1.Controls.Add(this.cbBenhNhan_BDT);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1295, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thanh toán Buổi điều trị";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgv_ThanhToanBDT
            // 
            this.dgv_ThanhToanBDT.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ThanhToanBDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThanhToanBDT.GridColor = System.Drawing.Color.Black;
            this.dgv_ThanhToanBDT.Location = new System.Drawing.Point(240, 129);
            this.dgv_ThanhToanBDT.Name = "dgv_ThanhToanBDT";
            this.dgv_ThanhToanBDT.Size = new System.Drawing.Size(854, 384);
            this.dgv_ThanhToanBDT.TabIndex = 5;
            this.dgv_ThanhToanBDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThanhToanBDT_CellClick);
            // 
            // cbBenhNhan_BDT
            // 
            this.cbBenhNhan_BDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBenhNhan_BDT.FormattingEnabled = true;
            this.cbBenhNhan_BDT.Location = new System.Drawing.Point(621, 81);
            this.cbBenhNhan_BDT.Name = "cbBenhNhan_BDT";
            this.cbBenhNhan_BDT.Size = new System.Drawing.Size(158, 32);
            this.cbBenhNhan_BDT.TabIndex = 1;
            this.cbBenhNhan_BDT.SelectedIndexChanged += new System.EventHandler(this.cbBenhNhan_BDT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bệnh nhân:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_ThanhToanDT);
            this.tabPage2.Controls.Add(this.cbBenhNhan_DT);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1295, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thanh toán Đơn thuốc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_ThanhToanDT
            // 
            this.dgv_ThanhToanDT.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ThanhToanDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThanhToanDT.GridColor = System.Drawing.Color.Black;
            this.dgv_ThanhToanDT.Location = new System.Drawing.Point(8, 106);
            this.dgv_ThanhToanDT.Name = "dgv_ThanhToanDT";
            this.dgv_ThanhToanDT.Size = new System.Drawing.Size(787, 333);
            this.dgv_ThanhToanDT.TabIndex = 4;
            this.dgv_ThanhToanDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThanhToanDT_CellClick);
            // 
            // cbBenhNhan_DT
            // 
            this.cbBenhNhan_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBenhNhan_DT.FormattingEnabled = true;
            this.cbBenhNhan_DT.Location = new System.Drawing.Point(391, 54);
            this.cbBenhNhan_DT.Name = "cbBenhNhan_DT";
            this.cbBenhNhan_DT.Size = new System.Drawing.Size(172, 32);
            this.cbBenhNhan_DT.TabIndex = 3;
            this.cbBenhNhan_DT.SelectedIndexChanged += new System.EventHandler(this.cbBenhNhan_DT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bệnh nhân:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmQL_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 693);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQL_ThanhToan";
            this.Text = "frmQL_ThanhToan";
            this.Load += new System.EventHandler(this.frmQL_ThanhToan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThanhToanBDT)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThanhToanDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_ThanhToanBDT;
        private System.Windows.Forms.ComboBox cbBenhNhan_BDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_ThanhToanDT;
        private System.Windows.Forms.ComboBox cbBenhNhan_DT;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
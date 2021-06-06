
namespace dental_sys
{
    partial class frmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuenMatKhau));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtGmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTK = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnGui = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tài khoản";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtGmail
            // 
            this.txtGmail.BorderColorFocused = System.Drawing.Color.Red;
            this.txtGmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGmail.BorderColorMouseHover = System.Drawing.Color.Red;
            this.txtGmail.BorderThickness = 1;
            this.txtGmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGmail.isPassword = false;
            this.txtGmail.Location = new System.Drawing.Point(319, 114);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(219, 33);
            this.txtGmail.TabIndex = 19;
            this.txtGmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTK
            // 
            this.txtTK.BorderColorFocused = System.Drawing.Color.Red;
            this.txtTK.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTK.BorderColorMouseHover = System.Drawing.Color.Red;
            this.txtTK.BorderThickness = 1;
            this.txtTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTK.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTK.isPassword = false;
            this.txtTK.Location = new System.Drawing.Point(319, 73);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(219, 33);
            this.txtTK.TabIndex = 18;
            this.txtTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGui
            // 
            this.btnGui.ActiveBorderThickness = 1;
            this.btnGui.ActiveCornerRadius = 20;
            this.btnGui.ActiveFillColor = System.Drawing.Color.Red;
            this.btnGui.ActiveForecolor = System.Drawing.Color.White;
            this.btnGui.ActiveLineColor = System.Drawing.Color.Black;
            this.btnGui.BackColor = System.Drawing.SystemColors.Control;
            this.btnGui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGui.BackgroundImage")));
            this.btnGui.ButtonText = "Gửi";
            this.btnGui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGui.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGui.IdleBorderThickness = 1;
            this.btnGui.IdleCornerRadius = 20;
            this.btnGui.IdleFillColor = System.Drawing.Color.White;
            this.btnGui.IdleForecolor = System.Drawing.Color.Red;
            this.btnGui.IdleLineColor = System.Drawing.Color.Black;
            this.btnGui.Location = new System.Drawing.Point(407, 186);
            this.btnGui.Margin = new System.Windows.Forms.Padding(5);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(116, 41);
            this.btnGui.TabIndex = 21;
            this.btnGui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ActiveBorderThickness = 1;
            this.btnThoat.ActiveCornerRadius = 20;
            this.btnThoat.ActiveFillColor = System.Drawing.Color.Red;
            this.btnThoat.ActiveForecolor = System.Drawing.Color.White;
            this.btnThoat.ActiveLineColor = System.Drawing.Color.Black;
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.IdleBorderThickness = 1;
            this.btnThoat.IdleCornerRadius = 20;
            this.btnThoat.IdleFillColor = System.Drawing.Color.White;
            this.btnThoat.IdleForecolor = System.Drawing.Color.Red;
            this.btnThoat.IdleLineColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(249, 186);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 41);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dental_sys.Properties.Resources.icons8_password_64;
            this.pictureBox1.Location = new System.Drawing.Point(43, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 278);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuenMatKhau";
            this.Text = "frmQuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGui;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThoat;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace dental_sys
{
    partial class frmotp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmotp));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtmaxn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGui = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập mã OTP";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtmaxn
            // 
            this.txtmaxn.BorderColorFocused = System.Drawing.Color.Red;
            this.txtmaxn.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmaxn.BorderColorMouseHover = System.Drawing.Color.Red;
            this.txtmaxn.BorderThickness = 1;
            this.txtmaxn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaxn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmaxn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmaxn.isPassword = false;
            this.txtmaxn.Location = new System.Drawing.Point(166, 92);
            this.txtmaxn.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaxn.Name = "txtmaxn";
            this.txtmaxn.Size = new System.Drawing.Size(127, 32);
            this.txtmaxn.TabIndex = 7;
            this.txtmaxn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dental_sys.Properties.Resources.icons8_good_pincode_64;
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnGui
            // 
            this.btnGui.ActiveBorderThickness = 1;
            this.btnGui.ActiveCornerRadius = 20;
            this.btnGui.ActiveFillColor = System.Drawing.Color.White;
            this.btnGui.ActiveForecolor = System.Drawing.Color.Red;
            this.btnGui.ActiveLineColor = System.Drawing.Color.Red;
            this.btnGui.BackColor = System.Drawing.SystemColors.Control;
            this.btnGui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGui.BackgroundImage")));
            this.btnGui.ButtonText = "Gửi";
            this.btnGui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGui.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGui.IdleBorderThickness = 1;
            this.btnGui.IdleCornerRadius = 20;
            this.btnGui.IdleFillColor = System.Drawing.Color.Red;
            this.btnGui.IdleForecolor = System.Drawing.Color.White;
            this.btnGui.IdleLineColor = System.Drawing.Color.Black;
            this.btnGui.Location = new System.Drawing.Point(119, 145);
            this.btnGui.Margin = new System.Windows.Forms.Padding(5);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(103, 41);
            this.btnGui.TabIndex = 8;
            this.btnGui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // frmotp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 208);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtmaxn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmotp";
            this.Text = "frmotp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGui;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtmaxn;
    }
}
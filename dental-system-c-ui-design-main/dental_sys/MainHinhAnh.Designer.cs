
namespace dental_sys
{
    partial class MainHinhAnh
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pcchinh = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcchinh)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pcchinh
            // 
            this.pcchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcchinh.Image = global::dental_sys.Properties.Resources._1;
            this.pcchinh.Location = new System.Drawing.Point(0, 0);
            this.pcchinh.Name = "pcchinh";
            this.pcchinh.Size = new System.Drawing.Size(1161, 572);
            this.pcchinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcchinh.TabIndex = 0;
            this.pcchinh.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 572);
            this.Controls.Add(this.pcchinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainHinhAnh";
            this.Text = "MainHinhAnh";
            ((System.ComponentModel.ISupportInitialize)(this.pcchinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pcchinh;
        private System.Windows.Forms.Timer timer1;
    }
}
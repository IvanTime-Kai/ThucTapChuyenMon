
namespace dental_sys
{
    partial class frm_NhanDienKhuonMat
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(13, 13);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(846, 641);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // frm_NhanDienKhuonMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 666);
            this.Controls.Add(this.picCapture);
            this.Name = "frm_NhanDienKhuonMat";
            this.Text = "Nhận Diện Khuôn Mặt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_NhanDienKhuonMat_FormClosed);
            this.Load += new System.EventHandler(this.frm_NhanDienKhuonMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
    }
}
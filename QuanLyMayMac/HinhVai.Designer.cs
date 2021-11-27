namespace QuanLyMayMac
{
    partial class fHinhVai
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
            this.ptrBHinhVai = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBHinhVai)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrBHinhVai
            // 
            this.ptrBHinhVai.Location = new System.Drawing.Point(12, 12);
            this.ptrBHinhVai.Name = "ptrBHinhVai";
            this.ptrBHinhVai.Size = new System.Drawing.Size(660, 637);
            this.ptrBHinhVai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrBHinhVai.TabIndex = 0;
            this.ptrBHinhVai.TabStop = false;
            // 
            // fHinhVai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.ptrBHinhVai);
            this.Name = "fHinhVai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hinh Anh";
            ((System.ComponentModel.ISupportInitialize)(this.ptrBHinhVai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrBHinhVai;
    }
}
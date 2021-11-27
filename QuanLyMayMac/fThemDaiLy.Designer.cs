namespace QuanLyMayMac
{
    partial class fThemDaiLy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtDiaChiXoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDTXoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenXoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.txtDiaChiXoa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSDTXoa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenXoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 121);
            this.panel1.TabIndex = 0;
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Location = new System.Drawing.Point(165, 81);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 34);
            this.btThoat.TabIndex = 25;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(84, 82);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 33);
            this.btThem.TabIndex = 24;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtDiaChiXoa
            // 
            this.txtDiaChiXoa.Location = new System.Drawing.Point(84, 55);
            this.txtDiaChiXoa.Name = "txtDiaChiXoa";
            this.txtDiaChiXoa.Size = new System.Drawing.Size(167, 20);
            this.txtDiaChiXoa.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dia chi :";
            // 
            // txtSDTXoa
            // 
            this.txtSDTXoa.Location = new System.Drawing.Point(84, 29);
            this.txtSDTXoa.Name = "txtSDTXoa";
            this.txtSDTXoa.Size = new System.Drawing.Size(167, 20);
            this.txtSDTXoa.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "So dien thoai :";
            // 
            // txtTenXoa
            // 
            this.txtTenXoa.Location = new System.Drawing.Point(84, 3);
            this.txtTenXoa.Name = "txtTenXoa";
            this.txtTenXoa.Size = new System.Drawing.Size(167, 20);
            this.txtTenXoa.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ten dai ly :";
            // 
            // fThemDaiLy
            // 
            this.AcceptButton = this.btThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(283, 146);
            this.Controls.Add(this.panel1);
            this.Name = "fThemDaiLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Them dai ly";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtDiaChiXoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDTXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenXoa;
        private System.Windows.Forms.Label label3;


    }
}
namespace QuanLyMayMac
{
    partial class fNhapTrangPhuc
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
            this.cbBKho = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ptrBLoaiVai = new System.Windows.Forms.PictureBox();
            this.cbBIDLoaiTP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thongTinCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThongTinCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapVaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBLoaiVai)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbBKho);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btNhap);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ptrBLoaiVai);
            this.panel1.Controls.Add(this.cbBIDLoaiTP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 398);
            this.panel1.TabIndex = 1;
            // 
            // cbBKho
            // 
            this.cbBKho.FormattingEnabled = true;
            this.cbBKho.Location = new System.Drawing.Point(91, 277);
            this.cbBKho.Name = "cbBKho";
            this.cbBKho.Size = new System.Drawing.Size(215, 21);
            this.cbBKho.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kho :";
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Location = new System.Drawing.Point(189, 304);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(92, 38);
            this.btThoat.TabIndex = 16;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btNhap
            // 
            this.btNhap.Location = new System.Drawing.Point(91, 304);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(92, 38);
            this.btNhap.TabIndex = 15;
            this.btNhap.Text = "Nhap";
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(91, 251);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(215, 20);
            this.txtSoLuong.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "So luong :";
            // 
            // ptrBLoaiVai
            // 
            this.ptrBLoaiVai.Location = new System.Drawing.Point(91, 30);
            this.ptrBLoaiVai.Name = "ptrBLoaiVai";
            this.ptrBLoaiVai.Size = new System.Drawing.Size(215, 215);
            this.ptrBLoaiVai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrBLoaiVai.TabIndex = 6;
            this.ptrBLoaiVai.TabStop = false;
            // 
            // cbBIDLoaiTP
            // 
            this.cbBIDLoaiTP.FormattingEnabled = true;
            this.cbBIDLoaiTP.Location = new System.Drawing.Point(91, 3);
            this.cbBIDLoaiTP.Name = "cbBIDLoaiTP";
            this.cbBIDLoaiTP.Size = new System.Drawing.Size(215, 21);
            this.cbBIDLoaiTP.TabIndex = 5;
            this.cbBIDLoaiTP.SelectedIndexChanged += new System.EventHandler(this.cbBIDLoaiTP_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Trang phuc :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinCaNhanToolStripMenuItem,
            this.nhapVaiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thongTinCaNhanToolStripMenuItem
            // 
            this.thongTinCaNhanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThongTinCaNhanToolStripMenuItem,
            this.doiMatKhauToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
            this.thongTinCaNhanToolStripMenuItem.Name = "thongTinCaNhanToolStripMenuItem";
            this.thongTinCaNhanToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.thongTinCaNhanToolStripMenuItem.Text = "Thong tin ca nhan";
            // 
            // xemThongTinCaNhanToolStripMenuItem
            // 
            this.xemThongTinCaNhanToolStripMenuItem.Name = "xemThongTinCaNhanToolStripMenuItem";
            this.xemThongTinCaNhanToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.xemThongTinCaNhanToolStripMenuItem.Text = "Xem thong tin ca nhan";
            this.xemThongTinCaNhanToolStripMenuItem.Click += new System.EventHandler(this.xemThongTinCaNhanToolStripMenuItem_Click);
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.doiMatKhauToolStripMenuItem.Text = "Doi mat khau";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dangXuatToolStripMenuItem.Text = "Dang xuat";
            // 
            // nhapVaiToolStripMenuItem
            // 
            this.nhapVaiToolStripMenuItem.Name = "nhapVaiToolStripMenuItem";
            this.nhapVaiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.nhapVaiToolStripMenuItem.Text = "Nhap vai";
            this.nhapVaiToolStripMenuItem.Click += new System.EventHandler(this.nhapVaiToolStripMenuItem_Click);
            // 
            // fNhapTrangPhuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fNhapTrangPhuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhap trang phuc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBLoaiVai)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptrBLoaiVai;
        private System.Windows.Forms.ComboBox cbBIDLoaiTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBKho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thongTinCaNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThongTinCaNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapVaiToolStripMenuItem;

    }
}
namespace QuanLyMayMac
{
    partial class fThemMauAo
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
            this.ptrBLoaiVai = new System.Windows.Forms.PictureBox();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.txtTenTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckBAo = new System.Windows.Forms.CheckBox();
            this.cbBLoaiVai = new System.Windows.Forms.ComboBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.ptrBHinhAnhMau = new System.Windows.Forms.PictureBox();
            this.txtTaiAnh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HinhAnhTrangPhuc = new System.Windows.Forms.OpenFileDialog();
            this.txtKichThuoc = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBLoaiVai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBHinhAnhMau)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtKichThuoc);
            this.panel1.Controls.Add(this.ptrBLoaiVai);
            this.panel1.Controls.Add(this.txtDuongDan);
            this.panel1.Controls.Add(this.txtTenTP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ckBAo);
            this.panel1.Controls.Add(this.cbBLoaiVai);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.ptrBHinhAnhMau);
            this.panel1.Controls.Add(this.txtTaiAnh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 347);
            this.panel1.TabIndex = 1;
            // 
            // ptrBLoaiVai
            // 
            this.ptrBLoaiVai.Location = new System.Drawing.Point(6, 124);
            this.ptrBLoaiVai.Name = "ptrBLoaiVai";
            this.ptrBLoaiVai.Size = new System.Drawing.Size(175, 175);
            this.ptrBLoaiVai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrBLoaiVai.TabIndex = 18;
            this.ptrBLoaiVai.TabStop = false;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(245, 96);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(117, 20);
            this.txtDuongDan.TabIndex = 17;
            // 
            // txtTenTP
            // 
            this.txtTenTP.Location = new System.Drawing.Point(6, 19);
            this.txtTenTP.Name = "txtTenTP";
            this.txtTenTP.Size = new System.Drawing.Size(175, 20);
            this.txtTenTP.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ten :";
            // 
            // ckBAo
            // 
            this.ckBAo.AutoSize = true;
            this.ckBAo.Location = new System.Drawing.Point(187, 60);
            this.ckBAo.Name = "ckBAo";
            this.ckBAo.Size = new System.Drawing.Size(39, 17);
            this.ckBAo.TabIndex = 14;
            this.ckBAo.Text = "Ao";
            this.ckBAo.UseVisualStyleBackColor = true;
            // 
            // cbBLoaiVai
            // 
            this.cbBLoaiVai.FormattingEnabled = true;
            this.cbBLoaiVai.Location = new System.Drawing.Point(6, 97);
            this.cbBLoaiVai.Name = "cbBLoaiVai";
            this.cbBLoaiVai.Size = new System.Drawing.Size(175, 21);
            this.cbBLoaiVai.TabIndex = 13;
            this.cbBLoaiVai.SelectedIndexChanged += new System.EventHandler(this.cbBLoaiVai_SelectedIndexChanged);
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Location = new System.Drawing.Point(188, 305);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(84, 39);
            this.btThoat.TabIndex = 12;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(97, 305);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(84, 39);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // ptrBHinhAnhMau
            // 
            this.ptrBHinhAnhMau.Location = new System.Drawing.Point(187, 124);
            this.ptrBHinhAnhMau.Name = "ptrBHinhAnhMau";
            this.ptrBHinhAnhMau.Size = new System.Drawing.Size(175, 175);
            this.ptrBHinhAnhMau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrBHinhAnhMau.TabIndex = 10;
            this.ptrBHinhAnhMau.TabStop = false;
            // 
            // txtTaiAnh
            // 
            this.txtTaiAnh.Location = new System.Drawing.Point(187, 97);
            this.txtTaiAnh.Name = "txtTaiAnh";
            this.txtTaiAnh.Size = new System.Drawing.Size(52, 20);
            this.txtTaiAnh.TabIndex = 9;
            this.txtTaiAnh.Text = "Tai anh";
            this.txtTaiAnh.UseVisualStyleBackColor = true;
            this.txtTaiAnh.Click += new System.EventHandler(this.txtTaiAnh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hinh anh mau :";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(6, 58);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(175, 20);
            this.txtGia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gia :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loai vai :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kich thuoc :";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.FormattingEnabled = true;
            this.txtKichThuoc.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.txtKichThuoc.Location = new System.Drawing.Point(187, 19);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(175, 21);
            this.txtKichThuoc.TabIndex = 19;
            // 
            // fThemMauAo
            // 
            this.AcceptButton = this.btThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(391, 372);
            this.Controls.Add(this.panel1);
            this.Name = "fThemMauAo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Them mau ao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBLoaiVai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBHinhAnhMau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckBAo;
        private System.Windows.Forms.ComboBox cbBLoaiVai;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.PictureBox ptrBHinhAnhMau;
        private System.Windows.Forms.Button txtTaiAnh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog HinhAnhTrangPhuc;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.PictureBox ptrBLoaiVai;
        private System.Windows.Forms.ComboBox txtKichThuoc;
    }
}
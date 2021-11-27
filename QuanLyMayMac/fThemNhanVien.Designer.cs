namespace QuanLyMayMac
{
    partial class fThemNhanVien
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
            this.cbBBoPhan = new System.Windows.Forms.ComboBox();
            this.cbBToTruong = new System.Windows.Forms.ComboBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dTPkNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbBBoPhan);
            this.panel1.Controls.Add(this.cbBToTruong);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.dTPkNgayVaoLam);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtLuong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNamSinh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCMND);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 255);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbBBoPhan
            // 
            this.cbBBoPhan.FormattingEnabled = true;
            this.cbBBoPhan.Items.AddRange(new object[] {
            "Quản lý",
            "Nhập vải",
            "Xuất hàng",
            "Nhân viên"});
            this.cbBBoPhan.Location = new System.Drawing.Point(88, 107);
            this.cbBBoPhan.Name = "cbBBoPhan";
            this.cbBBoPhan.Size = new System.Drawing.Size(200, 21);
            this.cbBBoPhan.TabIndex = 25;
            this.cbBBoPhan.SelectedIndexChanged += new System.EventHandler(this.cbBBoPhan_SelectedIndexChanged);
            // 
            // cbBToTruong
            // 
            this.cbBToTruong.FormattingEnabled = true;
            this.cbBToTruong.Location = new System.Drawing.Point(88, 160);
            this.cbBToTruong.Name = "cbBToTruong";
            this.cbBToTruong.Size = new System.Drawing.Size(200, 21);
            this.cbBToTruong.TabIndex = 24;
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Location = new System.Drawing.Point(192, 213);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(96, 36);
            this.btThoat.TabIndex = 22;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(88, 213);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(96, 36);
            this.btThem.TabIndex = 21;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dTPkNgayVaoLam
            // 
            this.dTPkNgayVaoLam.Location = new System.Drawing.Point(88, 187);
            this.dTPkNgayVaoLam.Name = "dTPkNgayVaoLam";
            this.dTPkNgayVaoLam.Size = new System.Drawing.Size(200, 20);
            this.dTPkNgayVaoLam.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngay vao lam :";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(88, 134);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(200, 20);
            this.txtLuong.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Luong :";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(88, 81);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(200, 20);
            this.txtNamSinh.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nam sinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "To truong :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bo phan :";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(88, 55);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 20);
            this.txtSDT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SDT :";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(88, 29);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(200, 20);
            this.txtCMND.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CMND";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(88, 3);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten :";
            // 
            // fThemNhanVien
            // 
            this.AcceptButton = this.btThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(320, 283);
            this.Controls.Add(this.panel1);
            this.Name = "fThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Them nhan vien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DateTimePicker dTPkNgayVaoLam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBToTruong;
        private System.Windows.Forms.ComboBox cbBBoPhan;
    }
}
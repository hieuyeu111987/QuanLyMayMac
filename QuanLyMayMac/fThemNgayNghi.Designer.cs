namespace QuanLyMayMac
{
    partial class fThemNgayNghi
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
            this.dtPKNgayNghi = new System.Windows.Forms.DateTimePicker();
            this.dtGVNgayNghi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.ckBCoPhep = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNgayNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.dtPKNgayNghi);
            this.panel1.Controls.Add(this.dtGVNgayNghi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.ckBCoPhep);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenNhanVien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIDNhanVien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 252);
            this.panel1.TabIndex = 0;
            // 
            // dtPKNgayNghi
            // 
            this.dtPKNgayNghi.CustomFormat = "yyyy/MM/dd";
            this.dtPKNgayNghi.Location = new System.Drawing.Point(91, 162);
            this.dtPKNgayNghi.Name = "dtPKNgayNghi";
            this.dtPKNgayNghi.Size = new System.Drawing.Size(247, 20);
            this.dtPKNgayNghi.TabIndex = 11;
            this.dtPKNgayNghi.Value = new System.DateTime(2019, 6, 24, 0, 0, 0, 0);
            // 
            // dtGVNgayNghi
            // 
            this.dtGVNgayNghi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVNgayNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVNgayNghi.Location = new System.Drawing.Point(91, 55);
            this.dtGVNgayNghi.Name = "dtGVNgayNghi";
            this.dtGVNgayNghi.Size = new System.Drawing.Size(247, 98);
            this.dtGVNgayNghi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngay nghi :";
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Location = new System.Drawing.Point(255, 208);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(76, 41);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(91, 208);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(76, 41);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // ckBCoPhep
            // 
            this.ckBCoPhep.AutoSize = true;
            this.ckBCoPhep.Location = new System.Drawing.Point(91, 185);
            this.ckBCoPhep.Name = "ckBCoPhep";
            this.ckBCoPhep.Size = new System.Drawing.Size(66, 17);
            this.ckBCoPhep.TabIndex = 6;
            this.ckBCoPhep.Text = "Co phep";
            this.ckBCoPhep.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngay nghi :";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(91, 29);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(247, 20);
            this.txtTenNhanVien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten nhan vien :";
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.Location = new System.Drawing.Point(91, 3);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.ReadOnly = true;
            this.txtIDNhanVien.Size = new System.Drawing.Size(247, 20);
            this.txtIDNhanVien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID nhan vien :";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(173, 208);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(76, 41);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xoa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // fThemNgayNghi
            // 
            this.AcceptButton = this.btThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(372, 279);
            this.Controls.Add(this.panel1);
            this.Name = "fThemNgayNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngay nghi nhan vien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNgayNghi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.CheckBox ckBCoPhep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView dtGVNgayNghi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPKNgayNghi;
        private System.Windows.Forms.Button btXoa;
    }
}
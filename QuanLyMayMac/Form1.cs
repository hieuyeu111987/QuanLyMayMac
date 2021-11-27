using QuanLyMayMac.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayMac
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat chuong trinh?", "Thong bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string bophan = NhanVienDAO.Instance.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
            if (bophan == "Quản lý")
            {
                fQuanLy quanly = new fQuanLy();
                this.Hide();
                quanly.ShowDialog();
                this.Show();
            }
            if (bophan == "Nhập hàng")
            {
                fNhapVai nhapvai = new fNhapVai();
                this.Hide();
                nhapvai.ShowDialog();
                this.Show();
            }
            if (bophan == "Xuất hàng")
            {
                fXuatTrangPhuc xuattrangphuc = new fXuatTrangPhuc();
                this.Hide();
                xuattrangphuc.ShowDialog();
                this.Show();
            }
            if (bophan == "0")
            {
                MessageBox.Show("Tai khoan hoac mat khau khong dung", "Thong bao");
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}

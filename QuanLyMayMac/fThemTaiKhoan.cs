using QuanLyMayMac.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayMac
{
    public partial class fThemTaiKhoan : Form
    {
        public fThemTaiKhoan()
        {
            InitializeComponent();
        }

        private int iDThem = NhanVienDAO.Instance.TraID();

        private void btThem_Click(object sender, EventArgs e)
        {
            if ((txtTaiKhoan.Text == null) || (txtMatKhau.Text == null))
            {
                MessageBox.Show("Thieu thong tin!", "Thong bao");
            }
            else
            {
                string matKhauMaHoa = NhanVienDAO.Instance.MaHoaMatKhau(txtMatKhau.Text);
                NhanVienDAO.Instance.ThemTaiKhoan(this.iDThem, txtTaiKhoan.Text, matKhauMaHoa);
                MessageBox.Show("Them tai khoan thanh cong!", "Thong bao");
                this.Close();
            }
        }

        void Thoat()
        {
            string kiemTra = (DataProvider.Instance.ExecuteScalar("SELECT IDNhanVien FROM TAIKHOAN WHERE IDNhanVien = " + this.iDThem)).ToString();
            if (kiemTra != null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhan vien can them tai khoan", "Thong bao");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Thoat();
        }

        private void fThemTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thoat();
        }
    }
}

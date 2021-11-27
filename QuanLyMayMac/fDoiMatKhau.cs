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
    public partial class fDoiMatKhau : Form
    {
        public fDoiMatKhau()
        {
            InitializeComponent();
            LoadThongTin();
        }

        void LoadThongTin()
        {
            string ID = (NhanVienDAO.Instance.IDCaNhan()).ToString();
            txtID.Text = NhanVienDAO.Instance.ThongTinCaNhan("IDNhanVien","NhanVien");
            txtTen.Text = NhanVienDAO.Instance.ThongTinCaNhan("TenNhanVien","NhanVien");
            txtTaiKhoan.Text = NhanVienDAO.Instance.ThongTinCaNhan("TenTaiKhoan", "TaiKhoan");

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            string ID = (NhanVienDAO.Instance.IDCaNhan()).ToString();
            string matKhauCu = (DataProvider.Instance.ExecuteScalar("SELECT MatKhau FROM TaiKhoan WHERE IDNhanVien = " + ID)).ToString();
            if ((txtMatKhau.Text == "") || (txtMatKhauMoi.Text == "") || (txtNhapLaiMatKhau.Text == ""))
            {
                MessageBox.Show("Thieu thong tin!", "Thong bao");
            }
            else if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mat khau nhap lai khong dung!", "Thong bao");
            }
            else if (txtMatKhau.Text == txtMatKhauMoi.Text)
            {
                MessageBox.Show("Mat khau moi trung voi mat khau cu!", "Thong bao");
            }
            else if ((NhanVienDAO.Instance.MaHoaMatKhau(txtMatKhau.Text)).ToString() != matKhauCu)
            {
                MessageBox.Show("Mat khau nhap vao khong dung!", "Thong bao");
            }
            else
            {
                NhanVienDAO.Instance.DoiMatKhau(Convert.ToInt32(ID), txtMatKhauMoi.Text);
                MessageBox.Show("Doi mat khau thanh cong!", "Thong bao");
            }
        }
    }
}

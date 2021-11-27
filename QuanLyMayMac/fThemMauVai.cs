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
    public partial class fThemMauVai : Form
    {
        public fThemMauVai()
        {
            InitializeComponent();
        }

        #region methods

        #endregion

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTaiAnh_Click(object sender, EventArgs e)
        {
            fileMauVai.ShowDialog();
            string DuongDan = fileMauVai.FileName;
            if ((string.IsNullOrEmpty(DuongDan)) || (DuongDan == "openFileDialog1"))
                return;
            else
            {
                Image HinhAnh = Image.FromFile(DuongDan);
                txtDuongDan.Text = DuongDan;
                ptrBHinhAnhMau.Image = HinhAnh;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenVai.Text))
                MessageBox.Show("Ban chua nhap ten vai!", "Thong bao");
            if (string.IsNullOrEmpty(txtMauChuDao.Text))
                MessageBox.Show("Ban chua nhap mau chu dao!", "Thong bao");
            if (string.IsNullOrEmpty(txtChieuDai.Text))
                MessageBox.Show("Ban chua nhap chieu dai!", "Thong bao");
            if (string.IsNullOrEmpty(txtChieuRong.Text))
                MessageBox.Show("Ban chua nhap chieu rong!", "Thong bao");
            if (string.IsNullOrEmpty(txtDuongDan.Text))
                MessageBox.Show("Ban chua tai hinh anh!", "Thong bao");
            else
                MauVaiDAO.Instance.ThemMauVai(txtTenVai.Text,txtMauChuDao.Text,Convert.ToInt32(txtChieuDai.Text),Convert.ToInt32(txtChieuRong.Text),txtDuongDan.Text,Convert.ToInt32(txtGia.Text));
        }
    }
}

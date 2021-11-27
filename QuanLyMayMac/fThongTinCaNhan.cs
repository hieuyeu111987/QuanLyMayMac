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
    public partial class fThongTinCaNhan : Form
    {
        public fThongTinCaNhan()
        {
            InitializeComponent();
            LoadThongTin();
        }

        #region methods

        void LoadThongTin()
        {
            string id = (NhanVienDAO.Instance.IDCaNhan()).ToString();
            txtIDXem.Text = NhanVienDAO.Instance.ThongTinCaNhan("IDNhanVien","NhanVien");
            txtTenXem.Text = NhanVienDAO.Instance.ThongTinCaNhan("TenNhanVien", "NhanVien");
            txtCMNDXem.Text = NhanVienDAO.Instance.ThongTinCaNhan("CMND", "NhanVien");
            txtSDTXem.Text = NhanVienDAO.Instance.ThongTinCaNhan("SDT", "NhanVien");
            txtBoPhanXem.Text = NhanVienDAO.Instance.ThongTinCaNhan("BoPhan", "NhanVien");
            txtSoNgayNghiXem.Text = (DataProvider.Instance.ExecuteScalar("SELECT COUNT(IDNgayNghi) AS 'SoNgayNghi' FROM dbo.NgayNghi WHERE IDNhanVien = " + id)).ToString();
            txtToTruongXem.Text = (DataProvider.Instance.ExecuteScalar("SELECT TenNhanVien FROM dbo.NhanVien WHERE IDNhanVien = (SELECT IDToTruong FROM dbo.NhanVien WHERE IDNhanVien = " + id + ")")).ToString();
            txtQuanLyXem.Text = (DataProvider.Instance.ExecuteScalar("SELECT TenNhanVien FROM dbo.NhanVien WHERE IDNhanVien = (SELECT IDQuanLy FROM dbo.NhanVien WHERE IDNhanVien = " + id + ")")).ToString();
        }

        #endregion

        #region even

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtCMNDXem.Text != "" && txtSDTXem.Text != "")
            {
                NhanVienDAO.Instance.SuaThongTinCaNhan(txtCMNDXem.Text, txtSDTXem.Text, txtIDXem.Text);
                MessageBox.Show("Thanh cong!", "Thong bao");
            }
            else
            {
                MessageBox.Show("Thieu thong tin!", "Thong bao");
            }
        }

        #endregion
    }
}

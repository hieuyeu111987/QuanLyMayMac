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
    public partial class fThemNgayNghi : Form
    {
        public fThemNgayNghi()
        {
            InitializeComponent();
            LoadThongTinNhanVien();
        }

        #region methods

        void LoadDanhSachNgayNghi()
        {
            dtGVNgayNghi.DataSource = NgayNghiDAO.Instance.LoadDanhSachNgayNghi("SELECT NgayNghi AS 'Ngay nghi',CoPhep AS 'Co phep' FROM dbo.NgayNghi WHERE IDNhanVien = ");
        }

        void LoadThongTinNhanVien()
        {
            txtIDNhanVien.Text = NgayNghiDAO.Instance.ID();
            txtTenNhanVien.Text = NgayNghiDAO.Instance.Ten();
            dtPKNgayNghi.Value = DateTime.Now;
            LoadDanhSachNgayNghi();
            NgayNghiBinding();
        }

        void NgayNghiBinding()
        {
            dtPKNgayNghi.DataBindings.Add(new Binding("Value", dtGVNgayNghi.DataSource, "Ngay nghi", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #region even

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
            int cophep = 0;
            if (ckBCoPhep.Checked == true)
                cophep = 1;
            string ngay = (dtPKNgayNghi.Value.Year).ToString() + "/" + (dtPKNgayNghi.Value.Month).ToString() + "/" + (dtPKNgayNghi.Value.Day).ToString();
            NgayNghiDAO.Instance.ThemNgayNghi(ngay, cophep);
            MessageBox.Show("Them ngay nghi thanh cong!", "Thong bao");
            LoadDanhSachNgayNghi();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string ngay = (dtPKNgayNghi.Value.Year).ToString() + "/" + (dtPKNgayNghi.Value.Month).ToString() + "/" + (dtPKNgayNghi.Value.Day).ToString();
            NgayNghiDAO.Instance.XoaNgayNghi(ngay);
            MessageBox.Show("Xoa ngay " + ngay + " thanh cong!", "Thong bao");
            LoadDanhSachNgayNghi();
        }

        #endregion

    }
}

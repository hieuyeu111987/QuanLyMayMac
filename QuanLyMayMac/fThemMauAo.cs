using QuanLyMayMac.DAO;
using QuanLyMayMac.DTO;
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
    public partial class fThemMauAo : Form
    {
        public fThemMauAo()
        {
            InitializeComponent();
            LoadDanhSachMauVai();
        }

        #region methods

        void LoadDanhSachMauVai()
        {
            List<MauVai> list = MauVaiDAO.Instance.DanhSachMauVai();
            cbBLoaiVai.DataSource = list;
            cbBLoaiVai.DisplayMember = "Ten";
        }

        #endregion

        #region even

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTaiAnh_Click(object sender, EventArgs e)
        {
            HinhAnhTrangPhuc.ShowDialog();
            string DuongDan = HinhAnhTrangPhuc.FileName;
            if (string.IsNullOrEmpty(DuongDan))
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
            int Ao = 0;
            if (ckBAo.Checked == true)
            {
                Ao = 1;
            }
            else
            {
                Ao = 0;
            }
            if (string.IsNullOrEmpty(txtTenTP.Text) || string.IsNullOrEmpty(txtKichThuoc.Text) || string.IsNullOrEmpty(txtDuongDan.Text) || string.IsNullOrEmpty(cbBLoaiVai.Text) || string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Ban chua nhap du thong tin!", "Thong bao");
            }
            else
            {
                int iD = (cbBLoaiVai.SelectedItem as MauVai).ID;
                MauTrangPhucDAO.Instance.ThemMauTrangPhuc(txtTenTP.Text, Ao, txtKichThuoc.Text, txtDuongDan.Text, iD, Convert.ToInt32(txtGia.Text));
                MessageBox.Show("Them mau trang phuc thanh cong!", "Thong bao");
            }
        }

        private void cbBLoaiVai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iD = (cbBLoaiVai.SelectedItem as MauVai).ID;
            string duongdan = (DataProvider.Instance.ExecuteScalar("SELECT HinhAnhMau FROM dbo.LoaiVai WHERE IDLoaiVai = " + iD.ToString()).ToString());
            Image HinhAnh = Image.FromFile(duongdan);
            ptrBLoaiVai.Image = HinhAnh;
        }

        #endregion


        

    }
}

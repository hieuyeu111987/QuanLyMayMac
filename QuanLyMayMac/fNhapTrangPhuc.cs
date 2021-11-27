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
    public partial class fNhapTrangPhuc : Form
    {
        public fNhapTrangPhuc()
        {
            InitializeComponent();
            LoadCBB();
        }

        void LoadCBB()
        {
            List<LoaiTrangPhuc> DSTrangPhuc = MauTrangPhucDAO.Instance.DSLoaiTrangPhuc();
            cbBIDLoaiTP.DataSource = DSTrangPhuc;
            cbBIDLoaiTP.DisplayMember = "Ten";
            List<Kho> DSKho = KhoDAO.Instance.DanhSachKho();
            cbBKho.DataSource = DSKho;
            cbBKho.DisplayMember = "TenKho";
        }

        private void xemThongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinCaNhan thongtincanhan = new fThongTinCaNhan();
            this.Hide();
            thongtincanhan.ShowDialog();
            this.Show();
        }

        private void nhapVaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapVai NhapVai = new fNhapVai();
            this.Hide();
            this.Close();
            NhapVai.ShowDialog();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMatKhau doimatkhau = new fDoiMatKhau();
            this.Hide();
            doimatkhau.ShowDialog();
            this.Show();
        }

        private void cbBIDLoaiTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((cbBIDLoaiTP.SelectedItem as LoaiTrangPhuc).ID);
            ptrBLoaiVai.Image = KiemTraDAO.Instance.Hinh(ID, "LoaiTrangPhuc");
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Ban chua nhap so luong!", "Thong bao");
            }
            else
            {
                string IDNhanVien = (NhanVienDAO.Instance.IDCaNhan()).ToString();
                string IDLoaiTrangPhuc = ((cbBIDLoaiTP.SelectedItem as LoaiTrangPhuc).ID).ToString();
                string IDKho = ((cbBKho.SelectedItem as Kho).IDKho).ToString();
                int SoLuong = Convert.ToInt32(txtSoLuong.Text);
                TrangPhucDAO.Instance.NhapTrangPhuc(IDNhanVien, IDLoaiTrangPhuc, IDKho, SoLuong);
                MessageBox.Show("Nhap trang phuc thanh cong!", "Thong bao");
            }
        }
    }
}

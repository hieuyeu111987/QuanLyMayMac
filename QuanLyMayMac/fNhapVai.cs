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
    public partial class fNhapVai : Form
    {
        public fNhapVai()
        {
            InitializeComponent();
            LoadDSNhapVai();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xemThongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinCaNhan thongtincanhan = new fThongTinCaNhan();
            this.Hide();
            thongtincanhan.ShowDialog();
            this.Show();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadDSNhapVai()
        {
            List<MauVai> DSVai = MauVaiDAO.Instance.DanhSachMauVai();
            cbBIDLoaiVai.DataSource = DSVai;
            cbBIDLoaiVai.DisplayMember = "Ten";
            List<DaiLy> DSDaiLy = DaiLyDAO.Instance.DanhSachDaiLy();
            cbBDaiLy.DataSource = DSDaiLy;
            cbBDaiLy.DisplayMember = "TenDaiLy";
            List<Kho> DSKho = KhoDAO.Instance.DanhSachKho();
            cbBKho.DataSource = DSKho;
            cbBKho.DisplayMember = "TenKho";
        }

        private void nhapTrangPhucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapTrangPhuc NhapTrangPhuc = new fNhapTrangPhuc();
            this.Hide();
            this.Close();
            NhapTrangPhuc.ShowDialog();
        }

        private void cbBIDLoaiVai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((cbBIDLoaiVai.SelectedItem as MauVai).ID);
            ptrBLoaiVai.Image = KiemTraDAO.Instance.Hinh(ID, "LoaiVai");
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMatKhau doimatkhau = new fDoiMatKhau();
            this.Hide();
            doimatkhau.ShowDialog();
            this.Show();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Ban can nhap so luong!", "Thong bao");
            }
            else
            {
                string Ngay = KiemTraDAO.Instance.ChuoiNgay((dTPkNgayNhap.Value.Day).ToString(), (dTPkNgayNhap.Value.Month).ToString(), (dTPkNgayNhap.Value.Year).ToString());
                string IDNhanVien = NhanVienDAO.Instance.IDCaNhan().ToString();
                string IDDaiLy = ((cbBDaiLy.SelectedItem as DaiLy).IDDaiLy).ToString();
                string IDKho = ((cbBKho.SelectedItem as Kho).IDKho).ToString();
                string IDLoaiVai = ((cbBIDLoaiVai.SelectedItem as MauVai).ID).ToString();
                VaiDAO.Instance.NhapVai(IDNhanVien, IDDaiLy, Ngay, IDLoaiVai, IDKho, Convert.ToInt32(txtSoLuong.Text));
                MessageBox.Show("Nhap vai thanh cong!", "Thong bao");
            }
        }
    }
}

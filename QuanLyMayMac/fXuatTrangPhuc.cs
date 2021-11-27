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
    public partial class fXuatTrangPhuc : Form
    {
        public fXuatTrangPhuc()
        {
            InitializeComponent();
            LoadCBB();
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

        void LoadCBB()
        {
            List<LoaiTrangPhuc> DSLoaiTrangPhuc = MauTrangPhucDAO.Instance.DSLoaiTrangPhuc();
            cbBIDLoaiTrangPhuc.DataSource = DSLoaiTrangPhuc;
            cbBIDLoaiTrangPhuc.DisplayMember = "Ten";
            List<KhachHang> DSKhachHang = KhachHangDAO.Instance.DSKhachHang();
            cbBKhachHang.DataSource = DSKhachHang;
            cbBKhachHang.DisplayMember = "Ten";
        }

        private void cbBIDLoaiTrangPhuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((cbBIDLoaiTrangPhuc.SelectedItem as LoaiTrangPhuc).ID);
            ptrBLoaiTrangPPhuc.Image = KiemTraDAO.Instance.Hinh(ID, "LoaiTrangPhuc");
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((cbBIDLoaiTrangPhuc.SelectedItem as LoaiTrangPhuc).ID);
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Ban can nhap so luong!", "Thong bao");
            }
            else if (Convert.ToInt32(txtSoLuong.Text) > TrangPhucDAO.Instance.SoLuongTrangPhuc(ID))
            {
                MessageBox.Show("Khong du so luong hang can xuat!", "Thong bao");
            }
            else
            {
                int IDLoaiTrangPhuc = Convert.ToInt32((cbBIDLoaiTrangPhuc.SelectedItem as LoaiTrangPhuc).ID);
                int SoLuong = Convert.ToInt32(txtSoLuong.Text);
                int IDNhanVien = NhanVienDAO.Instance.IDCaNhan();
                int IDKhachHang = Convert.ToInt32((cbBKhachHang.SelectedItem as KhachHang).ID);
                string Ngay = KiemTraDAO.Instance.ChuoiNgay((dTPkNgayNhap.Value.Day).ToString(), (dTPkNgayNhap.Value.Month).ToString(), (dTPkNgayNhap.Value.Year).ToString());
                TrangPhucDAO.Instance.XuatTrangPhuc(IDLoaiTrangPhuc, SoLuong, IDNhanVien, IDKhachHang, Ngay);
                MessageBox.Show("Xuat trang phuc thanh cong!", "Thong bao");
            }
        }
    }
}

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
    public partial class fThemNhanVien : Form
    {
        public fThemNhanVien()
        {
            InitializeComponent();
            LoadThongTin();
        }

        #region methods

        void LoadThongTin()
        {
            LoadCBB();
            LoadMacDinh();
        }

        void LoadCBB()
        {
            List<ToTruong> ToTruong = NhanVienDAO.Instance.LocToTruong();
            cbBToTruong.DataSource = ToTruong;
            cbBToTruong.DisplayMember = "TenNhanVien";
            
        }

        void LoadMacDinh()
        {
            dTPkNgayVaoLam.Value = DateTime.Now;
            txtLuong.Text = "7000000";
        }

        #endregion

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                int CMND, SDT, NamSinh, Luong;
                CMND = Convert.ToInt32(txtCMND.Text);
                SDT = Convert.ToInt32(txtSDT.Text);
                NamSinh = Convert.ToInt32(txtNamSinh.Text);
                Luong = Convert.ToInt32(txtNamSinh.Text);

                string ngay = (dTPkNgayVaoLam.Value.Year).ToString() + "/" + (dTPkNgayVaoLam.Value.Month).ToString() + "/" + (dTPkNgayVaoLam.Value.Day).ToString();
                int id = (cbBToTruong.SelectedItem as ToTruong).IDNhanVien;
                int ThemNhanVien = NhanVienDAO.Instance.ThemNhanVien(txtTen.Text, txtCMND.Text, txtSDT.Text, cbBBoPhan.Text, ngay, txtNamSinh.Text, txtLuong.Text, id.ToString());
                if (ThemNhanVien == 0)
                {
                    if (cbBBoPhan.Text != "Nhân viên")
                    {
                        int iDThem = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT IDNhanVien FROM NHANVIEN WHERE CMND = " + txtCMND.Text));
                        NhanVienDAO.Instance.NhanID(iDThem);
                        fThemTaiKhoan ThemTaiKhoan = new fThemTaiKhoan();
                        ThemTaiKhoan.ShowDialog();
                    }
                    MessageBox.Show("Thanh cong", "Thong bao");
                }
                else if (ThemNhanVien == 1)
                {
                    MessageBox.Show("Thieu thong tin!", "Thong bao");
                }
                else if (ThemNhanVien == 2)
                {
                    MessageBox.Show("CMND hoac SDT da ton tai!", "Thong bao");
                }
                else
                {
                    MessageBox.Show("Thong tin sai!", "Thong bao");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mot so thong tin khong dung(CMND, SDT, nam sinh hoac luong)!", "Thong bao");
            }
            
        }

        private void cbBBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }
    }
}

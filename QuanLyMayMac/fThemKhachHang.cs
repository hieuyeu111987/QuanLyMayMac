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
    public partial class fThemKhachHang : Form
    {
        public fThemKhachHang()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if ((txtTenXoa.Text == null) || (txtSDTXoa.Text == null) || (txtDiaChiXoa.Text == null))
            {
                MessageBox.Show("Thieu thong tin!", "Thong bao");
            }
            else
            {
                KhachHangDAO.Instance.ThemKhachHang(txtTenXoa.Text, txtSDTXoa.Text, txtDiaChiXoa.Text);
                MessageBox.Show("Them khach hang thanh cong!", "Thong bao");
            }
        }
    }
}

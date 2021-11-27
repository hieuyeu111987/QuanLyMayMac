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
    public partial class fThemKho : Form
    {
        public fThemKho()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if ((txtTenKho.Text == "") || (cbBTrangThai.Text == ""))
            {
                MessageBox.Show("Thieu thong tin!", "Thong bao");
            }
            else
            {
                KhoDAO.Instance.ThemKho(txtTenKho.Text, cbBTrangThai.Text);
                MessageBox.Show("Them kho thanh cong!", "Thong bao");
            }
        }
    }
}

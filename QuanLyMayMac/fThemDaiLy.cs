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
    public partial class fThemDaiLy : Form
    {
        public fThemDaiLy()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if ((txtTenXoa.Text == "") || (txtSDTXoa.Text == "") || (txtDiaChiXoa.Text == ""))
            {
                MessageBox.Show("Thieu thong tin!", "Thong bao");
            }
            else
            {
                DaiLyDAO.Instance.ThemDaiLy(txtTenXoa.Text, txtSDTXoa.Text, txtDiaChiXoa.Text);
                MessageBox.Show("Them dai ly thanh cong!", "Thong bao");
            }
        }
    }
}

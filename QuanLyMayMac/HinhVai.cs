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
    public partial class fHinhVai : Form
    {
        public fHinhVai()
        {
            InitializeComponent();
            LoadHinhVai();
        }

        void LoadHinhVai()
        {
            int ID = KiemTraDAO.Instance.xuatID();
            string QuanAo = KiemTraDAO.Instance.xuatLoaiHinh();
            string duongdan = (DataProvider.Instance.ExecuteScalar("SELECT HinhAnhMau FROM dbo.Loai" + QuanAo + " WHERE IDLoai" + QuanAo + " = " + ID.ToString()).ToString());
            Image HinhAnh = Image.FromFile(duongdan);
            ptrBHinhVai.Image = HinhAnh;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DAO
{
    public class KiemTraDAO
    {
        private static KiemTraDAO instance;

        public static KiemTraDAO Instance
        {
            get { if(instance == null) instance = new KiemTraDAO(); return KiemTraDAO.instance; }
            private set { KiemTraDAO.instance = value; }
        }

        private KiemTraDAO() { }

        public bool KiemTraID(string ID, string Ten)
        {
            int id = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(ID"+Ten+") FROM dbo."+Ten+" WHERE ID"+Ten+" = " + ID));
            if (id > 0)
                return true;
            else
                return false;
        }

        private int iDHinh;
        private string loaiHinh;

        public void nhapID(int ID, string LoaiHinh)
        {
            this.iDHinh = ID;
            this.loaiHinh = LoaiHinh;
        }

        public int xuatID()
        {
            return this.iDHinh;
        }

        public string xuatLoaiHinh()
        {
            return this.loaiHinh;
        }

        public Image Hinh(int ID, string Bang)
        {
            return Image.FromFile((DataProvider.Instance.ExecuteScalar("SELECT HinhAnhMau FROM dbo." + Bang + " WHERE ID" + Bang + " = " + ID).ToString()));
        }

        public string ChuoiNgay(string Ngay, string Thang, string Nam)
        {
            string NgayThangNam = Nam;
            if (Thang.Length == 1)
            {
                NgayThangNam = NgayThangNam + "0" + Thang;
            }
            else
            {
                NgayThangNam = NgayThangNam + Thang;
            }
            if (Ngay.Length == 1)
            {
                NgayThangNam = NgayThangNam + "0" + Ngay;
            }
            else
            {
                NgayThangNam = NgayThangNam + Ngay;
            }
            return NgayThangNam;
        }
    }
}

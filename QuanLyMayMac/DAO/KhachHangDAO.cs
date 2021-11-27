using QuanLyMayMac.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            private set { KhachHangDAO.instance = value; }
        }

        private KhachHangDAO() { }

        public DataTable DanhSachKhachHang()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT IDKhachHang AS 'ID',TenKhachHang AS 'Ten', SDT, DiaChi AS 'Dia chi' FROM dbo.KhachHang");
        }

        public DataTable XemDSKhachHang(string TenKhachHang)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT IDKhachHang AS 'ID',TenKhachHang AS 'Ten', SDT, DiaChi AS 'Dia chi' FROM dbo.KhachHang WHERE dbo.fuConvertToUnsign1(TenKhachHang) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + TenKhachHang + "') + '%'");
        }

        public void ThemKhachHang(string Ten, string SDT, string DiaChi)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_ThemKhachHang @Ten , @SDT , @DiaChi ", new object[] { Ten, SDT, DiaChi });
        }

        public void SuaKhachHang(int iD, string ten, string SDT, string diaChi)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_SuaKhachHang @ID , @Ten , @SDT , @DiaChi ", new object[] { iD, ten, SDT, diaChi });
        }

        public int KiemTraKhachHang(int iD, string bang)
        {
            int kt = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(IDKhachHang) AS 'Dem' FROM " + bang + " WHERE IDKhachHang = " + iD));
            return kt;
        }

        public void XoaKhachHang(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_XoaKhachHang @ID ", new object[] { id });
        }

        public List<KhachHang> DSKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            string query = "SELECT IDKhachHang, TenKhachHang AS 'Ten' FROM dbo.KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhachHang khachhang = new KhachHang(item);
                list.Add(khachhang);
            }
            return list;
        }

        public string LayThongTinKhachHang(string ThongTin, int IDKhachHang)
        {
            return (DataProvider.Instance.ExecuteScalar("SELECT " + ThongTin + " FROM dbo.KhachHang WHERE IDKhachHang = " + IDKhachHang)).ToString();
        }
    }
}

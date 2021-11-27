using QuanLyMayMac.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DAO
{
    public class TrangPhucDAO
    {
        private static TrangPhucDAO instance;

        public static TrangPhucDAO Instance
        {
            get { if (instance == null) instance = new TrangPhucDAO(); return TrangPhucDAO.instance; }
            private set { TrangPhucDAO.instance = value; }
        }

        public TrangPhucDAO() { }

        public void NhapTrangPhuc(string IDNhanVien, string IDLoaiTrangPhuc, string IDKho, int SoLuong)
        {
            for (int i = 0; i < SoLuong; i++)
            {
                DataProvider.Instance.ExecuteNonQuery("USP_ThemTrangPhuc @IDLoaiTrangPhuc , @IDKho ", new object[] { IDLoaiTrangPhuc, IDKho });
            }
        }

        public int SoLuongTrangPhuc(int ID)
        {
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(IDTrangPhuc) FROM dbo.TrangPhuc WHERE IDLoaiTrangPhuc = " + ID));
        }

        public void XuatTrangPhuc(int IDLoaiTrangPhuc, int SoLuong, int IDNhanVien, int IDKhachHang, string Ngay)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_ThemHoaDonBan @NgayThanhToan , @IDNhanVien , @IDKhachHang ", new object[] { Ngay, IDNhanVien, IDKhachHang });
            int IDHoaDonBan = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT IDHoaDonBan FROM dbo.HoaDonBan WHERE NgayThanhToan = '" + Ngay + "' AND IDNhanVien = " + IDNhanVien + " AND IDKhachHang = " + IDKhachHang));
            for (int i = 0; i < SoLuong; i++)
            {
                int IDTrangPhuc = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT IDTrangPhuc FROM dbo.TrangPhuc WHERE IDLoaiTrangPhuc = " + IDLoaiTrangPhuc + " ORDER BY IDTrangPhuc OFFSET " + i + " ROWS FETCH NEXT 1 ROWS ONLY"));
                DataProvider.Instance.ExecuteNonQuery("USP_ThemChiTietHoaDonBan @IDHoaDonBan , @IDTrangPhuc ", new object[] { IDHoaDonBan, IDTrangPhuc });
            }
        }

        public DataTable LoadDSThu()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDHoaDonBan AS 'ID', a.NgayThanhToan AS 'Ngay thanh toan', a.IDKhachHang AS 'ID khach hang', a.IDNhanVien AS 'ID nhan vien', SUM(c.Gia) AS 'So tien' FROM dbo.HoaDonBan a, dbo.TrangPhuc b, dbo.GiaTrangPhuc c, dbo.ChiTietHoaDonBan d WHERE a.IDHoaDonBan = d.IDHoaDon AND d.IDTrangPhuc = b.IDTrangPhuc AND b.IDLoaiTrangPhuc = c.IDLoaiTrangPhuc GROUP BY a.IDHoaDonBan, a.NgayThanhToan, a.IDNhanVien, a.IDKhachHang");
        }

        public DataTable DanhSachThuCoNgay(string Tu, string Den)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDHoaDonBan AS 'ID',a.NgayThanhToan AS 'Ngay thanh toan',a.IDKhachHang AS 'ID khach hang',a.IDNhanVien AS 'ID nhan vien',SUM(c.Gia) AS 'So tien' FROM dbo.HoaDonBan a, dbo.TrangPhuc b, dbo.GiaTrangPhuc c, dbo.ChiTietHoaDonBan d WHERE (a.IDHoaDonBan = d.IDHoaDon AND d.IDTrangPhuc = b.IDTrangPhuc AND b.IDLoaiTrangPhuc = c.IDLoaiTrangPhuc) AND (a.NgayThanhToan >= '" + Tu + "' AND a.NgayThanhToan <= '" + Den + "') GROUP BY a.IDHoaDonBan, a.NgayThanhToan, a.IDKhachHang, a.IDNhanVien");
        }

        public string TongTienThu(string Tu, string Den)
        {
            if (((DataProvider.Instance.ExecuteScalar("SELECT SUM(c.Gia) AS 'Gia' FROM dbo.TrangPhuc b, dbo.HoaDonBan a, dbo.GiaTrangPhuc c, dbo.ChiTietHoaDonBan d WHERE (a.IDHoaDonBan = d.IDHoaDon AND d.IDTrangPhuc = b.IDTrangPhuc AND b.IDLoaiTrangPhuc = c.IDLoaiTrangPhuc) AND (a.NgayThanhToan >= '" + Tu + "' AND a.NgayThanhToan <= '" + Den + "')")).ToString()) == null)
            {
                return "0";
            }
            else
            {
                return (DataProvider.Instance.ExecuteScalar("SELECT SUM(c.Gia) AS 'Gia' FROM dbo.TrangPhuc b, dbo.HoaDonBan a, dbo.GiaTrangPhuc c, dbo.ChiTietHoaDonBan d WHERE (a.IDHoaDonBan = d.IDHoaDon AND d.IDTrangPhuc = b.IDTrangPhuc AND b.IDLoaiTrangPhuc = c.IDLoaiTrangPhuc) AND (a.NgayThanhToan >= '" + Tu + "' AND a.NgayThanhToan <= '" + Den + "')")).ToString();
            }
        }

        public List<LoaiTrangPhuc> LoadDSLoaiTrangPhuc()
        {
            List<LoaiTrangPhuc> list = new List<LoaiTrangPhuc>();
            string query = "SELECT IDLoaiTrangPhuc, TenTrangPhuc AS 'Ten' FROM dbo.LoaiTrangPhuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LoaiTrangPhuc loaitrangPhuc = new LoaiTrangPhuc(item);
                list.Add(loaitrangPhuc);
            }
            return list;
        }

        public string LayThongTinTrangPhuc(string ThongTin, int IDTrangPhuc)
        {
            return (DataProvider.Instance.ExecuteScalar("SELECT " + ThongTin + " FROM dbo.LoaiTrangPhuc WHERE IDLoaiTrangPhuc = " + IDTrangPhuc)).ToString();
        }

        public string LayGiaTrangPhuc(string ThongTin, int IDTrangPhuc)
        {
            return (DataProvider.Instance.ExecuteScalar("SELECT " + ThongTin + " FROM GiaTrangPhuc WHERE IDLoaiTrangPhuc = " + IDTrangPhuc)).ToString();
        }

        public string LayThongTinLoaiVaiKichCo(string ThongTin, int IDTrangPhuc)
        {
            return (DataProvider.Instance.ExecuteScalar("SELECT " + ThongTin + " FROM GiaTrangPhuc a, LoaiTrangPhuc b, LoaiVai c WHERE a.IDLoaiTrangPhuc = b.IDLoaiTrangPhuc AND b.IDLoaiVai = c.IDLoaiVai AND a.IDLoaiTrangPhuc = " + IDTrangPhuc)).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DAO
{
    public class VaiDAO
    {
        private static VaiDAO instance;

        public static VaiDAO Instance
        {
            get { if (instance == null) instance = new VaiDAO(); return VaiDAO.instance; }
            private set { VaiDAO.instance = value; }
        }

        public VaiDAO() { }

        public void NhapVai(string IDNhanVien, string IDDaiLy, string NgayThanhToan, string IDLoaiVai, string IDKho, int SoLuong)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_ThemHoaDonMua @IDNhanVien , @IDDaiLyVai , @NgayThanhToan ", new object[] { IDNhanVien, IDDaiLy, NgayThanhToan });
            string ID = (DataProvider.Instance.ExecuteScalar("SELECT IDHoaDonMua FROM HoaDonMua WHERE IDNhanVien = " + IDNhanVien + " AND IDDaiLyVai = " + IDDaiLy + " AND NgayThanhToan = '" + NgayThanhToan + "'")).ToString();
            for (int i = 0; i < SoLuong; i++)
            {
                DataProvider.Instance.ExecuteNonQuery("USP_ThemVai @IDLoaiVai , @IDKho , @IDHoaDonMua ", new object[] { IDLoaiVai, IDKho, ID });
            }
        }

        public DataTable DanhSachChi()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDHoaDonMua AS 'ID',a.NgayThanhToan AS 'Ngay thanh toan',a.IDDaiLyVai AS 'ID dai ly vai',a.IDNhanVien AS 'ID nhan vien',SUM(c.Gia) AS 'So tien' FROM HoaDonMua a, Vai b, GiaVai c WHERE a.IDHoaDonMua = b.IDHoaDonMua AND b.IDLoaiVai = c.IDLoaiVai GROUP BY a.IDHoaDonMua, a.NgayThanhToan, a.IDDaiLyVai, a.IDNhanVien");
        }

        public DataTable DanhSachChiCoNgay(string Tu, string Den)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDHoaDonMua AS 'ID',a.NgayThanhToan AS 'Ngay thanh toan',a.IDDaiLyVai AS 'ID dai ly vai',a.IDNhanVien AS 'ID nhan vien',SUM(c.Gia) AS 'So tien' FROM HoaDonMua a, Vai b, GiaVai c WHERE (a.IDHoaDonMua = b.IDHoaDonMua AND b.IDLoaiVai = c.IDLoaiVai) AND (a.NgayThanhToan >= '"+Tu+"' AND a.NgayThanhToan <= '"+Den+"') GROUP BY a.IDHoaDonMua, a.NgayThanhToan, a.IDDaiLyVai, a.IDNhanVien");
        }

        public string TongTienChi(string Tu, string Den)
        {
            if (((DataProvider.Instance.ExecuteScalar("SELECT SUM(c.Gia) AS 'Gia' FROM dbo.Vai a, dbo.HoaDonMua b, dbo.GiaVai c WHERE (a.IDHoaDonMua = b.IDHoaDonMua AND c.IDLoaiVai = a.IDLoaiVai) AND (b.NgayThanhToan >= '" + Tu + "' AND b.NgayThanhToan <= '" + Den + "')")).ToString()) == null)
            {
                return "0";
            }
            else
            {
                return (DataProvider.Instance.ExecuteScalar("SELECT SUM(c.Gia) AS 'Gia' FROM dbo.Vai a, dbo.HoaDonMua b, dbo.GiaVai c WHERE (a.IDHoaDonMua = b.IDHoaDonMua AND c.IDLoaiVai = a.IDLoaiVai) AND (b.NgayThanhToan >= '" + Tu + "' AND b.NgayThanhToan <= '" + Den + "')")).ToString();
            }
        }
    }
}

    using QuanLyMayMac.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayMac.DAO
{
    public class MauVaiDAO
    {
        private static MauVaiDAO instance;

        public static MauVaiDAO Instance
        {
            get { if (instance == null) instance = new MauVaiDAO(); return MauVaiDAO.instance; }
            private set { MauVaiDAO.instance = value; }
        }

        private MauVaiDAO() { }

        public void ThemMauVai(string tenvai, string mau, int dai, int rong, string hinh, int gia)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_ThemMauVai @TenVai , @Mau , @Dai , @Rong , @Hinh ", new object[] { tenvai, mau, dai, rong, hinh });
            int id = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT IDLoaiVai FROM dbo.LoaiVai WHERE TenLoaiVai = '" + tenvai + "' AND MauChuDao = '" + mau + "' AND ChieuDai = " + dai + " AND ChieuRong = " + rong + " AND HinhAnhMau = '" + hinh + "'"));
            DataProvider.Instance.ExecuteNonQuery("USP_ThemGiaVai @Gia , @IDLoaiVai ", new object[] { gia, id });
        }

        public List<MauVai> DanhSachMauVai()
        {
            List<MauVai> list = new List<MauVai>();
            string query = "SELECT IDLoaiVai, TenLoaiVai as 'Ten' FROM dbo.LoaiVai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MauVai mauvai = new MauVai(item);
                list.Add(mauvai);
            }
            return list;
        }

        public DataTable LoadDanhSachVai()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT IDLoaiVai AS 'ID', TenLoaiVai AS 'Ten', MauChuDao AS 'Mau', ChieuDai AS 'Chieu dai', ChieuRong 'Chieu rong' FROM dbo.LoaiVai");
        }

        public DataTable XemDSVai(string TenVai)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT IDLoaiVai AS 'ID', TenLoaiVai AS 'Ten', MauChuDao AS 'Mau', ChieuDai AS 'Chieu dai', ChieuRong 'Chieu rong' FROM dbo.LoaiVai WHERE dbo.fuConvertToUnsign1(TenLoaiVai) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + TenVai + "') + '%'");
        }

        public int KiemTraLoaiVai(int iD, string bang)
        {
            int kt = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(IDLoaiVai) AS 'Dem' FROM " + bang + " WHERE IDLoaiVai = " + iD));
            return kt;
        }

        public void XoaMauVai(int id)
        {
                DataProvider.Instance.ExecuteNonQuery("USP_XoaMauVai @ID ", new object[] { id });
        }

        public void SuaMauVai(int iD, string ten, int dai, int rong, string mau, int gia)
        {
            int giaMoiNhat = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT Gia FROM GiaVai WHERE thoigian = (SELECT MAX(thoigian) FROM giavai WHERE idloaivai = " + iD + ") AND idloaivai = " + iD));
            if (gia == giaMoiNhat)
            {
                DataProvider.Instance.ExecuteNonQuery("USP_SuaMauVai @ID , @Ten , @Dai , @Rong , @Mau ", new object[] { iD, ten, dai, rong, mau });
            }
            else
            {
                DataProvider.Instance.ExecuteNonQuery("USP_SuaMauVai @ID , @Ten , @Dai , @Rong , @Mau ", new object[] { iD, ten, dai, rong, mau });
                DataProvider.Instance.ExecuteNonQuery("USP_ThemGiaVai @Gia , @IDLoaiVai ", new object[] { gia, iD });
            }
        }

        public DataTable LoadDSGiaVai()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDGiaVai AS 'ID', b.TenLoaiVai AS 'Ten vai', a.Gia, a.ThoiGian AS 'Ngay cap nhat' FROM dbo.GiaVai a, dbo.LoaiVai b WHERE a.IDLoaiVai = b.IDLoaiVai");
        }

        public DataTable XemDSGiaVai(string TenVai)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDGiaVai AS 'ID', b.TenLoaiVai AS 'Ten vai', a.Gia, a.ThoiGian AS 'Ngay cap nhat' FROM dbo.GiaVai a, dbo.LoaiVai b WHERE a.IDLoaiVai = b.IDLoaiVai AND dbo.fuConvertToUnsign1(b.TenLoaiVai) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + TenVai + "') + '%'");
        }

        public void XoaGiaVai(int ID)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_XoaGiaVai @ID ", new object[] { ID });
        }

        public void SuaGiaVai(int ID, int Gia, string ThoiGian, int IDLoaiVai)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_SuaGiaVai @ID , @Gia , @ThoiGian , @IDLoaiVai ", new object[] { ID, Gia, ThoiGian, IDLoaiVai });
        }

        public string LayThongTinLoaiVai(string ThongTin, int IDLoaiVai)
        {
            return (DataProvider.Instance.ExecuteScalar("SELECT " + ThongTin + "  FROM dbo.LoaiVai a,dbo.GiaVai b WHERE a.IDLoaiVai = b.IDLoaiVai AND a.IDLoaiVai = " + IDLoaiVai)).ToString();
        }

        public string LayDuongDanHinh(string ThongTin, int IDLoaiVai)
        {
            return (DataProvider.Instance.ExecuteScalar("SELECT " + ThongTin + " FROM dbo.LoaiVai WHERE IDLoaiVai = " + IDLoaiVai).ToString());
        }
    }
}

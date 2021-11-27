using QuanLyMayMac.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DAO
{
    public class DaiLyDAO
    {
        private static DaiLyDAO instance;

        public static DaiLyDAO Instance
        {
            get { if (instance == null) instance = new DaiLyDAO(); return DaiLyDAO.instance; }
            private set { DaiLyDAO.instance = value; }
        }

        private DaiLyDAO() { }

        public DataTable LoadDanhSachDaiLy()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT IDDaiLy AS 'ID', TenDaiLy AS 'Ten', SDT , DiaChi AS 'Dia chi' FROM dbo.DaiLy");
        }

        public DataTable XemDSDaiLy(string TenDaiLy)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT IDDaiLy AS 'ID', TenDaiLy AS 'Ten', SDT , DiaChi AS 'Dia chi' FROM dbo.DaiLy WHERE dbo.fuConvertToUnsign1(TenDaiLy) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + TenDaiLy + "') + '%'");
        }

        public void ThemDaiLy(string Ten, string SDT, string DiaChi)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_ThemDaiLy @Ten , @SDT , @DiaChi ", new object[] { Ten, SDT, DiaChi });
        }

        public void SuaDaiLy(int ID, string Ten, string SDT, string DiaChi)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_SuaDaiLy @ID , @Ten , @SDT , @DiaChi ", new object[] { ID, Ten, SDT, DiaChi });
        }

        public int KiemTraDaiLy(int iD, string bang)
        {
            int kt = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(IDDaiLyVai) AS 'Dem' FROM " + bang + " WHERE IDDaiLyVai = " + iD));
            return kt;
        }

        public void XoaDaiLy(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_XoaDaiLy @ID ", new object[] { id });
        }

        public List<DaiLy> DanhSachDaiLy()
        {
            List<DaiLy> list = new List<DaiLy>();
            string query = "SELECT IDDaiLy, TenDaiLy AS 'TenDaiLy' FROM dbo.DaiLy";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DaiLy daily = new DaiLy(item);
                list.Add(daily);
            }
            return list;
        }

        public string LayThongTinDaiLy(string ThongTin, int ID)
        {
            return (DataProvider.Instance.ExecuteScalar("SELECT " + ThongTin + " FROM dbo.DaiLy WHERE IDDaiLy = " + ID)).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DAO
{
    public class NgayNghiDAO
    {
        private static NgayNghiDAO instance;

        public static NgayNghiDAO Instance
        {
            get { if (instance == null) instance = new NgayNghiDAO(); return NgayNghiDAO.instance; }
            private set { NgayNghiDAO.instance = value; }
        }

        private NgayNghiDAO() { }

        private string IDNhanVien;
        private string TenNhanVien;

        public void LuuID(string id, string ten)
        {
            IDNhanVien = id;
            TenNhanVien = ten;
        }

        public string ID()
        {
            return IDNhanVien;
        }

        public string Ten()
        {
            return TenNhanVien;
        }

        public DataTable LoadDanhSachNgayNghi(string query)
        {
            return DataProvider.Instance.ExecuteQuery(query + IDNhanVien);
        }

        public void ThemNgayNghi(string ngay,int cophep)
        {
            DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_ThemNgayNghi @Ngay = '" + ngay + "' , @CoPhep = " + cophep + " , @ID = " + IDNhanVien);
        }

        public void XoaNgayNghi(string ngay)
        {
            DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_XoaNgayNghi @ngay = '" + ngay + "' , @id = " + IDNhanVien);
        }
    }
}

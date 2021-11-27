using QuanLyMayMac.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        private NhanVienDAO() { }

        #region Bien

        private int IDNhanVien;
        private int IDThemNV;

        #endregion

        public DataTable DanhSachNhanVien(string query)
        {
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<BoPhan> LocBoPhan()
        {
            List<BoPhan> list = new List<BoPhan>();
            string query = "SELECT BoPhan FROM dbo.NhanVien GROUP BY BoPhan ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BoPhan nhanvien = new BoPhan(item);
                list.Add(nhanvien);
            }
            return list;
        }

        public List<ToTruong> LocToTruong()
        {
            List<ToTruong> list = new List<ToTruong>();
            string query = "SELECT IDNhanVien, TenNhanVien FROM dbo.NhanVien WHERE IDNhanVien = IDToTruong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ToTruong nhanvien = new ToTruong(item);
                list.Add(nhanvien);
            }
            return list;
        }

        public List<QuanLy> LocQuanLy()
        {
            List<QuanLy> list = new List<QuanLy>();
            string query = "SELECT IDNhanVien, TenNhanVien FROM dbo.NhanVien WHERE IDNhanVien = IDQuanLy";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                QuanLy nhanvien = new QuanLy(item);
                list.Add(nhanvien);
            }
            return list;
        }

        public List<NhanVien> LoadDSNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "SELECT IDNhanVien, TenNhanVien FROM dbo.NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanvien = new NhanVien(item);
                list.Add(nhanvien);
            }
            return list;
        }

        public int ThemNhanVien(string ten,string cmnd, string sdt, string bophan, string ngay, string namsinh, string luong, string idtotruong)
        {
            if ((ten == "") || (cmnd == "") || (sdt == "") || (bophan == "") || (ngay == "") || (namsinh == "") || (luong == "") || (idtotruong == ""))
            {
                return 1;
            }
            else
            {
                int KiemTraCMND = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(CMND) FROM NhanVien WHERE CMND = '" + cmnd + "'"));
                int KiemTraSDT = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(SDT) FROM NhanVien WHERE SDT = '" + sdt + "'"));
                if ((KiemTraCMND > 0) || (KiemTraSDT > 0))
                {
                    return 2;
                }
                else
                {
                    int idquanly = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT IDQuanLy FROM dbo.NhanVien WHERE IDToTruong = " + idtotruong));
                    DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_ThemNhanVien @ten , @cmnd , @sdt , @bophan , @ngay , @namsinh , @luong , @idtotruong , @idquanly ", new object[] { ten, cmnd, sdt, bophan, ngay, namsinh, luong, idtotruong, idquanly });
                    return 0;
                }
            }
        }

        public void NhanID(int iD)
        {
            this.IDThemNV = iD;
        }

        public int TraID()
        {
            return this.IDThemNV;
        }

        public void ThemTaiKhoan(int iD, string taiKhoan, string matKhau)
        {
            string matKhauMaHoa = MaHoaMatKhau(matKhau);
            DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_ThemTaiKhoan @taikhoan = N'" + taiKhoan + "' , @matkhau = N'" + matKhauMaHoa + "' , @id = " + iD);
        }

        public void XoaNhanVien(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_XoaNhanVien @id", new object[] { id });
        }

        public void XoaTaiKhoan(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_XoaTaiKhoan @id", new object[] { id });
        }

        public void SuaThongTinNhanVien(int id, string ten, string cmnd, string sdt, string bophan, int idtotruong, int idquanly, int luong)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_SuaThongTinNhanVien @id , @ten , @cmnd , @sdt , @bophan , @luong , @totruong , @quanly ", new object[] { id, ten, cmnd, sdt, bophan, luong, idtotruong, idquanly });
        }

        public void ResetMatKhau(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_ResetMatKhau @id", new object[] { id });
        }

        public string MaHoaMatKhau(string matKhau)
        {
            byte[] maHoa1 = ASCIIEncoding.ASCII.GetBytes(matKhau);
            byte[] maHoa2 = new MD5CryptoServiceProvider().ComputeHash(maHoa1);
            string matKhauMaHoa = "";
            foreach (byte item in maHoa2)
            {
                matKhauMaHoa += item;
            }
            return matKhauMaHoa;
        }

        public string DangNhap(string taikhoan, string matkhau)
        {
            string matKhauMaHoa = MaHoaMatKhau(matkhau);
            IDNhanVien = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("EXEC dbo.USP_DangNhap @taikhoan = '" + taikhoan + "', @matkhau = '" + matKhauMaHoa + "'"));
            if (IDNhanVien > 0)
                return (DataProvider.Instance.ExecuteScalar("SELECT BoPhan FROM dbo.NhanVien WHERE IDNhanVien = " + IDNhanVien.ToString())).ToString();
            else
                return "0";
        }

        public int IDCaNhan()
        {
            return IDNhanVien;
        }

        public string ThongTinCaNhan(string thongtin,string bang)
        {
            return (DataProvider.Instance.ExecuteScalar("SELECT "+thongtin+" FROM dbo."+bang+" WHERE IDNhanVien = " + IDNhanVien)).ToString();
        }

        public void DoiMatKhau(int ID, string MatKhau)
        {
            string matKhauMaHoa = MaHoaMatKhau(MatKhau);
            DataProvider.Instance.ExecuteNonQuery("USP_DoiMatKhau @ID , @MatKhau ", new object[] { ID, matKhauMaHoa });
        }

        public string LayThongTinNhanVien(string ThongTin, int IDNhanVien)
        {
            return (DataProvider.Instance.ExecuteScalar("SELECT " + ThongTin + " FROM dbo.NhanVien WHERE IDNhanVien = " + IDNhanVien)).ToString();
        }

        public DataTable TimNhanVienTheoTen(string Ten)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT IDNhanVien AS 'ID',TenNhanVien AS 'Ten', CMND, SDT, BoPhan AS 'Bo phan', Luong, IDToTruong AS 'To truong',IDQuanLy AS 'Quan ly' FROM NhanVien WHERE dbo.fuConvertToUnsign1(TenNhanVien) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + Ten + "') + '%'");
        }

        public void SuaThongTinCaNhan(string CMND, string SDT, string IDNhanVien)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_SuaThongTinCaNhan @CMND , @SDT , @IDNhanVien ", new object[] { CMND, SDT, IDNhanVien });
        }
    }
}

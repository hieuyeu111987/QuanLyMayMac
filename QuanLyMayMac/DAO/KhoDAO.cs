using QuanLyMayMac.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DAO
{
    public class KhoDAO
    {
        private static KhoDAO instance;

        public static KhoDAO Instance
        {
            get { if (instance == null) instance = new KhoDAO(); return KhoDAO.instance; }
            private set { KhoDAO.instance = value; }
        }

        private KhoDAO() { }

        public DataTable DanhsachHangHoa(string query)
        {
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<Kho> LocKho()
        {
            List<Kho> list = new List<Kho>();
            string query = "SELECT a.TenKho FROM dbo.Kho a, dbo.Vai b, dbo.TrangPhuc c WHERE a.IDKho = b.IDKho AND a.IDKho = c.IDKho GROUP BY a.TenKho";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Kho kho = new Kho(item);
                list.Add(kho);
            }
            return list;
        }

        public List<LoaiVai> LocLoaiVai()
        {
            List<LoaiVai> list = new List<LoaiVai>();
            string query = "SELECT b.IDLoaiVai FROM dbo.Kho a, dbo.Vai b, dbo.TrangPhuc c WHERE a.IDKho = b.IDKho AND a.IDKho = c.IDKho GROUP BY b.IDLoaiVai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LoaiVai loaivai = new LoaiVai(item);
                list.Add(loaivai);
            }
            return list;
        }

        public List<LoaiTrangPhuc> LocLoaiTrangPhuc()
        {
            List<LoaiTrangPhuc> list = new List<LoaiTrangPhuc>();
            string query = "SELECT c.IDLoaiTrangPhuc FROM dbo.Kho a, dbo.Vai b, dbo.TrangPhuc c WHERE a.IDKho = b.IDKho AND a.IDKho = c.IDKho GROUP BY c.IDLoaiTrangPhuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LoaiTrangPhuc loaitrangphuc = new LoaiTrangPhuc(item);
                list.Add(loaitrangphuc);
            }
            return list;
        }

        public List<Kho> DanhSachKho()
        {
            List<Kho> list = new List<Kho>();
            string query = "SELECT IDKho , TenKho FROM Kho";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Kho kho = new Kho(item);
                list.Add(kho);
            }
            return list;
        }

        public void ThemKho(string ten, string trangThai)
        {
            int KhoDay = 0;
            if (trangThai == "Day")
            {
                KhoDay = 1;
            }
            else if (trangThai == "Rong")
            {
                KhoDay = 0;
            }
            else
            {
                return;
            }
            DataProvider.Instance.ExecuteNonQuery("USP_ThemKho @Ten , @KhoDay ", new object[] { ten, KhoDay });
        }

        public DataTable LoadDanhSachVai()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT b.IDLoaiVai AS 'ID',b.TenLoaiVai AS 'Ten vai',COUNT(a.IDVai) AS 'So luong' FROM dbo.Vai a, dbo.LoaiVai b WHERE a.IDLoaiVai = b.IDLoaiVai GROUP BY b.IDLoaiVai, b.TenLoaiVai");
        }

        public DataTable LoadDanhSachKhoVai(int ID)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDKho AS 'ID kho',a.TenKho AS 'Ten kho',COUNT(IDVai) AS 'So luong' FROM dbo.Kho a, dbo.Vai b WHERE a.IDKho = b.IDKho AND b.IDLoaiVai = " + ID + " GROUP BY a.IDKho, a.TenKho");
        }

        public DataTable LoadDanhSachTrangPhuc()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT b.IDLoaiTrangPhuc AS 'ID',b.TenTrangPhuc AS 'Ten trang phuc',COUNT(a.IDTrangPhuc) AS 'So luong' FROM dbo.TrangPhuc a, dbo.LoaiTrangPhuc b WHERE a.IDLoaiTrangPhuc = b.IDLoaiTrangPhuc GROUP BY b.IDLoaiTrangPhuc, b.TenTrangPhuc");
        }

        public DataTable LoadDanhSachKhoTrangPhuc(int ID)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDKho AS 'ID kho',a.TenKho AS 'Ten kho',COUNT(IDTrangPhuc) AS 'So luong' FROM dbo.Kho a, dbo.TrangPhuc b WHERE a.IDKho = b.IDKho AND b.IDLoaiTrangPhuc = " + ID + " GROUP BY a.IDKho, a.TenKho");
        }

        public int LayIDKhoTrangPhuc(int id)
        {
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT b.IDKho FROM dbo.TrangPhuc a, dbo.Kho b, dbo.LoaiTrangPhuc c WHERE a.IDKho = b.IDKho and a.IDLoaiTrangPhuc = c.IDLoaiTrangPhuc and c.IDLoaiTrangPhuc = " + id));
        }

        public int LayIDKhoVai(int id)
        {
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT b.IDKho FROM dbo.Vai a, dbo.Kho b, LoaiVai c WHERE a.IDKho = b.IDKho and a.IDLoaiVai = c.IDLoaiVai and c.IDLoaiVai = " + id));
        }

        public bool KhoDay(int IDKho)
        {
            string kho = (DataProvider.Instance.ExecuteScalar("SELECT KhoDay FROM dbo.Kho WHERE IDKho = " + IDKho)).ToString();
            if (kho == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SuaKho(int IDKho, string TenKho, int KhoDay)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_SuaKho @ID , @Ten , @KhoDay ", new object[] { IDKho, TenKho, KhoDay });
        }

        public string LayThongTinKho(string ThongTin, int IDKho)
        {
            return (DataProvider.Instance.ExecuteScalar("SELECT " + ThongTin + " FROM dbo.Kho WHERE IDKho = " + IDKho)).ToString();
        }
    }
}

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
    public class MauTrangPhucDAO
    {
        private static MauTrangPhucDAO instance;

        public static MauTrangPhucDAO Instance
        {
            get { if (instance == null) instance = new MauTrangPhucDAO(); return MauTrangPhucDAO.instance; }
            private set { MauTrangPhucDAO.instance = value; }
        }

        private MauTrangPhucDAO() { }

        public void ThemMauTrangPhuc(string ten, int ao, string kichco, string hinh, int loaivai, int gia)
        {
            DataProvider.Instance.ExecuteNonQuery("ThemLoaiTrangPhuc @Ten , @Ao , @KichCo , @Hinh , @IDLoaiVai ", new object[] { ten, ao, kichco, hinh, loaivai });
            int id = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT IDLoaiTrangPhuc FROM dbo.LoaiTrangPhuc WHERE TenTrangPhuc = '" + ten + "' AND Ao = '" + ao + "' AND KichCo = '" + kichco + "' AND HinhAnhMau = '" + hinh + "' AND IDLoaiVai = " + loaivai));
            DataProvider.Instance.ExecuteNonQuery("USP_ThemGiaTrangPhuc @Gia , @LoaiTrangPhuc ", new object[] { gia, id });
        }

        public DataTable LoadDanhSachTrangPhuc()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDLoaiTrangPhuc as 'ID', a.TenTrangPhuc 'Ten', a.Ao as 'Ao', a.KichCo as 'Kich co', b.TenLoaiVai as 'Loai vai' FROM LoaiTrangPhuc a, LoaiVai b WHERE a.IDLoaiVai = b.IDLoaiVai");
        }

        public DataTable XemDSTrangPhuc(string TenTrangPhuc)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDLoaiTrangPhuc as 'ID', a.TenTrangPhuc 'Ten', a.Ao as 'Ao', a.KichCo as 'Kich co', b.TenLoaiVai as 'Loai vai' FROM LoaiTrangPhuc a, LoaiVai b WHERE a.IDLoaiVai = b.IDLoaiVai AND dbo.fuConvertToUnsign1(a.TenTrangPhuc) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + TenTrangPhuc + "') + '%'");
        }

        public DataTable XemDSGiaTrangPhuc(string TenTrangPhuc)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDGia AS 'ID', b.TenTrangphuc AS 'Ten trang phuc', a.Gia, a.NgayApDung AS 'Ngay cap nhat' FROM dbo.GiaTrangPhuc a, dbo.LoaiTrangPhuc b WHERE a.IDLoaiTrangPhuc = b.IDLoaiTrangPhuc AND dbo.fuConvertToUnsign1(b.TenTrangPhuc) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + TenTrangPhuc + "') + '%'");
        }

        public void SuaTrangPhuc(int iD, string ten, int iDLoaiVai, int loaiAo, string kichCo, int gia)
        {
            int giaMoiNhat = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT Gia FROM GiaTrangPhuc WHERE NgayApDung = (SELECT MAX(NgayApDung) FROM GiaTrangPhuc WHERE IDLoaiTrangPhuc = " + iD + ") AND IDLoaiTrangPhuc = " + iD));
            if (gia == giaMoiNhat)
            {
                DataProvider.Instance.ExecuteNonQuery("USP_SuaMauTrabgPhuc @ID , @Ten , @IDLoaiVai , @LoaiAo , @KichCo ", new object[] { iD, ten, iDLoaiVai, loaiAo, kichCo });
            }
            else
            {
                DataProvider.Instance.ExecuteNonQuery("USP_SuaMauTrabgPhuc @ID , @Ten , @IDLoaiVai , @LoaiAo , @KichCo ", new object[] { iD, ten, iDLoaiVai, loaiAo, kichCo });
                DataProvider.Instance.ExecuteNonQuery("USP_ThemGiaTrangPhuc @Gia , @LoaiTrangPhuc ", new object[] { gia, iD });
            }
        }

        public int KiemTraLoaiTrangPhuc(int iD, string bang)
        {
            int kt = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT COUNT(IDLoaiTrangPhuc) AS 'Dem' FROM " + bang + " WHERE IDLoaiTrangPhuc = " + iD));
            return kt;
        }

        public void XoaMauVai(int id)
        {
            if (KiemTraLoaiTrangPhuc(id, "TrangPhuc") > 0)
            {
                MessageBox.Show("Mau nay con trong kho!", "Thong bao");
            }
            else if (KiemTraLoaiTrangPhuc(id, "GiaTrangPhuc") > 0)
            {
                MessageBox.Show("Mau nay con trong bang gia!", "Thong bao");
            }
            else
            {
                DataProvider.Instance.ExecuteNonQuery("USP_XoaMauTrangPhuc @ID ", new object[] { id });
            }
        }

        public DataTable LocTrangPhuc(string Ao, string size)
        {
            if ((Ao == "Tat ca") && (size == "Tat ca"))
            {
                return DataProvider.Instance.ExecuteQuery("SELECT a.IDloaitrangphuc as 'ID',a.tentrangphuc 'Ten',a.ao as 'Ao',a.kichco as 'Kich co',b.tenloaivai as 'Loai vai',c.gia as 'Gia' FROM LOAITRANGPHUC a,loaivai b ,giatrangphuc c WHERE a.idloaivai = b.idloaivai and a.idloaitrangphuc = c.idloaitrangphuc");
            }
            else if ((Ao != "Tat ca") && (size == "Tat ca"))
            {
                int a = 0;
                if (Ao == "Ao")
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
                return DataProvider.Instance.ExecuteQuery("SELECT a.IDloaitrangphuc as 'ID',a.tentrangphuc 'Ten',a.ao as 'Ao',a.kichco as 'Kich co',b.tenloaivai as 'Loai vai',c.gia as 'Gia' FROM LOAITRANGPHUC a,loaivai b ,giatrangphuc c where a.idloaivai = b.idloaivai and a.idloaitrangphuc = c.idloaitrangphuc AND Ao = " + a);
            }
            else if ((Ao == "Tat ca") && (size != "Tat ca"))
            {
                return DataProvider.Instance.ExecuteQuery("SELECT a.IDloaitrangphuc as 'ID',a.tentrangphuc 'Ten',a.ao as 'Ao',a.kichco as 'Kich co',b.tenloaivai as 'Loai vai',c.gia as 'Gia' FROM LOAITRANGPHUC a,loaivai b ,giatrangphuc c where a.idloaivai = b.idloaivai and a.idloaitrangphuc = c.idloaitrangphuc AND kichco = '" + size + "'");
            }
            else
            {
                int a = 0;
                if (Ao == "Ao")
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
                return DataProvider.Instance.ExecuteQuery("SELECT a.IDloaitrangphuc as 'ID',a.tentrangphuc 'Ten',a.ao as 'Ao',a.kichco as 'Kich co',b.tenloaivai as 'Loai vai',c.gia as 'Gia' FROM LOAITRANGPHUC a,loaivai b ,giatrangphuc c where a.idloaivai = b.idloaivai and a.idloaitrangphuc = c.idloaitrangphuc AND Ao = " + a + " and kichco = '" + size + "'");
            }
        }

        public List<LoaiTrangPhuc> DSLoaiTrangPhuc()
        {
            List<LoaiTrangPhuc> list = new List<LoaiTrangPhuc>();
            string query = "SELECT IDLoaiTrangPhuc, TenTrangPhuc AS 'Ten' FROM dbo.LoaiTrangPhuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LoaiTrangPhuc loaitrangphuc = new LoaiTrangPhuc(item);
                list.Add(loaitrangphuc);
            }
            return list;
        }

        public DataTable LoadDSGiaTrangPhuc()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.IDGia AS 'ID', b.TenTrangphuc AS 'Ten trang phuc', a.Gia, a.NgayApDung AS 'Ngay cap nhat' FROM dbo.GiaTrangPhuc a, dbo.LoaiTrangPhuc b WHERE a.IDLoaiTrangPhuc = b.IDLoaiTrangPhuc");
        }

        public void XoaGiaTrangPhuc(int ID)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_XoaGiaTrangPhuc @ID ", new object[] { ID });
        }

        public void SuaGiaTrangPhuc(int ID, int Gia, string ThoiGian, int IDLoaiTrangPhuc)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_SuaGiaTrangPhuc @ID , @Gia , @ThoiGian , @IDLoaiTrangPhuc ", new object[] { ID, Gia, ThoiGian, IDLoaiTrangPhuc });
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DTO
{
    public class NhanVien
    {
        public NhanVien(int idnhanvien, string tennhanvien)
        {
            this.IDNhanVien = idnhanvien;
            this.TenNhanVien = tennhanvien;
        }

        public NhanVien(DataRow row)
        {
            this.IDNhanVien = (int)row["idnhanvien"];
            this.TenNhanVien = row["tennhanvien"].ToString();
        }

        private int iDNhanVien;
        private string tenNhanVien;

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        public int IDNhanVien
        {
            get { return iDNhanVien; }
            set { iDNhanVien = value; }
        }
    }
}

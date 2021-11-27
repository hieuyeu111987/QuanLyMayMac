using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DTO
{
    public class KhachHang
    {
        private int iD;
        private string ten;

        public KhachHang(int id, string ten)
        {
            this.ID = id;
            this.Ten = ten;
        }

        public KhachHang(DataRow row)
        {
            this.ID = (int)row["IDKhachHang"];
            this.Ten = row["Ten"].ToString();
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}

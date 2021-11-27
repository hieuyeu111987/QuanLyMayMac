using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DTO
{
    public class LoaiTrangPhuc
    {
        private int iD;
        private string ten;

        public LoaiTrangPhuc(int id,string ten)
        {
            this.ID = id;
            this.Ten = ten;
        }

        public LoaiTrangPhuc(DataRow row)
        {
            this.ID = (int)row["IDLoaiTrangPhuc"];
            this.Ten = row["Ten"].ToString();
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
    }
}

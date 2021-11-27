using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DTO
{
    public class MauVai
    {
        private int iD;
        private string ten;

        public MauVai(int id, string ten)
        {
            this.ID = id;
            this.Ten = ten;
        }

        public MauVai(DataRow row)
        {
            this.ID = (int)row["IDLoaiVai"];
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DTO
{
    public class LoaiVai
    {
        private int iD;

        public LoaiVai(int id)
        {
            this.ID = id;
        }

        public LoaiVai(DataRow row)
        {
            this.ID = (int)row["IDLoaiVai"];
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DTO
{
    public class DaiLy
    {
        private int iDDaiLy;
        private string tenDaiLy;

        public DaiLy(int ID, string Ten)
        {
            this.IDDaiLy = ID;
            this.TenDaiLy = Ten;
        }

        public DaiLy(DataRow row)
        {
            this.IDDaiLy = (int)row["IDDaiLy"];
            this.TenDaiLy = row["tendaily"].ToString();
        }

        public string TenDaiLy
        {
            get { return tenDaiLy; }
            set { tenDaiLy = value; }
        }

        public int IDDaiLy
        {
            get { return iDDaiLy; }
            set { iDDaiLy = value; }
        }
    }
}

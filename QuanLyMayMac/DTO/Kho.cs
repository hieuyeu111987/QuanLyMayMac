using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DTO
{
    public class Kho
    {
        private int iDKho;
        private string tenKho;

        public Kho(int idkho, string tenkho)
        {
            this.IDKho = idkho;
            this.TenKho = tenkho;
        }

        public Kho(DataRow row)
        {
            this.IDKho = (int)row["IDKho"];
            this.TenKho = row["TenKho"].ToString();
        }

        public string TenKho
        {
            get { return tenKho; }
            set { tenKho = value; }
        }

        public int IDKho
        {
            get { return iDKho; }
            set { iDKho = value; }
        }
    }
}

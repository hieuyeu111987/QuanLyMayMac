using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayMac.DTO
{
    public class BoPhan
    {
        public BoPhan(string bophan)
        {
            this.Bophan = bophan;
        }

        public BoPhan(DataRow row)
        {
            this.Bophan = row["bophan"].ToString();
        }

        private string bophan;

        public string Bophan
        {
            get { return bophan; }
            set { bophan = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19_opp
{
    internal class SinhVien
    {
        private int ma;
        private string ten;

        public SinhVien(int ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }


        #region properties
        public int Ma
        {
            get { return ma; }
            set { ma = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        #endregion


        public override String ToString()
        {
            return this.ma + "-" + this.ten;
        }
    }
}

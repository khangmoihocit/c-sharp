using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai20_kethua
{
    internal class HinhChuNhat
    {
        private int a {  get; set; }
        private int b {  get; set; }

        public HinhChuNhat(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public virtual int dienTich()
        {
            return a * b;
        }

        public virtual int chuVi()
        {
            return (a + b) * 2;
        }
    }
}

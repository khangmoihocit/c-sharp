using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai20_kethua
{
    internal class HinhVuong : HinhChuNhat
    {
        public HinhVuong(int a) : base(a, a) { }

        public override int dienTich()
        {
            return base.dienTich();
        }

        public override int chuVi()
        {
            return base.chuVi();
        }

    }
}

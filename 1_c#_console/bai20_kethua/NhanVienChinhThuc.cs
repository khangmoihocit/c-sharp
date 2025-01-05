using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai20_kethua
{
    internal class NhanVienChinhThuc:NhanVien
    {

        public NhanVienChinhThuc(int ma, string ten):base(ma, ten)
        {

        }

        public new void tinhLuong()
        {
            base.tinhLuong();
        }

        public override double tinhLuong(int ngayCong)
        {
            if(ngayCong == 20)
            {
                return 10000000;
            }
            return base.tinhLuong(ngayCong);
        }
    }
}

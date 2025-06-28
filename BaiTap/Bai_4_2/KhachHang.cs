using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4_2
{
    internal class KhachHang
    {
        public string HoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string TenCoQuan { get; set; }

        public KhachHang() { }

        public override string ToString()
        {
            return this.HoTen;
        }
    }
}

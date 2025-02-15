using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai37_ListView
{
    internal class SanPham
    {
        public string Ma {  get; set; }
        public string Ten {  get; set; }
        public int Gia { get; set; }
        public DanhMuc danhMuc { get; set; }

        public SanPham(string ma, string ten, int gia)
        {
            Ma = ma;
            Ten = ten;
            Gia = gia;

        }

        public SanPham() { }
        
    }
}

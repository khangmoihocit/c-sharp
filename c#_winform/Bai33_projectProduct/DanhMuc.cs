using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai33_projectProduct
{
    public class DanhMuc
    {
        private Dictionary<string, SanPham> danhSachSanPham = new Dictionary<string, SanPham>();
        public string MaDM { get; set; }
        public string TenDM { get; set; }

        public void ThemSanPham(SanPham sanPham){
            if(!this.danhSachSanPham.ContainsKey(sanPham.MaSP))
                this.danhSachSanPham.Add(sanPham.MaSP, sanPham);
        }

        public Dictionary<string, SanPham> SanPhams
        {
            get { return this.danhSachSanPham; }
            set { this.danhSachSanPham = value; }
        }

        public override string ToString() => this.TenDM;
    }
}

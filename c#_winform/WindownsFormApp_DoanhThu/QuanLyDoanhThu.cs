using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindownsFormApp_DoanhThu
{
    public class QuanLyDoanhThu
    {
        private string _tenCLB;
        private string _tenNuoc;
        private int _soLuongVe;
        private double _giaVe;

        public QuanLyDoanhThu() { }

        public QuanLyDoanhThu(string tenCLB, string tenNuoc, int soLuongVe, double giaVe)
        {
            _tenCLB = tenCLB;
            _tenNuoc = tenNuoc;
            _soLuongVe = soLuongVe;
            _giaVe = giaVe;
        }

        public string TenCLB { get => _tenCLB; set => _tenCLB = value; }
        public string TenNuoc { get => _tenNuoc; set => _tenNuoc = value; }
        public int SoLuongVe { get => _soLuongVe; set => _soLuongVe = value; }
        public double GiaVe { get => _giaVe; set => _giaVe = value; }

        public double DoanhThu() => _giaVe * _soLuongVe;
    }
}

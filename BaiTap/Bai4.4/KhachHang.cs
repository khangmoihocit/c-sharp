using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4._4
{
    public class KhachHang
    {
        private int _maKH;
        private string _tenKH;
        private string _diaChi;
        private string _soDienThoai;
        private int _gioiTinh;
        private DateTime _ngaySinh;
        private string _tenCoQuan;

        public KhachHang()
        {
        }

        public KhachHang( string tenKH, string diaChi, string soDienThoai, int gioiTinh, DateTime ngaySinh, string tenCoQuan)
        {
          
            _tenKH = tenKH;
            _diaChi = diaChi;
            _soDienThoai = soDienThoai;
            _gioiTinh = gioiTinh;
            _ngaySinh = ngaySinh;
            _tenCoQuan = tenCoQuan;
        }

        public int MaKH { get => _maKH; set => _maKH = value; }
        public string TenKH { get => _tenKH; set => _tenKH = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string SoDienThoai { get => _soDienThoai; set => _soDienThoai = value; }
        public int GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string TenCoQuan { get => _tenCoQuan; set => _tenCoQuan = value; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

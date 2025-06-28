using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_report
{
    public class HoaDon
    {
        private int _maHoaDon;
        private int _maKhachHang;
        private DateTime _ngayLap;
        private DateTime _ngayGiaoHang;
        private string _tenNguoiNhan;
        private string _diaChiGiaoHang;
        private string _dienThoaiNguoiNhan;
        private string _trangThaiThanhToan;
        private string _nguoiLapHoaDon;
        private float _tiLeGiamGia;

        public HoaDon() { }

        public HoaDon(int maHoaDon, int maKhachHang, DateTime ngayLap, DateTime ngayGiaoHang, string tenNguoiNhan, string diaChiGiaoHang, string dienThoaiNguoiNhan, string trangThaiThanhToan, string nguoiLapHoaDon, float tiLeGiamGia)
        {
            MaHoaDon = maHoaDon;
            MaKhachHang = maKhachHang;
            NgayLap = ngayLap;
            NgayGiaoHang = ngayGiaoHang;
            TenNguoiNhan = tenNguoiNhan;
            DiaChiGiaoHang = diaChiGiaoHang;
            DienThoaiNguoiNhan = dienThoaiNguoiNhan;
            TrangThaiThanhToan = trangThaiThanhToan;
            NguoiLapHoaDon = nguoiLapHoaDon;
            TiLeGiamGia = tiLeGiamGia;
        }

        public int MaHoaDon { get => _maHoaDon; set => _maHoaDon = value; }
        public int MaKhachHang { get => _maKhachHang; set => _maKhachHang = value; }
        public DateTime NgayLap { get => _ngayLap; set => _ngayLap = value; }
        public DateTime NgayGiaoHang { get => _ngayGiaoHang; set => _ngayGiaoHang = value; }
        public string TenNguoiNhan { get => _tenNguoiNhan; set => _tenNguoiNhan = value; }
        public string DiaChiGiaoHang { get => _diaChiGiaoHang; set => _diaChiGiaoHang = value; }
        public string DienThoaiNguoiNhan { get => _dienThoaiNguoiNhan; set => _dienThoaiNguoiNhan = value; }
        public string TrangThaiThanhToan { get => _trangThaiThanhToan; set => _trangThaiThanhToan = value; }
        public string NguoiLapHoaDon { get => _nguoiLapHoaDon; set => _nguoiLapHoaDon = value; }
        public float TiLeGiamGia { get => _tiLeGiamGia; set => _tiLeGiamGia = value; }
    }
}

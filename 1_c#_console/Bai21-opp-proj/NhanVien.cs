using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21_opp_proj
{
    internal class NhanVien
    {
        public const long LUONG_CO_BAN = 10000000;
        public int maNhanVien {  get; set; }
        public string tenNhanVien { get; set; }
        public DateTime ngaySinh { get; set; }
        public LoaiChucVu chucVu { get; set; }
        public PhongBan phongBan { get; set; }
        public long tinhLuong
        {
            get
            {
                if (chucVu == LoaiChucVu.GIAM_DOC)
                    return LUONG_CO_BAN + (long)(LUONG_CO_BAN * 0.25);
                else if (chucVu == LoaiChucVu.TRUONG_PHONG)
                    return LUONG_CO_BAN + (long)(LUONG_CO_BAN * 0.15);
                else if (chucVu == LoaiChucVu.PHO_PHONG)
                    return LUONG_CO_BAN + (long)(LUONG_CO_BAN * 0.05);
                else 
                    return LUONG_CO_BAN;
            }
        }




        public NhanVien() { }

        public NhanVien(int maNhanVien, string tenNhanVien, DateTime ngaySinh, LoaiChucVu chucVu)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.ngaySinh = ngaySinh;
            this.chucVu = chucVu;
        }

        public override string ToString()
        {
            return this.maNhanVien + "\t" + this.tenNhanVien + "\t" + this.chucVu + "\t" + this.tinhLuong;
        }




    }
}

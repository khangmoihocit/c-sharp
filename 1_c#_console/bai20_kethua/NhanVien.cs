using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai20_kethua
{
    internal class NhanVien
    {
        private int ma { get; set; }
        private string ten { get; set; }


        public NhanVien(int ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }

        public void tinhLuong()
        {
            Console.WriteLine("day la luong cu nhan vien");
        }
        public virtual double tinhLuong(int ngayCong)
        {
            return ngayCong * 100;
        }
    }
}

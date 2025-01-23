using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21_opp_proj
{
    internal class PhongBan
    {

        private List<NhanVien> listNhanVien = new List<NhanVien>();
        public int maPhongBan {  get; set; }
        public string tenPhongBan { get; set; }
        public NhanVien truongPhong {  get; set; }


        private int compareTo(NhanVien nv1, NhanVien nv2)
        {
            if ((string.Compare(nv1.tenNhanVien, nv2.tenNhanVien) == 0))
            {
                if (nv1.maNhanVien < nv2.maNhanVien)
                    return 1;
                else if (nv1.maNhanVien < nv2.maNhanVien)
                    return -1;
                else
                    return 0;
            }
            return string.Compare(nv1.tenNhanVien, nv2.tenNhanVien);
        }

        public void sortNhanVienByName()
        {
            listNhanVien.Sort(compareTo);
        }


        public PhongBan() { }
        public PhongBan(int maPhongBan, string tenPhongBan)
        {
            this.maPhongBan = maPhongBan;
            this.tenPhongBan = tenPhongBan;
        }

        public bool addNhanVien(NhanVien nhanVien)
        {
            foreach(NhanVien nv in listNhanVien)
            {
                if (nhanVien.maNhanVien == nv.maNhanVien)
                    return false;
            }
            listNhanVien.Add(nhanVien);
            nhanVien.phongBan = this;
            return true;
        }

        public void printListNhanVien()
        {
            foreach(NhanVien nv in listNhanVien)
            {
                Console.WriteLine(nv);
            }
        }

        
    }
}

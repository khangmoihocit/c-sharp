using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._4
{
    internal class HangHoa
    {
        public int idHangHoa { get; set; }
        public string tenHangHoa { get; set; }
        public string dacDiem { get; set; }
        public string xuatXu { get; set; }
        public float giaNiemYet { get; set; }
        public HangHoa() { }

        public void inputHangHoa()
        {
            Console.WriteLine("nhap ten hang: ");
            this.tenHangHoa = Console.ReadLine();
            Console.WriteLine("nhap gia niem yet: ");
            this.giaNiemYet = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap dac diem: ");
            this.dacDiem = Console.ReadLine();
            Console.WriteLine("nhap xuat xu: ");
            this.xuatXu = Console.ReadLine();
        }

        public HangHoa(string tenHangHoa, string dacDiem, string xuatXu, float giaNiemYet)
        {
            this.tenHangHoa = tenHangHoa;
            this.dacDiem = dacDiem;
            this.xuatXu = xuatXu;
            this.giaNiemYet = giaNiemYet;
        }

        

    }
}

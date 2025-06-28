using System.Linq;
using System.Threading.Channels;


internal class Program
{


    //Anonymous - kiểu dữ liệu vô danh
    //Oject - thuoc tnh - chi doc
    // new {thuoctinh = giatri1, thuoctinh2 = giatri2}

    // dynamic - kiểu dữ liệu động: thoải mải truy cập phương thức, thuộc tính mà không cần xác định
    
    public static void Dynamic()
    {
        SinhVien sv = new SinhVien();
        PrintInf(sv);
    }

    public static void PrintInf(dynamic obj)
    {
        obj.HoTen = "Pham Van Khang";
        obj.Hello();
    }

    class SinhVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string NoiSinh { get; set; }

        public void Hello() => Console.WriteLine(this.HoTen);
    }

    private static void Main(string[] args)
    {
        List<SinhVien> listSinhVien = new List<SinhVien>()
        {
            new SinhVien(){HoTen = "Nam", NamSinh = 2003, NoiSinh = "HaNoi"},
            new SinhVien(){HoTen = "Dung", NamSinh = 2004, NoiSinh = "BacGiang"},
            new SinhVien(){HoTen = "Khanh", NamSinh = 2006, NoiSinh = "VinhPhuc"},
            new SinhVien(){HoTen = "Tai", NamSinh = 2005, NoiSinh = "NamDinh"}
        };

        var result = from sv in listSinhVien
                         //where sv.NoiSinh == "Hanoi"
                     where sv.HoTen.Contains("a")
                     select new
                     {
                         Ten = sv.HoTen,
                         NS = sv.NamSinh
                     };

        //foreach (var sinhvien in result)
        //{
        //    Console.WriteLine(sinhvien.Ten + " - " + sinhvien.NS);
        //}

        Dynamic();





        //var sanPham = new
        //{
        //    Ten = "Iphone 8",
        //    Gia = 1000,
        //    NamSx = 2018
        //};

        //Console.WriteLine(sanPham.Ten.GetType());
        //Console.WriteLine(sanPham.Gia.GetType());


        //lỗi, kiểu vô danh chỉ đọc
        //sanPham.Ten = "kha";
    }
}
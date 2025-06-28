using Bai21_opp_proj;

internal class Program
{

    static void TestQLNV()
    {
        PhongBan pb1 = new PhongBan(1001, "phong ban 1");
        PhongBan pb2 = new PhongBan(1002, "phong ban 2");

        NhanVien nv1 = new NhanVien(301, "b", DateTime.Parse("2005/02/12"), LoaiChucVu.NHAN_VIEN);
        NhanVien nv2 = new NhanVien(302, "d", DateTime.Parse("2005/02/12"), LoaiChucVu.TRUONG_PHONG);
        NhanVien nv3 = new NhanVien(303, " a", DateTime.Parse("2005/02/12"), LoaiChucVu.GIAM_DOC);
        NhanVien nv4 = new NhanVien(304, "n", DateTime.Parse("2005/02/12"), LoaiChucVu.NHAN_VIEN);
        NhanVien nv5 = new NhanVien(305, "c", DateTime.Parse("2005/02/12"), LoaiChucVu.NHAN_VIEN);

        pb1.addNhanVien(nv1);
        pb1.addNhanVien(nv2);
        pb1.addNhanVien(nv3);
        pb1.addNhanVien(nv4);
        pb1.addNhanVien(nv5);

       

        pb1.printListNhanVien();
        Console.WriteLine("ds nv sort la: ");
        pb1.sortNhanVienByName();
        pb1.printListNhanVien();

    }


    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TestQLNV();
    }
}
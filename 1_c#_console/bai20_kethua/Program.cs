using System.Data.SqlClient;
using bai20_kethua;

internal class Program
{
    static void testHinhCN()
    {
        HinhChuNhat h1 = new HinhChuNhat(2, 3);
        HinhChuNhat h2 = new HinhVuong(7);
        Console.WriteLine(h1.dienTich());
        Console.WriteLine(h2.dienTich());

    }

    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //SqlConnection conn = new SqlConnection();
        testHinhCN();

        Console.ReadLine();
    }
}
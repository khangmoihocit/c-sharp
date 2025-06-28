
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int soLuong = 10;
        string name = "khangpham";
        long price = 0;

        //sửa lỗi không hiện dấu
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("số lượng = {0}", soLuong);
        //Console.WriteLine(soLuong);

        //sua dau enter
        //Console.ReadLine();



        //ep kieu ket qua phep chia sang double
        double a = (double)1 / 2; //hoac double a = 1.0/2
        Console.WriteLine("{0} / {1} = {2}", 1, 2, a);

        

        //
        var t = 5;
        Console.WriteLine("kieu du lieu cua t = {0}", t.GetType().ToString());
        Console.WriteLine("hello word");

        //khai bao hang so
        const double PI = 3.14;

        
    }
}
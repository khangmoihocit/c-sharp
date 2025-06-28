internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //thu vien nhap xuat console
        //chuyen kieu du lieu (parse)
        //toan hoc(math)
        //ngau nhien(random)
        //ngay thang(datetime)

        //2 cach chuyen doi du lieu
        //int a = int.Parse(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());

        int n = 9;
        //cac ham toan hoc
        Console.WriteLine(Math.PI);
        Console.WriteLine(Math.Sqrt(n));
        Console.WriteLine(Math.Pow(n, 2));
        Console.WriteLine(Math.Max(4, 5));
        Console.WriteLine(Math.Abs(-10));
        Console.WriteLine(Math.Sin((2*Math.PI)/3));
        //lam tron den so thap phan thu 2
        Console.WriteLine(Math.Round(3.247, 2));
        //int c = a + b;
        //Console.WriteLine(c);



        //cac ham random
        Random rd = new Random();
        int x = rd.Next(3, 18);
        Console.WriteLine(x);



        //ngay thang
        DateTime birthDate = new DateTime(2005, 02, 18);
        Console.WriteLine(birthDate.ToString("dd/MM/yyyy"));

        Console.WriteLine(birthDate.Day);
        Console.WriteLine(birthDate.Month);
        Console.WriteLine(birthDate.Year);





        Console.ReadLine();
    }
}
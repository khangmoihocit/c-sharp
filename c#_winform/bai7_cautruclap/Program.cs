internal class Program
{


    static int tinhGiaiThua()
    {
        //tinh giai thua
        int result = 1;
        Console.Write("moi ban nhap so: ");
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        do
        {
            result *= i;
            ++i;

        } while (i <= n);
        return result;
    }

    static void tinhGiaiThua2()
    {
        int n;
        Console.Write("nhap so can tinh giai thua: ");
        n = int.Parse(Console.ReadLine());
        int sum = 1;
        for(int i = 1; i <= n; ++i)
        {
            sum *= i;
        }
        Console.WriteLine("ke qua " + n + "! = " + sum);
    }



    private static void Main(string[] args)
    {
        Console.WriteLine("hello world");

        //Console.WriteLine("ket qua phep tinh la: " + tinhGiaiThua());
        tinhGiaiThua2();

        Console.ReadLine();
    }
}
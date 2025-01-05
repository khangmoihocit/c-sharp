internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("nhap a = ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap b = ");
        b = int.Parse(Console.ReadLine());

        if(a == 0 && b != 0) Console.WriteLine("phuong trinh vo nghiem.");
        if(a == 0 && b == 0) Console.WriteLine("phuong trinh co vo so nghiem.");
        float res = 0;
        if (a != 0)
        {
            res = (float)-b / a;
            Console.WriteLine("nghiem cua phuong trinh la: " + res);
        }
    }
}
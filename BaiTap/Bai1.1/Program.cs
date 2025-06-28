using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("nhap a = ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap b = ");
        b = int.Parse(Console.ReadLine());

        //so lon nhat
        if(a > b) Console.WriteLine("so lon nhat: " + a);
        else Console.WriteLine("so lon nhat: " + b);

        //trung binh cong
        float avg = (a + b) / (float)2;
        Console.WriteLine("trung binh cong " + a + " va " + b + " la: " + avg);


    }
}
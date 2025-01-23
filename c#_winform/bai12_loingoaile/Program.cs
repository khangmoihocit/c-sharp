using System.Linq.Expressions;

internal class Program
{

    static void test()
    {
        int a = 10;
        Console.WriteLine("nhap mau so: ");
        int b = int.Parse(Console.ReadLine());

        //neu mau = 0, thi nem loi ra cho khac
        if(b == 0) throw new ArithmeticException("loi mau so = 0");
        int c = a / b;
        Console.WriteLine(c);
        
    }


    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //cac loi thuong gap:
        //- loi bien dich
        // - loi runtime exception
        // - loi logic exception
        try
        {
            Console.WriteLine("nhap ngay thang nam sinh: ");
            string s = Console.ReadLine();
            DateTime dateTime = DateTime.Parse(s);
            Console.WriteLine("s vua nhap: " + dateTime.ToString("dd/MM/yyyy"));
        }
        catch (Exception ex) { 
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("loi hay k loi");
        }

        try
        {
            test();
        }
        catch (ArithmeticException ex) {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();

    }
}
using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Hiện tổng 2 số nguyên
        int a, b;
        Console.WriteLine("Nhập hai số nguyên: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Tổng hai số đó là: {0}", a + b);
        //Hiện tích 3 số nguyên
        int c, d, e;
        Console.WriteLine("Nhập ba số nguyên: ");
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        e = int.Parse(Console.ReadLine());
        Console.WriteLine("Tích ba số đó là: {0}", c * d * e);
        //Nhập xâu và đếm
        Console.WriteLine("Nhập một xâu văn bản: ");
        var str = Console.ReadLine();
        var cleanInput = Regex.Replace(str, @"[^\w\s]", "");
        string[] words = cleanInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Số từ: {0}", words.Length);
        int upperCount = 0;
        int lowerCount = 0;
        foreach (char ch in str)
        {
            if (char.IsLetter(ch))
            {
                if (char.IsUpper(ch))
                {
                    upperCount++;
                }
                else if (char.IsLower(ch))
                {
                    lowerCount++;
                }
            }
        }
        Console.WriteLine("Chữ hoa: {0} từ, chữ thường: {1} từ", upperCount, lowerCount);












    }
}
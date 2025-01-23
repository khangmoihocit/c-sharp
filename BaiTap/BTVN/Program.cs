internal class Program
{
    private static void Main(string[] args)
    {

        //y 1
        int a, b;
        Console.WriteLine("nhap a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap b: ");
        b = int.Parse(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine("tong a + b = " + sum);


        //y 2
        int c, d, e;
        Console.WriteLine("nhap 3 so nguyen: ");
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        e = int.Parse(Console.ReadLine());
        int res = c * d * e;
        Console.WriteLine("tich 3 so vua nhap la: " + res);



        //y 3
        Console.WriteLine("nhap 1 van ban: ");
        string s = Console.ReadLine();

        s = s.Trim();
        string[] ss = s.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        int soTu = ss.Length;
        char[] arr = s.ToCharArray();

        int soChuHoa = 0;
        int soChuThuong = 0;
        for(int i=0; i<arr.Length; ++i)
        {
            if (Char.IsLetter(arr[i]))
            {
                if (Char.IsUpper(arr[i])) soChuHoa++;
                if (Char.IsLower(arr[i])) soChuThuong++;
            }
        }

        Console.WriteLine("so tu trong xau vua nhap: " + soTu);
        Console.WriteLine("so chu hoa: " + soChuHoa);
        Console.WriteLine("so chu thuong: " + soChuThuong);

    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap 1 xau bat ky: ");
        string s = Console.ReadLine();
        int soKyTu = 0, soLuongTu = 0;


        //chuyen xau thanh mang ky tu
        char[] arr = s.ToCharArray();



        // dem ky tu
        foreach(char x in arr)
        {
            if(!Char.IsWhiteSpace(x)) soKyTu++;
        }
        Console.WriteLine("so ky tu: " + soKyTu);



        //dem tu
        string[] ss = s.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        soLuongTu = ss.Length;
        Console.WriteLine("so luong tu: " + soLuongTu);



        //hien xau nguoc
        Array.Reverse(arr);
        string sRev = "";
        foreach(char x in arr)
        {
            sRev += x;
        }
        Console.WriteLine("xau dao nguoc: " + sRev);


        Console.ReadLine();
    }
}
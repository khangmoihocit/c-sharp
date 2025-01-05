internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //khai bao
        List<string> list = new List<string>();
        list.Add("cntt");
        list.Add("dtvt");
        list.Remove("cntt");

        foreach (string s in list)
        {
            Console.Write(s + ", ");
        }

        list.Clear();//xoa toan bo

        Console.ReadLine();
    }
}
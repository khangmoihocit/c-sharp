internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("nhap thoi gian moc 1: ");
        string s1 = Console.ReadLine();
        Console.Write("nhap thoi gian moc 2: ");
        string s2 = Console.ReadLine();


        try
        {
            //hh:mm:ss
            TimeSpan timeSpan1 = TimeSpan.Parse(s1);
            TimeSpan timeSpan2 = TimeSpan.Parse(s2);

            
            
            TimeSpan a = timeSpan1 - timeSpan2;
            Console.WriteLine("khoang cach thoi gian giua 2 moc thoi gian theo giay: " + a.TotalSeconds);

            if(timeSpan1.CompareTo(timeSpan2) < 0)
            {
                Console.WriteLine("thoi gian moc 1 xay ra truoc");
            }else if(timeSpan1.CompareTo(timeSpan2) > 0)
            {
                Console.WriteLine("thoi gian moc 2 xay ra truoc");
            }

            TimeSpan b = timeSpan1 + timeSpan2;
            Console.WriteLine("tong 2 moc thoi gian: "+ b.ToString());

        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }



        Console.ReadLine();
    }
}
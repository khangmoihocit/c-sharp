internal class Program
{

    static void Choi()
    {
        Random rd = new Random();
        int soCuaMay = rd.Next(11);
        int soCuaNguoi;
        int soLanDoan = 0;
        Console.WriteLine("may da ra 1 so trong doan tu 0->500, moi ban doan");
        while (true)
        {
            soCuaNguoi = int.Parse(Console.ReadLine());
            soLanDoan++;
            if(soCuaNguoi == soCuaMay)
            {
                Console.WriteLine("ban da doan dung, so cua may la: " + soCuaMay);
                break;
            }
            if(soCuaNguoi < soCuaMay)
            {
                Console.WriteLine("so ban doan < so cua may");
                Console.WriteLine("moi ban doan lai: ");

            }
            else
            {
                Console.WriteLine("so ban doan > so cua may");
            }
            if(soLanDoan == 7)
            {
                Console.WriteLine("game over");
                break;
            }
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Choi();
        Console.ReadLine();
    }
}
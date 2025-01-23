internal class Program
{

    /*
    lambda - Anonymous function
    1)
    (tham_so) => bieu_thuc;


    2) 
    (tham_so) => {
        cac_bieu_thuc;
        return gia_tri_tra_ve;
    }

    

     
     */

    public static void Test()
    {
        Action<string, string> welcome = (message, name) => Console.WriteLine(message + " " + name);
        welcome?.Invoke("xin chao", "kpham");
        welcome?.Invoke("chao mung", "kpham");
    }

    public static void Test1()
    {
        List<int> list = new List<int>() { 1, 3, 5, 7, 2, 4, 8, 11};

        //var result = list.Select((int x) =>
        //{
        //    return Math.Sqrt(x);
        //});

        //foreach(var x in result)
        //{
        //    Console.WriteLine(x + " ");
        //}
        Console.WriteLine("cac so chia het cho 2 : ");
        list.ForEach(
            x =>
            {
                if(x % 2 == 0) Console.WriteLine(x);
            }
            );

        //
        Console.WriteLine("cac so lon hon 5, nho hon 10");
        var kq = list.Where(x => x >= 5 && x <= 10);

        foreach(var x in kq)
        {
            Console.WriteLine(x);
        }



    }

    private static void Main(string[] args)
    {
    /*        
        Action<string> thongbao;
        //thongbao = (string s) => Console.WriteLine(s);
        thongbao = s => Console.WriteLine(s);
        thongbao?.Invoke("xin chao");


        //vd2
        Func<int, int, int> tinhtoan = (int a, int b) => a + b;
        Console.WriteLine(tinhtoan(2, 3));
    */

        Test1();

        Console.ReadLine();
    }
}
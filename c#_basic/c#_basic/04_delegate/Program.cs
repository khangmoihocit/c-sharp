
//delegate(type) bien = phuong thuc
public delegate void ShowLog(string message);


//tương đương với câu lệnh: nếu 'log != null' thì gọi hàm ' log.Invoke("...") ';
//log?.Invoke("xin chao");
internal class Program
{

    public static void Info(string s)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(s);
        Console.ResetColor();
    }

    public static void Warning(string s)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(s);
        Console.ResetColor();
    }

    public static int Tong(int a, int b) => a + b;
    public static int Hieu(int a, int b) => a - b;

    public static void Nhan(int a, int b, ShowLog log)
    {
        int result = a * b;
        log?.Invoke(result.ToString());
    }

    private static void Main(string[] args)
    {
        int a = 8, b = 5;
        Nhan(a, b, Info);


        //Action, Func : delegate - generic
        Action action; // ~ delegate void KIEU();
        Action<string, int> action1;// ~ delegare void KIEU(string a, int b);
        Func<int, double, string> func1; // ~ delegate string(int a, double b);


        //vd func
        Func<int, int, int> tinhtoan;
        tinhtoan = Tong;
        Console.WriteLine(tinhtoan(a, b));


        //vd action
        Action<string> action2;
        action2 = Info;
        action2 += Warning;
        action2?.Invoke("thong bao tu action");


        
    }
}
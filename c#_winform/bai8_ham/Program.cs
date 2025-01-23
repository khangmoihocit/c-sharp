
internal class Program
{
    static int TinhGiaiThua(int n)
    {
        int sum = 1;
        for(int i = 1; i <= n; ++i)
        {
            sum *= i;
        }
        return sum;
    }

    static int TangSo(ref int n)
    {
        n++;
        return n;
    }


   
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.Write("nhap so can tinh giai thua: ");
        //int n = int.Parse(Console.ReadLine());

        //Console.WriteLine(n + "! = " + TinhGiaiThua(n) );


        //truyen tham tri: sau khi thoat khoi ham, bien van giu nguyen gia tri goc.
        //truyen tham chieu: sau khi thoat khoi ham, no se lay gia tri thay doi trong ham.
        //trog c# truyen tham chieu su dung 'ref' hoac 'out' voi cac datatype(int, float, string ...)
        // ref: bắt buộc phải khởi tạo giá trị cho biến trước khi vào hàm.
        // out: bắt buộc phải gán giá trị cho biến trước khi thoát khỏi hàm.
        
        //vd:
        int a = 10;
        int b = TangSo(ref a);
        Console.WriteLine("test: ");
        Console.WriteLine(a);
        Console.WriteLine(b);


        Console.ReadLine();


    }
}


internal class Program
{

    //khi có nhiều kiểu dữ liệu muốn truyền vào 1 phương thức, ta use generic
    //public static void Swap<T>(ref T a, ref T b)
    //{
    //    T t;
    //    t = a;
    //    a = b;
    //    b = t;
    //}

    internal class Product<A>
    {
        public A ID;
        public void Set_ID(A _id)
        {
            this.ID = _id;
        }

        public void PrintInf()
        {
            Console.WriteLine($"ID = {this.ID}");
        }
    }

    private static void Main(string[] args)
    {

        Product<int> sanPham1 = new Product<int>();
        sanPham1.Set_ID(123);
        sanPham1.PrintInf();

        Product<string> sanPham = new Product<string>();
        sanPham.Set_ID("01ASB");
        sanPham.PrintInf();

        //float a = 5;
        //float b = 45;

        //Console.WriteLine("a = " + a + ", b = " + b);

        //Swap<float>(ref a, ref b);

        //Console.WriteLine("a = " + a + ", b = " + b);


    }

}
internal class Program
{

    //virtual method - 
    //lớp Abstract - dùng để làm cơ sở cho các lớp kế thừa

    abstract class Product
    {
        protected double Price { get; set; }

        public virtual void ProductInfo()
        {
            Console.WriteLine($"Gia san pham: {Price}");
        }

        public void test() => ProductInfo();
    }

    class Iphone : Product
    {
        public Iphone() => Price = 500;

        public int tong(int a, int b) => a + b;

        public override void ProductInfo()
        {

            Console.WriteLine($"san pham iphone: {Price}");
        }

    }


    //Interface
    interface IHinhHoc
    {
        public double TinhChuVi();
        public double TinhDienTich();

    }

    class HinhChuNhat : IHinhHoc
    {
        public HinhChuNhat(int _a, int _b)
        {
            this.a = _a;
            this.b = _b;
        }
        public double a { get; set; }
        public double b { get; set; }

        public double TinhChuVi()
        {
            return 2 * (a + b);
        }

        public double TinhDienTich()
        {
            return a * b;
        }
    }


    private static void Main(string[] args)
    {
        Iphone phone1 = new Iphone();
        phone1.ProductInfo();




    }
}
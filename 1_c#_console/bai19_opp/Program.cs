using bai19_opp;

internal class Program
{

    static void testParams()
    {
        ClassTestParams param = new ClassTestParams();

        long result = param.sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        Console.WriteLine(result);
    }


    private static void Main(string[] args)
    {
        //muc truy xuat
        //public: co the truy xuat o moi noi
        //private: chi co the truy xuat o trong class
        //protected: chi truy xuat trong class hoac class ke thua

        //static: dùng cho các thành phần lớp khoog phụ thuộc vào đối tượng cụ thể
        //vd: k cần khai bao đồi tg vẫn có thể dùng các phương thức
        testParams();

        Console.ReadLine();
        
    }

}
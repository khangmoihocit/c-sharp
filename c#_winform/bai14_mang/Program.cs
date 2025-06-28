internal class Program
{
    public static void PrintArray(int[] a)
    {
        foreach(int i in a)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int n = int.Parse(Console.ReadLine());

        //khai bao
        int[] a = new int[n];
        for(int i = 0; i<n; ++i)
        {
            int x = int.Parse(Console.ReadLine());
            a[i] = x;
        }

        foreach(int x in a)
        {
            Console.Write(x + " ");
        }


        //sao chep mang: copyto, array.copy
        int[] b = new int[n];
        Array.Copy(a, b, a.Length);
        PrintArray(b);

        //dao nguoc mang: phuong thuc Reverse cua class Array
        Array.Reverse(b);
        PrintArray(b);

        //sap xep mang: phuong thuc sort cua class array
        Array.Sort(b);
        PrintArray(b);

        //tim kiem: array.binarysearch(ten_mang, giatri); tra ve vi tri, -1 neu k tim thay
        if(Array.BinarySearch(b, 5) != -1)
        {
            Console.WriteLine("tim thay!");
        }
        else
        {
            Console.WriteLine("k tim thay!");
        }


        //mang da chieu
        //khai bao
        int soHang = 3, soCot = 3;
        int[,] a2 = new int[soHang, soCot];
        for(int i=0; i<a2.GetLength(0); i++)
        {
            for(int j=0; j<a2.GetLength(1); j++)
            {
                Console.WriteLine(a2[i,j]);
            }
        }




        Console.ReadLine();
    }


}
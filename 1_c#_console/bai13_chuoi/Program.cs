using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

internal class Program

{
    //dem so luong in hoa, thuong, so, khoang trang trong chuoi
    static void XuLyChuoi()
    {
        string s = "";
        Console.WriteLine("nhap xau: ");
        s = Console.ReadLine();
        int demInHoa = 0, demInThuong = 0, demSo = 0, demKT = 0;
        char[] arr = s.ToCharArray();
        for(int i = 0; i<arr.Length; ++i)
        {
            if (Char.IsUpper(arr[i])) demInHoa++;
            if (Char.IsLower(arr[i])) demInThuong++;
            if (Char.IsDigit(arr[i])) demSo++;
            if (Char.IsWhiteSpace(arr[i])) demKT++;
        }
        Console.WriteLine("so chu in hoa: " + demInHoa);
        Console.WriteLine("so chu in thuong: " + demInThuong);
        Console.WriteLine("so chu la so: " + demSo);
        Console.WriteLine("so khoang trang: " + demKT);
    }

    static void XuLyChuoi2()
    {
        string s = "d/program/user/bai hat/hoa tuong tu.mp3";
        int vt = s.LastIndexOf("/");
        string s1 = s.Substring(vt + 1);
        Console.WriteLine(s1);
        int vt2 = s1.LastIndexOf(".");
        string s2 = s1.Substring(0, vt2);
        Console.WriteLine(s2);
    }

    private static void Main(string[] args)
    {


        //kieu ky tu (char)
        Console.WriteLine("Hello, World!");
        char c = Convert.ToChar("a");
        Console.WriteLine(c);

        char c1 = 'a';
        char c2 = 'b';
        //ham so sanh 2 ky tu, tra ve <0, >0, =0
        int result = c1.CompareTo(c2);
        //ham so sanh equals tra ve true, false
        //Char.IsDigit(c): true, neu c la so
        //Char.IsLetter(c): true, neu c la chu
        //Char.IsNumeric(c): true, neu c la chu so unicode
        //Char.IsWhiteSpace(c): true, neu c la khoang trang
        //Char.IsLower(c): true, neu c la chu thuong
        //Char.IsUpper(c): true, neu c la chu hoa

        //Char.ToLower(c): chuyen ky tu c ve chu thuong
        //Char.ToUpper(c): chuyen ky tu c ve chu hoa



        //string: chuoi
        //a.ToString(): tra ve chuoi ung voi noi dung trong bien a
        //string str = Convert.ToString(obj); chuyen obj ve kieu xau

        //str.ToCharArray(): tra ve ki btu trong chuoi
        //str.Length
        //str.Contains("abc"): kiem tra xau con, co tra ve true

        //XuLyChuoi();

        string s = "hello";
        char[] a = new char[10];
        a[0] = 'a';
        a[1] = 'b';
        //sao chep 3 ki tu bat dau tu index 1, vao xau a tu index 2
        s.CopyTo(1, a, 2, 3);
        Console.WriteLine(a);

        //EndsWith: tra ve true neu dung la chuoi o cuoi
        if (s.EndsWith("lo"))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        //s1.Equals(s2)
        bool check = s.Equals("true");
        //string Insert(int startIndex, string value): chen chuoi
        //int IndexOf(char/string value): tra ve vi tri dau tien xuat hien
        //int IndexOf(char/string value, int startIndex)
        //int LastIndexOf(char/string value): tra ve vi tri cuoi cung, neu k tim thay tra ve -1
        string ss = "they are leaning programer.";
        Console.WriteLine("vi tri chu 'a' xuat hien: " + ss.IndexOf('a'));
        //string Remove(int startIndex, int count): xoa tu vi tri, bao nhieu ki tu
        //string Replace(string oldStr, string newStr):
        //string Substring(int startIndex, int count): cat chuoi
        // string Trim(): xoa du thua ben trai phai
        XuLyChuoi2();



        Console.ReadLine();
    }
}
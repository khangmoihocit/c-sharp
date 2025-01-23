internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //khai bao
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(1, "nguyen van a");
        dic.Add(2, "nguyen van b");
        dic.Add(3, "pham van khang");

        Console.WriteLine(dic[1]);

        //duyet danh sach
        foreach (KeyValuePair<int, string> item in dic)
        {
            int key = item.Key;
            string value = item.Value;
        }

        //kiem tra key co ton tai khong
        //dic.ContainsValue
        if (dic.ContainsKey(2)) {
            Console.WriteLine("found");
        }
        else
        {
            Console.WriteLine("not found");
        }
        
        int soLuong = dic.Count; //so luong phan tu trong dictionary
        dic.Remove(2); //xoa phan tu theo key
        //dic.Clear(); //xoa toan bo

        //lay list value, key trong dictionary
        List<string> dsValue = dic.Values.ToList();
        List<int> dsKey = dic.Keys.ToList();
        foreach (string item in dsValue)
        {
            Console.Write(item + ", ");
        }



        



        Console.ReadLine();

    }
}
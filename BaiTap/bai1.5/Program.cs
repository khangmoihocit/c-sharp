using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        try
        {
            Console.Write("Nhập ngày đầu tiên (dd/MM/yyyy): ");
            string s1 = Console.ReadLine();

            Console.Write("Nhập ngày thứ hai (dd/MM/yyyy): ");
            string s2 = Console.ReadLine();

            DateTime date1 = DateTime.ParseExact(s1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(s2, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            TimeSpan difference = date2 - date1;
            int daysDifference = Math.Abs(difference.Days);

            DateTime a = date1 < date2 ? date1 : date2;

            string formattedDate = a.ToString("dd/MM/yyyy");
            Console.WriteLine("Ngày sớm hơn: Ngày " + formattedDate);





        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}
using System.Configuration;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;
        try
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                addHangHoa(connection);
                hienHangHoa(connection);




            }

            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }



    //them hang hoa
    private static void addHangHoa(SqlConnection connection)
    {
        string tenHang, dacDiem, xuatXu;
        float giaNiemYet;

        Console.WriteLine("nhap ten hang: "); tenHang = Console.ReadLine();
        Console.WriteLine("nhap dac diem: "); dacDiem = Console.ReadLine();
        Console.WriteLine("nhap xuat xu: "); xuatXu = Console.ReadLine();
        Console.WriteLine("nhap gia niem yet: "); giaNiemYet = float.Parse(Console.ReadLine());

        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spHangHoa_Insert";
            command.Parameters.AddWithValue("@tenhang", tenHang);
            command.Parameters.AddWithValue("@gianiemyet", giaNiemYet);
            command.Parameters.AddWithValue("@dacdiem", dacDiem);
            command.Parameters.AddWithValue("@xuatxu", xuatXu);
            int n = command.ExecuteNonQuery();
            if(n > 0)
            {
                Console.WriteLine("them thanh cong");
            }
            else
            {
                Console.WriteLine("loi, k them dc");
            }
        }
    }


    //hien hang hoa
    private static void hienHangHoa(SqlConnection connection)
    {
        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spHangHoa_Get";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                int n = 1;
                while (reader.Read())
                {
                    Console.WriteLine("STT: " + n + "\t\ttên hàng: " + reader["sTenHang"]
                        + "\t\tGiá niêm yết: " + reader["fGiaNiemYet"]);
                    n++;
                }
            }
        }
    }








}
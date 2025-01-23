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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                hienHangHoa(connection);
            }




            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void hienHangHoa(SqlConnection connection)
    {
        using(SqlCommand command = connection.CreateCommand())
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spHangHoa_Get";
            using(SqlDataReader reader = command.ExecuteReader())
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
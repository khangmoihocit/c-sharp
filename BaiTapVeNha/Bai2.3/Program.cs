using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;
        using(SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            hienHangHoa(connection);
            Console.WriteLine("nhap id can xoa");
            int id = int.Parse(Console.ReadLine());
            deleteHangHoaById(connection, id);
            hienHangHoa(connection);
            
        }//cnn
    }

    private static void deleteHangHoaById(SqlConnection connection, int id)
    {
        using(SqlCommand command = new SqlCommand("spHangHoa_Delete", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PK_iHanghoaID", id);
            int n = command.ExecuteNonQuery();
            if(n > 0)
            {
                Console.WriteLine("xoa thanh cong");
            }
            else
            {
                Console.WriteLine("loi");
            }
        }
    }

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
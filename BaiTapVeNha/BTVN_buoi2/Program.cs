using System.Data;
using System.Data.SqlClient;
using System.Text;

internal class Program
{



    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        try
        {
            string connectionString = "Server = (local); Database = baitapvenha; User ID = khangbtl; Password = 123";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();


                //y 1
                Console.WriteLine("nhap nam sinh: ");
                int namSinh = int.Parse(Console.ReadLine());

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "select * from tblCongdan where year(tNgaysinh) = @namSinh";
                    sqlCommand.Parameters.AddWithValue("@namSinh", namSinh);
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                Console.WriteLine("CMND: " + sqlDataReader["sCMND"]
                                    + "\tHo ten: " + sqlDataReader["sHoten"]
                                    + "\tHo khau: " + sqlDataReader["sHokhau"]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("khong co cong dan nao");
                        }
                        sqlDataReader.Close();
                    }
                }


                //y2
                Console.WriteLine("nhap cmnd can xoa: ");
                string cmnd = Console.ReadLine();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "delete tblCongdan where sCMND = @cmnd";
                    sqlCommand.Parameters.AddWithValue("@cmnd", cmnd);
                    if (sqlCommand.ExecuteNonQuery() != 0)
                    {
                        Console.WriteLine("xoa thanh cong");
                    }
                    else
                    {
                        Console.WriteLine("khong tim thay cmnd can xoa");
                    }
                   
                }

                using (SqlCommand sqlCommand = new SqlCommand("select * from tblCongdan", sqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            Console.WriteLine("danh sach cong dan sau khi xoa: ");
                            while (sqlDataReader.Read())
                            {
                                Console.WriteLine("id cong dan: " + sqlDataReader["PK_iCongdanID"]
                                    + "\tCMND: " + sqlDataReader["sCMND"]
                                    + "\tHo ten: " + sqlDataReader["sHoten"]
                                    + "\tHo khau: " + sqlDataReader["sHokhau"]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("khong ton tai cong dan nao");
                        }
                        sqlDataReader.Close();
                    }
                }
                sqlConnection.Close();
            }


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }







        Console.ReadLine();
    }
}
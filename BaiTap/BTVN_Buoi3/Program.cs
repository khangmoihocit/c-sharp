using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;
        //string connectionString = "Server = (local); Database = baitapvenha; User ID = khangbtl; Password = 123";

        try
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int chon = 0;
                do
                {
                    Console.WriteLine("----menu----");
                    Console.WriteLine("1. them cong dan.");
                    Console.WriteLine("2. hien thi danh sach cong dan.");
                    Console.WriteLine("3. xoa cong dan.");
                    Console.WriteLine("4. sua thong tin cong dan.");
                    Console.WriteLine("5. tim cong dan.");
                    Console.WriteLine("0. Thoat.");
                    Console.Write("chon: ");
                    chon = int.Parse(Console.ReadLine());

                    switch (chon)
                    {
                        case 1:
                            //them cong dan
                            addCongDan(connection, inputCongDan());
                            
                            break;
                        case 2:
                            //hien thi ds cong dan
                            printListCongDanByTable(connection);
                            break;
                        case 3:
                            //xoa cong dam
                            Console.WriteLine("nhap id cong dan can xoa: ");
                            int idCongDan = int.Parse(Console.ReadLine());
                            removeCongDanById(connection, idCongDan);
                            break;
                        case 4:
                            //sua cong dan
                            Console.WriteLine("nhap id cong dan muon sua: ");
                            int id2 = int.Parse(Console.ReadLine());
                            updateCongDan(connection, id2);
                            break;
                        case 5:
                            //tim kiem cong dan theo 1 tieu chi lua chon
                            findCongDan(connection);
                            break;

                    }
                } while (chon != 0);
                connection.Close();
            }//conn
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }

    //tim kiem
    private static void findCongDan(SqlConnection connection)
    {
        Console.WriteLine("ban muon tim cong dan theo: ");
        Console.WriteLine("1. ten cong dan?");
        Console.WriteLine("2. cmnd?");
        Console.WriteLine("3. ho khau?");
        //Console.WriteLine("4. ngay sinh?");
        Console.Write("chon: ");
        int chon = int.Parse(Console.ReadLine());

        KeyValuePair<string, object> pair = new KeyValuePair<string, object>();
        if(chon == 1)
        {
            Console.WriteLine("nhap ten cong dan muon tim: ");
            string ten = Console.ReadLine();

            pair = new KeyValuePair<string, object>("sHoTen", ten);
        }
        else if(chon == 2)
        {
            Console.WriteLine("nhap cmnd: ");
            string cmnd = Console.ReadLine();

            pair = new KeyValuePair<string, object>("sCMND", cmnd);
        }
        else if(chon == 3)
        {
            Console.WriteLine("nhap ho khau: ");
            string hoKhau = Console.ReadLine();

            pair = new KeyValuePair<string, object>("sHoKhau", hoKhau);
        }
        else if(chon == 4)
        {
            Console.WriteLine("nhap ngay sinh: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            //
        }
        getCongDan(connection, pair);


    }

    //tim kiem duoi db
    private static void getCongDan(SqlConnection connection, KeyValuePair<string, object> pair)
    {
        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from tblCongDan where " + pair.Key + " = " + "'" + pair.Value + "'";

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    Console.WriteLine("id cd: " + reader["PK_iCongDanID"] 
                        + "\tten cd: " + reader["sHoTen"]
                    + "\tcmnd: " + reader["sCMND"] + "\tngay sinh: " 
                    + reader["tNgaySinh"] + "\tho khau: "
                    + reader["sHoKhau"]);
                }
            }
        }
    }






    //sua thong tin
    private static void updateCongDan(SqlConnection connection, int id)
    {
        using(SqlCommand command = connection.CreateCommand())
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "update_congdan";
            command.Parameters.AddWithValue("@id", id);
            Dictionary<string, object> congDan = inputCongDan();

            command.Parameters.AddWithValue("@hoten", congDan["hoTen"]);
            command.Parameters.AddWithValue("@cmnd", congDan["cmnd"]);
            command.Parameters.AddWithValue("@ngaysinh", congDan["ngaySinh"]);
            command.Parameters.AddWithValue("@hokhau", congDan["hoKhau"]);

            int n = command.ExecuteNonQuery();
            if(n!=0) Console.WriteLine("cap nhat thanh cog");
            else Console.WriteLine("khong tim thay id can cap nhat");
        }
    }



    //xoa cong dan theo id
    private static void removeCongDanById(SqlConnection connection, int id)
    {
        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandType = CommandType.Text;
            command.CommandText = "delete tblCongdan where PK_iCongdanID = " + id;
            int n = command.ExecuteNonQuery();
            if(n != 0)
            {
                Console.WriteLine("xoa thanh cong");
            }
            else
            {
                Console.WriteLine("khong tim thay id can xoa.");
            }
        }
    }






    //lay du lieu cong dan tu db
    private static DataTable getListCongDan(SqlConnection connection)
    {
        using (SqlCommand command = new SqlCommand("print_congdan", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable tblCongDan = new DataTable("tblCongDan");
                adapter.Fill(tblCongDan);
                return tblCongDan;

            }//adapter

        }//command


    }

    //hien thi danh sach cong dan
    private static void printListCongDanByTable(SqlConnection connection)
    {
        DataTable tblCongDan = getListCongDan(connection);
        DataView viewCongDan = new DataView(tblCongDan);

        foreach (DataRowView o in viewCongDan)
        {
            Console.WriteLine("id cd: " + o["PK_iCongDanID"] + "\tten cd: " + o["sHoTen"]
                + "\tcmnd: " + o["sCMND"] + "\tngay sinh: " + o["tNgaySinh"] + "\tho khau: "
                + o["sHoKhau"]);
        }

    }





    //lay du lieu cong dan tu ban phim
    private static Dictionary<string, object> inputCongDan()
    {
        Dictionary<string, object> congDan = new Dictionary<string, object>();

        string hoTen, cmnd, hoKhau;
        DateTime ngaySinh;

        Console.WriteLine("nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.WriteLine("nhap cmnd: ");
        cmnd = Console.ReadLine();
        Console.WriteLine("Nhap ho khau: ");
        hoKhau = Console.ReadLine();

        try
        {
            Console.WriteLine("nhap ngay sinh: ");
            ngaySinh = DateTime.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            ngaySinh = DateTime.Parse("1753/01/01");
        }

        congDan.Add("hoTen", hoTen);
        congDan.Add("cmnd", cmnd);
        congDan.Add("hoKhau", hoKhau);
        congDan.Add("ngaySinh", ngaySinh);


        return congDan;
    }

    //them cong dan
    private static void addCongDan(SqlConnection connection, Dictionary<string, object> congDan)
    {
        using (SqlCommand command = connection.CreateCommand())
        {

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "insert_tblCongDan";

            command.Parameters.AddWithValue("@sHoTen", congDan["hoTen"]);
            command.Parameters.AddWithValue("@sCMND", congDan["cmnd"]);
            command.Parameters.AddWithValue("@sHoKhau", congDan["hoKhau"]);
            command.Parameters.AddWithValue("@tNgaySinh", congDan["ngaySinh"]);

            int n = command.ExecuteNonQuery();
            if(n != 0)
            {
                Console.WriteLine("them thanh cong");
            }
            else
            {
                Console.WriteLine("loi, khong them duoc.");
            }

        }//command
    }

}
using System.Configuration;
using System.Data;
using System.Reflection.Metadata;
using Microsoft.Data.SqlClient;
using MoHinhNgatKetNoi;

internal class Program
{
    private static void Main(string[] args)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable tblHangHoa = getHangHoaByTable(connection);
                try
                {
                    //HangHoa h1 = new HangHoa();
                    //HangHoa h2 = new HangHoa();
                    //h2.inputHangHoa();
                    //h1.inputHangHoa();
                    //addHangHoa(connection, tblHangHoa, h1);
                    //addHangHoa(connection, tblHangHoa, h2);
                    deleteHangHoa(connection);

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex);
                }

                //updateHangHoaForDB(connection, tblHangHoa);

                printListHangHoaByDataView(tblHangHoa);


            }//cnn
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

    }

    private static DataTable getHangHoaByTable(SqlConnection connection)
    {
        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spHangHoa_Get";
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable tblHangHoa = new DataTable();
                adapter.Fill(tblHangHoa);
                return tblHangHoa;
            }//adapter
        }//command
    }

    //them hang hoa vao tbl
    private static void addHangHoa(SqlConnection connection, DataTable tblHangHoa, HangHoa hangHoa)
    {
        DataRow row = tblHangHoa.NewRow();
        row["sTenhang"] = hangHoa.tenHangHoa;
        row["fGianiemyet"] = hangHoa.giaNiemYet;
        row["sDacdiem"] = hangHoa.dacDiem;
        row["sXuatxu"] = hangHoa.xuatXu;

        tblHangHoa.Rows.Add(row);

    }


    //cap nhat hang hoa vao database
    private static void updateHangHoaForDB(SqlConnection connection, DataTable tblHangHoa)
    {
        using (SqlCommand insertCommand = connection.CreateCommand())
        {
            insertCommand.CommandText = "spHangHoa_Insert";
            insertCommand.CommandType = CommandType.StoredProcedure;
            insertCommand.Parameters.Add(
                new SqlParameter("@tenhang", SqlDbType.NVarChar, 300))
                .SourceColumn = "sTenhang";
            insertCommand.Parameters.Add(
                new SqlParameter("@gianiemyet", SqlDbType.Float))
                .SourceColumn = "fGianiemyet";
            insertCommand.Parameters.Add(
                new SqlParameter("@xuatxu", SqlDbType.NVarChar))
                .SourceColumn = "sXuatxu";
            insertCommand.Parameters.Add(
                new SqlParameter("@dacdiem", SqlDbType.NVarChar))
                .SourceColumn = "sDacdiem";

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.InsertCommand = insertCommand;

                //lay cac ban ghi can them tu tblHangHoa ra tableToBeInsert,
                //thuc thi Update tren tableToBeInsert
                DataTable tableToBeInsert = tblHangHoa.GetChanges(DataRowState.Added);
                adapter.Update(tableToBeInsert); //dua du lieu vao database bang proc spHangHoa_Insert
                if ((!tableToBeInsert.HasErrors))
                {
                    tblHangHoa.AcceptChanges();
                    Console.WriteLine("them hang hoa thanh cong!");
                }

            }//adpater
        }//insertcommand

    }//update

    private static void printListHangHoaByDataView(DataTable tblHangHoa)
    {
        DataView viewHangHoa = new DataView(tblHangHoa);
        viewHangHoa.Sort = "PK_iHanghoaID DESC";

        int soThuTu = 0;
        foreach (DataRowView drv in viewHangHoa)
        {
            Console.WriteLine(
                drv["sTenhang"]
               + "\t" + drv["fGianiemyet"]
               + "\t" + drv["sDacdiem"]);
        }
    }
    
    private static void syncDataToDatabase(SqlConnection connection, DataTable tableToBeSync)
    {
        using(SqlCommand deleteCommand = connection.CreateCommand())
        {
            deleteCommand.CommandText = "spHangHoa_Delete";
            deleteCommand.CommandType = CommandType.StoredProcedure;
            deleteCommand.Parameters.Add(
                new SqlParameter("@PK_iHanghoaID", SqlDbType.Int))
                .SourceColumn = "PK_iHangHoaID";

            using(SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.DeleteCommand = deleteCommand;
                adapter.Update(tableToBeSync);
                Console.WriteLine("da ghi nhan vao csdl");
            }
        }
    }
    
    private static void deleteHangHoa(SqlConnection connection)
    {
        int maHang = 0;
        DataTable tbl = getHangHoaByTable(connection);
        while (true)
        {
            Console.WriteLine("nhap ma hang can xoa(nhap 0 de ket thuc): ");
            maHang = int.Parse(Console.ReadLine());
            
            DataRow[] rows = tbl.Select(string.Format("PK_iHanghoaID = " + maHang));
            if(rows.Length > 0)
            {
                rows[0].Delete();
                Console.WriteLine("da danh dau  xoa");
            }
        }//while

        Console.WriteLine("co ghi nhan ve csdl khong?(Y/N)");
        string ans = Console.ReadLine();

        if (ans.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
        {
            syncDataToDatabase(connection, tbl.GetChanges(DataRowState.Deleted));
            tbl.AcceptChanges();
            printListHangHoaByDataView(tbl);
        }

    }
















}
using System.Configuration;
using System.Data;
using System.Text;
using Bai2._4;
using Microsoft.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            int chon = 0;
            DataTable m_HanghoaTable = getHangHoaByTable(connection);
            bool check2 = false;
            bool check3 = false;
            do
            {
                Console.WriteLine("-----menu--");
                Console.WriteLine("1. Hien danh sach");
                Console.WriteLine("2. them hang hoa");
                Console.WriteLine("3. xoa hang hoa");
                Console.WriteLine("4. dong bo ve csdl");
                Console.WriteLine("5. thoat");
                Console.Write("chon: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        {
                            printListHangHoa(connection, m_HanghoaTable);
                            break;
                        }
                    case 2:
                        {
                            HangHoa hangHoa = new HangHoa();
                            hangHoa.inputHangHoa();
                            addHangHoa(m_HanghoaTable, hangHoa);
                            check2 = true;
                            break;
                        }
                    case 3:
                        {
                            deleteHangHoa(connection, m_HanghoaTable);
                            check3 = true;
                            break;
                        }
                    case 4:
                        {
                            if(check2 || check3)
                            {
                                updateAndSyncDataToBeDatabase(connection, m_HanghoaTable);
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("da thoat chuong trinh");
                            break;
                        }

                }//switch


            } while (chon != 5);

        }//connetion

    }

    private static void updateAndSyncDataToBeDatabase(SqlConnection connection, DataTable tblHangHoa)
    {
        updateHangHoaToBeDatabase(connection, tblHangHoa);
        syncDataToBeDatabase(connection, tblHangHoa);
    }

    private static DataTable getHangHoaByTable(SqlConnection connection)
    {
        using (SqlCommand command = new SqlCommand("spHanghoa_Get", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                return tbl;
            }//adapter
        }//comamnd
    }

    private static void printListHangHoa(SqlConnection connection, DataTable tblHanghoa)
    {
        DataView view = new DataView(tblHanghoa);
        view.Sort = "PK_iHanghoaID ASC";

        int stt = 0;
        foreach (DataRowView drv in view)
        {
            Console.WriteLine(stt
                + "\t\t" + drv["sTenhang"]
                + "\t\t" + drv["fGianiemyet"]
                + "\t\t" + drv["PK_iHanghoaID"]
                );
            stt++;
        }
    }


    //them hang hoa vao tbl
    private static void addHangHoa(DataTable tblHanghoa, HangHoa hangHoa)
    {
        DataRow row = tblHanghoa.NewRow();
        row["sTenhang"] = hangHoa.tenHangHoa;
        row["fGianiemyet"] = hangHoa.giaNiemYet;
        row["sDacdiem"] = hangHoa.dacDiem;
        row["sXuatxu"] = hangHoa.xuatXu;

        tblHanghoa.Rows.Add(row);
    }

    //xoa hang hoa theo id
    private static void deleteHangHoa(SqlConnection connection, DataTable tblHanghoa)
    {
        int idHangHoa = 0;
        while (true)
        {
            Console.WriteLine("nhap id hang hoa can xoa(nhap 0 de ket thuc): ");
            idHangHoa = int.Parse(Console.ReadLine());
            if (idHangHoa == 0) break;


            DataRow[] rows = tblHanghoa.Select(string.Format("PK_iHanghoaID = " + idHangHoa));
            if (rows.Length == 1)
            {
                rows[0].Delete();
                Console.WriteLine("da danh dau xoa");
            }
        }//while
    }



    //cap nhat hang hoa vao database
    private static void updateHangHoaToBeDatabase(SqlConnection connection, DataTable tblHangHoa)
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
                new SqlParameter("@xuatxu", SqlDbType.NVarChar, 300))
                .SourceColumn = "sXuatxu";
            insertCommand.Parameters.Add(
                new SqlParameter("@dacdiem", SqlDbType.NVarChar, 300))
                .SourceColumn = "sDacdiem";

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.InsertCommand = insertCommand;
                DataTable tableToBeInsert = tblHangHoa.GetChanges(DataRowState.Added | DataRowState.Modified);
                if(tableToBeInsert != null)
                {
                    try
                    {
                        adapter.Update(tableToBeInsert); //dua du lieu vao database bang proc spHangHoa_Insert
                        if ((!tableToBeInsert.HasErrors)) tblHangHoa.AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }                  
                }
            }//adpater
        }//insertcommand
    }//update


    //cap nhat khi xoa trong database
    private static void syncDataToBeDatabase(SqlConnection connection, DataTable tblHangHoa)
    {
        using (SqlCommand deleteCommand = connection.CreateCommand())
        {
            deleteCommand.CommandText = "spHanghoa_Delete";
            deleteCommand.CommandType = CommandType.StoredProcedure;
            deleteCommand.Parameters.Add(
                new SqlParameter("@PK_iHanghoaID", SqlDbType.Int)).SourceColumn = "PK_iHanghoaID";

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.DeleteCommand = deleteCommand;

                // Lấy các hàng bị đánh dấu xóa
                DataTable tableToBeDelete = tblHangHoa.GetChanges(DataRowState.Deleted);

                if (tableToBeDelete != null)
                {
                    try
                    {
                        adapter.Update(tableToBeDelete);

                        // Chấp nhận thay đổi nếu không có lỗi
                        if (!tableToBeDelete.HasErrors)
                        {
                            tblHangHoa.AcceptChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Đã xảy ra lỗi khi cập nhật cơ sở dữ liệu: {ex.Message}");
                    }
                }
            }
        }
    }






















}
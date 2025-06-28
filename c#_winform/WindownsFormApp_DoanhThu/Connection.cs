using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WindownsFormApp_DoanhThu
{
    public class Connection
    {
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\c#_winform\WindownsFormApp_DoanhThu\QuanLyDoanhThu.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection() => new SqlConnection(stringConnection);

    }
}

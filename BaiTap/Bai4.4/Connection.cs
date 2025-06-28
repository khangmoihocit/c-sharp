using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Bai4._4
{
    public class Connection
    {
        private static string stringConnection = "Data Source=KHANG\\SQLEXPRESS02;Initial Catalog=db_Shop4Training;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetSqlConnection() => new SqlConnection(stringConnection);
    }
}

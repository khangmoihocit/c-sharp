using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.SqlServer.Server;
using Model;

namespace Database
{
    public class KhachHangDAO
    {
        public KhachHangDAO() { }

        public List<KhachHang> getKhachHangs()
        {
            List<KhachHang> khachHangDTOs = new List<KhachHang>();
            String query = "select * from tblKhachHang";
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                KhachHang khachHangDTO = new KhachHang();
                                khachHangDTO.Id = int.Parse(dataReader["iMaKH"].ToString());
                                khachHangDTO.Name = dataReader["sHoTen"].ToString();
                                khachHangDTO.Address = dataReader["sDiaChi"].ToString();

                                khachHangDTOs.Add(khachHangDTO);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return khachHangDTOs;

        }
        
    }
}

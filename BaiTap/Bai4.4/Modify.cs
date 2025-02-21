using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Bai4._4
{
    public class Modify
    {
        public Modify() { }

        public DataTable Table(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                        {
                            dataAdapter.SelectCommand = sqlCommand;
                            dataAdapter.Fill(dataTable);
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public void addKhachHang(KhachHang khachHang)
        {
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand insertCommand = new SqlCommand("spKhachHang_Insert", sqlConnection))
                    {
                        insertCommand.CommandType = CommandType.StoredProcedure;
                        insertCommand.Parameters.AddWithValue("@sHoten", khachHang.TenKH);
                        insertCommand.Parameters.AddWithValue("@sDiachi", khachHang.DiaChi);
                        insertCommand.Parameters.AddWithValue("@sDienthoai", khachHang.SoDienThoai);
                        insertCommand.Parameters.AddWithValue("@bGioitinh", khachHang.GioiTinh);
                        insertCommand.Parameters.AddWithValue("tNgaysinh", khachHang.NgaySinh);
                        insertCommand.Parameters.AddWithValue("@sTencoquan", khachHang.TenCoQuan);
                        int n = insertCommand.ExecuteNonQuery();
                        if (n > 0) MessageBox.Show("thêm thành công");
                        else MessageBox.Show("lỗi, không thêm đc");
                    }//insertCommand
                    sqlConnection.Close();
                }//sqlConnection
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void queryNormal(Dictionary<string, object> param, StringBuilder query)
        {
            foreach(var item in param)
            {
                string value = item.Value.ToString();
                if (checkString(value))
                {
                    if (!item.Key.Equals("sDienthoai") && !item.Key.Equals("tNgaysinh"))
                    {
                        //nếu là số
                        if (checkNumber(value)) query.Append(" and " + item.Key + " = " + value + " ");
                        //nếu là xâu
                        else query.Append(" and " + item.Key + " like '%" + value + "%' ");
                    }
                    //ngày sinh
                    else if (item.Key.Equals("tNgaysinh"))
                    {
                        query.Append(" and convert(date, tNgaysinh) = convert(date, '" + value + "') ");
                    }
                    else
                    {
                        query.Append(" and " + item.Key + " like '%" + value + "%' ");
                    }
                }
            }
        }
        
        public DataTable findAll(Dictionary<string, object> param)
        {
            StringBuilder query = new StringBuilder("select * from tblKhachHang where 1 = 1 ");
            queryNormal(param, query);

            MessageBox.Show(query.ToString());
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand(query.ToString(), sqlConnection);
                    sqlCommand.CommandType = CommandType.Text;

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    dataAdapter.Fill(table);

                    sqlConnection.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            return table;
        }

        public bool removeById(int id)
        {
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("spKhachHang_Delete", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@Id", id);
                        int n = sqlCommand.ExecuteNonQuery();
                        if (n > 0) return true;
                    }
                    sqlConnection.Close();
                }
            }
           
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public void update(KhachHang khachHang)
        {
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand("spKhachHang_Update", sqlConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", khachHang.MaKH);
                        command.Parameters.AddWithValue("@sHoten", khachHang.TenKH);
                        command.Parameters.AddWithValue("@sDiachi", khachHang.DiaChi);
                        command.Parameters.AddWithValue("@sDienthoai", khachHang.SoDienThoai);
                        command.Parameters.AddWithValue("@bGioitinh", khachHang.GioiTinh);
                        command.Parameters.AddWithValue("tNgaysinh", khachHang.NgaySinh);
                        command.Parameters.AddWithValue("@sTencoquan", khachHang.TenCoQuan);
                        int n = command.ExecuteNonQuery();
                        if (n > 0) MessageBox.Show("cập nhật thành công");
                        else MessageBox.Show("lỗi");
                    }
                    sqlConnection.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkString(string s)
        {
            if (!s.Equals("") && s != null) return true;
            return false;
        }

        private bool checkNumber(string s)
        {
            try
            {
                long number = long.Parse(s);

            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }

    }
}

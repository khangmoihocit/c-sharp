using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Bai4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<KhachHang> getKhachHangs()
        {
            List<KhachHang> listKhachHang = new List<KhachHang>();
            try
            {
                string connectionString = "Server = KHANG\SQLEXPRESS02; Database = db_Shop4Training; User ID = khangbtl; Password = 123; TrustServerCertificate=True";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("spKhachHang_Get", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                KhachHang khachHang = new KhachHang();

                                khachHang.HoTen = reader["sHoten"].ToString();
                                khachHang.ngaySinh = DateTime.Parse(reader["tNgaysinh"].ToString());
                                khachHang.TenCoQuan = reader["sTenCoquan"].ToString();
                                khachHang.DienThoai = reader["sDienthoai"].ToString();
                                if (reader["bGioitinh"].ToString() == "1")
                                {
                                    khachHang.GioiTinh = "name";
                                }
                                else
                                {
                                    khachHang.GioiTinh = "nu";
                                }
                                khachHang.DiaChi = reader["sDiachi"].ToString();
                                listKhachHang.Add(khachHang);
                            }


                        }
                    }
                    cnn.Close();
                }//cnn
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listKhachHang;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<KhachHang> khachHangs = getKhachHangs();

            foreach (var item in khachHangs)
            {
                lstKhachHang.Items.Add(item);
            }
        }

        private void lstKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            if(lstKhachHang.SelectedIndices.Count > 0)
            {
                KhachHang kh = lstKhachHang.SelectedItems[0] as KhachHang;
                MessageBox.Show(kh.HoTen + " ; " + kh.ngaySinh.ToString());
            }

        }
    }
}

using System.Configuration;
using System.Data;

namespace Bai_4_2
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
                string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;
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
    }
}

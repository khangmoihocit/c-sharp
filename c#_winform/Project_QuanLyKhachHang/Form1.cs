using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace Project_QuanLyKhachHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;
        public SqlConnection cnn = null;

        private void openConnection()
        {
            if (cnn == null)
                cnn = new SqlConnection(connectionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
        }

        private void closeConnection()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        private void printListKhachHang()
        {
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("select * from KhachHang", cnn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                lvKhachHang.Items.Clear();
                while (reader.Read())
                {
                    int ma = (int)reader["Ma"];
                    string ten = reader["Ten"].ToString();
                    bool gioiTinh = (bool)reader["GioiTinh"];
                    string phone = (string)reader["Phone"];
                    string loaiKH = (string)reader["LoaiKH"];

                    ListViewItem lvi = new ListViewItem(lvKhachHang.Items.Count + 1 + "");
                    lvi.SubItems.Add(ma + "");
                    lvi.SubItems.Add(ten);
                    lvi.SubItems.Add(phone);
                    lvi.SubItems.Add(gioiTinh == true ? "nam" : "nữ");

                    lvKhachHang.Items.Add(lvi);

                }
                reader.Close();
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printListKhachHang();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {

        }
    }
}

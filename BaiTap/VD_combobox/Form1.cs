using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace VD_combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienDanhsachKhachhang();
        }

        private SqlConnection sqlConnection = null;
        private string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;

        private void openConnection()
        {
            if (sqlConnection == null)
                sqlConnection = new SqlConnection(connectionString);
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        private void closeConnection()
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        private DataTable getKhachHang()
        {
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand("spKhachHang_Get", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblKhachHang");
                        adapter.Fill(tbl);
                        return tbl;
                    }
                }
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void hienDanhsachKhachhang()
        {
            DataTable t = getKhachHang();
            DataView v = new DataView(t);
            comboBox1.DisplayMember = "sHoten";
            comboBox1.ValueMember = "PK_iKhachhangID";
            comboBox1.DataSource = v;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("bạn vừa chọn khách hàng {0} có mã là {1}", comboBox1.Text,
                comboBox1.SelectedValue), "Demo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPNK_01
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            
            string recordFilter = "";
            string reportTitle = "Thông tin hóa đơn của khách hàng";
            if (!string.IsNullOrEmpty(dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString()))
            {
                int id = int.Parse(dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show(id.ToString());
                recordFilter = " {tblKhachHang.PK_iKhachhangID}  = " + id + " ";
            }


            string reportFilePath = @"D:\C#\BaiTap\SPNK_01\CrystalReport_HoaDon_KhachHang.rpt";

            frmReport_HoaDon_KhachHang frmReportHoaDon = new frmReport_HoaDon_KhachHang();
            frmReportHoaDon.showReport(reportFilePath,"", recordFilter);
            frmReportHoaDon.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Server = KHANG\\SQLEXPRESS02; Database = db_Shop4Training; User ID = khangbtl; Password = 123; TrustServerCertificate=True"))
            {
                using (SqlCommand command = new SqlCommand("select * from tblKhachHang", cnn))
                {
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvKhachHang.DataSource = table;
                }
            }
        }
    }
}

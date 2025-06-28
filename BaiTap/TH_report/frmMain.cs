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

namespace TH_report
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private DataTable getHoaDon()
        {
            using (SqlConnection cnn = new SqlConnection("Server = KHANG\\SQLEXPRESS02; Database = db_Shop4Training; User ID = khangbtl; Password = 123; TrustServerCertificate=True"))
            {
                using(SqlCommand command = new SqlCommand("select * from tblHoaDon", cnn))
                {
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmReportHoaDon frmReportHoaDon = new frmReportHoaDon();
            string recordFilter = "";

            if (!string.IsNullOrEmpty(dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString()))
            {
                int id = int.Parse(dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show(id.ToString());
                recordFilter = " {tblHoaDon.PK_iHoadonID}  = " + id + " ";
            }

            
            string reportFilePath = @"D:\C#\BaiTap\TH_report\CrystalReport1.rpt";


            frmReportHoaDon.showReport(@"D:\C#\BaiTap\TH_report\CrystalReport1.rpt", "Thông tin hóa đơn", recordFilter);
            frmReportHoaDon.ShowDialog();

        }

        public  void frmMain_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = getHoaDon();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvHoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvHoaDon.SelectedRows[0];
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHoaDon = int.Parse(row.Cells[0].Value.ToString());
                hoaDon.NgayLap = DateTime.Parse(row.Cells[1].Value.ToString());
                hoaDon.MaKhachHang = int.Parse(row.Cells[2].Value.ToString());
                hoaDon.NgayGiaoHang = DateTime.Parse(row.Cells[3].Value.ToString());
                hoaDon.TenNguoiNhan = row.Cells[4].Value.ToString();
                hoaDon.DiaChiGiaoHang = row.Cells[5].Value.ToString();
                hoaDon.DienThoaiNguoiNhan = row.Cells[6].Value.ToString();

                bool thanhtoan = bool.Parse(row.Cells[7].Value.ToString());
                if (thanhtoan) hoaDon.TrangThaiThanhToan = "đã thanh toán";
                else hoaDon.TrangThaiThanhToan = "chưa thanh toán";

                hoaDon.NguoiLapHoaDon = row.Cells[8].Value.ToString();
                hoaDon.TiLeGiamGia = float.Parse(row.Cells[9].Value.ToString());

                frmSua frmSua = new frmSua(hoaDon);
                frmSua.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("bạn chưa chọn hóa đơn để sửa");
            }
            
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

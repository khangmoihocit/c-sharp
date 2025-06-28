using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_report
{
    public partial class frmSua: Form
    {
        private HoaDon hoaDon;
        public frmSua(HoaDon hoaDon)
        {
            InitializeComponent();
            this.hoaDon = hoaDon;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KhachHang khachHang = cboTenNguoiNhan.SelectedItem as KhachHang;
            //txtDienThoai.Text = khachHang.DienThoai;
        }

        private void frmSua_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private string connectionString = "Data Source=KHANG\\SQLEXPRESS02;Initial Catalog=db_Shop4Training;Integrated Security=True;TrustServerCertificate=True;";

        private void printHoaDon()
        {
            txtTenNguoiNhan.Text = hoaDon.TenNguoiNhan;
            dtpNgayGiaoHang.Value = hoaDon.NgayGiaoHang;
            txtDiaChi.Text = hoaDon.DiaChiGiaoHang;
            txtTileGiamGia.Text = hoaDon.TiLeGiamGia.ToString();
            cboTrangThaiThanhToan.SelectedItem = hoaDon.TrangThaiThanhToan;
            txtDienThoai.Text = hoaDon.DienThoaiNguoiNhan;
            txtNguoiLap.Text = hoaDon.NguoiLapHoaDon;


        }
        private void frmSua_Load(object sender, EventArgs e)
        {
            printHoaDon();
        }

        private void getValueTextBoxes()
        {
            hoaDon.TenNguoiNhan = txtTenNguoiNhan.Text;
            hoaDon.NgayGiaoHang = dtpNgayGiaoHang.Value;
            hoaDon.DiaChiGiaoHang = txtDiaChi.Text;
            hoaDon.TiLeGiamGia = float.Parse(txtTileGiamGia.Text);
            hoaDon.TrangThaiThanhToan = cboTrangThaiThanhToan.SelectedItem.ToString();
            hoaDon.DienThoaiNguoiNhan = txtDienThoai.Text;
            hoaDon.NguoiLapHoaDon = txtNguoiLap.Text;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                getValueTextBoxes();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("spHoaDon_Update", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@PK_iHoadonID", hoaDon.MaHoaDon);
                        sqlCommand.Parameters.AddWithValue("@tNgaylap", hoaDon.NgayLap);
                        sqlCommand.Parameters.AddWithValue("@tNgayGiaoHang", hoaDon.NgayGiaoHang);
                        sqlCommand.Parameters.AddWithValue("@sTennguoinhan", hoaDon.TenNguoiNhan);
                        sqlCommand.Parameters.AddWithValue("@sDiachigiaohang", hoaDon.DiaChiGiaoHang);
                        sqlCommand.Parameters.AddWithValue("@sDienthoaiNguoinhan", hoaDon.DienThoaiNguoiNhan);
                        if (hoaDon.TrangThaiThanhToan.Equals("đã thanh toán"))
                        {
                            sqlCommand.Parameters.AddWithValue("@bDathanhtoan", true);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@bDathanhtoan", false);
                        }
                        sqlCommand.Parameters.AddWithValue("@sNguoilapHoadon", hoaDon.NguoiLapHoaDon);
                        sqlCommand.Parameters.AddWithValue("@fTileGiamgia", hoaDon.TiLeGiamGia);


                        int n = sqlCommand.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("cập nhật thành công");
                            this.Close();
                            frmMain frmMain = new frmMain();
                            frmMain.Show();
                        }
                        else
                        {
                            MessageBox.Show("cập nhật thất bại");
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

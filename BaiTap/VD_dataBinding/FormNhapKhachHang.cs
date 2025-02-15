using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace VD_dataBinding
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }


        private DataTable getKhachHang()
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("spKhachHang_Get", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable tbl = new DataTable("tblKhachHang");
                            adapter.Fill(tbl);
                            return tbl;
                        }
                    }
                    cnn.Close();
                }//cnn
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }


        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable t = getKhachHang();
            addKhachHang(t);
            if (updateKhachHangForDB(t))
            {
                FormDanhSachKhachHang frmDanhSachKhachHang = new FormDanhSachKhachHang();
                frmDanhSachKhachHang.Show();
            }
            
        }

        private void addKhachHang(DataTable tblKhachHang)
        {
            DataRow row = tblKhachHang.NewRow();
            row["sHoten"] = txtHoTen.Text;
            row["sDiaChi"] = txtDiaChi.Text;
            row["sDienThoai"] = txtDienThoai.Text;
            if (radNam.Checked)
            {
                row["bGioiTinh"] = 0;

            }
            else
            {
                row["bGioiTinh"] = 1;
            }
            row["tNgaySinh"] = dtpNgaySinh.Value;
            row["sTenCoQuan"] = txtCoQuan.Text;
            tblKhachHang.Rows.Add(row);
        }

        private bool updateKhachHangForDB(DataTable tblKhachHang)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand insertCommand = new SqlCommand("spKhachHang_Insert", conn))
                    {
                        insertCommand.CommandType = CommandType.StoredProcedure;
                        insertCommand.Parameters.Add(new SqlParameter("@sHoten", SqlDbType.NVarChar, 50)).SourceColumn = "sHoten";
                        insertCommand.Parameters.Add(new SqlParameter("@sDiachi", SqlDbType.NVarChar, 200)).SourceColumn = "sDiachi";
                        insertCommand.Parameters.Add(new SqlParameter("@sDienthoai", SqlDbType.NVarChar, 12)).SourceColumn = "sDienthoai";
                        insertCommand.Parameters.Add(new SqlParameter("@sTencoquan", SqlDbType.NVarChar, 100)).SourceColumn = "sTencoquan";
                        insertCommand.Parameters.Add(new SqlParameter("@bGioitinh", SqlDbType.Bit)).SourceColumn = "bGioitinh";
                        insertCommand.Parameters.Add(new SqlParameter("@tNgaysinh", SqlDbType.DateTime)).SourceColumn = "tNgaysinh";

                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.InsertCommand = insertCommand;
                            DataTable tableToBeInsert = tblKhachHang.GetChanges(DataRowState.Added);
                            adapter.Update(tableToBeInsert);
                            if (!tableToBeInsert.HasErrors)
                            {
                                tblKhachHang.AcceptChanges();
                                return true;
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool isSo(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                    return false;
            }
            return true;
        }

        private void checkInput()
        {
            bool isCheck = true;

            //ho ten
            if (txtHoTen.Text == "")
            {
                errorProvider1.SetError(txtHoTen, "tên không được để trống");
                isCheck = false;
            }
            else
                errorProvider1.SetError(txtHoTen, "");

            //ngay sinh
            if (dtpNgaySinh.Value >= DateTime.Now)
            {
                errorProvider1.SetError(dtpNgaySinh, "ngày sinh phải nhỏ hơn ngày hôm nay");
                isCheck = false;
            }
            else
                errorProvider1.SetError(dtpNgaySinh, "");

            //sdt
            if (txtDienThoai.Text.Length <= 12 && txtDienThoai.Text.Length >= 10 && isSo(txtDienThoai.Text) == true)
                errorProvider1.SetError(txtDienThoai, "");
            else
            {
                errorProvider1.SetError(txtDienThoai, "số điện thoại phải từ 10-12 số và không chứa kí tự khác số.");
                isCheck = false;
            }

            //gioi tinh
            if (radNam.Checked == false && radNu.Checked == false)
            {
                errorProvider1.SetError(radNam, "bạn chưa chọn giới tính");
                errorProvider1.SetError(radNu, "bạn chưa chọn giới tính");
                isCheck = false;
            }
            else
            {
                errorProvider1.SetError(radNam, "");
                errorProvider1.SetError(radNu, "");
            }

            //co quan
            if (txtCoQuan.Text.Length > 100)
            {
                errorProvider1.SetError(txtCoQuan, "không đc quá 100 kí tự");
                isCheck = false;
            }
            else
                errorProvider1.SetError(txtCoQuan, "");

            if (isCheck)
                btnLuu.Enabled = isCheck;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {
            checkInput();

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            checkInput();

        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            checkInput();

        }

        private void txtCoQuan_TextChanged(object sender, EventArgs e)
        {
            checkInput();

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            checkInput();

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            checkInput();

        }
    }
}

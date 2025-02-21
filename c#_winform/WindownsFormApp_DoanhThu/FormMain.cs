namespace WindownsFormApp_DoanhThu
{
    public partial class frmDoanhThuCLB : Form
    {
        public frmDoanhThuCLB()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        QuanLyDoanhThu doanhThu;
        private void frmDoanhThuCLB_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("select * from CLB");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //sk: user chọn tên sẽ hiện giá vé và tên nước
        private void cboTenCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenCLB.SelectedIndex == 0)
            {
                txtGiaVe.Text = "10";
                txtTenNuoc.Text = "ANH";
            }
            if (cboTenCLB.SelectedIndex == 1)
            {
                txtGiaVe.Text = "12";
                txtTenNuoc.Text = "PHÁP";
            }
            if (cboTenCLB.SelectedIndex == 2)
            {
                txtGiaVe.Text = "10";
                txtTenNuoc.Text = "TÂY BAN NHA";
            }
            if (cboTenCLB.SelectedIndex == 3)
            {
                txtGiaVe.Text = "7";
                txtTenNuoc.Text = "BỒ ĐÀO NHA";
            }
            if (cboTenCLB.SelectedIndex == 4)
            {
                txtGiaVe.Text = "12";
                txtTenNuoc.Text = "Ý";
            }
            if (cboTenCLB.SelectedIndex == 5)
            {
                txtGiaVe.Text = "17";
                txtTenNuoc.Text = "ĐỨC";
            }
        }

        //sự kiện: k cho user nhập chữ
        private void txtSoLuongVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) //isControl: cho phep user thao tac nhu xoa
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DeleteTextBoxes()
        {
            cboTenCLB.SelectedIndex = -1;
            txtTenNuoc.Text = "";
            txtGiaVe.Text = "";
            txtSoLuongVe.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (cboTenCLB.SelectedIndex == -1) { MessageBox.Show("Mời bạn chọn tên CLB"); return false; }
            if (txtSoLuongVe.Text == "") { MessageBox.Show("mời bạn nhập số lượng vé"); return false; }
            return true;
        }

        //lấy các dữ liệu của các textbox và chuyền về đối tượng
        private void GetValuesTextBoxes()
        {
            string _tenCLB = cboTenCLB.Text;
            string _tenNuoc = txtTenNuoc.Text;
            int _soLuongVe = int.Parse(txtSoLuongVe.Text);
            double _giaVe = double.Parse(txtGiaVe.Text);
            doanhThu = new QuanLyDoanhThu(_tenCLB, _tenNuoc, _soLuongVe, _giaVe);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "INSERT INTO CLB VALUES(N'" + doanhThu.TenCLB + "', N'" + doanhThu.TenNuoc + "', " + doanhThu.SoLuongVe + ", " + doanhThu.GiaVe + ", " + doanhThu.DoanhThu() + ") ";
                try
                {
                    modify.Command(query);
                    MessageBox.Show("Thêm thành công");
                    frmDoanhThuCLB_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtTenCLB_TextChanged(object sender, EventArgs e)
        {
            string name = txtTenCLB.Text.Trim();
            if (txtTenCLB.Text == "")
                frmDoanhThuCLB_Load(sender, e);
            else
            {
                string query = "select * from CLB where TenCauLacBo like '%" + name + "%'";
                dataGridView1.DataSource = modify.Table(query);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (CheckTextBoxes())
            //{
            //    GetValuesTextBoxes();
            //    string query = "UPDATE CLB SET " + doanhThu.TenCLB + "', N'" + doanhThu.TenNuoc + "', " + doanhThu.SoLuongVe + ", " + doanhThu.GiaVe + ", " + doanhThu.DoanhThu() + ") ";
            //    try
            //    {
            //        modify.Command(query);
            //        MessageBox.Show("Thêm thành công");
            //        frmDoanhThuCLB_Load(sender, e);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                cboTenCLB.SelectedItem = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtTenNuoc.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtSoLuongVe.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtGiaVe.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}

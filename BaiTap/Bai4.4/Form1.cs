using System.Text;

namespace Bai4._4
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private KhachHang khachHang;
        private Modify modify = new Modify();
        private void GetValuesTextBoxes()
        {
            string _tenKH = txtHoTen.Text;
            string _diaChi = txtDiaChi.Text;
            string _soDienThoai = txtSoDienThoai.Text;
            int _gioiTinh = 1;
            if (radNam.Checked == true) _gioiTinh = 1;
            if (radNu.Checked == true) _gioiTinh = 0;
            DateTime _ngaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
            string _tenCoQuan = txtTenCoQuan.Text;
            khachHang = new KhachHang(_tenKH, _diaChi, _soDienThoai, _gioiTinh, _ngaySinh, _tenCoQuan);
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            GetValuesTextBoxes();
                modify.addKhachHang(khachHang);
                frmKhachHang_Load(sender, e);



        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = modify.Table("spKhachHang_Get");
            btnCapNhat.Visible = false;
            btnCapNhat.Enabled = false;
            btnNhap.Visible = true;
            btnNhap.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            GetValuesTextBoxes();

            param["sHoten"] = khachHang.TenKH;
            param["sDiachi"] = khachHang.DiaChi;
            param["sDienthoai"] = khachHang.SoDienThoai;
            param["bGioitinh"] = khachHang.GioiTinh;
            param["sTencoquan"] = khachHang.TenCoQuan;
            param["tNgaysinh"] = dtpNgaySinh.Value.ToString("yyyy/MM/dd");

            dgvKhachHang.DataSource = modify.findAll(param);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dgvKhachHang.SelectedRows[0];
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                StringBuilder s = new StringBuilder("");
                for (int i = 0; i < dgvKhachHang.SelectedRows.Count; ++i)
                {
                    int id = (int)dgvKhachHang.SelectedRows[i].Cells[0].Value;
                    bool isDeleted = modify.removeById(id);
                    if (!isDeleted) MessageBox.Show("chưa xóa được khách hàng có mã: " + id);
                    else s.Append(", " + id);
                }
                MessageBox.Show("xóa thành công khách hàng có id là: " + s.ToString());
                frmKhachHang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("bạn chưa chọn khách hàng để xóa");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtTenCoQuan.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                try
                {
                    txtHoTen.Text = dgvKhachHang.SelectedRows[0].Cells[1].Value.ToString();
                    txtDiaChi.Text = dgvKhachHang.SelectedRows[0].Cells[2].Value.ToString();
                    txtSoDienThoai.Text = dgvKhachHang.SelectedRows[0].Cells[3].Value.ToString();
                    bool bit = bool.Parse(dgvKhachHang.SelectedRows[0].Cells[4].Value.ToString());
                    if (bit == true)
                    {
                        radNu.Checked = true;
                        radNam.Checked = false;
                    }
                    else
                    {
                        radNam.Checked = true;
                        radNu.Checked = false;
                    }
                    dtpNgaySinh.Value = DateTime.Parse(dgvKhachHang.SelectedRows[0].Cells[5].Value.ToString());
                    txtTenCoQuan.Text = dgvKhachHang.SelectedRows[0].Cells[6].Value.ToString();

                    //hiện btn cập nhật và ẩn btn nhập
                    btnNhap.Visible = false;
                    btnNhap.Enabled = false;
                    btnCapNhat.Visible = true;
                    btnCapNhat.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("bạn chưa chọn khách hàng để sửa");
            }
        }

        //btn cap nhat
        private void button1_Click(object sender, EventArgs e)
        {
            GetValuesTextBoxes();
            khachHang.MaKH = int.Parse(dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString());


            modify.update(khachHang);
            frmKhachHang_Load(sender, e);
            btnNhap.Enabled = true;
            btnNhap.Visible = true;
            btnCapNhat.Enabled = false;
            btnCapNhat.Visible = false;
        }
    }
}

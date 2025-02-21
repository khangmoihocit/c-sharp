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
            int _gioiTinh = 0;
            if (radNam.Checked == true) _gioiTinh = 1;
            if (radNu.Checked == false) _gioiTinh = 0;
            DateTime _ngaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
            string _tenCoQuan = txtTenCoQuan.Text;
            khachHang = new KhachHang(_tenKH, _diaChi, _soDienThoai, _gioiTinh, _ngaySinh, _tenCoQuan);
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            GetValuesTextBoxes();
            khachHang.MaKH = int.Parse(dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString());
            if (btnNhap.Text == "Nhập")
            {
                modify.addKhachHang(khachHang);
                    frmKhachHang_Load(sender, e);
            }
            if(btnNhap.Text == "Cập nhật")
            {
                modify.update(khachHang);
                frmKhachHang_Load(sender, e);
            }


        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = modify.Table("spKhachHang_Get");
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
            param["tNgaysinh"] = khachHang.NgaySinh;

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
                    btnNhap.Text = "Cập nhập";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("bạn chưa chọn khách hàng để sửa");
            }
        }
    }
}

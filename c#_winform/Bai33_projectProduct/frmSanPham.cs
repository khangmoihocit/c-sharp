namespace Bai33_projectProduct
{
    public partial class frmSanPham : Form
    {
        public static List<DanhMuc> danhSachDanhMuc = new List<DanhMuc>();
        private static List<SanPham> danhSachSanPham = new List<SanPham>();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDM = new frmDanhMuc();
            frmDanhMuc.CoThayDoi = false;

            //neu co su thay doi trong form danh muc se cap nhap lai de hien thi
            if (frmDM.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhMucLenComboBox();
            }
        }

        private void HienThiDanhMucLenComboBox()
        {
            cboDanhMuc.Items.Clear();
            danhSachDanhMuc.ForEach(item =>
            {
                cboDanhMuc.Items.Add(item);
            });
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn danh mục");
                return;
            }

            DanhMuc danhMuc = cboDanhMuc.SelectedItem as DanhMuc;
            SanPham sanPham = new SanPham();

            sanPham.MaSP = txtMaSP.Text;
            sanPham.TenSP = txtTenSP.Text;
            sanPham.DonGia = Double.Parse(txtDonGia.Text);
            sanPham.XuatXu = txtXuatXu.Text;
            sanPham.HanDung = dtpHanDung.Value;
            sanPham.danhMuc = danhMuc;

            danhMuc.ThemSanPham(sanPham);
            danhSachSanPham.Add(sanPham);
            HienThiSanPhamLenGiaoDien();
            ClearTextSanPham();
        }

        private void HienThiSanPhamLenGiaoDien()
        {
            lstSanPham.Items.Clear();
            danhSachSanPham.ForEach(item => lstSanPham.Items.Add(item));
        }

        private void ClearTextSanPham()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            txtXuatXu.Text = "";
            txtMaSP.Focus();
        }

        private void lstSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSanPham.SelectedIndex == -1)
                return;
            SanPham sanPham = lstSanPham.SelectedItem as SanPham;
            cboDanhMuc.SelectedItem = sanPham.danhMuc;
            txtMaSP.Text = sanPham.MaSP;
            txtTenSP.Text = sanPham.TenSP;
            txtDonGia.Text = sanPham.DonGia + "";
            txtXuatXu.Text = sanPham.XuatXu;
            dtpHanDung.Value = sanPham.HanDung;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lstSanPham.SelectedIndex != -1)
            {
                SanPham sanPham = lstSanPham.SelectedItem as SanPham ;
                DialogResult re = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm " + sanPham.TenSP + " không?",
                    "Hỏi xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if(re == DialogResult.Yes && sanPham != null)
                {
                    lstSanPham.Items.Remove(sanPham);
                    danhSachSanPham.Remove(sanPham);
                    ClearTextSanPham();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm để xóa!");
            }
        }
    }
}

namespace Bai31_combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string detail = "";
            detail = "Thông tin khách hàng: ";
            detail += "\nHọ và tên: " + txtTen.Text;
            detail += "\nSố điện thoại: " + txtSoDienThoai.Text;
            detail += "\nSản phẩm đặt: \n" + getInfoSanPham();
            detail += "\nPhương thức thanh toán: " + cboPhuongThucThanhToan2.SelectedItem;
            lblThongTinCTDH.Text = detail;
        }

        private string getInfoSanPham()
        {
            string s = "";
            for (int i = 0; i < lstSanPham.SelectedItems.Count; ++i)
            {
                s += (string)lstSanPham.SelectedItems[i];
                s += "\n";
            }

            return s;
        }

        private void cboPhuongThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhuongThucThanhToan.SelectedIndex != -1)
            {
                MessageBox.Show("Bạn đã chọn thanh toán bằng: " + cboPhuongThucThanhToan.SelectedItem);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát không?"
                , "Xác nhận thoát"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);

            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PhuongThucThanhToan atm = new PhuongThucThanhToan();
            atm.Id = 1;
            atm.Name = "ATM";
            atm.phi = 0;

            PhuongThucThanhToan tructiep = new PhuongThucThanhToan();
            tructiep.Id = 2;
            tructiep.Name = "Thanh toán tại cửa hàng";
            tructiep.phi = 10;

            PhuongThucThanhToan trasau = new PhuongThucThanhToan();
            trasau.Id = 3;
            trasau.Name = "Nhận hàng rồi thanh toán";
            trasau.phi = 20;

            cboPhuongThucThanhToan2.Items.Add(atm);
            cboPhuongThucThanhToan2.Items.Add(tructiep);
            cboPhuongThucThanhToan2.Items.Add(trasau);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhuongThucThanhToan2.SelectedIndex != -1)
            {
                PhuongThucThanhToan phuongThucThanhToan = cboPhuongThucThanhToan2.SelectedItem as PhuongThucThanhToan;
                MessageBox.Show("Bạn vừa chọn thanh toán bằng: " + phuongThucThanhToan.Name + "\nPhí: " + phuongThucThanhToan.phi);
            }
        }
    }
}

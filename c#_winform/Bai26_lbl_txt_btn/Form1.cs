namespace Bai26_lbl_txt_btn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void btnThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("bạn có muốn thoát chương trình không?"
                , "HỎI THOÁT"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Error);

            if(re == DialogResult.Yes)
                this.Close();
        }
    }
}

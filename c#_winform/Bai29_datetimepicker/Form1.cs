namespace Bai29_datetimepicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTen, "");
            errorProvider1.SetError(txtTuoi, "");

            if (txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Tên không thể để rỗng.");
                return;
            }

            int tuoi = 0;
            if (int.TryParse(txtTuoi.Text, out tuoi))
            {
                if (tuoi < 18)
                {
                    errorProvider1.SetError(txtTuoi, "tuổi phải lớn hơn 17.");
                    return;
                }
            }
            else
            {
                errorProvider1.SetError(txtTuoi, "tuổi không hợp lệ.");
                return;
            }

            if (dtpNgayDangKy.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                errorProvider1.SetError(dtpNgayDangKy, "không thể đăng ký ngày chủ nhật");
                return;
            }
            MessageBox.Show("Bạn đã đăng ký thành công");
        }

        private void lblNgayDangKy_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

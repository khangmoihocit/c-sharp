namespace VD_5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtB, "");
            try
            {
                float b = float.Parse(txtB.Text);
                if (b == 0)
                {
                    errorProvider1.SetError(txtB, "Số chia phải khác 0");
                    return;
                }
                float thuong = float.Parse(txtA.Text) / b;
                txtKetQua.Text = thuong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "có lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace Bai3._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mniThoat_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát chương trình không?",
                "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mniBai32_Click(object sender, EventArgs e)
        {
            Bai3_2Form frm = new Bai3_2Form();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void mniCalc_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.MdiParent = this;
            calculatorForm.Show();
        }
    }
}

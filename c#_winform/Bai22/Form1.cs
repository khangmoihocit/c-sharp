namespace Bai22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            DialogResult res = MessageBox.Show("Bạn có muốn thoát không?"
                , "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Text = "ban chon yes";
            }else if(res == DialogResult.No){
                this.Text = "ban chon no";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("day la noi dung canh bao", "canh bao", MessageBoxButtons.OK
                , MessageBoxIcon.Error);
        }
    }
}

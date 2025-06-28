using GUI;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report rp = new report();

            rp.showReport();
            rp.Show();
        }
    }
}

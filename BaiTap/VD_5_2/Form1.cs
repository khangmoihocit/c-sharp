namespace VD_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDuLieu_TextChanged(object sender, EventArgs e)
        {
            lblLength.Text = txtDuLieu.TextLength.ToString();
            btnSayIt.Enabled = (txtDuLieu.Text.Trim().Length > 0);
        }

        private void btnSayIt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello" + txtDuLieu.Text, "say it");
        }
    }
}

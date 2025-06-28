namespace VD_5_6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomListItem clt = new CustomListItem();
            clt.Text = txtText.Text;
            clt.Value = txtValue.Text;
            listBox1.Items.Add(clt);

            txtText.Text = txtValue.Text = string.Empty;
            txtText.Focus();
        }
    }
}

namespace Bai28_PictureBox
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcOff.Visible = false;
            pcOn.Visible = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (pcOn.Visible == true)
            {
                btnOnorOff.Text = txtName.Text + " .Turn off the light, please!";
            }
            else
            {
                btnOnorOff.Text = txtName.Text + " .Turn on the light, please!";
            }

        }

        private void btnOnorOff_Click(object sender, EventArgs e)
        {
            if (pcOn.Visible == true)
            {
                pcOn.Visible = false;
                pcOff.Visible = true;
                btnOnorOff.Text = btnOnorOff.Text.Replace("off", "on");
            }
            else
            {
                pcOn.Visible = true;
                pcOff.Visible = false;
                btnOnorOff.Text = btnOnorOff.Text.Replace("on", "off");

            }
        }

        private void pcOn_Click(object sender, EventArgs e)
        {

        }
    }
}

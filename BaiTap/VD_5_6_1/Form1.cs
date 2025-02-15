namespace VD_5_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = string.Format("index:{0}; selected item:\"{1})\";",
                comboBox1.SelectedIndex,
                comboBox1.SelectedItem);
        }
    }
}

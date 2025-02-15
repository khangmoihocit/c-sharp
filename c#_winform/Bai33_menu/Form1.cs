namespace Bai33_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sourceControl: cho biet button nao dang dcuo an chuot phai
            //chỉ cần 1 sourcecontrol sẽ áp dụng cho tất cả button
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Random rd = new Random();
            for(int i = 0; i< 10; i++)
            {
                Button btn = new Button();
                btn.Text = rd.Next(100) + "";
                flowLayoutPanel1.Controls.Add(btn);
                btn.ContextMenuStrip = contextMenuStrip1;
            }

        }
    }
}

namespace Bai37_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvt = lvSanPham.SelectedItems[0];
                string maSP = lvt.SubItems[0].Text;
                string tenSP = lvt.SubItems[1].Text;
                int giaSP = int.Parse(lvt.SubItems[2].Text);
                //MessageBox.Show(maSP + " - " + tenSP + " - " + giaSP);
                txtMaSP.Text = maSP;
                txtTenSP.Text = tenSP;
                txtGiaSP.Text = giaSP + "";
            }
        }

        private void lvSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != 1)
            {
                ColumnHeader col = lvSanPham.Columns[e.Column];
                MessageBox.Show("ban vua click cot: " + col.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearTextBox()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaSP.Text = "";
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            ListViewItem lvt = new ListViewItem(txtMaSP.Text);
            lvt.SubItems.Add(txtTenSP.Text);
            lvt.SubItems.Add(txtGiaSP.Text);
            lvSanPham.Items.Add(lvt);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                lvSanPham.Items.Remove(lvSanPham.SelectedItems[0]);
                ClearTextBox();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvt = lvSanPham.SelectedItems[0];
                lvt.SubItems[0].Text = txtMaSP.Text;
                lvt.SubItems[1].Text = txtTenSP.Text;
                lvt.SubItems[2].Text = txtGiaSP.Text;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

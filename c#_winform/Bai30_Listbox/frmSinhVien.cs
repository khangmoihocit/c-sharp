using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai30_Listbox
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSV.Text == "") throw new Exception("tên sinh viên  không được rỗng");

                lstLopA.Items.Add(txtTenSV.Text);
                txtTenSV.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("loi");
            }
        }

        private void btnPhai1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopA.SelectedItems.Count; i++)
            {
                string tmp = (string)lstLopA.SelectedItems[i];
                lstLopB.Items.Add(tmp);
            }
        }

        private void btnTrai1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopB.SelectedItems.Count; i++)
            {
                string tmp = (string)lstLopB.SelectedItems[i];
                lstLopA.Items.Add(tmp);
            }
        }

        private void btnPhai2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopA.Items.Count; i++)
            {
                string tmp = (string)(lstLopA.Items[i]);
                lstLopB.Items.Add(tmp);
            }
        }

        private void btnTrai2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopB.Items.Count; i++)
            {
                string tmp = (string)(lstLopB.Items[i]);
                lstLopA.Items.Add(tmp);
            }
        }

        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            lstLopA.Items.Clear();
        }

        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            lstLopB.Items.Clear();

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {

        }
    }
}

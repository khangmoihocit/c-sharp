using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai27_checkbox_rad
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhapTen.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //event khi txt thay đổi, thì chương trình cũng thay đổi theo code xử lý
        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.Text = txtNhapTen.Text;

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblLapTrinhBoi.ForeColor = radRed.ForeColor;

            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
                lblLapTrinhBoi.ForeColor = radGreen.ForeColor;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
                lblLapTrinhBoi.ForeColor = radBlue.ForeColor;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
                lblLapTrinhBoi.ForeColor = radBlack.ForeColor;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.Font = new Font(
                lblLapTrinhBoi.Font.Name,
                lblLapTrinhBoi.Font.Size,
                lblLapTrinhBoi.Font.Style ^ FontStyle.Bold
                );
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.Font = new Font(
                lblLapTrinhBoi.Font.Name,
                lblLapTrinhBoi.Font.Size,
                lblLapTrinhBoi.Font.Style ^ FontStyle.Italic
                );
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.Font = new Font(
                lblLapTrinhBoi.Font.Name,
                lblLapTrinhBoi.Font.Size,
                lblLapTrinhBoi.Font.Style ^ FontStyle.Underline
                );
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Bạn có chắc muốn thoát không?",
                "hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dresult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

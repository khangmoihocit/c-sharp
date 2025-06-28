using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            ganEvents();
        }

        //sự kiện khi ấn vào các số và toán tử
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (lblManHinh.Text == "0")
            {
                lblManHinh.Text = btn.Text;
            }
            else
            {
                lblManHinh.Text += btn.Text;
            }
        }

        //gán sự kiện cho các button
        private void ganEvents()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn && isSo_ToanTu(btn.Text))
                {
                    btn.Click += Button_Click;
                }
            }
        }

        private bool isSo_ToanTu(string s)
        {
            if (s == "+" || s == "-" || s == "*" || s == "/" || Char.IsDigit(s[0]))
                return true;

            return false;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                var result = dt.Compute(lblManHinh.Text, null);
                lblKetQua.Text = lblManHinh.Text;
                lblKetQua.Text += " = \n" + result.ToString();
                lblManHinh.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string s = lblManHinh.Text.ToString();
            try
            {
                if (s.Length > 0)
                    s = s.Remove(s.Length - 1, 1);
                else
                    lblManHinh.Text = "";

                lblManHinh.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            lblManHinh.Text = "";
        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1
{
    public partial class Bai3_2Form : Form
    {
        public Bai3_2Form()
        {
            InitializeComponent();
        }
 
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            string s = txtInput.Text;
            char[] arr = s.ToCharArray();
            string number = "";
            string alphabets = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsDigit(arr[i]))
                {
                    number += arr[i];
                }
                else if (Char.IsLetter(arr[i]))
                {
                    alphabets += arr[i];
                }
            }

            lblAlphabets.Text = number;
            lblNumbers.Text = alphabets;

        }
    }
}

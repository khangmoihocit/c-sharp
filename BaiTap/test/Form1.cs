using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace test
{
	public partial class Form1: Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			TestReport frm = new TestReport();
            string dieukienlockhachhang = "";

            if(!string.IsNullOrEmpty(txtDiaChi.Text))
                dieukienlockhachhang = "{tblKhachHang.sDiaChi} like '%" + txtDiaChi.Text.Replace("'", "''") + "%' ";


            if (radNam.Checked == true) dieukienlockhachhang += " and {tblKhachHang.bGioiTinh} = " + false;
            else if (radNu.Checked == true) dieukienlockhachhang += " and {tblKhachHang.bGioiTinh} = " + true;
            else
                dieukienlockhachhang += "";


            frm.showReport(@"D:\C#\BaiTap\test\CrystalReport1.rpt", "Báo cáo khách hàng", dieukienlockhachhang);
			frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



}

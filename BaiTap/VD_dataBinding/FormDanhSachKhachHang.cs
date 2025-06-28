﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace VD_dataBinding
{
    public partial class FormDanhSachKhachHang : Form
    {
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
        }
        private DataSet getKhachHang()
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["btvn"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from v_KhachHang", cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataSet dskh = new DataSet();
                            adapter.Fill(dskh);
                            return dskh;
                        }
                    }
                    cnn.Close();
                }//cnn
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {

            dgvKhachHang.DataSource = getKhachHang().Tables[0];

        }



    }
}

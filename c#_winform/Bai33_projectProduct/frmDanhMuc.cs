using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai33_projectProduct
{
    public partial class frmDanhMuc : Form
    {
        public static bool CoThayDoi = false;

        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DanhMuc danhMuc = new DanhMuc();
            danhMuc.MaDM = txtMaDM.Text;
            danhMuc.TenDM = txtTenDM.Text;

            if (!danhMuc.MaDM.Equals("") && !danhMuc.TenDM.Equals(""))
                if (!ContainMaDM(frmSanPham.danhSachDanhMuc, danhMuc.MaDM))
                    frmSanPham.danhSachDanhMuc.Add(danhMuc);

            HienThiDanhMucLenListBox();
            ClearTextDanhMuc();
            CoThayDoi = true;
        }

        private bool ContainMaDM(List<DanhMuc> listDanhMuc, string maDM)
        {
            foreach (DanhMuc item in listDanhMuc)
            {
                if (item.MaDM.Equals(maDM))
                    return true;
            }
            return false;
        }


        private void ClearTextDanhMuc()
        {
            txtMaDM.Text = "";
            txtTenDM.Text = "";
        }

        private void HienThiDanhMucLenListBox()
        {
            lstDanhMuc.Items.Clear();
            frmSanPham.danhSachDanhMuc.ForEach(item => lstDanhMuc.Items.Add(item));
        }

        private void lstDanhMauc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc danhMuc = lstDanhMuc.SelectedItem as DanhMuc;
                txtMaDM.Text = danhMuc.MaDM;
                txtTenDM.Text = danhMuc.TenDM;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc danhMuc = lstDanhMuc.SelectedItem as DanhMuc;
                if (danhMuc != null)
                {
                    frmSanPham.danhSachDanhMuc.Remove(danhMuc);
                    lstDanhMuc.Items.Remove(danhMuc);
                    ClearTextDanhMuc();
                    CoThayDoi = true;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(CoThayDoi == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}

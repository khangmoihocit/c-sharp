namespace Bai30_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhapSo.Text == "") throw new Exception("không được để nhập số rỗng");

                int x = int.Parse(txtNhapSo.Text);

                lstLop.Items.Add(x);
                txtNhapSo.Text = "";

            }
            catch (FormatException ex)
            {
                errorProvider1.SetError(txtNhapSo, ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoaDauVaCuoi_Click(object sender, EventArgs e)
        {
            if (lstLop.Items.Count > 0)
            {
                lstLop.Items.RemoveAt(0);
            }
            if (lstLop.Items.Count > 0)
            {
                lstLop.Items.RemoveAt(lstLop.Items.Count - 1);
            }

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lstLop.Items.Count; i++)
            {
                int x = (int)lstLop.Items[i];
                sum += x;
            }

            MessageBox.Show("tổng các phần tử là: " + sum);
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            //ktra user có đang chọn hay không
            //if(lstLop.SelectedIndex != -1)
            //{
            //    lstLop.Items.RemoveAt((int)lstLop.SelectedIndex);
            //}

            //trong khi vẫn còn đang chọn, thì vẫn lặp xóa phần tử thứ 0
            while (lstLop.SelectedIndices.Count > 0)
            {
                lstLop.Items.RemoveAt(lstLop.SelectedIndices[0]);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLop.Items.Count; ++i)
            {
                lstLop.Items[i] = CongHaiSo((int)lstLop.Items[i], 2);
            }
        }



        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLop.Items.Count; ++i)
            {
                int x = (int)lstLop.Items[i];
                lstLop.Items[i] = NhanHaiSo(x, x);
            }
        }

        private int CongHaiSo(int a, int b) => a + b;
        private long NhanHaiSo(int a, int b) => (long)a * b;

        private void btnSoChan_Click(object sender, EventArgs e)
        {
            lstLop.SelectedIndex = -1;
            for (int i = 0; i < lstLop.Items.Count; i++)
            {
                int tmp = (int)lstLop.Items[i];
                if (tmp % 2 == 0)
                    lstLop.SelectedIndex = i;
            }
        }

        private void btnSoLe_Click(object sender, EventArgs e)
        {
            lstLop.SelectedIndex = -1;
            for (int i = 0; i < lstLop.Items.Count; i++)
            {
                int tmp = (int)lstLop.Items[i];
                if (tmp % 2 != 0)
                    lstLop.SelectedIndex = i;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

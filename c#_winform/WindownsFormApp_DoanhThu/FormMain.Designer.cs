namespace WindownsFormApp_DoanhThu
{
    partial class frmDoanhThuCLB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTenCLB = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtGiaVe = new TextBox();
            txtTenNuoc = new TextBox();
            txtSoLuongVe = new TextBox();
            cboTenCLB = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnThongKe = new Button();
            btnThoat = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(373, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(319, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản lý doanh thu CLB";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenCLB);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(16, 112);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(700, 122);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txtTenCLB
            // 
            txtTenCLB.Location = new Point(141, 45);
            txtTenCLB.Name = "txtTenCLB";
            txtTenCLB.Size = new Size(234, 34);
            txtTenCLB.TabIndex = 1;
            txtTenCLB.TextChanged += txtTenCLB_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(38, 45);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên CLB";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtGiaVe);
            groupBox2.Controls.Add(txtTenNuoc);
            groupBox2.Controls.Add(txtSoLuongVe);
            groupBox2.Controls.Add(cboTenCLB);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(724, 112);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(405, 615);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SandyBrown;
            btnXoa.ForeColor = SystemColors.ActiveCaptionText;
            btnXoa.Location = new Point(288, 443);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 43);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightCoral;
            btnSua.ForeColor = SystemColors.ActiveCaptionText;
            btnSua.Location = new Point(146, 443);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 43);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.RosyBrown;
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(7, 443);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 43);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Location = new Point(132, 156);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.ReadOnly = true;
            txtGiaVe.Size = new Size(266, 34);
            txtGiaVe.TabIndex = 2;
            // 
            // txtTenNuoc
            // 
            txtTenNuoc.Location = new Point(132, 237);
            txtTenNuoc.Name = "txtTenNuoc";
            txtTenNuoc.ReadOnly = true;
            txtTenNuoc.Size = new Size(266, 34);
            txtTenNuoc.TabIndex = 2;
            // 
            // txtSoLuongVe
            // 
            txtSoLuongVe.Location = new Point(132, 324);
            txtSoLuongVe.Name = "txtSoLuongVe";
            txtSoLuongVe.Size = new Size(266, 34);
            txtSoLuongVe.TabIndex = 2;
            txtSoLuongVe.KeyPress += txtSoLuongVe_KeyPress;
            // 
            // cboTenCLB
            // 
            cboTenCLB.FormattingEnabled = true;
            cboTenCLB.Items.AddRange(new object[] { "MANCHESTER", "PARISSG", "REALMADRIT", "BENFICA", "ACMILAN", "BARCELONA" });
            cboTenCLB.Location = new Point(132, 77);
            cboTenCLB.Name = "cboTenCLB";
            cboTenCLB.Size = new Size(266, 36);
            cboTenCLB.TabIndex = 1;
            cboTenCLB.SelectedIndexChanged += cboTenCLB_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(7, 333);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 0;
            label6.Text = "Số lượng vé";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(7, 243);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 0;
            label5.Text = "Tên nước";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(7, 162);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 0;
            label4.Text = "Giá vé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(7, 77);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 0;
            label3.Text = "Tên CLB";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 242);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(700, 485);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.DarkOrange;
            btnThongKe.ForeColor = SystemColors.ActiveCaptionText;
            btnThongKe.Location = new Point(917, 22);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(108, 43);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.PowderBlue;
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(1042, 22);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 43);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmDoanhThuCLB
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1141, 741);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(btnThongKe);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDoanhThuCLB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chương trình chính";
            Load += frmDoanhThuCLB_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtTenCLB;
        private ComboBox cboTenCLB;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtGiaVe;
        private TextBox txtTenNuoc;
        private TextBox txtSoLuongVe;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnThongKe;
        private Button btnThoat;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}

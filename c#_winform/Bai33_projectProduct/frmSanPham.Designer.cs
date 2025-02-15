namespace Bai33_projectProduct
{
    partial class frmSanPham
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            lstSanPham = new ListBox();
            panel3 = new Panel();
            palThongTinChiTiet = new Panel();
            dtpHanDung = new DateTimePicker();
            txtXuatXu = new TextBox();
            txtDonGia = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnDanhMuc = new Button();
            cboDanhMuc = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            palThongTinChiTiet.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 73);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1013, 73);
            label1.TabIndex = 0;
            label1.Text = "Chương trình quản lý sản phẩm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 569);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstSanPham);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 569);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // lstSanPham
            // 
            lstSanPham.Dock = DockStyle.Fill;
            lstSanPham.Font = new Font("Segoe UI", 12F);
            lstSanPham.FormattingEnabled = true;
            lstSanPham.ItemHeight = 28;
            lstSanPham.Location = new Point(3, 30);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.Size = new Size(419, 536);
            lstSanPham.TabIndex = 0;
            lstSanPham.SelectedIndexChanged += lstSanPham_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(palThongTinChiTiet);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(425, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(588, 569);
            panel3.TabIndex = 2;
            // 
            // palThongTinChiTiet
            // 
            palThongTinChiTiet.AutoSize = true;
            palThongTinChiTiet.Controls.Add(dtpHanDung);
            palThongTinChiTiet.Controls.Add(txtXuatXu);
            palThongTinChiTiet.Controls.Add(txtDonGia);
            palThongTinChiTiet.Controls.Add(txtTenSP);
            palThongTinChiTiet.Controls.Add(txtMaSP);
            palThongTinChiTiet.Controls.Add(btnThoat);
            palThongTinChiTiet.Controls.Add(btnXoa);
            palThongTinChiTiet.Controls.Add(btnLuu);
            palThongTinChiTiet.Controls.Add(btnDanhMuc);
            palThongTinChiTiet.Controls.Add(cboDanhMuc);
            palThongTinChiTiet.Controls.Add(label8);
            palThongTinChiTiet.Controls.Add(label7);
            palThongTinChiTiet.Controls.Add(label6);
            palThongTinChiTiet.Controls.Add(label5);
            palThongTinChiTiet.Controls.Add(label4);
            palThongTinChiTiet.Controls.Add(label3);
            palThongTinChiTiet.Controls.Add(label2);
            palThongTinChiTiet.Dock = DockStyle.Fill;
            palThongTinChiTiet.Location = new Point(0, 0);
            palThongTinChiTiet.Name = "palThongTinChiTiet";
            palThongTinChiTiet.Size = new Size(588, 569);
            palThongTinChiTiet.TabIndex = 0;
            // 
            // dtpHanDung
            // 
            dtpHanDung.Location = new Point(153, 428);
            dtpHanDung.Name = "dtpHanDung";
            dtpHanDung.Size = new Size(402, 27);
            dtpHanDung.TabIndex = 5;
            // 
            // txtXuatXu
            // 
            txtXuatXu.Location = new Point(153, 354);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(402, 27);
            txtXuatXu.TabIndex = 4;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(153, 269);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(402, 27);
            txtDonGia.TabIndex = 3;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(153, 200);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(402, 27);
            txtTenSP.TabIndex = 2;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(153, 123);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(402, 27);
            txtMaSP.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(392, 505);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(241, 505);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(103, 505);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Location = new Point(461, 57);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(94, 29);
            btnDanhMuc.TabIndex = 3;
            btnDanhMuc.Text = "...";
            btnDanhMuc.UseVisualStyleBackColor = true;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(153, 57);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(284, 28);
            cboDanhMuc.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.Location = new Point(27, 356);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 1;
            label8.Text = "Xuất xứ";
            label8.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(27, 428);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 1;
            label7.Text = "Hạn dùng";
            label7.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(27, 268);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 1;
            label6.Text = "Đơn giá";
            label6.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(27, 199);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 1;
            label5.Text = "Tên SP";
            label5.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(27, 125);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 1;
            label4.Text = "Mã SP";
            label4.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(27, 56);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 1;
            label3.Text = "Danh mục";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(27, 15);
            label2.Name = "label2";
            label2.Size = new Size(182, 32);
            label2.TabIndex = 0;
            label2.Text = "Thông tin chi tiết";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 642);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            palThongTinChiTiet.ResumeLayout(false);
            palThongTinChiTiet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private ListBox lstSanPham;
        private Panel panel3;
        private Panel palThongTinChiTiet;
        private Label label3;
        private Label label2;
        private Button btnDanhMuc;
        private ComboBox cboDanhMuc;
        private TextBox textBox5;
        private TextBox txtXuatXu;
        private TextBox txtDonGia;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Button btnLuu;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnThoat;
        private Button btnXoa;
        private DateTimePicker dtpHanDung;
    }
}

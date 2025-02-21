namespace Bai4._4
{
    partial class frmKhachHang
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
            txtHoTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDiaChi = new TextBox();
            txtTenCoQuan = new TextBox();
            txtSoDienThoai = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            radNam = new RadioButton();
            radNu = new RadioButton();
            dgvKhachHang = new DataGridView();
            btnNhap = new Button();
            btnBoQua = new Button();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 1;
            label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(208, 27);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(324, 34);
            txtHoTen.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 1;
            label2.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 172);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 254);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 1;
            label4.Text = "Tên cơ quan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(595, 27);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 1;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(566, 103);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 28);
            label6.TabIndex = 1;
            label6.Text = "Số điện thoại";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(208, 172);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(748, 34);
            txtDiaChi.TabIndex = 2;
            // 
            // txtTenCoQuan
            // 
            txtTenCoQuan.Location = new Point(208, 251);
            txtTenCoQuan.Name = "txtTenCoQuan";
            txtTenCoQuan.Size = new Size(748, 34);
            txtTenCoQuan.TabIndex = 2;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(725, 103);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(231, 34);
            txtSoDienThoai.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(725, 27);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(231, 34);
            dtpNgaySinh.TabIndex = 3;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(230, 105);
            radNam.Name = "radNam";
            radNam.Size = new Size(71, 32);
            radNam.TabIndex = 4;
            radNam.TabStop = true;
            radNam.Text = "nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(374, 105);
            radNu.Name = "radNu";
            radNu.Size = new Size(56, 32);
            radNu.TabIndex = 4;
            radNu.TabStop = true;
            radNu.Text = "nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Bottom;
            dgvKhachHang.Location = new Point(0, 408);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(989, 360);
            dgvKhachHang.TabIndex = 5;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(128, 315);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(116, 53);
            btnNhap.TabIndex = 6;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(303, 315);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(116, 53);
            btnBoQua.TabIndex = 6;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(479, 315);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 53);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(654, 315);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(116, 53);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(840, 315);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 53);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 768);
            Controls.Add(btnXoa);
            Controls.Add(btnTimKiem);
            Controls.Add(btnSua);
            Controls.Add(btnBoQua);
            Controls.Add(btnNhap);
            Controls.Add(dgvKhachHang);
            Controls.Add(radNu);
            Controls.Add(radNam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTenCoQuan);
            Controls.Add(txtDiaChi);
            Controls.Add(txtHoTen);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDiaChi;
        private TextBox txtTenCoQuan;
        private TextBox txtSoDienThoai;
        private DateTimePicker dtpNgaySinh;
        private RadioButton radNam;
        private RadioButton radNu;
        private DataGridView dgvKhachHang;
        private Button btnNhap;
        private Button btnBoQua;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnXoa;
    }
}

namespace Bai31_combobox
{
    partial class Form1
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
            label2 = new Label();
            lblTen = new Label();
            groupBox1 = new GroupBox();
            lstSanPham = new ListBox();
            label4 = new Label();
            btnDatHang = new Button();
            groupBox2 = new GroupBox();
            lblThongTinCTDH = new Label();
            cboPhuongThucThanhToan = new ComboBox();
            txtTen = new TextBox();
            txtSoDienThoai = new TextBox();
            btnThoat = new Button();
            cboPhuongThucThanhToan2 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Màn hình đặt hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 93);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "Số điện thoại";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(41, 51);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(32, 20);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstSanPham);
            groupBox1.Location = new Point(41, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 245);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // lstSanPham
            // 
            lstSanPham.Dock = DockStyle.Fill;
            lstSanPham.FormattingEnabled = true;
            lstSanPham.Items.AddRange(new object[] { "realme q5 pro", "samsung glaxy j7prime", "xiaomi note 13 pro", "iphone 14 promax" });
            lstSanPham.Location = new Point(3, 23);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.SelectionMode = SelectionMode.MultiSimple;
            lstSanPham.Size = new Size(227, 219);
            lstSanPham.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 392);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 2;
            label4.Text = "Phương thức thanh toán";
            // 
            // btnDatHang
            // 
            btnDatHang.Location = new Point(94, 509);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(115, 29);
            btnDatHang.TabIndex = 3;
            btnDatHang.Text = "Đặt hàng";
            btnDatHang.UseVisualStyleBackColor = true;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblThongTinCTDH);
            groupBox2.Location = new Point(331, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 295);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết đơn hàng";
            // 
            // lblThongTinCTDH
            // 
            lblThongTinCTDH.Dock = DockStyle.Fill;
            lblThongTinCTDH.Location = new Point(3, 23);
            lblThongTinCTDH.Name = "lblThongTinCTDH";
            lblThongTinCTDH.Size = new Size(223, 269);
            lblThongTinCTDH.TabIndex = 0;
            // 
            // cboPhuongThucThanhToan
            // 
            cboPhuongThucThanhToan.FormattingEnabled = true;
            cboPhuongThucThanhToan.Items.AddRange(new object[] { "ATM", "Gửi tiền tại cửa hàng", "Gửi tiền sau khi nhận hàng" });
            cboPhuongThucThanhToan.Location = new Point(41, 415);
            cboPhuongThucThanhToan.Name = "cboPhuongThucThanhToan";
            cboPhuongThucThanhToan.Size = new Size(233, 28);
            cboPhuongThucThanhToan.TabIndex = 5;
            cboPhuongThucThanhToan.SelectedIndexChanged += cboPhuongThucThanhToan_SelectedIndexChanged;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(144, 50);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(130, 27);
            txtTen.TabIndex = 0;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(144, 93);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(130, 27);
            txtSoDienThoai.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(392, 510);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // cboPhuongThucThanhToan2
            // 
            cboPhuongThucThanhToan2.FormattingEnabled = true;
            cboPhuongThucThanhToan2.Location = new Point(44, 466);
            cboPhuongThucThanhToan2.Name = "cboPhuongThucThanhToan2";
            cboPhuongThucThanhToan2.Size = new Size(227, 28);
            cboPhuongThucThanhToan2.TabIndex = 6;
            cboPhuongThucThanhToan2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 566);
            Controls.Add(cboPhuongThucThanhToan2);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTen);
            Controls.Add(cboPhuongThucThanhToan);
            Controls.Add(groupBox2);
            Controls.Add(btnThoat);
            Controls.Add(btnDatHang);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(lblTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblTen;
        private GroupBox groupBox1;
        private Label label4;
        private Button btnDatHang;
        private GroupBox groupBox2;
        private ComboBox cboPhuongThucThanhToan;
        private Label lblThongTinCTDH;
        private TextBox txtTen;
        private TextBox txtSoDienThoai;
        private Button btnThoat;
        public ListBox lstSanPham;
        private ComboBox cboPhuongThucThanhToan2;
    }
}

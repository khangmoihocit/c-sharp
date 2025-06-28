namespace TH_report
{
    partial class frmSua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayGiaoHang = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTrangThaiThanhToan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTileGiamGia = new System.Windows.Forms.TextBox();
            this.txtTenNguoiNhan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người nhận";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày giao hàng";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpNgayGiaoHang
            // 
            this.dtpNgayGiaoHang.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayGiaoHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGiaoHang.Location = new System.Drawing.Point(210, 94);
            this.dtpNgayGiaoHang.Name = "dtpNgayGiaoHang";
            this.dtpNgayGiaoHang.Size = new System.Drawing.Size(265, 32);
            this.dtpNgayGiaoHang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ nhận hàng";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(210, 146);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(265, 32);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(707, 95);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(262, 32);
            this.txtDienThoai.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện thoại người nhận";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái thanh toán";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboTrangThaiThanhToan
            // 
            this.cboTrangThaiThanhToan.FormattingEnabled = true;
            this.cboTrangThaiThanhToan.Items.AddRange(new object[] {
            "chưa thanh toán",
            "đã thanh toán"});
            this.cboTrangThaiThanhToan.Location = new System.Drawing.Point(704, 30);
            this.cboTrangThaiThanhToan.Name = "cboTrangThaiThanhToan";
            this.cboTrangThaiThanhToan.Size = new System.Drawing.Size(265, 32);
            this.cboTrangThaiThanhToan.TabIndex = 1;
            this.cboTrangThaiThanhToan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên người lập";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(704, 154);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(265, 32);
            this.txtNguoiLap.TabIndex = 4;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = true;
            this.btnCapNhat.Location = new System.Drawing.Point(428, 286);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 34);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tỉ lệ giảm giá";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTileGiamGia
            // 
            this.txtTileGiamGia.Location = new System.Drawing.Point(210, 191);
            this.txtTileGiamGia.Name = "txtTileGiamGia";
            this.txtTileGiamGia.Size = new System.Drawing.Size(265, 32);
            this.txtTileGiamGia.TabIndex = 3;
            // 
            // txtTenNguoiNhan
            // 
            this.txtTenNguoiNhan.Location = new System.Drawing.Point(210, 41);
            this.txtTenNguoiNhan.Name = "txtTenNguoiNhan";
            this.txtTenNguoiNhan.Size = new System.Drawing.Size(265, 32);
            this.txtTenNguoiNhan.TabIndex = 3;
            // 
            // frmSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 363);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtNguoiLap);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTileGiamGia);
            this.Controls.Add(this.txtTenNguoiNhan);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.dtpNgayGiaoHang);
            this.Controls.Add(this.cboTrangThaiThanhToan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSua";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSua_FormClosed);
            this.Load += new System.EventHandler(this.frmSua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayGiaoHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTrangThaiThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTileGiamGia;
        private System.Windows.Forms.TextBox txtTenNguoiNhan;
    }
}
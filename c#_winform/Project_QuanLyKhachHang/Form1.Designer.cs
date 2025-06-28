namespace Project_QuanLyKhachHang
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            cboLoaiKH = new ComboBox();
            btnIn = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnTaoMoi = new Button();
            radNu = new RadioButton();
            radNam = new RadioButton();
            txtPhone = new TextBox();
            txtTen = new TextBox();
            txtMa = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            lvKhachHang = new ListView();
            STT = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Info;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(865, 62);
            label1.TabIndex = 0;
            label1.Text = "Chương trình quản lý khách hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 458);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(cboLoaiKH);
            groupBox1.Controls.Add(btnIn);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTaoMoi);
            groupBox1.Controls.Add(radNu);
            groupBox1.Controls.Add(radNam);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(865, 458);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết khách hàng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboLoaiKH
            // 
            cboLoaiKH.FormattingEnabled = true;
            cboLoaiKH.Items.AddRange(new object[] { "VIP", "Thường" });
            cboLoaiKH.Location = new Point(240, 318);
            cboLoaiKH.Name = "cboLoaiKH";
            cboLoaiKH.Size = new Size(431, 38);
            cboLoaiKH.TabIndex = 4;
            // 
            // btnIn
            // 
            btnIn.Font = new Font("Segoe UI", 11F);
            btnIn.Location = new Point(589, 395);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(87, 46);
            btnIn.TabIndex = 3;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 11F);
            btnXoa.Location = new Point(449, 395);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(87, 46);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 11F);
            btnLuu.Location = new Point(312, 395);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(87, 46);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.Font = new Font("Segoe UI", 11F);
            btnTaoMoi.Location = new Point(163, 395);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(107, 46);
            btnTaoMoi.TabIndex = 3;
            btnTaoMoi.Text = "Tạo mới";
            btnTaoMoi.UseVisualStyleBackColor = true;
            btnTaoMoi.Click += btnTaoMoi_Click;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Font = new Font("Segoe UI", 11F);
            radNu.Location = new Point(358, 184);
            radNu.Name = "radNu";
            radNu.Size = new Size(55, 29);
            radNu.TabIndex = 2;
            radNu.TabStop = true;
            radNu.Text = "nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Font = new Font("Segoe UI", 11F);
            radNam.Location = new Point(240, 182);
            radNam.Name = "radNam";
            radNam.Size = new Size(70, 29);
            radNam.TabIndex = 2;
            radNam.TabStop = true;
            radNam.Text = "nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(240, 242);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(431, 36);
            txtPhone.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(240, 112);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(431, 36);
            txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(240, 54);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(431, 36);
            txtMa.TabIndex = 1;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(50, 325);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 0;
            label6.Text = "Loại KH";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(50, 249);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 0;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(50, 184);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 0;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(50, 123);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 0;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(50, 65);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 520);
            panel3.Name = "panel3";
            panel3.Size = new Size(865, 324);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvKhachHang);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 13F);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(865, 324);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // lvKhachHang
            // 
            lvKhachHang.Columns.AddRange(new ColumnHeader[] { STT, columnHeader5, columnHeader1, columnHeader2, columnHeader3 });
            lvKhachHang.Dock = DockStyle.Fill;
            lvKhachHang.FullRowSelect = true;
            lvKhachHang.GridLines = true;
            lvKhachHang.Location = new Point(3, 32);
            lvKhachHang.Name = "lvKhachHang";
            lvKhachHang.Size = new Size(859, 289);
            lvKhachHang.TabIndex = 0;
            lvKhachHang.UseCompatibleStateImageBehavior = false;
            lvKhachHang.View = View.Details;
            // 
            // STT
            // 
            STT.Text = "STT";
            STT.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mã";
            columnHeader5.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên KH";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "SDT";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giới tính";
            columnHeader3.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 844);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private RadioButton radNu;
        private RadioButton radNam;
        private TextBox txtPhone;
        private TextBox txtTen;
        private TextBox txtMa;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnTaoMoi;
        private Panel panel3;
        private GroupBox groupBox2;
        private ListView lvKhachHang;
        private ColumnHeader STT;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ComboBox cboLoaiKH;
        private Button btnIn;
        private Label label6;
        private ColumnHeader columnHeader5;
    }
}

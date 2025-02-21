namespace VD_dataBinding
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDienThoai = new TextBox();
            txtCoQuan = new TextBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            groupBox1 = new GroupBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            btnLuu = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(73, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 29);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(171, 55);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(190, 30);
            txtHoTen.TabIndex = 2;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(412, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 29);
            label2.TabIndex = 0;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.Location = new Point(73, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 0;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.Location = new Point(73, 167);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 29);
            label4.TabIndex = 0;
            label4.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.Location = new Point(73, 221);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 29);
            label5.TabIndex = 0;
            label5.Text = "Tên cơ quan";
            // 
            // label6
            // 
            label6.Location = new Point(73, 280);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 29);
            label6.TabIndex = 0;
            label6.Text = "Địa chỉ";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(171, 167);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(190, 30);
            txtDienThoai.TabIndex = 2;
            txtDienThoai.TextChanged += txtDienThoai_TextChanged;
            // 
            // txtCoQuan
            // 
            txtCoQuan.Location = new Point(171, 221);
            txtCoQuan.Name = "txtCoQuan";
            txtCoQuan.Size = new Size(422, 30);
            txtCoQuan.TabIndex = 2;
            txtCoQuan.TextChanged += txtCoQuan_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(171, 280);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(422, 30);
            txtDiaChi.TabIndex = 2;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(506, 52);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(139, 30);
            dtpNgaySinh.TabIndex = 3;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radNam);
            groupBox1.Controls.Add(radNu);
            groupBox1.Location = new Point(171, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 64);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(99, 18);
            radNam.Name = "radNam";
            radNam.Size = new Size(68, 27);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            radNam.CheckedChanged += radNam_CheckedChanged;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(19, 18);
            radNu.Name = "radNu";
            radNu.Size = new Size(54, 27);
            radNu.TabIndex = 0;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            radNu.CheckedChanged += radNu_CheckedChanged;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(298, 343);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(85, 38);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 412);
            Controls.Add(groupBox1);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtDiaChi);
            Controls.Add(txtCoQuan);
            Controls.Add(txtDienThoai);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(btnLuu);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhachHangForm";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private TextBox txtDienThoai;
        private TextBox txtCoQuan;
        private TextBox txtDiaChi;
        private DateTimePicker dtpNgaySinh;
        private GroupBox groupBox1;
        private RadioButton radNam;
        private RadioButton radNu;
        private Button btnLuu;
        private ErrorProvider errorProvider1;
    }
}

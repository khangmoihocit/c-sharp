namespace Bai29_datetimepicker
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
            components = new System.ComponentModel.Container();
            gbDangKy = new GroupBox();
            btnDangKy = new Button();
            dtpNgayDangKy = new DateTimePicker();
            txtTuoi = new TextBox();
            txtTen = new TextBox();
            lblNgayDangKy = new Label();
            lblTuoi = new Label();
            lblTen = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbDangKy
            // 
            gbDangKy.Controls.Add(btnDangKy);
            gbDangKy.Controls.Add(dtpNgayDangKy);
            gbDangKy.Controls.Add(txtTuoi);
            gbDangKy.Controls.Add(txtTen);
            gbDangKy.Controls.Add(lblNgayDangKy);
            gbDangKy.Controls.Add(lblTuoi);
            gbDangKy.Controls.Add(lblTen);
            gbDangKy.Location = new Point(40, 30);
            gbDangKy.Name = "gbDangKy";
            gbDangKy.Size = new Size(468, 320);
            gbDangKy.TabIndex = 0;
            gbDangKy.TabStop = false;
            gbDangKy.Text = "Đăng ký thi bằng lái xe";
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(167, 245);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 3;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
            dtpNgayDangKy.Format = DateTimePickerFormat.Custom;
            dtpNgayDangKy.Location = new Point(167, 175);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(250, 27);
            dtpNgayDangKy.TabIndex = 2;
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(167, 102);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(175, 27);
            txtTuoi.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(167, 44);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(175, 27);
            txtTen.TabIndex = 0;
            // 
            // lblNgayDangKy
            // 
            lblNgayDangKy.AutoSize = true;
            lblNgayDangKy.Location = new Point(31, 175);
            lblNgayDangKy.Name = "lblNgayDangKy";
            lblNgayDangKy.Size = new Size(100, 20);
            lblNgayDangKy.TabIndex = 0;
            lblNgayDangKy.Text = "Ngày đăng ký";
            lblNgayDangKy.Click += lblNgayDangKy_Click;
            // 
            // lblTuoi
            // 
            lblTuoi.AutoSize = true;
            lblTuoi.Location = new Point(31, 105);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(38, 20);
            lblTuoi.TabIndex = 0;
            lblTuoi.Text = "Tuổi";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(31, 43);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(32, 20);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 377);
            Controls.Add(gbDangKy);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbDangKy.ResumeLayout(false);
            gbDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDangKy;
        private Button btnDangKy;
        private DateTimePicker dtpNgayDangKy;
        private TextBox txtTuoi;
        private TextBox txtTen;
        private Label lblNgayDangKy;
        private Label lblTuoi;
        private Label lblTen;
        private ErrorProvider errorProvider1;
    }
}

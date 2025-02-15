namespace Bai30_Listbox
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
            label1 = new Label();
            txtNhapSo = new TextBox();
            btnCapNhat = new Button();
            grpLop = new GroupBox();
            lstLop = new ListBox();
            groupBox2 = new GroupBox();
            btnSoLe = new Button();
            btnSoChan = new Button();
            btnBinhPhuong = new Button();
            btnTang2 = new Button();
            btnXoaChon = new Button();
            btnXoaDauVaCuoi = new Button();
            btnTong = new Button();
            btnKetThuc = new Button();
            errorProvider1 = new ErrorProvider(components);
            grpLop.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập số";
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(138, 28);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(257, 27);
            txtNhapSo.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(431, 28);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // grpLop
            // 
            grpLop.Controls.Add(lstLop);
            grpLop.Location = new Point(28, 89);
            grpLop.Name = "grpLop";
            grpLop.Size = new Size(222, 326);
            grpLop.TabIndex = 3;
            grpLop.TabStop = false;
            grpLop.Text = "Lớp A";
            // 
            // lstLop
            // 
            lstLop.Dock = DockStyle.Fill;
            lstLop.FormattingEnabled = true;
            lstLop.Location = new Point(3, 23);
            lstLop.Name = "lstLop";
            lstLop.SelectionMode = SelectionMode.MultiSimple;
            lstLop.Size = new Size(216, 300);
            lstLop.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSoLe);
            groupBox2.Controls.Add(btnSoChan);
            groupBox2.Controls.Add(btnBinhPhuong);
            groupBox2.Controls.Add(btnTang2);
            groupBox2.Controls.Add(btnXoaChon);
            groupBox2.Controls.Add(btnXoaDauVaCuoi);
            groupBox2.Controls.Add(btnTong);
            groupBox2.Location = new Point(312, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(232, 314);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các chức năng";
            // 
            // btnSoLe
            // 
            btnSoLe.Location = new Point(19, 285);
            btnSoLe.Name = "btnSoLe";
            btnSoLe.Size = new Size(194, 29);
            btnSoLe.TabIndex = 0;
            btnSoLe.Text = "Chọn số lẻ";
            btnSoLe.UseVisualStyleBackColor = true;
            btnSoLe.Click += btnSoLe_Click;
            // 
            // btnSoChan
            // 
            btnSoChan.Location = new Point(19, 244);
            btnSoChan.Name = "btnSoChan";
            btnSoChan.Size = new Size(194, 29);
            btnSoChan.TabIndex = 0;
            btnSoChan.Text = "Chọn số chẵn";
            btnSoChan.UseVisualStyleBackColor = true;
            btnSoChan.Click += btnSoChan_Click;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Location = new Point(19, 196);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(194, 29);
            btnBinhPhuong.TabIndex = 0;
            btnBinhPhuong.Text = "Thay bằng bình phương";
            btnBinhPhuong.UseVisualStyleBackColor = true;
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(19, 152);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(194, 29);
            btnTang2.TabIndex = 0;
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.UseVisualStyleBackColor = true;
            btnTang2.Click += btnTang2_Click;
            // 
            // btnXoaChon
            // 
            btnXoaChon.Location = new Point(19, 106);
            btnXoaChon.Name = "btnXoaChon";
            btnXoaChon.Size = new Size(194, 29);
            btnXoaChon.TabIndex = 0;
            btnXoaChon.Text = "Xóa phần tử đang chọn";
            btnXoaChon.UseVisualStyleBackColor = true;
            btnXoaChon.Click += btnXoaChon_Click;
            // 
            // btnXoaDauVaCuoi
            // 
            btnXoaDauVaCuoi.Location = new Point(19, 71);
            btnXoaDauVaCuoi.Name = "btnXoaDauVaCuoi";
            btnXoaDauVaCuoi.Size = new Size(194, 29);
            btnXoaDauVaCuoi.TabIndex = 0;
            btnXoaDauVaCuoi.Text = "Xóa phần tử đầu và cuối";
            btnXoaDauVaCuoi.UseVisualStyleBackColor = true;
            btnXoaDauVaCuoi.Click += btnXoaDauVaCuoi_Click;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(19, 26);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(194, 29);
            btnTong.TabIndex = 0;
            btnTong.Text = "Tổng của danh sách";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(159, 460);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(253, 29);
            btnKetThuc.TabIndex = 5;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 515);
            Controls.Add(btnKetThuc);
            Controls.Add(groupBox2);
            Controls.Add(grpLop);
            Controls.Add(btnCapNhat);
            Controls.Add(txtNhapSo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài tập rèn luyện listbox";
            Load += Form1_Load;
            grpLop.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapSo;
        private Button btnCapNhat;
        private GroupBox grpLop;
        private ListBox lstLop;
        private GroupBox groupBox2;
        private Button btnSoLe;
        private Button btnSoChan;
        private Button btnBinhPhuong;
        private Button btnTang2;
        private Button btnXoaChon;
        private Button btnXoaDauVaCuoi;
        private Button btnTong;
        private Button btnKetThuc;
        private ErrorProvider errorProvider1;
    }
}

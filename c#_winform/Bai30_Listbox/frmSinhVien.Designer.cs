namespace Bai30_Listbox
{
    partial class frmSinhVien
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
            label1 = new Label();
            txtTenSV = new TextBox();
            btnCapNhat = new Button();
            groupBox1 = new GroupBox();
            lstLopA = new ListBox();
            groupBox2 = new GroupBox();
            lstLopB = new ListBox();
            btnPhai1 = new Button();
            btnPhai2 = new Button();
            btnTrai2 = new Button();
            btnTrai1 = new Button();
            btnXoaLopA = new Button();
            btnXoaLopB = new Button();
            btnKetThuc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 37);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sinh viên: ";
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(183, 34);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(252, 27);
            txtTenSV.TabIndex = 0;
            txtTenSV.TextChanged += textBox1_TextChanged;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(458, 33);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(104, 29);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstLopA);
            groupBox1.Location = new Point(45, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 303);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lstLopA
            // 
            lstLopA.Dock = DockStyle.Fill;
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(3, 23);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiSimple;
            lstLopA.Size = new Size(206, 277);
            lstLopA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstLopB);
            groupBox2.Location = new Point(413, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 303);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // lstLopB
            // 
            lstLopB.Dock = DockStyle.Fill;
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(3, 23);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiSimple;
            lstLopB.Size = new Size(206, 277);
            lstLopB.TabIndex = 0;
            // 
            // btnPhai1
            // 
            btnPhai1.Location = new Point(293, 136);
            btnPhai1.Name = "btnPhai1";
            btnPhai1.Size = new Size(94, 29);
            btnPhai1.TabIndex = 2;
            btnPhai1.Text = ">";
            btnPhai1.UseVisualStyleBackColor = true;
            btnPhai1.Click += btnPhai1_Click;
            // 
            // btnPhai2
            // 
            btnPhai2.Location = new Point(293, 196);
            btnPhai2.Name = "btnPhai2";
            btnPhai2.Size = new Size(94, 29);
            btnPhai2.TabIndex = 3;
            btnPhai2.Text = ">>";
            btnPhai2.UseVisualStyleBackColor = true;
            btnPhai2.Click += btnPhai2_Click;
            // 
            // btnTrai2
            // 
            btnTrai2.Location = new Point(293, 318);
            btnTrai2.Name = "btnTrai2";
            btnTrai2.Size = new Size(94, 29);
            btnTrai2.TabIndex = 5;
            btnTrai2.Text = "<<";
            btnTrai2.UseVisualStyleBackColor = true;
            btnTrai2.Click += btnTrai2_Click;
            // 
            // btnTrai1
            // 
            btnTrai1.Location = new Point(293, 261);
            btnTrai1.Name = "btnTrai1";
            btnTrai1.Size = new Size(94, 29);
            btnTrai1.TabIndex = 4;
            btnTrai1.Text = "<";
            btnTrai1.UseVisualStyleBackColor = true;
            btnTrai1.Click += btnTrai1_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Location = new Point(71, 409);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(143, 29);
            btnXoaLopA.TabIndex = 6;
            btnXoaLopA.Text = "Xóa lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Location = new Point(444, 409);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(143, 29);
            btnXoaLopB.TabIndex = 8;
            btnXoaLopB.Text = "Xóa lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(271, 409);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(130, 29);
            btnKetThuc.TabIndex = 7;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 455);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnTrai1);
            Controls.Add(btnTrai2);
            Controls.Add(btnPhai2);
            Controls.Add(btnPhai1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTenSV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSinhVien";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenSV;
        private Button btnCapNhat;
        private GroupBox groupBox1;
        private ListBox lstLopA;
        private GroupBox groupBox2;
        private ListBox lstLopB;
        private Button btnPhai1;
        private Button btnPhai2;
        private Button btnTrai2;
        private Button btnTrai1;
        private Button btnXoaLopA;
        private Button btnXoaLopB;
        private Button btnKetThuc;
    }
}
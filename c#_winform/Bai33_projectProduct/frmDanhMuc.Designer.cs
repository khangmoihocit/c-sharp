namespace Bai33_projectProduct
{
    partial class frmDanhMuc
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
            groupBox1 = new GroupBox();
            lstDanhMuc = new ListBox();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            txtTenDM = new TextBox();
            txtMaDM = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDanhMuc);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 294);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách danh mục";
            // 
            // lstDanhMuc
            // 
            lstDanhMuc.Dock = DockStyle.Fill;
            lstDanhMuc.FormattingEnabled = true;
            lstDanhMuc.Location = new Point(3, 23);
            lstDanhMuc.Name = "lstDanhMuc";
            lstDanhMuc.Size = new Size(254, 268);
            lstDanhMuc.TabIndex = 0;
            lstDanhMuc.SelectedIndexChanged += lstDanhMauc_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(txtTenDM);
            groupBox2.Controls.Add(txtMaDM);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(278, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 294);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết danh mục";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(252, 249);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(125, 249);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(16, 249);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtTenDM
            // 
            txtTenDM.Location = new Point(16, 195);
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(330, 27);
            txtTenDM.TabIndex = 1;
            txtTenDM.TextChanged += textBox1_TextChanged;
            // 
            // txtMaDM
            // 
            txtMaDM.Location = new Point(16, 95);
            txtMaDM.Name = "txtMaDM";
            txtMaDM.Size = new Size(330, 27);
            txtMaDM.TabIndex = 0;
            txtMaDM.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(16, 155);
            label2.Name = "label2";
            label2.Size = new Size(135, 27);
            label2.TabIndex = 0;
            label2.Text = "Tên danh mục";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(135, 36);
            label1.TabIndex = 0;
            label1.Text = "Mã danh mục";
            // 
            // frmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 322);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDanhMuc";
            Load += frmDanhMuc_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstDanhMuc;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtMaDM;
        private Label label2;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
        private TextBox txtTenDM;
    }
}
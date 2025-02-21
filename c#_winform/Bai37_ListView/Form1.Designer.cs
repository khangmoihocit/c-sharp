namespace Bai37_ListView
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "sp1", "cocacola", "10000" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "sp2", "pesi", "80000" }, -1);
            lvSanPham = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtGiaSP = new TextBox();
            btnThemSP = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            SuspendLayout();
            // 
            // lvSanPham
            // 
            lvSanPham.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvSanPham.FullRowSelect = true;
            lvSanPham.GridLines = true;
            lvSanPham.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvSanPham.Location = new Point(14, 336);
            lvSanPham.Margin = new Padding(4);
            lvSanPham.Name = "lvSanPham";
            lvSanPham.Size = new Size(573, 320);
            lvSanPham.TabIndex = 0;
            lvSanPham.UseCompatibleStateImageBehavior = false;
            lvSanPham.View = View.Details;
            lvSanPham.ColumnClick += lvSanPham_ColumnClick;
            lvSanPham.SelectedIndexChanged += lvSanPham_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã sản phẩm";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sản phẩm";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 1;
            label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 202);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 1;
            label3.Text = "Giá sản phẩm";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(178, 54);
            txtMaSP.Margin = new Padding(4);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(252, 30);
            txtMaSP.TabIndex = 0;
            txtMaSP.TextChanged += textBox1_TextChanged;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(178, 127);
            txtTenSP.Margin = new Padding(4);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(252, 30);
            txtTenSP.TabIndex = 1;
            // 
            // txtGiaSP
            // 
            txtGiaSP.Location = new Point(178, 194);
            txtGiaSP.Margin = new Padding(4);
            txtGiaSP.Name = "txtGiaSP";
            txtGiaSP.Size = new Size(252, 30);
            txtGiaSP.TabIndex = 2;
            // 
            // btnThemSP
            // 
            btnThemSP.Location = new Point(58, 267);
            btnThemSP.Margin = new Padding(4);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(106, 33);
            btnThemSP.TabIndex = 3;
            btnThemSP.Text = "thêm";
            btnThemSP.UseVisualStyleBackColor = true;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(212, 269);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(368, 271);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 667);
            Controls.Add(btnCapNhat);
            Controls.Add(btnXoa);
            Controls.Add(btnThemSP);
            Controls.Add(txtGiaSP);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvSanPham);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvSanPham;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtGiaSP;
        private Button btnThemSP;
        private Button btnXoa;
        private Button btnCapNhat;
    }
}

namespace VD_dataBinding
{
    partial class FormDanhSachKhachHang
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
            dgvKhachHang = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dgvKhachHang.Location = new Point(12, 12);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(914, 460);
            dgvKhachHang.TabIndex = 0;
            // 
            // FormDanhSachKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 484);
            Controls.Add(dgvKhachHang);
            Name = "FormDanhSachKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDanhSachKhachHang";
            Load += FormDanhSachKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKhachHang;
    }
}
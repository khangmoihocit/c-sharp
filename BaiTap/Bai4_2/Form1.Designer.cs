namespace Bai4_2
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
            btnXemThongTin = new Button();
            lstKhachHang = new ListBox();
            SuspendLayout();
            // 
            // btnXemThongTin
            // 
            btnXemThongTin.Location = new Point(549, 188);
            btnXemThongTin.Name = "btnXemThongTin";
            btnXemThongTin.Size = new Size(193, 29);
            btnXemThongTin.TabIndex = 0;
            btnXemThongTin.Text = "xem thông tin";
            btnXemThongTin.UseVisualStyleBackColor = true;
            btnXemThongTin.Click += btnXemThongTin_Click;
            // 
            // lstKhachHang
            // 
            lstKhachHang.FormattingEnabled = true;
            lstKhachHang.Location = new Point(65, 29);
            lstKhachHang.Name = "lstKhachHang";
            lstKhachHang.Size = new Size(271, 364);
            lstKhachHang.TabIndex = 1;
            lstKhachHang.SelectedIndexChanged += lstKhachHang_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKhachHang);
            Controls.Add(btnXemThongTin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnXemThongTin;
        private ListBox lstKhachHang;
    }
}

namespace Bai_4_2
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
            lstKhachHang = new ListBox();
            btnXemThongTin = new Button();
            SuspendLayout();
            // 
            // lstKhachHang
            // 
            lstKhachHang.FormattingEnabled = true;
            lstKhachHang.Location = new Point(52, 12);
            lstKhachHang.Name = "lstKhachHang";
            lstKhachHang.Size = new Size(274, 404);
            lstKhachHang.TabIndex = 0;
            // 
            // btnXemThongTin
            // 
            btnXemThongTin.Location = new Point(442, 56);
            btnXemThongTin.Name = "btnXemThongTin";
            btnXemThongTin.Size = new Size(130, 29);
            btnXemThongTin.TabIndex = 1;
            btnXemThongTin.Text = "xem thông tin";
            btnXemThongTin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXemThongTin);
            Controls.Add(lstKhachHang);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstKhachHang;
        private Button btnXemThongTin;
    }
}

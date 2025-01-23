namespace Bai26_lbl_txt_btn
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
            lblHoTen = new Label();
            label1 = new Label();
            label2 = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            button4 = new Button();
            btnThoatChuongTrinh = new Button();
            btnHoVaTen = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.Highlight;
            lblHoTen.Font = new Font("Segoe UI", 13F);
            lblHoTen.ForeColor = SystemColors.ButtonHighlight;
            lblHoTen.Location = new Point(12, 9);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(776, 98);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "doc";
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += label1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(56, 153);
            label1.Name = "label1";
            label1.Size = new Size(89, 38);
            label1.TabIndex = 1;
            label1.Text = "Họ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(56, 227);
            label2.Name = "label2";
            label2.Size = new Size(89, 40);
            label2.TabIndex = 3;
            label2.Text = "Tên";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label1_Click_1;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(193, 153);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(533, 27);
            txtHo.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(193, 227);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(533, 27);
            txtTen.TabIndex = 4;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(90, 302);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(94, 41);
            btnHo.TabIndex = 5;
            btnHo.Text = "&họ";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(345, 302);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 41);
            btnTen.TabIndex = 6;
            btnTen.Text = "tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // button4
            // 
            button4.Location = new Point(345, 381);
            button4.Name = "button4";
            button4.Size = new Size(94, 41);
            button4.TabIndex = 3;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnThoatChuongTrinh
            // 
            btnThoatChuongTrinh.Location = new Point(345, 381);
            btnThoatChuongTrinh.Name = "btnThoatChuongTrinh";
            btnThoatChuongTrinh.Size = new Size(147, 41);
            btnThoatChuongTrinh.TabIndex = 8;
            btnThoatChuongTrinh.Text = "thoát chương trình";
            btnThoatChuongTrinh.UseVisualStyleBackColor = true;
            btnThoatChuongTrinh.Click += btnThoatChuongTrinh_Click;
            // 
            // btnHoVaTen
            // 
            btnHoVaTen.Location = new Point(590, 302);
            btnHoVaTen.Name = "btnHoVaTen";
            btnHoVaTen.Size = new Size(94, 41);
            btnHoVaTen.TabIndex = 7;
            btnHoVaTen.Text = "họ và tên";
            btnHoVaTen.UseVisualStyleBackColor = true;
            btnHoVaTen.Click += btnHoVaTen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoatChuongTrinh;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHoVaTen);
            Controls.Add(btnThoatChuongTrinh);
            Controls.Add(button4);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHoTen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "bai tap";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label label1;
        private Label label2;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button button4;
        private Button btnThoatChuongTrinh;
        private Button btnHoVaTen;
    }
}

namespace Bai27_checkbox_rad
{
    partial class FormMain
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
            lblNhapTen = new Label();
            txtNhapTen = new TextBox();
            groupBox1 = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            groupBox2 = new GroupBox();
            chkUnderline = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            label2 = new Label();
            lblLapTrinhBoi = new Label();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNhapTen
            // 
            lblNhapTen.AutoSize = true;
            lblNhapTen.Location = new Point(67, 46);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(70, 20);
            lblNhapTen.TabIndex = 0;
            lblNhapTen.Text = "Nhập tên";
            lblNhapTen.Click += label1_Click;
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(176, 47);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(443, 27);
            txtNhapTen.TabIndex = 0;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(radBlack);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radRed);
            groupBox1.Location = new Point(67, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "color";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Location = new Point(13, 156);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(65, 24);
            radBlack.TabIndex = 3;
            radBlack.Text = "black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(13, 120);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(59, 24);
            radBlue.TabIndex = 2;
            radBlue.Text = "blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(13, 78);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(68, 24);
            radGreen.TabIndex = 1;
            radGreen.Text = "green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.BackColor = SystemColors.Info;
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(13, 35);
            radRed.Name = "radRed";
            radRed.Size = new Size(52, 24);
            radRed.TabIndex = 0;
            radRed.Text = "red";
            radRed.UseVisualStyleBackColor = false;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 255);
            groupBox2.Controls.Add(chkUnderline);
            groupBox2.Controls.Add(chkItalic);
            groupBox2.Controls.Add(chkBold);
            groupBox2.Location = new Point(393, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 194);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "font";
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Location = new Point(20, 143);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(93, 24);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "underline";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Location = new Point(20, 94);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(63, 24);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Location = new Point(20, 40);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(62, 24);
            chkBold.TabIndex = 0;
            chkBold.Text = "bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 368);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Lập Trình Bởi";
            // 
            // lblLapTrinhBoi
            // 
            lblLapTrinhBoi.BorderStyle = BorderStyle.FixedSingle;
            lblLapTrinhBoi.Location = new Point(193, 368);
            lblLapTrinhBoi.Name = "lblLapTrinhBoi";
            lblLapTrinhBoi.Size = new Size(233, 30);
            lblLapTrinhBoi.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(509, 369);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(692, 450);
            Controls.Add(btnThoat);
            Controls.Add(lblLapTrinhBoi);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtNhapTen);
            Controls.Add(lblNhapTen);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapTen;
        private TextBox txtNhapTen;
        private GroupBox groupBox1;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private GroupBox groupBox2;
        private CheckBox chkUnderline;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Label label2;
        private Label lblLapTrinhBoi;
        private Button btnThoat;
    }
}
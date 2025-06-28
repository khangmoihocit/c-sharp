namespace test
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.CrystalReport11 = new test.CrystalReport1();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radKhongChon = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(330, 342);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(159, 50);
            this.btnBaoCao.TabIndex = 0;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Địa chỉ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(297, 126);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(338, 30);
            this.txtDiaChi.TabIndex = 2;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(299, 212);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(71, 29);
            this.radNam.TabIndex = 3;
            this.radNam.TabStop = true;
            this.radNam.Text = "nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(399, 212);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(55, 29);
            this.radNu.TabIndex = 3;
            this.radNu.TabStop = true;
            this.radNu.Text = "nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radKhongChon
            // 
            this.radKhongChon.AutoSize = true;
            this.radKhongChon.Location = new System.Drawing.Point(500, 212);
            this.radKhongChon.Name = "radKhongChon";
            this.radKhongChon.Size = new System.Drawing.Size(135, 29);
            this.radKhongChon.TabIndex = 3;
            this.radKhongChon.TabStop = true;
            this.radKhongChon.Text = "không chọn";
            this.radKhongChon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 510);
            this.Controls.Add(this.radKhongChon);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaoCao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radKhongChon;
    }
}


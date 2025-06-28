namespace VD_5_3
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
            txtA = new TextBox();
            label2 = new Label();
            txtB = new TextBox();
            btnChia = new Button();
            txtKetQua = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 185);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 0;
            label1.Text = "a = ";
            // 
            // txtA
            // 
            txtA.Location = new Point(169, 181);
            txtA.Margin = new Padding(4);
            txtA.Name = "txtA";
            txtA.Size = new Size(68, 32);
            txtA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 181);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 0;
            label2.Text = ": b = ";
            // 
            // txtB
            // 
            txtB.Location = new Point(351, 180);
            txtB.Margin = new Padding(4);
            txtB.Name = "txtB";
            txtB.Size = new Size(74, 32);
            txtB.TabIndex = 1;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(462, 185);
            btnChia.Margin = new Padding(4);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(66, 36);
            btnChia.TabIndex = 2;
            btnChia.Text = "=";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(561, 186);
            txtKetQua.Margin = new Padding(4);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(76, 32);
            txtKetQua.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 374);
            Controls.Add(btnChia);
            Controls.Add(txtKetQua);
            Controls.Add(txtB);
            Controls.Add(label2);
            Controls.Add(txtA);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtA;
        private Label label2;
        private TextBox txtB;
        private Button btnChia;
        private TextBox txtKetQua;
        private ErrorProvider errorProvider1;
    }
}

namespace Bai28_PictureBox
{
    partial class FormMain
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
            lblName = new Label();
            txtName = new TextBox();
            pcOn = new PictureBox();
            pcOff = new PictureBox();
            btnOnorOff = new Button();
            label2 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pcOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcOff).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(76, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(161, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // pcOn
            // 
            pcOn.Image = Properties.Resources.bongden_on;
            pcOn.Location = new Point(64, 75);
            pcOn.Name = "pcOn";
            pcOn.Size = new Size(143, 236);
            pcOn.SizeMode = PictureBoxSizeMode.AutoSize;
            pcOn.TabIndex = 2;
            pcOn.TabStop = false;
            pcOn.Click += pcOn_Click;
            // 
            // pcOff
            // 
            pcOff.Image = Properties.Resources.off;
            pcOff.Location = new Point(76, 82);
            pcOff.Name = "pcOff";
            pcOff.Size = new Size(131, 235);
            pcOff.SizeMode = PictureBoxSizeMode.AutoSize;
            pcOff.TabIndex = 2;
            pcOff.TabStop = false;
            // 
            // btnOnorOff
            // 
            btnOnorOff.Location = new Point(76, 353);
            btnOnorOff.Name = "btnOnorOff";
            btnOnorOff.Size = new Size(315, 37);
            btnOnorOff.TabIndex = 3;
            btnOnorOff.UseVisualStyleBackColor = true;
            btnOnorOff.Click += btnOnorOff_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(72, 407);
            label2.Name = "label2";
            label2.Size = new Size(179, 29);
            label2.TabIndex = 4;
            label2.Text = "Designed by: Mr. Khang";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(288, 407);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 467);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(btnOnorOff);
            Controls.Add(pcOff);
            Controls.Add(pcOn);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private PictureBox pcOn;
        private PictureBox pcOff;
        private Button btnOnorOff;
        private Label label2;
        private Button btnExit;
    }
}

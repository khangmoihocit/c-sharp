namespace VD_5_2
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
            txtDuLieu = new TextBox();
            btnSayIt = new Button();
            lblLength = new Label();
            SuspendLayout();
            // 
            // txtDuLieu
            // 
            txtDuLieu.Location = new Point(156, 120);
            txtDuLieu.Name = "txtDuLieu";
            txtDuLieu.Size = new Size(279, 27);
            txtDuLieu.TabIndex = 0;
            txtDuLieu.TextChanged += txtDuLieu_TextChanged;
            // 
            // btnSayIt
            // 
            btnSayIt.Location = new Point(298, 239);
            btnSayIt.Name = "btnSayIt";
            btnSayIt.Size = new Size(94, 29);
            btnSayIt.TabIndex = 1;
            btnSayIt.Text = "Say it";
            btnSayIt.UseVisualStyleBackColor = true;
            btnSayIt.Click += btnSayIt_Click;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(482, 123);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(17, 20);
            lblLength.TabIndex = 2;
            lblLength.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(lblLength);
            Controls.Add(btnSayIt);
            Controls.Add(txtDuLieu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDuLieu;
        private Button btnSayIt;
        private Label lblLength;
    }
}

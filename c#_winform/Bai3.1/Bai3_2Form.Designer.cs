namespace Bai3._1
{
    partial class Bai3_2Form
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
            txtInput = new TextBox();
            lblAlphabets = new Label();
            lblNumbers = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(173, 163);
            txtInput.Margin = new Padding(4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(370, 32);
            txtInput.TabIndex = 0;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // lblAlphabets
            // 
            lblAlphabets.BackColor = SystemColors.ActiveCaption;
            lblAlphabets.Location = new Point(43, 51);
            lblAlphabets.Margin = new Padding(4, 0, 4, 0);
            lblAlphabets.Name = "lblAlphabets";
            lblAlphabets.Size = new Size(250, 31);
            lblAlphabets.TabIndex = 1;
            // 
            // lblNumbers
            // 
            lblNumbers.BackColor = SystemColors.ActiveCaption;
            lblNumbers.Location = new Point(421, 51);
            lblNumbers.Margin = new Padding(4, 0, 4, 0);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(250, 31);
            lblNumbers.TabIndex = 1;
            // 
            // Bai3_2Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 243);
            Controls.Add(lblNumbers);
            Controls.Add(lblAlphabets);
            Controls.Add(txtInput);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "Bai3_2Form";
            Text = "Bai3_2Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label lblAlphabets;
        private Label lblNumbers;
    }
}
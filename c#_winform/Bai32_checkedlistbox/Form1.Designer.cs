namespace Bai32_checkedlistbox
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
            chklistLeft = new CheckedListBox();
            chklstRight = new CheckedListBox();
            btnMoveOneFromLeftToRight = new Button();
            btnMoveAllFromRightToLeft = new Button();
            btnMoveAllFromLeftToRight = new Button();
            btnMoveOneFromRightToLeft = new Button();
            SuspendLayout();
            // 
            // chklistLeft
            // 
            chklistLeft.FormattingEnabled = true;
            chklistLeft.Location = new Point(25, 32);
            chklistLeft.Name = "chklistLeft";
            chklistLeft.Size = new Size(194, 268);
            chklistLeft.TabIndex = 0;
            // 
            // chklstRight
            // 
            chklstRight.FormattingEnabled = true;
            chklstRight.Location = new Point(365, 32);
            chklstRight.Name = "chklstRight";
            chklstRight.Size = new Size(194, 268);
            chklstRight.TabIndex = 0;
            // 
            // btnMoveOneFromLeftToRight
            // 
            btnMoveOneFromLeftToRight.Location = new Point(245, 32);
            btnMoveOneFromLeftToRight.Name = "btnMoveOneFromLeftToRight";
            btnMoveOneFromLeftToRight.Size = new Size(94, 29);
            btnMoveOneFromLeftToRight.TabIndex = 1;
            btnMoveOneFromLeftToRight.Text = ">";
            btnMoveOneFromLeftToRight.UseVisualStyleBackColor = true;
            btnMoveOneFromLeftToRight.Click += btnMoveOneFromLeftToRight_Click;
            // 
            // btnMoveAllFromRightToLeft
            // 
            btnMoveAllFromRightToLeft.Location = new Point(245, 271);
            btnMoveAllFromRightToLeft.Name = "btnMoveAllFromRightToLeft";
            btnMoveAllFromRightToLeft.Size = new Size(94, 29);
            btnMoveAllFromRightToLeft.TabIndex = 2;
            btnMoveAllFromRightToLeft.Text = "<<";
            btnMoveAllFromRightToLeft.UseVisualStyleBackColor = true;
            // 
            // btnMoveAllFromLeftToRight
            // 
            btnMoveAllFromLeftToRight.Location = new Point(245, 114);
            btnMoveAllFromLeftToRight.Name = "btnMoveAllFromLeftToRight";
            btnMoveAllFromLeftToRight.Size = new Size(94, 29);
            btnMoveAllFromLeftToRight.TabIndex = 2;
            btnMoveAllFromLeftToRight.Text = ">>";
            btnMoveAllFromLeftToRight.UseVisualStyleBackColor = true;
            // 
            // btnMoveOneFromRightToLeft
            // 
            btnMoveOneFromRightToLeft.Location = new Point(245, 192);
            btnMoveOneFromRightToLeft.Name = "btnMoveOneFromRightToLeft";
            btnMoveOneFromRightToLeft.Size = new Size(94, 29);
            btnMoveOneFromRightToLeft.TabIndex = 2;
            btnMoveOneFromRightToLeft.Text = "<";
            btnMoveOneFromRightToLeft.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 339);
            Controls.Add(btnMoveOneFromRightToLeft);
            Controls.Add(btnMoveAllFromLeftToRight);
            Controls.Add(btnMoveAllFromRightToLeft);
            Controls.Add(btnMoveOneFromLeftToRight);
            Controls.Add(chklstRight);
            Controls.Add(chklistLeft);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox chklistLeft;
        private CheckedListBox chklstRight;
        private Button btnMoveOneFromLeftToRight;
        private Button btnMoveAllFromRightToLeft;
        private Button btnMoveAllFromLeftToRight;
        private Button btnMoveOneFromRightToLeft;
    }
}

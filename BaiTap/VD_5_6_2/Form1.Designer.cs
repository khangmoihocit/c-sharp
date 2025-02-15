namespace VD_5_6_2
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
            listBox1 = new ListBox();
            label = new Label();
            label2 = new Label();
            btnAdd = new Button();
            txtText = new TextBox();
            txtValue = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 11F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(35, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(267, 379);
            listBox1.TabIndex = 0;
            // 
            // label
            // 
            label.Location = new Point(378, 66);
            label.Name = "label";
            label.Size = new Size(107, 25);
            label.TabIndex = 1;
            label.Text = "Text";
            // 
            // label2
            // 
            label2.Location = new Point(378, 136);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Value";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(383, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "<< Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtText
            // 
            txtText.Location = new Point(383, 94);
            txtText.Name = "txtText";
            txtText.Size = new Size(209, 27);
            txtText.TabIndex = 3;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(383, 164);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(209, 27);
            txtValue.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 417);
            Controls.Add(txtValue);
            Controls.Add(txtText);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label;
        private Label label2;
        private Button btnAdd;
        private TextBox txtText;
        private TextBox txtValue;
    }
}

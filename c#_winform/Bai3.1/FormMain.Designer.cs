namespace Bai3._1
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            mniCacBai = new ToolStripMenuItem();
            mniBai32 = new ToolStripMenuItem();
            mniCalc = new ToolStripMenuItem();
            mniThoat = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mniCacBai, mniThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mniCacBai
            // 
            mniCacBai.DropDownItems.AddRange(new ToolStripItem[] { mniBai32, mniCalc });
            mniCacBai.Name = "mniCacBai";
            mniCacBai.Size = new Size(72, 24);
            mniCacBai.Text = "Các bài";
            // 
            // mniBai32
            // 
            mniBai32.Name = "mniBai32";
            mniBai32.Size = new Size(224, 26);
            mniBai32.Text = "Bài 3.2";
            mniBai32.Click += mniBai32_Click;
            // 
            // mniCalc
            // 
            mniCalc.Name = "mniCalc";
            mniCalc.Size = new Size(224, 26);
            mniCalc.Text = "Calculator";
            mniCalc.Click += mniCalc_Click;
            // 
            // mniThoat
            // 
            mniThoat.Name = "mniThoat";
            mniThoat.Size = new Size(61, 24);
            mniThoat.Text = "Thoát";
            mniThoat.Click += mniThoat_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 792);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài thực hành của Phạm Văn Khang";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mniCacBai;
        private ToolStripMenuItem mniThoat;
        private ToolStripMenuItem mniBai32;
        private ToolStripMenuItem mniCalc;
    }
}

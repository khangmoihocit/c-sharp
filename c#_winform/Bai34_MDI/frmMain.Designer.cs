namespace Bai34_MDI
{
    partial class frmMain
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
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            bài1ToolStripMenuItem = new ToolStripMenuItem();
            bài2ToolStripMenuItem = new ToolStripMenuItem();
            bài3ToolStripMenuItem = new ToolStripMenuItem();
            bài4ToolStripMenuItem = new ToolStripMenuItem();
            sắpXếpToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileToolStripMenuItem = new ToolStripMenuItem();
            tileveritiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sắpXếpToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(716, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bài1ToolStripMenuItem, bài2ToolStripMenuItem, bài3ToolStripMenuItem, bài4ToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // bài1ToolStripMenuItem
            // 
            bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            bài1ToolStripMenuItem.Size = new Size(224, 26);
            bài1ToolStripMenuItem.Text = "Bài 1";
            bài1ToolStripMenuItem.Click += bài1ToolStripMenuItem_Click;
            // 
            // bài2ToolStripMenuItem
            // 
            bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            bài2ToolStripMenuItem.Size = new Size(224, 26);
            bài2ToolStripMenuItem.Text = "Bài 2";
            bài2ToolStripMenuItem.Click += bài2ToolStripMenuItem_Click;
            // 
            // bài3ToolStripMenuItem
            // 
            bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            bài3ToolStripMenuItem.Size = new Size(224, 26);
            bài3ToolStripMenuItem.Text = "Bài 3";
            bài3ToolStripMenuItem.Click += bài3ToolStripMenuItem_Click;
            // 
            // bài4ToolStripMenuItem
            // 
            bài4ToolStripMenuItem.Name = "bài4ToolStripMenuItem";
            bài4ToolStripMenuItem.Size = new Size(224, 26);
            bài4ToolStripMenuItem.Text = "Bài 4";
            // 
            // sắpXếpToolStripMenuItem
            // 
            sắpXếpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrangeIconsToolStripMenuItem, cascadeToolStripMenuItem, tileToolStripMenuItem, tileveritiToolStripMenuItem });
            sắpXếpToolStripMenuItem.Name = "sắpXếpToolStripMenuItem";
            sắpXếpToolStripMenuItem.Size = new Size(76, 24);
            sắpXếpToolStripMenuItem.Text = "Sắp xếp";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(186, 26);
            arrangeIconsToolStripMenuItem.Text = "ArrangeIcons";
            arrangeIconsToolStripMenuItem.Click += arrangeIconsToolStripMenuItem_Click;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(186, 26);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileToolStripMenuItem
            // 
            tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            tileToolStripMenuItem.Size = new Size(186, 26);
            tileToolStripMenuItem.Text = "TileHorizontal";
            tileToolStripMenuItem.Click += tileToolStripMenuItem_Click;
            // 
            // tileveritiToolStripMenuItem
            // 
            tileveritiToolStripMenuItem.Name = "tileveritiToolStripMenuItem";
            tileveritiToolStripMenuItem.Size = new Size(186, 26);
            tileveritiToolStripMenuItem.Text = "TileVertical";
            tileveritiToolStripMenuItem.Click += tileveritiToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 452);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem bài1ToolStripMenuItem;
        private ToolStripMenuItem bài2ToolStripMenuItem;
        private ToolStripMenuItem bài3ToolStripMenuItem;
        private ToolStripMenuItem bài4ToolStripMenuItem;
        private ToolStripMenuItem sắpXếpToolStripMenuItem;
        private ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileToolStripMenuItem;
        private ToolStripMenuItem tileveritiToolStripMenuItem;
    }
}

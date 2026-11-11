namespace GBS.Sample.WinForms
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
            gbsEditor1 = new GBS.WinForms.GbsEditor();
            gbsRollBar1 = new GBS.WinForms.GbsRollBar();
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            開くoToolStripMenuItem = new ToolStripMenuItem();
            上書き保存ToolStripMenuItem = new ToolStripMenuItem();
            名前を付けて保存ToolStripMenuItem = new ToolStripMenuItem();
            hELPToolStripMenuItem = new ToolStripMenuItem();
            質問を投稿するToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gbsEditor1
            // 
            gbsEditor1.BackColor = Color.White;
            gbsEditor1.CaretOffset = 0L;
            gbsEditor1.ChangeMarkColor = Color.SteelBlue;
            gbsEditor1.DeletionMarkColor = Color.IndianRed;
            gbsEditor1.Dock = DockStyle.Fill;
            gbsEditor1.EnableVirtualCommands = true;
            gbsEditor1.FindPaletteCount = 10;
            gbsEditor1.Font = new Font("Consolas", 11F);
            gbsEditor1.ForeColor = Color.Black;
            gbsEditor1.Location = new Point(0, 24);
            gbsEditor1.MetaMarks.Color = Color.FromArgb(145, 150, 160);
            gbsEditor1.MetaMarks.CRLFSymbol = "↵";
            gbsEditor1.MetaMarks.CRSymbol = "↵";
            gbsEditor1.MetaMarks.EOFSymbol = "[EOF]";
            gbsEditor1.MetaMarks.FullWidthSpaceSymbol = "□";
            gbsEditor1.MetaMarks.HalfWidthSpaceSymbol = "·";
            gbsEditor1.MetaMarks.LFSymbol = "↓";
            gbsEditor1.MetaMarks.TabSymbol = "→";
            gbsEditor1.Name = "gbsEditor1";
            gbsEditor1.Size = new Size(800, 426);
            gbsEditor1.TabIndex = 0;
            gbsEditor1.Text = "gbsEditor1";
            gbsEditor1.ViewOffset = 0L;
            gbsEditor1.WrapMode = GBS.Text.WrapMode.None;
            // 
            // gbsRollBar1
            // 
            gbsRollBar1.Appearance = GBS.WinForms.RollBarAppearance.FlatIntegrated;
            gbsRollBar1.BackColor = Color.White;
            gbsRollBar1.Dock = DockStyle.Right;
            gbsRollBar1.Editor = gbsEditor1;
            gbsRollBar1.Location = new Point(725, 24);
            gbsRollBar1.MiniViewScale = 0.25F;
            gbsRollBar1.MiniViewWidth = 80;
            gbsRollBar1.Name = "gbsRollBar1";
            gbsRollBar1.SegmentSize = 268435456;
            gbsRollBar1.Size = new Size(75, 426);
            gbsRollBar1.TabIndex = 1;
            gbsRollBar1.Text = "gbsRollBar1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, hELPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, 開くoToolStripMenuItem, 上書き保存ToolStripMenuItem, 名前を付けて保存ToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(53, 20);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "新規作成";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // 開くoToolStripMenuItem
            // 
            開くoToolStripMenuItem.Name = "開くoToolStripMenuItem";
            開くoToolStripMenuItem.Size = new Size(180, 22);
            開くoToolStripMenuItem.Text = "開く(&o)";
            開くoToolStripMenuItem.Click += 開くoToolStripMenuItem_Click;
            // 
            // 上書き保存ToolStripMenuItem
            // 
            上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem";
            上書き保存ToolStripMenuItem.Size = new Size(180, 22);
            上書き保存ToolStripMenuItem.Text = "上書き保存";
            上書き保存ToolStripMenuItem.Click += 上書き保存ToolStripMenuItem_Click;
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            名前を付けて保存ToolStripMenuItem.Size = new Size(180, 22);
            名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存";
            名前を付けて保存ToolStripMenuItem.Click += 名前を付けて保存ToolStripMenuItem_Click;
            // 
            // hELPToolStripMenuItem
            // 
            hELPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 質問を投稿するToolStripMenuItem });
            hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            hELPToolStripMenuItem.Size = new Size(47, 20);
            hELPToolStripMenuItem.Text = "HELP";
            // 
            // 質問を投稿するToolStripMenuItem
            // 
            質問を投稿するToolStripMenuItem.Name = "質問を投稿するToolStripMenuItem";
            質問を投稿するToolStripMenuItem.Size = new Size(180, 22);
            質問を投稿するToolStripMenuItem.Text = "質問を投稿する";
            質問を投稿するToolStripMenuItem.Click += 質問を投稿するToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbsRollBar1);
            Controls.Add(gbsEditor1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "無題のドキュメント";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GBS.WinForms.GbsEditor gbsEditor1;
        private GBS.WinForms.GbsRollBar gbsRollBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 開くoToolStripMenuItem;
        private ToolStripMenuItem 上書き保存ToolStripMenuItem;
        private ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem hELPToolStripMenuItem;
        private ToolStripMenuItem 質問を投稿するToolStripMenuItem;
    }
}

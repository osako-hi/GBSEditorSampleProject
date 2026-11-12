using GBS.WinForms;
using System.IO;
namespace GBS.Sample.WinForms

{
    public partial class Form1 : Form

    {


        private string? _currentFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void 開くoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "すべてのファイル (*.*)|*.*"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            if (!ConfirmSaveChanges())
                return;

            gbsEditor1.Open(dialog.FileName);
            _currentFile = dialog.FileName;
        }

        private void 上書き保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private bool SaveFile()
        {
            if (_currentFile == null)
                return SaveFileAs();

            gbsEditor1.Save();
            return true;
        }

        private bool SaveFileAs()
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "テキストファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*",
                FileName = _currentFile != null
                    ? Path.GetFileName(_currentFile)
                    : "無題.txt"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
                return false;

            gbsEditor1.SaveAs(dialog.FileName);
            _currentFile = dialog.FileName;

            Text = $"GBS Sample - {Path.GetFileName(_currentFile)}";
            return true;
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private bool ConfirmSaveChanges()
        {
            if (!gbsEditor1.IsModified)
                return true;

            var result = MessageBox.Show(
                this,
                "変更内容が保存されていません。\n保存しますか？",
                "GBS Sample",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            switch (result)
            {
                case DialogResult.Yes:
                    return SaveFile();

                case DialogResult.No:
                    return true;

                default:
                    return false;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        // 新規作成
        private void NewFile()
        {
            if (!ConfirmSaveChanges())
                return;

            // ここに既存の新規作成処理
            _currentFile = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmSaveChanges())
                e.Cancel = true;
        }

        private void 質問を投稿するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = GbsSupport.CreatePostUrl();

            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo(url)
                {
                    UseShellExecute = true
                });
        }
    }
}

using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace V_EditorPro
{
    public partial class MainForm : Form
    {
        public MainForm(string filePath = null)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);

            if (!string.IsNullOrEmpty(filePath))
            {
                OpenFile(filePath);
            }
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                OpenFile();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFile();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void searchReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SearchReplaceDialog searchReplaceDialog = new SearchReplaceDialog(richTextBox1))
            {
                searchReplaceDialog.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutWindow = new AboutForm())
            {
                aboutWindow.ShowDialog();
            }
        }

        private void OpenFile(string filePath)
        {
            richTextBox1.Text = File.ReadAllText(filePath);
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Markdown Files (*.md)|*.md|Batch Files (*.bat)|*.bat|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog.FileName);
            }
        }

        private void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = $"{DateTime.Now.ToString("yyyy-MM-dd")}.txt";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Markdown Files (*.md)|*.md|Batch Files (*.bat)|*.bat|All Files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
            }
        }
    }
}
using System;
using System.Windows.Forms;

namespace V_EditorPro
{
    public partial class SearchReplaceDialog : Form
    {
        private RichTextBox _richTextBox;

        public SearchReplaceDialog(RichTextBox richTextBox)
        {
            InitializeComponent();
            _richTextBox = richTextBox;
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            int startIndex = _richTextBox.SelectionStart + _richTextBox.SelectionLength;
            int wordStartIndex = _richTextBox.Find(txtFind.Text, startIndex, RichTextBoxFinds.None);
            if (wordStartIndex != -1)
            {
                _richTextBox.Select(wordStartIndex, txtFind.Text.Length);
                _richTextBox.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Text not found");
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (_richTextBox.SelectedText == txtFind.Text)
            {
                _richTextBox.SelectedText = txtReplace.Text;
            }
            btnFindNext.PerformClick();
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            _richTextBox.Text = _richTextBox.Text.Replace(txtFind.Text, txtReplace.Text);
        }

        private void InitializeComponent()
        {
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(12, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(200, 20);
            this.txtFind.TabIndex = 0;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(12, 38);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(200, 20);
            this.txtReplace.TabIndex = 1;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(218, 10);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(218, 36);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(218, 65);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 4;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // SearchReplaceDialog
            // 
            this.ClientSize = new System.Drawing.Size(305, 100);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtFind);
            this.Name = "SearchReplaceDialog";
            this.Text = "SearchReplaceDialog";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
    }
}
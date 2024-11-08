using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace smolEdit
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            label1.Text = $"by abrendan\nVersion 1.2\nOS: {RuntimeInformation.OSDescription}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
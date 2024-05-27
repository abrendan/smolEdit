using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace V_EditorPro
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            label1.Text = $"V_EditorPro\nVersion 1.0\nOS: {RuntimeInformation.OSDescription}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
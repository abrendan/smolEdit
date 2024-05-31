using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_EditorPro;

namespace V_EditorPro
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                // A file was passed as an argument
                string filePath = args[0];

                // Create the main form and pass the file path to it
                Application.Run(new MainForm(filePath));
            }
            else
            {
                // No file was passed as an argument
                Application.Run(new MainForm());

            }
        }
    }
}
using System;
using System.Diagnostics;
using System.Windows.Forms;
using InternetStatus.Properties;
using System.Runtime.InteropServices;

namespace InternetStatus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show(Resources.AnotherInstance, Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}

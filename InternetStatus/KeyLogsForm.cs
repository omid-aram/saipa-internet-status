using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InternetStatus
{
    public partial class KeyLogsForm : Form
    {
        public KeyLogsForm()
        {
            InitializeComponent();
        }

        public void ShowLog()
        {
            txtKeyLogs.ResetText();

            while (KeyboardHook.KeyLogs.Count > 60)
            {
                KeyboardHook.KeyLogs.Remove(KeyboardHook.KeyLogs.First().Key);
            }

            foreach (var item in KeyboardHook.KeyLogs)
            {
                txtKeyLogs.AppendText($"[{item.Key.ToString("f")}]");
                txtKeyLogs.AppendText(Environment.NewLine);
                txtKeyLogs.AppendText($"{item.Value}");
                txtKeyLogs.AppendText(Environment.NewLine);
                txtKeyLogs.AppendText(Environment.NewLine);
            }

            this.Show();

            if (!tmrRefresh.Enabled)
            {
                tmrRefresh.Start();
            }
        }

        private void KeyLogsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible)
            {
                tmrRefresh.Stop();
                this.Hide();
                e.Cancel = true;
            }
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                ShowLog();
            }
        }
    }
}

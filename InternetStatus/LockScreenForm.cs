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
    public partial class LockScreenForm : Form
    {
        public LockScreenForm()
        {
            InitializeComponent();
        }

        public void SetDateAndTime()
        {
            lblTime.Text = DateTime.Now.ToString("H:mm");
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM d");
        }

        private void LockScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible)
            {
                e.Cancel = true;
            }
        }

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
    }
}

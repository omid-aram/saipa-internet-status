
namespace InternetStatus
{
    partial class KeyLogsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtKeyLogs = new System.Windows.Forms.TextBox();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtKeyLogs
            // 
            this.txtKeyLogs.AcceptsReturn = true;
            this.txtKeyLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyLogs.BackColor = System.Drawing.Color.Black;
            this.txtKeyLogs.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtKeyLogs.Location = new System.Drawing.Point(0, 0);
            this.txtKeyLogs.Multiline = true;
            this.txtKeyLogs.Name = "txtKeyLogs";
            this.txtKeyLogs.ReadOnly = true;
            this.txtKeyLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyLogs.Size = new System.Drawing.Size(799, 449);
            this.txtKeyLogs.TabIndex = 0;
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 1000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // KeyLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKeyLogs);
            this.Name = "KeyLogsForm";
            this.Text = "Key Logs";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyLogsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyLogs;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}
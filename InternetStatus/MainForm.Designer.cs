namespace InternetStatus
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInternetStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTotalTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTotalReceived = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTotalSent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuIsAllowConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConnectionTip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConnectUrl = new System.Windows.Forms.TextBox();
            this.lblSent = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgToggleButton = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusLogo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuRefresh = new System.Windows.Forms.ToolStripSplitButton();
            this.checkEveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSec60 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSec40 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSec20 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmailLogo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEmail = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerPage = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.imgStatus = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgToggleButton)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "Internet Status";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Internet Status";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.btnShowForm_Click);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.btnShowForm_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeader,
            this.mnuInternetStatus,
            this.mnuTotalTime,
            this.mnuTotalReceived,
            this.mnuTotalSent,
            this.btnRefresh,
            this.toolStripMenuItem1,
            this.mnuIsAllowConnection,
            this.mnuConnectionTip,
            this.toolStripSeparator1,
            this.btnShowForm,
            this.toolStripMenuItem2,
            this.btnClose});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(176, 242);
            // 
            // mnuHeader
            // 
            this.mnuHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnuHeader.Name = "mnuHeader";
            this.mnuHeader.Size = new System.Drawing.Size(175, 22);
            this.mnuHeader.Text = "Internet Status";
            // 
            // mnuInternetStatus
            // 
            this.mnuInternetStatus.Name = "mnuInternetStatus";
            this.mnuInternetStatus.Size = new System.Drawing.Size(175, 22);
            this.mnuInternetStatus.Text = "Internet Status";
            this.mnuInternetStatus.Visible = false;
            // 
            // mnuTotalTime
            // 
            this.mnuTotalTime.Name = "mnuTotalTime";
            this.mnuTotalTime.Size = new System.Drawing.Size(175, 22);
            this.mnuTotalTime.Text = "Total Time";
            // 
            // mnuTotalReceived
            // 
            this.mnuTotalReceived.Name = "mnuTotalReceived";
            this.mnuTotalReceived.Size = new System.Drawing.Size(175, 22);
            this.mnuTotalReceived.Text = "Total Received";
            // 
            // mnuTotalSent
            // 
            this.mnuTotalSent.Name = "mnuTotalSent";
            this.mnuTotalSent.Size = new System.Drawing.Size(175, 22);
            this.mnuTotalSent.Text = "Total Sent";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(175, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuIsAllowConnection
            // 
            this.mnuIsAllowConnection.CheckOnClick = true;
            this.mnuIsAllowConnection.Name = "mnuIsAllowConnection";
            this.mnuIsAllowConnection.Size = new System.Drawing.Size(175, 22);
            this.mnuIsAllowConnection.Text = "Allow Connection";
            this.mnuIsAllowConnection.ToolTipText = "I will disconnect the internet, if it is connected.";
            this.mnuIsAllowConnection.CheckedChanged += new System.EventHandler(this.mnuIsAllowConnection_CheckedChanged);
            // 
            // mnuConnectionTip
            // 
            this.mnuConnectionTip.ForeColor = System.Drawing.Color.DarkRed;
            this.mnuConnectionTip.Name = "mnuConnectionTip";
            this.mnuConnectionTip.Size = new System.Drawing.Size(175, 22);
            this.mnuConnectionTip.Text = "Not Allowed!";
            this.mnuConnectionTip.Click += new System.EventHandler(this.mnuConnectionTip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // btnShowForm
            // 
            this.btnShowForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.Size = new System.Drawing.Size(175, 22);
            this.btnShowForm.Text = "Show Status Form";
            this.btnShowForm.Click += new System.EventHandler(this.btnShowForm_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 6);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 22);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "disconnect.ico");
            this.imageList.Images.SetKeyName(1, "connect.ico");
            this.imageList.Images.SetKeyName(2, "appbar.timer.16.png");
            this.imageList.Images.SetKeyName(3, "appbar.download.16.png");
            this.imageList.Images.SetKeyName(4, "appbar.upload.16.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lstLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(248, 90);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(370, 303);
            this.panel1.TabIndex = 0;
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.Color.MidnightBlue;
            this.lstLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lstLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.IntegralHeight = false;
            this.lstLog.ItemHeight = 14;
            this.lstLog.Location = new System.Drawing.Point(6, 6);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(358, 291);
            this.lstLog.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtConnectUrl);
            this.panel2.Controls.Add(this.lblSent);
            this.panel2.Controls.Add(this.lblReceived);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblDisplayName);
            this.panel2.Controls.Add(this.lblUserId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 303);
            this.panel2.TabIndex = 1;
            // 
            // txtConnectUrl
            // 
            this.txtConnectUrl.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtConnectUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConnectUrl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConnectUrl.Location = new System.Drawing.Point(18, 3);
            this.txtConnectUrl.Name = "txtConnectUrl";
            this.txtConnectUrl.Size = new System.Drawing.Size(211, 13);
            this.txtConnectUrl.TabIndex = 1;
            this.txtConnectUrl.Text = "http://iran.ir";
            // 
            // lblSent
            // 
            this.lblSent.BackColor = System.Drawing.Color.Transparent;
            this.lblSent.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSent.Location = new System.Drawing.Point(101, 255);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(142, 25);
            this.lblSent.TabIndex = 0;
            this.lblSent.Text = "User Id:";
            // 
            // lblReceived
            // 
            this.lblReceived.BackColor = System.Drawing.Color.Transparent;
            this.lblReceived.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblReceived.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReceived.Location = new System.Drawing.Point(101, 231);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(142, 25);
            this.lblReceived.TabIndex = 0;
            this.lblReceived.Text = "User Id:";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDate.Location = new System.Drawing.Point(101, 163);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(142, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "User Id:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(15, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sent:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(15, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Received:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(15, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(101, 188);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(142, 25);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "User Id:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(15, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Time:";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoEllipsis = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDisplayName.Location = new System.Drawing.Point(101, 60);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(142, 103);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "User Id:";
            // 
            // lblUserId
            // 
            this.lblUserId.BackColor = System.Drawing.Color.Transparent;
            this.lblUserId.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserId.Location = new System.Drawing.Point(101, 35);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(142, 25);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User Id:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id:";
            // 
            // imgToggleButton
            // 
            this.imgToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgToggleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgToggleButton.Image = global::InternetStatus.Properties.Resources.switch_off;
            this.imgToggleButton.Location = new System.Drawing.Point(492, 35);
            this.imgToggleButton.Name = "imgToggleButton";
            this.imgToggleButton.Size = new System.Drawing.Size(114, 40);
            this.imgToggleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgToggleButton.TabIndex = 2;
            this.imgToggleButton.TabStop = false;
            this.imgToggleButton.Click += new System.EventHandler(this.imgToggleButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(308, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Allow Connection:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusLogo,
            this.lblStatus,
            this.lblMessage,
            this.mnuRefresh,
            this.lblEmailLogo,
            this.lblEmail});
            this.statusStrip.Location = new System.Drawing.Point(0, 393);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(618, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatusLogo
            // 
            this.lblStatusLogo.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblStatusLogo.Name = "lblStatusLogo";
            this.lblStatusLogo.Size = new System.Drawing.Size(19, 17);
            this.lblStatusLogo.Text = "Q";
            // 
            // lblStatus
            // 
            this.lblStatus.DoubleClickEnabled = true;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 17);
            this.lblStatus.Text = "Disco‭nnected";
            this.lblStatus.DoubleClick += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(310, 17);
            this.lblMessage.Spring = true;
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuRefresh.DropDownButtonWidth = 18;
            this.mnuRefresh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkEveryToolStripMenuItem,
            this.toolStripSeparator2,
            this.mnuSec60,
            this.mnuSec40,
            this.mnuSec20});
            this.mnuRefresh.Font = new System.Drawing.Font("Wingdings", 9.75F);
            this.mnuRefresh.Image = ((System.Drawing.Image)(resources.GetObject("mnuRefresh.Image")));
            this.mnuRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Size = new System.Drawing.Size(38, 20);
            this.mnuRefresh.Text = "6";
            this.mnuRefresh.ButtonClick += new System.EventHandler(this.btnRefresh_Click);
            // 
            // checkEveryToolStripMenuItem
            // 
            this.checkEveryToolStripMenuItem.Enabled = false;
            this.checkEveryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.checkEveryToolStripMenuItem.Name = "checkEveryToolStripMenuItem";
            this.checkEveryToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.checkEveryToolStripMenuItem.Text = "Check every ...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // mnuSec60
            // 
            this.mnuSec60.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuSec60.Name = "mnuSec60";
            this.mnuSec60.Size = new System.Drawing.Size(155, 22);
            this.mnuSec60.Tag = "60";
            this.mnuSec60.Text = "60 Seconds";
            this.mnuSec60.Click += new System.EventHandler(this.mnuCheckEvery_Click);
            // 
            // mnuSec40
            // 
            this.mnuSec40.Checked = true;
            this.mnuSec40.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSec40.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuSec40.Name = "mnuSec40";
            this.mnuSec40.Size = new System.Drawing.Size(155, 22);
            this.mnuSec40.Tag = "40";
            this.mnuSec40.Text = "40 Seconds";
            this.mnuSec40.Click += new System.EventHandler(this.mnuCheckEvery_Click);
            // 
            // mnuSec20
            // 
            this.mnuSec20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuSec20.Name = "mnuSec20";
            this.mnuSec20.Size = new System.Drawing.Size(155, 22);
            this.mnuSec20.Tag = "20";
            this.mnuSec20.Text = "20 Seconds";
            this.mnuSec20.Click += new System.EventHandler(this.mnuCheckEvery_Click);
            // 
            // lblEmailLogo
            // 
            this.lblEmailLogo.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblEmailLogo.Name = "lblEmailLogo";
            this.lblEmailLogo.Size = new System.Drawing.Size(22, 17);
            this.lblEmailLogo.Text = "*";
            this.lblEmailLogo.Click += new System.EventHandler(this.lblEmailLogo_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(104, 17);
            this.lblEmail.Text = "khoshniat@gmail.com";
            this.lblEmail.Visible = false;
            // 
            // timerPage
            // 
            this.timerPage.Enabled = true;
            this.timerPage.Interval = 40000;
            this.timerPage.Tick += new System.EventHandler(this.timerPage_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Controls.Add(this.imgStatus);
            this.pnlTop.Controls.Add(this.imgToggleButton);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(618, 90);
            this.pnlTop.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(81, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "Internet Status";
            // 
            // imgStatus
            // 
            this.imgStatus.Image = global::InternetStatus.Properties.Resources.globe_gray;
            this.imgStatus.Location = new System.Drawing.Point(15, 15);
            this.imgStatus.Name = "imgStatus";
            this.imgStatus.Size = new System.Drawing.Size(60, 60);
            this.imgStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgStatus.TabIndex = 3;
            this.imgStatus.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(618, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(634, 449);
            this.Name = "MainForm";
            this.Text = "Internet Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgToggleButton)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuInternetStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnShowForm;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSent;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.ToolStripStatusLabel lblEmail;
        private System.Windows.Forms.Timer timerPage;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusLogo;
        private System.Windows.Forms.ToolStripStatusLabel lblEmailLogo;
        private System.Windows.Forms.ToolStripMenuItem mnuIsAllowConnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imgToggleButton;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox imgStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripSplitButton mnuRefresh;
        private System.Windows.Forms.ToolStripMenuItem mnuSec60;
        private System.Windows.Forms.ToolStripMenuItem mnuSec40;
        private System.Windows.Forms.ToolStripMenuItem mnuSec20;
        private System.Windows.Forms.ToolStripMenuItem checkEveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuTotalTime;
        private System.Windows.Forms.ToolStripMenuItem mnuTotalReceived;
        private System.Windows.Forms.ToolStripMenuItem mnuTotalSent;
        private System.Windows.Forms.ToolStripMenuItem mnuHeader;
        private System.Windows.Forms.ToolStripMenuItem mnuConnectionTip;
        private System.Windows.Forms.TextBox txtConnectUrl;
    }
}


using System;
using System.ComponentModel;
using System.DirectoryServices;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using InternetStatus.Properties;
using Microsoft.Win32;

namespace InternetStatus
{
    public enum Status
    {
        Loading,
        Connected,
        Disconnected,
        NoNetwork,
        Connecting,
        Disconnecting
    }

    public partial class MainForm : Form
    {
        #region Properties

        private string _userId;
        private string _displayName;
        private string _upTime;
        private string _recieved;
        private string _sent;
        private Stream _data;

        private WebClient WebClient { get; set; }

        private readonly BackgroundWorker _worker;

        private readonly BackgroundWorker _workerStatus;

        private readonly MainModel _myModel = new MainModel();

        private Status? LastStatus { get; set; }
        private Status MyStatus { get; set; }

        private bool IsAllowConnection
        {
            get { return mnuIsAllowConnection.Checked; }
        }

        private bool IsInitHide { get; set; }

        private string _myToolTipText;

        public string MyToolTipText
        {
            get { return _myToolTipText; }
            set
            {
                _myToolTipText = value;
                notifyIcon.BalloonTipText = notifyIcon.Text = lblStatus.Text = value;
                mnuInternetStatus.Text = string.Format("{0}", value);
            }
        }

        public int TimerInterval
        {
            get { return _myModel.Interval; }
            set
            {
                if (_myModel.Interval == value)
                    return;

                _myModel.Interval = value;
                timerPage.Interval = value * 1000;
                timerPage.Start();

                mnuSec20.Checked = int.Parse(mnuSec20.Tag.ToString()) == value;
                mnuSec40.Checked = int.Parse(mnuSec40.Tag.ToString()) == value;
                mnuSec60.Checked = int.Parse(mnuSec60.Tag.ToString()) == value;

                LogStatus(string.Format("Checking every {0} seconds...", value));
            }
        }

        private const long Kb = 1024;
        private const long Mb = 1048576; //1024 * 1024;
        private const long Gb = 1073741824; //1024 * 1024 * 1024;
        private const long Tb = 1099511627776; //1024 * 1024 * 1024 * 1024;
        private const long Pb = 1125899906842624; //1024 * 1024 * 1024 * 1024 * 1024;

        #endregion

        #region Methods

        private void InstallMeOnStartUp()
        {
            try
            {
                RegistryKey key =
                    Registry.CurrentUser.OpenSubKey(
                        "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (key != null)
                {
                    Assembly curAssembly = Assembly.GetExecutingAssembly();
                    key.SetValue("InternetStatus", curAssembly.Location);
                }
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        private void RefreshPage()
        {
            if (!_workerStatus.IsBusy)
            {
                var today = GetPersianDate(DateTime.Now);
                if (Settings.Default.Date != today)
                {
                    CloseCurrentSession();
                    OpenNewSession();
                }

                MyStatus = Status.Loading;
                ChangeStatus();

                _workerStatus.RunWorkerAsync();
            }
        }

        private void ReadValues(string response)
        {
            response = response.Substring(1, response.Length - 2).ToUpper();

            _userId = GetValue(response, "USERNAME");
            _upTime = GetValue(response, "UPTIME");
            _recieved = GetValue(response, "INCOMING");
            _sent = GetValue(response, "OUTGOING");

            MyStatus = GetValue(response, "STATUS") == "1" ? Status.Connected : Status.Disconnected;
            ChangeStatus();

            if (string.IsNullOrEmpty(_displayName) || _userId != _myModel.UserId)
            {
                if (!_worker.IsBusy)
                {
                    _worker.RunWorkerAsync();
                }
            }
        }

        private string GetValue(string json, string name)
        {
            var nameIndex = json.IndexOf(name, StringComparison.Ordinal);
            var colonIndex = json.IndexOf(':', nameIndex);
            var endValueIndex = json.IndexOf(',', colonIndex + 1);

            var result = (endValueIndex > 0)
                ? json.Substring(colonIndex + 1, endValueIndex - colonIndex - 1)
                : json.Substring(colonIndex + 1);

            if (result.Length > 0 && result[0] == '"')
            {
                result = result.Substring(1, result.Length - 2);
            }

            return result.Trim();
        }

        private static TimeSpan StringToTimeSpan(string time)
        {
            var timeSplited = time.Split(':');
            return new TimeSpan(int.Parse(timeSplited[0]), int.Parse(timeSplited[1]), int.Parse(timeSplited[2]));
        }

        private long StringSizeToByte(string size)
        {
            size = size ?? string.Empty;
            var parts = size.Split(' ');
            if (parts.Length > 3)
            {
                var num = double.Parse(parts[0], NumberFormatInfo.InvariantInfo);
                var unit = parts[2][0];

                if (unit == 'B')
                {
                    return (long)num;
                }
                if (unit == 'K')
                {
                    return (long)(num * 1024);
                }
                if (unit == 'M')
                {
                    return (long)(num * 1024 * 1024);
                }
                if (unit == 'G')
                {
                    return (long)(num * 1024 * 1024 * 1024);
                }
                if (unit == 'T')
                {
                    return (long)(num * 1024 * 1024 * 1024 * 1024);
                }
            }
            return 0;
        }

        private string SizeToString(long size)
        {
            if (size < Kb * 0.9)
            {
                return string.Format("{0} B", size);
            }
            if (size < Mb * 0.9)
            {
                return string.Format("{0:F2} KB", (double)size / Kb);
            }
            if (size < Gb * 0.9)
            {
                return string.Format("{0:F2} MB", (double)size / Mb);
            }
            if (size < Tb * 0.9)
            {
                return string.Format("{0:F2} GB", (double)size / Gb);
            }
            if (size < Pb * 0.9)
            {
                return string.Format("{0:F2} TB", (double)size / Tb);
            }

            return size.ToString(CultureInfo.InvariantCulture);
        }

        private void PrintModel()
        {
            lblDisplayName.Text = _myModel.DisplayName;
            lblUserId.Text = _myModel.UserId;
            lblDate.Text = _myModel.Date;
            lblTime.Text = _myModel.UpTime.ToString();
            lblReceived.Text = SizeToString(_myModel.Recieved);
            lblSent.Text = SizeToString(_myModel.Sent);

            mnuTotalTime.Text = lblTime.Text;
            mnuTotalReceived.Text = lblReceived.Text;
            mnuTotalSent.Text = lblSent.Text;
        }

        private void WriteStatusTexts()
        {
            switch (MyStatus)
            {
                case Status.Loading:
                    {
                        MyToolTipText = Resources.Loading;
                        break;
                    }
                case Status.Connecting:
                    {
                        MyToolTipText = Resources.Connecting;
                        lblStatusLogo.Text = Resources.LogoLoading;
                        break;
                    }
                case Status.Disconnecting:
                    {
                        MyToolTipText = Resources.Disconnecting;
                        lblStatusLogo.Text = Resources.LogoLoading;
                        break;
                    }
                case Status.Connected:
                    {
                        MyToolTipText = Resources.Connected;
                        lblStatusLogo.Text = _myModel.IsSync ? Resources.LogoConnectedSync : Resources.LogoConnected;

                        _myModel.DisplayName = _displayName;
                        _myModel.UserId = _userId;
                        _myModel.UpTime = Settings.Default.UpTime + StringToTimeSpan(_upTime);
                        _myModel.Recieved = Settings.Default.Recieved + StringSizeToByte(_recieved);
                        _myModel.Sent = Settings.Default.Sent + StringSizeToByte(_sent);
                        PrintModel();
                        break;
                    }
                case Status.Disconnected:
                    {
                        MyToolTipText = Resources.Disconnected;
                        lblStatusLogo.Text = Resources.LogoDisconnected;
                        break;
                    }
                case Status.NoNetwork:
                    {
                        MyToolTipText = Resources.NoNetwork;
                        lblStatusLogo.Text = Resources.LogoDisconnected;
                        break;
                    }
            }
        }

        private void ChangeStatus()
        {
            WriteStatusTexts();

            if (MyStatus == Status.Loading ||
                MyStatus == LastStatus)
            {
                return;
            }

            LogStatus(string.Format("{0}{1}", MyStatus, MyStatus == Status.Connected ? " : " + _userId : string.Empty));

            LastStatus = MyStatus;
            switch (MyStatus)
            {
                case Status.Loading:
                case Status.Connecting:
                case Status.Disconnecting:
                    {
                        return;
                    }
                case Status.Connected:
                    {
                        //OpenNewSession();
                        notifyIcon.Icon = Icon.FromHandle(((Bitmap)imageList.Images[1]).GetHicon());
                        mnuHeader.Image = imageList.Images[1];

                        imgStatus.Image = Resources.globe;
                        pnlTop.BackColor = mnuHeader.BackColor = Color.DeepSkyBlue;
                        
                        

                        if (!IsAllowConnection)
                        {
                            Disconnect();
                        }

                        break;
                    }
                case Status.Disconnected:
                case Status.NoNetwork:
                    {
                        CloseCurrentSession();
                        notifyIcon.Icon = Icon.FromHandle(((Bitmap)imageList.Images[0]).GetHicon());
                        mnuHeader.Image = imageList.Images[0];

                        imgStatus.Image = Resources.globe_gray;
                        pnlTop.BackColor = Color.WhiteSmoke;
                        mnuHeader.BackColor = Color.LightGray;

                        break;
                    }
            }

            if (MyStatus != Status.NoNetwork)
            {
                notifyIcon.ShowBalloonTip(5000);
            }
        }

        public static string RemoveSpecialCharacters(string str)
        {
            var sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') ||
                    c == '.' || c == ',' || c == '_' || c == '-' || c == ' ' || c == '(' || c == ')')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private void SignOutClick()
        {
            const string url = "http://172.18.255.33:1398/signout.cgi?submit=%D8%AE%D8%B1%D9%88%D8%AC";
            var data = WebClient.OpenRead(url);
            if (data != null) data.Close();
        }

        private void Disconnect()
        {
            MyStatus = Status.Disconnecting;
            WriteStatusTexts();

            SignOutClick();

            MyStatus = Status.Disconnected;
            ChangeStatus();
        }

        private void CloseCurrentSession()
        {
            Settings.Default.DisplayName = _myModel.DisplayName;
            Settings.Default.UserId = _myModel.UserId;
            Settings.Default.Date = _myModel.Date;
            Settings.Default.UpTime = new TimeSpan(_myModel.UpTime.Ticks);
            Settings.Default.Recieved = _myModel.Recieved;
            Settings.Default.Sent = _myModel.Sent;
            Settings.Default.IsSync = _myModel.IsSync;
            Settings.Default.Interval = TimerInterval;

            Settings.Default.Save();

            //LogStatus("Values are saved.");
        }

        private string GetPersianDate(DateTime date)
        {
            var calendar = new PersianCalendar();
            return string.Format("{0}/{1:D2}/{2:D2}", calendar.GetYear(date), calendar.GetMonth(date),
                calendar.GetDayOfMonth(date));
        }

        private void OpenNewSession()
        {
            var today = GetPersianDate(DateTime.Now);
            if (Settings.Default.Date != today)
            {
                var recieved = SizeToString(Settings.Default.Recieved);
                var sent = SizeToString(Settings.Default.Sent);
                const int len = 12;
                LogStatus(string.Format("┌──────────────────┬──────────────┐"));
                LogStatus(string.Format("│ Summary usage of │ {0}{1} │", Settings.Default.Date, new string(' ', len - Settings.Default.Date.Length)), true);
                LogStatus(string.Format("│   Total UpTime   │ {0}{1} │", Settings.Default.UpTime, new string(' ', len - Settings.Default.UpTime.ToString().Length)), true);
                LogStatus(string.Format("│   Total Recieved │ {0}{1} │", recieved, new string(' ', len - recieved.Length)), true);
                LogStatus(string.Format("│   Total Sent     │ {0}{1} │", sent, new string(' ', len - sent.Length)), true);
                LogStatus(string.Format("└──────────────────┴──────────────┘"), true);

                Settings.Default.UserId = string.Empty;
                Settings.Default.Date = string.Empty;
                Settings.Default.UpTime = new TimeSpan();
                Settings.Default.Recieved = 0;
                Settings.Default.Sent = 0;
                Settings.Default.IsSync = false;
                Settings.Default.Interval = TimerInterval;

                Settings.Default.Save();
            }

            _myModel.Date = today;
            _myModel.DisplayName = _displayName = Settings.Default.DisplayName;
            _myModel.UserId = _userId = Settings.Default.UserId;
            _myModel.UpTime = new TimeSpan(Settings.Default.UpTime.Ticks);
            _myModel.Recieved = Settings.Default.Recieved;
            _myModel.Sent = Settings.Default.Sent;
            _myModel.IsSync = Settings.Default.IsSync;
            TimerInterval = Settings.Default.Interval;
            PrintModel();

            //LogStatus("Saved values are recovered.");
        }

        public string FindDisplayName()
        {
            if (!string.IsNullOrEmpty(_userId))
            {
                try
                {
                    using (var de = new DirectoryEntry("LDAP://saipacorp.com"))
                    {
                        using (var adSearch = new DirectorySearcher(de))
                        {
                            adSearch.Filter = string.Format("(sAMAccountName={0})", _userId);
                            SearchResult adSearchResult = adSearch.FindOne();
                            if (adSearchResult.Properties["displayname"].Count > 0)
                            {
                                return adSearchResult.Properties["displayname"][0].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ex.GetType();
                }
            }
            return String.Empty;
        }

        private void LogStatus(string text, bool noTime = false)
        {
            var now = DateTime.Now;
            lstLog.Items.Add(string.Format("{0} {1}", noTime ? "          " : string.Format("[{0:D2}:{1:D2}:{2:D2}]", now.Hour, now.Minute, now.Second), text));
            lstLog.SelectedIndex = lstLog.Items.Count - 1;
            lstLog.SelectedIndex = -1;
        }

        private void LocateForm()
        {
            var bound = Screen.PrimaryScreen.WorkingArea;

            Left = bound.Width - Width - 12;
            Top = bound.Height - Height - 12;
        }

        #endregion

        #region Events

        public MainForm()
        {
            try
            {
                InitializeComponent();

                _worker = new BackgroundWorker();
                _worker.DoWork += worker_DoWork;

                _workerStatus = new BackgroundWorker();
                _workerStatus.DoWork += workerStatus_DoWork;
                _workerStatus.RunWorkerCompleted += workerStatus_RunWorkerCompleted;

                Opacity = 0;

                LogStatus("Application Started.");
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        void workerStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (_data != null)
                {
                    var reader = new StreamReader(_data);
                    var response = reader.ReadToEnd();

                    ReadValues(response);

                    _data.Close();
                    reader.Close();
                }
                else
                {
                    MyStatus = Status.NoNetwork;
                    ChangeStatus();
                }
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        void workerStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                const string url = "http://172.18.255.33:1397/status.html?info=1";
                _data = WebClient.OpenRead(url);
            }
            catch (Exception)
            {
                _data = null;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LocateForm();

                WebClient = new WebClient();
                WebClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                MyStatus = Status.Loading;
                WriteStatusTexts();

                OpenNewSession();

                InstallMeOnStartUp();

                mnuIsAllowConnection.Checked = false; //Settings.Default.IsAllowConnection; //chkIsPrevent.Checked;

                RefreshPage();

                mnuTotalTime.Image = imageList.Images[2];
                mnuTotalReceived.Image = imageList.Images[3];
                mnuTotalSent.Image = imageList.Images[4];
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            _displayName = FindDisplayName();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    Hide();
                    e.Cancel = true;
                }
                else
                {
                    CloseCurrentSession();
                }
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        private void btnShowForm_Click(object sender, EventArgs e)
        {
            try
            {
                Show();
                WindowState = FormWindowState.Normal;
                Activate();
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshPage();
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        private void timerPage_Tick(object sender, EventArgs e)
        {
            try
            {
                RefreshPage();
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                //if (_myModel != null && !string.IsNullOrEmpty(_myModel.DisplayName))
                if (!IsInitHide)
                {
                    IsInitHide = true;
                    Opacity = 100;
                    Hide();
                }
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        private void mnuIsAllowConnection_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                imgToggleButton.Image = mnuIsAllowConnection.Checked
                    ? Resources.switch_on
                    : Resources.switch_off;

                LastStatus = null;
                LogStatus(string.Format("Allow Connection: {0}", mnuIsAllowConnection.Checked ? "ON" : "OFF"));

                if (mnuIsAllowConnection.Checked)
                {
                    mnuIsAllowConnection.ToolTipText =
                        string.Format("You may connect the internet and I just watch the usage.");
                    mnuConnectionTip.ForeColor = Color.Green;
                    mnuConnectionTip.Text = string.Format("Allowed.");
                }
                else
                {
                    mnuIsAllowConnection.ToolTipText =
                        string.Format("I will disconnect the internet, if it is connected.");
                    mnuConnectionTip.ForeColor = Color.DarkRed;
                    mnuConnectionTip.Text = string.Format("Not Allowed!");
                }

                if (!IsAllowConnection && MyStatus == Status.Connected)
                {
                    Disconnect();
                }
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        private void imgToggleButton_Click(object sender, EventArgs e)
        {
            try
            {
                mnuIsAllowConnection.Checked = !mnuIsAllowConnection.Checked;
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        private void lblEmailLogo_Click(object sender, EventArgs e)
        {
            try
            {
                lblEmail.Visible = !lblEmail.Visible;
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        private void mnuCheckEvery_Click(object sender, EventArgs e)
        {
            try
            {
                var menuItem = sender as ToolStripMenuItem;

                if (menuItem != null) 
                {
                    TimerInterval = int.Parse(menuItem.Tag.ToString());
                }
            }
            catch (Exception ex)
            {
                LogStatus(ex.Message);
            }
        }

        #endregion

        private void mnuConnectionTip_Click(object sender, EventArgs e)
        {
            mnuIsAllowConnection.PerformClick();
        }
    }
}
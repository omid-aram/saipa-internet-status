using System;
using System.Xml.Serialization;

namespace InternetStatus
{
    public class MainModel
    {
        public string DisplayName { get; set; }

        public string UserId { get; set; }

        public String Date { get; set; }

        private TimeSpan _upTime;
        [XmlIgnore]
        public TimeSpan UpTime
        {
            get { return _upTime; }
            set { _upTime = value; }
        }

        [XmlElement("UpTime")]
        public long UpTimeTicks
        {
            get { return _upTime.Ticks; }
            set { _upTime = new TimeSpan(value); }
        }

        public long Received { get; set; }

        public long Sent { get; set; }

        public bool IsSync { get; set; }

        public int Interval { get; set; }

        public bool IsNoSleep { get; set; }

        public bool IsAutoDC { get; set; }
    }
}

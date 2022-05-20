using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchApplication
{
    public class Stopwatch
    {
        public bool IsStart { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public TimeSpan Duration { get; set; }

        public void Start()
        {
            if (IsStart)
            {
                throw new InvalidOperationException();
            }
            StartTime = DateTime.Now;
            IsStart = true;//Indicating that stopwatch is now started.
        }

        public string Stop()
        {
            if (!IsStart)
            {
                throw new InvalidOperationException();
            }
            this.StopTime = DateTime.Now;
            this.Duration = this.StopTime - this.StartTime;
            IsStart = false;//indicating that stopwatch stopped

            return Duration.Seconds.ToString();
        }
    }
}

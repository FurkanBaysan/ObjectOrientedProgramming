using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchApplication
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException();
            }
            this._startTime = DateTime.Now;
            _running = true; // Indicating that stopwatch is now started.
        }

        public void Stop()
        {
            if (!_running)
            {
                throw new InvalidOperationException();
            }

            this._endTime = DateTime.Now;
            _running = false; // indicating that stopwatch stopped
        }

        public TimeSpan GetInterval()
        {
            TimeSpan duration = _endTime - _startTime;
            return duration;
        }
    }
}

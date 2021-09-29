using System;

namespace StopWatch
{
    public class StartEnd
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _flag = false;

        public DateTime StartTime()
        {
            if (_flag)
                throw new InvalidOperationException("Stopwatch is Already Started!");

            _startTime = DateTime.Now;
            _flag = true;
            return _startTime;
        }
        public DateTime EndTime()
        {
            if (!_flag)
                throw new InvalidOperationException("Stopwath is not Running!");

            _endTime = DateTime.Now;
            _flag = false;
            return _endTime;

        }
        public TimeSpan GetTime(DateTime end, DateTime start)
        {
            return end - start;
        }
    }
}

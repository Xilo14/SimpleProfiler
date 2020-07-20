using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SimpleProfiler
{
    public class TimeProfiler : IDisposable
    {
        private DateTime _start;
        private DateTime _finish;
        private Stopwatch _stopwatch;
        public TimeProfiler()
        {
            _start = DateTime.Now;
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        public void Dispose()
        {
            _stopwatch.Stop();
            _finish = DateTime.Now;

            RegisterRecord record = new RegisterRecord(
                this._start,
                this._finish,
                this._stopwatch.Elapsed);

            PerfRegister.Records.Add(record);
        }
    }

    public struct RegisterRecord : IRegisterRecord
    {
        public RegisterRecord(DateTime Start, DateTime Finish, TimeSpan Elapsed)
        {
            this.Start = Start;
            this.Finish = Finish;
            this.Elapsed = Elapsed;
        }

        public DateTime Start { get; }
        public DateTime Finish { get; }
        public TimeSpan Elapsed { get; }
    }
}

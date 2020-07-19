using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProfiler
{
    public static class PerfRegister
    {
        public static List<RegisterRecord> Records { get; set; } = new List<RegisterRecord>();

        public static RegisterRecord? LastRecord
        {
            get
            {
                if (Records.Count > 0)
                    return Records[Records.Count - 1];
                else
                    return null;
            }

        }
    }

    public struct RegisterRecord
    {
        public DateTime Start;
        public DateTime Finish;
        public TimeSpan Elapsed;

        public RegisterRecord(DateTime Start,DateTime Finish,TimeSpan Elapsed)
        {
            this.Start = Start;
            this.Finish = Finish;
            this.Elapsed = Elapsed;
        }
    }
}

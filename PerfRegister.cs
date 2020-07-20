using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProfiler
{
    public static class PerfRegister
    {
        public static List<IRegisterRecord> Records { get; set; } = new List<IRegisterRecord>();

        public static IRegisterRecord? LastRecord
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
    public interface IRegisterRecord {
        public DateTime Start { get; }
        public DateTime Finish { get; }
        public TimeSpan Elapsed { get; }
    }
   
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace CountingTimeApp
{
    public sealed class ProcessList
    {
        public List<MyProces> processes = new List<MyProces>();

        private static readonly Lazy<ProcessList> lazy = new Lazy<ProcessList> (() => new ProcessList());

        public static ProcessList Instance { get { return lazy.Value; } }

        private ProcessList()
        {
        }
        public void startCountingTimeForProcess(MyProces currentProces)
        {
           MyProces procesFromList = processes.Find(x => x.Name == currentProces.Name);
           procesFromList.StartTime = DateTime.Now;
        }
        public void startCountingTimeForProcess(int indexProces)
        {
            MyProces procesFromList = processes[indexProces];
            procesFromList.StartTime = DateTime.Now;
        }
    }
}

using System;

namespace CountingTimeApp
{
    public class MyProces
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime StartTime { get; set; }
        public string MainWindowTitle { get; set; }
        public bool TimeIsCounted { get; set; }
        public TimeSpan Time { get; set; }
    }
}

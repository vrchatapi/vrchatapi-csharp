using System;

namespace VRChat.API.Realtime.Models
{
    public class LogEventArgs : EventArgs
    {
        public Exception Exception { get; set; }
        public string Message { get; set; }
        public LogLevel Level { get; set; }
    }

    public enum LogLevel
    {
        Trace,
        Debug,
        Info,
        Warning,
        Error,
        Critical
    }
}


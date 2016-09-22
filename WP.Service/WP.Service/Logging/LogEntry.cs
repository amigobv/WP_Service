using System;
using WP.Service.Helper;

namespace WP.Service.Logging
{
    public class LogEntry
    {
        private static readonly char[] SPLIT_CHARS = {'|'};

        public string DateTime { get; private set; }
        public string LogLevel { get; private set; }
        public string Logger { get; private set; }
        public string Message { get; private set; }
        public string Exception { get; private set; }
        private LogEntry()
        {
            
        }

        public LogEntry(string dateTime, string logLevel, string logger, string message, string exception)
        {
            DateTime = dateTime;
            LogLevel = logLevel;
            Logger = logger;
            Message = message;
            Exception = exception;
        }

        public static LogEntry Parse(string data)
        {
            Verify.NotEmpty(data, nameof(data));

            var splitted = data.Split(SPLIT_CHARS, StringSplitOptions.None);
            var entry = new LogEntry();

            if (splitted.Length >= 1)
                entry.DateTime = splitted[0]?.Trim();
            if (splitted.Length >= 2)
                entry.LogLevel = splitted[1]?.Trim();
            if (splitted.Length >= 3)
                entry.Logger = splitted[2]?.Trim();
            if (splitted.Length >= 4)
                entry.Message = splitted[3];
            if (splitted.Length >= 5)
                entry.Exception = splitted[4];

            return entry;
        }
    }
}
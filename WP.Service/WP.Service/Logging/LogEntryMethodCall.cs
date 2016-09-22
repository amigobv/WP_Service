using System;

namespace WP.Service.Logging
{
    public static class LogEntryMethodCall
    {
        public delegate void LogEntryEventHandler(LogEntry entry);

        public static event LogEntryEventHandler LogEntryReceived;

        public static void LogMethod(string dateTime, string logLevel, string logger, string message, string exception)
        {
            RaiseLogEntryReceived(new LogEntry(dateTime, logLevel, logger, message, exception));
        }

        #region implementation

        private static void RaiseLogEntryReceived(LogEntry logEntry)
        {
            var handler = LogEntryReceived;
            try
            {
                handler?.Invoke(logEntry);
            }
            catch (Exception)
            {
                //silent
                ;
            }
        }
        #endregion
    }
}
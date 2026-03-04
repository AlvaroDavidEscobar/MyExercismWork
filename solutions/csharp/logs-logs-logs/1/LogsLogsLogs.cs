// TODO: define the 'LogLevel' enum

using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
public enum LogLevel {
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}
static class LogLine {
    public static LogLevel ParseLogLevel(string log_line) {
        log_line = log_line.Split('[')[1].Split(']')[0];
        switch (log_line) {
            case "TRC": return LogLevel.Trace;
            case "DBG": return LogLevel.Debug;
            case "INF": return LogLevel.Info;
            case "WRN": return LogLevel.Warning;
            case "ERR": return LogLevel.Error;
            case "FTL": return LogLevel.Fatal;
            default: return LogLevel.Unknown;
        }
    }

    public static string OutputForShortLog(LogLevel log_level, string message) {
        return $"{Convert.ToInt32(log_level)}:{message}";
    }
}
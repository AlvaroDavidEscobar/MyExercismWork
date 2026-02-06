using System.Text.RegularExpressions;

static class LogLine{
    public static string Message(string logLine){
        logLine = logLine.Split(":")[1];
        return logLine.Trim();
    }

    public static string LogLevel(string logLine){
        logLine = logLine.Split("[")[1];
        logLine = logLine.Split("]")[0];
        return logLine.ToLower();
    }

    public static string Reformat(string logLine){
        string PartA = Message(logLine);
        string PartB = LogLevel(logLine);
        return $"{PartA} ({PartB})";
    }
}

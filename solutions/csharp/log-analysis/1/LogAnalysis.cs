using System.Diagnostics.Metrics;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string Caller, string Cutter) => Caller.Split(Cutter)[1];

    public static string SubstringBetween(this string Caller, string FirstChar, string LastChar) {
        Caller = Caller.Split(FirstChar)[1];
        Caller = Caller.Split(LastChar)[0];
        return Caller;
    }

    public static string Message(this string Caller) => Caller.Split(": ")[1];

    public static string LogLevel(this string Caller) {
        Caller = Caller.Split("[")[1];
        Caller = Caller.Split("]")[0];
        return Caller;
    }
}
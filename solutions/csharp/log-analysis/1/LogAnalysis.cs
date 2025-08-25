public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string cut) {
        return str.Substring(str.IndexOf(cut) + cut.Length);
    }

    public static string SubstringBetween(this string str, string front, string back) {
        return str.Substring(str.IndexOf(front) + front.Length, str.IndexOf(back) - str.IndexOf(front) - front.Length);
    }
    
    public static string Message(this string str) {
        return str.SubstringAfter("]:").Trim();
    }

    public static string LogLevel(this string str) {
        return str.SubstringBetween("[", "]");
    }
}
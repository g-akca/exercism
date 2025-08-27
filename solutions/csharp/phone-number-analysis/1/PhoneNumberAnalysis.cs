public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string first = phoneNumber.Substring(0, 3);
        string second = phoneNumber.Substring(4, 3);
        string last = phoneNumber.Substring(8, 4);
        return (first == "212" ? true : false, second == "555" ? true : false, last);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}

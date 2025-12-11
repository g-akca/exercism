using System;
using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(GetTimeZoneId(location));
        DateTime localTime = DateTime.Parse(appointmentDateDescription);
        return TimeZoneInfo.ConvertTimeToUtc(localTime, tz);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        switch (alertLevel) {
            case AlertLevel.Early:
                return appointment.AddDays(-1);
            case AlertLevel.Standard:
                return appointment.AddHours(-1).AddMinutes(-45);
            case AlertLevel.Late:
                return appointment.AddMinutes(-30);
            default:
                return appointment;
        }
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(GetTimeZoneId(location));
        return tz.IsDaylightSavingTime(dt) != tz.IsDaylightSavingTime(dt.AddDays(-7));
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo culture;
        switch (location) {
            case Location.London:
                culture = new CultureInfo("en-GB");
                break;
            case Location.Paris:
                culture = new CultureInfo("fr-FR");
                break;
            default:
                culture = CultureInfo.InvariantCulture;
                break;
        }

        if (DateTime.TryParse(dtStr, culture, DateTimeStyles.None, out DateTime result)) {
            return result;
        }

        return DateTime.MinValue;
    }

    private static string GetTimeZoneId(Location location)
    {
        bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        switch (location) {
            case Location.NewYork:
                return isWindows ? "Eastern Standard Time" : "America/New_York";
            case Location.London: 
                return isWindows ? "GMT Standard Time" : "Europe/London";
            case Location.Paris:
                return isWindows ? "W. Europe Standard Time" : "Europe/Paris";
            default:
                return "Unknown";
        }
    }
}

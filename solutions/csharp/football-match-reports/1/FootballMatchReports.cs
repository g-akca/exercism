public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum) {
            case 1:
                return "goalie";
                break;
            case 2:
                return "left back";
                break;
            case 3:
            case 4:
                return "center back";
                break;
            case 5:
                return "right back";
                break;
            case 6:
            case 7:
            case 8:
                return "midfielder";
                break;
            case 9:
                return "left wing";
                break;
            case 10:
                return "striker";
                break;
            case 11:
                return "right wing";
                break;
            default:
                return "UNKNOWN";
                break;
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report) {
            case int supporters:
                return $"There are {supporters} supporters at the match.";
                break;
            case string announcement:
                return announcement;
                break;
            case Foul foul:
                return foul.GetDescription();
                break;
            case Injury injury:
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
                break;
            case Incident incident:
                return incident.GetDescription();
                break;
            case Manager manager:
                return $"{manager.Name}{(manager.Club != null ? " (" + manager.Club + ")" : "")}";
                break;
            default:
                return "";
                break;
        }
    }
}

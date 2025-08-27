static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string result = "";
        if (id != null) result += "[" + id + "] - ";
            
        result += name + " - ";
            
        if (department != null) result += department.ToUpper();
        else result += "OWNER";
        
        return result;
    }
}

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        return $"{(id != null ? $"[{id}] - " : "")}{name} - {(department != null ? department.ToUpper() : "OWNER")}";
    }
}

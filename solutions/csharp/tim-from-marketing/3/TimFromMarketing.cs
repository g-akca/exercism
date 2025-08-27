static class Badge
{
    public static string Print(int? id, string name, string? department) => $"{(id != null ? $"[{id}] - " : "")}{name} - {(department != null ? department.ToUpper() : "OWNER")}";
}

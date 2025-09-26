enum AccountType {
    Guest,
    User,
    Moderator
}

[Flags]
enum Permission : byte {
    Read = 0b00000001,
    Write = 0b00000010,
    Delete = 0b00000100,
    All = Read | Write | Delete,
    None = 0
}

static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        switch (accountType) {
            case AccountType.Guest:
                return Permission.Read;
            case AccountType.User:
                return Permission.Read | Permission.Write;
            case AccountType.Moderator:
                return Permission.Read | Permission.Write | Permission.Delete;
            default:
                return Permission.None;
        }
    }

    public static Permission Grant(Permission current, Permission grant) => current | grant;

    public static Permission Revoke(Permission current, Permission revoke) => current & ~revoke;

    public static bool Check(Permission current, Permission check) => current == (current | check);
}

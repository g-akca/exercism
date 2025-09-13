using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder("", identifier.Length);
        for (int i = 0; i < identifier.Length; i++) {
            char c = identifier[i];
            if (Char.IsWhiteSpace(c)) sb.Append('_');
            else if (Char.IsControl(c)) sb.Append("CTRL");
            else if (c == '-') {
                sb.Append(Char.ToUpper(identifier[i + 1]));
                i++;
            }
            else if (!Char.IsLetter(c) || (c >= 'α' && c <= 'ω')) continue;
            else sb.Append(c);
        }
        return sb.ToString();
    }
}

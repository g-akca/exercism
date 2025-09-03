public class Robot
{
    private static Random random = new Random();
    private static HashSet<string> usedNames = new HashSet<string>();
    private string name;

    public string Name
    {
        get
        {
            if (name == null) name = GenerateUniqueName();
            return name;
        }
    }

    public void Reset()
    {
        if (name != null) {
            usedNames.Remove(name);
            name = null;
        }
    }

    private static string GenerateUniqueName()
    {
        string newName;
        do newName = GenerateRandomName();
        while (!usedNames.Add(newName));
        
        return newName;
    }

    private static string GenerateRandomName()
    {
        char letter1 = (char)('A' + random.Next(0, 26));
        char letter2 = (char)('A' + random.Next(0, 26));
        int number = random.Next(0, 1000);
        return $"{letter1}{letter2}{number:000}";
    }
}

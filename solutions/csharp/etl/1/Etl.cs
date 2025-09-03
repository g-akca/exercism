public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var kvp in old) {
            int key = kvp.Key;
            string[] values = kvp.Value;

            foreach (var value in values) {
                result[value.ToLower()] = key;
            }
        }
        
        return result;
    }
}
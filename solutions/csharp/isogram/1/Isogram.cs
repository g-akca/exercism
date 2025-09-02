public static class Isogram
{
    public static bool IsIsogram(string word) => word.ToLower()
                                                     .Where(c => Char.IsLetter(c))
                                                     .GroupBy(c => c)
                                                     .Count() == word.ToLower()
                                                                     .Where(c => Char.IsLetter(c))
                                                                     .Count();
}

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        List<string> results = new List<string> ();
        
        for (int i = 0; i < strand.Length; i += 3) {
            switch (strand.Substring(i, 3)) {
                case "AUG":
                    results.Add("Methionine");
                    break;
                case "UUU":
                case "UUC":
                    results.Add("Phenylalanine");
                    break;
                case "UUA":
                case "UUG":
                    results.Add("Leucine");
                    break;
                case "UCU":
                case "UCC":
                case "UCA":
                case "UCG":
                    results.Add("Serine");
                    break;
                case "UAU":
                case "UAC":
                    results.Add("Tyrosine");
                    break;
                case "UGU":
                case "UGC":
                    results.Add("Cysteine");
                    break;
                case "UGG":
                    results.Add("Tryptophan");
                    break;
                case "UAA":
                case "UAG":
                case "UGA":
                    return results.ToArray();
            }
        }

        return results.ToArray();
    }
}
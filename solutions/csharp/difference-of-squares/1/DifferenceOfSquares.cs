public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max) => Convert.ToInt32(Math.Pow(max * (max + 1) / 2.0, 2.0));

    public static int CalculateSumOfSquares(int max) => Enumerable.Range(1, max).Select(i => i * i).Sum();

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}
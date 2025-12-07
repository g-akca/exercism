public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        Array.Sort(input);
        int left = 0, right = input.Length - 1;
        while (left <= right) {
            int middle = (left + right) / 2;

            if (input[middle] == value) return middle;

            if (input[middle] < value) left = middle + 1;
            else right = middle - 1;
        }

        return -1;
    }
}
class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] {0, 2, 5, 3, 7, 8, 4};

    public int Today() => this.birdsPerDay[this.birdsPerDay.Length - 1];

    public void IncrementTodaysCount() => this.birdsPerDay[this.birdsPerDay.Length - 1]++;

    public bool HasDayWithoutBirds() => Array.IndexOf(this.birdsPerDay, 0) == -1 ? false : true;

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for (int i = 0; i < (numberOfDays <= 7 ? numberOfDays : 7); i++) {
            sum += this.birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays() => this.birdsPerDay.Where(b => b >= 5)
                                             .Count();
}

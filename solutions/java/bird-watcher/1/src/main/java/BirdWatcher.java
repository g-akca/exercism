
class BirdWatcher {
    private final int[] birdsPerDay;

    public BirdWatcher(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay.clone();
    }

    public int[] getLastWeek() {
        int[] birdsLastWeek = {0, 2, 5, 3, 7, 8, 4};
        return birdsLastWeek;
    }

    public int getToday() {
        return birdsPerDay[birdsPerDay.length - 1];
    }

    public void incrementTodaysCount() {
        birdsPerDay[birdsPerDay.length - 1]++;
    }

    public boolean hasDayWithoutBirds() {
        for (var count : birdsPerDay) {
            if (count == 0) return true;
        }
        return false;
    }

    public int getCountForFirstDays(int numberOfDays) {
        int total = 0;
        for (int i = 0; i < (numberOfDays <= 7 ? numberOfDays : 7); i++) total += birdsPerDay[i];
        return total;
    }

    public int getBusyDays() {
        int busy = 0;
        for (var count : birdsPerDay) {
            if (count >= 5) busy++;
        }
        return busy;
    }
}

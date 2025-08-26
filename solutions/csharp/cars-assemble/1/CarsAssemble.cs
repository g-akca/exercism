static class AssemblyLine
{
    public const int CARS_PER_HOUR = 221;
    
    public static double SuccessRate(int speed)
    {
        if (speed == 0) {
            return 0;
        }
        else if (speed <= 4) {
            return 1;
        }
        else if (speed <= 8) {
            return 0.9;
        }
        else if (speed == 9) {
            return 0.8;
        }
        else {
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed) * speed * CARS_PER_HOUR;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return Convert.ToInt32(ProductionRatePerHour(speed)) / 60;
    }
}

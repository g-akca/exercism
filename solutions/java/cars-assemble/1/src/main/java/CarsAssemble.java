public class CarsAssemble {

    public static int CARS_PER_HOUR = 221;
    
    public double productionRatePerHour(int speed) {
        if (speed <= 4) {
            return CARS_PER_HOUR * speed;
        }
        else if (speed <= 8) {
            return CARS_PER_HOUR * speed * 90.0 / 100;
        }
        else if (speed == 9) {
            return CARS_PER_HOUR * speed * 80.0 / 100;
        }

        return CARS_PER_HOUR * speed * 77.0 / 100;
    }

    public int workingItemsPerMinute(int speed) {
        return (int)productionRatePerHour(speed) / 60;
    }
}

public class JedliksToyCar {
    private int distanceDriven;
    private int battery = 100;
    
    public static JedliksToyCar buy() {
        return new JedliksToyCar();
    }

    public String distanceDisplay() {
        return "Driven " + distanceDriven + " meters";
    }

    public String batteryDisplay() {
        if (battery > 0) return "Battery at " + battery + "%";
        return "Battery empty";
    }

    public void drive() {
        if (battery > 0) {
            distanceDriven += 20;
            battery--;
        }
    }
}

public class Lasagna {
    private final int EXPECTED_MINUTES_IN_OVEN = 40;
    private final int PREPARATION_TIME_PER_LAYER = 2;
    
    public int expectedMinutesInOven() {
        return EXPECTED_MINUTES_IN_OVEN;
    }

    public int remainingMinutesInOven(int in_oven) {
        return expectedMinutesInOven() - in_oven;
    }

    public int preparationTimeInMinutes(int layers) {
        return layers * PREPARATION_TIME_PER_LAYER;
    }

    public int totalTimeInMinutes(int layers, int in_oven) {
        return preparationTimeInMinutes(layers) + in_oven;
    }
}

public class Lasagna {

    public int expectedMinutesInOven() {
        return 40;
    }

    public int remainingMinutesInOven(int in_oven) {
        return expectedMinutesInOven() - in_oven;
    }

    public int preparationTimeInMinutes(int layers) {
        return layers * 2;
    }

    public int totalTimeInMinutes(int layers, int in_oven) {
        return preparationTimeInMinutes(layers) + in_oven;
    }
}

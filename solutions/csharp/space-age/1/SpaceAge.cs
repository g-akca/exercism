public class SpaceAge
{
    private int age;
    private static double SECONDS_PER_EARTH_DAY = 31557600;
    private static double MERCURY_PERIOD = 0.2408467;
    private static double VENUS_PERIOD = 0.61519726;
    private static double MARS_PERIOD = 1.8808158;
    private static double JUPITER_PERIOD = 11.862615;
    private static double SATURN_PERIOD = 29.447498;
    private static double URANUS_PERIOD = 84.016846;
    private static double NEPTUNE_PERIOD = 164.79132;
    
    public SpaceAge(int seconds) => this.age = seconds;

    public double OnEarth() => age / SECONDS_PER_EARTH_DAY;

    public double OnMercury() => this.OnEarth() / MERCURY_PERIOD;

    public double OnVenus() => this.OnEarth() / VENUS_PERIOD;

    public double OnMars() => this.OnEarth() / MARS_PERIOD;

    public double OnJupiter() => this.OnEarth() / JUPITER_PERIOD;

    public double OnSaturn() => this.OnEarth() / SATURN_PERIOD;

    public double OnUranus() => this.OnEarth() / URANUS_PERIOD;

    public double OnNeptune() => this.OnEarth() / NEPTUNE_PERIOD;
}
class RemoteControlCar
{
    private int speed;
    private int drain;
    private int driven = 0;
    private int battery = 100;

    public int getSpeed() => this.speed;
    public int getDrain() => this.drain;
    
    public RemoteControlCar(int speed, int drain) {
        this.speed = speed;
        this.drain = drain;
    }

    public bool BatteryDrained() => battery < drain ? true : false;

    public int DistanceDriven() => driven;

    public void Drive()
    {
        if (!BatteryDrained()) {
            battery -= drain;
            driven += speed;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;
    
    public RaceTrack(int distance) => this.distance = distance;

    public bool TryFinishTrack(RemoteControlCar car) => Convert.ToDouble(distance) / car.getSpeed() * car.getDrain() <= 100 ? true : false;
}

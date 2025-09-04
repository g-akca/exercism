class RemoteControlCar
{
    private int _drivenDistance = 0;
    private int _battery = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_drivenDistance} meters";

    public string BatteryDisplay()
    {
        if (_battery > 0) return $"Battery at {_battery}%";
        return "Battery empty";
    }

    public void Drive()
    {
        if (_battery > 0) {
            _drivenDistance += 20;
            _battery -= 1;
        }
    }
}

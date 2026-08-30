class WeighingMachine
{
    public int Precision { get; }

    private double _weight;
    public double Weight
    {
        get => _weight;
        set => _weight = (value >= 0 ? value : throw new ArgumentOutOfRangeException());
    }

    public double TareAdjustment { get; set; } = 5;

    public string DisplayWeight
    {
        get => $"{Math.Round(Weight - TareAdjustment, Precision).ToString($"F{Precision}")} kg";
    }

    public WeighingMachine(int precision) => Precision = precision;
}

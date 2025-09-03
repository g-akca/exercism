public class Player
{
    public int RollDie()
    {
        Random randObj = new();
        return randObj.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        Random randObj = new();
        return randObj.Next(0, 99) + randObj.NextDouble();
    }
}

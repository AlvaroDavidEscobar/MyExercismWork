public class Player
{
    Random random = new Random();
    public int RollDie() => random.Next(1, 18 + 1);

    //public double GenerateSpellStrength() => random.Next(0, 100) + random.NextDouble();
    public double GenerateSpellStrength() => random.NextDouble() * 100;
}

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int TimeSpentInOven) => ExpectedMinutesInOven() - TimeSpentInOven;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int Layers) => Layers * 2;
    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int Layers, int TimeSpentInOven) => (Layers * 2) + TimeSpentInOven;
}

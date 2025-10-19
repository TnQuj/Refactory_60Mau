using System;

enum BirdType
{
    European,
    African,
    NorwegianBlue
}

class Bird
{
    private BirdType type;
    private int numberOfCoconuts;
    private bool isNailed;
    private double voltage;

    public Bird(BirdType type, int numberOfCoconuts = 0, bool isNailed = false, double voltage = 0)
    {
        this.type = type;
        this.numberOfCoconuts = numberOfCoconuts;
        this.isNailed = isNailed;
        this.voltage = voltage;
    }

    public double GetSpeed()
    {
        switch (type)
        {
            case BirdType.European:
                return GetBaseSpeed();
            case BirdType.African:
                return GetBaseSpeed() - GetLoadFactor() * numberOfCoconuts;
            case BirdType.NorwegianBlue:
                return (isNailed) ? 0 : GetBaseSpeed(voltage);
            default:
                throw new Exception("Unknown bird type");
        }
    }

    private double GetBaseSpeed(double voltage = 0) => 10 + voltage * 0.5;
    private double GetLoadFactor() => 2.0;
}

class Program
{
    static void Main()
    {
        Bird european = new Bird(BirdType.European);
        Bird african = new Bird(BirdType.African, numberOfCoconuts: 3);
        Bird norwegian = new Bird(BirdType.NorwegianBlue, isNailed: false, voltage: 120);

        Console.WriteLine($"European speed: {european.GetSpeed()}");
        Console.WriteLine($"African speed: {african.GetSpeed()}");
        Console.WriteLine($"Norwegian Blue speed: {norwegian.GetSpeed()}");
    }
}

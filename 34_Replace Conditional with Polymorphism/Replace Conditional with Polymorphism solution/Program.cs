using System;

abstract class Bird
{
    public abstract double GetSpeed();

    protected double GetBaseSpeed(double voltage = 0) => 10 + voltage * 0.5;
    protected double GetLoadFactor() => 2.0;
}

class European : Bird
{
    public override double GetSpeed() => GetBaseSpeed();
}

class African : Bird
{
    private int numberOfCoconuts;

    public African(int numberOfCoconuts)
    {
        this.numberOfCoconuts = numberOfCoconuts;
    }

    public override double GetSpeed() => GetBaseSpeed() - GetLoadFactor() * numberOfCoconuts;
}

class NorwegianBlue : Bird
{
    private bool isNailed;
    private double voltage;

    public NorwegianBlue(bool isNailed, double voltage)
    {
        this.isNailed = isNailed;
        this.voltage = voltage;
    }

    public override double GetSpeed() => (isNailed) ? 0 : GetBaseSpeed(voltage);
}

class Program
{
    static void Main()
    {
        Bird european = new European();
        Bird african = new African(3);
        Bird norwegian = new NorwegianBlue(false, 120);

        Console.WriteLine($"European speed: {european.GetSpeed()}");
        Console.WriteLine($"African speed: {african.GetSpeed()}");
        Console.WriteLine($"Norwegian Blue speed: {norwegian.GetSpeed()}");
    }
}
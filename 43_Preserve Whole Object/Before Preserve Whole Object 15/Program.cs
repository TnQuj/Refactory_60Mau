using System;

public class TemperatureRange
{
    public double Min { get; set; }
    public double Max { get; set; }

    public TemperatureRange(double min, double max)
    {
        Min = min;
        Max = max;
    }
}

public class Room
{
    private double currentTemperature;

    public Room(double currentTemperature)
    {
        this.currentTemperature = currentTemperature;
    }

    public double GetCurrentTemperature()
    {
        return currentTemperature;
    }
}

public class HeatingSystem
{
    // ❌ Truyền nhiều tham số riêng lẻ
    public void Regulate(double minTemp, double maxTemp, double currentTemp)
    {
        if (currentTemp < minTemp)
            Console.WriteLine("Turning on heater...");
        else if (currentTemp > maxTemp)
            Console.WriteLine("Turning off heater...");
        else
            Console.WriteLine("Temperature is optimal.");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        TemperatureRange range = new TemperatureRange(18, 24);
        Room room = new Room(20);

        HeatingSystem system = new HeatingSystem();
        system.Regulate(range.Min, range.Max, room.GetCurrentTemperature());
    }
}

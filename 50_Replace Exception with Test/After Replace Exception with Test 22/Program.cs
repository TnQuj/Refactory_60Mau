using System;

public class Report
{
    private double[] values = { 10.5, 20.0, 30.5 };

    // ✅ Dùng điều kiện kiểm tra thay vì Exception
    public double GetValueForPeriod(int periodNumber)
    {
        if (periodNumber < 0 || periodNumber >= values.Length)
        {
            return 0;
        }
        return values[periodNumber];
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Report report = new Report();

        Console.WriteLine(report.GetValueForPeriod(1)); // ✅ 20.0
        Console.WriteLine(report.GetValueForPeriod(5)); // ✅ 0 (không lỗi)
    }
}
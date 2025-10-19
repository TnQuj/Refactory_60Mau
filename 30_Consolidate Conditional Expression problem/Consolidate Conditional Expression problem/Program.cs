using System;

class Program
{
    static void Main()
    {
        double result = DisabilityAmount(1.5, 8, false);
        Console.WriteLine($"Disability Amount: {result}");
    }

    static double DisabilityAmount(double seniority, int monthsDisabled, bool isPartTime)
    {
        if (seniority < 2)
        {
            return 0;
        }
        if (monthsDisabled > 12)
        {
            return 0;
        }
        if (isPartTime)
        {
            return 0;
        }

        // Tính toán số tiền trợ cấp (giả sử)
        return 5000;
    }
}

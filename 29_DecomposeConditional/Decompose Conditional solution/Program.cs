using System;

class Program
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        double quantity = 10;

        double charge;
        if (IsSummer(date))
        {
            charge = SummerCharge(quantity);
        }
        else
        {
            charge = WinterCharge(quantity);
        }

        Console.WriteLine($"Total charge: {charge}");
    }

    static bool IsSummer(DateTime date)
    {
        DateTime SUMMER_START = new DateTime(date.Year, 6, 1);
        DateTime SUMMER_END = new DateTime(date.Year, 8, 31);
        return date >= SUMMER_START && date <= SUMMER_END;
    }

    static double SummerCharge(double quantity)
    {
        double summerRate = 3.5;
        return quantity * summerRate;
    }

    static double WinterCharge(double quantity)
    {
        double winterRate = 5.0;
        double winterServiceCharge = 20.0;
        return quantity * winterRate + winterServiceCharge;
    }
}
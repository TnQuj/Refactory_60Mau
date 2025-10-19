using System;

class Program
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        DateTime SUMMER_START = new DateTime(date.Year, 6, 1);
        DateTime SUMMER_END = new DateTime(date.Year, 8, 31);
        double quantity = 10;
        double winterRate = 5.0;
        double summerRate = 3.5;
        double winterServiceCharge = 20.0;
        double charge;

        if (date < SUMMER_START || date > SUMMER_END)
        {
            charge = quantity * winterRate + winterServiceCharge;
        }
        else
        {
            charge = quantity * summerRate;
        }

        Console.WriteLine($"Total charge: {charge}");
    }
}

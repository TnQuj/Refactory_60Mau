using System;

class Program
{
    static void Main()
    {
        double price = 1000;
        double total;

        if (IsSpecialDeal())
        {
            total = price * 0.95;
        }
        else
        {
            total = price * 0.98;
        }

        Send(); // Mã trùng lặp được đưa ra ngoài

        Console.WriteLine($"Total: {total}");
    }

    static bool IsSpecialDeal()
    {
        // Giả sử điều kiện đặc biệt
        return DateTime.Now.DayOfWeek == DayOfWeek.Sunday;
    }

    static void Send()
    {
        Console.WriteLine("Order has been sent!");
    }
}

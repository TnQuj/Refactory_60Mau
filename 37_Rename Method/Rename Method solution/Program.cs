using System;

class Customer
{
    private string name;
    private double totalPurchases;

    public Customer(string name, double totalPurchases)
    {
        this.name = name;
        this.totalPurchases = totalPurchases;
    }

    // Renamed to a meaningful name
    public double GetTotalPurchases()
    {
        return totalPurchases;
    }
}

class Program
{
    static void Main()
    {
        Customer c = new Customer("Alice", 1200);
        Console.WriteLine("Total purchases: " + c.GetTotalPurchases());
    }
}

using System;

public class Account
{
    private double balance;

    public Account(double balance)
    {
        this.balance = balance;
    }

    // ✅ Chỉ thực hiện hành động (Modifier)
    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    // ✅ Chỉ truy vấn dữ liệu (Query)
    public double GetBalance()
    {
        return balance;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1000);
        acc.Withdraw(200); // Hành động
        Console.WriteLine("Current balance: " + acc.GetBalance()); // Truy vấn
    }
}
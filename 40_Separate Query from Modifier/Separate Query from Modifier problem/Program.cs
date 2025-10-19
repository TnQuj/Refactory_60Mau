using System;

public class Account
{
    private double balance;

    public Account(double balance)
    {
        this.balance = balance;
    }

    // ❌ Vừa thay đổi dữ liệu (rút tiền) vừa trả về giá trị (số dư mới)
    public double Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
        return balance;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1000);
        Console.WriteLine("Balance after withdraw: " + acc.Withdraw(200));
    }
}

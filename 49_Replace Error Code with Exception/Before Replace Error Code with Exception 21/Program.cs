using System;

public class Account
{
    private int balance;

    public Account(int initialBalance)
    {
        balance = initialBalance;
    }

    // ❌ Phương thức trả về mã lỗi thay vì ném ngoại lệ
    public int Withdraw(int amount)
    {
        if (amount > balance)
        {
            // Trả về -1 nếu lỗi (rút quá số dư)
            return -1;
        }
        else
        {
            balance -= amount;
            return 0; // 0 = thành công
        }
    }

    public int GetBalance()
    {
        return balance;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1000);

        int result = acc.Withdraw(1500);

        if (result == -1)
            Console.WriteLine("❌ Lỗi: Rút quá số dư!");
        else
            Console.WriteLine("✅ Rút tiền thành công. Số dư còn lại: " + acc.GetBalance());
    }
}

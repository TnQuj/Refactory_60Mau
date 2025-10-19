using System;

public class Employee
{
    private double salary;

    public Employee(double salary)
    {
        this.salary = salary;
    }

    // ❌ Các phương thức này chỉ khác nhau ở phần trăm tăng lương
    public void IncreaseSalaryBy10Percent()
    {
        salary += salary * 0.10;
    }

    public void IncreaseSalaryBy20Percent()
    {
        salary += salary * 0.20;
    }

    public void IncreaseSalaryBy30Percent()
    {
        salary += salary * 0.30;
    }

    public double GetSalary()
    {
        return salary;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(1000);
        emp.IncreaseSalaryBy10Percent();
        Console.WriteLine("After 10% increase: " + emp.GetSalary());

        emp.IncreaseSalaryBy20Percent();
        Console.WriteLine("After 20% increase: " + emp.GetSalary());
    }
}

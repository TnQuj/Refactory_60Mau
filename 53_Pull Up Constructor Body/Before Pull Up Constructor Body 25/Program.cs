using System;

public class Employee
{
    protected string Name;
    protected string Id;
}

public class Manager : Employee
{
    private int Grade;

    // ❌ Constructor chứa code lặp lại (gán Name, Id)
    public Manager(string name, string id, int grade)
    {
        this.Name = name;
        this.Id = id;
        this.Grade = grade;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Manager: {Name}, ID: {Id}, Grade: {Grade}");
    }
}

public class Developer : Employee
{
    private string Language;

    // ❌ Constructor chứa code lặp lại (gán Name, Id)
    public Developer(string name, string id, string language)
    {
        this.Name = name;
        this.Id = id;
        this.Language = language;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Developer: {Name}, ID: {Id}, Language: {Language}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Manager m = new Manager("Alice", "M01", 5);
        Developer d = new Developer("Bob", "D01", "C#");

        m.ShowInfo();
        d.ShowInfo();
    }
}

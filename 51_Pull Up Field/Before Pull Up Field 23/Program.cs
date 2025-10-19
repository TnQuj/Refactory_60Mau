using System;

// Lớp cha
public class Unit
{
    protected int health;
}

// Hai lớp con có cùng phương thức giống nhau
public class Soldier : Unit
{
    public int GetHealth()
    {
        return health;
    }
}

public class Tank : Unit
{
    public int GetHealth()
    {
        return health;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Soldier soldier = new Soldier();
        Tank tank = new Tank();

        Console.WriteLine("Soldier Health: " + soldier.GetHealth());
        Console.WriteLine("Tank Health: " + tank.GetHealth());
    }
}

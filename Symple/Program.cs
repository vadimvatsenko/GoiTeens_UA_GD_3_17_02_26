using System;

public class Program
{
    public static void Main()
    {
        

    }
}

public class Player
{
    public int PositionX { get; private set; } = 0;
    public void Attack(Enemy enemy, int damage)
    {
        enemy.TakeDamage(damage);
    }
}

public class Enemy
{
    public int Name { get; private set; }
    private int _health = 100;
    public int PositinX {get; private set;}

    public Enemy(int name)
    {
        Name = name;
        PositinX = new Random().Next(0,10);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            _health = 0;
        }
        Console.WriteLine($"Enemy {Name} -  {_health} health left.");
    }
}


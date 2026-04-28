using System;

public class Program
{
    public static void Main()
    {
        Unit player = new Unit("Player", 100);
        Unit enemy = new Unit("Enemy", 50);
        
        player.Attack(enemy, 30);
        enemy.Attack(player, 85);
        
        player.ShowUnitInfo();
        enemy.ShowUnitInfo();

        int numb = 2;
        string numbs = numb switch
        {
            5 => "Five",
            _ => "No Number"
        };
        
        /*Console.WriteLine("Before damage");
        player.ShowUnitInfo();
        
        player.TakeDamage(10);
        player.TakeDamage(10);
        
        Console.WriteLine("After damage");
        player.ShowUnitInfo();
        
        Console.WriteLine("After healing");
        player.Heal(10);*/
        
        
        Console.ReadKey();
    }
}

public class Unit
{
    private string _name;
    private int _health;
    
    public Unit(string name, int health)
    {
        _name = name;
        _health = health;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            _health = 0;
        }
    }

    public void Heal(int heal)
    {
        _health += heal;
        if (_health > 100)
        {
            _health = 100;
        }
    }
    
    public void Attack(Unit target, int damage)
    {
        //Console.WriteLine($"Unit {_name} attacks");
        target.TakeDamage(damage);
    }
    
    public void ShowUnitInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Health: {_health}");
    }
}
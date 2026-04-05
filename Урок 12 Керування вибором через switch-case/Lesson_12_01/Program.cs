using System;
using System.Text;


enum ItemType
{
    Posion, // 0
    Sword, // 1
    Shied, // 2
    Exit, // 3
}

enum AnimalType
{
    Idle,
    Move,
    Death
}


public class Program
{
    public static void Main()
    {
        
        
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        
        Console.Write($"Enter item index 0 - Posion, 1 - Sword, 2 - Shield 3 - Exit: ");
        int option = int.Parse(Console.ReadLine());

        ItemType item = (ItemType)option;

        switch (item)
        {
            case ItemType.Posion:
                Console.WriteLine("You buy a Posion");
                Console.ReadKey();
                break;
            case ItemType.Sword:
                Console.WriteLine("You buy a Sword");
                break;
            case ItemType.Shied:
                Console.WriteLine("You buy a Shied");
                break;
            case ItemType.Exit:
                Console.WriteLine("You buy a Exit");
                break;
            default:
                Console.WriteLine("No item in Shop");
                break;
        }
        
        Console.ReadKey();
    }
}
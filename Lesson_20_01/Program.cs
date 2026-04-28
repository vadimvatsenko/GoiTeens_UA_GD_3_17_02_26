using System;

public class Program
{
    public static void Main()
    {
        /*int summ = CalcSum(10, 5);
        Console.WriteLine(summ);*/
        
        List<string> inventory0 = GetInventory();
        List<string> inventory1 = inventory0;

        inventory0.Add("Bow");

        Console.WriteLine("inventory0");
        foreach (var item in inventory0)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("inventory1");
        foreach (var item in inventory1)
        {
            Console.WriteLine(item);
        }
        
        inventory1.Add("Pistol");
        
        Console.WriteLine("inventory0");
        foreach (var item in inventory0)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("inventory1");
        foreach (var item in inventory1)
        {
            Console.WriteLine(item);
        }
        
        Console.ReadKey();
    }

    private static int CalcSum(int a, int b)
    {
        return a + b;
    }

    private static List<string> GetInventory()
    {
        List<string> inventoryList = new List<string>()
        {
            "Sword",
            "Shield",
            "Poison"
        };

        return inventoryList;
    }
}
using System;



public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> resorces = new Dictionary<string, int>()
        {
            { "gold", 10 },
            { "silver", 20 },
            { "broth", 30 },
        };
        
        Dictionary<string, int> resorces2 = new Dictionary<string, int>()
        {
            ["gold"] = 10,
            ["silver"] = 20,
            ["broth"] = 30,
        };

        Dictionary<string, bool> resorces3 = new Dictionary<string, bool>()
        {
            ["Get 2 crysytal"] = false,
            ["Get 3 crysytal"] = false,
            ["Get 4 crysytal"] = false,
        };
        
        resorces3["Get 2 crysytal"] = true;
        
        resorces.Add("poison", 15);
        resorces2.Add("item", 10);
        
        int goldCount = resorces["gold"];

        foreach (var quest in resorces3)
        {
            Console.WriteLine(quest.Key + ": " + quest.Value);
        }

        foreach (var quest in resorces3.Keys)
        {
            Console.WriteLine(quest);
        }

        foreach (var quest in resorces2.Values)
        {
            Console.WriteLine(quest);
        }

        string goldText = "gold";

        if (!resorces.ContainsKey(goldText))
        {
            resorces.Add(goldText, 1);
        }
        else
        {
            resorces[goldText] += 1115;
        }
        
        Console.WriteLine("-------------");

        foreach (var res in resorces)
        {
            Console.WriteLine(res.Key + ": " + res.Value);
        }
        
        resorces.Remove(goldText);
        
        Console.WriteLine("-------------");

        foreach (var res in resorces)
        {
            Console.WriteLine(res.Key + ": " + res.Value);
        }
        
        resorces.Clear();
        
        foreach (var res in resorces)
        {
            Console.WriteLine(res.Key + ": " + res.Value);
        }
        
        Console.WriteLine("-------------");
        
        //Console.WriteLine(goldCount);
        
        
        
        Console.ReadKey();
    }
}
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int countStone = GetCountItem("Stone");
        int countGolden = GetCountItem("Golden");
        
        int countBronze = GetCountItem("Bronze");
        
        Console.WriteLine($"Stone {countStone} Golden {countGolden} Bronze {countBronze}");
        Console.ReadKey();
    }

    private static Dictionary<string, int> GetResources()
    {
        Dictionary<string, int> resorces = new Dictionary<string, int>()
        {
            { "Bread", 50 },
            { "Stone", 100 },
            { "Golden", 150 },
            { "Silver", 200 },
        };
        
        return resorces;
    }

    private static int GetCountItem(string key)
    {
        Dictionary<string, int> dict = GetResources();

        if (dict.ContainsKey(key))
        {
            return dict[key];
        }
        return 0;
    }
}
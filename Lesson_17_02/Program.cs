using System;

public class Program
{
    public static void Main()
    {

        /*int[,] input = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        for (int i = 0; i < input.GetLength(1); i++)
        {
            for (int j = 0; j < input.GetLength(0); j++)
            {
                Console.Write(input[i, j]);
            }
            Console.WriteLine();
        }*/

        /*List<int> numbers = new List<int>()
        {
            50, 70, 80, 90, 100,
        };

        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);

        //Console.WriteLine(numbers[2]);

        numbers.Remove(2);
        numbers.RemoveAt(2);

        Console.WriteLine(numbers.Count);

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }*/

        /*List<string> inventory = new List<string>()
        {
            "Sword",
            "Shield"
        };
        
        
        int swordIndex = inventory.IndexOf("ewrwerwerwe");

        inventory.Insert(1, "Bow");

        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        if (!inventory.Contains("Pistol"))
        {
            inventory.Add("Pistol");
        }*/
        
        List<int> scores = new List<int>() { 50, 10, 30 };
        
        //scores.Sort();
        //scores.Reverse();

        List<int> numbers = new List<int>()
        {
            100, 200, 300, 400, 500, 600, 700, 800, 900, 1000
        };
        
        scores.AddRange(numbers);

        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }
        
        Console.ReadKey();
    }
}
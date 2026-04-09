using System;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = 
            { 
                10, // 0
                17, // 1
                1, // 2
                -40, // 3
                3, // 4
                15, // 5
                42, // 6
                -13 // 7
            };

        
        int max = int.MinValue; 
        // -2147483648
        // 10
        // 17
        // 17
        // 17
        // 17
        // 17
        // 42
        // 42
        
        int min = int.MaxValue;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            // 0 - 10 > -2147483648 - true
            // 1 - 17 > 10 
            // 2 - 1 > 17
            // 3 - -40 > 17
            // 4 - 3 > 17
            // 5 - 15 > 17
            // 6 - 42 > 17
            // 7 - -13 > 42
            if (numbers[i] > max)
            {
                // max було -2147483648 стало 10
                // max було 10 стало 17
                // max було 17 стало 17
                // max було 17 стало 17
                // max було 17 стало 17
                // max було 17 стало 17
                // max було 17 стало 42
                // max було 42 стало 42
                max = numbers[i];
            }

            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        
        Console.WriteLine(max);
        Console.WriteLine(min);
        
        Console.WriteLine("++++++++++++");

        int sum = 0;
        // 0 + 10 = 10
        // 10 + 17 = 27

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        
        Console.WriteLine($"Summ {sum}");
        
        float average = (float)sum / (float)numbers.Length;
        
        Console.WriteLine($"Average {average}");

        double[] numbs2 = new double[10];

        for (int i = 1; i <= numbs2.Length; i++)
        {
            numbs2[i - 1] = Math.Pow(2, i);
        }

        foreach (var n in numbs2)
        {
            Console.WriteLine(n);
        }
        
        Console.ReadKey();
    }
    
}
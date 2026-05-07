using System;

public class Program
{
    public static void Main()
    {
        int counter = 0;
        int length = 10;

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Spacebar)
            {
                int numb = counter % length;
                Console.WriteLine(numb);
                counter++;
            }
        }
        
        Console.ReadKey();
    }
}






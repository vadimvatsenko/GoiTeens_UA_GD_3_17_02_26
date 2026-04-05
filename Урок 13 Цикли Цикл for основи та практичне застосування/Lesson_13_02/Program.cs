using System;

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Ми шукаємо ключ у {i}");

            if (i == rnd.Next(0, 11))
            {
                Console.WriteLine($"Ключ знайдено в {i}");
                break;
            }
        }
        
        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                continue;
                //Console.WriteLine($"⛔ Гравець {i} заблокований, пропускаємо...");
            }
            
            Console.WriteLine($"✅ Гравець {i} — активний");
        }

        List<int> numbs = new List<int>()
        {
            1, 26, 10, 17, 20, 10
        };
        
        int sum = 0;

        for (int i = 0; i < numbs.Count; i++)
        {
            sum += numbs[i];
        }
        
        Console.WriteLine(sum);
        
        
        Console.ReadKey();
    }
}

//if (i == rnd.Next(0, 11))
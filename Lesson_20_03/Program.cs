using System;

/***🎮 Ігровий приклад**
Уявімо гру: герой хоче **поділити скарби між друзями**.
- Функція повинна сказати, чи ділення можливе (`true`/`false`).
- А також віддати **результат ділення**, тобто скільки скарбів отримає кожен.*/

public class Program
{
    public static void Main(string[] args)
    {
        int result;
        
        bool isSuccess = TryDivedeTreasures(9, 3, out result);

        if (isSuccess && result > 0)
        {
            Console.WriteLine($"Every friend take {result}");
        }
        else
        {
            Console.WriteLine($"Devided imposssible {result}");
        }
        
        Console.ReadKey();
    }

    private static bool TryDivedeTreasures(int totalTreasure, int frieds, out int result)
    {
        if (frieds == 0)
        {
            result = 0;
            return false;
        }
        
        result = totalTreasure / frieds;
        return true;
    }
}
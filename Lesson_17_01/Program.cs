// Діана - ДЗ switch

// Пояснення пару задач на масиви (Рівень Складний)

// Місія 11. "Непарні зверху вниз"
//Виведи елементи з непарними номерами, починаючи з останнього.

// Місія 14. "Змійка"
// Виводь: перший, останній, другий, передостанній, і так далі.

using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 13, 27, 4, 91, 56, 8, 34, 72, 19, 60 };

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] % 2 != 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        
        
        Console.WriteLine("----14----");

        int stopIndex = numbers.Length / 2;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == stopIndex) break;
            Console.WriteLine($"{numbers[i]} - {numbers[numbers.Length - i - 1]}");
        }
        
        Console.ReadKey();
    }
}

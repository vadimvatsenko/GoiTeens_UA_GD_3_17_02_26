using System;

// Юра чи розібрався з тим, що запитував.
// Тимур 12 ДЗ
// Богдан 17 завдання
// Діана 16 завдання
// Дмитро 16 завдання, пояснення


//🎯 Місія 12. "Парні, а потім непарні"
// Спочатку парні позиції, потім непарні (обидва блоки — зліва направо).

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int>()
        {
            10, 17, 200, 300, 500, 13
        };
        
        int sum = Calculate(1, 2);
        Console.WriteLine(sum);
        
        int sum2 = Calculate(10, 56);
        
        int listSum = CalculateList(numbers);
        
        Console.WriteLine(listSum);
        
        Console.ReadKey();
    }

    public static void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }

    public static int Calculate(int a, int b)
    {
        int result = a + b;
        return result;
    }

    public static int CalculateList(List<int> listOfNumbers)
    {
        int sum = 0;
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            sum += listOfNumbers[i];
        }
        
        return sum;
    }
}
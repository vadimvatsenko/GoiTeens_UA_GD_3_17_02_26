namespace Lesson_14_01;

// План на сьогодні
// Кахут по циклу for

// Нова тема цикл while, do-while, вкладені цикли.
// Повернемося до цикла for практика 
// Диана ДЗ


internal class Program
{
    static void Main(string[] args)
    {
        /*int posX = 0;
        
        while (true)
        {
            Thread.Sleep(1000);
            posX++;
            Console.WriteLine(posX);
            
            if(posX >= 10) break;
            
        }

        int energy = 5;

        while (energy > 0)
        {
            energy--;
        }*/
        
        string aswer = String.Empty;

        while (aswer != "yes")
        {
            Console.WriteLine("Enter YES");
            aswer = Console.ReadLine().ToLower();
        }
        
        Console.WriteLine("End Cycle");
        
        
        Console.ReadKey();
    }
}
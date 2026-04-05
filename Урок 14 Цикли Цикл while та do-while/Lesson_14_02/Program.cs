using System;

public class Program
{
    public static void Main()
    {
        /*while (false)
        {
            Console.WriteLine("While");
        }
        
        do
        {
            Console.WriteLine("DO-While");
        } while (false);
        
        Console.ReadKey();*/
        
        string qeustion = "How are old you?";
        int aswer = 13;

        int ans = 0;
        
        do
        {
            Console.WriteLine(qeustion);
            ans = int.Parse(Console.ReadLine());

            if (ans != aswer)
            {
                Console.WriteLine("Sorry, you entered an incorrect answer.");
            }
            
        } while (ans != aswer);
        
        Console.WriteLine("You are rigth");
        
        Console.ReadKey();
    }
}
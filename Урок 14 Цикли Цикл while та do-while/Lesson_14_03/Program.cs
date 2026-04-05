public class Program
{
    public static void Main()
    {

        for (int x = 1; x <= 10; x++)
        {
            for (int y = 1; y <= 10; y++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
        
        Console.ReadKey();
    }
}


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int h = 6;
            
            while (true)
            {
                if (h == 6) { Console.WriteLine("##########"); }
                else if (h == 1) { Console.WriteLine("##########"); break; }
                else { Console.WriteLine("#        #"); };
                h--;
            };
            
            Console.ReadKey();
        }
    }
}
using System;

namespace ConsoleApp1
{
    // це перечислення
    internal class Program
    {

        static void Main(string[] args)
        {
            int numb = 25;
            
            int tens = numb / 10;
            int hundred = numb % 10;
            
            Console.WriteLine(hundred + " " + tens);

            string tensString = tens switch
            {
                2 => "Двадцять",
                3 => "Тридцять"
            };

            string hunsString = hundred switch
            {
                1 => "Один",
                5 => "П'ять"
            };
            
            Console.WriteLine(tensString + " " + hunsString);
            
            Console.ReadKey();
        }
    }
}




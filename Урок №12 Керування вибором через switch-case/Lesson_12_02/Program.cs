// Pattern matching (патерн матчінг)
namespace GoiTeens_UA_;

public class Program
{
    public static void Main()
    {
        int numbMonth = 10;
        
        string message = numbMonth switch
        {
            12 or 1 or 2 => "Зима",
            3 or 4 or 5 => "Весна",
            6 or 7 or 8 => "Літо",
            9 or 10 or 11 => "Осінь",
            _ => "Немає такого місяця"
        };
        
        Console.WriteLine(message);

        int month = 13;
        int temp = -5;

        string message1 = (month, temp) switch
        {
            (1 or 2, <= 0) => "Морозна зима",
            (3 or 4, >= 10) => "Тепла весна",
            (6 or 7 or 8, >= 20) => "Прохолодна осінь",
            (9 or 10, >= 15 and <= 20) => "Прохолодна Осінь",
            (11 or 12, < 5) => "Холодна Зима",
            (_, _) => "Незвична погода"
        };
        
        Console.WriteLine(message1);
        
        Console.ReadKey();
    }
}
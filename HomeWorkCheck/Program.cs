namespace HomeWorkCheck;


internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> prices = new Dictionary<string, int>()
        {
            { "Хліб", 20 },
            { "Яблуко", 10 }
        };

        Dictionary<string, int> cart = new Dictionary<string, int>()
        {
            { "Хліб", 2 },
            { "Яблуко", 3 }
        };

        int total = 0;

        foreach (var item in cart)
        {
            total += prices[item.Key] * item.Value;
        }

        Console.WriteLine("Сума: " + total);

        Console.ReadKey();
    }
}







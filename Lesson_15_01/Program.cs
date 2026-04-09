public class Program
{
    public static void Main()
    {

        string[] inventory = new[]
        {
            "Sword", // 0
            "Shield", // 1
            "Poison" // 2
        };
        
        Console.WriteLine(inventory[0]);
        Console.WriteLine(inventory[1]);
        //Console.WriteLine(inventory[2]);
        
        Console.WriteLine(inventory[inventory.Length - 1]);
        
        Console.WriteLine(inventory.Length);

        float[] numbsFloat = new float[]
        {
            1.5f,
            2.5f,
            3.5f,
        };
        
        int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Toys[] toys =
        {
            new Toys("Car"), // 0
            new Toys("Bat"), // 1
            new Toys("Sword"), // 2
            new Toys("Bow"), // 3
            new Toys("Spear"), // 4
            new Toys("Bow"), // 5
            new Toys("Spear"), // 6
        };

        for (int i = 0; i < toys.Length; i++)
        {
            Console.WriteLine(toys[i].Name);
        }
        
        int[] numbersArray = { 150,300,450,600};

        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.WriteLine($"number {i + 1}  : {numbersArray[i]}");
        }
        
        
        Console.ReadKey();
        
    }

    public class Toys
    {
        public string Name { get; private set; }

        public Toys(string name)
        {
            Name = name;
        }
    }
}
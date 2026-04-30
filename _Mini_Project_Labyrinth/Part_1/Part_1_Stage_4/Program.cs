using System;
using Part_1_Stage_4;

// Етап 3 — Заставка і зібраний рівень (SayWelcome → PlayLevel) та фінальний Main

class Program
{
    
    // Генератор випадкових чисел — використовується скрізь, де потрібно "випадково" щось розмістити
    private static Random random = new Random();
    
    private static void Main()
    {
        MazeGenerator mazeGenerator = new MazeGenerator(12, 20);
        Input input = new Input();
        Player player = new Player(input, mazeGenerator, new Vector2(5,5), "@");
        
        
        PlayLevel(mazeGenerator, 20);

        while (true)
        {
            Console.Clear();
            input.Update();
            mazeGenerator.GameBoard[player.Position.X, player.Position.Y] = player.Symbol;
            
            mazeGenerator.PrintGameBoard();
        }
    }
    
    private static void SayWelcome()
    {
        Console.Clear();
        Console.WriteLine("██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗");  
        Console.WriteLine("██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝");  
        Console.WriteLine("██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗");  
        Console.WriteLine("██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝");  
        Console.WriteLine("╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗");  
        Console.WriteLine(" ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝");

        Console.WriteLine("Enter Something Key for Continue....");
        Console.ReadKey(true); 
        Console.Clear();
    }

    // Основний метод для запуску/ігри на одному рівні
    // len/wid — розміри; percentages — відсотки об'єктів від загальної кількості клітин
    private static void PlayLevel(MazeGenerator mazeGenerator, int wallPercent)
    {
        // Виводимо заставку(ASCII art)
        SayWelcome();
        // Встановлюємо глобальні розміри через локальні параметри
        
        // Ініціалізуємо порожнє поле
        mazeGenerator.InitializeGameBoard();
        
        // загальна кількість клітинок
        int totalCells = mazeGenerator.Rows * mazeGenerator.Cols;
        // Розраховуємо кількість стін на основі відсотків
        int wallsCount = totalCells * wallPercent / 100;
        
        // Створюємо об'єкти на полі згідно підрахунків
        mazeGenerator.CreateObjects(wallsCount, StaticFields.WallSymbol);
        
        // Відображаємо поле
        mazeGenerator.PrintGameBoard();
        
        Console.ReadKey();
    }
}
using System;

// Етап 3 — Заставка і зібраний рівень (SayWelcome → PlayLevel) та фінальний Main

class Program
{
    private static string wallSymbol = "█";
    private static string backgroundSymbol = ".";
    private static string playerSymbol = "֍";
    private static string lastPlayerSymbol = ".";
    // Генератор випадкових чисел — використовується скрізь, де потрібно "випадково" щось розмістити
    private static Random random = new Random();

    // Розміри поля
    private static int rows; // кількість рядків (довжина гри)
    private static int cols; // кількість стовпців (ширина гри)

    // Ігрове поле — двовимірний масив рядків (кожна клітинка містить 1-символьний рядок)
    private static string[,] gameBoard;
    
    // Позиція гравця
    private static int[] playerPosition = new int[2];
    
    private static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        PlayLevel(12, 20, 20);

        while (true)
        {
            int[] direction = CheckInput();
            
            MovePlayer(direction, playerSymbol);
            
            Console.Clear();
            PrintGameBoard();
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
    private static void PlayLevel(int len, int wid, int wallPercent)
    {
        // Виводимо заставку(ASCII art)
        SayWelcome();
        // Встановлюємо глобальні розміри через локальні параметри
        rows = len;
        cols = wid;
        
        // Ініціалізуємо порожнє поле
        InitializeGameBoard();
        
        SpawnPlayer();
        
        // загальна кількість клітинок
        int totalCells = rows * cols;
        // Розраховуємо кількість стін на основі відсотків
        int wallsCount = totalCells * wallPercent / 100;
        
        // Створюємо об'єкти на полі згідно підрахунків
        CreateObjects(wallsCount, wallSymbol);
        
        // Відображаємо поле
        PrintGameBoard();
        
        Console.ReadKey();
    }
    
    // Розміщує гравця у випадковій клітинці
    // playerSymbol — зазвичай "@"
    private static void SpawnPlayer()
    {
        int x =  random.Next(0, rows);
        int y = random.Next(0, cols);
        
        // Зберігаємо координати у масиві позиції гравця
        playerPosition[0] = x;
        playerPosition[1] = y;
        
        // Позиціюємо символ гравця на полі
        gameBoard[x, y] = playerSymbol;
    }

    private static int[] CheckInput()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow :
            case ConsoleKey.W:
                return new []{-1, 0};
            case ConsoleKey.LeftArrow or ConsoleKey.A :
                return new[] { 0, -1 };
            case ConsoleKey.DownArrow or ConsoleKey.S:
                return  new []{1, 0};
            case ConsoleKey.RightArrow or ConsoleKey.D:
                return   new []{0, 1};
            default:
                return new []{0, 0};
        }
    }

    private static void MovePlayer(int[] moveDirection, string symbol)
    {
        // Обчислюємо майбутні координати гравця після руху
        int futureRow = playerPosition[0] + moveDirection[0]; // новий рядок
        int futureCol = playerPosition[1] + moveDirection[1]; // новий стовпчик
        
        // Перевіряємо, чи майбутня позиція не виходить за межі поля
        // Якщо майбутній рядок або стовпець поза допустимим діапазоном — просто нічого не робимо
        if(futureRow < 0 || futureRow >= rows || futureCol < 0 || futureCol >= cols) return;
        // Якщо на майбутній позиції стіна ("█"):
        if(gameBoard[futureRow, futureCol] == wallSymbol) return;
        
        // --- процедури для переміщення — оновлення символів на полі ---
        // Замість символа гравця в його поточній позиції ми повинні відновити те, що там було раніше (lastPlayerSymbol)
        gameBoard[playerPosition[0], playerPosition[1]] = lastPlayerSymbol;
        
        // Тепер змінюємо координати гравця на нові — робимо сам рух
        playerPosition[0] += moveDirection[0];
        playerPosition[1] += moveDirection[1];
        
        // Зберігаємо символ, який знаходиться в новій клітинці (перед тим як поставити туди "@")
        // Це потрібно, бо коли гравець покине цю клітинку, потрібно буде відновити те, що там було.
        lastPlayerSymbol = gameBoard[playerPosition[0], playerPosition[1]];
        
        // І встановлюємо символ гравця в новій позиції
        gameBoard[playerPosition[0], playerPosition[1]] = playerSymbol;
    }
}
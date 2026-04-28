using System;

// Етап 3 — Заставка і зібраний рівень (SayWelcome → PlayLevel) та фінальний Main

class Program
{
    private static string wallSymbol = "█";
    private static string backgroundSymbol = ".";
    // Генератор випадкових чисел — використовується скрізь, де потрібно "випадково" щось розмістити
    private static Random random = new Random();

    // Розміри поля
    private static int rows; // кількість рядків (довжина гри)
    private static int cols; // кількість стовпців (ширина гри)

    // Ігрове поле — двовимірний масив рядків (кожна клітинка містить 1-символьний рядок)
    private static string[,] gameBoard;
    
    private static void Main()
    {
        PlayLevel(12, 20, 20);
    }

    private static void InitializeGameBoard()
    {
        // Створюємо масив з поточними розмірами rows x cols
        gameBoard = new string[rows, cols];

        // Проходимо кожну клітинку і ставимо "."
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < cols; y++)
            {
                gameBoard[x, y] = backgroundSymbol;
            }
        }
    }

    // Виводить ігрове поле в консоль построково
    // Пояснення: для деяких символів (█) ми виводимо символ двічі, щоб візуально вони були квадратніші
    private static void PrintGameBoard()
    {
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < cols; y++)
            {
                // Якщо символ ширший (щоб краще виглядало), виводимо його двічі без пробілу
                if (gameBoard[x, y] == wallSymbol)
                {
                    // Для стін і дверей повторюємо символ, щоб клітинка виглядала "пустішою
                    Console.Write(gameBoard[x, y] + gameBoard[x, y]);
                }
                else
                {
                    // Інакше виводимо символ + пробіл, щоб вирівнювання виглядало рівномірно
                    Console.Write(gameBoard[x, y] + " ");
                }
            }
            // Після кожного рядка — новий рядок у консолі
            Console.WriteLine();
        }
    }

    // Перевіряє, чи є хоч одна порожня клітинка на полі
    // Пояснення: корисно, щоб уникнути нескінченного рандому при заповненні
    private static bool HasEmptyCell()
    {
        // Перебираємо всі символи масиву (в C# foreach проходить по всіх елементах)
        foreach (var symbol in gameBoard)
        {
            // якщо хоч одна точка знайдена — є пусті клітинки
            if (symbol == backgroundSymbol)
            {
                return true;
            }
        }
        // Якщо ніде не знайшли "." — порожніх клітинок немає
        return false;
    }

    // Створює на полі objCount об'єктів з символом symbolToSpawn
    private static void CreateObjects(int objCount, string symbol)
    {
        // Якщо вже немає порожніх клітин — припиняємо спроби (щоб не зациклитись)
        for (int i = 0; i < objCount; i++)
        {
            int x;
            int y;

            do
            {
                if(!HasEmptyCell()) return; // виходимо — більше немає місця
                x = random.Next(0, rows); // випадковий рядок
                y = random.Next(0, cols);
            } while (gameBoard[x, y] != backgroundSymbol); // повторюємо поки не знайдемо порожнє місце
            
            gameBoard[x, y] = symbol; // Розміщуємо символ на полі
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
}
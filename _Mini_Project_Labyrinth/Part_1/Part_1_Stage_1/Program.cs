using System;

// Етап 1 — Створення та виведення простого поля

class Program
{
    private static string wallSymbol = "█";
    // Генератор випадкових чисел — використовується скрізь, де потрібно "випадково" щось розмістити
    private static Random random = new Random();

    // Розміри поля
    private static int rows; // кількість рядків (довжина гри)
    private static int cols; // кількість стовпців (ширина гри)

    // Ігрове поле — двовимірний масив рядків (кожна клітинка містить 1-символьний рядок)
    private static string[,] gameBoard;
    
    private static void Main()
    {
        rows = 12;
        cols = 20;
        
        InitializeGameBoard();
        PrintGameBoard();
        
        Console.ReadKey();
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
                gameBoard[x, y] = ".";
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
}
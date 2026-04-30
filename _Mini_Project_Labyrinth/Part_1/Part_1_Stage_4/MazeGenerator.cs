namespace Part_1_Stage_4;

public class MazeGenerator
{
    private Random _random = new Random();
    // Розміри поля
    public int Rows { get; private set; } // кількість рядків (довжина гри)
    public int Cols { get; private set; }  // кількість стовпців (ширина гри)

    // Ігрове поле — двовимірний масив рядків (кожна клітинка містить 1-символьний рядок)
    public string[,] GameBoard { get; private set; }

    public MazeGenerator(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
    }
    
    public void InitializeGameBoard()
    {
        // Створюємо масив з поточними розмірами rows x cols
        GameBoard = new string[Rows, Cols];

        // Проходимо кожну клітинку і ставимо "."
        for (int x = 0; x < Rows; x++)
        {
            for (int y = 0; y < Cols; y++)
            {
                GameBoard[x, y] = StaticFields.BackgroundSymbol;
            }
        }
    }
    
    // Виводить ігрове поле в консоль построково
    // Пояснення: для деяких символів (█) ми виводимо символ двічі, щоб візуально вони були квадратніші
    public void PrintGameBoard()
    {
        for (int x = 0; x < Rows; x++)
        {
            for (int y = 0; y < Cols; y++)
            {
                // Якщо символ ширший (щоб краще виглядало), виводимо його двічі без пробілу
                if (GameBoard[x, y] == StaticFields.WallSymbol)
                {
                    // Для стін і дверей повторюємо символ, щоб клітинка виглядала "пустішою
                    Console.Write(GameBoard[x, y] + GameBoard[x, y]);
                }
                else
                {
                    // Інакше виводимо символ + пробіл, щоб вирівнювання виглядало рівномірно
                    Console.Write(GameBoard[x, y] + " ");
                }
            }
            // Після кожного рядка — новий рядок у консолі
            Console.WriteLine();
        }
    }

    // Перевіряє, чи є хоч одна порожня клітинка на полі
    // Пояснення: корисно, щоб уникнути нескінченного рандому при заповненні
    private bool HasEmptyCell()
    {
        // Перебираємо всі символи масиву (в C# foreach проходить по всіх елементах)
        foreach (var symbol in GameBoard)
        {
            // якщо хоч одна точка знайдена — є пусті клітинки
            if (symbol == StaticFields.BackgroundSymbol)
            {
                return true;
            }
        }
        // Якщо ніде не знайшли "." — порожніх клітинок немає
        return false;
    }

    // Створює на полі objCount об'єктів з символом symbolToSpawn
    public void CreateObjects(int objCount, string symbol)
    {
        // Якщо вже немає порожніх клітин — припиняємо спроби (щоб не зациклитись)
        for (int i = 0; i < objCount; i++)
        {
            int x;
            int y;

            do
            {
                if(!HasEmptyCell()) return; // виходимо — більше немає місця
                x = _random.Next(0, Rows); // випадковий рядок
                y = _random.Next(0, Cols);
            } while (GameBoard[x, y] != StaticFields.BackgroundSymbol); // повторюємо поки не знайдемо порожнє місце
            
            GameBoard[x, y] = symbol; // Розміщуємо символ на полі
        }
    }
}
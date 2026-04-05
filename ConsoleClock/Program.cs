using System;
using System.Threading;

class ConsoleClock
{
    static void Main()
    {
        Console.CursorVisible = false;
        int size = 20; // Розмір поля (20x20 символів)
        char[,] canvas = new char[size, size];

        while (true)
        {
            ClearCanvas(canvas, size);
            DateTime now = DateTime.Now;

            // Малюємо обідок годинника
            DrawCircle(canvas, size / 2, size / 2, size / 2 - 1);

            // Розраховуємо кути (у радіанах)
            double secRad = (now.Second * 6 - 90) * Math.PI / 180;
            double minRad = (now.Minute * 6 - 90) * Math.PI / 180;
            double hourRad = ((now.Hour % 12) * 30 + now.Minute * 0.5 - 90) * Math.PI / 180;

            // Малюємо стрілки різними символами
            DrawLine(canvas, size / 2, size / 2, hourRad, size / 4, 'H');   // Годинна (коротка)
            DrawLine(canvas, size / 2, size / 2, minRad, size / 2.5, 'M'); // Хвилинна
            DrawLine(canvas, size / 2, size / 2, secRad, size / 2.2, '.'); // Секундна

            // Виведення на екран
            Console.SetCursorPosition(0, 0);
            Render(canvas, size);
            Console.WriteLine($"\n Поточний час: {now.ToLongTimeString()} ");
            
            Thread.Sleep(1000); // Чекаємо секунду
        }
    }

    static void ClearCanvas(char[,] canvas, int size)
    {
        for (int y = 0; y < size; y++)
            for (int x = 0; x < size; x++)
                canvas[y, x] = ' ';
    }

    static void DrawLine(char[,] canvas, int cx, int cy, double angle, double length, char symbol)
    {
        for (int i = 0; i <= length; i++)
        {
            int x = (int)(cx + i * Math.Cos(angle) * 1.5); // *1.5 бо символи в консолі вузькі
            int y = (int)(cy + i * Math.Sin(angle));
            if (x >= 0 && x < canvas.GetLength(1) && y >= 0 && y < canvas.GetLength(0))
                canvas[y, x] = symbol;
        }
    }

    static void DrawCircle(char[,] canvas, int cx, int cy, int r)
    {
        for (int i = 0; i < 360; i += 10)
        {
            double angle = i * Math.PI / 180;
            int x = (int)(cx + r * Math.Cos(angle) * 1.5);
            int y = (int)(cy + r * Math.Sin(angle));
            if (x >= 0 && x < canvas.GetLength(1) && y >= 0 && y < canvas.GetLength(0))
                canvas[y, x] = '#';
        }
    }

    static void Render(char[,] canvas, int size)
    {
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
                Console.Write(canvas[y, x] + " ");
            Console.WriteLine();
        }
    }
}
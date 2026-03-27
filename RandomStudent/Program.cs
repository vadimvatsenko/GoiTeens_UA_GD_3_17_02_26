using System;

public class Program
{
    public static void Main()
    {
        
        Dictionary<string, int> studentQA = new Dictionary<string, int>()
        {
            ["Henenko Bohdan"] = 0,
            ["Kyrdan Yaroslav"] = 0,
            ["Konopchuk Kostiantyn"] = 0,
            ["Matvii Zbozhnyi"] = 0,
            ["Nochkovskyi Dmytro"] = 0,
            ["Prashchuk Viktoriia"] = 0,
            ["Pushkaruk Illia"] = 0,
            ["Ryndin Oleksandr"] = 0,
            ["Serhii Fomenko"] = 0,
            ["Solomenko Diana"] = 0,
            ["Tymur Hryshchenko"] = 0,
            ["Shevchuk Vsevolod"] = 0,
            ["Shumyliak Yurii"] = 0,
        };
        Random rnd = new Random();
        
        Console.WriteLine("Enter menu \n1 - Random Student \n2 - Task Random");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                string student = studentQA.Keys.ElementAt(option);
                Console.WriteLine($"{student}");
                break;
            case 2:
                Console.Write("Enter count of task: ");
                int count = int.Parse(Console.ReadLine());
                
                foreach (var st in studentQA)
                {
                    int numbQA = rnd.Next(1, count + 1);
                    
                    studentQA[st.Key] = numbQA;
                }

                Console.WriteLine();
        
                foreach (var st in studentQA)
                {
                    Console.WriteLine($"{st.Key}: {st.Value}");
                }

                break; 
        }
        
        Console.ReadKey();
    }
}
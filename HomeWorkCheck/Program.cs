using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] scores = GetLeaderboard();
            Console.WriteLine($"Максимальный счет: {scores.Max()}");

            
            string[] treasures = GetTreasures();
            foreach (string treasure in treasures)
            {
                Console.WriteLine($"Найдено: {treasure}");
            }

            
            List<string> spells = GetSpells();
            Console.WriteLine($"Первое заклинание: {spells[0]}");

            
            if (DivideCoins(100, 5, out int coins))
                Console.WriteLine($"Монети поділено: по {coins} на кожного.");
            else
                Console.WriteLine("Помилка ділення монет.");


            if (SplitPotion(10, 3, out int potions))
                Console.WriteLine($"Зілля поділено: по {potions} на кожного.");
            else
                Console.WriteLine("Помилка поділу зілля.");


            if (DividePoints(50, 2, out int points))
                Console.WriteLine($"Бали поділено: по {points} на кожного.");
            else
                Console.WriteLine("Помилка ділення балів.");
        }

        // 1️ Функція 
         public static bool DivideCoins(int totalCoins, int friends, out int coinsPerFriend)
         {
            if (friends <= 0)
            {
                coinsPerFriend = 0;
                return false;
            }
            coinsPerFriend = totalCoins / friends;
            return true;
         }

        // 2️ Функція 
         public static bool SplitPotion(int totalPotions, int partyMembers, out int potionsPerMember)
         {
            if (partyMembers <= 0)
            {
                potionsPerMember = 0;
                return false;
            }
            potionsPerMember = totalPotions / partyMembers;
            return true;
         }

        // 3️ Функція 
         public static bool DividePoints(int points, int players, out int pointsPerPlayer)
         {
            if (players <= 0)
            {
                pointsPerPlayer = 0;
                return false;
            }
            pointsPerPlayer = points / players;
            return true;
         }


        static int[] GetLeaderboard()
        {
            return new int[] { 250, 180, 120 };
        }

        
        static string[] GetTreasures()
        {
            return new string[] { "Кольцо", "Корона", "Алмаз" };
        }

        
        static List<string> GetSpells()
        {
            return new List<string> { "Огонь", "Лед", "Молния" };
        }
    }
}

// Актуалізація знань - Кахут (10хв)
// Проблеми з ДЗ (15хв)

// Табличка, хто здав, хто не здав
// Пройтись по ДЗ, 
// Диана 
// Тимур
// Урок №7 Порівняльні оператори.
// Урок №8 Умовні вирази if, if-else Урок
// Урок №10 Вирази else if. Тернарний оператор.
// 1 Ви не читаєте, що я вам пишу у ДЗ
// 2 Пояснення, що до здачі ДЗ
// 3 Пройтися по боргах ДЗ


// Цикл у перед
// Цикл назад
// break
// continue
// табличка множення


namespace Lesson_13_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            List<Enemy> enemies = new List<Enemy>()
            {
                new Enemy("Olya", 100, rand.Next(0, 6)), // 0
                new Enemy("Anton", 100, rand.Next(0, 6)), // 1
                new Enemy("Yura", 100, rand.Next(0, 6)), // 2
                new Enemy("Dima", 100, rand.Next(0, 6)), // 3
                new Enemy("Illya", 100, rand.Next(0, 6)), // 4
            };

            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].ShowInfo();
            }
            
            Player player = new Player();
            
            for (int i = 0; i < enemies.Count; i++)
            {
                if ((enemies[i].PositionX - player.PositionX) <= 2)
                {
                    player.Attack(enemies[i], rand.Next(0, 101));
                }
            }
            
            Console.WriteLine();
            
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].ShowInfo();
            }
            
            Console.ReadKey();
        }
    }

    public class Player
    {
        public int PositionX { get; private set; } = 0;

        public void Attack(Enemy enemy, int damage)
        {
            enemy.TakeDamage(damage);
        }
    }

    public class Enemy
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        
        public int PositionX { get; private set; }

        public Enemy(string name, int health, int positionX)
        {
            Name = name;
            Health = health;
            PositionX = positionX;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if(Health <= 0)
            {
                Health = 0;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name {Name}, Health: {Health}, PositionX: {PositionX}");
        }
    }
}





using System;

namespace WeaponsGame
{
    class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        protected int usageCount = 0;

        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }

        public virtual void Attack()
        {
            usageCount++;
            double fatigue = 1 - (usageCount * 0.1);
            if (fatigue < 0.5) fatigue = 0.5;

            int finalDamage = (int)(Damage * fatigue);
            Console.WriteLine($"{Name} атакує на {finalDamage}");
        }

        public virtual void DisplayWeaponStats()
        {
            Console.WriteLine($"Зброя: {Name}, Шкода: {Damage}");
        }
    }

    class Sword : Weapon
    {
        public double BladeLength { get; set; }
        public bool IsSharpened { get; set; } = false;

        public Sword(string name, int damage, double bladeLength)
            : base(name, damage)
        {
            BladeLength = bladeLength;
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine($"Лезо: {BladeLength} см");
        }

        public void SpecialAttack()
        {
            Console.WriteLine($"Спец атака: {Damage * 2}");
        }

        public void Sharpen()
        {
            if (!IsSharpened)
            {
                Damage += 10;
                IsSharpened = true;
            }
        }

        public override void DisplayWeaponStats()
        {
            base.DisplayWeaponStats();
            Console.WriteLine($"Лезо: {BladeLength}, Заточений: {IsSharpened}");
        }
    }

    class Bow : Weapon
    {
        public int ArrowCount { get; set; }
        private int maxArrows;

        public Bow(string name, int damage, int arrows)
            : base(name, damage)
        {
            ArrowCount = arrows;
            maxArrows = arrows;
        }

        public override void Attack()
        {
            if (ArrowCount > 0)
            {
                ArrowCount--;
                base.Attack();
                Console.WriteLine($"Стріли: {ArrowCount}");
            }
            else
            {
                Console.WriteLine("Немає стріл");
            }
        }

        public void SpecialAttack()
        {
            Console.WriteLine($"Масова шкода: {Damage * ArrowCount}");
            ArrowCount = 0;
        }

        public void Reload()
        {
            ArrowCount = maxArrows;
        }

        public override void DisplayWeaponStats()
        {
            base.DisplayWeaponStats();
            Console.WriteLine($"Стріли: {ArrowCount}/{maxArrows}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sword sword = new Sword("Меч", 30, 80);
            Bow bow = new Bow("Лук", 15, 5);

            sword.DisplayWeaponStats();
            bow.DisplayWeaponStats();

            sword.Attack();
            sword.Sharpen();
            sword.SpecialAttack();

            bow.Attack();
            bow.SpecialAttack();
            bow.Reload();
            bow.Attack();
        }
    }
}
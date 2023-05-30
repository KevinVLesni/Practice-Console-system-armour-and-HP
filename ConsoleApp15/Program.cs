using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            float health;
            int armour;
            int damage;
            int precentConverter = 100;

            Console.Write("Введите количество здоровья: ");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество брони: ");
            armour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= Convert.ToSingle(damage) / precentConverter * armour;

            Console.WriteLine($"Вам нанесли {damage} урона. " +
                $"У вас осталось {health} здоровья.");
            Console.Read();
        }
    }
} 
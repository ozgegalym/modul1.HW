using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше  имя: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите ваше Фамилию: ");
            string SecondName = Console.ReadLine();

            Console.WriteLine("Введите ваше Отчество: ");
            string middleName = Console.ReadLine();

            Console.WriteLine("Приветствую тебя - " + SecondName + " " + firstName + " " + middleName);

            Console.WriteLine("Введите количество чисел:");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("Ошибка! Введите положительное целое число.");
            }

            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите число {i + 1}:");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Ошибка! Введите корректное целое число.");
                }
                sum += number;
            }

            Console.WriteLine($"Сумма введенных чисел: {sum}");
            Console.ReadKey();
        }
    }
}

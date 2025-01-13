using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            if (!TryInputNumber("Введите число n", out n))
            {
                Console.ReadKey();
                return;
            }

            if (n < 1)
            {
                Console.WriteLine("Число n должно быть натуральным");
                Console.ReadKey();
                return;
            }

            int count = 0; // Счётчик найденных простых чисел
            int number = 0; // Начальное число для проверки

            Console.WriteLine($"Первые {n} простых чисел:");

            while (count < n)
            {
                for (number = 1; number <= n; number++)
                {
                    Console.Write(number + " ");
                    count++;
                }
                number++;
            }

            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
        }
    }
}
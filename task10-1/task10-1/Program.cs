using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m");
            int m;

            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите целое число n");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (n >= 20 || m > n || m < 1)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству 1 <= m <= n < 20");
                Console.ReadKey();
                return;
            }

            var product = 1;

            for (int i = m; i <= n; i++)
                product *= i;

            Console.WriteLine($"Произведение чисел от {m} до {n} равно {product}");

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = a;
            return true;
        }
    }
}
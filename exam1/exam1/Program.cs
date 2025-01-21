using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperBorder = 10000000;

            Console.WriteLine("Данная программа ищет числа от 10 до 10 млн, которые равны\n" +
                "сумме своих цифр, возведенных в n-ую степень.\n");
            Console.WriteLine("(Заметка: для лучшей работы программы пришлось сократить диапазон\n" +
                "с 1 млрд до 10 млн, иначе очень долго производятся расчеты!)\n");

            for (int n = 4; n <= 7; n++)
            {
                Console.WriteLine($"Список таких чисел для для n = {n}:");

                List<int> result = SearchForRightNumbers(n, upperBorder);

                foreach (var number in result)
                {
                    Console.WriteLine(number);
                }

                int sum = 0;
                foreach (var number in result)
                {
                    sum += number;
                }
                Console.WriteLine($"Сумма чисел для n = {n}: {sum}\n");

            }

            Console.ReadKey();
        }


        static int SumOfPowersOfDigits(int number, int n)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, n);
                number /= 10;
            }
            return sum;
        }

        static List<int> SearchForRightNumbers(int n, int upperBorder)
        {
            List<int> searchResult = new List<int>();

            for (int i = 10; i < upperBorder; i++)
            {
                if (i == SumOfPowersOfDigits(i, n))
                {
                    searchResult.Add(i);
                }
            }
            return searchResult;
        }

    }
}

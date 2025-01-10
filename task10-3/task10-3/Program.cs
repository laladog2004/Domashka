using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;

            Console.WriteLine("Введите число a (1 < a <= 2)");

            while (true)
            {
                string input = Console.ReadLine();

                if (double.TryParse(input, out a))
                {
                    if (a > 1 && a <= 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Число должно быть больше 1 и не больше 2. Попробуйте снова.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введите число.");
                }
            }


            bool first = true;
            for (int n = 1; ; n++)
            {
                double currentValue = 1 + 1 / Math.Sqrt(n);

                if (currentValue < a)
                {
                    continue;
                }

                if (!first)
                    Console.Write("; ");
                Console.Write($"1 + 1/√{n}");

                first = false;
            }


        }

        
    }

}
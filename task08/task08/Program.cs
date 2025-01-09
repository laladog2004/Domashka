using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента функции:");
            
            char x = char.Parse(Console.ReadLine());

            if (Char.IsNumber(x) == false)
                Console.WriteLine("Неверный формат значения аргумента функции.");

            else if (Char.IsNumber(x) == true)
                Console.WriteLine($"f({x}) = {MyFunction(x)}");

            Console.ReadKey();
        }

        static double MyFunction(double x)
        {
            if (Math.Abs(x) > 1)
                return 1;
            else if (0 < Math.Abs(x) && Math.Abs(x) < 1)
                return Math.Abs(x);
            else if (x == 0)
                return 2;

            return Math.Acos(x);
        }
    }
}